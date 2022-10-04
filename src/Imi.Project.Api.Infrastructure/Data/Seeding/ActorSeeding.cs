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
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Jack Nicholson" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Shelley Duvall" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Arnold Schwarzenegger" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Linda Hamilton" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Michael J. Fox" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Christopher Lloyd" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "John Goodman" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Billy Crystal" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Ralph Fiennes" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Adrien Brody" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Daniel Radcliffe" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Rupert Grint" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Emma Watson" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "George MacKay" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "Benedict Cumberbatch" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), Name = "Leonardo DiCaprio" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), Name = "Kate Winslet" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), Name = "Mike Myers" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), Name = "Eddie Murphy" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Name = "Tom Hanks" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000021"), Name = "Robin Wright" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000022"), Name = "Joaquin Phoenix" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000023"), Name = "Scarlett Johansson" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000024"), Name = "Bradley Cooper" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000025"), Name = "Ed Helms" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000026"), Name = "Zach Galifianakis" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000027"), Name = "Robert De Niro" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000028"), Name = "Malcolm McDowell" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000029"), Name = "Keira Knightley" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000030"), Name = "Bill Murray" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000031"), Name = "Benicio del Toro" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000032"), Name = "Ed Asner" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "Christopher Plummer" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000034"), Name = "Jeff Bridges" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000035"), Name = "Macaulay Culkin" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000036"), Name = "Joe Pesci" },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000037"), Name = "Daniel Stern" }
            );
        }
    }
}
