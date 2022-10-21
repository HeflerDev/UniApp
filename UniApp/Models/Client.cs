using System.ComponentModel.DataAnnotations;

namespace UniApp.Models;

public class Client
{
   [Key]
   public int ClientId { get; set; }
   [Required]
   [StringLength(31)]
   public string Name { get; set; }
   [Required]
   [StringLength(100)]
   public string Email { get; set; } 
   [Range(18, 105)]
   public int Age { get; set; }
   public List<Booking> Bookings { get; set; }
}