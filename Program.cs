using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Financial_ms.Models;
using Financial_ms.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//pass UserDataBaseSetting in appsetting to UserDataBaseSettings class 
builder.Services.Configure<UserDatabaseSettings>(builder.Configuration.GetSection(nameof(UserDatabaseSettings)));
builder.Services.AddSingleton<IUserDatabaseSettings>(
	sp => sp.GetRequiredService<IOptions<UserDatabaseSettings>>().Value);

builder.Services.Configure<BillDatabaseSettings>(builder.Configuration.GetSection(nameof(BillDatabaseSettings)));
builder.Services.AddSingleton<IBillDatabaseSettings>(
	sk => sk.GetRequiredService<IOptions<BillDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(
	s =>new MongoClient(
		builder.Configuration.GetValue<string>("DatabaseSettings:ConnectionString")));
	

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBillService, BillService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
