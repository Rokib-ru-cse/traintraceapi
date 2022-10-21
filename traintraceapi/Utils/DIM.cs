using traintraceapi.DAL.DbSeed.CountrySeed;
using traintraceapi.DAL.DbSeed.TrainSeed;
using traintraceapi.BLL.Interface;
using traintraceapi.BLL.Service;

namespace traintraceapi.Utils
{
    public class DIM
    {
        public static void DependencyInjection(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<Seed>();
            builder.Services.AddScoped<CountryDbInitializer>();
            builder.Services.AddScoped<TrainDbInitializer>();
            builder.Services.AddScoped<ICountryBLRepository,CountryBLService>();
            builder.Services.AddScoped<ITrainBLRepository,TrainBLService>();
            builder.Services.AddScoped<ILocationBLRepository,LocationBLService>();

        }
    }
}
