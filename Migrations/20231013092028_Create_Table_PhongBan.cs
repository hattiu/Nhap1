using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhap1.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_PhongBan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "TEXT", nullable: false),
                    TenPB = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPB);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
