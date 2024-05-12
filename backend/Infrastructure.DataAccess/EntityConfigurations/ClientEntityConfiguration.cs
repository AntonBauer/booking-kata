using BookingKata.Domain.CommonTypes;
using BookingKata.Domain.Entities.Clients;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.EntityConfigurations;

internal sealed class ClientEntityConfiguration : IEntityTypeConfiguration<Client>
{
  public void Configure(EntityTypeBuilder<Client> builder)
  {
    builder.HasKey(client => client.Id);

    builder.Property(client => client.Id)
           .HasConversion(clientId => clientId.Value, value => ClientId.Create(value));

    builder.Property(client => client.Name)
           .IsRequired()
           .HasConversion(name => name.Value, value => NonEmptyString.Create(value));
  }
}