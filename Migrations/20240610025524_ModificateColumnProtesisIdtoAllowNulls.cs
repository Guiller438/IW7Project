using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class ModificateColumnProtesisIdtoAllowNulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesProtesicos_Prostheses_ProtesisId",
                table: "ClientesProtesicos");

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0add7253-85bf-4dcd-b8b5-0e978c0b45af"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("1725d073-aa79-4e04-a2d8-5bab22a9bcd2"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("43b3ff45-abf1-4ff6-bdcb-9c19cdb0c782"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("5d875f08-83cd-4a15-a507-623e44a3c2d4"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6005ade4-2c23-4040-a4da-4698f9f07d9e"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("603f96d4-f410-4235-a8ba-c3a21e063aad"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("8cb1a042-0aca-4d9d-8760-91ed317d4146"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("8f9d9dac-7982-4d18-98a6-813253428ae2"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("969a6c06-d293-490a-93dd-46aaaa925edb"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d323b2ea-832a-4cf0-8e25-d683bb359b49"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d426f2f1-a8bb-4556-9cfb-f67ac8e6e2e9"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("e6c7c3bb-4830-4d2c-bebb-e91bb3e808a7"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("fd5fd562-b797-4522-aeef-97efc9074814"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0245c78f-9140-4ee9-b1c4-e713b8c22f17"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("25b843a9-c672-4f13-82f0-1c6f8827df41"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("581c45fb-cf54-457a-a686-d38c3c012453"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("673bebfa-d72d-4732-bfd6-58762cd122c1"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("769b3ac4-da2c-463d-9d1d-5cf2608d9135"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("99678c0e-166f-4b8b-9e78-544c94b5bb1e"));

            migrationBuilder.AlterColumn<int>(
                name: "ProtesisId",
                table: "ClientesProtesicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("000bc71d-cc63-4e56-9ee7-3ff8c1d77dcb"), "Chopart" },
                    { new Guid("11233488-278b-435b-bda0-ecba6451ff06"), "HipDisarticulation" },
                    { new Guid("1ff1eeee-a5d0-41ed-8a52-d63126be5c7f"), "AnkleDisarticulation" },
                    { new Guid("52e38285-f63c-47f6-b819-1e9f0fa8708c"), "ToeComplete" },
                    { new Guid("537406fe-2005-4f65-8b9a-e7825ec70e80"), "ToePartial" },
                    { new Guid("7f91d381-9ccd-4239-9a24-4a8516e029fd"), "FootPartial" },
                    { new Guid("84ca52d6-5fd7-48bf-ba03-f461c61b8c13"), "Above Knee" },
                    { new Guid("88e7688a-b1f0-487a-a2a5-1ec2a9995e16"), "Lisfranc" },
                    { new Guid("9061113e-d73d-45c3-b139-bd05c4454ce0"), "Hemipelvectomy" },
                    { new Guid("9c272054-5023-4bf8-87d3-8195920f61e2"), "KneeDisarticulation" },
                    { new Guid("abfb034c-4dce-4420-9490-4cbf1f51f605"), "Transfemoral" },
                    { new Guid("d8193d9e-ba9d-45a5-8290-62ac0e041944"), "Below Knee" },
                    { new Guid("fc31c64f-6faf-40cc-b83f-5fc634c2b754"), "Transtibial" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("8be33d8b-8912-4a8d-baf9-d9758c4e1a42"), "Finger Partial" },
                    { new Guid("9d45bbb7-f567-43fd-a0cb-557244a222f8"), "Elbow Disarticulation" },
                    { new Guid("b5ed041c-5679-4530-9262-7a9da24ab5a1"), "Finger Complete" },
                    { new Guid("bb1048e3-21f3-4158-a914-635047681347"), "Wrist Disarticulation" },
                    { new Guid("d4109c26-32ff-4d6f-a633-5f441f48bc0d"), "Hand Partial" },
                    { new Guid("d8bb67ca-3bc1-4f4b-b484-3a140707992a"), "Transradial" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesProtesicos_Prostheses_ProtesisId",
                table: "ClientesProtesicos",
                column: "ProtesisId",
                principalTable: "Prostheses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesProtesicos_Prostheses_ProtesisId",
                table: "ClientesProtesicos");

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("000bc71d-cc63-4e56-9ee7-3ff8c1d77dcb"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("11233488-278b-435b-bda0-ecba6451ff06"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("1ff1eeee-a5d0-41ed-8a52-d63126be5c7f"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("52e38285-f63c-47f6-b819-1e9f0fa8708c"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("537406fe-2005-4f65-8b9a-e7825ec70e80"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("7f91d381-9ccd-4239-9a24-4a8516e029fd"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("84ca52d6-5fd7-48bf-ba03-f461c61b8c13"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("88e7688a-b1f0-487a-a2a5-1ec2a9995e16"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9061113e-d73d-45c3-b139-bd05c4454ce0"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9c272054-5023-4bf8-87d3-8195920f61e2"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("abfb034c-4dce-4420-9490-4cbf1f51f605"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d8193d9e-ba9d-45a5-8290-62ac0e041944"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("fc31c64f-6faf-40cc-b83f-5fc634c2b754"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("8be33d8b-8912-4a8d-baf9-d9758c4e1a42"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9d45bbb7-f567-43fd-a0cb-557244a222f8"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("b5ed041c-5679-4530-9262-7a9da24ab5a1"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("bb1048e3-21f3-4158-a914-635047681347"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d4109c26-32ff-4d6f-a633-5f441f48bc0d"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("d8bb67ca-3bc1-4f4b-b484-3a140707992a"));

            migrationBuilder.AlterColumn<int>(
                name: "ProtesisId",
                table: "ClientesProtesicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("0245c78f-9140-4ee9-b1c4-e713b8c22f17"), "Wrist Disarticulation" },
                    { new Guid("25b843a9-c672-4f13-82f0-1c6f8827df41"), "Finger Complete" },
                    { new Guid("581c45fb-cf54-457a-a686-d38c3c012453"), "Transradial" },
                    { new Guid("673bebfa-d72d-4732-bfd6-58762cd122c1"), "Elbow Disarticulation" },
                    { new Guid("769b3ac4-da2c-463d-9d1d-5cf2608d9135"), "Hand Partial" },
                    { new Guid("99678c0e-166f-4b8b-9e78-544c94b5bb1e"), "Finger Partial" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesProtesicos_Prostheses_ProtesisId",
                table: "ClientesProtesicos",
                column: "ProtesisId",
                principalTable: "Prostheses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
