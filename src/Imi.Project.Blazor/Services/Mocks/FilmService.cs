using Imi.Project.Blazor.Data.Seeding;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Mocks
{
    public class FilmService : ICRUDService<Film>
    {
        List<Film> filmList = FilmSeeding.GetFilms;
        List<Genre> genreList = GenreSeeding.GetGenres;
        List<Director> directorList = DirectorSeeding.GetDirectors;

        public async Task<Film> Get(Guid id)
        {
            //return await Task.FromResult(filmList.SingleOrDefault(x => x.Id == id));

            return filmList.Select(f => new Film
            {
                Id = f.Id,
                Title = f.Title,
                Image = f.Image,
                ReleaseYear = f.ReleaseYear,
                DirectorId = f.DirectorId,
                DirectorName = directorList.SingleOrDefault(e => e.Id.Equals(f.DirectorId)).Name,
                GenreId = f.GenreId,
                GenreName = genreList.SingleOrDefault(e => e.Id.Equals(f.GenreId)).Name,
            })
            .SingleOrDefault(x => x.Id == id);
        }

        public Task<IQueryable<Film>> GetAll()
        {
            return Task.FromResult(
                filmList.Select(f => new Film()
                {
                    Id = f.Id,
                    Title = f.Title,
                    Image = f.Image,
                    ReleaseYear = f.ReleaseYear,
                    DirectorId = f.DirectorId,
                    DirectorName = directorList.SingleOrDefault(d => d.Id.Equals(f.DirectorId)).Name,
                    GenreId = f.GenreId,
                    GenreName = genreList.SingleOrDefault(g => g.Id.Equals(f.GenreId)).Name
                }).AsQueryable()
            );
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
            film.DirectorName = item.DirectorName;
            film.GenreName = item.GenreName;
            return Task.CompletedTask;
        }
    }
}
