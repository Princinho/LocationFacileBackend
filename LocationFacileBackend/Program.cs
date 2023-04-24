using LocationFacileBackend;
using LocationFacileBackend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LocationFacileDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/houses", (LocationFacileDBContext _db) =>
{
    return _db.Houses.ToListAsync();
});
app.MapPost("/api/houses", (House house, LocationFacileDBContext _db) =>
{
    _db.Houses.Add(house);
    _db.SaveChanges();
    return Results.Created($"/api/houses/{house.Id}", house);
});
app.MapPut("/api/houses", (House house, LocationFacileDBContext _db) =>
{
    _db.Entry(house).State = EntityState.Modified;
    _db.SaveChanges();
});
app.MapDelete("/api/houses/{id:int}", (int id, LocationFacileDBContext _db) =>
{
    var house = _db.Houses.Find(id);
    if (house == null) return Results.NotFound();
    _db.Entry(house).State = EntityState.Deleted;
    _db.SaveChanges();
    return Results.NoContent();
});
app.Run();
