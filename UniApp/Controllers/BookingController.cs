using Microsoft.AspNetCore.Mvc;
using UniApp.Models;

namespace UniApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookingController : Controller
{
    private readonly ApplicationDbContext _context;
    public BookingController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public dynamic Get()
    {
        var  bookings = _context?.Booking?.ToList();
        if (bookings is not null)
        {
            return bookings;
        }

        return NotFound();
    }

    [HttpGet("{id}")]
    public Booking Get(int id)
    {
        return _context.Booking.Single(b => b.BookingId == id);
    }

    [HttpPost]
    public async Task<ActionResult<Booking>> Post([FromBody] Booking booking){
        if (ModelState.IsValid)
        {
            int clientId = booking.ClientId;
            booking.Client = _context.Client.Single(c => c.ClientId == clientId);
            
            _context.Booking.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        return NotFound();
    }

    [HttpPut("{id}")]
    public StatusCodeResult Put(Booking booking, int id)
    {
        var entity = _context.Booking.FirstOrDefault(item => item.BookingId == id);

        if (entity != null)
        {
            entity.Name = booking.Name;
            entity.EndLocation = booking.EndLocation;
            entity.StartLocation = booking.StartLocation;

            _context.SaveChanges();
            return Ok();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public StatusCodeResult Delete(int id)
    {
        var bookings = _context.Booking.FirstOrDefault(b => b.BookingId == id);
        if (bookings != null)
        {
            _context.Booking.Remove(bookings);
            _context.SaveChanges();
            return Ok();
        }

        return NotFound();
    }
}