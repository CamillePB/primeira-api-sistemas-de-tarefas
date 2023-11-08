using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Models;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace PrimeiraApi.Data
{
    //facilitador para trablhar com qualquer banco de dados
    public class SistemaTarefasDBContext : DbContext
    {
        //conexao com o bd
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options)
        {
        }

        //tabelas no bd
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
