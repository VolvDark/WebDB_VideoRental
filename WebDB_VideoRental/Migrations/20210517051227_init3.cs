using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDB_VideoRental.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "genre",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genre", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cassette",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<int>(nullable: false),
                    producer = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    MainActor = table.Column<string>(nullable: true),
                    DateNote = table.Column<DateTime>(nullable: false),
                    GenreId = table.Column<long>(nullable: false),
                    cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cassette", x => x.id);
                    table.ForeignKey(
                        name: "FK_cassette_genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "genre",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    PassData = table.Column<string>(nullable: true),
                    DatePickup = table.Column<DateTime>(nullable: false),
                    DateReturn = table.Column<DateTime>(nullable: false),
                    IsPayment = table.Column<bool>(nullable: false),
                    IsReturn = table.Column<bool>(nullable: false),
                    CassetteID1 = table.Column<long>(nullable: false),
                    Cassette1id = table.Column<long>(nullable: true),
                    CassetteID2 = table.Column<long>(nullable: false),
                    Cassette2id = table.Column<long>(nullable: true),
                    CassetteID3 = table.Column<long>(nullable: false),
                    Cassette3id = table.Column<long>(nullable: true),
                    EmployeeID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                    table.ForeignKey(
                        name: "FK_client_cassette_Cassette1id",
                        column: x => x.Cassette1id,
                        principalTable: "cassette",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_client_cassette_Cassette2id",
                        column: x => x.Cassette2id,
                        principalTable: "cassette",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_client_cassette_Cassette3id",
                        column: x => x.Cassette3id,
                        principalTable: "cassette",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_client_employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cassette_GenreId",
                table: "cassette",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_client_Cassette1id",
                table: "client",
                column: "Cassette1id");

            migrationBuilder.CreateIndex(
                name: "IX_client_Cassette2id",
                table: "client",
                column: "Cassette2id");

            migrationBuilder.CreateIndex(
                name: "IX_client_Cassette3id",
                table: "client",
                column: "Cassette3id");

            migrationBuilder.CreateIndex(
                name: "IX_client_EmployeeID",
                table: "client",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "cassette");

            migrationBuilder.DropTable(
                name: "genre");
        }
    }
}
