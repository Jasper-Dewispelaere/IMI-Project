using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ActorSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new { }
            );
        }
    }
}
