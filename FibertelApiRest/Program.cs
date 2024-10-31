
using FibertelData.Auth.Repositories;
using FibertelData.Auth.Services;

using FibertelData.Sources.BaseDeDatos;
using FibertelData.Store.Repositories;
using FibertelData.Store.Services;

using FibertelDomain.Auth.Repositories;
using FibertelDomain.Auth.Services;

using FibertelDomain.Store.Repositories;
using FibertelDomain.Store.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// string con = "Data Source=EDGARDO;Initial Catalog=FibertelDBase;Integrated Security=True; TrustServerCertificate=True";
// builder.Services.AddDbContext<FibertelDbContext>(
//     conf => conf.UseSqlServer(
//         con,
//         b => b.MigrationsAssembly("FibertelApiRest"))
//     );
    string con = "Data Source=Fiber";
builder.Services.AddDbContext<FibertelDbContext>(
    conf => conf.UseSqlite(
        con,
        b => b.MigrationsAssembly("FibertelApiRest"))
    );

//string con = "workstation id=FibertelDBase.mssql.somee.com;packet size=4096;user id=Maycol_SQLLogin_3;pwd=kmulfi6joa;data source=FibertelDBase.mssql.somee.com;persist security info=False;initial catalog=FibertelDBase;TrustServerCertificate=True";
//builder.Services.AddDbContext<FibertelDbContext>(
//    conf => conf.UseSqlServer(
//        con,
//        b => b.MigrationsAssembly("FibertelApiRest"))
//    );



builder.Services.AddCors(
    (conf) => conf.AddDefaultPolicy(policy =>
        policy.AllowAnyHeader()
            .AllowAnyMethod()
            .WithOrigins("http://localhost:4200")
    )
);

// Inyeccion de dependencias -------------------------------------------------------------------

// Services

builder.Services.AddScoped<IBannerService, BannerServiceDbImpl>();
builder.Services.AddScoped<ICategoriaService, CategoriaServiceDbImpl>();
builder.Services.AddScoped<IMarcaService, MarcaServiceDbImpl>();
builder.Services.AddScoped<IProductoService, ProductoServiceDbImpl>();
builder.Services.AddScoped<IDetallePedidoService, DetallePedidoServiceDbImpl>();
builder.Services.AddScoped<IPedidoService, PedidoServiceDbImpl>();
builder.Services.AddScoped<IPersonalService, PersonalServiceDbImpl>();
builder.Services.AddScoped<IEnvioService, EnvioServiceDbImpl>();
builder.Services.AddScoped<IRecojoService, RecojoServiceDbImpl>();
builder.Services.AddScoped<IClienteService, ClienteServiceDbImpl>();
builder.Services.AddScoped<IComprobanteService, ComprobanteServiceDbImpl>();
builder.Services.AddScoped<IAdministradorService, AdministradorServiceDblmpl>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationServiceDbImpl>();

// Repositories

//builder.Services.AddScoped<IAuthRepository, AuthRepository>(); //ACTIVAR PARA LA AUTENTICACION
builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepositoryImpl>();
builder.Services.AddScoped<IProductoRepository, ProductoRepositoryImpl>();
builder.Services.AddScoped<IMovimientosRepository, MovimientosRepositoryImpl>();

 
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();

    
