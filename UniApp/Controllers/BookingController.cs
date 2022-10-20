using System.Net;
using Microsoft.AspNetCore.Mvc;
using UniApp.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace UniApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookingController : Controller
{
    private readonly ApplicationDbContext _context;
    public BookingController() {}

    [HttpGet]
    public IEnumerable<Booking> Get()
    {
        return _context.Bookings;
    }

    [HttpGet("{id}")]
    public IQueryable<Booking> Get(int id)
    {
        return _context.Bookings.Where(b => b.BookingId == id);
    }

    [HttpPost]
    public async Task<ActionResult<Booking>> Post(Booking booking){
        if (ModelState.IsValid)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return Ok();
        }

        return NotFound();
    }

    [HttpPut]
    public Booking Put([FromForm] Booking book) => _repository.UpdateBooking(book);

    [HttpPatch("{id}")]
    public StatusCodeResult Patch(int id, [FromForm] JsonPatchDocument<Booking> patch)
    {
        Booking book = Get(id);
        if (book != null)
        {
            patch.ApplyTo(book);
            return Ok();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public void Delete(int id) => _repository.DeleteBooking(id);
}