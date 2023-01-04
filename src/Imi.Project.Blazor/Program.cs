using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Models.Quiz;
using Imi.Project.Blazor.Services;
using Imi.Project.Blazor.Services.Api;
using Imi.Project.Blazor.Services.Mocks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<ICRUDService<Film>, FilmApiService>();
builder.Services.AddTransient<ICRUDService<Genre>, GenreService>();
builder.Services.AddTransient<ICRUDService<Director>, DirectorService>();
builder.Services.AddTransient<IQuizService<QuizItem>, QuizService>();
builder.Services.AddScoped<HttpClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

