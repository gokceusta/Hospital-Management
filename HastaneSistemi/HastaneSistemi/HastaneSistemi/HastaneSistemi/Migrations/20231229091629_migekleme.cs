using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneSistemi.Migrations
{
    public partial class migekleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastas",
                columns: table => new
                {
                    HastaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HastaSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastas", x => x.HastaID);
                });

            migrationBuilder.CreateTable(
                name: "Polikliniks",
                columns: table => new
                {
                    PoliklinikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoliklinikAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polikliniks", x => x.PoliklinikID);
                });

            migrationBuilder.CreateTable(
                name: "Doktors",
                columns: table => new
                {
                    DoktorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoliklinikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktors", x => x.DoktorID);
                    table.ForeignKey(
                        name: "FK_Doktors_Polikliniks_PoliklinikID",
                        column: x => x.PoliklinikID,
                        principalTable: "Polikliniks",
                        principalColumn: "PoliklinikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    RandevuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuGun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RandevuSaat = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DoktorID = table.Column<int>(type: "int", nullable: false),
                    HastaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.RandevuID);
                    table.ForeignKey(
                        name: "FK_Randevus_Doktors_DoktorID",
                        column: x => x.DoktorID,
                        principalTable: "Doktors",
                        principalColumn: "DoktorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevus_Hastas_HastaID",
                        column: x => x.HastaID,
                        principalTable: "Hastas",
                        principalColumn: "HastaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doktors_PoliklinikID",
                table: "Doktors",
                column: "PoliklinikID");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorID",
                table: "Randevus",
                column: "DoktorID");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaID",
                table: "Randevus",
                column: "HastaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Doktors");

            migrationBuilder.DropTable(
                name: "Hastas");

            migrationBuilder.DropTable(
                name: "Polikliniks");
        }
    }
}
