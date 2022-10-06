using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; } 
        public DbSet<Actor> Actors { get; set; } 
        public DbSet<Director> Directors { get; set; } 
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FilmSeeding.Seed(modelBuilder);
            GenreSeeding.Seed(modelBuilder);
            DirectorSeeding.Seed(modelBuilder);
            ActorSeeding.Seed(modelBuilder);

            modelBuilder.Entity<Film>()
                .HasOne(f => f.Director)
                .WithMany(d => d.Films);

            modelBuilder.Entity<Film>()
                .HasOne(f => f.Genre)
                .WithMany(g => g.Films);

            modelBuilder.Entity<Film>()
                .HasMany(f => f.Actors)
                .WithMany(a => a.Films)
                .UsingEntity<Dictionary<string, object>>("FilmActors",
                    f => f.HasOne<Actor>().WithMany().HasForeignKey("ActorId"),
                    a => a.HasOne<Film>().WithMany().HasForeignKey("FilmId"),
                    fa =>
                    {
                        fa.HasKey("FilmId", "ActorId");
                        fa.HasData(
                            new[]
                            {
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000001"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000001"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000002"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000002"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000003"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000003"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000004"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000004"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000005"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000009") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000005"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000006"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000006"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000012") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000006"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000013") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000007"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000014") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000007"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000015") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000008"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000016") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000008"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000017") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000009"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000018") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000009"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000019") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000010"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000020") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000010"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000021") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000022") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000023") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000012"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000024") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000012"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000025") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000012"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000026") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000013"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000022") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000013"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000027") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000014"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000028") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000015"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000015") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000015"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000029") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000016"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000016"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000030") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000016"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000031") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000017"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000020") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000018"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000032") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000018"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000033") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000019"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000019"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000034") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000020"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000035") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000020"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000036") },
                                new { FilmId = Guid.Parse("00000000-0000-0000-0000-000000000020"), ActorId = Guid.Parse("00000000-0000-0000-0000-000000000037") },
                            });
                    });
            base.OnModelCreating(modelBuilder);
        }
    }
}
