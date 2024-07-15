using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class DonacionesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("0100f4d0-d03e-4fd6-a8d5-2e39e7c5a3a8"), "Below Knee" },
                    { new Guid("1120c9b9-23c6-4b4d-924a-f073d171b31b"), "Hemipelvectomy" },
                    { new Guid("2d4057f2-dbbc-4e6d-9372-53d45a4c177d"), "Transfemoral" },
                    { new Guid("329c10c9-34cb-49a5-a946-ea6dd664a568"), "KneeDisarticulation" },
                    { new Guid("3a80fb08-2444-4325-90ba-2ddbe0d7ccbd"), "ToePartial" },
                    { new Guid("490f1718-3462-4759-8875-1686dfa00994"), "Chopart" },
                    { new Guid("56ee89ba-fa30-473a-9a6f-2102756e411c"), "ToeComplete" },
                    { new Guid("784bc31e-704a-49a7-963f-b14992cebc90"), "Transtibial" },
                    { new Guid("7ae8dbd1-528f-41c4-a18b-e59fa13006c4"), "Above Knee" },
                    { new Guid("7f65d764-296b-4376-bdb2-80edfe641f10"), "Lisfranc" },
                    { new Guid("9aa6ff13-b1e4-42ee-883a-d2c3f61b2860"), "HipDisarticulation" },
                    { new Guid("f43923f5-865a-4caf-82da-859d2af5833f"), "AnkleDisarticulation" },
                    { new Guid("fb172a43-bbf0-47f0-8feb-75fac69ad1ae"), "FootPartial" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("01dd424a-5856-4bb6-8bcd-2f077611c496"), "Transradial" },
                    { new Guid("0d26626e-af6a-467d-bf3d-c072b217dd33"), "Elbow Disarticulation" },
                    { new Guid("2c4b64cb-62d3-444a-bcbf-641e3096d052"), "Finger Partial" },
                    { new Guid("5bd17c2e-4d34-4128-8e98-403b12ffa62e"), "Wrist Disarticulation" },
                    { new Guid("88070be0-1c32-4f04-8da4-ee86b81eadff"), "Finger Complete" },
                    { new Guid("9991406a-f857-4cd8-9ab4-56c44391fe9e"), "Hand Partial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0100f4d0-d03e-4fd6-a8d5-2e39e7c5a3a8"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("1120c9b9-23c6-4b4d-924a-f073d171b31b"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("2d4057f2-dbbc-4e6d-9372-53d45a4c177d"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("329c10c9-34cb-49a5-a946-ea6dd664a568"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("3a80fb08-2444-4325-90ba-2ddbe0d7ccbd"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("490f1718-3462-4759-8875-1686dfa00994"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("56ee89ba-fa30-473a-9a6f-2102756e411c"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("784bc31e-704a-49a7-963f-b14992cebc90"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("7ae8dbd1-528f-41c4-a18b-e59fa13006c4"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("7f65d764-296b-4376-bdb2-80edfe641f10"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9aa6ff13-b1e4-42ee-883a-d2c3f61b2860"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("f43923f5-865a-4caf-82da-859d2af5833f"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("fb172a43-bbf0-47f0-8feb-75fac69ad1ae"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("01dd424a-5856-4bb6-8bcd-2f077611c496"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0d26626e-af6a-467d-bf3d-c072b217dd33"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("2c4b64cb-62d3-444a-bcbf-641e3096d052"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("5bd17c2e-4d34-4128-8e98-403b12ffa62e"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("88070be0-1c32-4f04-8da4-ee86b81eadff"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9991406a-f857-4cd8-9ab4-56c44391fe9e"));

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
        }
    }
}
