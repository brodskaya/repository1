using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OutstaffSystem.Data;
using OutstaffSystem.MappingProfiles;
using OutstaffSystem.Application.Contractors.Commands;
using OutstaffSystem.Application.Contractors.Queries;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Подключение DbContext
builder.Services.AddDbContext<OutstaffContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Подключение MediatR и AutoMapper
builder.Services.AddMediatR(typeof(CreateContractorCommand).Assembly);
builder.Services.AddAutoMapper(typeof(ContractorProfile));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();