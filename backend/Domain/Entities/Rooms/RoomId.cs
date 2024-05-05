namespace BookingKata.Domain.Entities.Rooms;

public record RoomId : Id<Guid>
{
  private RoomId(Guid value) : base(value) { }

  public static RoomId Create(Guid value) => new(value);
}