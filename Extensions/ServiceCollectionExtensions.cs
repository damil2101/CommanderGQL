using System.Text.Json;
using System.Text.Json.Serialization;
using CommanderGQL.Data;
using Microsoft.EntityFrameworkCore;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection InitConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("CommandConStr")));
        var jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        services.AddSingleton(jsonSerializerOptions);
        return services;
    }
}