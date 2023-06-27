using ApiAuthAngular.Data;
using ApiAuthAngular.Repository.Interface;
using ApiAuthAngular.Repository.UserService;
using APiAuthAngular.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Userservice>();
builder.Services.AddScoped<IBaserepo<string,User>,UserRepo>();
//builder.Services.AddScoped<IBaserepo <string, User>, UserRepo>();
builder.Services.AddScoped<ITokengenerate, Tokenservice>();
builder.Services.AddDbContext<AuthAngular>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "AuthAngular")));


builder.Services.AddCors(options =>
{
    options.AddPolicy("authapi", options =>
    {
        options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("authapi");
app.UseAuthorization();

app.MapControllers();

app.Run();
