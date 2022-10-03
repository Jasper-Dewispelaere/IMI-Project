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
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Title = "The Shining", Image = "https://i.imgur.com/DZk7zf8.jpg", ReleaseYear = 1980, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Title = "The Terminator", Image = "", ReleaseYear = 1984, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Title = "Back to the Future", Image = "", ReleaseYear = 1985, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Title = "Monsters, Inc.", Image = "", ReleaseYear = 2001, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000004"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Title = "The Grand Budapest Hotel", Image = "", ReleaseYear = 2014, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Title = "Harry Potter and the Philosopher’s Stone", Image = "", ReleaseYear = 2001, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000007"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Title = "1917", Image = "", ReleaseYear = 2019, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Title = "Titanic", Image = "", ReleaseYear = 1997, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000009") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Title = "Shrek", Image = "", ReleaseYear = 2001, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000005"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Title = "Forrest Gump", Image = "", ReleaseYear = 1994, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Title = "Her", Image = "", ReleaseYear = 2013, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000009"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000009") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Title = "The Hangover", Image = "", ReleaseYear = 2009, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Title = "Joker", Image = "", ReleaseYear = 2019, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Title = "A Clockwork Orange", Image = "", ReleaseYear = 1971, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Title = "The Imitation Game", Image = "", ReleaseYear = 2014, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000011"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), Title = "The French Dispatch", Image = "", ReleaseYear = 2021, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), Title = "Cast Away", Image = "", ReleaseYear = 2000, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), Title = "Up", Image = "", ReleaseYear = 2009, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000004"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), Title = "The Big Lebowski", Image = "", ReleaseYear = 1998, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000012"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Title = "Home Alone", Image = "", ReleaseYear = 1990, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") }
            );
        }
    }
}
