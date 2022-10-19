using System.Collections.Generic;

namespace UniApp.Models;
public class Repository : IRepository
{
    private Dictionary<int, Booking> _items;

    public Repository()
    {
        _items = new Dictionary<int, Booking>();
        new List<Booking>
        {
            new() {BookingId = 1, Name = "John Smith", StartLocation = "São Paulo", EndLocation = "Salvador"},
            new() {BookingId = 2, Name = "Jane Doe", StartLocation = "Porto Alegre", EndLocation = "São Paulo"},
            new() {BookingId = 3, Name = "Robert Pulsen", StartLocation = "Portugal", EndLocation = "Germany"},
            new() {BookingId = 4, Name = "Tyler Durden", StartLocation = "New York", EndLocation = "Piauí"},
        }.ForEach(b => AddSchedule(b));
    }

    public Booking this[int id] => _items.ContainsKey(id) ? _items[id] : null;
    public IEnumerable<Booking> Bookings => _items.Values;

    public Booking AddSchedule(Booking booking)
    {
        if (booking.BookingId == 0)
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