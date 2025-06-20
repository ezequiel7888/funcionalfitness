using FuncionalFitness.Server.Client.Pages;
using FuncionalFitness.Server.Components;
using Microsoft.EntityFrameworkCore;
using funcionalfitness.BD.datos.entidades;

var builder = WebApplication.CreateBuilder(args);

var conectionString = builder.Configuration.GetConnectionString("ConnSqlServer")
?? throw new InvalidOperationException("el string de conexion no existe.");

builder.Services.AddDbContext<GymDbContext>(options =>
    options.UseSqlServer(conectionString));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FuncionalFitness.Server.Client._Imports).Assembly);

app.Run();
