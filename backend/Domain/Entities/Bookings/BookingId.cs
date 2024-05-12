namespace BookingKata.Domain.Entities.Bookings;

public record BookingId : Id<Guid>
{
  public static BookingId Empty { get; } = new(Guid.Empty);

  private BookingId(Guid value) : base(value) { }

  public static BookingId Create(Guid value) => new(value);
}