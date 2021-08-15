using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "OverBookedAPI",
        Version = "v0.0.2",
        Description = "A Web App for storing and managing your Web Bookmarks and Reading Lists",
        License = new() { Name = "MIT License" },
        Contact = new() { Name = "Chanakya", Email = "uchanakyasrinivas@gmail.com", Url = new("https://github.com/U-C-S") }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OverBookedAPI v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
