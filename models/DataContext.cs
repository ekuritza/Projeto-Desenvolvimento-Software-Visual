using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    // Entity Framework Code First
    // É a classe que define a estrutura do banco de dados
    public class DataContext : DbContext   // Criar Herança para trabalhar com o banco
    {
        // Estabelecer conexão com o banco
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Definir quais as classes de modelo servirão para as tabelas no banco de dados
        public DbSet<Morador> moradores { get; set; } // Sempre DbSet e o nome da classe no plural
         public DbSet<Vagas> vagas { get; set; }

    }
}
