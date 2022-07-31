using DirectoryWebApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//TODO: if moving to production you'll need to hook up a real db
builder.Services.AddDbContext<DirectoryApiDbContext>(options =>
    options.UseInMemoryDatabase("DirectoryDb"));

builder.Services.AddLogging();

var app = builder.Build();

//Seed with dev data
//TODO: delete if production, this seeds test data
SeedData.InitializeDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
