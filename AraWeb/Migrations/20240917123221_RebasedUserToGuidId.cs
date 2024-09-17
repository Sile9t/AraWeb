using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AraWeb.Migrations
{
    /// <inheritdoc />
    public partial class RebasedUserToGuidId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExperyTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateState",
                columns: table => new
                {
                    DateStateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateState", x => x.DateStateId);
                });

            migrationBuilder.CreateTable(
                name: "OccupState",
                columns: table => new
                {
                    OccupStateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupState", x => x.OccupStateId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Square = table.Column<double>(type: "float", nullable: false),
                    GuestsCount = table.Column<int>(type: "int", nullable: false),
                    BedsCount = table.Column<int>(type: "int", nullable: false),
                    RoomsCount = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    ReviewsCount = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentId);
                    table.ForeignKey(
                        name: "FK_Apartments_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Occupancies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccupancyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EvictionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    OccupStateId = table.Column<int>(type: "int", nullable: false),
                    ReservedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Occupancies_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Occupancies_AspNetUsers_ReservedById",
                        column: x => x.ReservedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Occupancies_OccupState_OccupStateId",
                        column: x => x.OccupStateId,
                        principalTable: "OccupState",
                        principalColumn: "OccupStateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationDates",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    ExtraCharge = table.Column<double>(type: "float", nullable: false),
                    DateStateId = table.Column<int>(type: "int", nullable: false),
                    OccupancyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDates", x => new { x.Date, x.ApartmentId });
                    table.ForeignKey(
                        name: "FK_ReservationDates_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDates_DateState_DateStateId",
                        column: x => x.DateStateId,
                        principalTable: "DateState",
                        principalColumn: "DateStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDates_Occupancies_OccupancyId",
                        column: x => x.OccupancyId,
                        principalTable: "Occupancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "DateState",
                columns: new[] { "DateStateId", "Description", "Name" },
                values: new object[,]
                {
                    { 0, null, "Empty" },
                    { 1, null, "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "OccupState",
                columns: new[] { "OccupStateId", "Description", "Name" },
                values: new object[,]
                {
                    { 0, null, "Created" },
                    { 1, null, "Pushed" },
                    { 2, null, "Submited" },
                    { 3, null, "Reserved" },
                    { 4, null, "Cancelled" },
                    { 5, null, "Passed" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_OwnerId",
                table: "Apartments",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_ApartmentId",
                table: "Occupancies",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_OccupStateId",
                table: "Occupancies",
                column: "OccupStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_ReservedById",
                table: "Occupancies",
                column: "ReservedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDates_ApartmentId",
                table: "ReservationDates",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDates_DateStateId",
                table: "ReservationDates",
                column: "DateStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDates_OccupancyId",
                table: "ReservationDates",
                column: "OccupancyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ReservationDates");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DateState");

            migrationBuilder.DropTable(
                name: "Occupancies");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "OccupState");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
