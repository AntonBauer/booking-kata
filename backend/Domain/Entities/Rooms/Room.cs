using BookingKata.Domain.CommonTypes;

namespace BookingKata.Domain.Entities.Rooms;

public abstract class Room(RoomId id, NonEmptyString name, RoomStatus status) : Entity<RoomId, Guid>(id)
{
  public NonEmptyString Name => name;

  public static FreeRoom Create(string name)
  {
    var roomName = NonEmptyString.Create(name);

    return new FreeRoom(RoomId.Create(Guid.Empty),
                        roomName);
  }
}