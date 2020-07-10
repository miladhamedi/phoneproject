using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.Data.Migrations
{
    public partial class AddDbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 35, nullable: false),
                    LastName = table.Column<string>(maxLength: 35, nullable: false),
                    NationalCode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneContacts",
                columns: table => new
                {
                    PhoneContactId = table.Column<Guid>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    ContactId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneContacts", x => x.PhoneContactId);
                    table.ForeignKey(
                        name: "FK_PhoneContacts_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneContacts_ContactId",
                table: "PhoneContacts",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneContacts");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
