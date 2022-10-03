using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DirectorSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Stanley Kubrick" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Robert Zemeckis" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "James Cameron" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Pete Docter" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Andrew Adamson" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Wes Anderson" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Chris Columbus" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Sam Mendes" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Spike Jonze" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Todd Phillips" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Morten Tyldum" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Joel Coen" }
            );
        }
    }
}
