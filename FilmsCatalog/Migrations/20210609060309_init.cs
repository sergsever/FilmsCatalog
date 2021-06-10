using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmsCatalog.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Джон Уэйн" },
                    { 2, null, "Клин Иствуд" },
                    { 3, null, "Чарльз Бронсон" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Release", "Title" },
                values: new object[,]
                {
                    { 1, "вестерн", new DateTime(1930, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Большой след" },
                    { 2, "детектив", new DateTime(1971, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Грязный Гарри" },
                    { 3, "вестерн", new DateTime(1939, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Дилижанс" },
                    { 4, "военный", new DateTime(1962, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Самый длинный день" },
                    { 5, "детектив", new DateTime(1944, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "В седле" },
                    { 6, "вестерн", new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "За пригрошню долларов" },
                    { 7, "вестерн", new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Хороший, плохой, злой" },
                    { 8, "военный", new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Куда не долетают орлы" },
                    { 9, "военный", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Большой побег" },
                    { 10, "вестерн", new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Белый бизон" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MovieId",
                table: "Actors",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
