using BookingKata.Domain.Entities.Bookings;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal sealed class BookingEntityConfiguration : IEntityTypeConfiguration<Booking>
{
  public void Configure(EntityTypeBuilder<Booking> builder)
  {
    builder.HasKey(booking => booking.Id);

    builder.Property(booking => booking.Id)
           .HasConversion(bookingId => bookingId.Value, value => BookingId.Create(value));

    builder.HasOne(booking => booking.Client)
           .WithMany()
           .OnDelete(DeleteBehavior.Cascade);

    builder.ComplexProperty(booking => booking.Dates);
  }
}