using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class AddDonationGoalToClientesProtesicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "DonationGoal",
                table: "ClientesProtesicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("0a8ad653-a149-4f7d-96f0-34ef19e929a2"), "Transtibial" },
                    { new Guid("2ed1f5b0-103b-4280-a658-6f8285beb9b8"), "Transfemoral" },
                    { new Guid("5ff42a72-b4d3-44fa-bf33-a77de0a5ddb0"), "Chopart" },
                    { new Guid("76d8c215-ca4d-413b-963c-c970dd59a0bb"), "KneeDisarticulation" },
                    { new Guid("94bf0c5e-a1bf-40b9-9948-1a824b9d8305"), "HipDisarticulation" },
                    { new Guid("9d978188-dc74-4232-b83f-e650e8ec3d93"), "ToeComplete" },
                    { new Guid("aaaa1ca1-b3cf-4db8-be6f-cb642c4f7f85"), "Hemipelvectomy" },
                    { new Guid("ad54c767-350f-48f8-b75e-c9bea83872f3"), "Above Knee" },
                    { new Guid("b7d96fff-4172-4097-9f74-a6f944d85368"), "AnkleDisarticulation" },
                    { new Guid("c85cb6e7-e43d-420e-9a10-67d1ac868ea3"), "Below Knee" },
                    { new Guid("dbebfaa1-9c64-4ace-8f4c-085c3b03bb7f"), "FootPartial" },
                    { new Guid("e139c2e3-5d4a-493f-89d9-edd6ea13a129"), "ToePartial" },
                    { new Guid("e55d16fa-7d48-45f5-af8b-dbaf7f3e1f47"), "Lisfranc" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("0644d72a-c893-4039-8460-d1179352573f"), "Transradial" },
                    { new Guid("318ce2d0-7263-4a00-a51f-9e35811f52e9"), "Elbow Disarticulation" },
                    { new Guid("366175b0-281a-4cf0-a7f5-1731f7af6d3b"), "Hand Partial" },
                    { new Guid("435ec171-f08f-4af5-a802-a01b662f002b"), "Finger Partial" },
                    { new Guid("a349f95a-b6ef-4ff7-a5cf-d80c387199b8"), "Wrist Disarticulation" },
                    { new Guid("bc623f9e-deac-41bf-84cd-1c2e25a2ab67"), "Finger Complete" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0a8ad653-a149-4f7d-96f0-34ef19e929a2"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("2ed1f5b0-103b-4280-a658-6f8285beb9b8"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("5ff42a72-b4d3-44fa-bf33-a77de0a5ddb0"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("76d8c215-ca4d-413b-963c-c970dd59a0bb"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("94bf0c5e-a1bf-40b9-9948-1a824b9d8305"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9d978188-dc74-4232-b83f-e650e8ec3d93"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("aaaa1ca1-b3cf-4db8-be6f-cb642c4f7f85"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("ad54c767-350f-48f8-b75e-c9bea83872f3"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("b7d96fff-4172-4097-9f74-a6f944d85368"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("c85cb6e7-e43d-420e-9a10-67d1ac868ea3"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("dbebfaa1-9c64-4ace-8f4c-085c3b03bb7f"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("e139c2e3-5d4a-493f-89d9-edd6ea13a129"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("e55d16fa-7d48-45f5-af8b-dbaf7f3e1f47"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0644d72a-c893-4039-8460-d1179352573f"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("318ce2d0-7263-4a00-a51f-9e35811f52e9"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("366175b0-281a-4cf0-a7f5-1731f7af6d3b"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("435ec171-f08f-4af5-a802-a01b662f002b"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a349f95a-b6ef-4ff7-a5cf-d80c387199b8"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("bc623f9e-deac-41bf-84cd-1c2e25a2ab67"));

            migrationBuilder.DropColumn(
                name: "DonationGoal",
                table: "ClientesProtesicos");

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
    }
}
