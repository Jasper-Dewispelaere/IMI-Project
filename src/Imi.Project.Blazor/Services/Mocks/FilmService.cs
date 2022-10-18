using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Mocks
{
    public class FilmService : ICRUDService<Film>
    {
        public Task Create(Film item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Film> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Film>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Film item)
        {
            throw new NotImplementedException();
        }
    }
}
