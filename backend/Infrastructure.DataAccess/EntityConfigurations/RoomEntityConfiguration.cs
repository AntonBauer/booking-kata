using BookingKata.Domain.CommonTypes;
using BookingKata.Domain.Entities.Bookings;
using BookingKata.Domain.Entities.Rooms;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal sealed class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
{
  public void Configure(EntityTypeBuilder<Room> builder)
  {
    builder.HasKey(room => room.Id);

    builder.Property(room => room.Id)
           .HasConversion(roomId => roomId.Value,
                          value => RoomId.Create(value));

    builder.Property(room => room.Name)
            .HasConversion(name => name.Value,
                           value => NonEmptyString.Create(value))
           .IsRequired();

    builder.HasMany<Booking>("_bookings")
           .WithOne(booking => booking.Room)
           .IsRequired()
           .OnDelete(DeleteBehavior.Cascade);
  }
}