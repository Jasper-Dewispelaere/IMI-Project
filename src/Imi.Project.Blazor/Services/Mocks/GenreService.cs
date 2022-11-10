using Imi.Project.Blazor.Data.Seeding;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Mocks
{
    public class GenreService : ICRUDService<Genre>
    {
        List<Genre> genreList = GenreSeeding.GetGenres;

        public Task Create(Genre item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Genre>> GetAll()
        {
            return Task.FromResult(
                genreList.AsQueryable()
            );
        }

        public Task Update(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}
