using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AraWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultCostAndDefaultExtraChargeFieldsToApartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("10f45add-a8c9-4f2b-b36c-64192b04b5fa"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1d884ee4-fad7-4036-85f3-cb7d77128cfa"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("2227f501-86bb-44d7-955e-7520b4f20ab0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("32e912fb-43ad-43f4-950b-f512485c63e0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("382f795a-4bca-493b-929a-d92fc69d009e"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("5293c09c-0b37-4dd9-b274-ecefcf20471f"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("5b4bf18f-b3bd-49be-970c-c18701971045"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("5f10b441-ac22-41d1-b855-ce8292fa035a"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7444033b-4884-4b97-9273-4871a587f0f6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("768bb65e-35b6-4a9d-9c9f-0e625049fd73"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("793ca25e-fb8a-465b-9b0b-ed7f7374e0ef"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("8844ae44-308f-4a51-aadf-4b0eefd40321"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("98eadb3c-e378-4436-a4bb-a9aef9eec82b"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("9b02d999-93be-47a4-a782-59ef4b88d3d6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a3f0b07d-9053-4543-a0ce-ce97df9620bf"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("bbbbe96c-e52e-4ea8-9513-a3ca7df7b8f3"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f1c7b408-4f08-48d9-a59a-d97bb31c15b6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f47eb9a8-082b-42ea-96f8-abdcb3acff1a"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f8d831bf-16a4-445c-8149-ee4a40fa0a4c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("fd9c4e82-8a6c-4ba8-8276-288719fd000b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f2397b2-c6f8-403d-882e-ca5657e9aafc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70cd7fc4-44cd-42af-8ec6-91ef7917d805"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8bfdd6f2-6491-45e2-80d9-f0c03af41cf1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e4bb7cef-b30c-4827-8a89-cb38c1c6310d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0672a2cd-45c5-410c-bf4c-b78847be080b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06936d4d-7c6c-48a9-8157-91e58277121e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("07775568-8345-49ac-87bf-29b93c867f01"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc3e5fc-d7d9-40e9-91fe-9d28dd5e6094"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b827da64-682e-437a-9ff5-622f82da7eca"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd6d34d8-3bd7-4bbe-9995-a6bc8803a61e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c4585018-984a-4a38-a998-e98eb0566350"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c84d9279-27bf-4db2-ba30-6367911677b8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("df48d3cf-95fd-4ee9-a94e-0e00fb265d2c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f377b36a-fc9a-42dd-8ac1-f2a72688b033"));

            migrationBuilder.AddColumn<double>(
                name: "DefaultCost",
                table: "Apartments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DefaultExtraCharge",
                table: "Apartments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("197e246e-1c72-4024-bb38-0ab03b90c963"), null, "Manager", "MANAGER" },
                    { new Guid("80e75fbb-5000-43aa-8993-11ce499f016d"), null, "ApartmentOwner", "APARTMENT_OWNER" },
                    { new Guid("87f9a03d-e289-44b8-a358-78f349bc6038"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("d8bc1622-13d4-492d-8d42-7a457047f1b2"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExperyTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1785bd47-756e-4049-9b65-abb5f2a21b88"), 0, "c7a87b0c-3b32-47a8-a41b-e0228af6a485", null, false, "Fabian", "Heidenreich", false, null, null, null, null, "(461) 483-0373 x823", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("2ee2b5ac-8dc4-4626-8805-37a9e7635410"), 0, "5a1ba570-dc99-4354-b179-2e96eaa1652a", null, false, "Stevie", "Towne", false, null, null, null, null, "1-715-622-9457 x9137", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("364c3e79-f92f-4b6d-9380-f4940e848d63"), 0, "44644148-7509-46b1-bd29-830332c1cddc", null, false, "Meaghan", "Schowalter", false, null, null, null, null, "(823) 677-9679 x2960", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("3b47cdb6-e554-48c7-9586-818eb2753dba"), 0, "36a29456-2463-447e-9693-d473fafbc612", null, false, "Dax", "Schulist", false, null, null, null, null, "733.770.1238 x1170", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("728fab6f-ebd1-4f2c-a1ad-fdb57633f798"), 0, "cb97f8c1-73a5-4652-9666-621c7f119d0e", null, false, "Reid", "Moore", false, null, null, null, null, "(978) 581-8611 x28259", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("8630a908-87f1-4995-9629-16e8d10d274c"), 0, "e1be9321-94d5-4f3b-8a01-c60880741ef2", null, false, "Cornelius", "Roob", false, null, null, null, null, "(600) 285-0666", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("879e5154-671c-44b0-b5e8-e25fb8311e42"), 0, "d951cd91-c70d-4df8-bcb3-5bc531851d0b", null, false, "Fleta", "Spencer", false, null, null, null, null, "1-366-539-4683", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("88646f6b-485e-4373-9136-342f429e3404"), 0, "17a4dac2-8cc9-4be6-a01b-9fe7f5a60aef", null, false, "Isai", "Legros", false, null, null, null, null, "1-906-652-4381", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("89a6c731-813b-4a47-96ce-046f1c8c7701"), 0, "045608bf-d7f1-496b-ba97-422b65b93d09", null, false, "Stacy", "Cormier", false, null, null, null, null, "352-604-7464", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("d5e20af1-4375-4aaa-8ced-69e97c6f4e81"), 0, "4935f16a-226f-430b-86ae-a49280f1e287", null, false, "Verla", "Rogahn", false, null, null, null, null, "349-968-4851", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "OccupState",
                keyColumn: "OccupStateId",
                keyValue: 2,
                column: "Name",
                value: "Submitted");

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentId", "Address", "BedsCount", "DefaultCost", "DefaultExtraCharge", "GuestsCount", "Name", "OwnerId", "Rate", "ReviewsCount", "RoomsCount", "Square" },
                values: new object[,]
                {
                    { new Guid("19dbca47-04d5-4337-bd8d-fbf2d3ce4660"), "4420 West Fork, Marciaport, United States Minor Outlying Islands", 5, 110.0, 40.0, 7, "Esse quo expedita.", new Guid("88646f6b-485e-4373-9136-342f429e3404"), 3.2000000000000002, 56L, 3, 81.5 },
                    { new Guid("1c78c410-2e16-4c13-81bd-fd09bf7fe2cc"), "36466 Yundt Parkways, West Malvina, Slovenia", 1, 100.0, 60.0, 12, "Iste distinctio molestias.", new Guid("3b47cdb6-e554-48c7-9586-818eb2753dba"), 0.59999999999999998, 75L, 3, 78.239999999999995 },
                    { new Guid("32375e40-716c-494c-aad1-c7dfd7117572"), "4380 Terry Stream, Christiansenville, Panama", 1, 120.0, 100.0, 3, "Fugit id sint.", new Guid("89a6c731-813b-4a47-96ce-046f1c8c7701"), 5.5999999999999996, 95L, 2, 3.5600000000000001 },
                    { new Guid("39b50519-69a5-402f-9364-94f0f3d2708e"), "691 Alexander Station, East Sister, Trinidad and Tobago", 4, 60.0, 10.0, 6, "Non at hic.", new Guid("364c3e79-f92f-4b6d-9380-f4940e848d63"), 6.2999999999999998, 72L, 2, 8.2799999999999994 },
                    { new Guid("54b5e55a-0edf-4753-9bdb-ea24d87c3edb"), "9425 Buck Ridge, New Bernadineland, Chile", 4, 40.0, 60.0, 8, "Nam enim labore.", new Guid("879e5154-671c-44b0-b5e8-e25fb8311e42"), 1.1000000000000001, 21L, 1, 44.409999999999997 },
                    { new Guid("64e6bddb-e045-4cb1-b806-86dc29fbe39a"), "426 Geraldine Brook, Barbaraland, Mauritania", 2, 60.0, 80.0, 10, "Ea non culpa.", new Guid("88646f6b-485e-4373-9136-342f429e3404"), 1.6000000000000001, 89L, 1, 6.2599999999999998 },
                    { new Guid("73ea65c2-0c14-47f0-914e-e0fc4e934df3"), "9895 Joan Rue, Danielaville, Armenia", 8, 120.0, 40.0, 12, "Itaque aut consequatur.", new Guid("d5e20af1-4375-4aaa-8ced-69e97c6f4e81"), 6.0999999999999996, 44L, 2, 84.840000000000003 },
                    { new Guid("8d839c72-18d1-4ffd-a0f2-3002279d48cc"), "67734 Schamberger Mission, South Mabel, Seychelles", 2, 170.0, 90.0, 1, "Eos omnis consequatur.", new Guid("1785bd47-756e-4049-9b65-abb5f2a21b88"), 6.5999999999999996, 28L, 4, 83.989999999999995 },
                    { new Guid("960508c5-aefd-4e9c-956b-e07ea25d1498"), "838 King River, Lake Tressafurt, Italy", 5, 20.0, 90.0, 8, "Similique et culpa.", new Guid("2ee2b5ac-8dc4-4626-8805-37a9e7635410"), 1.8999999999999999, 93L, 4, 77.530000000000001 },
                    { new Guid("9b0c291a-7cc8-48be-881e-21d4769de2d6"), "11954 Brendon Brook, Lake Athena, Argentina", 7, 120.0, 10.0, 10, "Cupiditate reprehenderit rem.", new Guid("1785bd47-756e-4049-9b65-abb5f2a21b88"), 9.3000000000000007, 65L, 2, 0.28000000000000003 },
                    { new Guid("9b16ffb9-c984-4cb9-9847-2de559b1a546"), "77121 Filiberto Shores, Lake Roystad, El Salvador", 4, 40.0, 80.0, 4, "Ullam quis sint.", new Guid("d5e20af1-4375-4aaa-8ced-69e97c6f4e81"), 0.90000000000000002, 43L, 4, 72.620000000000005 },
                    { new Guid("a0402c34-0ba3-486e-85b9-95d20b485c86"), "37118 Marcellus Knoll, Lake Garett, Guinea", 1, 70.0, 20.0, 6, "Et inventore iusto.", new Guid("879e5154-671c-44b0-b5e8-e25fb8311e42"), 8.8000000000000007, 23L, 3, 58.600000000000001 },
                    { new Guid("caffc6bf-52ea-45fd-b229-179a20b14a7c"), "7860 VonRueden Islands, Schowalterhaven, Sri Lanka", 8, 130.0, 20.0, 10, "Qui fugit neque.", new Guid("728fab6f-ebd1-4f2c-a1ad-fdb57633f798"), 0.20000000000000001, 49L, 2, 87.980000000000004 },
                    { new Guid("cb5e21d2-7b56-4260-9a82-714ba9440889"), "73015 Lynch Estates, Chadchester, Uganda", 7, 80.0, 10.0, 5, "Aut nihil veniam.", new Guid("3b47cdb6-e554-48c7-9586-818eb2753dba"), 0.10000000000000001, 43L, 2, 22.530000000000001 },
                    { new Guid("d396cb3e-5b6d-4792-8503-deee8e631d51"), "171 Corkery Lodge, West Paytonburgh, Jersey", 3, 180.0, 20.0, 11, "Maiores reiciendis alias.", new Guid("89a6c731-813b-4a47-96ce-046f1c8c7701"), 8.9000000000000004, 63L, 4, 25.239999999999998 },
                    { new Guid("df052e5b-a4c4-40ae-9a86-1893bd304add"), "1909 Peggie Motorway, Port Ernestoview, Jordan", 6, 130.0, 80.0, 6, "Sapiente quisquam tenetur.", new Guid("8630a908-87f1-4995-9629-16e8d10d274c"), 1.8999999999999999, 36L, 1, 13.99 },
                    { new Guid("e9b48f41-d1b1-449d-b96c-6661667e1233"), "47583 Stiedemann Glen, East Meredith, Costa Rica", 1, 50.0, 30.0, 3, "Qui sit nihil.", new Guid("8630a908-87f1-4995-9629-16e8d10d274c"), 1.6000000000000001, 1L, 2, 74.790000000000006 },
                    { new Guid("eb489456-c07c-4012-a00d-415c9587961b"), "1277 Yundt Passage, Shaynaside, Belize", 4, 170.0, 90.0, 5, "Distinctio sed laboriosam.", new Guid("728fab6f-ebd1-4f2c-a1ad-fdb57633f798"), 0.80000000000000004, 49L, 2, 2.1299999999999999 },
                    { new Guid("ecdfd4c4-525e-4c57-aaf2-e5ee66f75ce0"), "144 Fay Vista, Melvinton, France", 8, 130.0, 30.0, 12, "Velit pariatur debitis.", new Guid("2ee2b5ac-8dc4-4626-8805-37a9e7635410"), 0.29999999999999999, 89L, 3, 78.879999999999995 },
                    { new Guid("f47b8671-c9ab-4307-86ef-27373afc43bf"), "88446 Wisozk Mountain, Port Ivah, Holy See (Vatican City State)", 4, 170.0, 100.0, 12, "Veniam rerum voluptas.", new Guid("364c3e79-f92f-4b6d-9380-f4940e848d63"), 9.4000000000000004, 24L, 2, 61.700000000000003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("19dbca47-04d5-4337-bd8d-fbf2d3ce4660"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1c78c410-2e16-4c13-81bd-fd09bf7fe2cc"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("32375e40-716c-494c-aad1-c7dfd7117572"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("39b50519-69a5-402f-9364-94f0f3d2708e"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("54b5e55a-0edf-4753-9bdb-ea24d87c3edb"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("64e6bddb-e045-4cb1-b806-86dc29fbe39a"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("73ea65c2-0c14-47f0-914e-e0fc4e934df3"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("8d839c72-18d1-4ffd-a0f2-3002279d48cc"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("960508c5-aefd-4e9c-956b-e07ea25d1498"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("9b0c291a-7cc8-48be-881e-21d4769de2d6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("9b16ffb9-c984-4cb9-9847-2de559b1a546"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a0402c34-0ba3-486e-85b9-95d20b485c86"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("caffc6bf-52ea-45fd-b229-179a20b14a7c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("cb5e21d2-7b56-4260-9a82-714ba9440889"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("d396cb3e-5b6d-4792-8503-deee8e631d51"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("df052e5b-a4c4-40ae-9a86-1893bd304add"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("e9b48f41-d1b1-449d-b96c-6661667e1233"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("eb489456-c07c-4012-a00d-415c9587961b"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("ecdfd4c4-525e-4c57-aaf2-e5ee66f75ce0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f47b8671-c9ab-4307-86ef-27373afc43bf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("197e246e-1c72-4024-bb38-0ab03b90c963"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("80e75fbb-5000-43aa-8993-11ce499f016d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("87f9a03d-e289-44b8-a358-78f349bc6038"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8bc1622-13d4-492d-8d42-7a457047f1b2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1785bd47-756e-4049-9b65-abb5f2a21b88"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2ee2b5ac-8dc4-4626-8805-37a9e7635410"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("364c3e79-f92f-4b6d-9380-f4940e848d63"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b47cdb6-e554-48c7-9586-818eb2753dba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("728fab6f-ebd1-4f2c-a1ad-fdb57633f798"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8630a908-87f1-4995-9629-16e8d10d274c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("879e5154-671c-44b0-b5e8-e25fb8311e42"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88646f6b-485e-4373-9136-342f429e3404"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89a6c731-813b-4a47-96ce-046f1c8c7701"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5e20af1-4375-4aaa-8ced-69e97c6f4e81"));

            migrationBuilder.DropColumn(
                name: "DefaultCost",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "DefaultExtraCharge",
                table: "Apartments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2f2397b2-c6f8-403d-882e-ca5657e9aafc"), null, "User", "USER" },
                    { new Guid("70cd7fc4-44cd-42af-8ec6-91ef7917d805"), null, "ApartmentOwner", "APARTMENT_OWNER" },
                    { new Guid("8bfdd6f2-6491-45e2-80d9-f0c03af41cf1"), null, "Manager", "MANAGER" },
                    { new Guid("e4bb7cef-b30c-4827-8a89-cb38c1c6310d"), null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExperyTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0672a2cd-45c5-410c-bf4c-b78847be080b"), 0, "2781583a-02ff-4891-b4a5-f99348e50d0b", null, false, "Lazaro", "O'Reilly", false, null, null, null, null, "663-275-4207 x504", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("06936d4d-7c6c-48a9-8157-91e58277121e"), 0, "e3ff0b18-59a1-46bc-a323-eba08c62a7e7", null, false, "Jazlyn", "Carter", false, null, null, null, null, "(427) 521-9482", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("07775568-8345-49ac-87bf-29b93c867f01"), 0, "2bee5d88-ca3c-42df-ac8c-f27f6f95937d", null, false, "Tillman", "Torp", false, null, null, null, null, "(215) 379-6532 x7094", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("3cc3e5fc-d7d9-40e9-91fe-9d28dd5e6094"), 0, "e0a5ad29-4d5e-465d-9ee4-e0a3619e456e", null, false, "Theresia", "Sanford", false, null, null, null, null, "835.981.4306", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("b827da64-682e-437a-9ff5-622f82da7eca"), 0, "49556839-f378-4f8b-b2ce-4b9e884b4853", null, false, "Rick", "Daniel", false, null, null, null, null, "276.428.0371", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("bd6d34d8-3bd7-4bbe-9995-a6bc8803a61e"), 0, "3e720e03-9f28-408d-97e0-bbc55daa7eb2", null, false, "Rocio", "Howe", false, null, null, null, null, "(865) 300-0246 x36018", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("c4585018-984a-4a38-a998-e98eb0566350"), 0, "5e41efdb-e483-44c7-979b-34ef93d419d7", null, false, "Sadye", "MacGyver", false, null, null, null, null, "310.493.6064", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("c84d9279-27bf-4db2-ba30-6367911677b8"), 0, "a3ba5840-a4ea-42f7-a86e-94ea98a0ce84", null, false, "Conner", "Satterfield", false, null, null, null, null, "1-200-629-1455 x00463", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("df48d3cf-95fd-4ee9-a94e-0e00fb265d2c"), 0, "45e3b430-ae3d-442e-941a-5c468d7ca282", null, false, "Blake", "Crona", false, null, null, null, null, "776.810.1225 x39649", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null },
                    { new Guid("f377b36a-fc9a-42dd-8ac1-f2a72688b033"), 0, "8a60a7d8-576b-4c5e-a820-5af0709c93ff", null, false, "Shawna", "Abshire", false, null, null, null, null, "504.279.6319 x9527", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "OccupState",
                keyColumn: "OccupStateId",
                keyValue: 2,
                column: "Name",
                value: "Submited");

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentId", "Address", "BedsCount", "GuestsCount", "Name", "OwnerId", "Rate", "ReviewsCount", "RoomsCount", "Square" },
                values: new object[,]
                {
                    { new Guid("10f45add-a8c9-4f2b-b36c-64192b04b5fa"), "4022 Tracey Branch, Port Alexa, Azerbaijan", 6, 11, "Exercitationem sint repellat.", new Guid("b827da64-682e-437a-9ff5-622f82da7eca"), 1.8, 33L, 3, 88.049999999999997 },
                    { new Guid("1d884ee4-fad7-4036-85f3-cb7d77128cfa"), "27091 Rath Corner, Lake Everett, Antigua and Barbuda", 1, 3, "Eligendi mollitia libero.", new Guid("3cc3e5fc-d7d9-40e9-91fe-9d28dd5e6094"), 9.6999999999999993, 38L, 4, 32.859999999999999 },
                    { new Guid("2227f501-86bb-44d7-955e-7520b4f20ab0"), "33074 Helene Forges, Lake Frederique, Papua New Guinea", 8, 5, "Sed illo mollitia.", new Guid("bd6d34d8-3bd7-4bbe-9995-a6bc8803a61e"), 1.6000000000000001, 86L, 1, 31.98 },
                    { new Guid("32e912fb-43ad-43f4-950b-f512485c63e0"), "799 Stehr Station, South Don, Kyrgyz Republic", 8, 5, "Et voluptatem ex.", new Guid("f377b36a-fc9a-42dd-8ac1-f2a72688b033"), 3.2000000000000002, 50L, 2, 9.3900000000000006 },
                    { new Guid("382f795a-4bca-493b-929a-d92fc69d009e"), "7486 Rosina Plains, Bernitaberg, Tuvalu", 8, 10, "Ratione in distinctio.", new Guid("0672a2cd-45c5-410c-bf4c-b78847be080b"), 4.5, 39L, 4, 76.489999999999995 },
                    { new Guid("5293c09c-0b37-4dd9-b274-ecefcf20471f"), "332 Morgan Avenue, West Ulises, Bermuda", 2, 12, "Cumque non quod.", new Guid("f377b36a-fc9a-42dd-8ac1-f2a72688b033"), 8.5, 45L, 3, 47.789999999999999 },
                    { new Guid("5b4bf18f-b3bd-49be-970c-c18701971045"), "0689 Peter Neck, McDermottfurt, Guam", 8, 6, "Pariatur autem placeat.", new Guid("bd6d34d8-3bd7-4bbe-9995-a6bc8803a61e"), 6.9000000000000004, 60L, 2, 70.769999999999996 },
                    { new Guid("5f10b441-ac22-41d1-b855-ce8292fa035a"), "370 Celine Manors, West Daphneemouth, Northern Mariana Islands", 4, 5, "Eveniet dolores quia.", new Guid("c84d9279-27bf-4db2-ba30-6367911677b8"), 3.8999999999999999, 38L, 3, 94.829999999999998 },
                    { new Guid("7444033b-4884-4b97-9273-4871a587f0f6"), "855 Schuster Valleys, North Jettieland, Saint Kitts and Nevis", 2, 12, "Ullam repellendus ipsa.", new Guid("df48d3cf-95fd-4ee9-a94e-0e00fb265d2c"), 5.2000000000000002, 63L, 4, 38.880000000000003 },
                    { new Guid("768bb65e-35b6-4a9d-9c9f-0e625049fd73"), "48728 Savanna Stravenue, Quintonville, Turkey", 3, 7, "Alias qui dolor.", new Guid("b827da64-682e-437a-9ff5-622f82da7eca"), 5.5999999999999996, 63L, 1, 22.620000000000001 },
                    { new Guid("793ca25e-fb8a-465b-9b0b-ed7f7374e0ef"), "73721 Goldner Fords, Kirlinmouth, Wallis and Futuna", 6, 1, "Temporibus exercitationem sit.", new Guid("06936d4d-7c6c-48a9-8157-91e58277121e"), 8.1999999999999993, 41L, 1, 70.689999999999998 },
                    { new Guid("8844ae44-308f-4a51-aadf-4b0eefd40321"), "24048 Goodwin Mountain, West Maximus, Dominican Republic", 6, 12, "Ea quia similique.", new Guid("06936d4d-7c6c-48a9-8157-91e58277121e"), 1.2, 65L, 1, 21.199999999999999 },
                    { new Guid("98eadb3c-e378-4436-a4bb-a9aef9eec82b"), "8598 Jovany Hills, North Dean, Paraguay", 2, 12, "Inventore cupiditate ut.", new Guid("c4585018-984a-4a38-a998-e98eb0566350"), 9.4000000000000004, 36L, 2, 94.450000000000003 },
                    { new Guid("9b02d999-93be-47a4-a782-59ef4b88d3d6"), "08223 Glenda Forest, Kertzmannton, Uzbekistan", 3, 4, "Et est error.", new Guid("3cc3e5fc-d7d9-40e9-91fe-9d28dd5e6094"), 6.2000000000000002, 61L, 4, 0.56999999999999995 },
                    { new Guid("a3f0b07d-9053-4543-a0ce-ce97df9620bf"), "743 Cassin Point, South Eveline, Samoa", 7, 5, "Saepe quos incidunt.", new Guid("c4585018-984a-4a38-a998-e98eb0566350"), 2.8999999999999999, 93L, 3, 53.539999999999999 },
                    { new Guid("bbbbe96c-e52e-4ea8-9513-a3ca7df7b8f3"), "654 Tanner Curve, Kyliefurt, Lao People's Democratic Republic", 2, 8, "Praesentium enim aut.", new Guid("07775568-8345-49ac-87bf-29b93c867f01"), 1.0, 28L, 3, 61.93 },
                    { new Guid("f1c7b408-4f08-48d9-a59a-d97bb31c15b6"), "1266 Antonetta Ridges, Lake Otha, Western Sahara", 1, 10, "Temporibus laborum ea.", new Guid("0672a2cd-45c5-410c-bf4c-b78847be080b"), 3.1000000000000001, 90L, 4, 30.140000000000001 },
                    { new Guid("f47eb9a8-082b-42ea-96f8-abdcb3acff1a"), "339 Abner Springs, O'Connerburgh, Philippines", 6, 12, "Nesciunt et praesentium.", new Guid("07775568-8345-49ac-87bf-29b93c867f01"), 0.29999999999999999, 43L, 3, 19.239999999999998 },
                    { new Guid("f8d831bf-16a4-445c-8149-ee4a40fa0a4c"), "1527 Becker Forges, Lewshire, Colombia", 1, 8, "Laudantium amet corporis.", new Guid("c84d9279-27bf-4db2-ba30-6367911677b8"), 8.8000000000000007, 82L, 2, 25.890000000000001 },
                    { new Guid("fd9c4e82-8a6c-4ba8-8276-288719fd000b"), "642 Geoffrey Squares, Wittingfort, Cameroon", 6, 4, "Consequuntur quo doloremque.", new Guid("df48d3cf-95fd-4ee9-a94e-0e00fb265d2c"), 1.3, 37L, 2, 80.709999999999994 }
                });
        }
    }
}
