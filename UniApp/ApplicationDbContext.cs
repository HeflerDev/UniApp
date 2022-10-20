using Microsoft.EntityFrameworkCore;
using UniApp.Models;

namespace UniApp;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
     
   }
   public DbSet<Booking> Bookings { get; set; }
}
