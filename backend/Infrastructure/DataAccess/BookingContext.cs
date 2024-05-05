using BookingKata.Domain.Entities.Rooms;

using Microsoft.EntityFrameworkCore;

internal sealed class BookingContext(DbContextOptions<BookingContext> options) : DbContext(options)
{
  public DbSet<Room> Rooms => Set<Room>();
}