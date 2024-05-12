using System.Collections.Immutable;

using BookingKata.Domain.CommonTypes;
using BookingKata.Domain.Entities.Bookings;

namespace BookingKata.Domain.Entities.Rooms;

public sealed class Room : Entity<RoomId, Guid>
{
  private readonly ImmutableHashSet<Booking> _bookings = [];

  public NonEmptyString Name { get; }

  private Room(RoomId id, NonEmptyString name) : base(id) =>
    Name = name;

  public static Room Create(string name)
  {
    var roomName = NonEmptyString.Create(name);
    return new(RoomId.Empty, roomName);
  }
}