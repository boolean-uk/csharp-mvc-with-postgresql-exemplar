using exercise.api.EndPoints;
using exercise.api.Models;
using exercise.api.Repository;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDatabaseRepository<Employee>, DatabaseRepository<Employee>>();
builder.Services.AddScoped<IDatabaseRepository<Department>, DatabaseRepository<Department>>();
builder.Services.AddScoped<IDatabaseRepository<Salary>, DatabaseRepository<Salary>>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureDepartmentAPI();
app.ConfigureEmployeeAPI();
app.ConfigureSalaryAPI();


app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
