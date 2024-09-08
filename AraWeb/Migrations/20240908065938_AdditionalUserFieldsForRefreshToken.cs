using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AraWeb.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserFieldsForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("13dc134a-3f9c-4a0c-adfb-8e2f24932529"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("16782832-5b96-401c-b9a6-c0eb47c879f4"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1dbeeffd-4e8b-40f6-9f2b-d9471513b606"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("2e8cd2b7-9f36-44fc-b39c-2acfb6c1fc8a"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("38fd0bd3-3ffc-43ee-862d-12349d08a596"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("45268d30-fa8b-4fec-8067-b08db2a25a60"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("49eec6a0-7d95-41f3-aae2-bed91c7062c8"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("4cb56703-b3f3-4160-9ed1-ea3b1884aab3"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("68dbc805-f4f3-4605-94d0-6eb6abf8520c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7567e886-2032-42d2-839f-ef0492c4f927"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("8bc0b6cc-6c48-4b4b-87c8-938d6d326718"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("933f5dfa-b8ea-44bf-8045-bc62bd51524a"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a24b2e56-1ec6-486a-8033-bf84239858eb"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("ad8efa22-3113-4dd4-aa79-cc37d97466e8"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("b44eea52-4cd8-4788-904b-c0c4c41d6d36"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("bfdbf68c-f4e8-4003-9354-e870fb96d27e"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("c200fa81-cd98-4fe7-8a7f-5b3f555551db"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("cbd009ee-9024-42cc-b459-976777989bf7"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("d250e216-13ee-4b1c-8250-57229417ffb6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("e96538c0-c854-4a1a-8b39-9ec6fbadcdcb"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cea8b97-1d44-4abc-88c2-0a01a180349c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e28c02e-f094-40df-8eec-8ce9c550c7ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56365493-aa14-4bda-a617-f839fb5401b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e35e787-0820-4524-bd32-1b99cabf3654");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04fe9541-cfc0-4951-93fc-caf65c17c1db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1185d9f0-b511-4d3c-8b37-d9de82c4db39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16e81a02-08a8-4ecc-9b55-80ee5f4fb4dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "321420ce-3d16-4c79-ae3a-7614a67812d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54d12ad0-b4da-488d-9a1a-ad6e32098177");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5507f4df-2fac-4428-92fb-8c5da18a6976");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d173c0b-14fb-4f8e-bcbd-cbac0c0cc87e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98fa0699-d564-4c26-88b5-3d990951537a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cefa5530-8d8d-4431-b551-67d75eebb313");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba14356-5a90-4756-b8f4-5e0d375630b8");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExperyTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f06c0f8-0a17-457a-9550-3a24bc574200", null, "User", "USER" },
                    { "48f067fb-4f7b-4fc7-bd2e-b7e32aab0e6e", null, "Manager", "MANAGER" },
                    { "dd33f26b-ecf7-46dc-81b4-72a20ac57040", null, "Administrator", "ADMINISTRATOR" },
                    { "e09ca7ef-b41f-42a5-aa40-24a947e3cdb6", null, "ApartmentOwner", "APARTMENT_OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExperyTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0323fbbf-53bd-47d6-a440-53ac523cf4d8", 0, "370000e9-34e0-4d19-a1d2-503d64193c81", null, false, "Aubrey", "Wunsch", false, null, null, null, null, "458-309-6849 x814", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51a443f3-bb1c-4c6c-abc8-75ec201f5fd9", false, null },
                    { "0a967d8d-d2e4-41e2-baba-50b6aa96f781", 0, "38440c12-9f84-4f27-9ea7-d5b9d95eb1c7", null, false, "Selina", "Pfannerstill", false, null, null, null, null, "634.849.5232 x105", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ef99b558-9330-4511-bc10-2d402824566d", false, null },
                    { "2d2a54a4-56a8-44e9-83c2-f5804b317261", 0, "d9f5fe32-94e9-42f6-bdf8-24a90ba88300", null, false, "Hollis", "Beer", false, null, null, null, null, "400.490.9701", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ffb438e6-a899-467a-8574-068efb0c0225", false, null },
                    { "40d54930-899b-491e-a73e-e7359cbecced", 0, "6bf8b093-3d21-4ded-94e1-836509c5ae24", null, false, "Lilian", "Gibson", false, null, null, null, null, "617-381-4379", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3aa1ad1b-7416-4f12-9a9d-6b972d310784", false, null },
                    { "b93c1225-e090-4cf6-9bdf-ee22e647a9f3", 0, "9007c65f-92b4-487d-9ead-5a8efec66b32", null, false, "Deven", "Abshire", false, null, null, null, null, "(292) 785-3086 x3152", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a9efd623-8c29-4ca5-8804-37b18b3bd48a", false, null },
                    { "b9cd9883-962a-4142-b293-1c9f10416063", 0, "37d92fb8-0ad4-47ad-a402-3ce8e3b2e9ca", null, false, "Robin", "Okuneva", false, null, null, null, null, "(353) 325-8241 x43499", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0abbc8da-ed28-4305-846d-4463d26f0e8e", false, null },
                    { "ba8a57b0-95e2-4064-9bdb-ebe5ddf8044e", 0, "da63b836-a056-4ef2-a3d8-67c72ff41f66", null, false, "Brooklyn", "Lueilwitz", false, null, null, null, null, "687-257-2220 x777", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac5a3c31-e32a-48b0-9760-26a3f63ca1f7", false, null },
                    { "d3948b32-992b-4165-acb1-1912bd51d3f7", 0, "5ff798a0-31e3-417b-a900-66c23690d0ad", null, false, "Rex", "Langosh", false, null, null, null, null, "206.344.8223", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6e08da98-1543-492a-b52e-22a0fdbf5106", false, null },
                    { "ef52febd-2ea8-4a36-8164-606fedd5bdcd", 0, "d905446a-634b-4b81-a967-e57f4f66138e", null, false, "Asha", "Kertzmann", false, null, null, null, null, "361.595.0493 x678", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c89710c1-39b2-4d09-a2a2-6453a0878ebb", false, null },
                    { "f7b3312d-ac3e-482a-82c1-24b3f0df84ae", 0, "75337130-b50d-4810-b006-be6ca577b402", null, false, "Ibrahim", "VonRueden", false, null, null, null, null, "392.402.6659 x97696", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7e35a739-99c0-4b9e-8a22-34b6063dca9f", false, null }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentId", "Address", "BedsCount", "GuestsCount", "Name", "OwnerId", "Rate", "ReviewsCount", "RoomsCount", "Square" },
                values: new object[,]
                {
                    { new Guid("1ae934f5-137c-4f51-bc01-20b02eecfe0b"), "066 Wendy Lane, Schoentown, Niue", 5, 5, "Repellendus id aut.", "d3948b32-992b-4165-acb1-1912bd51d3f7", 0.018625203199539014, 335L, 3, 0.042302550387608891 },
                    { new Guid("1e86879d-14a8-4820-a39a-647d60b94b2e"), "224 Hoppe Road, West Blaise, Benin", 7, 4, "Excepturi dicta expedita.", "0323fbbf-53bd-47d6-a440-53ac523cf4d8", 0.047790940867059789, 405L, 1, 0.58705321458708981 },
                    { new Guid("1fe8bce1-27a9-4749-814e-e48363601123"), "571 West Meadows, Donniemouth, Peru", 3, 8, "Earum doloribus et.", "f7b3312d-ac3e-482a-82c1-24b3f0df84ae", 0.082817630568003231, 619L, 3, 0.82432238364765487 },
                    { new Guid("243b0c6a-bd37-4f7b-b29f-9983392ef867"), "1520 Ariane Cliffs, Tedland, Saint Martin", 5, 7, "Voluptate quo fuga.", "ba8a57b0-95e2-4064-9bdb-ebe5ddf8044e", 0.012128251761911787, 125L, 3, 0.60368847567483053 },
                    { new Guid("2e9ebc73-1f2b-47ae-983f-a05521419269"), "9329 Grimes Forest, New Bryon, Central African Republic", 4, 3, "Velit tempora maxime.", "40d54930-899b-491e-a73e-e7359cbecced", 0.039654651854748209, 994L, 1, 0.37106119541311844 },
                    { new Guid("32b60fc7-5fdb-4036-ab5d-1ba10eaade6c"), "1141 Leannon Run, Schambergerport, French Polynesia", 8, 6, "Aut eveniet architecto.", "b93c1225-e090-4cf6-9bdf-ee22e647a9f3", 0.08623942645767177, 397L, 2, 0.37959326280839584 },
                    { new Guid("3688429c-47b0-4e23-9e57-33ee98f588b5"), "368 Bernie Meadows, Eloisemouth, Pakistan", 2, 8, "Qui hic quia.", "b9cd9883-962a-4142-b293-1c9f10416063", 0.0033373327577701506, 92L, 4, 0.6319639063966318 },
                    { new Guid("493f2dad-957f-4834-9def-e518316bce7c"), "8799 Janelle Land, Imanimouth, Nicaragua", 2, 5, "Laboriosam quod saepe.", "ef52febd-2ea8-4a36-8164-606fedd5bdcd", 0.027210807946348742, 588L, 4, 0.32506895770983751 },
                    { new Guid("49d54290-1d66-444d-ac93-d315d4d06778"), "3310 Wyman Extensions, Jonberg, Congo", 2, 12, "Totam aut quod.", "f7b3312d-ac3e-482a-82c1-24b3f0df84ae", 0.049683043378912439, 418L, 2, 0.15261330193068398 },
                    { new Guid("9635f2ff-5e40-4be8-865d-e77b086720e6"), "59593 Annalise Ranch, Port Westonstad, Kiribati", 3, 2, "Aut iste ea.", "2d2a54a4-56a8-44e9-83c2-f5804b317261", 0.010194210894706093, 926L, 4, 0.13832967362221241 },
                    { new Guid("a8d7a7f0-6561-43fc-83f2-9bbeeed97121"), "51632 Christopher Trace, Morarmouth, Oman", 8, 7, "Voluptates non pariatur.", "ef52febd-2ea8-4a36-8164-606fedd5bdcd", 0.052979433639450124, 80L, 4, 0.59513722996450169 },
                    { new Guid("bdcc55d8-0cd0-4361-a983-4ef285503695"), "832 Mike Causeway, North Brennontown, Mali", 2, 2, "Et qui in.", "2d2a54a4-56a8-44e9-83c2-f5804b317261", 0.061606619807367896, 977L, 3, 0.34586976155600091 },
                    { new Guid("bf64fa9a-774d-4e99-b17d-a579efe2a25e"), "59491 Green Neck, South Barneyville, Peru", 5, 4, "Amet quae ut.", "0323fbbf-53bd-47d6-a440-53ac523cf4d8", 0.075392219673554986, 327L, 4, 0.86381195879573558 },
                    { new Guid("c177a782-6004-4013-80a4-531f6d7a3c0b"), "06102 Stoltenberg Burg, Lake Miketown, Belarus", 7, 5, "Magnam illo quibusdam.", "0a967d8d-d2e4-41e2-baba-50b6aa96f781", 0.091011207418321527, 283L, 3, 0.39778635187132355 },
                    { new Guid("c1f6bd65-7d25-4db6-94c1-39599c081f66"), "97804 Kristoffer Loop, East Isabella, Reunion", 2, 10, "Quas error soluta.", "b9cd9883-962a-4142-b293-1c9f10416063", 0.045628183308208059, 501L, 1, 0.028801835965608716 },
                    { new Guid("d9483c88-149c-4208-b698-a178e46ede7c"), "4373 Gerlach Track, Trompview, Nigeria", 3, 5, "Eos quisquam eos.", "ba8a57b0-95e2-4064-9bdb-ebe5ddf8044e", 0.053241091315546288, 96L, 2, 0.095819201799158926 },
                    { new Guid("e4f9a37b-aacb-4418-845f-d64dd5f2d5cf"), "36348 Lesly Summit, South Eliane, Guatemala", 2, 1, "Nisi animi ut.", "d3948b32-992b-4165-acb1-1912bd51d3f7", 0.032361017141493038, 370L, 2, 0.24518564579344895 },
                    { new Guid("ec35aa06-45e0-4515-a9d1-1c1c834337dc"), "342 Johnston Locks, New Brentchester, Lithuania", 3, 4, "Perspiciatis in modi.", "b93c1225-e090-4cf6-9bdf-ee22e647a9f3", 0.049712483782661021, 381L, 1, 0.78516409839881618 },
                    { new Guid("ed61a9ab-2a76-4ee9-bd4f-1c60841d1b71"), "23537 O'Hara Key, Spencerbury, Seychelles", 6, 3, "Illum accusantium debitis.", "0a967d8d-d2e4-41e2-baba-50b6aa96f781", 0.034315606397801887, 737L, 3, 0.75160945537587065 },
                    { new Guid("f18a0ff1-d3f6-49f7-99d3-b0e1d2df7951"), "21396 Obie Isle, Bradtkechester, Cuba", 8, 2, "Consectetur ut aut.", "40d54930-899b-491e-a73e-e7359cbecced", 0.038001055553054039, 477L, 1, 0.65945249940529227 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1ae934f5-137c-4f51-bc01-20b02eecfe0b"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1e86879d-14a8-4820-a39a-647d60b94b2e"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1fe8bce1-27a9-4749-814e-e48363601123"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("243b0c6a-bd37-4f7b-b29f-9983392ef867"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("2e9ebc73-1f2b-47ae-983f-a05521419269"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("32b60fc7-5fdb-4036-ab5d-1ba10eaade6c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("3688429c-47b0-4e23-9e57-33ee98f588b5"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("493f2dad-957f-4834-9def-e518316bce7c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("49d54290-1d66-444d-ac93-d315d4d06778"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("9635f2ff-5e40-4be8-865d-e77b086720e6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a8d7a7f0-6561-43fc-83f2-9bbeeed97121"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("bdcc55d8-0cd0-4361-a983-4ef285503695"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("bf64fa9a-774d-4e99-b17d-a579efe2a25e"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("c177a782-6004-4013-80a4-531f6d7a3c0b"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("c1f6bd65-7d25-4db6-94c1-39599c081f66"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("d9483c88-149c-4208-b698-a178e46ede7c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("e4f9a37b-aacb-4418-845f-d64dd5f2d5cf"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("ec35aa06-45e0-4515-a9d1-1c1c834337dc"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("ed61a9ab-2a76-4ee9-bd4f-1c60841d1b71"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f18a0ff1-d3f6-49f7-99d3-b0e1d2df7951"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f06c0f8-0a17-457a-9550-3a24bc574200");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48f067fb-4f7b-4fc7-bd2e-b7e32aab0e6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd33f26b-ecf7-46dc-81b4-72a20ac57040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e09ca7ef-b41f-42a5-aa40-24a947e3cdb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0323fbbf-53bd-47d6-a440-53ac523cf4d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a967d8d-d2e4-41e2-baba-50b6aa96f781");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d2a54a4-56a8-44e9-83c2-f5804b317261");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40d54930-899b-491e-a73e-e7359cbecced");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b93c1225-e090-4cf6-9bdf-ee22e647a9f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9cd9883-962a-4142-b293-1c9f10416063");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba8a57b0-95e2-4064-9bdb-ebe5ddf8044e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3948b32-992b-4165-acb1-1912bd51d3f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef52febd-2ea8-4a36-8164-606fedd5bdcd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7b3312d-ac3e-482a-82c1-24b3f0df84ae");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExperyTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cea8b97-1d44-4abc-88c2-0a01a180349c", null, "Manager", "MANAGER" },
                    { "2e28c02e-f094-40df-8eec-8ce9c550c7ca", null, "ApartmentOwner", "APARTMENT_OWNER" },
                    { "56365493-aa14-4bda-a617-f839fb5401b3", null, "User", "USER" },
                    { "5e35e787-0820-4524-bd32-1b99cabf3654", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04fe9541-cfc0-4951-93fc-caf65c17c1db", 0, "fba07b89-28e8-480f-a4b8-aa107bd294d1", null, false, "Buster", "Olson", false, null, null, null, null, "1-312-320-1559", false, "0a4119ec-3ad8-4793-a0d7-bf329dafcc53", false, null },
                    { "1185d9f0-b511-4d3c-8b37-d9de82c4db39", 0, "c3b42fb4-3a0e-4356-a0a0-be79fd011492", null, false, "Clotilde", "Wisozk", false, null, null, null, null, "572-730-7974", false, "42b234b9-2992-48c1-b948-93ee069c4bf8", false, null },
                    { "16e81a02-08a8-4ecc-9b55-80ee5f4fb4dc", 0, "62e38839-56c8-486a-93dd-03e265320fef", null, false, "Boris", "Crooks", false, null, null, null, null, "(790) 214-0596 x77977", false, "70e859ff-3781-478f-a960-dcfe9220309f", false, null },
                    { "321420ce-3d16-4c79-ae3a-7614a67812d1", 0, "a742fb51-4b28-4095-af06-f642e6bf1f37", null, false, "Micah", "Sauer", false, null, null, null, null, "218.232.7266 x6289", false, "01253c51-b7cd-44e3-975d-1bbfa7b821e0", false, null },
                    { "54d12ad0-b4da-488d-9a1a-ad6e32098177", 0, "e272805c-2696-419d-a828-9b95691248eb", null, false, "Isidro", "Parker", false, null, null, null, null, "1-613-568-2334", false, "9752dd0d-ae14-4adf-a8ef-792c5df8b695", false, null },
                    { "5507f4df-2fac-4428-92fb-8c5da18a6976", 0, "1b99cdc1-c20f-4bd4-9937-87388ac55730", null, false, "Pauline", "McClure", false, null, null, null, null, "1-793-428-6042", false, "441bf689-ff11-4be8-ae37-936fe55a597b", false, null },
                    { "6d173c0b-14fb-4f8e-bcbd-cbac0c0cc87e", 0, "17a2f6a5-650f-40ea-8ee8-db51d0a26cb9", null, false, "Rhiannon", "Batz", false, null, null, null, null, "237.818.1548 x247", false, "e8316e72-2b0f-44db-8866-daaf23fca1a1", false, null },
                    { "98fa0699-d564-4c26-88b5-3d990951537a", 0, "ec725f61-7158-45c9-80e2-05bf78b0d58c", null, false, "Cordia", "Gibson", false, null, null, null, null, "290.743.1619 x8094", false, "9ca1a074-1bed-40e2-9101-3290f6028f96", false, null },
                    { "cefa5530-8d8d-4431-b551-67d75eebb313", 0, "b070a333-05a2-4437-9d3d-810a8ec486ad", null, false, "Damaris", "Corwin", false, null, null, null, null, "278-214-7417 x435", false, "b3d00e12-d0c1-4df9-9389-37857805d2cd", false, null },
                    { "fba14356-5a90-4756-b8f4-5e0d375630b8", 0, "f9e65e8d-b160-41ff-b3ab-16f4bdb1b426", null, false, "Schuyler", "Roberts", false, null, null, null, null, "883-689-0174", false, "43421ed0-97ce-4649-be4d-eeec5582e126", false, null }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentId", "Address", "BedsCount", "GuestsCount", "Name", "OwnerId", "Rate", "ReviewsCount", "RoomsCount", "Square" },
                values: new object[,]
                {
                    { new Guid("13dc134a-3f9c-4a0c-adfb-8e2f24932529"), "07119 Shaniya Island, Hermistonstad, Kyrgyz Republic", 2, 11, "띢⤗鎞᯻漬ݴ釫瞬", "cefa5530-8d8d-4431-b551-67d75eebb313", 0.039374453656426285, 758685472L, 3, 0.41466016972059089 },
                    { new Guid("16782832-5b96-401c-b9a6-c0eb47c879f4"), "6797 Jakubowski Burgs, Hassanmouth, Congo", 2, 11, "椈㌔�鼨菁찎꽩ꍪ퓧౵", "98fa0699-d564-4c26-88b5-3d990951537a", 0.0973245722610626, 1427562338L, 1, 0.76408841991331156 },
                    { new Guid("1dbeeffd-4e8b-40f6-9f2b-d9471513b606"), "0167 Elena Springs, Volkmanborough, Pakistan", 6, 1, "쏳얠爥墭눱�妄疥猋霰", "04fe9541-cfc0-4951-93fc-caf65c17c1db", 0.065019609528503608, 1441739267L, 1, 0.73698411247231976 },
                    { new Guid("2e8cd2b7-9f36-44fc-b39c-2acfb6c1fc8a"), "09583 Clemens Plain, Wilbermouth, Ireland", 3, 10, "假⽻털ꎱﯢ초휩ⷬꏮ韨", "321420ce-3d16-4c79-ae3a-7614a67812d1", 0.072125256690444089, 921275470L, 1, 0.60050631080302341 },
                    { new Guid("38fd0bd3-3ffc-43ee-862d-12349d08a596"), "200 Marvin Knolls, West Irving, Turkmenistan", 5, 11, "蓙猓硺䉹�ـꐬ㬌", "04fe9541-cfc0-4951-93fc-caf65c17c1db", 0.040516370175228827, 1681220667L, 4, 0.15406867528471244 },
                    { new Guid("45268d30-fa8b-4fec-8067-b08db2a25a60"), "77755 Mann Landing, Lake Jerelport, Eritrea", 3, 11, "㡁农擜馽뤷ꌅㅑ惩㖫", "5507f4df-2fac-4428-92fb-8c5da18a6976", 0.004389061677205798, 1745338022L, 4, 0.99136779752850945 },
                    { new Guid("49eec6a0-7d95-41f3-aae2-bed91c7062c8"), "10132 Becker Well, Prudencemouth, Peru", 3, 11, "匩빋�씐㈒㏊嬩詇", "16e81a02-08a8-4ecc-9b55-80ee5f4fb4dc", 0.086084672697905068, 526744234L, 2, 0.33234321178941711 },
                    { new Guid("4cb56703-b3f3-4160-9ed1-ea3b1884aab3"), "15104 Addie Overpass, Tiastad, Indonesia", 4, 12, "邓躞Ꞣ䁴覠﩮ꧦ粄�", "16e81a02-08a8-4ecc-9b55-80ee5f4fb4dc", 0.095205159972546194, 586076518L, 1, 0.37306226112969604 },
                    { new Guid("68dbc805-f4f3-4605-94d0-6eb6abf8520c"), "016 Melyssa Club, South Hansmouth, Panama", 2, 10, "祫Ჸ垿睇窆羅䷀�", "98fa0699-d564-4c26-88b5-3d990951537a", 0.040875162869217163, 159198858L, 2, 0.81186010871622249 },
                    { new Guid("7567e886-2032-42d2-839f-ef0492c4f927"), "652 Larson Prairie, Forestport, Kyrgyz Republic", 1, 5, "ᨚ쥺衤෸⠇輗蓓钂《�", "54d12ad0-b4da-488d-9a1a-ad6e32098177", 0.026731343023977307, 160694619L, 3, 0.84901921385082457 },
                    { new Guid("8bc0b6cc-6c48-4b4b-87c8-938d6d326718"), "154 Javier Highway, North Goldenstad, Bermuda", 8, 3, "㋴藴윬罰揚㧚折᫇�", "6d173c0b-14fb-4f8e-bcbd-cbac0c0cc87e", 0.039160907396088122, 893414872L, 4, 0.23023719493163816 },
                    { new Guid("933f5dfa-b8ea-44bf-8045-bc62bd51524a"), "9120 Simone Harbor, Lake Alizeberg, Venezuela", 7, 8, "볼伮㝛莵簟뒻긟肧ᗬ䘳", "cefa5530-8d8d-4431-b551-67d75eebb313", 0.01935986145582368, 437151648L, 4, 0.94087338105029694 },
                    { new Guid("a24b2e56-1ec6-486a-8033-bf84239858eb"), "87522 Stokes Coves, South Cleve, Dominica", 3, 1, "쳞輧贡撔昋驅ᴒ证蝐", "6d173c0b-14fb-4f8e-bcbd-cbac0c0cc87e", 0.0041568771843824431, 1807573545L, 4, 0.88592323607411017 },
                    { new Guid("ad8efa22-3113-4dd4-aa79-cc37d97466e8"), "73353 Beahan Lane, Kreigershire, South Georgia and the South Sandwich Islands", 8, 3, "‘䒝ﯰý῎㽫쉛偕k", "54d12ad0-b4da-488d-9a1a-ad6e32098177", 0.077126147313868992, 984073980L, 2, 0.98876125801219061 },
                    { new Guid("b44eea52-4cd8-4788-904b-c0c4c41d6d36"), "781 Kurtis Creek, Hicklefurt, Saint Helena", 8, 4, "ִ躭ư甐ᖚ煮ഝ", "fba14356-5a90-4756-b8f4-5e0d375630b8", 0.033142839721575709, 1693513771L, 1, 0.80001382055134607 },
                    { new Guid("bfdbf68c-f4e8-4003-9354-e870fb96d27e"), "7300 Juana Stravenue, South Gerhardborough, Ethiopia", 6, 7, "꘨스䏩枿⹾；侉䫣嵑�", "1185d9f0-b511-4d3c-8b37-d9de82c4db39", 0.068443370411677959, 548121382L, 4, 0.37841684916962576 },
                    { new Guid("c200fa81-cd98-4fe7-8a7f-5b3f555551db"), "90380 Benedict Lock, Kertzmannbury, Colombia", 6, 12, "ᅓ꯹�ٽ⎳ㆥ鴫筞Ｙ", "321420ce-3d16-4c79-ae3a-7614a67812d1", 0.0042753090014248894, 201129124L, 2, 0.7748539275515024 },
                    { new Guid("cbd009ee-9024-42cc-b459-976777989bf7"), "505 Metz Ports, Lake Luna, South Africa", 4, 9, "㺞瀩ⵥ஠�팟⓸ᗓ날쥖", "5507f4df-2fac-4428-92fb-8c5da18a6976", 0.03480128512865345, 115416269L, 1, 0.72704874314556223 },
                    { new Guid("d250e216-13ee-4b1c-8250-57229417ffb6"), "8132 Dominique Courts, Lake Allisonfort, Libyan Arab Jamahiriya", 3, 9, "꼛죰욑ﯡ䣶࿝◄鐎", "fba14356-5a90-4756-b8f4-5e0d375630b8", 0.043783132969357819, 966366500L, 1, 0.15565815762644733 },
                    { new Guid("e96538c0-c854-4a1a-8b39-9ec6fbadcdcb"), "694 Ledner Ports, North Kristoffer, Niger", 4, 6, "ꋶٖ覅蟎ꬤ⌉飗蛀ﮤ", "1185d9f0-b511-4d3c-8b37-d9de82c4db39", 0.088313964846845353, 889358515L, 3, 0.42293483819530553 }
                });
        }
    }
}
