using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElDataBase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElClient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElClient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestType = table.Column<int>(type: "int", nullable: false),
                    ChannelType = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Body = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Response = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ModelUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElRequest_ElClient_ElClientId",
                        column: x => x.ElClientId,
                        principalTable: "ElClient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElRequest_ElClientId",
                table: "ElRequest",
                column: "ElClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElRequest");

            migrationBuilder.DropTable(
                name: "ElClient");
        }
    }
}
