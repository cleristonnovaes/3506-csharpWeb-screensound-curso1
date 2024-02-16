using Microsoft.AspNetCore.Http.Json;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<JsonOptions>(options =>
                    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/", () =>
{
    var dal = new DAL<Artista>(new ScreenSoundContext());
    return dal.Listar();
});

app.Run();
