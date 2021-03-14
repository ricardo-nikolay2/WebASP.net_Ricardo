using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_MVC_NET_5.Data.Migrations
{
    public partial class Tambah_PartNumberString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProduksiStringIDs",
                columns: table => new
                {
                    PartNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduksiStringIDs", x => x.PartNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProduksiStringIDs");
        }
    }
}
