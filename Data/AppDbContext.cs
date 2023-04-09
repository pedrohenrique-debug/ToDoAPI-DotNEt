
using MeuTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Data
{   // AppDbContext nada mais é do que o contexto de dados de nossa aplicação. O contexto de dados ou data context nada mais é do que a representação do nosso banco de memoria. Então basicamente a gente usa esse arquivo para dizer que classe X vai ser tabela Y no banco, classe y vai ser tabela Z no banco e assim por diante. Então a gente mapeia tudo por dentro desse arquivo aqui.
    public class AppDbContext : DbContext  
    {
        //Se o nosso dbset (AppDbContext e DBContext) é a representação do banco de dados em memória.
        // O nosso DbSet é a representação da nossa tabela
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}