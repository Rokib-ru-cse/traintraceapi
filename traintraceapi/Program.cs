using Microsoft.EntityFrameworkCore;
using traintraceapi.DAL;
using traintraceapi.Utils;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors();
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("mycors",
//                           policy =>
//                           {
//                               policy.WithOrigins("http://localhost:4200",
//                                                   "http://www.contoso.com")
//                                                   .AllowAnyHeader()
//                                                   .AllowAnyMethod();
//                           });
// });
// builder.Services.AddCors(p => p.AddPolicy("mycors", builder =>
//     {
//         builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
//     }));

ConfigurationManager configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("DefaultConnectionString");

var serverVersion = new MySqlServerVersion(new Version(8, 0, 3));
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(connectionString, serverVersion);
});

// Add services to the container.

DIM.DependencyInjection(builder);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.EnvironmentName == "Development")
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
app.Services.CreateScope().ServiceProvider.GetRequiredService<Seed>().SeedData();

app.UseHttpsRedirection();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
