using Microsoft.EntityFrameworkCore;
using UniApp.Models;

namespace UniApp;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
     
   }
   public DbSet<Client> Client { get; set; }
   public DbSet<Booking> Booking { get; set; }

   protected override void OnModelCreating(ModelBuilder builder)
   {
       builder.Entity<Client>().ToTable("Client");
       builder.Entity<Booking>().ToTable("Booking");
   }
}
