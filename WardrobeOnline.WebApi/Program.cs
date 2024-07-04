global using WardrobeOnline.DAL;
global using WardrobeOnline.WebApi;
using WardrobeOnline.BLL;

using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Связь с остальными слоями
builder.Services.AddDataLayer("Host=localhost;Port=5432;Database=wardrobe;Username=postgres;Password=root");
builder.Services.AddBusinessLayer();

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

if (app.Configuration["ImageSetting:Type"] == "local")
{
    app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(app.Configuration["ImageSetting:Path"])
    });
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();