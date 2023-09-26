using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PortalEstudiantil.AppBlazor;
using PortalEstudiantil.AppBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7002/api/") });
builder.Services.AddScoped<ICicloService, CicloService>();
builder.Services.AddScoped<IDocenteService, DocenteService>();
builder.Services.AddScoped<IGradoService, GradoService>();
builder.Services.AddScoped<IHorarioService, HorarioService>();
builder.Services.AddScoped<IMateriaService, MateriaService>();
builder.Services.AddScoped<IRolService, RolService>();
builder.Services.AddScoped<ITurnoService, TurnoService>();


builder.Services.AddScoped<ITurnoService, TurnoService>();
builder.Services.AddMudServices();

builder.Services.AddMudServices(); //importacion de los servicios de MudBlazor

await builder.Build().RunAsync();
