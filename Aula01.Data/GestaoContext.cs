using Aula01.Data.Mappings;
using Aula01.Domain;
using Microsoft.EntityFrameworkCore;

namespace Aula01.Data
{
	public class GestaoContext : DbContext
    {
        public GestaoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
