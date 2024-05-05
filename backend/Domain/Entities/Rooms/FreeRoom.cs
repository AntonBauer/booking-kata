using BookingKata.Domain.CommonTypes;

namespace BookingKata.Domain.Entities.Rooms;

public sealed class FreeRoom : Room
{
  internal FreeRoom(RoomId id, NonEmptyString name) : base(id, name, RoomStatus.Free) { }

  public BookedRoom Book() => new(Id, Name);
}