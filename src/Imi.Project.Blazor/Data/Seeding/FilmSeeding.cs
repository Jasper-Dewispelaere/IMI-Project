using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Data.Seeding
{
    public class FilmSeeding
    {
        public static List<Film> films = new List<Film>
        {
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Title = "The Shining", Image = "https://i.imgur.com/WaC2BJy.jpg", ReleaseYear = 1980, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Title = "The Terminator", Image = "https://i.imgur.com/oG6lDFU.jpg", ReleaseYear = 1984, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Title = "Back to the Future", Image = "https://i.imgur.com/dlmlSTB.jpg", ReleaseYear = 1985, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Title = "Monsters, Inc.", Image = "https://i.imgur.com/yL2zevc.jpg", ReleaseYear = 2001, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000004"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Title = "The Grand Budapest Hotel", Image = "https://i.imgur.com/REDhy8B.jpg", ReleaseYear = 2014, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Title = "Harry Potter and the Philosopher’s Stone", Image = "https://i.imgur.com/Elt7LFe.jpg", ReleaseYear = 2001, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000007"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Title = "1917", Image = "https://i.imgur.com/s7ai915.jpg", ReleaseYear = 2019, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Title = "Titanic", Image = "https://i.imgur.com/Yua2ZyQ.jpg", ReleaseYear = 1997, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000009") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Title = "Shrek", Image = "https://i.imgur.com/7oAYSgZ.jpg", ReleaseYear = 2001, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000005"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Title = "Forrest Gump", Image = "https://i.imgur.com/MnTykWM.jpg", ReleaseYear = 1994, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Title = "Her", Image = "https://i.imgur.com/ipvfgza.jpg", ReleaseYear = 2013, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000009"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000009") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Title = "The Hangover", Image = "https://i.imgur.com/nSWWPDJ.jpg", ReleaseYear = 2009, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Title = "Joker", Image = "https://i.imgur.com/vQKKmkP.jpg", ReleaseYear = 2019, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Title = "A Clockwork Orange", Image = "https://i.imgur.com/p5DDiYQ.jpg", ReleaseYear = 1971, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Title = "The Imitation Game", Image = "https://i.imgur.com/S2c56sS.jpg", ReleaseYear = 2014, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000011"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), Title = "The French Dispatch", Image = "https://i.imgur.com/BnL6bre.jpg", ReleaseYear = 2021, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), Title = "Cast Away", Image = "https://i.imgur.com/qsWpLG0.jpg", ReleaseYear = 2000, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), Title = "Up", Image = "https://i.imgur.com/1qTvRjR.jpg", ReleaseYear = 2009, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000004"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), Title = "The Big Lebowski", Image = "https://i.imgur.com/IksTt38.jpg", ReleaseYear = 1998, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000012"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
            new Film() { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Title = "Home Alone", Image = "https://i.imgur.com/uyjsvzX.jpg", ReleaseYear = 1990, DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004") }
        };

        public static List<Film> GetFilms
        {
            get 
            {
                return films;
            }
        }
    }
}
