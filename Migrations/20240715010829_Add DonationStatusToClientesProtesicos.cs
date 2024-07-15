using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class AddDonationStatusToClientesProtesicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "DonationStatus",
                table: "ClientesProtesicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("14ea61da-2b69-498e-8713-9bfb32bc4750"), "HipDisarticulation" },
                    { new Guid("35192a73-6027-40be-9616-1f86fc4eb78b"), "Transtibial" },
                    { new Guid("3f3cc0ce-4478-4c5b-8b07-b6d5c9ff26e8"), "ToeComplete" },
                    { new Guid("4f98e10d-51db-4120-9936-612f5adb1c93"), "Above Knee" },
                    { new Guid("672af86d-1df8-4154-b60a-7f2ee32d2ac0"), "Below Knee" },
                    { new Guid("6738e14d-7d38-4b4e-84c1-e1bab5aa88cd"), "Hemipelvectomy" },
                    { new Guid("6845eeb4-e512-4b26-98fe-93a8c9531fbc"), "Transfemoral" },
                    { new Guid("a313e1d5-f666-4cb6-979b-24542bb3d473"), "ToePartial" },
                    { new Guid("c7f7743a-8536-4837-8fb4-7d3b74fd18e2"), "Chopart" },
                    { new Guid("d58fd402-80e0-4ce8-b958-1fb90d1137c7"), "AnkleDisarticulation" },
                    { new Guid("e161fe85-d162-4332-8ab3-ab7c8e54c7f6"), "Lisfranc" },
                    { new Guid("f1b573b7-fcdd-41a7-aa7f-30355f680517"), "KneeDisarticulation" },
                    { new Guid("fa6fbe9f-851c-4383-adc2-01d20914f647"), "FootPartial" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("22b998ec-7de2-488e-bd73-c980093d831f"), "Hand Partial" },
                    { new Guid("39d4e236-b616-4535-9ade-2dc21e6f7326"), "Wrist Disarticulation" },
                    { new Guid("794efabd-5515-4049-920f-1e50739241c1"), "Finger Partial" },
                    { new Guid("a0b90e19-1f35-4c5f-ad2d-576a6213a8aa"), "Finger Complete" },
                    { new Guid("d9989a9f-3cc9-4b3b-a3c0-5ac460a56b74"), "Transradial" },
                    { new Guid("e57c53a2-4788-4192-8f7b-76e08a232b53"), "Elbow Disarticulation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("14ea61da-2b69-498e-8713-9bfb32bc4750"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("35192a73-6027-40be-9616-1f86fc4eb78b"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("3f3cc0ce-4478-4c5b-8b07-b6d5c9ff26e8"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("4f98e10d-51db-4120-9936-612f5adb1c93"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("672af86d-1df8-4154-b60a-7f2ee32d2ac0"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6738e14d-7d38-4b4e-84c1-e1bab5aa88cd"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6845eeb4-e512-4b26-98fe-93a8c9531fbc"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a313e1d5-f666-4cb6-979b-24542bb3d473"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("c7f7743a-8536-4837-8fb4-7d3b74fd18e2"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d58fd402-80e0-4ce8-b958-1fb90d1137c7"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("e161fe85-d162-4332-8ab3-ab7c8e54c7f6"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("f1b573b7-fcdd-41a7-aa7f-30355f680517"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("fa6fbe9f-851c-4383-adc2-01d20914f647"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("22b998ec-7de2-488e-bd73-c980093d831f"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("39d4e236-b616-4535-9ade-2dc21e6f7326"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("794efabd-5515-4049-920f-1e50739241c1"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a0b90e19-1f35-4c5f-ad2d-576a6213a8aa"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d9989a9f-3cc9-4b3b-a3c0-5ac460a56b74"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("e57c53a2-4788-4192-8f7b-76e08a232b53"));

            migrationBuilder.DropColumn(
                name: "DonationStatus",
                table: "ClientesProtesicos");

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
    }
}
