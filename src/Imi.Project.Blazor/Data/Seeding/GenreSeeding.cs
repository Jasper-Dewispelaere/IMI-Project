using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Data.Seeding
{
    public class GenreSeeding
    {
        public static List<Genre> genres = new List<Genre>
        {
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Action"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Adventure"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Animation"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Comedy"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Drama"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Fantasy"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "History" },
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Horror"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Romance"},
            new Genre() { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Thriller"}
        };
    }
}
