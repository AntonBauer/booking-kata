using BookingKata.Domain.Entities.Clients;
using BookingKata.Domain.Entities.Rooms;

using Microsoft.EntityFrameworkCore;

internal sealed class BookingContext(DbContextOptions<BookingContext> options) : DbContext(options)
{
  public DbSet<Room> Rooms => Set<Room>();

  public DbSet<Client> Clients => Set<Client>();

  protected override void OnModelCreating(ModelBuilder modelBuilder) =>
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookingContext).Assembly)
                .HasDefaultSchema("booking");
}