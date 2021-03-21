using Microsoft.EntityFrameworkCore.Migrations;

namespace CarevecMobile.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicePackages_AspNetUsers_UserId",
                table: "ServicePackages");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePackages_AspNetUsers_UserId",
                table: "ServicePackages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicePackages_AspNetUsers_UserId",
                table: "ServicePackages");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePackages_AspNetUsers_UserId",
                table: "ServicePackages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
