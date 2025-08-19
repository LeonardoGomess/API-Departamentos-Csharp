using Departamentos.Infrastructure.Persistence;
using Departamentos.Infrastructure.Persistence.Repositories;
using Departamentos.Domain.Interfaces;
using Departamentos.Application.UseCases.Departamento;
using Departamentos.Application.UseCases.Funcionario;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Departamentos API", Version = "v1" });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();


builder.Services.AddScoped<GetDepartamentosUseCase>();
builder.Services.AddScoped<CreateDepartamentoUseCase>();
builder.Services.AddScoped<UpdateDepartamentoUseCase>();
builder.Services.AddScoped<DeleteDepartamentoUseCase>();

builder.Services.AddScoped<GetFuncionariosByDepartamentoUseCase>();
builder.Services.AddScoped<CreateFuncionarioUseCase>();
builder.Services.AddScoped<UpdateFuncionarioUseCase>();
builder.Services.AddScoped<DeleteFuncionarioUseCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
