using BookingKata.Domain.CommonTypes;

namespace BookingKata.Domain.Entities.Rooms;

public sealed class BookedRoom : Room
{
  internal BookedRoom(RoomId id, NonEmptyString name) : base(id, name, RoomStatus.Booked) { }

  public FreeRoom Free() => new(Id, Name);
}