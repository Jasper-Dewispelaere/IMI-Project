using Imi.Project.Blazor.Data;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Api
{
    public class FilmApiService : ICRUDService<Film>
    {
        string baseUrl = Config.Url;
        private readonly HttpClient _httpClient = null;

        public FilmApiService(HttpClient httpClient)
        { 
            _httpClient = httpClient;
        }

        public async Task<Film> Get(Guid id)
        {
            var dto = await _httpClient.GetFromJsonAsync<Film>($"{baseUrl}/{id}");
            return new Film
            {
                Id = dto.Id,
                Title = dto.Title,
                Image = dto.Image,
                ReleaseYear = dto.ReleaseYear,
                DirectorId = dto.DirectorId,
                DirectorName = dto.DirectorName,
                GenreId = dto.GenreId,
                GenreName = dto.GenreName,
            };
        }

        public Task<IQueryable<Film>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Create(Film item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Film item)
        {
            throw new NotImplementedException();
        }
    }
}
