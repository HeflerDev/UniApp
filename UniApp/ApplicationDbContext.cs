using Microsoft.EntityFrameworkCore;
using UniApp.Models;

namespace UniApp;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
     
   }
   public DbSet<Booking> Booking { get; set; }
   public DbSet<Client> Client { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Booking>().ToTable("Booking");
      modelBuilder.Entity<Client>().ToTable("Client");
   }
}
