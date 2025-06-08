using kolokwium_apbd.Data;
using kolokwium_apbd.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("defaultConnection")));
builder.Services.AddScoped<IDbService, DbService>();

var app = builder.Build();

app.MapControllers();
app.Run();