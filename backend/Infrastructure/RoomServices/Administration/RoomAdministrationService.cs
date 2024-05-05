using BookingKata.Domain.Entities.Rooms;

namespace BookingKata.Infrastructure.RoomServices.Administration;

internal sealed class RoomAdministrationService(BookingContext _context) : IRoomAdministrationService
{
  public async Task<FreeRoom> Create(string name, CancellationToken cancellationToken)
  {
    var room = Room.Create(name);

    await _context.Rooms.AddAsync(room, cancellationToken);
    await _context.SaveChangesAsync();

    return room;
  }

  public async Task Delete(RoomId roomId, CancellationToken cancellationToken)
  {
    var room = await _context.Rooms.FindAsync([roomId], cancellationToken);

    if (room is not null)
    {
      _context.Rooms.Remove(room);
      await _context.SaveChangesAsync();
    }
  }

  public async Task<Room> Read(RoomId roomId, CancellationToken cancellationToken)
  {
    var room = await _context.Rooms.FindAsync([roomId], cancellationToken);
    return room;
  }

  public Task<Room> Update(RoomId roomId, string name, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}