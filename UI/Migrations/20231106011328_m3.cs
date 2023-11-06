using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ExportBillDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProductID",
                table: "ExportBillDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
