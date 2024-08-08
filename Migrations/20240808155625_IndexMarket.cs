using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stocktracker.Migrations
{
    /// <inheritdoc />
    public partial class IndexMarket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indexes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StartPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    NoOfDays = table.Column<int>(type: "integer", nullable: false),
                    TradeHoursPerDay = table.Column<decimal>(type: "numeric", nullable: false),
                    ChangeBy = table.Column<decimal>(type: "numeric", nullable: false),
                    MaxDailyChangePercentMin = table.Column<decimal>(type: "numeric", nullable: false),
                    MaxDailyChangePercentMax = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indexes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indexes");
        }
    }
}
