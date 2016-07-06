using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Sbabu.Web.Migrations
{
    public partial class PortfolioUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Portfolio",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<int>(
                name: "Odr",
                table: "Portfolio",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Active", table: "Portfolio");
            migrationBuilder.DropColumn(name: "Odr", table: "Portfolio");
        }
    }
}
