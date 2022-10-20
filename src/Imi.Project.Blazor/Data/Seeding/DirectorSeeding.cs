using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Data.Seeding
{
    public class DirectorSeeding
    {
        public static List<Director> directors = new List<Director>
        {
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Stanley Kubrick" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Robert Zemeckis" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "James Cameron" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Pete Docter" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Andrew Adamson" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Wes Anderson" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Chris Columbus" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Sam Mendes" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Spike Jonze" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Todd Phillips" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Morten Tyldum" },
            new Director() { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Joel Coen" }
        };

        public static List<Director> GetDirectors
        {
            get
            {
                return directors;
            }
        }
    }
}
