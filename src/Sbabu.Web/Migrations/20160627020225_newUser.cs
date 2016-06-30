using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Sbabu.Web.Migrations
{
    public partial class newUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "NVARCHAR", nullable: true),
                    BusinessHours = table.Column<string>(type: "VARCHAR", nullable: true),
                    City = table.Column<string>(type: "VARCHAR", nullable: true),
                    ContactNo = table.Column<string>(type: "VARCHAR", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR", nullable: true),
                    EmaildId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR", nullable: true),
                    State = table.Column<string>(type: "VARCHAR", nullable: true),
                    WebsiteLink = table.Column<string>(type: "VARCHAR", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    EmailId = table.Column<string>(type: "VARCHAR", nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR", nullable: false),
                    UserName = table.Column<string>(type: "VARCHAR", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "SocialNetwork",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetwork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialNetwork_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("SocialNetwork");
            migrationBuilder.DropTable("Users");
            migrationBuilder.DropTable("Company");
        }
    }
}
