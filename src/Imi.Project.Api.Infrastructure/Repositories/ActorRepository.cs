using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Imi.Project.Api.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class ActorRepository : BaseRepository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
