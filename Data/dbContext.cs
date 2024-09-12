using aplicacionInventario4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aplicacionInventario4.Data
{
    public class dbContext : DbContext
    {
      public dbContext(DbContextOptions <dbContext> options) : base(options)
      {
        //sajdp
      }
      public DbSet<Categoria> Categorias { get; set; } = null!;
      public DbSet<Material> Materials { get; set; } = null!;

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
        //sd
      }
    }
}
