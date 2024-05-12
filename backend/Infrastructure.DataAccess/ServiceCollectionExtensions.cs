using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DataAccess;

public static class ServiceCollectionExtensions
{
  internal const string ConnectionStringName = "BookingConnection";

  public static IServiceCollection AddDataAccess(this IServiceCollection services,
                                                 IConfiguration configuration) =>
    services.AddDbContext<BookingContext>(options =>
      options.UseNpgsql(configuration.GetConnectionString(ConnectionStringName)));
 }