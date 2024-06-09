using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class ModificationTocClienteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.CreateTable(
                name: "ClientesProtesicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProtesisId = table.Column<int>(type: "int", nullable: false),
                    LifeStyleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesProtesicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientesProtesicos_LifeStyles_LifeStyleId",
                        column: x => x.LifeStyleId,
                        principalTable: "LifeStyles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesProtesicos_Prostheses_ProtesisId",
                        column: x => x.ProtesisId,
                        principalTable: "Prostheses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("0add7253-85bf-4dcd-b8b5-0e978c0b45af"), "Lisfranc" },
                    { new Guid("1725d073-aa79-4e04-a2d8-5bab22a9bcd2"), "Hemipelvectomy" },
                    { new Guid("43b3ff45-abf1-4ff6-bdcb-9c19cdb0c782"), "Transtibial" },
                    { new Guid("5d875f08-83cd-4a15-a507-623e44a3c2d4"), "FootPartial" },
                    { new Guid("6005ade4-2c23-4040-a4da-4698f9f07d9e"), "ToeComplete" },
                    { new Guid("603f96d4-f410-4235-a8ba-c3a21e063aad"), "Above Knee" },
                    { new Guid("8cb1a042-0aca-4d9d-8760-91ed317d4146"), "Transfemoral" },
                    { new Guid("8f9d9dac-7982-4d18-98a6-813253428ae2"), "HipDisarticulation" },
                    { new Guid("969a6c06-d293-490a-93dd-46aaaa925edb"), "KneeDisarticulation" },
                    { new Guid("d323b2ea-832a-4cf0-8e25-d683bb359b49"), "AnkleDisarticulation" },
                    { new Guid("d426f2f1-a8bb-4556-9cfb-f67ac8e6e2e9"), "Below Knee" },
                    { new Guid("e6c7c3bb-4830-4d2c-bebb-e91bb3e808a7"), "ToePartial" },
                    { new Guid("fd5fd562-b797-4522-aeef-97efc9074814"), "Chopart" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientesProtesicos_LifeStyleId",
                table: "ClientesProtesicos",
                column: "LifeStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesProtesicos_ProtesisId",
                table: "ClientesProtesicos",
                column: "ProtesisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesProtesicos");

          

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LifeStyleId = table.Column<int>(type: "int", nullable: false),
                    ProsthesisId = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProtesisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_LifeStyles_LifeStyleId",
                        column: x => x.LifeStyleId,
                        principalTable: "LifeStyles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Prostheses_ProsthesisId",
                        column: x => x.ProsthesisId,
                        principalTable: "Prostheses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LifeStyleId",
                table: "Clientes",
                column: "LifeStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProsthesisId",
                table: "Clientes",
                column: "ProsthesisId");
        }
    }
}
