using Imi.Project.Blazor.Data.Seeding;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Mocks
{
    public class FilmService : ICRUDService<Film>
    {
        List<Film> filmList = FilmSeeding.GetFilms;
        private readonly ICRUDService<Film> filmService;

        public async Task<Film> Get(Guid id)
        {
            return await Task.FromResult(filmList.SingleOrDefault(x => x.Id == id));
        }

        public async Task<IQueryable<Film>> GetAll()
        {
            var films = await filmService.GetAll();

            return filmList.Select(f => new Film
            {
                Id = f.Id,
                Title = f.Title,
                Image = f.Image,
                ReleaseYear = f.ReleaseYear,
                DirectorId = f.DirectorId,
                GenreId = f.GenreId,
            }).AsQueryable();
            
        }

        public FilmService(ICRUDService<Film> filmService)
        { 
            this.filmService = filmService;
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
