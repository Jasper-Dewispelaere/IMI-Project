using Imi.Project.Blazor.Data.Seeding;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Mocks
{
    public class DirectorService : ICRUDService<Director>
    {
        List<Director> directorList = DirectorSeeding.GetDirectors;

        public Task Create(Director item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Director> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Director>> GetAll()
        {
            return Task.FromResult(
                directorList.AsQueryable()
            );
        }

        public Task Update(Director item)
        {
            throw new NotImplementedException();
        }
    }
}
