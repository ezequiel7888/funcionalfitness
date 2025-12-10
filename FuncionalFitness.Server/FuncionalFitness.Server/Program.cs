//using funcionalfitness.BD;
//using funcionalfitness.BD.datos.entidades;
using funcionalfitness.repositorio;
using funcionalfitness.servicio.ServiciosHttp;
using FuncionalFitness.Server.Client.Pages;
using FuncionalFitness.Server.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();


    // Add services to the container.

    //cadena de conexion al sql server
    var conectionString = builder.Configuration.GetConnectionString("ConnSqlServer")
    ?? throw new InvalidOperationException("el string de conexion no existe.");

    //contexto de la base de datos
    //builder.Services.AddDbContext<GymDbContext>(options =>
        //options.UseSqlServer(conectionString));

    //registro de repositorios
    //builder.Services.AddScoped<IRepositorio<RegistroUsuario>, Repositorio<RegistroUsuario>>();

    //registro de servidores
    builder.Services.AddHttpClient();
    builder.Services.AddScoped<IHttpServicio, HttpServicio>();

    // Add services to the container.
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents()
        .AddInteractiveWebAssemblyComponents();

    builder.Services.AddServerSideBlazor()
      .AddCircuitOptions(options => { options.DetailedErrors = true; });


    var app = builder.Build();
   

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
    

    app.Run();



