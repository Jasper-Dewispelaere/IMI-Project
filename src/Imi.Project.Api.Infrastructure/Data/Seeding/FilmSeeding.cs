using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class FilmSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Title = "The Shining", Image = "https://i.imgur.com/DZk7zf8.jpg", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Title = "", Image = "", ReleaseYear = 1980, DirectorId = Guid.Parse(""), GenreId = Guid.Parse("") }
            );
        }
    }
}
