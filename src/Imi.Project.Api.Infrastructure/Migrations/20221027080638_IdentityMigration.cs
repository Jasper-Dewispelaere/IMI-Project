using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class IdentityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasApprovedTermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmActors",
                columns: table => new
                {
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActors", x => new { x.FilmId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_FilmActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActors_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Jack Nicholson" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Shelley Duvall" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Arnold Schwarzenegger" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Linda Hamilton" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Michael J. Fox" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Christopher Lloyd" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "John Goodman" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Billy Crystal" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Ralph Fiennes" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Adrien Brody" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Daniel Radcliffe" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Rupert Grint" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Emma Watson" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "George MacKay" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Benedict Cumberbatch" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Leonardo DiCaprio" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Kate Winslet" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Mike Myers" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Eddie Murphy" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Tom Hanks" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Robin Wright" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Joaquin Phoenix" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Scarlett Johansson" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Bradley Cooper" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Ed Helms" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "Zach Galifianakis" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Robert De Niro" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Malcolm McDowell" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "Keira Knightley" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "Bill Murray" },
                    { new Guid("00000000-0000-0000-0000-000000000031"), "Benicio del Toro" },
                    { new Guid("00000000-0000-0000-0000-000000000032"), "Ed Asner" },
                    { new Guid("00000000-0000-0000-0000-000000000033"), "Christopher Plummer" },
                    { new Guid("00000000-0000-0000-0000-000000000034"), "Jeff Bridges" },
                    { new Guid("00000000-0000-0000-0000-000000000035"), "Macaulay Culkin" },
                    { new Guid("00000000-0000-0000-0000-000000000036"), "Joe Pesci" },
                    { new Guid("00000000-0000-0000-0000-000000000037"), "Daniel Stern" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "b2b8d4a5-7353-4110-b6b2-bd44cf703ed5", new DateTime(2022, 10, 27, 10, 6, 38, 587, DateTimeKind.Local).AddTicks(2317), "admin@imi.be", true, false, false, null, "ADMIN@IMI.BE", "IMIADMIN", "AQAAAAEAACcQAAAAEARK/Ci9CQiz+gjnSXhnK6dKnUVS+CmPPl4BitKn99XXap+9ScpuM32Yvd6p8oPyPQ==", null, false, "4a0487b4-5dc6-4ea0-b528-0c75f5d85927", false, "ImiAdmin" },
                    { "2", 0, "66864c70-58b7-4a35-9073-8da9481950eb", new DateTime(2022, 10, 27, 10, 6, 38, 587, DateTimeKind.Local).AddTicks(2347), "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", "AQAAAAEAACcQAAAAECwq+dqo81ZrhG78/3LABfXX9n0vn5su8X6bA1L1ezZJYeYgppS+TQJfnT6KpPHgTQ==", null, false, "6c9a625b-e971-4d40-8b19-6213fc8ab426", false, "ImiUser" },
                    { "3", 0, "3d773f4d-7a17-493c-94a5-7082277bda84", new DateTime(2022, 10, 27, 10, 6, 38, 587, DateTimeKind.Local).AddTicks(2349), "user@imi.be", true, false, false, null, "USER@IMI.BE", "IMIREFUSER", "AQAAAAEAACcQAAAAENcPC/s/9MNnUi9hEIHaNK9x1AjhPS+g9HGBgUXSwLTE1hgRRJbLi2BVMUZJy9HpCA==", null, false, "cc30e923-f5bb-4723-81a3-6e449795f406", false, "ImiRefuser" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Stanley Kubrick" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Robert Zemeckis" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000003"), "James Cameron" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Pete Docter" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Andrew Adamson" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Wes Anderson" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Chris Columbus" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Sam Mendes" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Spike Jonze" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Todd Phillips" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Morten Tyldum" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Joel Coen" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Action" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Adventure" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Animation" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Comedy" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Drama" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Fantasy" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "History" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Horror" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Romance" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "1" },
                    { 2, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "2" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "DirectorId", "GenreId", "Image", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000008"), "https://i.imgur.com/WaC2BJy.jpg", 1980, "The Shining" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), "https://i.imgur.com/oG6lDFU.jpg", 1984, "The Terminator" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), "https://i.imgur.com/dlmlSTB.jpg", 1985, "Back to the Future" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003"), "https://i.imgur.com/yL2zevc.jpg", 2001, "Monsters, Inc." },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000004"), "https://i.imgur.com/REDhy8B.jpg", 2014, "The Grand Budapest Hotel" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000006"), "https://i.imgur.com/Elt7LFe.jpg", 2001, "Harry Potter and the Philosopher’s Stone" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000007"), "https://i.imgur.com/s7ai915.jpg", 2019, "1917" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000009"), "https://i.imgur.com/Yua2ZyQ.jpg", 1997, "Titanic" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003"), "https://i.imgur.com/7oAYSgZ.jpg", 2001, "Shrek" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000005"), "https://i.imgur.com/MnTykWM.jpg", 1994, "Forrest Gump" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), "https://i.imgur.com/ipvfgza.jpg", 2013, "Her" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000004"), "https://i.imgur.com/nSWWPDJ.jpg", 2009, "The Hangover" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000010"), "https://i.imgur.com/vQKKmkP.jpg", 2019, "Joker" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000005"), "https://i.imgur.com/p5DDiYQ.jpg", 1971, "A Clockwork Orange" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007"), "https://i.imgur.com/S2c56sS.jpg", 2014, "The Imitation Game" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000005"), "https://i.imgur.com/BnL6bre.jpg", 2021, "The French Dispatch" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), "https://i.imgur.com/qsWpLG0.jpg", 2000, "Cast Away" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003"), "https://i.imgur.com/1qTvRjR.jpg", 2009, "Up" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000004"), "https://i.imgur.com/IksTt38.jpg", 1998, "The Big Lebowski" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000004"), "https://i.imgur.com/uyjsvzX.jpg", 1990, "Home Alone" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ActorId", "FilmId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000020") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActors_ActorId",
                table: "FilmActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_DirectorId",
                table: "Films",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_GenreId",
                table: "Films",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FilmActors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
