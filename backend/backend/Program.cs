using backend.Model;
using backend.Service;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<FuelQueueUpdateSettings>(
    builder.Configuration.GetSection(nameof(FuelQueueUpdateSettings))); 

builder.Services.AddSingleton<IFuelQueueUpdate>(sp => sp.GetRequiredService<IOptions<FuelQueueUpdateSettings>>().Value);

//same connection string for all
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("Connection:ConnectionString")));

builder.Services.AddScoped<IFuelQueueUpdateService, FuelQueueUpdateService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
