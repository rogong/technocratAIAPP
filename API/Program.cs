using System.Text.Json;
using System.Text.Json.Serialization;
using API.Data;
using API.Entities;
using API.Helpers;
using API.Interface;
using API.Middleware;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MappingProfiles));
builder.Services.AddScoped<IMentionRepository, MentionRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AiManagerContext>(opt => 
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(opt => {
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
