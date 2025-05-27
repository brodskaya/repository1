using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MediatR;
using AutoMapper;
using Outstaff.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OutstaffDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();