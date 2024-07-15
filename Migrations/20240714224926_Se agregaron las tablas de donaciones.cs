using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class Seagregaronlastablasdedonaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("2dae067d-6c3d-4f8e-b3f3-483a8533018f"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("483d0c9a-1eb3-48c3-904b-216605da822e"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6a6f43be-f71d-4ed9-a512-55d1f5d7fb55"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6e5d7e10-9965-4fe4-9710-541771a3ffc5"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("726032b7-2ba7-4bf0-b9c9-ec0f80a0f8c6"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("72817246-52b0-4dfc-8f73-ac1cea389920"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("8325217a-f6f9-4dbf-a9af-dee84de8b134"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9fdbf2de-7e96-4a2b-a6ce-919771370e64"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a62ecd08-8a7a-45ac-b8f8-4a0591407e24"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("ad5e417e-9d6c-4f07-8e00-4c0f2ddd089a"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d50b111f-baed-46b0-83ba-99f86f5d3020"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("eb200c07-2140-4188-b6a0-5df2d57035f9"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("f50e6372-5eca-438a-9531-3185efd7d6ba"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("399ae274-a9dd-4e1a-a435-10c253a63656"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("74b031da-f6a8-4f4e-9369-074709cf2cfd"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("8be1bf1b-cdf7-4e75-a176-7470358e1455"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("b09e6d24-f6ed-4ebc-af07-738ce1f55a81"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("c85d09d2-8198-4a37-84a1-65f5770e348e"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d24e8451-a681-4efb-9ec6-535d6dea6d32"));

            migrationBuilder.CreateTable(
                name: "Donaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donaciones_ClientesProtesicos_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientesProtesicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("0227edd8-eff0-434a-a9b0-daa24c4b89af"), "Lisfranc" },
                    { new Guid("13148e2f-9dac-4f71-b696-1e26dc6fc07b"), "KneeDisarticulation" },
                    { new Guid("1ec970b4-18b6-427a-9a34-e5ef1e38b0af"), "AnkleDisarticulation" },
                    { new Guid("2fa99d29-65d8-417e-afc8-11cfd493e0d8"), "ToePartial" },
                    { new Guid("646ce4ae-4c76-41ba-88a6-915f8faf7694"), "Chopart" },
                    { new Guid("6edd0aff-dc1c-4e97-a2ec-834ff4aa09da"), "Above Knee" },
                    { new Guid("8dd4766d-98ff-4c02-be38-b5fca0e2c2d2"), "Transtibial" },
                    { new Guid("9b73f0fb-39f6-4ddf-86d2-e726009254e9"), "ToeComplete" },
                    { new Guid("a50d3fe4-9bb9-4b91-97ba-ee95f22153ff"), "Below Knee" },
                    { new Guid("bd1d890a-b36a-4a5e-a42a-ffe342548650"), "Hemipelvectomy" },
                    { new Guid("cebae0e0-5b7b-4790-b489-23baf61b5b97"), "FootPartial" },
                    { new Guid("d48e8d32-b0d4-4973-9cba-598e89869a92"), "Transfemoral" },
                    { new Guid("fd88867b-306b-4d41-b896-99e89f7a708b"), "HipDisarticulation" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("29659335-4c25-4de7-9df8-e039b2e9e30b"), "Elbow Disarticulation" },
                    { new Guid("460f5a70-ed33-4e8d-a2cd-6cdfa437ca51"), "Finger Complete" },
                    { new Guid("86d02b26-4fc1-460c-8cdf-656e7c229c4e"), "Hand Partial" },
                    { new Guid("87828a47-20ee-43e9-9726-049819082162"), "Finger Partial" },
                    { new Guid("c2a0de17-4362-4d04-8ab7-7dc88640cddc"), "Wrist Disarticulation" },
                    { new Guid("d39e8c51-89ae-456c-bbd7-7ce5e601d1a4"), "Transradial" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_ClientId",
                table: "Donaciones",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donaciones");

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0227edd8-eff0-434a-a9b0-daa24c4b89af"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("13148e2f-9dac-4f71-b696-1e26dc6fc07b"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("1ec970b4-18b6-427a-9a34-e5ef1e38b0af"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("2fa99d29-65d8-417e-afc8-11cfd493e0d8"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("646ce4ae-4c76-41ba-88a6-915f8faf7694"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6edd0aff-dc1c-4e97-a2ec-834ff4aa09da"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("8dd4766d-98ff-4c02-be38-b5fca0e2c2d2"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9b73f0fb-39f6-4ddf-86d2-e726009254e9"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a50d3fe4-9bb9-4b91-97ba-ee95f22153ff"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("bd1d890a-b36a-4a5e-a42a-ffe342548650"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("cebae0e0-5b7b-4790-b489-23baf61b5b97"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d48e8d32-b0d4-4973-9cba-598e89869a92"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("fd88867b-306b-4d41-b896-99e89f7a708b"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("29659335-4c25-4de7-9df8-e039b2e9e30b"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("460f5a70-ed33-4e8d-a2cd-6cdfa437ca51"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("86d02b26-4fc1-460c-8cdf-656e7c229c4e"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("87828a47-20ee-43e9-9726-049819082162"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("c2a0de17-4362-4d04-8ab7-7dc88640cddc"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d39e8c51-89ae-456c-bbd7-7ce5e601d1a4"));

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("2dae067d-6c3d-4f8e-b3f3-483a8533018f"), "Hemipelvectomy" },
                    { new Guid("483d0c9a-1eb3-48c3-904b-216605da822e"), "HipDisarticulation" },
                    { new Guid("6a6f43be-f71d-4ed9-a512-55d1f5d7fb55"), "Chopart" },
                    { new Guid("6e5d7e10-9965-4fe4-9710-541771a3ffc5"), "ToePartial" },
                    { new Guid("726032b7-2ba7-4bf0-b9c9-ec0f80a0f8c6"), "ToeComplete" },
                    { new Guid("72817246-52b0-4dfc-8f73-ac1cea389920"), "FootPartial" },
                    { new Guid("8325217a-f6f9-4dbf-a9af-dee84de8b134"), "Transfemoral" },
                    { new Guid("9fdbf2de-7e96-4a2b-a6ce-919771370e64"), "KneeDisarticulation" },
                    { new Guid("a62ecd08-8a7a-45ac-b8f8-4a0591407e24"), "Above Knee" },
                    { new Guid("ad5e417e-9d6c-4f07-8e00-4c0f2ddd089a"), "Below Knee" },
                    { new Guid("d50b111f-baed-46b0-83ba-99f86f5d3020"), "AnkleDisarticulation" },
                    { new Guid("eb200c07-2140-4188-b6a0-5df2d57035f9"), "Transtibial" },
                    { new Guid("f50e6372-5eca-438a-9531-3185efd7d6ba"), "Lisfranc" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("399ae274-a9dd-4e1a-a435-10c253a63656"), "Hand Partial" },
                    { new Guid("74b031da-f6a8-4f4e-9369-074709cf2cfd"), "Wrist Disarticulation" },
                    { new Guid("8be1bf1b-cdf7-4e75-a176-7470358e1455"), "Elbow Disarticulation" },
                    { new Guid("b09e6d24-f6ed-4ebc-af07-738ce1f55a81"), "Finger Partial" },
                    { new Guid("c85d09d2-8198-4a37-84a1-65f5770e348e"), "Finger Complete" },
                    { new Guid("d24e8451-a681-4efb-9ec6-535d6dea6d32"), "Transradial" }
                });
        }
    }
}
