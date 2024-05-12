namespace BookingKata.Domain.Entities.Rooms;

public record RoomId : Id<Guid>
{
  public static RoomId Empty { get; } = new(Guid.Empty);

  private RoomId(Guid value) : base(value) { }

  public static RoomId Create(Guid value) => new(value);
}