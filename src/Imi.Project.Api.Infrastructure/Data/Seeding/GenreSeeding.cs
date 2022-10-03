using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class GenreSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Action"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Adventure"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Animation"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Comedy"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Drama"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Fantasy"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "History" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Horror"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Romance"},
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Thriller"}
            );
        }
    }
}
