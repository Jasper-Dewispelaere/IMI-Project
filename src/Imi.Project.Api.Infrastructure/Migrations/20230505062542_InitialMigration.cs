using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d28abcf-da05-4da9-8c19-69e215ba3f1f", new DateTime(2023, 5, 5, 8, 25, 41, 875, DateTimeKind.Local).AddTicks(2270), "AQAAAAEAACcQAAAAEDJboQ3abGuS+PVBauT11/b/rt7U/Jxfq6tJJADdgpoCrTmjga3SJd4TgcQatMna3w==", "6be3001e-81f6-4b6a-bcde-306ff092ac69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbe4e221-2ce7-4e8a-a442-03764a4da330", new DateTime(2023, 5, 5, 8, 25, 41, 875, DateTimeKind.Local).AddTicks(2298), "AQAAAAEAACcQAAAAECgXLKoDpUgndyevEB/z0/wV5f9drHdhsarzGMBxhk4pkX/C3cLrrXvvDNSQytD3Gg==", "a0e158cb-0546-4cf2-ada8-e8983f44c9ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f708c11-1f52-4a70-946b-081409f278be", new DateTime(2023, 5, 5, 8, 25, 41, 875, DateTimeKind.Local).AddTicks(2299), "AQAAAAEAACcQAAAAEB7BF0AX+b8aQSgnzmz2/b+w+ikywLVbTqANnSKKXdyjU9OwpZXEpPhS1qeDOh+mCA==", "b08264d3-3f49-41c5-873f-6fd08dc70ea1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b8d4a5-7353-4110-b6b2-bd44cf703ed5", new DateTime(2022, 10, 27, 10, 6, 38, 587, DateTimeKind.Local).AddTicks(2317), "AQAAAAEAACcQAAAAEARK/Ci9CQiz+gjnSXhnK6dKnUVS+CmPPl4BitKn99XXap+9ScpuM32Yvd6p8oPyPQ==", "4a0487b4-5dc6-4ea0-b528-0c75f5d85927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66864c70-58b7-4a35-9073-8da9481950eb", new DateTime(2022, 10, 27, 10, 6, 38, 587, DateTimeKind.Local).AddTicks(2347), "AQAAAAEAACcQAAAAECwq+dqo81ZrhG78/3LABfXX9n0vn5su8X6bA1L1ezZJYeYgppS+TQJfnT6KpPHgTQ==", "6c9a625b-e971-4d40-8b19-6213fc8ab426" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d773f4d-7a17-493c-94a5-7082277bda84", new DateTime(2022, 10, 27, 10, 6, 38, 587, DateTimeKind.Local).AddTicks(2349), "AQAAAAEAACcQAAAAENcPC/s/9MNnUi9hEIHaNK9x1AjhPS+g9HGBgUXSwLTE1hgRRJbLi2BVMUZJy9HpCA==", "cc30e923-f5bb-4723-81a3-6e449795f406" });
        }
    }
}
