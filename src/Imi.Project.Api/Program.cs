using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDatabase")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{ 
    options.SignIn.RequireConfirmedEmail = false; 
}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddCors();

builder.Services.AddScoped<IFilmRepository, FilmRepository>();
builder.Services.AddScoped<IDirectorRepository, DirectorRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IActorRepository, ActorRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(option => 
{ 
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; 
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(jwtOptions => 
    { 
        jwtOptions.TokenValidationParameters = new TokenValidationParameters() 
        { 
            ValidateActor = true, 
            ValidateAudience = true, 
            ValidateLifetime = true, 
            ValidIssuer = builder.Configuration["JWTConfiguration:Issuer"], 
            ValidAudience = builder.Configuration["JWTConfiguration:Audience"], 
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWTConfiguration:SigningKey"])) 
        }; 
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseCors(builder => builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
}

app.UseHttpsRedirection();

app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

app.Run();