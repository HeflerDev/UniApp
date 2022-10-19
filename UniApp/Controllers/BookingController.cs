using Microsoft.AspNetCore.Mvc;
using UniApp.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;

namespace UniApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookingController : Controller
{
    private IRepository _repository;
    public BookingController(IRepository repo) => _repository = repo;

    [HttpGet]
    public IEnumerable<Booking> Get() => _repository.Bookings;

    [HttpGet("{id}")]
    public Booking Get(int id) => _repository[id];

    [HttpPost]
    public Booking Post([FromBody] Booking book) =>
        _repository.AddSchedule(new Booking
        {
            Name = book.Name,
            StartLocation = book.StartLocation,
            EndLocation =  book.EndLocation
        });

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