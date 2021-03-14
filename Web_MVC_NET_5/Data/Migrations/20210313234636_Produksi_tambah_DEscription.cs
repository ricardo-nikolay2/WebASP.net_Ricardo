using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_MVC_NET_5.Data.Migrations
{
    public partial class Produksi_tambah_DEscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Produksis",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Produksis");
        }
    }
}
