
using Business.Layer.services;
using Business.Layer.services.Contracts;
using Business.Layer.DependencyInjection;
using Business.Layer.DTO;
using Microsoft.EntityFrameworkCore;
using DataAccess.Layer.DataContext;
using DataAccess.Layer.repositories.Contracts;
using DataAccess.Layer.repositories;
using Microsoft.AspNetCore.Hosting;
using Cqrs.Hosts;


var builder = WebApplication.CreateBuilder(args);

DependencyInjection.RegisterServices(builder.Services);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddAutoMapper(typeof(Business.Layer.AutoMapper.AutoMapper));
builder.Services.AddAutoMapper(typeof(StartUp));


// Add services to the container.
builder.Services.AddDbContext<NewRepairDbQaDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlServerConnStr"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options => options.AddPolicy(name: "dossierFront",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("dossierFront");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
