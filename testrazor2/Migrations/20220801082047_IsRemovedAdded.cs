using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorBlog.Migrations
{
    public partial class IsRemovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Tb_Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Tb_Projects");
        }
    }
}
