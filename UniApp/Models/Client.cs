using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UniApp.Models;

public class Client
{
    [Key]
    public int ClientId { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Name { get; set; }
    [MinLength(3)]
    [MaxLength(20)]
    [Required]
    public string Email { get; set; }
    public List<Booking>? Bookings { get; set; }
}