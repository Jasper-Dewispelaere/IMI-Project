using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Repositories.Interfaces
{
    public interface IFilmRepository : IBaseRepository<Film>
    {
        Task<IEnumerable<Film>> GetByDirectorIdAsync(Guid id);
        Task<IEnumerable<Film>> GetByGenreIdAsync(Guid id);
    }
}
