using CommanderGQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("CommandConStr")));

var environment = builder.Environment;

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();