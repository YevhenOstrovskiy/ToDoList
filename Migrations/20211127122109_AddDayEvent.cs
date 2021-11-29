using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    public partial class AddDayEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayEventId",
                table: "TodoItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DayEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayEvents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_DayEventId",
                table: "TodoItems",
                column: "DayEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_DayEvents_DayEventId",
                table: "TodoItems",
                column: "DayEventId",
                principalTable: "DayEvents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_DayEvents_DayEventId",
                table: "TodoItems");

            migrationBuilder.DropTable(
                name: "DayEvents");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_DayEventId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "DayEventId",
                table: "TodoItems");
        }
    }
}
