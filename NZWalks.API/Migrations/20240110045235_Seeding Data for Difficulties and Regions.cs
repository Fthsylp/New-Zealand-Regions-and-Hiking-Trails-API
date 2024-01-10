using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00cf32c4-5950-467d-8e4d-5135f5b4ea89"), "Hard" },
                    { new Guid("572afe80-c43a-484f-9369-c1778be28617"), "Medium" },
                    { new Guid("ad17a6e6-b6aa-49ea-b702-279caa353bee"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("1139d11e-1e3c-4add-bd54-8328d6d73127"), "BOP", "Bay Of Plenty", "" },
                    { new Guid("3a9e8538-6563-42f6-afdb-62b8c764f755"), "NTL", "Northland", "" },
                    { new Guid("5e55c1ff-4135-4441-9e73-84ea6f9824ef"), "AKL", "Auckland", null },
                    { new Guid("701051e9-606d-435f-81c4-ce960a223fcd"), "STL", "Southland", null },
                    { new Guid("83266d02-0593-447d-9d4d-eb61d9735945"), "WGN", "Wellington", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("00cf32c4-5950-467d-8e4d-5135f5b4ea89"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("572afe80-c43a-484f-9369-c1778be28617"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("ad17a6e6-b6aa-49ea-b702-279caa353bee"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1139d11e-1e3c-4add-bd54-8328d6d73127"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3a9e8538-6563-42f6-afdb-62b8c764f755"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5e55c1ff-4135-4441-9e73-84ea6f9824ef"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("701051e9-606d-435f-81c4-ce960a223fcd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("83266d02-0593-447d-9d4d-eb61d9735945"));
        }
    }
}
