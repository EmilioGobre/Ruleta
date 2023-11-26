using Ruleta.Server.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => options.AddDefaultPolicy(
    builder =>
    {
        builder.WithOrigins("http://localhost:5289")
        .AllowAnyHeader()
        .AllowAnyMethod();
    }));
var connectionString = builder.Configuration.GetConnectionString("DildoStoreContext");
builder.Services.AddSqlServer<RuletaContext>(connectionString);
var app = builder.Build();
app.UseCors();
app.Run();