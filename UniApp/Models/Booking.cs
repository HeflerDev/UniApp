using System.ComponentModel.DataAnnotations;

namespace UniApp.Models;

public class Booking
{
    [Required]
    public int BookingId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string StartLocation { get; set; }
    [Required]
    public string EndLocation { get; set; }
}