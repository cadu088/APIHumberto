using Aula01.Data.Mappings;
using Aula01.Domain;
using Microsoft.EntityFrameworkCore;

namespace Aula01.Data
{
	public class GestaoCategoriaContext : DbContext
    {
        public GestaoCategoriaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
           
        }
    }
}
