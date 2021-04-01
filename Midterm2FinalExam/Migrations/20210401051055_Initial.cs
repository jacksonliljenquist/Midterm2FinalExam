using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Midterm2FinalExam.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuoteInfo",
                columns: table => new
                {
                    QuoteID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quote = table.Column<string>(nullable: false),
                    AuthorSpeaker = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteInfo", x => x.QuoteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuoteInfo");
        }
    }
}
