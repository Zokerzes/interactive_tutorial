using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interactive_tutorial.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Contents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
