using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1139d11e-1e3c-4add-bd54-8328d6d73127"),
                column: "RegionImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3a9e8538-6563-42f6-afdb-62b8c764f755"),
                column: "RegionImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("83266d02-0593-447d-9d4d-eb61d9735945"),
                column: "RegionImageUrl",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1139d11e-1e3c-4add-bd54-8328d6d73127"),
                column: "RegionImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3a9e8538-6563-42f6-afdb-62b8c764f755"),
                column: "RegionImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("83266d02-0593-447d-9d4d-eb61d9735945"),
                column: "RegionImageUrl",
                value: "");
        }
    }
}
