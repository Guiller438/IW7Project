using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IW7PP.Migrations
{
    /// <inheritdoc />
    public partial class NewFuncionalities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "LowerLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("06e56270-8e6d-45b6-8537-bde2b9886825"), "Lisfranc" },
                    { new Guid("0b5230d3-2864-4ef2-ad33-b8052bdfcbcf"), "AnkleDisarticulation" },
                    { new Guid("1bfc6a27-b6b8-49cf-8a03-5eb05a8805f5"), "Hemipelvectomy" },
                    { new Guid("2fcf53ab-9a53-4e7e-8d58-a96db29a48d3"), "FootPartial" },
                    { new Guid("663e7b17-cf76-4003-9a82-eda32202b405"), "ToePartial" },
                    { new Guid("6c53dc3f-4152-447a-8ec2-05b618a8ff2d"), "ToeComplete" },
                    { new Guid("77551789-4cef-48e9-841f-2715d5447d60"), "Above Knee" },
                    { new Guid("78091850-dd7d-463f-afe7-8084a2975d70"), "HipDisarticulation" },
                    { new Guid("9b8e5364-c726-4435-aeb4-54144b9622da"), "Chopart" },
                    { new Guid("a1144f4d-4ee9-4710-b349-b9640d3b39fa"), "Below Knee" },
                    { new Guid("a3883c2a-fd46-410f-8bec-f358b2beedec"), "KneeDisarticulation" },
                    { new Guid("ba09047a-0c9c-418c-9eba-dadaa71af38a"), "Transfemoral" },
                    { new Guid("f1cc80b9-f8c7-4f0c-8455-47ec7a03e9f4"), "Transtibial" }
                });

            migrationBuilder.InsertData(
                table: "UpperLimbAmputations",
                columns: new[] { "Id", "AmputationName" },
                values: new object[,]
                {
                    { new Guid("192ad1fd-fa2b-4bec-9544-16c19e36ff7a"), "Transradial" },
                    { new Guid("31cd3cf3-de4e-4b88-a845-44fa28fce161"), "Hand Partial" },
                    { new Guid("4ac8a785-848c-407b-b0b1-9fb55d165ecd"), "Elbow Disarticulation" },
                    { new Guid("4d10c76c-1a14-4e81-a3fa-01ffa3e975ac"), "Wrist Disarticulation" },
                    { new Guid("b9356f48-b98f-46a9-9293-3b94b1ae7989"), "Finger Complete" },
                    { new Guid("bb88b052-260a-4534-b9b8-737982efcddc"), "Finger Partial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("06e56270-8e6d-45b6-8537-bde2b9886825"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("0b5230d3-2864-4ef2-ad33-b8052bdfcbcf"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("1bfc6a27-b6b8-49cf-8a03-5eb05a8805f5"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("2fcf53ab-9a53-4e7e-8d58-a96db29a48d3"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("663e7b17-cf76-4003-9a82-eda32202b405"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("6c53dc3f-4152-447a-8ec2-05b618a8ff2d"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("77551789-4cef-48e9-841f-2715d5447d60"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("78091850-dd7d-463f-afe7-8084a2975d70"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("9b8e5364-c726-4435-aeb4-54144b9622da"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a1144f4d-4ee9-4710-b349-b9640d3b39fa"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("a3883c2a-fd46-410f-8bec-f358b2beedec"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("ba09047a-0c9c-418c-9eba-dadaa71af38a"));

            migrationBuilder.DeleteData(
                table: "LowerLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("f1cc80b9-f8c7-4f0c-8455-47ec7a03e9f4"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("192ad1fd-fa2b-4bec-9544-16c19e36ff7a"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("31cd3cf3-de4e-4b88-a845-44fa28fce161"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("4ac8a785-848c-407b-b0b1-9fb55d165ecd"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("4d10c76c-1a14-4e81-a3fa-01ffa3e975ac"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("b9356f48-b98f-46a9-9293-3b94b1ae7989"));

            migrationBuilder.DeleteData(
                table: "UpperLimbAmputations",
                keyColumn: "Id",
                keyValue: new Guid("bb88b052-260a-4534-b9b8-737982efcddc"));

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
        }
    }
}
