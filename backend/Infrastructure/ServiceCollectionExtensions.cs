using BookingKata.Infrastructure.RoomServices.Administration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookingKata.Infrastructure;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddDomainServices(this IServiceCollection services,
                                                     IConfiguration configuration) =>
    services.AddDataAccess(configuration)
            .AddRoomServices();

  private static IServiceCollection AddRoomServices(this IServiceCollection services) =>
    services.AddScoped<IRoomAdministrationService, RoomAdministrationService>();

  private static IServiceCollection AddDataAccess(this IServiceCollection services,
                                                  IConfiguration configuration) =>
    services.AddNpgsql<BookingContext>(string.Empty);
}