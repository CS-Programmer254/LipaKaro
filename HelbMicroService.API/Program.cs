using HelbMicroService.Application.Commands;
using HelbMicroService.Application.Services;
using HelbMicroService.Domain.Entities;
using HelbMicroService.Domain.Repositories;
using HelbMicroService.Infastracture.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddDbContext<MyDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
//}


var connectionString = builder.Configuration.GetConnectionString("HELB");
builder.Services.AddDbContext<HelbContext>(options =>
options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IApplicantService, ApplicantService>();
builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
builder.Services
    .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(ApplicationCommandHandler)));

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
