using Imi.Project.Blazor.Data;
using Imi.Project.Blazor.DTOs;
using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Pages;
using System.Text.Json;

namespace Imi.Project.Blazor.Services.Api
{
    public class FilmApiService : ICRUDService<Film>
    {
        private string baseUrl = Config.Url;
        private readonly HttpClient _httpClient = null;

        public FilmApiService(HttpClient httpClient)
        { 
            _httpClient = httpClient;
        }

        public async Task<Film> Get(Guid id)
        {
            var dto = await _httpClient.GetFromJsonAsync<FilmDto>($"{baseUrl}/Films/{id}");
            return new Film
            {
                Id = dto.Id,
                Title = dto.Title,
                Image = dto.Image,
                ReleaseYear = dto.ReleaseYear,
                DirectorId = dto.Director.Id,
                DirectorName = dto.Director.Name,
                GenreId = dto.Genre.Id,
                GenreName = dto.Genre.Name,
            };
        }

        public async Task<IQueryable<Film>> GetAll()
        {
            var dtos = await _httpClient.GetFromJsonAsync<FilmDto[]>($"{baseUrl}/Films");
            return dtos.Select(dto => new Film
            {
                Id = dto.Id,
                Title = dto.Title,
                Image = dto.Image,
                ReleaseYear = dto.ReleaseYear,
                DirectorId = dto.Director.Id,
                DirectorName = dto.Director.Name,
                GenreId = dto.Genre.Id,
                GenreName = dto.Genre.Name,
            }).AsQueryable();
        }

        public Task Create(Film item)
        {
            var dto = new FilmRequestDto
            {
                Id = Guid.NewGuid(),
                Title = item.Title,
                Image = item.Image,
                ReleaseYear = item.ReleaseYear,
                GenreId = item.GenreId,
                DirectorId = item.DirectorId
            };
            return _httpClient.PostAsJsonAsync($"{baseUrl}/Films", dto);
        }

        public Task Delete(Guid id)
        {
            return _httpClient.DeleteAsync($"{baseUrl}/Films/{id}");
        }

        public Task Update(Film item)
        {
            var dto = new FilmRequestDto
            {
                Id = item.Id,
                Title = item.Title,
                Image = item.Image,
                ReleaseYear = item.ReleaseYear,
                GenreId = item.GenreId,
                DirectorId = item.DirectorId
            };
            return _httpClient.PutAsJsonAsync($"{baseUrl}/Films", dto);
        }
    }
}
