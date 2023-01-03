using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmFinderApi.Migrations
{
    /// <inheritdoc />
    public partial class seedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateDate", "PasswordHash", "TempPassword", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "/msrEh2aisw4YMZxo0VI42yG8wpYt5Xeq19Xs6zhJ/0=", "P@ssw0rd", "test user" },
                    { 2, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "/msrEh2aisw4YMZxo0VI42yG8wpYt5Xeq19Xs6zhJ/0=", "/msrEh2aisw4YMZxo0VI42yG8wpYt5Xeq19Xs6zhJ/0=", "test user 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);
        }
    }
}
