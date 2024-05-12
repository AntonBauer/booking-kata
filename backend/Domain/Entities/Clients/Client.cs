using BookingKata.Domain.CommonTypes;

namespace BookingKata.Domain.Entities.Clients;

public sealed class Client : Entity<ClientId, Guid>
{
  public NonEmptyString Name { get; }

  private Client(ClientId id, NonEmptyString name) : base(id) =>
    Name = name;

  public static Client Create(string name)
  {
    var clientName = NonEmptyString.Create(name);
    return new(ClientId.Empty, clientName);
  }
}