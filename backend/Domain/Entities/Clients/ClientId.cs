namespace BookingKata.Domain.Entities.Clients;

public record ClientId : Id<Guid>
{
  public static ClientId Empty { get; } = new(Guid.Empty);

  private ClientId(Guid value) : base(value) { }

  public static ClientId Create(Guid value) => new(value);
}