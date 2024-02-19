using Microsoft.EntityFrameworkCore;

namespace MycoMatrix.Models;

public class MycoMatrixContext : DbContext
{
  public DbSet<Mushroom> Mushrooms { get; set; }

  public MycoMatrixContext(DbContextOptions<MycoMatrixContext> options) : base(options)
  {
    
  }

  // protected override void OnModelCreating(ModelBuilder builder)
  //   {
  //     builder.Entity<Mushroom>()
  //       .HasData(
  //         null
  //       );
  //   }
}
