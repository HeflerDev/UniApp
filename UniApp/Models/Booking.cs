using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniApp.Models;

public class Booking
{
    [Key]
    public int BookingId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string StartLocation { get; set; }
    [Required]
    public string EndLocation { get; set; }
    [ForeignKey("Client")]
    public int ClientId { get; set; }
    public Client? Client { get; set; }
}