using BookingKata.Domain.Entities.Rooms;

namespace BookingKata.Infrastructure.RoomServices.Administration;

public interface IRoomAdministrationService
{
  public Task<Room> Create(string name, CancellationToken cancellationToken);
  public Task<Room> Read(RoomId roomId, CancellationToken cancellationToken);
  public Task<Room> Update(RoomId roomId, string name, CancellationToken cancellationToken);
  public Task Delete(RoomId roomId, CancellationToken cancellationToken);
}