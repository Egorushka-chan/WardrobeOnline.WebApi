using WardrobeOnline.DAL;
using WardrobeOnline.BLL;
using Microsoft.Extensions.FileProviders;
using Serilog;
using WardrobeOnline.WebApi.Settings;
using WardrobeOnline.BLL.Models.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Связь с остальными слоями

string connectionString = builder.Configuration["ConnectionStrings:Postgresql"] +
    $"Username={builder.Configuration["POSTGRES_USER"]};" +
    $"Password={builder.Configuration["POSTGRES_PASSWORD"]};";

builder.Services.Configure<ImageSetting>(
    builder.Configuration.GetSection("ImageSetting"));

builder.Services.Configure<RedisSetting>(
    builder.Configuration.GetSection("RedisSetting"));

builder.Services.AddDataLayer(connectionString);
builder.Services.AddBusinessLayer(builder.Configuration.Get<ImageSetting>(), builder.Configuration.Get<RedisSetting>());

builder.Host.UseSerilog((context, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration);
});

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

// Сервер изображений
if (app.Configuration["ImageSetting:Type"] == "local")
{
    string? path = app.Configuration["ImageSetting:Path"];
    if (!Path.Exists(path))
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), "Images");
    }

    app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(path),
        RequestPath = new PathString("/images"),
        ServeUnknownFileTypes = true
    });
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();