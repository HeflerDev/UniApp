using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.AspNetIdentity;
using Microsoft.EntityFrameworkCore.TestModels.MusicStore;
using MySqlX.XDevAPI;
using UniApp.Models;

namespace UniApp;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
   public DbSet<Booking> Bookings { get; set; }
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
      
   }
}