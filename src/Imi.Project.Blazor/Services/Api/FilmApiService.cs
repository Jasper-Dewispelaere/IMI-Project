using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Api
{
    public class FilmApiService : ICRUDService<Film>
    {

        public Task Create(Film item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Film> Get(Guid id)
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
