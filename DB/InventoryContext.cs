using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) 
        { 

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Material> Materiales { get; set; }
         
    }
}
