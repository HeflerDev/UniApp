using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.AspNetIdentity;
using Microsoft.EntityFrameworkCore.TestModels.MusicStore;
using UniApp.Models;

namespace UniApp;

public class ApplicationDbContext : IdentityDbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
     
   }
   public DbSet<Booking> Bookings { get; set; }
}
