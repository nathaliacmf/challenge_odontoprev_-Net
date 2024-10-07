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

// Configuração da string de conexão para o banco de dados Oracle
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

// Injeção de dependências para a aplicação de Clientes
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IClienteApplicationService, ClienteApplicationService>();

// Injeção de dependências para a aplicação de Usuários e Sinistros
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
builder.Services.AddTransient<ISinistroRepository, SinistroRepository>();
builder.Services.AddTransient<ISinistroApplicationService, SinistroApplicationService>();

// Configuração dos controladores
builder.Services.AddControllers();

// Configuração do Swagger para documentação da API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Cliente, Usuário e Sinistro",
        Version = "v1",
        Description = "API para cadastro de clientes, usuários e sinistros"
    });
    c.EnableAnnotations(); // Habilitar anotações no Swagger
});

var app = builder.Build();

// Configuração do pipeline HTTP para desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
