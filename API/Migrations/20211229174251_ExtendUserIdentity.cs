using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class ExtendUserIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09baff31-0f9a-48a8-ab7b-4b5b28b3a619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd940d9b-ee25-4a66-a119-1953abbba4b5");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordReset",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenExpires",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerificationToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Verified",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            // migrationBuilder.CreateTable(
            //     name: "RefreshToken",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         AccountId = table.Column<int>(type: "int", nullable: true),
            //         Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_RefreshToken", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_RefreshToken_accounts_AccountId",
            //             column: x => x.AccountId,
            //             principalTable: "accounts",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "FK_RefreshToken_AspNetUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AspNetUsers",
            //             principalColumn: "Id");
            //     });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a188478c-5ecc-4423-bb2c-3cc516b67bf5", "69310e20-7d43-4161-9aa0-2360a12230a7", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca53eb66-78fd-4624-8b16-0ba09f954116", "e28c4fea-1b83-4448-9b63-a14eb68f955d", "Admin", "ADMIN" });

        //     migrationBuilder.CreateIndex(
        //         name: "IX_RefreshToken_AccountId",
        //         table: "RefreshToken",
        //         column: "AccountId");

        //     migrationBuilder.CreateIndex(
        //         name: "IX_RefreshToken_UserId",
        //         table: "RefreshToken",
        //         column: "UserId");
         }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a188478c-5ecc-4423-bb2c-3cc516b67bf5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca53eb66-78fd-4624-8b16-0ba09f954116");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordReset",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResetTokenExpires",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VerificationToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Verified",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09baff31-0f9a-48a8-ab7b-4b5b28b3a619", "7ab2361e-07bb-4f87-816e-f3f216756061", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd940d9b-ee25-4a66-a119-1953abbba4b5", "d54fe8c2-c813-4a53-a63a-5a2e30ffd81b", "Member", "MEMBER" });
        }
    }
}
