
using AbsaBankMicroservice.Domain.Repositories;
using AbsaBankMicroservice.Application.Services;
using AbsaBankMicroservice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using AbsaBankMicroservice.Infrastructure.Persistence;
using AbsaBankMicroservice.Application.Commands;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AbsaCoreBanking");
builder.Services.AddDbContext<AbsaBankDbContext>(options =>
options.UseSqlServer(connectionString));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentAccountService, StudentAccountService>();
builder.Services.AddScoped<IStudentAccountRepository, StudentAccountRepository>();
builder.Services
    .AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(CreateStudentAccountCommandHandler)));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
