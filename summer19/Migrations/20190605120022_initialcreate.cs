using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace summer19.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Departement = table.Column<string>(maxLength: 60, nullable: false),
                    Position = table.Column<string>(maxLength: 60, nullable: false),
                    NoPosition = table.Column<int>(maxLength: 60, nullable: false),
                    Skills = table.Column<string>(maxLength: 100, nullable: false),
                    Location = table.Column<string>(maxLength: 60, nullable: false),
                    Status = table.Column<string>(maxLength: 60, nullable: false),
                    Comments = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requirements");
        }
    }
}
