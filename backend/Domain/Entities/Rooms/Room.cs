using BookingKata.Domain.CommonTypes;

namespace BookingKata.Domain.Entities.Rooms;

public record Room : Entity<Guid>
{
  public NonEmptyString Name { get; }

  private Room(RoomId id, NonEmptyString name) : base(id) => Name = name;

  public static Room Create(string name)
  {
    var nonEmptyName = NonEmptyString.Create(name);
    return new(RoomId.Create(Guid.NewGuid()), nonEmptyName);
  }
}