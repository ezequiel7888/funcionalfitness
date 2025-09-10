using FuncionalFitness.Server.Client.Pages;
using FuncionalFitness.Server.Components;
using Microsoft.EntityFrameworkCore;
using funcionalfitness.BD.datos.entidades;
using funcionalfitness.BD;

var builder = WebApplication.CreateBuilder(args);
#region
builder.Services.AddControllers();

builder.Services.AddSwaggerGen();
{

    // Add services to the container.


    var conectionString = builder.Configuration.GetConnectionString("ConnSqlServer")
    ?? throw new InvalidOperationException("el string de conexion no existe.");

    builder.Services.AddDbContext<GymDbContext>(options =>
        options.UseSqlServer(conectionString));

    // Add services to the container.
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents()
        .AddInteractiveWebAssemblyComponents();

    #endregion

    var app = builder.Build();
    #region



    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseWebAssemblyDebugging();
        app.UseSwagger();
        app.UseSwaggerUI();
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

    app.MapControllers();
    #endregion

    app.Run();
}


