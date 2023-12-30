using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneSistemi.Migrations
{
    public partial class migekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Hesaps",
                columns: table => new
                {
                    HesapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapSifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hesaps", x => x.HesapID);
                });

            migrationBuilder.CreateTable(
                name: "Kayits",
                columns: table => new
                {
                    HesapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapSifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kayits", x => x.HesapID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Hesaps");

            migrationBuilder.DropTable(
                name: "Kayits");
        }
    }
}
