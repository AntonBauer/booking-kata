using BookingKata.Domain.Entities.Clients;
using BookingKata.Domain.Entities.Rooms;

namespace BookingKata.Domain.Entities.Bookings;

public sealed class Booking : Entity<BookingId, Guid>
{
  public Client Client { get; }
  public Room Room { get; }
  public DateRange Dates { get; }

  private Booking(BookingId id, Client client, Room room, DateRange dates) : base(id) =>
    (Client, Room, Dates) = (client, room, dates);

  public static Booking Create(Client client, Room room, DateRange dates) =>
    new(BookingId.Empty, client, room, dates);
}