using backend.Model;
using backend.Model.FuelTypeUpdates;
using backend.Model.LoginRegistration;
using backend.Model.UserRegistration;
using backend.Service;
using backend.Service.FuelTypeUpdates;
using backend.Service.UserService;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<FuelQueueUpdateSettings>(
    builder.Configuration.GetSection(nameof(FuelQueueUpdateSettings)));

builder.Services.Configure<FuelTypeDBSettings>(
    builder.Configuration.GetSection(nameof(FuelTypeDBSettings)));

builder.Services.Configure<LoginDBSettings>(
    builder.Configuration.GetSection(nameof(LoginDBSettings)));

builder.Services.AddSingleton<IFuelQueueUpdate>(sp => sp.GetRequiredService<IOptions<FuelQueueUpdateSettings>>().Value);
builder.Services.AddSingleton<IFuelTypeDBSettings>(sp => sp.GetRequiredService<IOptions<FuelTypeDBSettings>>().Value);
builder.Services.AddSingleton<ILoginDBSettings>(sp => sp.GetRequiredService<IOptions<LoginDBSettings>>().Value);

//same connection string for all
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("Connection:ConnectionString")));

builder.Services.AddScoped<IFuelQueueUpdateService, FuelQueueUpdateService>();
builder.Services.AddScoped<IFuelTypeUpdateService, FuelTypeUpdateService>();
builder.Services.AddScoped<IUserService, UserService>();

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
