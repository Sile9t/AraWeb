using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AraWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OccupStateId = table.Column<int>(type: "int", nullable: false),
                    ReservedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
