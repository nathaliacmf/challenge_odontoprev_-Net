using Cadastro.Cliente.API.Application.Interfaces;
using Cadastro.Cliente.API.Application.Services;
using Cadastro.Cliente.API.Domain.Interfaces;
using Cadastro.Cliente.API.Infrastructure.Data.Repository;
using Cadastro.UsuarioSinistro.API.Application.Interfaces;
using Cadastro.UsuarioSinistro.API.Application.Services;
using Cadastro.UsuarioSinistro.API.Domain.Interfaces;
using Cadastro.UsuarioSinistro.API.Infrastructure.Data.Repository;
using Cadastro.UsuarioSinistro.API.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configura��o da string de conex�o para o banco de dados Oracle
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

// Inje��o de depend�ncias para a aplica��o de Clientes
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IClienteApplicationService, ClienteApplicationService>();

// Inje��o de depend�ncias para a aplica��o de Usu�rios e Sinistros
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
builder.Services.AddTransient<ISinistroRepository, SinistroRepository>();
builder.Services.AddTransient<ISinistroApplicationService, SinistroApplicationService>();

// Configura��o dos controladores
builder.Services.AddControllers();

// Configura��o do Swagger para documenta��o da API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Cliente, Usu�rio e Sinistro",
        Version = "v1",
        Description = "API para cadastro de clientes, usu�rios e sinistros"
    });
    c.EnableAnnotations(); // Habilitar anota��es no Swagger
});

var app = builder.Build();

// Configura��o do pipeline HTTP para desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
