using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interactive_tutorial.Migrations
{
    /// <inheritdoc />
    public partial class FixAdmins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Admins_Login",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Admins_Login",
                table: "Admins",
                column: "Login",
                unique: true);
        }
    }
}
