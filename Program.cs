using Bangazon.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Bangazon;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonDbContext>(builder.Configuration["BangazonDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Getting all users
app.MapGet("/api/users", (BangazonDbContext db) =>
{
    return db.Users.ToList();
});

// Getting all product categories
app.MapGet("/api/categories", (BangazonDbContext db) =>
{
    return db.Categories.ToList();
});

// Getting all products
app.MapGet("/api/products", (BangazonDbContext db) =>
{
    return db.Products.ToList();
});

// Getting all orders
app.MapGet("/api/orders", (BangazonDbContext db) =>
{
    return db.Orders.ToList();
});

// Getting all order payment types
app.MapGet("/api/payments", (BangazonDbContext db) =>
{
    return db.PaymentTypes.ToList();
});

// Getting all order statuses
app.MapGet("/api/statuses", (BangazonDbContext db) =>
{
    return db.OrderStatusTypes.ToList();
});

app.Run();