using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Film>> GetByDirectorIdAsync(Guid id)
        {
            var films = await GetAll().Where(p => p.DirectorId.Equals(id)).ToListAsync();
            return films;
        }

        public async Task<IEnumerable<Film>> GetByGenreIdAsync(Guid id)
        {
            var films = await GetAll().Where(p => p.GenreId.Equals(id)).ToListAsync();
            return films;
        }

        public override IQueryable<Film> GetAll()
        {
            return _dbContext.Films
                        .Include(f => f.Director)
                        .Include(f => f.Genre)
                        .Include(f => f.Actors).ThenInclude(a => a.Films);
        }

        public async override Task<IEnumerable<Film>> ListAllAsync()
        {
            var films = await GetAll().ToListAsync();
            return films;
        }

        public async override Task<Film> GetByIdAsync(Guid id)
        {
            var film = await GetAll().SingleOrDefaultAsync(p => p.Id.Equals(id));
            return film;
        }

    }
}
