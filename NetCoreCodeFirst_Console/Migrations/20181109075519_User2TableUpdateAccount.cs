using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreCodeFirst_Console.Migrations
{
    public partial class User2TableUpdateAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_User2_Account",
                table: "User2",
                column: "Account",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User2_Account",
                table: "User2");
        }
    }
}
