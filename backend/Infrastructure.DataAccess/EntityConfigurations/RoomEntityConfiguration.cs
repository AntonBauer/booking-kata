using BookingKata.Domain.CommonTypes;
using BookingKata.Domain.Entities.Bookings;
using BookingKata.Domain.Entities.Rooms;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.EntityConfigurations;

internal sealed class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
{
  public void Configure(EntityTypeBuilder<Room> builder)
  {
    builder.HasKey(room => room.Id);

    builder.Property(room => room.Id)
           .HasConversion(roomId => roomId.Value, value => RoomId.Create(value));

    builder.Property(room => room.Name)
           .IsRequired()
           .HasConversion(name => name.Value, value => NonEmptyString.Create(value));

    builder.HasMany<Booking>("_bookings")
           .WithOne(booking => booking.Room)
           .IsRequired()
           .OnDelete(DeleteBehavior.Cascade);
  }
}