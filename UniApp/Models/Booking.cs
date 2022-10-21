using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniApp.Models;

public class Booking
{
    public int BookingId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string StartLocation { get; set; }
    [Required]
    public string EndLocation { get; set; }
    
    public int ClientId { get; set; }
    public Client Client { get; set; }
}