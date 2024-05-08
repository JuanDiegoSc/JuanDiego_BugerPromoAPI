using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JuanDiego_BugerPromoAPI.Data;
using JuanDiego_BugerPromoAPI.Controllers;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<JuanDiego_BugerPromoAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JuanDiego_BugerPromoAPIContext") ?? throw new InvalidOperationException("Connection string 'JuanDiego_BugerPromoAPIContext' not found.")));

// Add services to the container.

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

app.MapBurgerEndpoints();

app.MapPromoEndpoints();

app.Run();
