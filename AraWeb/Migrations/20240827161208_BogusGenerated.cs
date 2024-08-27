using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AraWeb.Migrations
{
    /// <inheritdoc />
    public partial class BogusGenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0024520e-9781-4fad-8248-9ffe017ac4d1"), "Hubert", "550.379.2140 x3192" },
                    { new Guid("1e0ff627-aadf-4266-aa70-d930960696db"), "Ruby", "1-338-801-6652" },
                    { new Guid("2d467980-ff3d-4572-b126-26bccb2f31e8"), "Halie", "(761) 809-0397 x2076" },
                    { new Guid("89f2b834-6d07-488b-bb97-e9debebb6f86"), "Ernestine", "951.477.5999 x341" },
                    { new Guid("90448a16-0f00-4fc0-bf6c-0f8e545876dc"), "Devyn", "(424) 495-2883" },
                    { new Guid("a432befa-d141-420a-950a-8ed8df55befb"), "Rashawn", "(347) 351-0621 x7977" },
                    { new Guid("c914b7a9-4c93-4179-b5aa-98ae4e1b0271"), "Judd", "739.621.9623 x569" },
                    { new Guid("df8a4170-9800-4a7c-b61d-e417d97cb2c8"), "Brendon", "(900) 689-8731 x603" },
                    { new Guid("fc27675e-ee5d-4f0a-b79a-5a1b7c1f3d8a"), "Brandyn", "723.956.9175 x0916" },
                    { new Guid("ff49bb87-b0cc-4fea-91e2-24d0aedfb4bc"), "Arvid", "385.608.5588 x1476" }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentId", "Address", "BedsCount", "CapacitySquare", "GuestsCount", "Name", "OwnerId", "Rate", "ReviewsCount", "RoomsCount" },
                values: new object[,]
                {
                    { new Guid("054ec238-fff0-463a-8311-9b0b9324e1b0"), "458 Connelly Terrace, Nadermouth, Seychelles", 6, 74.93856081946528, 5, "犅溞緈䜿됀訌捻ޗᘴ䰥", new Guid("a432befa-d141-420a-950a-8ed8df55befb"), 0.80792508907260407, 699528502L, 1 },
                    { new Guid("0b0d3208-237c-4958-8989-34c1ea298db6"), "8441 Schiller Crescent, Einarberg, Saudi Arabia", 5, 79.982866131223389, 7, "೚뿉잪篛孝齦ㄶ吊烍�", new Guid("0024520e-9781-4fad-8248-9ffe017ac4d1"), 0.71925656716514141, 798476779L, 4 },
                    { new Guid("15d98c54-40d2-4573-9d26-e56a0053d8ca"), "16149 Emmett Skyway, Wunschfurt, Cayman Islands", 6, 81.325115686313836, 1, "㐖Ꚕ됦厯믿廽⵿虜灓䁄", new Guid("2d467980-ff3d-4572-b126-26bccb2f31e8"), 0.060154017728358267, 1539211074L, 4 },
                    { new Guid("29121930-efb2-472a-97dd-28b6f365c7d0"), "0556 Dale Cliff, Jacobishire, Nigeria", 2, 97.055198982861683, 5, "깆ﴴਸ਼잚ꘁ蝞㤀酦받", new Guid("c914b7a9-4c93-4179-b5aa-98ae4e1b0271"), 0.29488897170200989, 962002728L, 3 },
                    { new Guid("2a67d595-7755-442a-9a42-37f2640813d8"), "138 Volkman Rue, Lake Christop, Guatemala", 4, 33.203785895073821, 6, "ꨘʺ㒅陖蟑崤ꌨ⚡㼃ꐭ", new Guid("89f2b834-6d07-488b-bb97-e9debebb6f86"), 0.41445252582852798, 136837581L, 3 },
                    { new Guid("2aa5c6d0-1ca1-4c31-8c8f-0421c7790c20"), "452 Tony Lodge, Johnsonside, Honduras", 5, 36.855637839569241, 9, "徟ⓐ燡檔㐠ﮊᗍ矹Ʝ", new Guid("89f2b834-6d07-488b-bb97-e9debebb6f86"), 0.2198523486543863, 1975188694L, 3 },
                    { new Guid("2c3d1dd2-c751-474e-ba5c-3081e3ba4957"), "158 Durgan Well, Kyleemouth, Colombia", 7, 3.5906625697719297, 11, "ꦰ횵䤆஥尥膱쎑댺㪭", new Guid("1e0ff627-aadf-4266-aa70-d930960696db"), 0.041324305236304704, 19995276L, 1 },
                    { new Guid("350690b0-9e86-4cb4-ba63-799ca7330719"), "146 Kellen Mountain, Port Ted, Pitcairn Islands", 8, 24.365707975294303, 11, "ￎ┸羏ꥭ�涅ᓲ칡㛃", new Guid("90448a16-0f00-4fc0-bf6c-0f8e545876dc"), 0.07170099805725938, 782697435L, 1 },
                    { new Guid("4a098679-9acf-4849-8837-a20c6a42bad0"), "39639 Crist Plains, Thadfort, Tanzania", 7, 85.695926116362315, 7, "慾耠㴅翙鉪勖弛한⮎뿙", new Guid("ff49bb87-b0cc-4fea-91e2-24d0aedfb4bc"), 0.49368434952338625, 387162089L, 2 },
                    { new Guid("89985a40-e9e2-40df-b976-90f0c1d4d46d"), "219 Joey Mall, Harbermouth, Uganda", 4, 84.965639084534232, 1, "ꖆ뛷孓猰듦䭢㗼䝀绝", new Guid("df8a4170-9800-4a7c-b61d-e417d97cb2c8"), 0.45249321890572369, 994301788L, 4 },
                    { new Guid("a2620e00-2a9e-402a-82be-179643c1f9d8"), "413 Lueilwitz Groves, East Adahton, Oman", 6, 89.947147117267562, 5, "擈ꮅ憾햁˪⢚ᮮ뷕", new Guid("2d467980-ff3d-4572-b126-26bccb2f31e8"), 0.40746795922977352, 600323978L, 2 },
                    { new Guid("a2b81065-ae1f-4919-9046-185c8de9f26d"), "122 Boyd Ports, North Amelia, Antigua and Barbuda", 3, 40.822095068848007, 5, "飭뉓뿢춧岎ዯ䄸᧪⌍", new Guid("a432befa-d141-420a-950a-8ed8df55befb"), 0.79686464256281475, 2128596321L, 3 },
                    { new Guid("a7401f79-6ed1-4934-a1db-5542719a8d16"), "04529 Lucio Prairie, Francismouth, Ethiopia", 1, 60.750570367200631, 1, "䯫斂仾岻�᰿扨㭞", new Guid("fc27675e-ee5d-4f0a-b79a-5a1b7c1f3d8a"), 0.65649881672000399, 1358213207L, 1 },
                    { new Guid("a89f6840-ecb1-4470-924c-0ddf3cf3636b"), "720 Shayne Squares, South Lisette, Swaziland", 3, 75.868508992157743, 3, "ᇶ澕쏌薄噞汞ꂜ䤊턡", new Guid("90448a16-0f00-4fc0-bf6c-0f8e545876dc"), 0.86278800714883419, 1404847108L, 4 },
                    { new Guid("ade910e1-2ed7-44be-9430-53740041d43c"), "6577 Blanca Row, Schmelerside, Kenya", 5, 4.5790676396517576, 1, "餐惇ꕠ︨᧡�岹쵄靃", new Guid("fc27675e-ee5d-4f0a-b79a-5a1b7c1f3d8a"), 0.64076560253600623, 490744323L, 2 },
                    { new Guid("bacd01f6-7e6f-46f8-9144-92374a85f7cf"), "098 Roselyn Track, Lake Rowenastad, Guatemala", 6, 84.90161086156796, 1, "邢冂蘙皂㻢质눈럥鰆", new Guid("c914b7a9-4c93-4179-b5aa-98ae4e1b0271"), 0.34327804074268031, 1383901836L, 2 },
                    { new Guid("da594fbb-e62a-4bd9-8140-2b7b16afd528"), "8383 Edwin Estates, Bartolettiburgh, Bulgaria", 4, 8.3552779825553749, 1, "˨噋呂扉✉㺪粀׮١", new Guid("1e0ff627-aadf-4266-aa70-d930960696db"), 0.1070992044864717, 937056584L, 1 },
                    { new Guid("ee556b10-d4f3-42c6-a489-cb4be972b8cd"), "80408 Wunsch Square, Klockostad, Argentina", 8, 83.176691735345443, 12, "칋켛࿼쾠�隌�橱౉憘", new Guid("df8a4170-9800-4a7c-b61d-e417d97cb2c8"), 0.2199155535088283, 2103860387L, 3 },
                    { new Guid("fa520528-3781-4e61-be39-a600bcb5dd13"), "5550 Schultz Shoal, South Kristin, Jamaica", 4, 14.026923264678004, 1, "럹譃돯断ࣆ머顅", new Guid("0024520e-9781-4fad-8248-9ffe017ac4d1"), 0.88675543034703075, 996612426L, 1 },
                    { new Guid("fd968687-a318-4d38-a5fd-92eb23acf0f6"), "04975 Legros Mews, North Ciaramouth, Namibia", 4, 70.460020867726101, 3, "䩭⮇烇�Ƞ�☰턏郼", new Guid("ff49bb87-b0cc-4fea-91e2-24d0aedfb4bc"), 0.14495771218798181, 640144442L, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("054ec238-fff0-463a-8311-9b0b9324e1b0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("0b0d3208-237c-4958-8989-34c1ea298db6"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("15d98c54-40d2-4573-9d26-e56a0053d8ca"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("29121930-efb2-472a-97dd-28b6f365c7d0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("2a67d595-7755-442a-9a42-37f2640813d8"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("2aa5c6d0-1ca1-4c31-8c8f-0421c7790c20"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("2c3d1dd2-c751-474e-ba5c-3081e3ba4957"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("350690b0-9e86-4cb4-ba63-799ca7330719"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("4a098679-9acf-4849-8837-a20c6a42bad0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("89985a40-e9e2-40df-b976-90f0c1d4d46d"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a2620e00-2a9e-402a-82be-179643c1f9d8"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a2b81065-ae1f-4919-9046-185c8de9f26d"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a7401f79-6ed1-4934-a1db-5542719a8d16"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a89f6840-ecb1-4470-924c-0ddf3cf3636b"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("ade910e1-2ed7-44be-9430-53740041d43c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("bacd01f6-7e6f-46f8-9144-92374a85f7cf"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("da594fbb-e62a-4bd9-8140-2b7b16afd528"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("ee556b10-d4f3-42c6-a489-cb4be972b8cd"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("fa520528-3781-4e61-be39-a600bcb5dd13"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("fd968687-a318-4d38-a5fd-92eb23acf0f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0024520e-9781-4fad-8248-9ffe017ac4d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e0ff627-aadf-4266-aa70-d930960696db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d467980-ff3d-4572-b126-26bccb2f31e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89f2b834-6d07-488b-bb97-e9debebb6f86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90448a16-0f00-4fc0-bf6c-0f8e545876dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a432befa-d141-420a-950a-8ed8df55befb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c914b7a9-4c93-4179-b5aa-98ae4e1b0271"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df8a4170-9800-4a7c-b61d-e417d97cb2c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc27675e-ee5d-4f0a-b79a-5a1b7c1f3d8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff49bb87-b0cc-4fea-91e2-24d0aedfb4bc"));
        }
    }
}
