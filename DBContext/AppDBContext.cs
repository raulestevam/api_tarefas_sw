using api_tarefas.Models;
using Microsoft.EntityFrameworkCore;
namespace api_tarefas.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions <AppDBContext> options): base (options) { } //metodo construtor para conexao com bd
        public DbSet <Usuario> usuarios { get; set; }
        public DbSet <Tarefa> tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //personaliza as consultas no bd
        {
            modelBuilder.Entity<Tarefa>() 
                .HasOne(t => t.usuario) //tarefa tem relação 1 pra 1 com user
                .WithMany(u => u.tarefas) //user pra varias task
                .HasForeignKey(t => t.fk_usuario) //relação task com foreign user 
                .OnDelete(DeleteBehavior.Restrict); //delete primeiro tarefas
            base.OnModelCreating(modelBuilder);
        }
    }
}
