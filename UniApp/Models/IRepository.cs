namespace UniApp.Models;

public interface IRepository
{
    IEnumerable<Booking> Bookings { get; }
    Booking this[int id] { get; }
    Booking AddSchedule(Booking booking);
    Booking UpdateBooking(Booking booking);
    void DeleteBooking(int id);
}