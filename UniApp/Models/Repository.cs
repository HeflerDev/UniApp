using System.Collections.Generic;
using System.Data.SqlClient;

namespace UniApp.Models;
public class Repository : IRepository
{
    private readonly ApplicationDbContext _context;
    public Booking Index(Booking booking)
    {
        return booking;
    }
    
    public Booking this[int id] => _items.ContainsKey(id) ? _items[id] : null;
    public IEnumerable<Booking> Bookings => _items.Values;

    public Booking AddSchedule(Booking booking)
    {
        {
            int key = _items.Count;
            while (_items.ContainsKey(key))
            {
                key++;
            }
            booking.BookingId = key;
        }

        _items[booking.BookingId] = booking;
        return booking;
    }

    public Booking UpdateBooking(Booking booking)
    {
        AddSchedule(booking);
        return booking;
    }

    public void DeleteBooking(int id)
    {
        _items.Remove(id);
    }
}