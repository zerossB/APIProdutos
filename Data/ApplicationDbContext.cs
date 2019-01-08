using Microsoft.EntityFrameworkCore;
using APIProdutos.Models;
using JetBrains.Annotations;

namespace APIProdutos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :
            base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.CodigoBarras);
            modelBuilder.Entity<Usuario>()
                .HasKey(p => p.ID);
        }
    }
}