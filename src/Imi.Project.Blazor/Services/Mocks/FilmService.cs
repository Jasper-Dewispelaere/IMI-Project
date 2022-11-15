using Imi.Project.Blazor.Data.Seeding;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Mocks
{
    public class FilmService : ICRUDService<Film>
    {
        List<Film> filmList = FilmSeeding.GetFilms;
        private readonly ICRUDService<Director> directorService;
        private readonly ICRUDService<Genre> genreService;

        public FilmService(ICRUDService<Director> directorService, ICRUDService<Genre> genreService)
        {
            this.directorService = directorService;
            this.genreService = genreService;
        }

        public async Task<Film> Get(Guid id)
        {
            var directors = await directorService.GetAll();
            var genres = await genreService.GetAll();

            return filmList.Select(f => new Film
            {
                Id = f.Id,
                Title = f.Title,
                Image = f.Image,
                ReleaseYear = f.ReleaseYear,
                DirectorId = f.DirectorId,
                DirectorName = directors.SingleOrDefault(e => e.Id.Equals(f.DirectorId)).Name,
                GenreId = f.GenreId,
                GenreName = genres.SingleOrDefault(e => e.Id.Equals(f.GenreId)).Name,
            })
            .SingleOrDefault(x => x.Id == id);
        }

        public async Task<IQueryable<Film>> GetAll()
        {
            var directors = await directorService.GetAll();
            var genres = await genreService.GetAll();

            return filmList.Select(f => new Film()
                {
                    Id = f.Id,
                    Title = f.Title,
                    Image = f.Image,
                    ReleaseYear = f.ReleaseYear,
                    DirectorId = f.DirectorId,
                    DirectorName = directors.SingleOrDefault(d => d.Id.Equals(f.DirectorId)).Name,
                    GenreId = f.GenreId,
                    GenreName = genres.SingleOrDefault(e => e.Id.Equals(f.GenreId)).Name
                }).AsQueryable();
        }

        public Task Create(Film item)
        {
            item.Id = Guid.NewGuid();
            filmList.Add(item);
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var film = filmList.SingleOrDefault(x => x.Id == id);
            if (film == null) throw new ArgumentException("ERROR film not found!");
            filmList.Remove(film);
            return Task.CompletedTask;
        }

        public Task Update(Film item)
        {
            var film = filmList.SingleOrDefault(x => x.Id == item.Id);
            if (film == null) throw new ArgumentException("ERROR film not found!");
            film.Title = item.Title;
            film.ReleaseYear = item.ReleaseYear;
            film.Image = item.Image;
            film.DirectorId = item.DirectorId;
            film.GenreId = item.GenreId;    
            return Task.CompletedTask;
        }
    }
}
