using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StocksApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Faked_Initial_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StcokSymbol",
                table: "SellOrders",
                newName: "StockSymbol");

            migrationBuilder.InsertData(
                table: "BuyOrders",
                columns: new[] { "BuyOrderID", "DateAndTimeOfOrder", "Price", "Quantity", "StockName", "StockSymbol" },
                values: new object[,]
                {
                    { new Guid("00169571-229e-1f5b-8721-bfb1d952a2e6"), new DateTime(2026, 11, 25, 18, 23, 47, 859, DateTimeKind.Utc).AddTicks(9711), 2314.8800000000001, 21816L, "Strosin, Gutkowski and Erdman", "" },
                    { new Guid("005ad229-a2a2-667b-1078-ff2081fc03a4"), new DateTime(2027, 1, 4, 13, 30, 8, 193, DateTimeKind.Utc).AddTicks(7717), 3535.4299999999998, 127L, "Moen - Mitchell", "" },
                    { new Guid("0061b8ad-4a19-7ec3-6a56-7ee4bcb99485"), new DateTime(2027, 3, 27, 12, 4, 51, 491, DateTimeKind.Utc).AddTicks(7778), 2820.3400000000001, 60125L, "Bernhard LLC", "" },
                    { new Guid("00754472-05c6-05ae-cb4e-2410d546b4a3"), new DateTime(2027, 7, 23, 22, 14, 9, 695, DateTimeKind.Utc).AddTicks(412), 4042.0300000000002, 28404L, "Schaefer Inc", "£" },
                    { new Guid("00802371-f1c9-a9e0-5696-2d8f286d2082"), new DateTime(2026, 11, 6, 15, 12, 57, 235, DateTimeKind.Utc).AddTicks(977), 4695.6000000000004, 18176L, "Ryan Inc", "" },
                    { new Guid("00b27d9f-2035-6b20-69e0-75767ba6179a"), new DateTime(2027, 4, 9, 15, 31, 30, 622, DateTimeKind.Utc).AddTicks(414), 5824.5500000000002, 33256L, "Koch Inc", "ƒ" },
                    { new Guid("00df9efd-b340-31b9-1f7b-8d06b39cb1f8"), new DateTime(2026, 11, 5, 1, 5, 7, 318, DateTimeKind.Utc).AddTicks(2678), 488.61000000000001, 18159L, "Cronin, Koch and Gerhold", "" },
                    { new Guid("010440c0-01f1-2799-7179-d3d5aa42c7bf"), new DateTime(2027, 5, 7, 6, 33, 18, 193, DateTimeKind.Utc).AddTicks(5753), 2818.4400000000001, 62248L, "Legros - Runolfsson", "" },
                    { new Guid("01d4cf3c-a5a6-501b-db1f-6ccdb87f4fed"), new DateTime(2026, 11, 11, 1, 23, 0, 754, DateTimeKind.Utc).AddTicks(2057), 2703.8899999999999, 14917L, "Barrows, Deckow and Herzog", "₱" },
                    { new Guid("01e79412-23c0-fedc-3ede-502ec5d7eabe"), new DateTime(2026, 10, 5, 0, 7, 40, 549, DateTimeKind.Utc).AddTicks(5430), 207.03999999999999, 70984L, "Ankunding - Altenwerth", "CHF" },
                    { new Guid("01eb7423-d8df-f3c2-f4d4-163ad975a61e"), new DateTime(2027, 8, 1, 1, 11, 53, 622, DateTimeKind.Utc).AddTicks(4055), 3495.5799999999999, 94427L, "Kirlin Group", "₨" },
                    { new Guid("01f37192-2eb0-9afa-f258-3cafeb868e1c"), new DateTime(2027, 3, 23, 23, 54, 18, 965, DateTimeKind.Utc).AddTicks(654), 3528.3899999999999, 49431L, "Watsica Inc", "$" },
                    { new Guid("025951a3-6e9b-a6e0-fc38-2a7e67746e0c"), new DateTime(2026, 11, 3, 3, 13, 11, 319, DateTimeKind.Utc).AddTicks(2583), 9322.9699999999993, 15471L, "Hartmann Inc", "£" },
                    { new Guid("026179fb-6366-587e-47fc-a0106ce4a87c"), new DateTime(2026, 11, 25, 2, 1, 6, 313, DateTimeKind.Utc).AddTicks(8866), 6922.6999999999998, 85543L, "Goyette Group", "лв" },
                    { new Guid("02bab5af-da41-dda8-2673-4a0fb23e788c"), new DateTime(2027, 4, 13, 8, 30, 22, 439, DateTimeKind.Utc).AddTicks(9192), 2917.1500000000001, 18791L, "Ortiz Group", "" },
                    { new Guid("03131ab3-b51c-c888-2b5f-a44740c8f40b"), new DateTime(2027, 3, 26, 5, 12, 25, 142, DateTimeKind.Utc).AddTicks(281), 84.799999999999997, 47545L, "Harvey - Rath", "" },
                    { new Guid("0362aef5-c1d3-0564-f120-b80b8e96d7d7"), new DateTime(2027, 2, 3, 23, 25, 8, 697, DateTimeKind.Utc).AddTicks(6131), 3496.0900000000001, 97225L, "Mertz - Grimes", "" },
                    { new Guid("0365cb57-4d72-1949-8554-522f8dfff504"), new DateTime(2026, 10, 6, 6, 33, 55, 101, DateTimeKind.Utc).AddTicks(6917), 3169.0799999999999, 41750L, "Huel LLC", "kr" },
                    { new Guid("03775e33-63b3-7dd7-310b-bec6b02cb285"), new DateTime(2027, 2, 12, 14, 9, 42, 12, DateTimeKind.Utc).AddTicks(2931), 2914.5799999999999, 42600L, "Hilll, Daugherty and Yundt", "؋" },
                    { new Guid("0378f923-7cd2-d9b2-c871-34b77ee238d1"), new DateTime(2027, 3, 8, 19, 15, 40, 216, DateTimeKind.Utc).AddTicks(7629), 8104.5299999999997, 10273L, "Wolf, Yost and Schroeder", "P" },
                    { new Guid("03c62b53-fa38-18db-1d6a-78e9658b049e"), new DateTime(2027, 6, 6, 17, 32, 39, 14, DateTimeKind.Utc).AddTicks(5153), 3645.1900000000001, 32014L, "McCullough, Glover and Crona", "" },
                    { new Guid("03c64df0-1b68-6936-4f36-54401785d8f0"), new DateTime(2026, 12, 12, 17, 20, 25, 532, DateTimeKind.Utc).AddTicks(1663), 2183.23, 1990L, "Rath - Blick", "$" },
                    { new Guid("03df7668-6842-d0fe-4b16-1ebeaaa494d1"), new DateTime(2026, 9, 22, 14, 59, 14, 617, DateTimeKind.Utc).AddTicks(5255), 2858.25, 39797L, "Corwin, Fadel and Hackett", "₡" },
                    { new Guid("03ee69ae-d957-8704-4858-5dd45615f6e4"), new DateTime(2027, 7, 11, 17, 5, 18, 960, DateTimeKind.Utc).AddTicks(122), 4784.4099999999999, 89379L, "Medhurst, Skiles and Hyatt", "lei" },
                    { new Guid("0570e33d-f832-bc0a-36c6-331710e88ae6"), new DateTime(2027, 2, 8, 5, 17, 55, 201, DateTimeKind.Utc).AddTicks(1756), 2161.4699999999998, 3687L, "Kilback - Kihn", "$" },
                    { new Guid("0599cb8d-dc7e-695c-2218-349c464779b0"), new DateTime(2027, 7, 31, 8, 26, 41, 11, DateTimeKind.Utc).AddTicks(5731), 7239.4700000000003, 99392L, "Toy - Dietrich", "﷼" },
                    { new Guid("05b288c1-238b-26f1-5163-794459ccac06"), new DateTime(2026, 11, 15, 15, 59, 56, 954, DateTimeKind.Utc).AddTicks(7536), 1554.95, 66978L, "Pagac Inc", "Nu" },
                    { new Guid("06b6e1e6-f38a-8129-c7c2-bf0c7b0d9fe2"), new DateTime(2027, 7, 29, 8, 51, 26, 345, DateTimeKind.Utc).AddTicks(4836), 2072.7399999999998, 47646L, "Kulas, Crooks and Conroy", "лв" },
                    { new Guid("06ba630a-f151-5157-dc64-5ff81db33f15"), new DateTime(2026, 10, 1, 7, 30, 28, 809, DateTimeKind.Utc).AddTicks(6396), 1768.0699999999999, 71961L, "Mueller Group", "" },
                    { new Guid("06e7a0fb-68e1-cd4b-adef-3c38d2113e3a"), new DateTime(2026, 12, 30, 4, 9, 13, 500, DateTimeKind.Utc).AddTicks(1975), 8263.0, 36676L, "Monahan - Cremin", "" },
                    { new Guid("072076fa-051a-4048-396c-12ed168e0413"), new DateTime(2027, 2, 24, 19, 0, 21, 339, DateTimeKind.Utc).AddTicks(118), 8676.8199999999997, 75380L, "Wisozk Group", "" },
                    { new Guid("074b6738-3a18-c2f8-9425-bc9cdb5e34fc"), new DateTime(2027, 1, 9, 19, 49, 57, 250, DateTimeKind.Utc).AddTicks(7343), 2916.8499999999999, 85636L, "Veum and Sons", "" },
                    { new Guid("0793c009-40e5-c835-ef05-f4acc62c0788"), new DateTime(2027, 3, 13, 16, 6, 2, 152, DateTimeKind.Utc).AddTicks(3788), 1448.3800000000001, 55026L, "Hudson LLC", "" },
                    { new Guid("07e1f565-9464-3bcd-f817-4a2c71fc1066"), new DateTime(2026, 8, 10, 22, 43, 32, 685, DateTimeKind.Utc).AddTicks(5507), 7755.1800000000003, 68901L, "Senger LLC", "" },
                    { new Guid("0888e797-87f7-2f84-e38d-a04706841996"), new DateTime(2026, 9, 5, 21, 56, 27, 38, DateTimeKind.Utc).AddTicks(354), 3762.8499999999999, 2718L, "Langosh - Mertz", "C$" },
                    { new Guid("08a5f8a9-e773-cf13-ac62-ddc4282199d2"), new DateTime(2027, 4, 9, 8, 8, 44, 94, DateTimeKind.Utc).AddTicks(9166), 4498.5500000000002, 83940L, "Wolf - Ward", "Db" },
                    { new Guid("08ff2009-6f0f-dca5-0b3b-69b1418bd596"), new DateTime(2027, 3, 21, 9, 33, 7, 607, DateTimeKind.Utc).AddTicks(3245), 4953.1199999999999, 42884L, "Waters Group", "" },
                    { new Guid("08ff9876-774b-c96b-f2c4-b15d32a64e00"), new DateTime(2027, 2, 23, 12, 0, 54, 270, DateTimeKind.Utc).AddTicks(7293), 5637.6999999999998, 77425L, "Donnelly and Sons", "B/." },
                    { new Guid("091de8d0-ee47-9b84-1ab3-1b3986e6356c"), new DateTime(2027, 3, 3, 15, 50, 10, 258, DateTimeKind.Utc).AddTicks(8670), 210.28, 66174L, "Pfeffer - Flatley", "KM" },
                    { new Guid("0966f020-5c98-a49c-03e6-04de417e9711"), new DateTime(2027, 2, 9, 14, 50, 55, 211, DateTimeKind.Utc).AddTicks(9750), 7752.3100000000004, 51488L, "Cummings - Becker", "$" },
                    { new Guid("098b6ecc-5714-b09a-36cf-d6280bb3c707"), new DateTime(2026, 8, 25, 16, 16, 29, 974, DateTimeKind.Utc).AddTicks(5283), 6264.9399999999996, 78165L, "Hoppe, Cormier and Balistreri", "₺" },
                    { new Guid("09cf8d21-4bef-674e-22e3-717b065c0529"), new DateTime(2026, 11, 3, 17, 15, 59, 642, DateTimeKind.Utc).AddTicks(3324), 990.88, 97052L, "Haag LLC", "" },
                    { new Guid("0a363319-6d5e-cb0b-0906-a887caed9ee9"), new DateTime(2027, 5, 11, 4, 30, 31, 467, DateTimeKind.Utc).AddTicks(3294), 7734.9300000000003, 45521L, "Wehner - Raynor", "" },
                    { new Guid("0aadb675-ad70-73e1-6335-248b9b8d5a4f"), new DateTime(2026, 10, 10, 20, 59, 34, 949, DateTimeKind.Utc).AddTicks(8719), 6807.1700000000001, 7735L, "Kirlin LLC", "S/." },
                    { new Guid("0b424345-ac1a-f5e5-88e9-d72edb4b0b37"), new DateTime(2027, 3, 24, 23, 29, 10, 501, DateTimeKind.Utc).AddTicks(4189), 3684.6599999999999, 83893L, "Moen - Gutmann", "Kč" },
                    { new Guid("0b472700-f4e5-2fde-0478-e97c23b8001a"), new DateTime(2026, 9, 19, 3, 50, 18, 378, DateTimeKind.Utc).AddTicks(9760), 8170.2700000000004, 80427L, "Krajcik, O'Reilly and Mitchell", "" },
                    { new Guid("0b679869-5392-a8b6-2c34-7adf470786da"), new DateTime(2027, 7, 2, 3, 32, 2, 105, DateTimeKind.Utc).AddTicks(2840), 2522.0100000000002, 12637L, "Batz Group", "ден" },
                    { new Guid("0b6d82ee-ca51-675a-3d21-950fbb21e891"), new DateTime(2027, 1, 23, 18, 35, 1, 125, DateTimeKind.Utc).AddTicks(3514), 9972.1299999999992, 53479L, "Kertzmann, Rosenbaum and Ratke", "NT$" },
                    { new Guid("0bd0bf25-e516-0354-b8a6-aa71bae89d6a"), new DateTime(2027, 7, 25, 22, 1, 8, 337, DateTimeKind.Utc).AddTicks(176), 365.88999999999999, 56143L, "Satterfield, Erdman and Marquardt", "Ls" },
                    { new Guid("0bf4dc5d-8a6a-dba7-eac1-6417732308ea"), new DateTime(2027, 5, 23, 17, 15, 31, 581, DateTimeKind.Utc).AddTicks(4813), 3533.9099999999999, 62907L, "MacGyver, Brown and Bruen", "" },
                    { new Guid("0c0012dc-a9cf-916e-1a1e-346569b2533f"), new DateTime(2026, 9, 21, 10, 7, 17, 673, DateTimeKind.Utc).AddTicks(7611), 6942.21, 28577L, "Pagac, Mertz and Sipes", "$" },
                    { new Guid("0c5c3e37-1bb8-9526-afaa-5524951b9a14"), new DateTime(2027, 3, 2, 21, 41, 8, 904, DateTimeKind.Utc).AddTicks(3475), 5543.4300000000003, 99410L, "Ryan - Greenholt", "Php" },
                    { new Guid("0c615dbb-36a2-5d9d-c820-3523c9cd0d4b"), new DateTime(2026, 9, 12, 12, 9, 24, 402, DateTimeKind.Utc).AddTicks(2196), 1309.72, 95373L, "Moore - Willms", "ден" },
                    { new Guid("0ca38fdd-9c50-1b5d-4abc-60bcfc7a4094"), new DateTime(2026, 11, 16, 18, 42, 25, 849, DateTimeKind.Utc).AddTicks(9388), 7995.0, 47054L, "Champlin Group", "Bs" },
                    { new Guid("0ca4181b-2620-f988-72f8-90961234a2df"), new DateTime(2026, 10, 21, 18, 17, 18, 554, DateTimeKind.Utc).AddTicks(1367), 8091.8800000000001, 2162L, "Quigley LLC", "" },
                    { new Guid("0d062f64-b4ec-2168-5c6e-f3553416f0d3"), new DateTime(2026, 12, 30, 14, 35, 39, 28, DateTimeKind.Utc).AddTicks(3736), 4779.0799999999999, 45483L, "Collins, Mayer and Rohan", "" },
                    { new Guid("0d179ca5-49a6-c241-daa4-4e368bf846de"), new DateTime(2026, 9, 14, 7, 50, 9, 572, DateTimeKind.Utc).AddTicks(535), 547.61000000000001, 6250L, "McKenzie LLC", "" },
                    { new Guid("0d61cab4-079e-95d9-eb33-891f92b7f7b4"), new DateTime(2026, 10, 31, 13, 3, 9, 291, DateTimeKind.Utc).AddTicks(5693), 4548.1700000000001, 93409L, "Champlin - Champlin", "₴" },
                    { new Guid("0da5b4af-42a5-1be1-3a08-99108ea588a1"), new DateTime(2027, 6, 29, 0, 22, 38, 757, DateTimeKind.Utc).AddTicks(2608), 7540.1300000000001, 92631L, "Harris - Crist", "" },
                    { new Guid("0e1b6d51-0518-a19f-0abf-5f9db9126d18"), new DateTime(2027, 7, 25, 4, 11, 44, 35, DateTimeKind.Utc).AddTicks(2368), 2234.52, 6499L, "Rowe - Hilpert", "" },
                    { new Guid("0e1de641-0cf1-5a6d-0644-6ef3df5f932b"), new DateTime(2026, 11, 12, 21, 32, 14, 537, DateTimeKind.Utc).AddTicks(1733), 7455.3599999999997, 71119L, "McCullough, White and Hane", "" },
                    { new Guid("0e30ae4b-c64a-6797-68a3-c011ea1a231f"), new DateTime(2026, 11, 15, 9, 16, 34, 25, DateTimeKind.Utc).AddTicks(6732), 5252.9300000000003, 67124L, "McDermott - Ledner", "£" },
                    { new Guid("0e52aed8-2b54-f39d-494d-ea4e84cae0e7"), new DateTime(2027, 7, 9, 10, 4, 37, 550, DateTimeKind.Utc).AddTicks(5848), 9400.6299999999992, 36065L, "Harris - VonRueden", "zł" },
                    { new Guid("0e5dd057-0733-3bca-ca73-80e57cb327f1"), new DateTime(2026, 9, 8, 23, 14, 23, 531, DateTimeKind.Utc).AddTicks(1811), 6047.0600000000004, 96804L, "Schultz, VonRueden and Hilpert", "" },
                    { new Guid("0ed89a06-fea1-1516-cac5-468a06072911"), new DateTime(2027, 4, 8, 8, 15, 17, 421, DateTimeKind.Utc).AddTicks(2515), 1386.52, 40764L, "Denesik - Schinner", "$" },
                    { new Guid("0ef5e0e4-0571-7e2d-efe9-b3e53e429bcf"), new DateTime(2027, 4, 9, 8, 32, 7, 153, DateTimeKind.Utc).AddTicks(1841), 2895.46, 71495L, "Yost - Runolfsson", "C$" },
                    { new Guid("0f1afa0c-67f3-3029-6685-3324a1995e9c"), new DateTime(2027, 3, 16, 0, 53, 5, 132, DateTimeKind.Utc).AddTicks(5847), 3366.7600000000002, 10552L, "Botsford - Corkery", "" },
                    { new Guid("0f478f4c-975f-d30b-920b-bfde080779b7"), new DateTime(2027, 1, 12, 3, 26, 40, 421, DateTimeKind.Utc).AddTicks(9452), 5819.7399999999998, 21585L, "Streich Group", "" },
                    { new Guid("0f4a4da7-63c6-e198-0e78-b6b2cc2b58f3"), new DateTime(2027, 3, 5, 12, 25, 32, 320, DateTimeKind.Utc).AddTicks(4999), 4469.3199999999997, 92961L, "Lehner, Kautzer and Hansen", "Db" },
                    { new Guid("0f98133a-952b-370a-3c0d-c0ebf649e5ea"), new DateTime(2027, 6, 6, 15, 6, 52, 434, DateTimeKind.Utc).AddTicks(9563), 6646.6499999999996, 46177L, "Runte - Konopelski", "¥" },
                    { new Guid("10638ec8-d1f3-8510-7364-ca29d8156922"), new DateTime(2026, 12, 12, 4, 29, 38, 60, DateTimeKind.Utc).AddTicks(5197), 2602.4499999999998, 36072L, "O'Hara LLC", "$" },
                    { new Guid("10808bfa-4bfe-15cf-a339-fed11a93e926"), new DateTime(2027, 4, 24, 11, 32, 47, 592, DateTimeKind.Utc).AddTicks(4928), 9220.1000000000004, 38720L, "Crona and Sons", "£" },
                    { new Guid("10c15313-22ee-714f-53ec-c87ce3ad5551"), new DateTime(2027, 7, 13, 1, 23, 24, 657, DateTimeKind.Utc).AddTicks(9530), 7658.21, 52449L, "Murphy, Nader and Block", "₮" },
                    { new Guid("10c23b2e-5959-c714-e16a-751004364871"), new DateTime(2026, 11, 19, 18, 43, 10, 882, DateTimeKind.Utc).AddTicks(243), 4554.3299999999999, 88198L, "Douglas - Williamson", "" },
                    { new Guid("1101c5f4-a724-ea39-bab6-cc9733fbd8e5"), new DateTime(2027, 3, 10, 9, 13, 6, 614, DateTimeKind.Utc).AddTicks(9329), 6688.0500000000002, 36272L, "Champlin - Murray", "" },
                    { new Guid("11115780-1f8e-a92c-cce4-61c0c8c198d4"), new DateTime(2027, 3, 20, 17, 44, 29, 705, DateTimeKind.Utc).AddTicks(6532), 825.41999999999996, 92525L, "Leffler LLC", "₡" },
                    { new Guid("11284ab8-052f-8592-8bec-19bb4d15acb9"), new DateTime(2027, 3, 16, 16, 15, 1, 253, DateTimeKind.Utc).AddTicks(2048), 9520.9400000000005, 81869L, "Durgan, Flatley and Larson", "" },
                    { new Guid("1141948a-5315-8d1a-fc0b-4666dbbd8e94"), new DateTime(2027, 7, 10, 1, 25, 3, 757, DateTimeKind.Utc).AddTicks(309), 5114.8400000000001, 53654L, "Ebert - Funk", "" },
                    { new Guid("115795bb-8e43-9905-bed3-7f23c53d4f9c"), new DateTime(2027, 3, 15, 5, 52, 4, 162, DateTimeKind.Utc).AddTicks(2172), 6704.96, 32342L, "Howell, Kshlerin and Schaden", "﷼" },
                    { new Guid("118d63ea-636b-47ce-aecf-b3bef89e8f4f"), new DateTime(2027, 7, 15, 0, 57, 21, 992, DateTimeKind.Utc).AddTicks(9870), 4390.0600000000004, 69241L, "Bauch LLC", "£" },
                    { new Guid("11d95557-0dd3-eb83-f1d7-37d2b0da5007"), new DateTime(2027, 8, 1, 7, 24, 26, 624, DateTimeKind.Utc).AddTicks(2370), 9186.0200000000004, 90490L, "Toy, Gulgowski and Koelpin", "" },
                    { new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"), new DateTime(2027, 3, 15, 6, 54, 12, 881, DateTimeKind.Utc).AddTicks(7798), 3828.98, 32949L, "Morar, Becker and Kulas", "₱" },
                    { new Guid("1216ee5a-4f64-aadb-d5b9-9cfe69251ed5"), new DateTime(2027, 1, 9, 14, 30, 31, 621, DateTimeKind.Utc).AddTicks(6863), 6751.3800000000001, 40895L, "Schimmel, Ebert and Champlin", "" },
                    { new Guid("1237f4be-cd74-6dd2-7ca2-2e6daac34152"), new DateTime(2026, 11, 13, 8, 37, 37, 297, DateTimeKind.Utc).AddTicks(2378), 2460.4099999999999, 69079L, "Yundt - Gaylord", "" },
                    { new Guid("126a230b-44b5-32e7-23db-8e6059f21f8c"), new DateTime(2026, 10, 25, 20, 49, 49, 742, DateTimeKind.Utc).AddTicks(3516), 4225.9200000000001, 83461L, "Kerluke Inc", "₹" },
                    { new Guid("13412e73-f410-df4f-f886-2f887e361070"), new DateTime(2027, 1, 6, 4, 35, 10, 634, DateTimeKind.Utc).AddTicks(6593), 38.560000000000002, 19963L, "O'Reilly, Durgan and Blick", "" },
                    { new Guid("13a15f40-7b5a-bb16-f515-1b5051bb3c22"), new DateTime(2027, 6, 18, 23, 44, 27, 896, DateTimeKind.Utc).AddTicks(6160), 4486.3800000000001, 56646L, "Smith - Metz", "Rp" },
                    { new Guid("13b21b6f-872e-e65a-af0f-82e46b34a44c"), new DateTime(2026, 11, 7, 18, 47, 4, 255, DateTimeKind.Utc).AddTicks(7966), 5978.2700000000004, 66461L, "Torp LLC", "kr" },
                    { new Guid("13ce50a9-2c4f-59af-21d4-12608eee1845"), new DateTime(2027, 5, 18, 22, 41, 40, 614, DateTimeKind.Utc).AddTicks(8208), 6958.1899999999996, 54911L, "Bahringer, Toy and Rowe", "" },
                    { new Guid("13dab998-2c53-3c6b-47cd-164ebf45dcf5"), new DateTime(2026, 8, 10, 13, 23, 47, 874, DateTimeKind.Utc).AddTicks(4620), 1846.4100000000001, 48623L, "Rohan - Stark", "" },
                    { new Guid("13f36d03-6ac8-5a30-9c1c-bd63900594ba"), new DateTime(2027, 2, 15, 21, 43, 4, 818, DateTimeKind.Utc).AddTicks(345), 1274.9400000000001, 72251L, "Maggio, Homenick and Schoen", "" },
                    { new Guid("14425992-c857-e39e-c155-96bfc2dd0161"), new DateTime(2027, 7, 1, 3, 54, 20, 222, DateTimeKind.Utc).AddTicks(6821), 984.35000000000002, 63475L, "VonRueden and Sons", "" },
                    { new Guid("14562bd5-90f8-9064-6bbc-bed9f68e89c6"), new DateTime(2026, 12, 23, 12, 32, 22, 700, DateTimeKind.Utc).AddTicks(2480), 4425.4700000000003, 44367L, "Hyatt - Blick", "" },
                    { new Guid("14582bbf-8109-1cb2-4d90-ee1b7e732450"), new DateTime(2026, 11, 13, 14, 38, 57, 887, DateTimeKind.Utc).AddTicks(9285), 7856.04, 40L, "Schultz - Baumbach", "₩" },
                    { new Guid("148573a1-266d-eabc-e6d1-4ee2184ea439"), new DateTime(2027, 2, 28, 16, 4, 54, 721, DateTimeKind.Utc).AddTicks(6149), 3099.0700000000002, 48206L, "Hintz - Kunde", "₩" },
                    { new Guid("148833ad-f8d5-914f-fa4c-0fe845c0385d"), new DateTime(2026, 9, 24, 19, 22, 47, 924, DateTimeKind.Utc).AddTicks(2179), 211.47, 63677L, "Abshire - Goyette", "$" },
                    { new Guid("1489e9ea-4b93-14e1-37c4-a7d24a402885"), new DateTime(2026, 10, 6, 22, 40, 18, 489, DateTimeKind.Utc).AddTicks(6176), 7416.6499999999996, 82968L, "Adams Group", "kr" },
                    { new Guid("1511f43e-b2e7-0856-e957-c95d7bca54f3"), new DateTime(2027, 5, 26, 7, 1, 28, 361, DateTimeKind.Utc).AddTicks(6875), 3243.0700000000002, 22267L, "Fisher, Botsford and Terry", "" },
                    { new Guid("15b7c6f5-45c1-d3be-4da8-95ec846e31d3"), new DateTime(2026, 12, 31, 12, 48, 25, 107, DateTimeKind.Utc).AddTicks(9802), 9462.7800000000007, 5617L, "Witting - Will", "Nu" },
                    { new Guid("164d1dc3-fd02-67a9-96e9-86746e88e7cf"), new DateTime(2026, 8, 17, 9, 34, 44, 635, DateTimeKind.Utc).AddTicks(7808), 1893.0, 1300L, "Stokes - Hermann", "" },
                    { new Guid("16811694-7d17-e93a-155e-dc307fb3fe82"), new DateTime(2027, 6, 27, 6, 30, 36, 556, DateTimeKind.Utc).AddTicks(9020), 2718.8099999999999, 94011L, "Treutel - Quitzon", "" },
                    { new Guid("16ab8c5d-80e1-d350-389b-ed2052b9bd4b"), new DateTime(2027, 5, 22, 2, 40, 55, 453, DateTimeKind.Utc).AddTicks(8229), 6008.3599999999997, 8978L, "Kreiger and Sons", "Lek" },
                    { new Guid("17476a1b-91d8-904f-fb8e-b4b0c857f077"), new DateTime(2027, 8, 2, 14, 6, 41, 889, DateTimeKind.Utc).AddTicks(6528), 1734.23, 48494L, "Block LLC", "лв" },
                    { new Guid("174af80b-fd3e-841d-62c0-09ca91815435"), new DateTime(2027, 6, 4, 11, 41, 19, 140, DateTimeKind.Utc).AddTicks(8354), 421.80000000000001, 905L, "Hane Group", "Bs" },
                    { new Guid("17591031-9ed3-e5c7-1975-550d97abe757"), new DateTime(2026, 12, 15, 12, 25, 35, 832, DateTimeKind.Utc).AddTicks(8399), 256.81, 73131L, "Bednar Group", "" },
                    { new Guid("17e99a11-dfff-5612-6eb0-a669756cf566"), new DateTime(2027, 5, 8, 14, 8, 45, 820, DateTimeKind.Utc).AddTicks(2933), 2263.1799999999998, 66000L, "Barrows LLC", "MT" },
                    { new Guid("185a0589-a29f-16d5-bd50-7a08cfa28551"), new DateTime(2027, 5, 13, 0, 24, 41, 694, DateTimeKind.Utc).AddTicks(4319), 7745.3199999999997, 70464L, "Schamberger, Bergnaum and Zemlak", "TT$" },
                    { new Guid("190110a3-5331-b961-a532-d071d91fe6e9"), new DateTime(2026, 9, 16, 5, 15, 12, 489, DateTimeKind.Utc).AddTicks(2219), 4430.8199999999997, 17891L, "Terry and Sons", "" },
                    { new Guid("1901167e-6596-cc6f-3db6-b95c0431451d"), new DateTime(2027, 5, 30, 11, 27, 16, 338, DateTimeKind.Utc).AddTicks(8046), 1520.4200000000001, 76814L, "Lueilwitz - Little", "¥" },
                    { new Guid("191d9535-41f8-a7e5-5e47-dffa50b1307c"), new DateTime(2026, 12, 29, 11, 42, 41, 99, DateTimeKind.Utc).AddTicks(2369), 7797.3900000000003, 84787L, "Mertz, Kshlerin and Wolff", "" },
                    { new Guid("198a485a-5c30-0e3e-c62d-281b63125090"), new DateTime(2027, 3, 21, 4, 46, 5, 156, DateTimeKind.Utc).AddTicks(8346), 8008.7700000000004, 36675L, "Murphy - Kiehn", "₡" },
                    { new Guid("19ddf8d2-94e8-5214-6a74-fccf260329c6"), new DateTime(2027, 4, 22, 15, 41, 37, 934, DateTimeKind.Utc).AddTicks(4934), 2700.8400000000001, 70164L, "Tromp - Haag", "" },
                    { new Guid("1a438df7-304d-239c-d30c-9d3e2eecc81f"), new DateTime(2027, 8, 3, 6, 14, 9, 539, DateTimeKind.Utc).AddTicks(2489), 1236.95, 29690L, "Stroman, Blick and Casper", "" },
                    { new Guid("1a5b35bf-f287-8b10-385d-cad3e712aeb6"), new DateTime(2027, 4, 3, 18, 9, 38, 774, DateTimeKind.Utc).AddTicks(4326), 4692.8500000000004, 21532L, "Botsford - Strosin", "$" },
                    { new Guid("1b1c691f-6a2c-8fff-e7fe-e085856de3c5"), new DateTime(2026, 12, 29, 0, 57, 14, 376, DateTimeKind.Utc).AddTicks(4434), 6388.25, 62569L, "Witting, Lesch and Mohr", "" },
                    { new Guid("1b31b2eb-5b32-619b-b344-92baf5d2a3c1"), new DateTime(2027, 6, 10, 2, 24, 55, 104, DateTimeKind.Utc).AddTicks(4764), 4692.9799999999996, 76626L, "Mraz, Anderson and Douglas", "NT$" },
                    { new Guid("1b42904a-f20c-bb4f-2c0b-637ff68ccc9d"), new DateTime(2026, 11, 22, 2, 41, 55, 424, DateTimeKind.Utc).AddTicks(5000), 3841.3699999999999, 2956L, "Haag - Rogahn", "$" },
                    { new Guid("1b484a2b-e9ff-571e-410d-2ff4a0a29704"), new DateTime(2027, 3, 6, 1, 30, 1, 839, DateTimeKind.Utc).AddTicks(3385), 3539.9299999999998, 76457L, "Schuppe, Morar and Torp", "" },
                    { new Guid("1b51bad3-86b4-1335-d89b-02a8a7f078eb"), new DateTime(2027, 1, 5, 1, 38, 51, 502, DateTimeKind.Utc).AddTicks(4762), 3817.02, 69800L, "Walsh LLC", "$" },
                    { new Guid("1b78fb46-19b6-6846-5a76-55c8087ac590"), new DateTime(2027, 1, 28, 0, 35, 2, 758, DateTimeKind.Utc).AddTicks(1663), 9408.4500000000007, 44419L, "Davis, Kessler and Hudson", "$" },
                    { new Guid("1b959cbd-2b6f-1397-0c53-d77f212db57d"), new DateTime(2027, 7, 6, 16, 8, 38, 719, DateTimeKind.Utc).AddTicks(9022), 7984.3699999999999, 38554L, "Cronin - Anderson", "£" },
                    { new Guid("1bd262c7-42c3-3466-5e63-76f8653fd88b"), new DateTime(2026, 8, 17, 12, 32, 23, 197, DateTimeKind.Utc).AddTicks(7379), 9001.4699999999993, 6796L, "Homenick - Gerlach", "лв" },
                    { new Guid("1c107289-bccd-fea9-37ef-1efec18fe13b"), new DateTime(2027, 1, 25, 11, 28, 47, 89, DateTimeKind.Utc).AddTicks(6739), 3529.8499999999999, 39779L, "Ward Group", "﷼" },
                    { new Guid("1c4aefcf-3f50-1dbe-bc37-dc2c83eba16a"), new DateTime(2027, 3, 18, 17, 51, 32, 851, DateTimeKind.Utc).AddTicks(4980), 9561.2700000000004, 38711L, "Wehner LLC", "Q" },
                    { new Guid("1c582406-f88d-fcf9-66cf-7645d14c44f8"), new DateTime(2027, 2, 22, 12, 1, 16, 221, DateTimeKind.Utc).AddTicks(6765), 5111.8699999999999, 71273L, "Prohaska, Sipes and Kulas", "₩" },
                    { new Guid("1d026139-d5a5-f43d-fdb1-69142f5c2053"), new DateTime(2026, 8, 23, 5, 26, 15, 301, DateTimeKind.Utc).AddTicks(7526), 1726.72, 12390L, "Daniel and Sons", "﷼" },
                    { new Guid("1d0557d0-384a-00e1-8f49-74c8e0efba78"), new DateTime(2026, 9, 16, 14, 48, 30, 17, DateTimeKind.Utc).AddTicks(3923), 351.00999999999999, 20932L, "Walsh, Gutkowski and Murphy", "฿" },
                    { new Guid("1d0bcb70-9c0b-d0f2-d489-000376a4ed73"), new DateTime(2027, 6, 23, 6, 30, 35, 462, DateTimeKind.Utc).AddTicks(7624), 4519.0, 93344L, "Parker - Feest", "$" },
                    { new Guid("1d2d3ca5-00e8-6c85-fec7-a2921927dacf"), new DateTime(2027, 3, 28, 21, 19, 16, 309, DateTimeKind.Utc).AddTicks(2207), 6819.9099999999999, 66298L, "Balistreri Inc", "" },
                    { new Guid("1d59eaae-0d36-735b-7e51-076d7dca4949"), new DateTime(2026, 9, 30, 1, 9, 56, 862, DateTimeKind.Utc).AddTicks(9974), 5009.1099999999997, 99970L, "White, Treutel and Mosciski", "" },
                    { new Guid("1d5d2718-8715-4277-5ab7-5aea0e57d175"), new DateTime(2027, 5, 11, 1, 25, 39, 403, DateTimeKind.Utc).AddTicks(5851), 3535.0599999999999, 82940L, "Steuber, Berge and White", "₫" },
                    { new Guid("1da43eee-9bed-d4a2-12a2-cd8dc6d604b4"), new DateTime(2027, 8, 3, 0, 22, 52, 201, DateTimeKind.Utc).AddTicks(4223), 9960.8899999999994, 28310L, "Douglas, Orn and Runolfsdottir", "" },
                    { new Guid("1e0fb905-3153-6a0b-19a7-d0d54442f2f9"), new DateTime(2027, 7, 29, 22, 20, 34, 79, DateTimeKind.Utc).AddTicks(6798), 5629.1700000000001, 17083L, "Kshlerin - MacGyver", "₨" },
                    { new Guid("1e7c9d12-7a71-36a1-0685-0e84b8681543"), new DateTime(2027, 2, 7, 12, 4, 14, 275, DateTimeKind.Utc).AddTicks(8059), 983.16999999999996, 93296L, "Heathcote - Schinner", "" },
                    { new Guid("1f01b87a-65b7-6318-9785-0c470bacabe3"), new DateTime(2026, 12, 25, 19, 42, 22, 290, DateTimeKind.Utc).AddTicks(5493), 107.92, 87393L, "Bode and Sons", "Lt" },
                    { new Guid("1f12a5c4-175c-11af-58b8-27a41584180f"), new DateTime(2026, 10, 3, 13, 11, 52, 307, DateTimeKind.Utc).AddTicks(8598), 6840.7799999999997, 67679L, "DuBuque LLC", "CHF" },
                    { new Guid("1f65c0d1-d081-3cef-26dd-b139258afc19"), new DateTime(2026, 11, 10, 17, 11, 16, 884, DateTimeKind.Utc).AddTicks(7409), 7927.2799999999997, 57473L, "Schulist Group", "₹" },
                    { new Guid("1faac5dd-edd5-8212-8f20-fa703f965e61"), new DateTime(2027, 7, 28, 6, 58, 56, 503, DateTimeKind.Utc).AddTicks(4564), 6163.4099999999999, 45690L, "Bernier Inc", "ман" },
                    { new Guid("202c05ca-5965-3577-34e0-8bcffbd931b6"), new DateTime(2027, 1, 13, 5, 16, 32, 887, DateTimeKind.Utc).AddTicks(6606), 9621.7000000000007, 65113L, "MacGyver, Schmidt and Quigley", "₫" },
                    { new Guid("204952ca-b348-a3b3-d1ab-401d3e00b382"), new DateTime(2026, 9, 10, 16, 11, 30, 728, DateTimeKind.Utc).AddTicks(1653), 3423.3499999999999, 61915L, "Bergstrom - Hermann", "RM" },
                    { new Guid("2051282c-47f0-a66e-4896-535232181c8f"), new DateTime(2026, 8, 31, 3, 10, 5, 972, DateTimeKind.Utc).AddTicks(9595), 4716.0, 52795L, "Von - Rice", "؋" },
                    { new Guid("2051d62f-8df4-71af-2a6e-65c3d54e950c"), new DateTime(2026, 12, 1, 21, 4, 59, 245, DateTimeKind.Utc).AddTicks(2752), 4991.9700000000003, 99516L, "Schoen LLC", "S" },
                    { new Guid("20b5179c-c592-9bf9-4b2a-d5244f4675b5"), new DateTime(2027, 1, 15, 20, 26, 44, 625, DateTimeKind.Utc).AddTicks(989), 2273.4400000000001, 96912L, "Bechtelar - Boehm", "﷼" },
                    { new Guid("20d09489-497d-d5e9-1df2-af7bc47c80cc"), new DateTime(2027, 7, 23, 15, 29, 26, 955, DateTimeKind.Utc).AddTicks(3558), 4408.75, 23380L, "Medhurst Inc", "₭" },
                    { new Guid("20d3a550-84e7-e58a-e96c-07b8ae7cded9"), new DateTime(2027, 6, 5, 16, 34, 24, 337, DateTimeKind.Utc).AddTicks(2704), 7174.0900000000001, 33966L, "Ledner LLC", "" },
                    { new Guid("216491db-ab51-3f73-7ef4-32c02c3d85a9"), new DateTime(2027, 4, 23, 16, 5, 58, 386, DateTimeKind.Utc).AddTicks(532), 8870.1100000000006, 86452L, "Gottlieb - Padberg", "Rp" },
                    { new Guid("21986ee1-9a47-6d79-f759-e811c375c184"), new DateTime(2027, 6, 22, 10, 17, 52, 978, DateTimeKind.Utc).AddTicks(8724), 7575.21, 35577L, "Cartwright - Koelpin", "B/." },
                    { new Guid("21bc803a-4b02-2330-66b1-d820f6f57229"), new DateTime(2026, 9, 14, 9, 27, 40, 156, DateTimeKind.Utc).AddTicks(6785), 5533.5900000000001, 30758L, "Trantow, Yundt and Kovacek", "B/." },
                    { new Guid("21f16ae9-ac4a-1979-19b4-a74df625b7cf"), new DateTime(2027, 2, 5, 21, 58, 21, 468, DateTimeKind.Utc).AddTicks(9557), 8641.9500000000007, 2029L, "Heller, Weimann and Jacobson", "฿" },
                    { new Guid("222abfcb-f185-be6c-f1c2-3f1be3ff196b"), new DateTime(2027, 2, 5, 0, 21, 30, 602, DateTimeKind.Utc).AddTicks(8527), 5171.1800000000003, 72071L, "Volkman - Nitzsche", "Lt" },
                    { new Guid("226c8338-fc98-30ae-b59f-8367dc63d399"), new DateTime(2027, 1, 23, 10, 10, 18, 914, DateTimeKind.Utc).AddTicks(2518), 6070.2700000000004, 26664L, "Gutmann Group", "" },
                    { new Guid("22befc39-34d2-8518-20e2-5cfa9bc1f9f6"), new DateTime(2027, 4, 6, 0, 59, 4, 152, DateTimeKind.Utc).AddTicks(7701), 5006.4300000000003, 16366L, "Turner, Terry and Nicolas", "$" },
                    { new Guid("22c11349-110f-8781-9639-cc9cfc3885fd"), new DateTime(2026, 11, 16, 2, 27, 37, 949, DateTimeKind.Utc).AddTicks(3058), 5768.9099999999999, 18142L, "Davis LLC", "lei" },
                    { new Guid("22cd7a79-26aa-c7f8-67a7-886c5828665f"), new DateTime(2026, 12, 19, 12, 11, 28, 996, DateTimeKind.Utc).AddTicks(252), 3249.2199999999998, 13129L, "Langworth - McCullough", "" },
                    { new Guid("238da285-0159-0f2d-6bc7-dc494865e472"), new DateTime(2027, 7, 24, 13, 25, 42, 130, DateTimeKind.Utc).AddTicks(724), 8376.4300000000003, 23601L, "Fritsch - Feest", "" },
                    { new Guid("23f85c1f-c19f-80db-5ce8-e311f21b204b"), new DateTime(2026, 12, 26, 16, 11, 18, 175, DateTimeKind.Utc).AddTicks(318), 593.80999999999995, 49829L, "Fritsch and Sons", "Ft" },
                    { new Guid("2410f4f1-3592-74b9-d3af-4a848bea4913"), new DateTime(2027, 1, 10, 8, 13, 35, 312, DateTimeKind.Utc).AddTicks(6393), 1369.3800000000001, 23181L, "Romaguera and Sons", "" },
                    { new Guid("243a7bd5-42ec-da71-f6dc-4209689087b2"), new DateTime(2027, 4, 22, 6, 15, 9, 7, DateTimeKind.Utc).AddTicks(7226), 5464.54, 98567L, "DuBuque Group", "kn" },
                    { new Guid("2460d26f-e18c-fd22-972f-42fd65e71a23"), new DateTime(2027, 2, 28, 14, 35, 43, 234, DateTimeKind.Utc).AddTicks(4360), 4015.6199999999999, 93318L, "Bauch Group", "" },
                    { new Guid("247605d9-1ed8-ce9c-9d01-d341eb459663"), new DateTime(2027, 3, 27, 11, 0, 18, 171, DateTimeKind.Utc).AddTicks(4799), 5640.3900000000003, 57392L, "Spencer - Mueller", "₨" },
                    { new Guid("24761e0e-d3a5-bffa-80e5-8645cb1d5705"), new DateTime(2027, 4, 5, 4, 6, 28, 870, DateTimeKind.Utc).AddTicks(8379), 4497.3900000000003, 34494L, "Jakubowski - Quigley", "₭" },
                    { new Guid("24ac461b-9523-b58d-7aa2-b92baede2b3b"), new DateTime(2027, 1, 16, 10, 19, 7, 827, DateTimeKind.Utc).AddTicks(9684), 7686.7600000000002, 93335L, "Kuhic, Fay and Ebert", "₱" },
                    { new Guid("252b0343-7453-69e1-f933-1e4ac24f2119"), new DateTime(2026, 8, 29, 11, 43, 31, 673, DateTimeKind.Utc).AddTicks(2399), 6229.5799999999999, 403L, "Gaylord - Kovacek", "$" },
                    { new Guid("2539dda9-256b-e837-751a-0352c268cda9"), new DateTime(2027, 1, 8, 0, 25, 12, 619, DateTimeKind.Utc).AddTicks(4806), 5746.4399999999996, 58625L, "Kovacek Group", "RD$" },
                    { new Guid("25443e8c-8a6e-72b7-b5e7-c8d7120bc6ab"), new DateTime(2027, 5, 30, 14, 34, 6, 895, DateTimeKind.Utc).AddTicks(8699), 9732.5799999999999, 21221L, "Bartoletti, Mohr and Senger", "₨" },
                    { new Guid("25a8e077-e859-4f99-da18-8a1a1964f36e"), new DateTime(2027, 2, 6, 17, 43, 11, 969, DateTimeKind.Utc).AddTicks(9015), 5152.79, 9207L, "Toy - Orn", "C$" },
                    { new Guid("265da8c8-26ce-e3c3-bbe9-638dcff1ef05"), new DateTime(2026, 11, 17, 10, 52, 2, 171, DateTimeKind.Utc).AddTicks(1969), 6949.5500000000002, 82655L, "Emard and Sons", "zł" },
                    { new Guid("266d130b-a476-8eac-11c9-0dc3d64d2df0"), new DateTime(2026, 11, 23, 9, 4, 8, 380, DateTimeKind.Utc).AddTicks(9031), 4013.9899999999998, 2019L, "Roberts - Kirlin", "ман" },
                    { new Guid("26f29e11-53cd-2328-0045-a6bcc69b2e97"), new DateTime(2026, 8, 19, 18, 38, 31, 562, DateTimeKind.Utc).AddTicks(4488), 3130.3899999999999, 93515L, "Schumm, Luettgen and Simonis", "$" },
                    { new Guid("27065d98-402e-a894-514e-d8cab43d1e2b"), new DateTime(2027, 3, 23, 4, 54, 37, 193, DateTimeKind.Utc).AddTicks(1526), 7764.8599999999997, 36329L, "Osinski and Sons", "S/." },
                    { new Guid("27df1ccd-8f3d-32c7-5390-06ae7aae4757"), new DateTime(2027, 3, 9, 13, 15, 8, 58, DateTimeKind.Utc).AddTicks(3093), 800.85000000000002, 35729L, "Maggio, Kerluke and Hills", "Дин." },
                    { new Guid("27e2e12d-038b-e1e7-2d47-fc1d083298af"), new DateTime(2027, 4, 6, 6, 35, 13, 165, DateTimeKind.Utc).AddTicks(9735), 4968.7299999999996, 89159L, "Olson LLC", "" },
                    { new Guid("27f41c13-5c3f-c8a2-71ed-24025f1e70c7"), new DateTime(2026, 10, 15, 23, 8, 25, 783, DateTimeKind.Utc).AddTicks(6426), 424.49000000000001, 69727L, "Bogan, Mayer and Kulas", "лв" },
                    { new Guid("287445ad-b108-5548-6b38-dba611251863"), new DateTime(2027, 4, 19, 22, 28, 52, 417, DateTimeKind.Utc).AddTicks(9837), 5920.9700000000003, 26087L, "Macejkovic LLC", "" },
                    { new Guid("28945082-0e0a-82d9-8606-4c84b517bf8d"), new DateTime(2027, 7, 17, 21, 51, 20, 387, DateTimeKind.Utc).AddTicks(2643), 5965.7700000000004, 9299L, "Kuvalis - Franecki", "₫" },
                    { new Guid("28da1074-0f1a-d79f-fdbe-03bb910a84fa"), new DateTime(2027, 2, 13, 13, 58, 36, 881, DateTimeKind.Utc).AddTicks(1546), 2296.48, 61065L, "Bernier LLC", "" },
                    { new Guid("29796f3b-b3af-8559-d97a-b83246c0a9ef"), new DateTime(2027, 7, 20, 1, 34, 54, 976, DateTimeKind.Utc).AddTicks(1281), 4306.0100000000002, 82717L, "McClure, Abernathy and Heathcote", "Rp" },
                    { new Guid("29a1429b-5bc5-92af-b3b4-f20247e1d480"), new DateTime(2027, 3, 2, 0, 7, 58, 692, DateTimeKind.Utc).AddTicks(9771), 8826.1299999999992, 15449L, "Tillman, Konopelski and Hagenes", "₩" },
                    { new Guid("29cac353-5be0-6053-9880-dbfdebb5cc68"), new DateTime(2027, 1, 23, 11, 9, 25, 676, DateTimeKind.Utc).AddTicks(2210), 7935.6400000000003, 49449L, "Runolfsdottir - Bednar", "" },
                    { new Guid("2a84fe2f-8f62-902f-ebb9-9bfd27fb366b"), new DateTime(2027, 7, 22, 3, 55, 57, 173, DateTimeKind.Utc).AddTicks(7692), 4666.0799999999999, 8763L, "Beier Inc", "J$" },
                    { new Guid("2b178c4c-c4ae-3266-d7bd-56bc9abdd32d"), new DateTime(2027, 5, 5, 20, 51, 32, 57, DateTimeKind.Utc).AddTicks(7119), 5049.04, 15619L, "Conn and Sons", "лв" },
                    { new Guid("2b3d9c01-d361-053d-2fda-2a458fb1d696"), new DateTime(2027, 1, 31, 9, 22, 30, 289, DateTimeKind.Utc).AddTicks(9212), 5396.8999999999996, 80918L, "Roberts Inc", "£" },
                    { new Guid("2b454b75-2ce7-05f8-c4ef-19204e95c74a"), new DateTime(2027, 4, 10, 4, 6, 47, 839, DateTimeKind.Utc).AddTicks(5632), 2600.4200000000001, 31890L, "Hansen - VonRueden", "$" },
                    { new Guid("2b9f7a2f-cfc5-3e1a-5ae3-f0e1d7afacba"), new DateTime(2027, 1, 27, 13, 36, 1, 381, DateTimeKind.Utc).AddTicks(9390), 424.22000000000003, 19069L, "Volkman - Leuschke", "$" },
                    { new Guid("2ba5ce3e-108d-74a0-d1b5-ddfb16482c7e"), new DateTime(2027, 6, 23, 12, 0, 3, 548, DateTimeKind.Utc).AddTicks(556), 3946.6100000000001, 92687L, "Walker, Rutherford and Raynor", "$" },
                    { new Guid("2c475fd8-c993-7e08-cc48-9824a8c159e2"), new DateTime(2026, 10, 15, 9, 32, 34, 47, DateTimeKind.Utc).AddTicks(8299), 2295.7600000000002, 72435L, "Okuneva, Muller and Morar", "$" },
                    { new Guid("2ca5cc38-ca7d-c4bb-c80e-5b83be5b41c2"), new DateTime(2026, 9, 27, 16, 8, 48, 176, DateTimeKind.Utc).AddTicks(9707), 2590.8699999999999, 72162L, "Gislason Inc", "p." },
                    { new Guid("2e19cd36-5081-e812-37e7-3d63953d25e5"), new DateTime(2026, 8, 30, 0, 29, 36, 46, DateTimeKind.Utc).AddTicks(3072), 8443.4799999999996, 90028L, "Torp - Kihn", "Php" },
                    { new Guid("2e7b5d70-2ab0-664b-1859-4031cc96a5a6"), new DateTime(2027, 4, 7, 3, 19, 41, 422, DateTimeKind.Utc).AddTicks(2318), 6539.1899999999996, 50375L, "Schroeder, Watsica and Corwin", "₡" },
                    { new Guid("2eefbf36-3fc9-4fd4-c6a4-e8ef1bf4362c"), new DateTime(2027, 5, 3, 12, 15, 30, 633, DateTimeKind.Utc).AddTicks(4810), 5375.9200000000001, 59356L, "Jacobs - Braun", "" },
                    { new Guid("2f3b1f3b-1cf8-32a0-9903-0931a115bb25"), new DateTime(2027, 5, 15, 18, 9, 6, 71, DateTimeKind.Utc).AddTicks(6854), 9069.7800000000007, 93521L, "Hilll LLC", "zł" },
                    { new Guid("2f52b200-4a6c-744a-3276-c72041140a3d"), new DateTime(2027, 3, 29, 14, 25, 20, 378, DateTimeKind.Utc).AddTicks(1995), 6999.79, 46653L, "Buckridge LLC", "" },
                    { new Guid("2f5372f4-e48a-cd92-b5f0-358bc8ba9c55"), new DateTime(2026, 11, 5, 14, 45, 7, 24, DateTimeKind.Utc).AddTicks(7391), 8578.4899999999998, 48212L, "Glover, Purdy and Little", "Lek" },
                    { new Guid("2fad8f9d-c983-0aa5-0cce-c7bdd8e1b60c"), new DateTime(2026, 8, 25, 19, 28, 20, 339, DateTimeKind.Utc).AddTicks(1903), 3817.4899999999998, 62398L, "Flatley - Kassulke", "$" },
                    { new Guid("2faee5e5-fc3b-66f0-554d-2bdb158a6d9a"), new DateTime(2027, 7, 20, 18, 53, 47, 821, DateTimeKind.Utc).AddTicks(5314), 2818.5500000000002, 93067L, "Lowe and Sons", "" },
                    { new Guid("2fd8d15c-a1b9-93e0-532b-a674adb46a88"), new DateTime(2026, 9, 1, 16, 12, 50, 730, DateTimeKind.Utc).AddTicks(8018), 7053.8599999999997, 56150L, "Cronin Group", "ƒ" },
                    { new Guid("303e8c4c-99b7-fa77-7ffc-006170b880aa"), new DateTime(2027, 7, 31, 3, 44, 13, 750, DateTimeKind.Utc).AddTicks(5517), 6159.5500000000002, 45937L, "Luettgen LLC", "€" },
                    { new Guid("31484e42-d07a-198d-3f11-bd5fcf61a1c9"), new DateTime(2027, 3, 9, 21, 51, 52, 858, DateTimeKind.Utc).AddTicks(617), 7397.0799999999999, 6773L, "Dicki - Walsh", "Php" },
                    { new Guid("315b02c0-5003-e1df-07e9-f1f51d9e1dda"), new DateTime(2027, 1, 16, 15, 19, 54, 885, DateTimeKind.Utc).AddTicks(497), 9509.8700000000008, 52431L, "Will Inc", "" },
                    { new Guid("315f7231-5ee0-2512-58f3-60b5513839c3"), new DateTime(2027, 5, 3, 6, 2, 22, 358, DateTimeKind.Utc).AddTicks(7976), 8002.3800000000001, 24148L, "Nader Group", "Kč" },
                    { new Guid("317e0405-8f87-24bf-250e-4f6c641b8f82"), new DateTime(2026, 11, 10, 12, 52, 33, 518, DateTimeKind.Utc).AddTicks(9543), 3175.3800000000001, 97923L, "Bergnaum, Rath and Durgan", "" },
                    { new Guid("31b0333e-45c2-069e-58c2-9e8c362bd7a0"), new DateTime(2027, 5, 27, 15, 20, 38, 8, DateTimeKind.Utc).AddTicks(3668), 3777.1999999999998, 74605L, "Hermiston, Rodriguez and Johnson", "" },
                    { new Guid("31cdfd4a-02fb-e83a-8b07-a7def834acce"), new DateTime(2027, 6, 11, 21, 17, 31, 996, DateTimeKind.Utc).AddTicks(2766), 5866.5200000000004, 85256L, "Barton, Jaskolski and Bernier", "Ft" },
                    { new Guid("3217a348-823f-ac26-31a9-7dc1269f2193"), new DateTime(2027, 7, 20, 12, 46, 26, 264, DateTimeKind.Utc).AddTicks(2678), 6721.7200000000003, 8114L, "Von, Runolfsdottir and Emmerich", "$" },
                    { new Guid("32247015-31b4-c3ea-7483-075f10f8d1e7"), new DateTime(2026, 10, 19, 3, 2, 50, 323, DateTimeKind.Utc).AddTicks(2740), 2459.29, 14510L, "Schaden, O'Keefe and Abshire", "" },
                    { new Guid("324724fb-f243-33ae-34e9-0bd56d4cbb43"), new DateTime(2027, 5, 8, 4, 56, 51, 859, DateTimeKind.Utc).AddTicks(6118), 4131.9200000000001, 79926L, "Cormier - Waelchi", "" },
                    { new Guid("327411fa-91b3-babf-fc4a-01e10ff3cd75"), new DateTime(2027, 6, 5, 20, 42, 18, 95, DateTimeKind.Utc).AddTicks(734), 434.85000000000002, 73762L, "Harvey, Graham and Jakubowski", "$" },
                    { new Guid("327dc006-03e4-5edb-3256-71f1aaadb19a"), new DateTime(2026, 8, 14, 5, 4, 54, 685, DateTimeKind.Utc).AddTicks(1699), 4730.3500000000004, 46977L, "Aufderhar - Waelchi", "TT$" },
                    { new Guid("32b6f203-92df-8d7e-abc3-618706bcc87b"), new DateTime(2027, 4, 12, 10, 2, 17, 431, DateTimeKind.Utc).AddTicks(1206), 905.79999999999995, 42846L, "Schumm Inc", "" },
                    { new Guid("330b04ac-ddc6-c439-613a-c9a4be853e45"), new DateTime(2026, 12, 25, 20, 0, 19, 923, DateTimeKind.Utc).AddTicks(282), 1465.05, 20203L, "Turner - Hoppe", "" },
                    { new Guid("332d349a-af2c-98b2-ddc4-54442e9c8f70"), new DateTime(2026, 10, 8, 14, 8, 9, 5, DateTimeKind.Utc).AddTicks(2016), 1458.5799999999999, 32337L, "Witting, Leuschke and Altenwerth", "₡" },
                    { new Guid("33a1084e-756c-bbe2-b6de-7b86dca104ae"), new DateTime(2026, 11, 6, 21, 21, 51, 432, DateTimeKind.Utc).AddTicks(6607), 2288.54, 33416L, "Okuneva, Mertz and Veum", "$" },
                    { new Guid("3403a6ca-21bc-54cf-8b1f-438e4f8d0297"), new DateTime(2027, 3, 23, 17, 16, 16, 668, DateTimeKind.Utc).AddTicks(5758), 3897.98, 29827L, "Dooley LLC", "" },
                    { new Guid("34146925-c581-5ab7-b858-428e069e5888"), new DateTime(2026, 11, 26, 14, 50, 21, 360, DateTimeKind.Utc).AddTicks(9011), 5231.3299999999999, 36221L, "Hoeger LLC", "" },
                    { new Guid("3417e8dd-f5d2-7bd6-b2f3-daf5e5c754f6"), new DateTime(2026, 9, 26, 17, 49, 2, 279, DateTimeKind.Utc).AddTicks(8404), 4148.9799999999996, 12654L, "Cormier - Hoeger", "Ls" },
                    { new Guid("34794256-47a4-90af-cd34-e6f739a0277d"), new DateTime(2026, 11, 5, 19, 40, 46, 178, DateTimeKind.Utc).AddTicks(5624), 5619.6000000000004, 91011L, "Walter, Feeney and Labadie", "kn" },
                    { new Guid("34cdff5d-5024-c1fa-6b5e-0f3ad4ad1f81"), new DateTime(2026, 10, 4, 5, 49, 53, 454, DateTimeKind.Utc).AddTicks(3985), 396.38999999999999, 25936L, "Fadel LLC", "" },
                    { new Guid("356ad7b0-1494-e140-2507-b1e7f4e0ebd4"), new DateTime(2027, 2, 16, 20, 59, 40, 495, DateTimeKind.Utc).AddTicks(8157), 7873.9899999999998, 93889L, "Johns - Wolff", "£" },
                    { new Guid("356f7a1b-7841-9f8e-5f22-461c9013967f"), new DateTime(2026, 8, 13, 22, 49, 50, 742, DateTimeKind.Utc).AddTicks(1859), 3607.27, 48188L, "Swaniawski - Wolff", "$" },
                    { new Guid("35ce262e-fa17-78c2-1d9e-f243b13eed46"), new DateTime(2026, 12, 16, 11, 58, 12, 354, DateTimeKind.Utc).AddTicks(8770), 8193.1000000000004, 63537L, "Stoltenberg LLC", "Gs" },
                    { new Guid("364ee84a-b945-da34-01d3-f8390386619e"), new DateTime(2027, 2, 27, 18, 24, 53, 462, DateTimeKind.Utc).AddTicks(7883), 3827.0799999999999, 90845L, "Jast Group", "" },
                    { new Guid("374a9343-84e7-175d-a75f-f74666af864b"), new DateTime(2026, 8, 23, 14, 46, 9, 934, DateTimeKind.Utc).AddTicks(381), 9841.6100000000006, 23509L, "Spencer, Kutch and McCullough", "$" },
                    { new Guid("37ba370e-f3df-f23d-181b-cc13af0c3358"), new DateTime(2026, 12, 17, 16, 54, 16, 3, DateTimeKind.Utc).AddTicks(8206), 7708.2299999999996, 74577L, "Schaefer Inc", "kr" },
                    { new Guid("37fd754c-bbec-ebd2-d206-a187c26c05f6"), new DateTime(2027, 3, 21, 11, 29, 50, 202, DateTimeKind.Utc).AddTicks(5204), 159.41999999999999, 25030L, "Hackett, Labadie and Robel", "" },
                    { new Guid("380c6c06-ec41-ca7e-5fde-284a205f9a47"), new DateTime(2027, 2, 1, 4, 55, 9, 598, DateTimeKind.Utc).AddTicks(8918), 8094.9200000000001, 84784L, "Nienow, Grady and Breitenberg", "$" },
                    { new Guid("387429e5-cb71-ddee-c5e5-ae412ef0406b"), new DateTime(2027, 3, 8, 13, 25, 46, 416, DateTimeKind.Utc).AddTicks(1453), 7764.25, 7885L, "Mitchell, Crona and Osinski", "kr" },
                    { new Guid("38cf2138-d5fc-d753-7c8e-650472e70335"), new DateTime(2027, 3, 28, 7, 1, 10, 426, DateTimeKind.Utc).AddTicks(5337), 5083.4700000000003, 73836L, "Runolfsson, Rau and Quigley", "Lek" },
                    { new Guid("38dfac58-b0d4-9543-c41b-bbbec22fd667"), new DateTime(2026, 12, 13, 9, 4, 50, 189, DateTimeKind.Utc).AddTicks(3957), 6850.3599999999997, 46850L, "Kunde LLC", "R$" },
                    { new Guid("3939572a-ec43-3666-8224-4acd101ecdc5"), new DateTime(2027, 7, 5, 11, 51, 45, 793, DateTimeKind.Utc).AddTicks(9586), 2551.4400000000001, 1708L, "Heller and Sons", "ден" },
                    { new Guid("393e018b-bf54-367f-4343-7fa068f5ba70"), new DateTime(2027, 1, 14, 21, 36, 38, 133, DateTimeKind.Utc).AddTicks(143), 5786.0500000000002, 8049L, "Christiansen LLC", "﷼" },
                    { new Guid("399fae4c-1009-00d3-a521-bb7c04124161"), new DateTime(2027, 3, 16, 8, 25, 50, 513, DateTimeKind.Utc).AddTicks(2255), 3087.4000000000001, 10820L, "Ebert, Stoltenberg and Ortiz", "лв" },
                    { new Guid("3ac6a3b7-7cc9-320c-66ae-5a55bed3220d"), new DateTime(2027, 3, 30, 17, 54, 18, 909, DateTimeKind.Utc).AddTicks(4319), 1941.7, 34826L, "Fadel Group", "CHF" },
                    { new Guid("3b085a98-b13c-3f7a-2705-3ff6ed2f4e54"), new DateTime(2026, 10, 4, 15, 54, 50, 596, DateTimeKind.Utc).AddTicks(5611), 8265.0, 86310L, "McGlynn - Roob", "﷼" },
                    { new Guid("3bd975a0-9a03-1f6c-a694-cf917bc10fed"), new DateTime(2027, 1, 19, 20, 32, 48, 756, DateTimeKind.Utc).AddTicks(4580), 8247.3199999999997, 39569L, "Wiegand - Kulas", "MT" },
                    { new Guid("3c70e5e5-bd2c-29b0-7445-1f8b03735d3e"), new DateTime(2027, 6, 24, 7, 33, 27, 214, DateTimeKind.Utc).AddTicks(7250), 9071.8999999999996, 65704L, "Heller, Wolf and Lang", "₩" },
                    { new Guid("3c7569ae-60e5-d031-18a1-c399d79fd4fb"), new DateTime(2027, 6, 16, 2, 28, 39, 959, DateTimeKind.Utc).AddTicks(9647), 2795.46, 99092L, "Schmeler, Kertzmann and Welch", "" },
                    { new Guid("3cbb5025-8967-901b-4f04-7542e33cf452"), new DateTime(2026, 11, 4, 17, 30, 25, 686, DateTimeKind.Utc).AddTicks(1941), 6512.4200000000001, 87859L, "DuBuque, Dare and Reynolds", "" },
                    { new Guid("3cef2c1d-f613-ef05-ecae-d32c4853b8c3"), new DateTime(2026, 11, 30, 23, 22, 15, 673, DateTimeKind.Utc).AddTicks(593), 5151.5, 19466L, "Beer and Sons", "BZ$" },
                    { new Guid("3d2187cb-a0ae-a8c7-2862-b7b4b57c3eff"), new DateTime(2027, 1, 12, 5, 26, 41, 642, DateTimeKind.Utc).AddTicks(8187), 4240.8800000000001, 14372L, "Kuphal - Kautzer", "€" },
                    { new Guid("3e203f0d-f8dc-4163-af91-150720531207"), new DateTime(2026, 8, 22, 5, 26, 0, 568, DateTimeKind.Utc).AddTicks(9179), 9113.3099999999995, 31409L, "Welch, Barrows and Hansen", "" },
                    { new Guid("3e4dae95-3309-2363-0759-8a5a9e73471e"), new DateTime(2027, 2, 2, 10, 54, 39, 218, DateTimeKind.Utc).AddTicks(414), 1511.8, 69787L, "Pfeffer - Aufderhar", "" },
                    { new Guid("3e58af11-c272-4984-71a4-b1e03540f9cc"), new DateTime(2027, 6, 17, 17, 20, 43, 949, DateTimeKind.Utc).AddTicks(1439), 1530.47, 95263L, "Koepp, Reichel and Botsford", "﷼" },
                    { new Guid("3e6bba0b-c749-d3c3-2005-11016f22a2c9"), new DateTime(2026, 11, 8, 17, 43, 10, 70, DateTimeKind.Utc).AddTicks(4655), 383.13, 38703L, "Metz, Swift and Kilback", "" },
                    { new Guid("3ee2dbaa-985a-20f0-7590-9b6d13603175"), new DateTime(2026, 12, 7, 5, 56, 5, 661, DateTimeKind.Utc).AddTicks(4030), 1025.8800000000001, 25015L, "Morar - Nader", "kr" },
                    { new Guid("3eedc00e-ecb1-65d6-10cf-f37596107fbc"), new DateTime(2027, 7, 10, 12, 7, 51, 166, DateTimeKind.Utc).AddTicks(1397), 8584.0200000000004, 95942L, "Strosin - Breitenberg", "kr" },
                    { new Guid("3f26674e-78d3-7674-3877-02e78ffeea9c"), new DateTime(2026, 11, 9, 22, 32, 11, 330, DateTimeKind.Utc).AddTicks(859), 819.95000000000005, 5834L, "Fritsch - Dickens", "$" },
                    { new Guid("3f9f41e9-2c4c-e653-cfe5-8484d4a0b4cd"), new DateTime(2027, 1, 7, 7, 34, 40, 127, DateTimeKind.Utc).AddTicks(108), 8922.2700000000004, 62219L, "Volkman, Veum and Jaskolski", "zł" },
                    { new Guid("3fb3dfb6-5684-1e6d-4120-909680fde230"), new DateTime(2026, 9, 16, 2, 9, 8, 906, DateTimeKind.Utc).AddTicks(8250), 3554.1599999999999, 97857L, "Ruecker - Homenick", "៛" },
                    { new Guid("3fdf17a1-367a-3cad-eb35-082a0700410c"), new DateTime(2027, 2, 1, 8, 53, 4, 815, DateTimeKind.Utc).AddTicks(8684), 5139.3400000000001, 10650L, "Casper - Cartwright", "₨" },
                    { new Guid("402b8d6e-d999-349a-4b41-5c26697d46ae"), new DateTime(2026, 9, 8, 8, 21, 3, 578, DateTimeKind.Utc).AddTicks(9460), 5687.9399999999996, 32156L, "Yundt Inc", "" },
                    { new Guid("40707ef2-39cc-40b1-ae97-c7ef78d15c01"), new DateTime(2027, 7, 25, 11, 12, 34, 538, DateTimeKind.Utc).AddTicks(4105), 4191.3500000000004, 22699L, "Stokes Inc", "£" },
                    { new Guid("40753f06-e224-cb2d-c6de-5c1364b5ba8c"), new DateTime(2027, 2, 11, 3, 3, 15, 933, DateTimeKind.Utc).AddTicks(1632), 7912.5900000000001, 52858L, "Powlowski - Dickens", "$" },
                    { new Guid("40b4241d-a7d7-c6b6-5e30-bd7c13f14e68"), new DateTime(2027, 1, 28, 4, 28, 47, 770, DateTimeKind.Utc).AddTicks(2650), 3692.29, 60901L, "Herzog - Quigley", "₭" },
                    { new Guid("40b63821-1a95-14d5-e4d8-e364931a09b9"), new DateTime(2026, 9, 27, 8, 33, 7, 941, DateTimeKind.Utc).AddTicks(3902), 8757.6700000000001, 58695L, "D'Amore, Lynch and Littel", "" },
                    { new Guid("412d529f-0f82-e033-e86c-59203093af1b"), new DateTime(2026, 10, 6, 23, 35, 26, 523, DateTimeKind.Utc).AddTicks(2471), 2939.29, 93881L, "Nitzsche and Sons", "Lt" },
                    { new Guid("414d4203-7244-8d2d-cdc7-7457c6984e46"), new DateTime(2026, 9, 15, 17, 57, 52, 474, DateTimeKind.Utc).AddTicks(1923), 8100.29, 2989L, "Moen, McDermott and Shields", "BZ$" },
                    { new Guid("4280e11f-668e-a858-50bd-ea058034ecd2"), new DateTime(2027, 8, 3, 6, 58, 35, 589, DateTimeKind.Utc).AddTicks(3400), 9309.9699999999993, 2620L, "Kassulke and Sons", "" },
                    { new Guid("431307b1-451d-b41f-8bda-dfa2cd312a5a"), new DateTime(2026, 8, 14, 5, 48, 43, 474, DateTimeKind.Utc).AddTicks(3415), 1427.25, 53552L, "Skiles - Langosh", "$" },
                    { new Guid("43579918-0503-dc20-25c9-91d889b8d55c"), new DateTime(2027, 3, 22, 8, 8, 44, 740, DateTimeKind.Utc).AddTicks(4780), 5343.9799999999996, 28568L, "Schultz Group", "kr" },
                    { new Guid("43ad92fa-b47b-2927-bdcd-235fe95ec372"), new DateTime(2027, 3, 23, 13, 4, 55, 836, DateTimeKind.Utc).AddTicks(5342), 9378.9799999999996, 80232L, "Greenfelder - Hoeger", "$" },
                    { new Guid("43c408c7-69bc-1087-1214-44607a299e82"), new DateTime(2027, 6, 13, 13, 51, 28, 958, DateTimeKind.Utc).AddTicks(9672), 727.0, 7376L, "Pagac and Sons", "$" },
                    { new Guid("43df9b23-49c0-612c-a6ef-32d735c6f1df"), new DateTime(2026, 10, 4, 6, 48, 38, 593, DateTimeKind.Utc).AddTicks(5957), 9694.4699999999993, 18487L, "Borer - Simonis", "C$" },
                    { new Guid("43e0aec8-fa5b-1234-dc1d-87c9b07a4141"), new DateTime(2026, 9, 1, 20, 14, 5, 929, DateTimeKind.Utc).AddTicks(4861), 7730.8699999999999, 16676L, "Fahey, Schiller and Toy", "" },
                    { new Guid("43f5bab5-d2bc-0f4d-dda1-a6f333894ff7"), new DateTime(2026, 9, 8, 4, 33, 58, 43, DateTimeKind.Utc).AddTicks(6302), 7188.5500000000002, 87892L, "Ernser - Mertz", "₩" },
                    { new Guid("44192a69-d2fc-3cbd-2fd6-68e8d97adeb0"), new DateTime(2027, 2, 27, 12, 43, 39, 518, DateTimeKind.Utc).AddTicks(1380), 8736.4300000000003, 3104L, "Romaguera Group", "" },
                    { new Guid("44a66f8d-562a-1dbf-30fd-86094d864332"), new DateTime(2027, 8, 3, 16, 9, 10, 310, DateTimeKind.Utc).AddTicks(4599), 8846.3099999999995, 81217L, "Konopelski, Stark and Roob", "Lt" },
                    { new Guid("44e4ac3c-925a-346f-c202-fe1ceb8e6840"), new DateTime(2027, 6, 21, 13, 45, 7, 191, DateTimeKind.Utc).AddTicks(6281), 9497.6100000000006, 93541L, "O'Reilly - Hagenes", "" },
                    { new Guid("452e9051-9f76-2445-8075-9102da5e5a35"), new DateTime(2026, 9, 5, 7, 46, 48, 587, DateTimeKind.Utc).AddTicks(3728), 300.66000000000003, 31234L, "Hartmann - Cormier", "﷼" },
                    { new Guid("4534d281-f073-8519-5dcf-dc5239b6670f"), new DateTime(2026, 10, 3, 14, 11, 30, 315, DateTimeKind.Utc).AddTicks(4866), 1056.4000000000001, 53078L, "Dibbert and Sons", "" },
                    { new Guid("46248ae8-78b5-c0e9-77a7-04bcbea16e3f"), new DateTime(2027, 8, 1, 23, 12, 47, 209, DateTimeKind.Utc).AddTicks(654), 2218.8200000000002, 89814L, "Dibbert - Littel", "Ls" },
                    { new Guid("465868c8-5dd7-31a6-bb0f-15b149c07278"), new DateTime(2027, 7, 25, 15, 43, 31, 482, DateTimeKind.Utc).AddTicks(8081), 6269.1599999999999, 62579L, "Wiegand, Mills and Howe", "" },
                    { new Guid("46af79ee-09d9-3635-8554-860d415e002a"), new DateTime(2026, 9, 18, 8, 17, 17, 640, DateTimeKind.Utc).AddTicks(9253), 6588.3599999999997, 47184L, "Jacobi - Aufderhar", "zł" },
                    { new Guid("4726c7c9-5ca7-1849-a34b-448ee9890164"), new DateTime(2027, 2, 19, 6, 48, 27, 152, DateTimeKind.Utc).AddTicks(6305), 2966.75, 79658L, "Gleason - Russel", "BZ$" },
                    { new Guid("47477869-8ee3-f441-25b3-e71aac8ae2c9"), new DateTime(2026, 12, 4, 2, 19, 58, 861, DateTimeKind.Utc).AddTicks(9627), 6733.21, 28512L, "McDermott, Leannon and Batz", "$" },
                    { new Guid("47746c94-91b6-0d84-d373-5eaa17417801"), new DateTime(2027, 5, 16, 1, 51, 23, 671, DateTimeKind.Utc).AddTicks(2173), 2564.6500000000001, 66453L, "Connelly - Bayer", "BZ$" },
                    { new Guid("47d0ec3a-7bba-0024-e381-d25b7bf03a29"), new DateTime(2026, 9, 6, 2, 15, 31, 154, DateTimeKind.Utc).AddTicks(8100), 7678.3999999999996, 87936L, "Kuphal - Zboncak", "Ft" },
                    { new Guid("47d6d779-eb70-a14b-cf24-b8ccf772c5ad"), new DateTime(2026, 11, 23, 23, 29, 29, 366, DateTimeKind.Utc).AddTicks(5624), 4967.3199999999997, 47164L, "Pacocha - Bechtelar", "﷼" },
                    { new Guid("480d00ca-93fd-4bcf-0bcb-764c743b2398"), new DateTime(2027, 2, 7, 16, 52, 40, 289, DateTimeKind.Utc).AddTicks(2739), 9028.7800000000007, 84000L, "Kunde Group", "ƒ" },
                    { new Guid("48a4a59f-0052-b668-c7ad-815da96104e7"), new DateTime(2026, 11, 8, 1, 27, 37, 530, DateTimeKind.Utc).AddTicks(870), 1741.5, 83898L, "Lockman, Berge and Kirlin", "лв" },
                    { new Guid("48b8e2b5-7929-e188-dd20-8dc391470cf3"), new DateTime(2026, 11, 29, 14, 18, 4, 978, DateTimeKind.Utc).AddTicks(8747), 864.88999999999999, 23947L, "Jast - Thompson", "" },
                    { new Guid("490475d5-d98e-4236-fda9-c93822e14268"), new DateTime(2026, 11, 17, 9, 14, 10, 981, DateTimeKind.Utc).AddTicks(3142), 5731.7399999999998, 63423L, "Stark - Toy", "$" },
                    { new Guid("493a0cd3-c137-846e-bcb6-2f1dac11605f"), new DateTime(2027, 1, 27, 19, 44, 53, 345, DateTimeKind.Utc).AddTicks(169), 4566.8599999999997, 14349L, "Brekke Inc", "₨" },
                    { new Guid("493ee353-12c3-1d2c-eb6d-0c0d45c20717"), new DateTime(2027, 5, 25, 17, 16, 59, 179, DateTimeKind.Utc).AddTicks(5427), 193.16, 49859L, "Crooks Group", "$" },
                    { new Guid("49584ad0-cea9-3d06-8c46-38cb5975ea73"), new DateTime(2027, 6, 12, 1, 18, 2, 937, DateTimeKind.Utc).AddTicks(1793), 9949.2600000000002, 28899L, "O'Kon - Howell", "﷼" },
                    { new Guid("49b0220d-b27e-90b2-050f-101dcf20c059"), new DateTime(2027, 4, 15, 7, 52, 56, 966, DateTimeKind.Utc).AddTicks(4939), 1783.71, 46593L, "Zemlak LLC", "KM" },
                    { new Guid("49e9f04c-8a73-25de-a68a-d7006952e922"), new DateTime(2027, 2, 20, 15, 11, 31, 605, DateTimeKind.Utc).AddTicks(7743), 7030.0699999999997, 9755L, "Bauch Group", "" },
                    { new Guid("4a21be93-b855-65c4-d969-edb36179203e"), new DateTime(2027, 5, 27, 8, 22, 37, 132, DateTimeKind.Utc).AddTicks(3099), 1427.9100000000001, 18671L, "Runolfsson, Kris and Rau", "£" },
                    { new Guid("4a6fd641-0278-d8d9-a961-836444519ffa"), new DateTime(2027, 7, 20, 17, 41, 14, 195, DateTimeKind.Utc).AddTicks(7172), 8634.8199999999997, 6914L, "Streich LLC", "₮" },
                    { new Guid("4a9c4c4c-6201-4563-1566-891dfe2ffe15"), new DateTime(2027, 5, 7, 22, 31, 14, 141, DateTimeKind.Utc).AddTicks(8375), 5119.3299999999999, 33621L, "Crist, Torp and VonRueden", "₨" },
                    { new Guid("4aaeecb0-08f6-34eb-1010-c6795ef01891"), new DateTime(2026, 8, 11, 11, 0, 58, 301, DateTimeKind.Utc).AddTicks(1136), 3852.7399999999998, 21372L, "Weber and Sons", "$" },
                    { new Guid("4ac4ad2f-6e45-6a0c-1e88-6cd9f761860c"), new DateTime(2026, 11, 15, 5, 31, 9, 316, DateTimeKind.Utc).AddTicks(2158), 1350.8499999999999, 65032L, "Ratke, Adams and Yost", "P" },
                    { new Guid("4ade61f1-d176-061e-6ff1-6bc971a712da"), new DateTime(2027, 6, 26, 14, 11, 21, 216, DateTimeKind.Utc).AddTicks(1642), 6188.2600000000002, 25836L, "Reichert - Marks", "$" },
                    { new Guid("4b021375-6822-1c63-ea87-b8dfd2630268"), new DateTime(2026, 10, 11, 4, 38, 54, 996, DateTimeKind.Utc).AddTicks(49), 2718.4899999999998, 89894L, "Gottlieb - Torp", "лв" },
                    { new Guid("4b204e09-abbd-0dd4-ae11-f2d59ab04495"), new DateTime(2026, 9, 21, 15, 59, 47, 412, DateTimeKind.Utc).AddTicks(9039), 9639.0499999999993, 91069L, "Jakubowski, McLaughlin and Jacobs", "" },
                    { new Guid("4b249b11-6e90-54ad-9a09-c97babdcd2c0"), new DateTime(2027, 1, 23, 14, 0, 58, 32, DateTimeKind.Utc).AddTicks(9409), 4852.4799999999996, 82196L, "Carter LLC", "₨" },
                    { new Guid("4b4bedef-ffed-b35e-4e5b-55e8946893f6"), new DateTime(2026, 9, 20, 11, 39, 18, 727, DateTimeKind.Utc).AddTicks(6078), 7727.5200000000004, 20968L, "Runolfsson - Schroeder", "" },
                    { new Guid("4b706dee-acde-9de0-0c13-bd20b7554e69"), new DateTime(2027, 7, 2, 12, 45, 17, 687, DateTimeKind.Utc).AddTicks(3798), 2141.5500000000002, 54417L, "Walter, Strosin and Wilkinson", "" },
                    { new Guid("4b870147-0b6e-312b-c8a6-a40d14726939"), new DateTime(2026, 9, 12, 8, 25, 43, 899, DateTimeKind.Utc).AddTicks(1187), 9813.7099999999991, 95045L, "Simonis, Roberts and Becker", "ƒ" },
                    { new Guid("4bf7957e-1da0-8afc-0a1d-5a17a4565cc9"), new DateTime(2027, 6, 8, 11, 7, 17, 289, DateTimeKind.Utc).AddTicks(6945), 4941.9300000000003, 59199L, "O'Connell, Gleichner and Jacobson", "P" },
                    { new Guid("4c238d1e-6445-ccf9-8612-2741b9132e33"), new DateTime(2027, 1, 17, 13, 48, 49, 372, DateTimeKind.Utc).AddTicks(1738), 530.15999999999997, 23895L, "Rippin - Blanda", "kr" },
                    { new Guid("4c945bcf-f817-76d5-de63-f66dec122e97"), new DateTime(2027, 4, 5, 16, 44, 40, 210, DateTimeKind.Utc).AddTicks(3163), 1149.52, 76048L, "Schmitt and Sons", "p." },
                    { new Guid("4cd39cba-c6de-4531-7f3a-bbf778a9c6eb"), new DateTime(2026, 12, 2, 7, 49, 44, 348, DateTimeKind.Utc).AddTicks(4963), 2122.8200000000002, 25403L, "Leannon, Hammes and Lehner", "$" },
                    { new Guid("4d03a2c2-f34e-2e73-db7a-e1557ad707d7"), new DateTime(2026, 8, 10, 4, 32, 21, 102, DateTimeKind.Utc).AddTicks(1249), 4571.0500000000002, 92526L, "Champlin and Sons", "лв" },
                    { new Guid("4d198d07-93a8-eaad-c9cc-e7fc11a91cab"), new DateTime(2027, 6, 23, 0, 26, 48, 521, DateTimeKind.Utc).AddTicks(8060), 5485.7799999999997, 84717L, "Nader Group", "ƒ" },
                    { new Guid("4d1c385f-3252-321d-5285-5f9967677f27"), new DateTime(2027, 7, 14, 12, 7, 38, 765, DateTimeKind.Utc).AddTicks(9315), 5530.0200000000004, 39658L, "Dickinson Group", "" },
                    { new Guid("4d4952a0-6f3e-39f5-2224-99a4fae4bb50"), new DateTime(2026, 11, 6, 0, 30, 54, 210, DateTimeKind.Utc).AddTicks(9056), 5624.1700000000001, 20362L, "Walter, Grady and Sporer", "" },
                    { new Guid("4da4900d-ba01-148d-c6b1-122152c2b0b8"), new DateTime(2027, 7, 25, 16, 23, 12, 365, DateTimeKind.Utc).AddTicks(9139), 4205.6800000000003, 11989L, "Ebert, Gibson and Kshlerin", "£" },
                    { new Guid("4ed6457e-49fe-2b9a-f610-9f54791faff7"), new DateTime(2027, 6, 21, 12, 32, 35, 646, DateTimeKind.Utc).AddTicks(7431), 989.26999999999998, 29723L, "Hoppe - DuBuque", "" },
                    { new Guid("4f5514c5-47a6-ff6e-cf63-7ffbadc634c7"), new DateTime(2026, 8, 31, 17, 37, 19, 596, DateTimeKind.Utc).AddTicks(7515), 8929.5400000000009, 54391L, "Zemlak - Swift", "₴" },
                    { new Guid("501168ab-b471-2b70-23e6-6ef6ca037767"), new DateTime(2026, 10, 7, 9, 37, 57, 878, DateTimeKind.Utc).AddTicks(8737), 2183.3699999999999, 74388L, "O'Kon, Ward and Rogahn", "" },
                    { new Guid("511c57fa-38b7-5b54-81f6-a3c445440c23"), new DateTime(2026, 9, 17, 23, 45, 3, 210, DateTimeKind.Utc).AddTicks(5980), 5442.9499999999998, 47616L, "Jacobson - Keeling", "лв" },
                    { new Guid("512465da-f756-1ddf-f8b6-32899890a482"), new DateTime(2027, 6, 21, 15, 17, 58, 100, DateTimeKind.Utc).AddTicks(5162), 3544.5300000000002, 78415L, "Towne Inc", "лв" },
                    { new Guid("51308fa1-b6f6-0d22-6c2e-c757675ffea9"), new DateTime(2026, 12, 12, 1, 26, 38, 278, DateTimeKind.Utc).AddTicks(3369), 9622.3600000000006, 76804L, "Kessler, Kemmer and Fay", "" },
                    { new Guid("513c2e36-0a6a-20df-dbd2-e5968249b100"), new DateTime(2027, 2, 1, 22, 7, 35, 84, DateTimeKind.Utc).AddTicks(6981), 9558.6800000000003, 26240L, "Heaney LLC", "៛" },
                    { new Guid("516c9c93-1752-568b-f409-eb2da65e225d"), new DateTime(2027, 5, 13, 7, 53, 10, 219, DateTimeKind.Utc).AddTicks(567), 869.94000000000005, 88191L, "Sawayn - Greenholt", "KM" },
                    { new Guid("51ad100d-2a38-acc9-30f2-1317daf80e5f"), new DateTime(2027, 2, 15, 6, 31, 26, 277, DateTimeKind.Utc).AddTicks(4933), 8813.8899999999994, 74230L, "Skiles and Sons", "" },
                    { new Guid("522553b5-c4be-9e0b-e2d7-67b5c1120e7b"), new DateTime(2026, 11, 5, 1, 44, 22, 999, DateTimeKind.Utc).AddTicks(8922), 959.96000000000004, 52257L, "MacGyver - Turcotte", "₨" },
                    { new Guid("52704dcf-fe36-e661-6198-b4e865b255f9"), new DateTime(2027, 1, 11, 5, 47, 25, 565, DateTimeKind.Utc).AddTicks(9053), 8283.3600000000006, 86453L, "Stamm, Bins and Bernier", "kr" },
                    { new Guid("52c28139-8ea2-49d5-986e-3336a5c10f4e"), new DateTime(2027, 2, 12, 19, 45, 29, 419, DateTimeKind.Utc).AddTicks(4920), 8547.0599999999995, 27580L, "Green LLC", "лв" },
                    { new Guid("5306caeb-5233-3868-e282-7be95fc027f3"), new DateTime(2027, 6, 19, 4, 13, 41, 976, DateTimeKind.Utc).AddTicks(6770), 6302.0100000000002, 42133L, "Mayer Inc", "" },
                    { new Guid("532a3c56-3a1f-0bf2-2f78-183f108adc3b"), new DateTime(2027, 7, 7, 0, 32, 45, 442, DateTimeKind.Utc).AddTicks(1797), 7924.1700000000001, 13934L, "Johnson Inc", "﷼" },
                    { new Guid("5347ec37-44e9-65f0-de72-0eb60a2f156a"), new DateTime(2027, 7, 24, 20, 20, 56, 196, DateTimeKind.Utc).AddTicks(2756), 7529.9899999999998, 50477L, "Lehner Group", "₺" },
                    { new Guid("534d6504-46aa-9f5e-7873-2d474c3398d2"), new DateTime(2027, 1, 20, 5, 18, 23, 717, DateTimeKind.Utc).AddTicks(461), 1649.3399999999999, 60835L, "Mitchell, Kohler and Feeney", "" },
                    { new Guid("534f0616-b81b-6628-847e-072ed5c275cb"), new DateTime(2026, 12, 12, 20, 17, 5, 297, DateTimeKind.Utc).AddTicks(9465), 7472.6300000000001, 80193L, "Towne - Gutkowski", "" },
                    { new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"), new DateTime(2026, 11, 30, 13, 45, 40, 894, DateTimeKind.Utc).AddTicks(4792), 3904.29, 75123L, "Ratke - Abshire", "" },
                    { new Guid("53e7c164-0aea-78ad-6a31-cf51df5bc0cf"), new DateTime(2026, 10, 29, 12, 17, 13, 172, DateTimeKind.Utc).AddTicks(4677), 1224.6199999999999, 80167L, "Boyle - Mayer", "" },
                    { new Guid("53ef4162-2510-a59d-2b97-57e53850a7c8"), new DateTime(2026, 11, 23, 18, 4, 59, 120, DateTimeKind.Utc).AddTicks(392), 700.97000000000003, 11581L, "Wolf, Bernhard and Cronin", "$" },
                    { new Guid("53fb9190-cae3-df73-ef33-df5327c21106"), new DateTime(2027, 3, 12, 1, 30, 8, 796, DateTimeKind.Utc).AddTicks(8135), 8102.3599999999997, 69234L, "Schmitt Group", "Дин." },
                    { new Guid("541059a5-5365-55eb-fba8-74cdb2ef5f6c"), new DateTime(2027, 2, 22, 8, 16, 50, 224, DateTimeKind.Utc).AddTicks(3228), 6797.8000000000002, 5218L, "Satterfield - Wuckert", "kr" },
                    { new Guid("54382476-8bc5-b2ea-bc48-8af6aa9aefe0"), new DateTime(2026, 9, 18, 21, 15, 3, 125, DateTimeKind.Utc).AddTicks(7508), 8107.6199999999999, 49491L, "Kub, Yost and Emmerich", "" },
                    { new Guid("54660cf4-dafe-0828-e699-7d92da51e0d5"), new DateTime(2027, 1, 5, 3, 47, 10, 36, DateTimeKind.Utc).AddTicks(6573), 6609.5200000000004, 44497L, "Bins Inc", "$" },
                    { new Guid("54a45fb2-d26f-3799-33ac-bc11149a52dc"), new DateTime(2026, 12, 3, 2, 44, 59, 210, DateTimeKind.Utc).AddTicks(5492), 7672.3500000000004, 42191L, "Hills Inc", "" },
                    { new Guid("54b84671-1d16-d12d-8aa0-8ea72d9821cb"), new DateTime(2027, 1, 21, 22, 11, 35, 208, DateTimeKind.Utc).AddTicks(1637), 7634.3699999999999, 87659L, "Leuschke, Greenfelder and Strosin", "₫" },
                    { new Guid("54bfc257-3fa5-fad5-3163-954c4c9af546"), new DateTime(2027, 6, 29, 23, 7, 45, 999, DateTimeKind.Utc).AddTicks(3111), 691.92999999999995, 17943L, "Ortiz LLC", "Gs" },
                    { new Guid("5537aaa5-0c87-369f-88cb-39e8110ff6ab"), new DateTime(2026, 9, 25, 1, 18, 21, 889, DateTimeKind.Utc).AddTicks(2245), 1095.4400000000001, 37389L, "Cremin - Hodkiewicz", "$" },
                    { new Guid("563d852a-075f-258e-842c-ace876f962da"), new DateTime(2027, 5, 11, 23, 22, 57, 870, DateTimeKind.Utc).AddTicks(70), 6367.3900000000003, 28637L, "Fadel - Brakus", "₨" },
                    { new Guid("56744e95-241a-bdf2-d5e6-59231ca9e037"), new DateTime(2027, 7, 17, 15, 32, 47, 562, DateTimeKind.Utc).AddTicks(8831), 5942.8400000000001, 61611L, "Lueilwitz - Rempel", "" },
                    { new Guid("56baf62b-e151-5e8b-6d9e-b97ee24d3cfb"), new DateTime(2027, 8, 3, 10, 51, 55, 962, DateTimeKind.Utc).AddTicks(656), 3066.0, 97525L, "Hills - Bashirian", "$" },
                    { new Guid("57809d73-5040-970a-1659-5b6c31b80f2a"), new DateTime(2026, 9, 2, 7, 0, 44, 758, DateTimeKind.Utc).AddTicks(3834), 9801.5699999999997, 71751L, "Brakus - Heller", "$" },
                    { new Guid("578438c0-f670-76d7-3797-bf2bd0a0bd70"), new DateTime(2027, 4, 17, 6, 39, 26, 756, DateTimeKind.Utc).AddTicks(695), 6836.1800000000003, 32928L, "Lehner, Nicolas and DuBuque", "₦" },
                    { new Guid("57a885f9-1291-a931-56b0-b04f6be5a982"), new DateTime(2026, 10, 4, 21, 35, 19, 798, DateTimeKind.Utc).AddTicks(2941), 7008.6400000000003, 62598L, "Feest Group", "kn" },
                    { new Guid("57c6abb0-68ec-f305-1182-5279bc79929c"), new DateTime(2027, 6, 11, 16, 20, 14, 470, DateTimeKind.Utc).AddTicks(6455), 7998.7299999999996, 44823L, "Veum, Raynor and Shanahan", "£" },
                    { new Guid("57da2236-c236-0645-9a5a-f362d5bae4f8"), new DateTime(2026, 10, 29, 3, 57, 38, 90, DateTimeKind.Utc).AddTicks(1772), 6084.9300000000003, 89403L, "Batz, Tillman and Fahey", "" },
                    { new Guid("580d649b-633b-bec7-5b72-3563bee0ebaf"), new DateTime(2027, 2, 21, 6, 43, 21, 607, DateTimeKind.Utc).AddTicks(2396), 7006.4700000000003, 93911L, "Bosco - Pfeffer", "" },
                    { new Guid("583ccdbe-7295-9489-8ed3-29e43b08d46f"), new DateTime(2026, 8, 9, 10, 25, 6, 622, DateTimeKind.Utc).AddTicks(6537), 7791.8599999999997, 52096L, "Terry LLC", "" },
                    { new Guid("585a7be1-a868-8d54-6840-b08d69f7756c"), new DateTime(2026, 9, 28, 19, 30, 30, 373, DateTimeKind.Utc).AddTicks(9628), 1.9199999999999999, 65104L, "Hintz, Pollich and Larkin", "лв" },
                    { new Guid("59354a34-3333-3a67-bfba-9823150bb6cb"), new DateTime(2027, 4, 23, 17, 57, 25, 217, DateTimeKind.Utc).AddTicks(4381), 8364.25, 99198L, "Bernier, Bernhard and Terry", "" },
                    { new Guid("5951e896-9fd7-9fb1-439e-ef6028f87c4a"), new DateTime(2027, 2, 2, 10, 28, 16, 590, DateTimeKind.Utc).AddTicks(1448), 524.29999999999995, 77751L, "Dooley and Sons", "₦" },
                    { new Guid("59fd0ee6-bba7-8032-3741-7c43a7cd12d1"), new DateTime(2027, 6, 27, 1, 14, 46, 190, DateTimeKind.Utc).AddTicks(2105), 7330.4700000000003, 91691L, "O'Connell, Ratke and Nicolas", "$" },
                    { new Guid("5a6d0e68-bb1e-46db-593e-50e882441313"), new DateTime(2027, 3, 19, 19, 30, 12, 530, DateTimeKind.Utc).AddTicks(3480), 9114.25, 18011L, "Schuster Inc", "" },
                    { new Guid("5a86fe1c-6396-d48d-1a80-a3bea9f0b2a2"), new DateTime(2027, 4, 20, 0, 19, 35, 904, DateTimeKind.Utc).AddTicks(6722), 1281.53, 39639L, "Price LLC", "" },
                    { new Guid("5a91bec8-a1d5-ae3e-5da2-37b209df8ef3"), new DateTime(2026, 10, 13, 5, 21, 38, 767, DateTimeKind.Utc).AddTicks(4149), 3453.9299999999998, 21828L, "Raynor, Goodwin and Hackett", "$" },
                    { new Guid("5acbdbd2-b8cf-441b-4f1d-d2e8b2bcad53"), new DateTime(2027, 4, 18, 1, 22, 21, 280, DateTimeKind.Utc).AddTicks(5649), 9302.5900000000001, 81846L, "Pollich - Simonis", "kr" },
                    { new Guid("5b0aa95c-ce61-4058-faee-3d08d8b9d4a8"), new DateTime(2026, 8, 31, 12, 49, 39, 70, DateTimeKind.Utc).AddTicks(2797), 3463.6399999999999, 39218L, "Haley - Rau", "﷼" },
                    { new Guid("5b483318-490f-2dac-21f8-0d068478d22b"), new DateTime(2027, 1, 8, 11, 30, 23, 155, DateTimeKind.Utc).AddTicks(9352), 8904.1499999999996, 81625L, "Gislason, Kiehn and Bartoletti", "" },
                    { new Guid("5b6b5beb-3b95-834d-df6f-e047a781a0d3"), new DateTime(2027, 1, 24, 14, 46, 2, 835, DateTimeKind.Utc).AddTicks(3372), 7287.0900000000001, 3567L, "Anderson and Sons", "" },
                    { new Guid("5b7a2c93-bcf0-9720-61e2-1298181f1760"), new DateTime(2027, 5, 17, 10, 51, 5, 102, DateTimeKind.Utc).AddTicks(3369), 7726.3299999999999, 21031L, "Schmeler - Quigley", "N$" },
                    { new Guid("5b7ffee3-c459-a2f1-ebf1-8fdc4a104adf"), new DateTime(2027, 6, 29, 6, 54, 41, 840, DateTimeKind.Utc).AddTicks(3058), 1475.23, 56805L, "Lesch, Morar and Gibson", "" },
                    { new Guid("5b84b13f-b16a-a9e8-57c9-83a5d417515f"), new DateTime(2027, 1, 11, 15, 36, 57, 175, DateTimeKind.Utc).AddTicks(9403), 2132.5999999999999, 96623L, "Lehner LLC", "" },
                    { new Guid("5c1465a5-5e64-57aa-9ed7-a574b201ff5c"), new DateTime(2027, 4, 18, 9, 0, 24, 187, DateTimeKind.Utc).AddTicks(2018), 1020.01, 68843L, "Spinka, Bayer and Dach", "Kč" },
                    { new Guid("5c435c64-b77a-5b03-b982-2ca26e88cdfd"), new DateTime(2026, 12, 28, 16, 9, 20, 113, DateTimeKind.Utc).AddTicks(6055), 4079.48, 29542L, "Stoltenberg Group", "؋" },
                    { new Guid("5c618a90-0a8b-3fcd-2399-9b90b3515a17"), new DateTime(2026, 12, 28, 0, 27, 31, 267, DateTimeKind.Utc).AddTicks(5088), 1139.49, 85246L, "Harris - Abbott", "£" },
                    { new Guid("5cce2960-85e6-5a8c-1ce8-ac7fd9e7af92"), new DateTime(2027, 4, 29, 7, 55, 59, 707, DateTimeKind.Utc).AddTicks(1889), 2833.9200000000001, 94573L, "Stroman, Pollich and Zulauf", "$" },
                    { new Guid("5cf8208b-da0a-41eb-fb0d-61cac5c1ecff"), new DateTime(2027, 7, 16, 14, 44, 12, 747, DateTimeKind.Utc).AddTicks(211), 1188.8399999999999, 3180L, "Rutherford, Lockman and Marvin", "" },
                    { new Guid("5d1ee8dd-07b3-ea80-ddc3-5f49be9c7148"), new DateTime(2027, 5, 22, 20, 54, 4, 292, DateTimeKind.Utc).AddTicks(3255), 2558.4299999999998, 39913L, "Pagac Inc", "R$" },
                    { new Guid("5d472b78-1d30-df74-960f-f4a0dc541a45"), new DateTime(2026, 10, 6, 11, 49, 55, 629, DateTimeKind.Utc).AddTicks(4988), 1564.28, 37122L, "Trantow - Lemke", "" },
                    { new Guid("5d6bcb46-276e-5dad-c737-eed6236f1398"), new DateTime(2026, 8, 17, 4, 16, 36, 434, DateTimeKind.Utc).AddTicks(8897), 3945.3699999999999, 24299L, "Kuvalis Inc", "" },
                    { new Guid("5d855284-015e-0c12-79e3-df3b5b318f71"), new DateTime(2027, 1, 28, 22, 50, 56, 733, DateTimeKind.Utc).AddTicks(8010), 3484.9499999999998, 33987L, "Koepp Group", "P" },
                    { new Guid("5dad05aa-fc1b-4b7f-8d8c-b090e013e59d"), new DateTime(2027, 1, 11, 13, 8, 38, 522, DateTimeKind.Utc).AddTicks(4690), 2704.3699999999999, 99752L, "Denesik, Sawayn and Adams", "ƒ" },
                    { new Guid("5dd395fd-1c31-4d31-3aab-768d88855ac7"), new DateTime(2026, 9, 30, 6, 29, 46, 616, DateTimeKind.Utc).AddTicks(775), 8030.2700000000004, 83958L, "Mueller, Wunsch and Gleason", "﷼" },
                    { new Guid("5dfb3bbe-bb6a-2d12-6229-84338da8caf4"), new DateTime(2026, 11, 26, 13, 31, 16, 870, DateTimeKind.Utc).AddTicks(4785), 3263.6100000000001, 43675L, "Kilback LLC", "₮" },
                    { new Guid("5e067ee4-5304-1bc0-6423-b80983ae61ee"), new DateTime(2027, 1, 28, 22, 51, 33, 50, DateTimeKind.Utc).AddTicks(9548), 2505.98, 48911L, "Kirlin, Bartoletti and Schimmel", "₨" },
                    { new Guid("5e23bd8a-8ba7-875a-19ab-bdd051f413cc"), new DateTime(2027, 7, 2, 8, 50, 57, 924, DateTimeKind.Utc).AddTicks(7154), 5587.2200000000003, 8404L, "Wunsch - Heller", "MT" },
                    { new Guid("5e411d0d-7f5e-9c9a-2f7a-aa123621ab61"), new DateTime(2027, 5, 25, 4, 53, 27, 37, DateTimeKind.Utc).AddTicks(1440), 9309.3299999999999, 84728L, "Roob, Treutel and Hartmann", "£" },
                    { new Guid("5ed0f430-17e0-81ca-d86b-5dbae4f16137"), new DateTime(2027, 5, 20, 7, 54, 23, 162, DateTimeKind.Utc).AddTicks(4860), 6719.4399999999996, 15412L, "Prosacco - Wunsch", "ƒ" },
                    { new Guid("5f96d857-7b02-8fe0-59e7-e5bf16c1d509"), new DateTime(2027, 3, 30, 16, 6, 22, 811, DateTimeKind.Utc).AddTicks(5094), 2359.2199999999998, 90758L, "Thompson LLC", "﷼" },
                    { new Guid("6010982e-6972-480e-3756-f9a9c860b317"), new DateTime(2026, 10, 19, 17, 13, 33, 363, DateTimeKind.Utc).AddTicks(6355), 1394.3, 47224L, "Stiedemann Group", "" },
                    { new Guid("603c3c3e-7507-f10c-f8b7-e03d31906a4d"), new DateTime(2027, 3, 7, 9, 28, 36, 307, DateTimeKind.Utc).AddTicks(9261), 9347.5100000000002, 19856L, "Dooley, Lehner and Schamberger", "ден" },
                    { new Guid("60673fbe-22a6-d955-f4d2-e4e0a0f87ae1"), new DateTime(2027, 4, 18, 12, 3, 32, 703, DateTimeKind.Utc).AddTicks(2956), 8975.8199999999997, 4608L, "Kohler LLC", "L" },
                    { new Guid("608cdd91-a905-2fd8-da59-8520ece2389c"), new DateTime(2027, 5, 6, 14, 59, 30, 753, DateTimeKind.Utc).AddTicks(3978), 7763.1199999999999, 74045L, "Wisoky, Gottlieb and Cartwright", "$" },
                    { new Guid("6099e608-600b-0fe3-4fd5-9b18ee52acde"), new DateTime(2026, 9, 3, 21, 10, 14, 812, DateTimeKind.Utc).AddTicks(3685), 4613.6899999999996, 85814L, "Windler, Murphy and Ankunding", "$" },
                    { new Guid("60dda251-d5db-dd27-4ee1-1b88b5ad3f6e"), new DateTime(2027, 5, 22, 21, 14, 12, 161, DateTimeKind.Utc).AddTicks(3300), 6522.25, 8430L, "Stark - Stroman", "p." },
                    { new Guid("619344e9-8fff-b827-e3ab-227cd958696c"), new DateTime(2026, 11, 19, 17, 54, 57, 839, DateTimeKind.Utc).AddTicks(7421), 6581.5299999999997, 14480L, "Keebler Inc", "MT" },
                    { new Guid("61cb7012-2565-b6da-ed1f-ec5eb6cc7921"), new DateTime(2026, 12, 30, 21, 32, 10, 59, DateTimeKind.Utc).AddTicks(4059), 7726.5500000000002, 9502L, "Morar - Rosenbaum", "₦" },
                    { new Guid("61fc9a0a-5b20-a809-95f2-00374121735c"), new DateTime(2026, 11, 28, 3, 12, 30, 817, DateTimeKind.Utc).AddTicks(6741), 8879.9899999999998, 73269L, "Davis - Schumm", "₨" },
                    { new Guid("623e3a1e-a53d-140b-c88a-4f8e0bce2796"), new DateTime(2026, 10, 1, 10, 15, 17, 7, DateTimeKind.Utc).AddTicks(7573), 8106.3100000000004, 26885L, "Cole LLC", "" },
                    { new Guid("62baf4bd-555f-5a31-6902-9b849d7de53f"), new DateTime(2026, 9, 3, 7, 56, 57, 616, DateTimeKind.Utc).AddTicks(6146), 8213.3199999999997, 14926L, "Lang, Glover and Durgan", "J$" },
                    { new Guid("636f9c91-f72e-5485-de3b-75368eb7c730"), new DateTime(2026, 12, 16, 7, 4, 21, 896, DateTimeKind.Utc).AddTicks(7669), 1096.8399999999999, 59536L, "Ferry, Paucek and Hand", "£" },
                    { new Guid("63a8bd6f-f227-97a1-495d-53775aec2060"), new DateTime(2026, 12, 25, 21, 24, 50, 567, DateTimeKind.Utc).AddTicks(6270), 3831.1700000000001, 70924L, "Hamill Inc", "$" },
                    { new Guid("63d6a1ba-7e32-41c0-3a18-01ce415314ac"), new DateTime(2027, 5, 11, 18, 9, 11, 171, DateTimeKind.Utc).AddTicks(9319), 5913.4200000000001, 38471L, "Cassin, Denesik and Macejkovic", "B/." },
                    { new Guid("63f2aa37-6139-bdf6-33c2-30302b079951"), new DateTime(2026, 12, 8, 3, 47, 51, 321, DateTimeKind.Utc).AddTicks(5042), 994.21000000000004, 95855L, "Muller - Strosin", "₺" },
                    { new Guid("64401233-f729-8703-076c-7c6082973edf"), new DateTime(2027, 1, 6, 15, 14, 25, 791, DateTimeKind.Utc).AddTicks(2886), 9866.8600000000006, 41463L, "Nolan Inc", "" },
                    { new Guid("64a7c775-9f80-a723-d7c6-757a67ce4e0e"), new DateTime(2027, 3, 30, 2, 23, 47, 942, DateTimeKind.Utc).AddTicks(6466), 9448.0699999999997, 10855L, "Crist - Deckow", "MT" },
                    { new Guid("65236362-7cf4-772a-0fee-aa6e56ed3ac0"), new DateTime(2027, 5, 14, 2, 42, 16, 627, DateTimeKind.Utc).AddTicks(3874), 7565.1400000000003, 90423L, "Kirlin, D'Amore and Sauer", "" },
                    { new Guid("6552ee21-d54a-62e4-6b33-ea8dd13cc59f"), new DateTime(2027, 6, 23, 9, 54, 19, 506, DateTimeKind.Utc).AddTicks(2414), 6348.2299999999996, 53975L, "Daniel Inc", "R" },
                    { new Guid("65d2a6ab-29b3-a012-68d0-7de4598d83ec"), new DateTime(2027, 3, 2, 2, 35, 8, 836, DateTimeKind.Utc).AddTicks(1840), 3431.1199999999999, 24371L, "Hayes - Buckridge", "$" },
                    { new Guid("668feaae-3a84-7f48-7166-408f2b656505"), new DateTime(2027, 2, 13, 22, 56, 26, 218, DateTimeKind.Utc).AddTicks(5685), 9477.8400000000001, 27570L, "Watsica - Hammes", "" },
                    { new Guid("67ab1076-fea5-0ce2-3b23-dada52241549"), new DateTime(2027, 6, 24, 23, 24, 49, 935, DateTimeKind.Utc).AddTicks(5384), 4338.5500000000002, 74396L, "Price - Maggio", "" },
                    { new Guid("67c896ca-b4a9-b036-47ad-8d651a7de49a"), new DateTime(2027, 5, 15, 6, 54, 32, 440, DateTimeKind.Utc).AddTicks(5459), 3403.0100000000002, 32643L, "Cruickshank, Runolfsson and Kulas", "kr" },
                    { new Guid("68521623-487f-9d71-de49-5e0c11a697dc"), new DateTime(2026, 12, 27, 3, 43, 12, 42, DateTimeKind.Utc).AddTicks(2415), 779.0, 72395L, "Morar - Schaden", "$" },
                    { new Guid("686e21fb-2490-76a0-fe51-c2574d289a26"), new DateTime(2027, 4, 16, 5, 46, 17, 36, DateTimeKind.Utc).AddTicks(1978), 2084.6100000000001, 16815L, "Zboncak, Dietrich and Bosco", "" },
                    { new Guid("689c9b81-693b-cd25-db74-5275ce6beae3"), new DateTime(2027, 1, 20, 2, 32, 47, 799, DateTimeKind.Utc).AddTicks(4777), 6144.0299999999997, 21094L, "King and Sons", "₨" },
                    { new Guid("690c7509-3f0c-00ca-f069-101866af4321"), new DateTime(2026, 10, 6, 10, 51, 41, 186, DateTimeKind.Utc).AddTicks(8553), 3886.98, 13968L, "Mayert - Donnelly", "" },
                    { new Guid("691b8c0d-4cc0-e0a8-3f05-846b67345a65"), new DateTime(2026, 9, 5, 22, 20, 47, 735, DateTimeKind.Utc).AddTicks(3997), 8051.5900000000001, 42052L, "Skiles LLC", "" },
                    { new Guid("692f165d-77a5-d7fe-d51a-8d387975c185"), new DateTime(2026, 11, 14, 15, 33, 42, 149, DateTimeKind.Utc).AddTicks(9057), 3151.52, 38794L, "Feil - Terry", "$" },
                    { new Guid("69cf949d-545d-88a0-2d9a-6f7c66a05596"), new DateTime(2026, 9, 30, 10, 22, 49, 880, DateTimeKind.Utc).AddTicks(6232), 3473.3699999999999, 83614L, "Cartwright Inc", "$" },
                    { new Guid("6a3b12ff-9f38-4eea-4a0f-a90675d73ba4"), new DateTime(2027, 8, 2, 0, 11, 46, 992, DateTimeKind.Utc).AddTicks(8938), 2450.4200000000001, 88992L, "Kunde and Sons", "NT$" },
                    { new Guid("6acee898-3073-e833-0ab3-40e8df9fcf76"), new DateTime(2027, 2, 2, 12, 8, 17, 796, DateTimeKind.Utc).AddTicks(7796), 2350.6100000000001, 44395L, "Kshlerin LLC", "Ft" },
                    { new Guid("6ad8e88b-90d4-9cd0-46cc-498e69ace031"), new DateTime(2027, 6, 10, 16, 6, 30, 851, DateTimeKind.Utc).AddTicks(4996), 696.05999999999995, 36093L, "Lang, Hoppe and Hagenes", "$" },
                    { new Guid("6b009e1d-e71a-a670-3513-063eaf81c4c8"), new DateTime(2026, 10, 8, 8, 24, 12, 340, DateTimeKind.Utc).AddTicks(3808), 5349.1800000000003, 69885L, "Boyle, Stamm and Anderson", "៛" },
                    { new Guid("6b41dcec-de86-bf74-5840-1e0910e6ee19"), new DateTime(2027, 8, 3, 15, 52, 41, 711, DateTimeKind.Utc).AddTicks(779), 8957.5300000000007, 17133L, "Skiles Inc", "Q" },
                    { new Guid("6bbdba9f-78a0-eea6-fa1b-432dc4537731"), new DateTime(2026, 12, 5, 5, 59, 45, 798, DateTimeKind.Utc).AddTicks(2239), 5140.0900000000001, 34720L, "Pfeffer - Glover", "" },
                    { new Guid("6bc7fb09-5dc5-d2fe-25a5-cf5ce6b47373"), new DateTime(2027, 6, 17, 6, 40, 29, 856, DateTimeKind.Utc).AddTicks(8452), 7023.9899999999998, 23894L, "Thiel - Pacocha", "$" },
                    { new Guid("6c2949c4-a684-2f22-6f0b-39164346a331"), new DateTime(2026, 9, 12, 0, 20, 14, 577, DateTimeKind.Utc).AddTicks(6212), 3891.2600000000002, 73051L, "Conroy, Quigley and Monahan", "£" },
                    { new Guid("6ca43125-2a15-bb13-d489-a19386d0da2c"), new DateTime(2026, 9, 4, 15, 24, 0, 19, DateTimeKind.Utc).AddTicks(3141), 7739.1800000000003, 32266L, "Schaden LLC", "Q" },
                    { new Guid("6cb477bb-eb47-3e50-b5e1-d6b14a5f4881"), new DateTime(2026, 11, 17, 1, 35, 40, 157, DateTimeKind.Utc).AddTicks(6202), 5805.7399999999998, 40402L, "Daugherty Inc", "$" },
                    { new Guid("6cc16352-536f-22ed-eb90-6fd5d8b42264"), new DateTime(2027, 5, 9, 12, 33, 2, 583, DateTimeKind.Utc).AddTicks(811), 1825.6900000000001, 45150L, "Reilly - Bode", "" },
                    { new Guid("6cc33791-b1c1-5a68-953a-6212a7cf7627"), new DateTime(2027, 4, 1, 17, 51, 3, 147, DateTimeKind.Utc).AddTicks(6934), 7969.75, 82131L, "Blick - Lowe", "£" },
                    { new Guid("6cd2a506-1416-b985-f591-a6ed5f91e796"), new DateTime(2026, 11, 29, 6, 45, 22, 195, DateTimeKind.Utc).AddTicks(9997), 2013.97, 48972L, "Marvin, Schmidt and Kassulke", "Bs" },
                    { new Guid("6d0b5560-c9c2-2987-6f3f-0e2b81c56b32"), new DateTime(2026, 8, 20, 12, 41, 31, 341, DateTimeKind.Utc).AddTicks(6687), 8982.2099999999991, 36998L, "Willms - Corwin", "" },
                    { new Guid("6d5fc5e5-34f6-1479-ede2-1a93773906a9"), new DateTime(2027, 4, 5, 1, 41, 54, 396, DateTimeKind.Utc).AddTicks(1590), 3268.98, 88090L, "Abshire Group", "лв" },
                    { new Guid("6d67b608-9611-54d4-c034-4ec56d530bcf"), new DateTime(2027, 2, 23, 22, 17, 53, 439, DateTimeKind.Utc).AddTicks(8391), 2739.1999999999998, 68442L, "Stamm, Tillman and Boyer", "kr" },
                    { new Guid("6d786d4f-dfdd-61b5-a4fc-1c853b335082"), new DateTime(2027, 3, 5, 9, 38, 16, 645, DateTimeKind.Utc).AddTicks(8643), 3431.8800000000001, 36719L, "Shanahan - Welch", "KM" },
                    { new Guid("6d7bd228-30eb-a546-2dd4-09972654c0c7"), new DateTime(2026, 8, 23, 20, 4, 6, 328, DateTimeKind.Utc).AddTicks(3968), 2722.3400000000001, 44669L, "Medhurst Inc", "" },
                    { new Guid("6d81a4a0-5aa0-03f5-989f-99a9b77da195"), new DateTime(2027, 2, 27, 0, 10, 42, 496, DateTimeKind.Utc).AddTicks(6925), 9190.6299999999992, 80000L, "Kub, Olson and Jacobson", "₭" },
                    { new Guid("6d86dafe-fb84-d0c1-5289-0e79b4041785"), new DateTime(2027, 4, 17, 4, 25, 47, 986, DateTimeKind.Utc).AddTicks(6529), 9847.7700000000004, 18264L, "Balistreri - Emard", "$" },
                    { new Guid("6e38c1c5-c91b-b3cf-6d80-df142f6789c7"), new DateTime(2026, 12, 13, 8, 24, 57, 990, DateTimeKind.Utc).AddTicks(9953), 7153.54, 42145L, "Murazik and Sons", "Bs" },
                    { new Guid("6ec8e04f-cf2c-150a-d499-df0e7fe8ca2b"), new DateTime(2026, 10, 10, 22, 9, 44, 343, DateTimeKind.Utc).AddTicks(2157), 2374.8000000000002, 60248L, "Ernser - Klein", "" },
                    { new Guid("6ed22a68-d6d4-1af6-36d7-d40393342648"), new DateTime(2026, 12, 22, 0, 23, 40, 419, DateTimeKind.Utc).AddTicks(9133), 597.33000000000004, 95410L, "Johnston, Zemlak and Koepp", "" },
                    { new Guid("6eda1f0b-bb5a-880b-39ef-31d17a2020a5"), new DateTime(2026, 9, 3, 17, 4, 33, 191, DateTimeKind.Utc).AddTicks(3535), 4028.5900000000001, 18965L, "Reynolds, Grady and Thiel", "N$" },
                    { new Guid("6ef64432-385f-a33a-4e92-953eb9f3d14d"), new DateTime(2027, 7, 4, 9, 6, 40, 578, DateTimeKind.Utc).AddTicks(4718), 4882.3400000000001, 22107L, "Hahn Group", "₨" },
                    { new Guid("6f0b2b7f-7bc2-55b0-81ee-bd1b4ed30b8b"), new DateTime(2026, 12, 16, 17, 51, 13, 840, DateTimeKind.Utc).AddTicks(9943), 625.12, 52319L, "Mertz LLC", "Q" },
                    { new Guid("6f36d41b-58c6-3fc9-fb83-ad438ed3382d"), new DateTime(2026, 11, 11, 3, 5, 33, 496, DateTimeKind.Utc).AddTicks(1073), 9496.3099999999995, 37639L, "Nienow - Funk", "" },
                    { new Guid("6f3fe828-e504-8fb0-f987-c330081ca8fe"), new DateTime(2027, 4, 21, 6, 3, 5, 546, DateTimeKind.Utc).AddTicks(1633), 7813.4300000000003, 38452L, "Luettgen - Rutherford", "" },
                    { new Guid("6f7058cf-8da2-c05a-92c1-da8f4a8fb3ab"), new DateTime(2027, 2, 14, 21, 52, 37, 595, DateTimeKind.Utc).AddTicks(7354), 7296.1099999999997, 87930L, "Lockman - Roob", "Ls" },
                    { new Guid("6fa05b67-ac06-1760-5001-ba85671a78a1"), new DateTime(2026, 8, 31, 15, 42, 6, 942, DateTimeKind.Utc).AddTicks(3755), 8453.2700000000004, 32132L, "Lindgren - Wintheiser", "" },
                    { new Guid("6fd55596-f82b-c2e8-3b70-7ff304851d90"), new DateTime(2027, 3, 28, 18, 25, 34, 776, DateTimeKind.Utc).AddTicks(4229), 6345.1199999999999, 32280L, "Kirlin LLC", "" },
                    { new Guid("6fffc9ac-704f-baa8-24cf-ce1b6155c4e7"), new DateTime(2026, 11, 22, 10, 27, 44, 555, DateTimeKind.Utc).AddTicks(4533), 2230.0900000000001, 19386L, "Hackett, Morissette and Keebler", "₪" },
                    { new Guid("7041373d-9d82-8489-0c2a-4b5a84b510d7"), new DateTime(2026, 10, 22, 19, 47, 2, 24, DateTimeKind.Utc).AddTicks(3735), 4464.6400000000003, 31855L, "Hamill - Thompson", "руб" },
                    { new Guid("7072eb2a-c3bd-2a7f-934d-cbefae54e6aa"), new DateTime(2027, 6, 9, 15, 55, 37, 375, DateTimeKind.Utc).AddTicks(8687), 8354.2299999999996, 94856L, "Parker - Johnston", "" },
                    { new Guid("70c49c57-9ae2-bd99-d77c-3723706d0a29"), new DateTime(2026, 11, 14, 11, 14, 21, 108, DateTimeKind.Utc).AddTicks(2074), 3809.3800000000001, 22805L, "Grady, McLaughlin and Flatley", "$" },
                    { new Guid("70e8a1d5-0f6f-c0ba-1364-0f91182bf0a0"), new DateTime(2027, 4, 3, 22, 53, 0, 651, DateTimeKind.Utc).AddTicks(7416), 6853.3199999999997, 4260L, "Rolfson, Bartell and Heaney", "" },
                    { new Guid("718cecef-edcf-11e8-7e1b-251fd6e5372a"), new DateTime(2026, 8, 8, 15, 52, 26, 406, DateTimeKind.Utc).AddTicks(3982), 2687.23, 62174L, "Walter - Roob", "" },
                    { new Guid("71ad1149-5f73-e603-25f2-842151578466"), new DateTime(2027, 7, 24, 15, 57, 18, 159, DateTimeKind.Utc).AddTicks(2291), 8362.4500000000007, 73742L, "Weissnat and Sons", "₨" },
                    { new Guid("72294e50-1333-5d51-7642-d7f700a22740"), new DateTime(2027, 3, 31, 3, 3, 42, 132, DateTimeKind.Utc).AddTicks(8544), 27.960000000000001, 55280L, "Metz LLC", "" },
                    { new Guid("72630819-d453-dd91-5456-24419822ac41"), new DateTime(2027, 5, 16, 0, 7, 20, 203, DateTimeKind.Utc).AddTicks(3535), 5855.5200000000004, 23818L, "Keebler, Conn and Kuvalis", "лв" },
                    { new Guid("72a4e933-0e00-5fe3-64f4-612aa57deec2"), new DateTime(2027, 4, 12, 20, 36, 30, 531, DateTimeKind.Utc).AddTicks(6407), 8583.2600000000002, 6405L, "Johnson - Stark", "лв" },
                    { new Guid("72afa886-6376-81a7-3769-819aadebb3bf"), new DateTime(2027, 2, 17, 8, 57, 31, 376, DateTimeKind.Utc).AddTicks(3274), 2974.4299999999998, 40070L, "Kertzmann Group", "" },
                    { new Guid("72fff58d-dba7-fdc0-d1b6-ca4683318ab6"), new DateTime(2027, 5, 9, 16, 43, 59, 431, DateTimeKind.Utc).AddTicks(3091), 9872.9300000000003, 30117L, "Koelpin, Schultz and Shields", "BZ$" },
                    { new Guid("73876b73-2f57-0535-7fc9-d672c1b224d2"), new DateTime(2027, 5, 16, 22, 33, 7, 457, DateTimeKind.Utc).AddTicks(1780), 5163.46, 47272L, "Hettinger, Lehner and Bailey", "$" },
                    { new Guid("73bba4b0-8120-27ed-cfea-d381fc3651aa"), new DateTime(2027, 6, 18, 6, 45, 20, 944, DateTimeKind.Utc).AddTicks(4774), 5154.6499999999996, 9738L, "Anderson, Strosin and Jacobs", "Ls" },
                    { new Guid("744386d3-8a84-b3e7-934d-a78295d054ea"), new DateTime(2027, 4, 29, 17, 44, 58, 364, DateTimeKind.Utc).AddTicks(9784), 7409.3900000000003, 9162L, "Thompson, VonRueden and Konopelski", "Lek" },
                    { new Guid("747cf847-7096-a9c6-801e-82c05452a7d2"), new DateTime(2026, 12, 25, 22, 14, 26, 725, DateTimeKind.Utc).AddTicks(5769), 4661.5100000000002, 63325L, "Crist, Treutel and Ratke", "$" },
                    { new Guid("753e11bf-18e1-4404-7576-f9a2fb09ab47"), new DateTime(2026, 11, 12, 6, 43, 50, 797, DateTimeKind.Utc).AddTicks(1752), 7377.5200000000004, 22061L, "Kertzmann LLC", "ден" },
                    { new Guid("762cd93f-cc5c-25fb-3364-b1fcbe79ee70"), new DateTime(2026, 8, 31, 21, 32, 56, 449, DateTimeKind.Utc).AddTicks(8006), 9409.0499999999993, 10022L, "Pollich - Koch", "€" },
                    { new Guid("7666c381-9a82-fd55-9a3b-216d4b52abf0"), new DateTime(2026, 10, 19, 20, 13, 28, 372, DateTimeKind.Utc).AddTicks(8857), 3124.25, 52569L, "Emmerich and Sons", "ден" },
                    { new Guid("769f81c3-6188-7e79-39e2-30b720ac4d5d"), new DateTime(2026, 10, 15, 21, 23, 59, 271, DateTimeKind.Utc).AddTicks(4837), 3273.6900000000001, 37976L, "Feil, Fay and Simonis", "" },
                    { new Guid("76cb6188-5630-a7e6-0125-f58c5fcf85b7"), new DateTime(2027, 1, 17, 5, 3, 38, 187, DateTimeKind.Utc).AddTicks(2954), 5154.4099999999999, 68622L, "Feil, Carter and Smitham", "RD$" },
                    { new Guid("76f59e02-4f16-1851-bf8b-d22cb87ffac9"), new DateTime(2027, 2, 19, 22, 7, 41, 50, DateTimeKind.Utc).AddTicks(1502), 4205.5699999999997, 19058L, "Rogahn and Sons", "£" },
                    { new Guid("7704e733-9ee2-a8f4-ccd8-6754f8b510c6"), new DateTime(2027, 2, 26, 21, 5, 47, 908, DateTimeKind.Utc).AddTicks(8924), 7780.0500000000002, 75776L, "Kreiger, Wintheiser and Turner", "$" },
                    { new Guid("7741cff6-9323-4c4f-94f4-6a18c03d1bc2"), new DateTime(2026, 9, 30, 15, 51, 17, 140, DateTimeKind.Utc).AddTicks(8001), 7693.6999999999998, 64227L, "Koelpin, Weber and Sporer", "C$" },
                    { new Guid("7783d12d-ff77-1a25-b3ca-e6d5100f7409"), new DateTime(2026, 11, 3, 20, 15, 54, 36, DateTimeKind.Utc).AddTicks(7734), 3101.6399999999999, 6681L, "Hegmann - Stracke", "лв" },
                    { new Guid("778ad253-62f3-1407-f1c1-eae87cd19fc4"), new DateTime(2027, 2, 28, 3, 20, 28, 473, DateTimeKind.Utc).AddTicks(1887), 327.97000000000003, 86735L, "Dooley, Cormier and McGlynn", "¥" },
                    { new Guid("77a219a7-563a-1e71-0fe9-1234ac2dc337"), new DateTime(2026, 10, 7, 11, 42, 11, 168, DateTimeKind.Utc).AddTicks(4506), 8798.4400000000005, 63354L, "Hintz - Muller", "" },
                    { new Guid("77c61d40-445e-6251-efdf-310fb6d846b2"), new DateTime(2026, 11, 24, 0, 3, 2, 621, DateTimeKind.Utc).AddTicks(2355), 156.41999999999999, 69379L, "Emmerich, Ernser and McGlynn", "$" },
                    { new Guid("78039622-e8c6-2f0d-b547-65011544c384"), new DateTime(2027, 5, 3, 13, 37, 45, 356, DateTimeKind.Utc).AddTicks(9200), 2382.54, 31428L, "Schaden LLC", "$" },
                    { new Guid("780476a4-f3ab-5def-55e2-21e1cc35e4d0"), new DateTime(2026, 9, 21, 20, 54, 23, 834, DateTimeKind.Utc).AddTicks(9824), 9135.1499999999996, 31574L, "Powlowski and Sons", "₦" },
                    { new Guid("79f05f69-4cdc-71e1-1249-ae83d5433431"), new DateTime(2026, 8, 26, 15, 57, 30, 137, DateTimeKind.Utc).AddTicks(4986), 4574.8400000000001, 98593L, "Murphy and Sons", "฿" },
                    { new Guid("7a06bb77-fa6d-c433-89fe-eb5ebd69adfd"), new DateTime(2027, 8, 5, 4, 23, 21, 496, DateTimeKind.Utc).AddTicks(2570), 4084.3899999999999, 20709L, "Rempel, Spinka and Johnson", "" },
                    { new Guid("7a70fa32-b740-f422-6186-f5b8c4d3ca8b"), new DateTime(2027, 2, 23, 7, 47, 16, 267, DateTimeKind.Utc).AddTicks(2773), 761.91999999999996, 76588L, "Connelly Inc", "" },
                    { new Guid("7aec1ce0-95e6-4ea4-ef5f-e245462b5618"), new DateTime(2027, 4, 10, 12, 5, 35, 334, DateTimeKind.Utc).AddTicks(9557), 5210.8800000000001, 45321L, "Green - Gorczany", "" },
                    { new Guid("7b0914c0-ad8e-3a06-40bf-b4e8d0189a50"), new DateTime(2026, 9, 14, 12, 26, 11, 333, DateTimeKind.Utc).AddTicks(4329), 3503.5, 84915L, "Bergnaum - Schultz", "" },
                    { new Guid("7b181888-8bfb-8c18-b556-252d944e0bbb"), new DateTime(2026, 9, 13, 22, 9, 14, 938, DateTimeKind.Utc).AddTicks(3412), 2156.0799999999999, 22534L, "Lang - Deckow", "" },
                    { new Guid("7b193112-fbb1-2ab9-6592-80549d9c247c"), new DateTime(2026, 9, 16, 1, 42, 17, 720, DateTimeKind.Utc).AddTicks(4594), 2882.2199999999998, 48284L, "Nikolaus - McGlynn", "" },
                    { new Guid("7b54986c-bc6c-534c-115a-5dd0c28341a0"), new DateTime(2027, 2, 12, 6, 50, 29, 9, DateTimeKind.Utc).AddTicks(3569), 1069.4400000000001, 15562L, "Reinger - Gutkowski", "$" },
                    { new Guid("7b5fa917-3ee1-f36c-12e1-77e4d30c0f72"), new DateTime(2027, 4, 6, 12, 36, 48, 540, DateTimeKind.Utc).AddTicks(3594), 4394.2700000000004, 82075L, "Blick - Koepp", "﷼" },
                    { new Guid("7bea3968-17df-33bb-84cb-b4b6e03ea7c3"), new DateTime(2026, 8, 22, 4, 13, 15, 208, DateTimeKind.Utc).AddTicks(382), 8868.7900000000009, 72375L, "Beatty - Waters", "" },
                    { new Guid("7c2a46a5-d5eb-fd0b-eb95-6d4ed7199e30"), new DateTime(2026, 8, 23, 21, 32, 51, 337, DateTimeKind.Utc).AddTicks(1112), 340.37, 41485L, "Wilderman - Daugherty", "$" },
                    { new Guid("7c506a94-c30c-8c0b-0114-42bd1a05ddc4"), new DateTime(2026, 8, 14, 10, 55, 59, 509, DateTimeKind.Utc).AddTicks(8735), 1891.6099999999999, 30230L, "Haley - Crooks", "" },
                    { new Guid("7c52ddfb-8d56-a0b1-8a3e-3faa11a1c7d0"), new DateTime(2026, 11, 22, 23, 43, 44, 214, DateTimeKind.Utc).AddTicks(8613), 2755.4000000000001, 56518L, "Ferry, Rogahn and Schultz", "₮" },
                    { new Guid("7c727f79-b998-2adc-a92e-87f746e88f4d"), new DateTime(2026, 11, 24, 14, 2, 59, 823, DateTimeKind.Utc).AddTicks(8309), 7517.0100000000002, 45438L, "Conroy, Lang and Raynor", "ден" },
                    { new Guid("7ce182a9-8274-45eb-ee38-1e3fe649c742"), new DateTime(2027, 4, 7, 3, 26, 54, 604, DateTimeKind.Utc).AddTicks(1533), 1241.8099999999999, 36900L, "Wyman Inc", "" },
                    { new Guid("7d3e0f11-3172-509d-3e39-27b82f55013e"), new DateTime(2027, 6, 1, 20, 49, 31, 908, DateTimeKind.Utc).AddTicks(8798), 6216.75, 62164L, "Lesch, Wilderman and Cartwright", "kr" },
                    { new Guid("7ddcdb03-cb6e-7122-d8f1-cd8d3e2d207a"), new DateTime(2026, 8, 7, 15, 49, 4, 397, DateTimeKind.Utc).AddTicks(7664), 2967.8899999999999, 65666L, "Cole, Purdy and Wuckert", "Rp" },
                    { new Guid("7deb7b75-acff-29e1-c175-6bb9bfe05b8e"), new DateTime(2026, 12, 5, 17, 14, 56, 484, DateTimeKind.Utc).AddTicks(8426), 2520.3600000000001, 94250L, "Durgan - Glover", "" },
                    { new Guid("7e07e9e4-e177-ead3-4062-ff1c211548d1"), new DateTime(2027, 4, 9, 7, 26, 54, 327, DateTimeKind.Utc).AddTicks(6723), 8579.6900000000005, 45907L, "White - Christiansen", "" },
                    { new Guid("7eae23f7-dd17-75aa-bc5b-966724454dfb"), new DateTime(2027, 6, 6, 2, 10, 15, 250, DateTimeKind.Utc).AddTicks(2343), 313.14999999999998, 7383L, "Buckridge, Shanahan and Nader", "$" },
                    { new Guid("7f4032a2-f0f0-64b0-b64e-15362a772a5a"), new DateTime(2027, 4, 13, 21, 9, 12, 918, DateTimeKind.Utc).AddTicks(1660), 5391.6300000000001, 9328L, "Sipes - Roob", "$" },
                    { new Guid("7f54ccf4-35e2-30eb-86bc-505f03e8f8ba"), new DateTime(2026, 9, 24, 15, 33, 25, 118, DateTimeKind.Utc).AddTicks(2873), 494.02999999999997, 29404L, "Dickens - Boehm", "" },
                    { new Guid("7f5d1633-f3f4-6af9-9a14-202f2dfd2a50"), new DateTime(2027, 7, 6, 10, 48, 14, 900, DateTimeKind.Utc).AddTicks(1004), 9763.4500000000007, 19168L, "Dibbert, Walsh and Bruen", "$" },
                    { new Guid("7fb4aaea-ea82-5575-1b3e-68220dcd67e3"), new DateTime(2026, 9, 10, 22, 16, 53, 563, DateTimeKind.Utc).AddTicks(9594), 7969.4899999999998, 18841L, "Rau - Jerde", "Q" },
                    { new Guid("802946e2-b538-f31d-0b69-46ff8b8d6d60"), new DateTime(2027, 5, 17, 11, 13, 56, 83, DateTimeKind.Utc).AddTicks(2374), 8340.7700000000004, 12823L, "Williamson, Goldner and Breitenberg", "$" },
                    { new Guid("80430f59-d29b-854a-9239-de9a566919c2"), new DateTime(2026, 11, 8, 13, 47, 17, 516, DateTimeKind.Utc).AddTicks(5013), 4964.5, 83858L, "Graham Group", "" },
                    { new Guid("8099b02a-35e0-3778-0b16-370d741caf43"), new DateTime(2027, 6, 26, 20, 10, 2, 663, DateTimeKind.Utc).AddTicks(706), 9519.1599999999999, 97434L, "Mertz - Pouros", "Bs" },
                    { new Guid("809b4772-6540-7f6a-165d-9978e36cb453"), new DateTime(2026, 8, 10, 23, 27, 21, 242, DateTimeKind.Utc).AddTicks(4055), 7364.1999999999998, 71451L, "Hagenes - Boyle", "лв" },
                    { new Guid("80d64754-af16-5f15-a840-b66a6232ed64"), new DateTime(2027, 3, 8, 21, 37, 37, 907, DateTimeKind.Utc).AddTicks(2171), 1350.0699999999999, 66128L, "Schneider Group", "" },
                    { new Guid("810690c1-99fa-0d07-11de-1b579102d35a"), new DateTime(2027, 1, 24, 11, 20, 5, 10, DateTimeKind.Utc).AddTicks(2231), 6237.9700000000003, 93036L, "Schmeler, Simonis and Crooks", "¥" },
                    { new Guid("81340fee-7262-36c8-165e-e731a3deec29"), new DateTime(2027, 4, 12, 12, 22, 36, 219, DateTimeKind.Utc).AddTicks(6963), 7122.4899999999998, 81306L, "Lynch - Schaefer", "﷼" },
                    { new Guid("815d016b-41a5-cfe7-f04e-2d6655593520"), new DateTime(2027, 8, 5, 7, 30, 11, 264, DateTimeKind.Utc).AddTicks(4982), 6998.6700000000001, 17797L, "Monahan - Herzog", "" },
                    { new Guid("8184cf37-ae74-b4d5-7d83-3835c3c20b14"), new DateTime(2027, 2, 11, 9, 53, 14, 174, DateTimeKind.Utc).AddTicks(9902), 4613.9799999999996, 41756L, "Howe, Cartwright and Padberg", "RD$" },
                    { new Guid("81bcd594-d6fe-3287-7eab-556928dbb5f6"), new DateTime(2026, 11, 17, 9, 0, 9, 364, DateTimeKind.Utc).AddTicks(2089), 2494.2800000000002, 80291L, "Kohler Inc", "₮" },
                    { new Guid("8220c285-e45f-05e2-8deb-8212a9098701"), new DateTime(2026, 12, 6, 20, 24, 57, 858, DateTimeKind.Utc).AddTicks(3360), 8561.2700000000004, 74871L, "Jacobson, Welch and Dicki", "Bs" },
                    { new Guid("8246bf9f-d269-3a70-6154-e49936253d1a"), new DateTime(2027, 5, 25, 14, 16, 32, 255, DateTimeKind.Utc).AddTicks(2128), 5269.8500000000004, 8540L, "Corwin - Schimmel", "RM" },
                    { new Guid("8256eb6c-87ad-6f39-9280-df866bfbb740"), new DateTime(2027, 4, 4, 15, 32, 6, 855, DateTimeKind.Utc).AddTicks(7415), 7945.04, 64239L, "Cronin, Daniel and Ullrich", "" },
                    { new Guid("82eca56c-3f21-c6e1-42f9-dc37bee9511e"), new DateTime(2026, 11, 11, 18, 43, 34, 283, DateTimeKind.Utc).AddTicks(8136), 5749.8900000000003, 81757L, "Douglas LLC", "TT$" },
                    { new Guid("82fea160-6263-dd20-5ec1-82afeece4634"), new DateTime(2027, 5, 6, 13, 49, 33, 901, DateTimeKind.Utc).AddTicks(2632), 1532.4300000000001, 11563L, "Christiansen Inc", "Gs" },
                    { new Guid("830cd727-6e4b-daf0-2170-84218930f378"), new DateTime(2027, 3, 9, 16, 17, 28, 846, DateTimeKind.Utc).AddTicks(2314), 6059.1599999999999, 77073L, "Nienow - Howell", "Bs" },
                    { new Guid("831dfef2-8f3d-5e90-12cb-acb04502c768"), new DateTime(2027, 1, 16, 22, 9, 0, 16, DateTimeKind.Utc).AddTicks(170), 2097.8200000000002, 22143L, "McDermott - Dooley", "₨" },
                    { new Guid("8321ab6a-690a-7fe3-8e68-1fa2795612c6"), new DateTime(2026, 12, 11, 21, 29, 47, 883, DateTimeKind.Utc).AddTicks(8783), 84.280000000000001, 76254L, "Hilpert - Weissnat", "kr" },
                    { new Guid("83320788-1cd7-8908-f864-c561b4ce4e9a"), new DateTime(2027, 4, 15, 11, 26, 56, 57, DateTimeKind.Utc).AddTicks(743), 8456.4099999999999, 66988L, "Pollich, Emmerich and Harris", "" },
                    { new Guid("8358b6da-ce64-8853-3bf3-9a6a84b32a3b"), new DateTime(2027, 5, 3, 21, 54, 7, 887, DateTimeKind.Utc).AddTicks(717), 7383.1800000000003, 47493L, "Schoen - Sawayn", "" },
                    { new Guid("84b8d0cc-cfd7-5624-ae90-cad21dd1d23a"), new DateTime(2027, 7, 5, 11, 33, 31, 670, DateTimeKind.Utc).AddTicks(5140), 6842.4099999999999, 27028L, "Marvin, Wehner and Heaney", "" },
                    { new Guid("84d9a632-ba58-5e62-f116-040fd44b95ee"), new DateTime(2027, 4, 26, 19, 45, 22, 877, DateTimeKind.Utc).AddTicks(1789), 6772.4099999999999, 90124L, "Schaefer - Ledner", "$" },
                    { new Guid("850944b8-df58-87ec-15ec-997a06059037"), new DateTime(2026, 11, 9, 22, 55, 18, 263, DateTimeKind.Utc).AddTicks(8337), 4230.0600000000004, 96999L, "O'Kon LLC", "" },
                    { new Guid("85589261-ad16-391c-7de1-2420d53ac39c"), new DateTime(2026, 12, 22, 4, 58, 32, 743, DateTimeKind.Utc).AddTicks(954), 4869.9799999999996, 21130L, "Champlin LLC", "" },
                    { new Guid("8585a9ee-d41d-aa9d-01f2-255cc6201f96"), new DateTime(2027, 3, 10, 18, 23, 25, 241, DateTimeKind.Utc).AddTicks(6236), 5784.4799999999996, 66344L, "Romaguera, Jacobs and Spinka", "" },
                    { new Guid("8628db1b-54b1-772e-6b69-ca3a836f8399"), new DateTime(2026, 12, 8, 6, 16, 36, 733, DateTimeKind.Utc).AddTicks(2816), 3743.0599999999999, 58943L, "Kuphal, Cassin and Kihn", "" },
                    { new Guid("866136f3-3b80-7cde-06b9-fc52ddff25dd"), new DateTime(2027, 6, 13, 15, 31, 37, 333, DateTimeKind.Utc).AddTicks(1812), 9944.5200000000004, 17159L, "Little, Kutch and Sawayn", "$" },
                    { new Guid("866f1628-d48e-668f-f0ea-83fe805e6a59"), new DateTime(2026, 10, 30, 18, 14, 37, 197, DateTimeKind.Utc).AddTicks(2092), 825.11000000000001, 34217L, "Sipes, Cassin and Abernathy", "" },
                    { new Guid("86c67375-4c42-0930-f84f-a9a868d13b97"), new DateTime(2027, 3, 18, 16, 0, 49, 7, DateTimeKind.Utc).AddTicks(5599), 111.88, 46256L, "Witting, Rutherford and Daniel", "" },
                    { new Guid("86fb0feb-adb9-c470-21d4-89e51bf28777"), new DateTime(2026, 9, 9, 18, 54, 22, 274, DateTimeKind.Utc).AddTicks(8296), 5570.29, 68427L, "Hansen, Stiedemann and Lesch", "" },
                    { new Guid("8795d370-9456-b71d-fcb0-e541575abb6f"), new DateTime(2026, 12, 17, 5, 7, 7, 890, DateTimeKind.Utc).AddTicks(523), 179.72999999999999, 82009L, "MacGyver, Dickens and Swift", "₭" },
                    { new Guid("87ffa6f7-6715-d8c0-693c-1b2846124076"), new DateTime(2026, 12, 16, 8, 16, 32, 633, DateTimeKind.Utc).AddTicks(4306), 3890.4200000000001, 63765L, "Hamill, Grant and Koelpin", "" },
                    { new Guid("88192754-814f-87cb-3fb3-3ee0a5cb8260"), new DateTime(2027, 7, 31, 21, 28, 53, 342, DateTimeKind.Utc).AddTicks(2171), 9461.8299999999999, 62081L, "Nicolas LLC", "Дин." },
                    { new Guid("886c1010-62ad-bf20-e993-e2c11f3ab568"), new DateTime(2027, 1, 27, 9, 10, 30, 375, DateTimeKind.Utc).AddTicks(4542), 8912.25, 62215L, "Weimann, Larkin and Romaguera", "" },
                    { new Guid("8872cf67-44ea-70c7-6ae4-59be075226f7"), new DateTime(2027, 5, 31, 4, 45, 57, 706, DateTimeKind.Utc).AddTicks(609), 3714.4200000000001, 69055L, "Mertz - Hartmann", "Gs" },
                    { new Guid("88fd47a0-7c87-578a-79df-58c712aeb8d3"), new DateTime(2026, 8, 18, 2, 15, 54, 312, DateTimeKind.Utc).AddTicks(6616), 6534.8400000000001, 86572L, "Fay - Doyle", "₦" },
                    { new Guid("890ce33d-c7df-4faf-102b-8e078aecde08"), new DateTime(2027, 5, 7, 20, 39, 2, 66, DateTimeKind.Utc).AddTicks(3305), 94.129999999999995, 86433L, "Homenick, Emard and Robel", "" },
                    { new Guid("890db3ec-d5a4-cabf-91de-8d23317e319c"), new DateTime(2027, 6, 4, 5, 26, 6, 907, DateTimeKind.Utc).AddTicks(7684), 658.75999999999999, 74052L, "O'Keefe Group", "Rp" },
                    { new Guid("892a4517-97b5-7479-34cd-b95db266a663"), new DateTime(2026, 9, 10, 8, 30, 9, 488, DateTimeKind.Utc).AddTicks(7499), 2827.1799999999998, 46664L, "Murray, Kautzer and Gusikowski", "₹" },
                    { new Guid("89526104-632a-6967-0f92-2ddbecb831f4"), new DateTime(2027, 7, 2, 16, 30, 43, 698, DateTimeKind.Utc).AddTicks(8275), 1220.49, 39218L, "Spinka Inc", "" },
                    { new Guid("8968b3cd-cfe4-44d2-396a-0b27359a97de"), new DateTime(2027, 5, 18, 19, 59, 8, 262, DateTimeKind.Utc).AddTicks(2250), 9864.5900000000001, 2068L, "Kovacek LLC", "€" },
                    { new Guid("898a48bc-ec42-6ffd-5b57-4f97bfaba94a"), new DateTime(2026, 12, 7, 16, 49, 45, 58, DateTimeKind.Utc).AddTicks(7341), 4083.54, 95691L, "Streich and Sons", "$" },
                    { new Guid("89928f57-925f-6085-61c8-4bf3b51b41a5"), new DateTime(2026, 12, 19, 16, 41, 30, 399, DateTimeKind.Utc).AddTicks(4735), 7756.1000000000004, 47071L, "Cartwright - Pacocha", "NT$" },
                    { new Guid("89df9686-966b-f70d-45c1-05b7f00fd6a2"), new DateTime(2026, 12, 6, 14, 4, 11, 206, DateTimeKind.Utc).AddTicks(4069), 9493.8600000000006, 17150L, "Lowe - Torphy", "" },
                    { new Guid("8a309b0e-9aa4-bc57-1d8b-3311869ceee4"), new DateTime(2027, 4, 19, 11, 4, 14, 186, DateTimeKind.Utc).AddTicks(5339), 1294.0899999999999, 82483L, "Thiel, Olson and Dicki", "₭" },
                    { new Guid("8aa79b46-2d61-e290-003e-5f970bbfefa4"), new DateTime(2027, 2, 22, 7, 7, 30, 761, DateTimeKind.Utc).AddTicks(7178), 1538.97, 72531L, "Buckridge and Sons", "Gs" },
                    { new Guid("8aca6524-8265-7150-54c8-64c9b5a90d4a"), new DateTime(2026, 12, 22, 1, 44, 14, 571, DateTimeKind.Utc).AddTicks(6830), 442.80000000000001, 15401L, "Gutmann - Batz", "Ft" },
                    { new Guid("8b34bf40-e9b9-128b-4ad4-488b7a2afb90"), new DateTime(2027, 6, 21, 10, 9, 57, 734, DateTimeKind.Utc).AddTicks(2726), 8286.5, 5482L, "Jast Group", "$" },
                    { new Guid("8b43a96d-a75a-0690-45a8-e633ea707e10"), new DateTime(2026, 11, 30, 10, 32, 56, 644, DateTimeKind.Utc).AddTicks(7697), 9462.4500000000007, 19523L, "Kassulke - Weimann", "" },
                    { new Guid("8bbdeac2-d336-75ee-d6ca-b7b28ad69fb1"), new DateTime(2026, 11, 3, 10, 55, 16, 395, DateTimeKind.Utc).AddTicks(4949), 9960.6599999999999, 20222L, "Connelly Inc", "C$" },
                    { new Guid("8bc727ce-69c5-37b5-251c-4457d6942dc1"), new DateTime(2026, 9, 12, 17, 34, 22, 609, DateTimeKind.Utc).AddTicks(5222), 7956.2600000000002, 26122L, "Jacobs LLC", "" },
                    { new Guid("8c083ccb-08ba-f2d9-ad86-4102b3a0f918"), new DateTime(2026, 12, 30, 14, 20, 50, 769, DateTimeKind.Utc).AddTicks(8218), 869.77999999999997, 96497L, "Rau Group", "Дин." },
                    { new Guid("8cab24c8-1f04-c418-2e93-313fb68da757"), new DateTime(2026, 10, 28, 4, 30, 53, 217, DateTimeKind.Utc).AddTicks(1921), 7556.6099999999997, 76391L, "Connelly - King", "₫" },
                    { new Guid("8d21d44d-0ff8-7dfe-c6bb-ec77f954f4dc"), new DateTime(2027, 3, 24, 15, 46, 10, 999, DateTimeKind.Utc).AddTicks(5331), 3170.8000000000002, 95499L, "Morar LLC", "" },
                    { new Guid("8d257f04-b0b0-1060-a1c4-6aa1de500424"), new DateTime(2027, 3, 11, 2, 37, 55, 460, DateTimeKind.Utc).AddTicks(9979), 1266.8399999999999, 3641L, "Daugherty and Sons", "R$" },
                    { new Guid("8d4c902d-cfc7-c768-2808-fc43e2208b25"), new DateTime(2027, 2, 17, 3, 42, 37, 458, DateTimeKind.Utc).AddTicks(6193), 541.38, 76419L, "Ward - Fisher", "" },
                    { new Guid("8deb6efe-905c-f0e2-cc18-8dc5268e0b5d"), new DateTime(2026, 10, 31, 12, 27, 25, 781, DateTimeKind.Utc).AddTicks(3982), 4987.3199999999997, 32473L, "Towne LLC", "" },
                    { new Guid("8e0c856e-7e9d-fa0d-eda3-26fa2b410d1a"), new DateTime(2027, 2, 26, 9, 8, 28, 174, DateTimeKind.Utc).AddTicks(7756), 9194.6800000000003, 80466L, "Tremblay - Schiller", "" },
                    { new Guid("8e1ab9a0-ee4f-5351-8b36-50a87d9b7d1b"), new DateTime(2026, 9, 27, 2, 48, 20, 460, DateTimeKind.Utc).AddTicks(4531), 1192.24, 13178L, "Kovacek, Lubowitz and Lynch", "" },
                    { new Guid("8e214dcc-477b-b0c4-001b-856740d2b386"), new DateTime(2027, 4, 25, 1, 27, 15, 997, DateTimeKind.Utc).AddTicks(3940), 3687.02, 97307L, "Gleason - Torp", "" },
                    { new Guid("8e283a86-c065-1fc7-1e65-96542e2ee49d"), new DateTime(2027, 4, 2, 16, 33, 7, 622, DateTimeKind.Utc).AddTicks(9280), 9086.5300000000007, 86935L, "Nicolas LLC", "kr" },
                    { new Guid("8eb36b6e-8031-f944-82e6-be8952984b8b"), new DateTime(2027, 1, 1, 12, 8, 43, 661, DateTimeKind.Utc).AddTicks(5316), 8007.0900000000001, 7976L, "Kilback - Pollich", "" },
                    { new Guid("8edb0133-255e-411f-f560-0731ff0a1931"), new DateTime(2026, 11, 28, 15, 23, 54, 930, DateTimeKind.Utc).AddTicks(8677), 830.44000000000005, 70698L, "Vandervort - Koss", "$" },
                    { new Guid("8efeab9b-0325-8693-a9c8-0858804a2f1e"), new DateTime(2027, 6, 30, 8, 1, 18, 679, DateTimeKind.Utc).AddTicks(983), 8089.1199999999999, 7054L, "Bradtke - Schmeler", "Rp" },
                    { new Guid("8f3d1663-8fd8-a5cb-6e2f-a85d4916165d"), new DateTime(2027, 6, 24, 1, 7, 24, 839, DateTimeKind.Utc).AddTicks(1441), 7141.71, 21943L, "Schoen, Harris and Rohan", "₺" },
                    { new Guid("8f75f8f1-4a4e-6186-ff5f-da4b5481b8df"), new DateTime(2027, 1, 13, 19, 34, 24, 336, DateTimeKind.Utc).AddTicks(1928), 7495.9099999999999, 39722L, "Robel - Hintz", "₺" },
                    { new Guid("8f7d9f1f-a4b3-5d9b-3836-b741b0cc062a"), new DateTime(2027, 2, 21, 3, 47, 56, 602, DateTimeKind.Utc).AddTicks(9738), 1290.0699999999999, 54627L, "Hane - Ryan", "$" },
                    { new Guid("8f93ce2d-0e45-45ae-1c01-3d9ec9a14403"), new DateTime(2027, 2, 3, 20, 40, 10, 356, DateTimeKind.Utc).AddTicks(5526), 5018.3999999999996, 27458L, "Stokes, Nienow and Von", "₡" },
                    { new Guid("8f9849a3-ac83-07db-3f98-d73c817ba151"), new DateTime(2026, 9, 22, 9, 11, 37, 365, DateTimeKind.Utc).AddTicks(2604), 9209.3600000000006, 82013L, "Macejkovic, Turcotte and Bailey", "лв" },
                    { new Guid("8fb4415b-f183-c2fc-5d0e-0b8f61bbefc4"), new DateTime(2027, 7, 3, 1, 19, 35, 823, DateTimeKind.Utc).AddTicks(7021), 4604.6300000000001, 85332L, "Greenfelder, McGlynn and Brekke", "$" },
                    { new Guid("8fe8cea3-d553-895e-0980-62effd59330e"), new DateTime(2026, 11, 29, 11, 6, 0, 73, DateTimeKind.Utc).AddTicks(8538), 7868.8500000000004, 67575L, "Blick and Sons", "" },
                    { new Guid("90759361-4f15-6128-0f80-1d0395c86830"), new DateTime(2027, 5, 24, 5, 24, 22, 644, DateTimeKind.Utc).AddTicks(38), 5432.7399999999998, 35584L, "Smith - Cummerata", "" },
                    { new Guid("907709cb-e5ef-9dc4-f914-e6dcdfd9b0b7"), new DateTime(2027, 6, 3, 16, 57, 18, 579, DateTimeKind.Utc).AddTicks(4501), 4730.9200000000001, 11145L, "Vandervort - Keeling", "₨" },
                    { new Guid("90986fe6-434d-830c-42cc-3d122a935f57"), new DateTime(2026, 10, 26, 1, 36, 23, 754, DateTimeKind.Utc).AddTicks(1132), 109.51000000000001, 31851L, "Wisoky Group", "kr" },
                    { new Guid("90a3d78b-bc0d-319f-879c-35b7d533a0e6"), new DateTime(2026, 11, 8, 9, 36, 10, 463, DateTimeKind.Utc).AddTicks(6086), 332.19999999999999, 64163L, "Purdy - Yundt", "" },
                    { new Guid("90af9248-af55-5c81-3878-3e8469d01f31"), new DateTime(2027, 1, 25, 12, 0, 5, 905, DateTimeKind.Utc).AddTicks(1359), 1594.9400000000001, 2032L, "McKenzie Group", "Bs" },
                    { new Guid("90ce02ed-0b67-6984-40d5-78aeee4830ad"), new DateTime(2027, 1, 9, 1, 46, 50, 749, DateTimeKind.Utc).AddTicks(6960), 2061.4000000000001, 94578L, "Pollich, Boyle and Hills", "$" },
                    { new Guid("91180619-ccd8-bbe9-f8ae-cc32356dd22c"), new DateTime(2026, 8, 20, 18, 38, 48, 461, DateTimeKind.Utc).AddTicks(4999), 6927.5299999999997, 93515L, "Heaney and Sons", "₨" },
                    { new Guid("913b47e5-4656-12f5-93d0-41fca0c63b18"), new DateTime(2027, 5, 18, 0, 54, 30, 494, DateTimeKind.Utc).AddTicks(617), 7782.0699999999997, 63425L, "Marquardt, Wisoky and Larson", "" },
                    { new Guid("915a90b2-836d-86b8-1737-e1059036c89a"), new DateTime(2027, 2, 23, 8, 0, 19, 44, DateTimeKind.Utc).AddTicks(8303), 9793.1800000000003, 35084L, "Turner, Hermiston and Yundt", "CHF" },
                    { new Guid("9171db25-59b6-f683-5753-747ac13115e8"), new DateTime(2027, 5, 30, 1, 4, 14, 517, DateTimeKind.Utc).AddTicks(9221), 3297.46, 81853L, "Dickens Inc", "$" },
                    { new Guid("91856bdc-b239-2b08-bb90-e3394e39a149"), new DateTime(2027, 6, 22, 15, 17, 51, 420, DateTimeKind.Utc).AddTicks(9556), 4115.9099999999999, 26711L, "Welch - Larson", "$" },
                    { new Guid("91a13832-0dc8-4ade-ac22-491705102f04"), new DateTime(2027, 7, 5, 20, 53, 47, 358, DateTimeKind.Utc).AddTicks(9744), 1245.72, 65247L, "Turner, Durgan and Erdman", "TT$" },
                    { new Guid("91af6b81-b8ff-311c-bcde-a7d337a91d19"), new DateTime(2026, 10, 23, 6, 37, 46, 812, DateTimeKind.Utc).AddTicks(6), 8984.4300000000003, 61280L, "Kling, Lockman and Koss", "ден" },
                    { new Guid("922a818d-9725-a9f7-7eff-494c2635fcae"), new DateTime(2026, 10, 24, 15, 16, 42, 956, DateTimeKind.Utc).AddTicks(1369), 6283.1000000000004, 24371L, "Lueilwitz - Hamill", "$" },
                    { new Guid("923037dd-f9df-af73-1943-2ce783286c01"), new DateTime(2026, 9, 16, 13, 48, 26, 3, DateTimeKind.Utc).AddTicks(1009), 4587.1000000000004, 49926L, "Sporer - Schowalter", "Rp" },
                    { new Guid("92313abf-3903-a9d5-93c3-a73d1245e4af"), new DateTime(2027, 3, 7, 0, 25, 55, 637, DateTimeKind.Utc).AddTicks(6210), 2451.73, 68528L, "Wisoky LLC", "" },
                    { new Guid("92821288-8547-aa88-e17e-a149a5cb694e"), new DateTime(2027, 1, 13, 15, 30, 21, 410, DateTimeKind.Utc).AddTicks(8004), 4969.0500000000002, 67515L, "Jerde - Thiel", "NT$" },
                    { new Guid("92f532ba-b2e8-f5c7-2df8-55a08d9a0bec"), new DateTime(2027, 6, 21, 10, 29, 27, 772, DateTimeKind.Utc).AddTicks(5109), 9505.1399999999994, 70499L, "VonRueden - Berge", "﷼" },
                    { new Guid("92fa2400-1282-8e71-4be2-75f7670beb89"), new DateTime(2026, 12, 1, 7, 54, 59, 841, DateTimeKind.Utc).AddTicks(6299), 2143.79, 46270L, "Morissette, Schneider and Senger", "Nu" },
                    { new Guid("9349b9bf-8b3f-8fff-fd08-7c0d7b75a270"), new DateTime(2027, 4, 14, 9, 50, 40, 493, DateTimeKind.Utc).AddTicks(3031), 8442.1200000000008, 78440L, "Wunsch Group", "$" },
                    { new Guid("93520263-8889-9ffc-86ff-fe48ecf6aebd"), new DateTime(2027, 3, 11, 1, 17, 29, 635, DateTimeKind.Utc).AddTicks(8714), 4300.1499999999996, 69806L, "Green, Baumbach and Aufderhar", "" },
                    { new Guid("937fe4ae-1c8c-def3-da30-a9867cf7f71c"), new DateTime(2027, 3, 21, 1, 52, 17, 216, DateTimeKind.Utc).AddTicks(88), 3683.75, 32388L, "Corwin - Daugherty", "€" },
                    { new Guid("9459c2ac-047a-9bbb-5275-9bbb43f4b527"), new DateTime(2026, 9, 27, 3, 39, 4, 340, DateTimeKind.Utc).AddTicks(7123), 9952.6000000000004, 82583L, "Fahey, McKenzie and Stamm", "" },
                    { new Guid("94c0d15f-d9d2-ef4e-aa44-d05b50e8d0c2"), new DateTime(2027, 5, 8, 15, 16, 1, 605, DateTimeKind.Utc).AddTicks(9327), 4702.96, 93864L, "Breitenberg, Torp and Steuber", "" },
                    { new Guid("9507883d-d5c5-3e2e-e3bc-46cd47005280"), new DateTime(2027, 6, 19, 11, 20, 44, 274, DateTimeKind.Utc).AddTicks(1879), 1462.97, 44091L, "Corkery - Dach", "៛" },
                    { new Guid("951c3d6b-f091-5370-b2d5-765263275bb2"), new DateTime(2026, 9, 11, 23, 50, 21, 760, DateTimeKind.Utc).AddTicks(6749), 5597.1800000000003, 46099L, "Graham Group", "₺" },
                    { new Guid("95454751-17dc-2ae1-0f12-6380079b534f"), new DateTime(2027, 3, 24, 10, 24, 30, 936, DateTimeKind.Utc).AddTicks(6876), 2071.8600000000001, 42288L, "Dare Inc", "kr" },
                    { new Guid("95543df1-61d8-8d9d-4332-631818a6a658"), new DateTime(2026, 9, 4, 8, 27, 24, 219, DateTimeKind.Utc).AddTicks(7915), 1767.03, 36509L, "Corwin - Hackett", "C$" },
                    { new Guid("955a4066-eed6-48a8-1803-acf61246bec8"), new DateTime(2027, 2, 21, 19, 48, 42, 794, DateTimeKind.Utc).AddTicks(1517), 649.13999999999999, 37815L, "Thiel Inc", "" },
                    { new Guid("95a03258-c591-3c88-66ed-b821a01c4efd"), new DateTime(2026, 8, 13, 9, 51, 10, 895, DateTimeKind.Utc).AddTicks(530), 2228.6100000000001, 92687L, "Heidenreich, Dietrich and Fay", "$" },
                    { new Guid("95bb4be2-3c25-7625-59f0-efe0b7e50e6d"), new DateTime(2027, 6, 18, 20, 53, 23, 310, DateTimeKind.Utc).AddTicks(8791), 5651.8699999999999, 27433L, "Orn LLC", "RM" },
                    { new Guid("96ba173e-04ae-3bcd-9986-9e56f0adbf3a"), new DateTime(2026, 12, 30, 3, 16, 39, 989, DateTimeKind.Utc).AddTicks(6793), 902.03999999999996, 15220L, "Schultz LLC", "" },
                    { new Guid("96cbc724-a3d3-0326-bd10-31849f07d947"), new DateTime(2027, 5, 8, 3, 54, 26, 280, DateTimeKind.Utc).AddTicks(2613), 4905.1099999999997, 40203L, "Bartoletti Inc", "฿" },
                    { new Guid("96ceb23f-19f0-5045-d786-a691091f9982"), new DateTime(2027, 3, 16, 5, 16, 40, 536, DateTimeKind.Utc).AddTicks(5378), 7796.6400000000003, 32175L, "Mueller Inc", "៛" },
                    { new Guid("978676e4-34bc-148c-7bfe-acaa54194809"), new DateTime(2027, 4, 4, 16, 23, 4, 657, DateTimeKind.Utc).AddTicks(4320), 1869.0599999999999, 45276L, "Schmitt - Mann", "NT$" },
                    { new Guid("97b3db46-dc20-1e5c-1209-4637b25341f5"), new DateTime(2026, 12, 27, 9, 49, 48, 167, DateTimeKind.Utc).AddTicks(1003), 8346.1800000000003, 31494L, "Beahan - Cremin", "$" },
                    { new Guid("9856b3c6-de6b-3323-92bf-0102af88a7dd"), new DateTime(2027, 7, 8, 0, 37, 52, 439, DateTimeKind.Utc).AddTicks(6965), 8100.6700000000001, 79447L, "Paucek - Rutherford", "$" },
                    { new Guid("9865a3a5-7da7-4701-d1e1-19a1c8bab606"), new DateTime(2026, 11, 8, 1, 3, 10, 193, DateTimeKind.Utc).AddTicks(9920), 3129.6599999999999, 97957L, "Hartmann Inc", "﷼" },
                    { new Guid("98a79e3d-9183-1df1-f7f3-44f681974173"), new DateTime(2026, 8, 29, 10, 19, 5, 549, DateTimeKind.Utc).AddTicks(7780), 813.09000000000003, 25210L, "Lynch Inc", "N$" },
                    { new Guid("98b5d4e3-442d-5801-8cbd-42feee7b20a7"), new DateTime(2026, 10, 19, 14, 6, 38, 835, DateTimeKind.Utc).AddTicks(5046), 1783.9200000000001, 61329L, "Feest, Gislason and Grant", "£" },
                    { new Guid("98c8777d-6f28-a784-c6fd-909e84206cf9"), new DateTime(2027, 6, 15, 0, 41, 30, 398, DateTimeKind.Utc).AddTicks(74), 164.84, 40811L, "McLaughlin, Yost and Farrell", "$U" },
                    { new Guid("99aef068-2924-ed07-d9fe-a9c793d37f22"), new DateTime(2026, 12, 17, 16, 47, 6, 740, DateTimeKind.Utc).AddTicks(1447), 9458.3999999999996, 77062L, "MacGyver and Sons", "Kč" },
                    { new Guid("99b58f1d-522d-2cc0-6874-3f0df9dbd14c"), new DateTime(2027, 4, 24, 3, 52, 55, 505, DateTimeKind.Utc).AddTicks(8577), 3670.1399999999999, 57211L, "Satterfield - Smitham", "" },
                    { new Guid("99de2625-4292-a1be-8246-3c87e3ad71e2"), new DateTime(2027, 6, 25, 19, 7, 15, 257, DateTimeKind.Utc).AddTicks(6594), 1015.61, 40407L, "Breitenberg - Kling", "N$" },
                    { new Guid("99e63b22-78bd-6bf6-edc8-7577752ff9e5"), new DateTime(2027, 6, 21, 15, 33, 3, 219, DateTimeKind.Utc).AddTicks(1373), 8793.4799999999996, 52423L, "Hahn, Hettinger and Hahn", "$" },
                    { new Guid("9a19a4b3-1f3f-6373-a104-9aa1d04cf32d"), new DateTime(2027, 5, 18, 5, 3, 26, 119, DateTimeKind.Utc).AddTicks(5641), 685.19000000000005, 59809L, "Bergnaum Inc", "$" },
                    { new Guid("9a55be5b-48fb-3214-0bd6-c4148f3df0b9"), new DateTime(2026, 8, 26, 0, 7, 31, 392, DateTimeKind.Utc).AddTicks(5180), 3658.27, 54444L, "Abernathy - Rutherford", "$" },
                    { new Guid("9adf27cd-269e-60e3-13ea-be3030602782"), new DateTime(2027, 4, 25, 9, 5, 55, 656, DateTimeKind.Utc).AddTicks(9736), 3567.77, 71860L, "Parker, Muller and Schuppe", "$" },
                    { new Guid("9b04a2b7-3486-fb8e-e30f-fbeeaba8d181"), new DateTime(2026, 12, 1, 16, 23, 38, 466, DateTimeKind.Utc).AddTicks(3131), 1093.8399999999999, 3143L, "Roob, Zulauf and Kozey", "$" },
                    { new Guid("9b2100bd-168b-8d44-4f7c-9ed6f9c1319a"), new DateTime(2026, 12, 9, 22, 48, 32, 613, DateTimeKind.Utc).AddTicks(3404), 2221.3000000000002, 8645L, "Orn - Champlin", "B/." },
                    { new Guid("9b34151d-3b8e-e784-a6bf-329b571f18a1"), new DateTime(2027, 6, 6, 14, 16, 57, 986, DateTimeKind.Utc).AddTicks(3706), 8652.1299999999992, 96252L, "Johnson - Weimann", "" },
                    { new Guid("9b58a966-74f2-ea2b-1632-391abd36cef2"), new DateTime(2026, 8, 17, 10, 49, 14, 975, DateTimeKind.Utc).AddTicks(637), 3452.6700000000001, 64415L, "Denesik, Jenkins and O'Hara", "S/." },
                    { new Guid("9b885bcc-bce0-3def-4f4d-a8a13bf6386a"), new DateTime(2026, 11, 10, 5, 0, 33, 184, DateTimeKind.Utc).AddTicks(1362), 6223.2600000000002, 67496L, "Wisoky - Windler", "₭" },
                    { new Guid("9c068e4b-cafe-0765-2e6a-8473ce0e8b92"), new DateTime(2026, 8, 31, 10, 55, 42, 205, DateTimeKind.Utc).AddTicks(1601), 6032.3500000000004, 51114L, "Watsica LLC", "" },
                    { new Guid("9c480ed8-4688-4b99-ddde-dca4857919fd"), new DateTime(2027, 3, 26, 16, 43, 51, 29, DateTimeKind.Utc).AddTicks(2549), 2066.8499999999999, 30449L, "Becker - Osinski", "$" },
                    { new Guid("9c8b967a-c8bf-8429-9525-12c929c94b00"), new DateTime(2027, 2, 15, 14, 28, 8, 572, DateTimeKind.Utc).AddTicks(1393), 8585.3799999999992, 43205L, "Powlowski - McKenzie", "" },
                    { new Guid("9c911090-df69-85f9-f3fe-c57bd8ffa96c"), new DateTime(2026, 10, 24, 6, 39, 56, 688, DateTimeKind.Utc).AddTicks(3770), 4778.8100000000004, 68744L, "Bogisich Group", "₩" },
                    { new Guid("9d2faa9d-30d4-8e7d-e8ee-51413667ba08"), new DateTime(2026, 11, 11, 12, 7, 39, 716, DateTimeKind.Utc).AddTicks(7965), 9663.6100000000006, 55068L, "Lowe, Schroeder and Kovacek", "" },
                    { new Guid("9d3bc80f-f26e-0565-9e4c-3104629639c3"), new DateTime(2026, 8, 8, 23, 19, 37, 469, DateTimeKind.Utc).AddTicks(7022), 6897.3199999999997, 69360L, "Dickinson and Sons", "" },
                    { new Guid("9d46b827-7a4a-80d7-dfb3-bf40e8fabd0e"), new DateTime(2027, 7, 19, 14, 31, 45, 741, DateTimeKind.Utc).AddTicks(873), 690.61000000000001, 82368L, "Windler Inc", "Q" },
                    { new Guid("9d55af6c-53eb-79e4-1bf1-42435a23843c"), new DateTime(2026, 9, 30, 4, 16, 42, 252, DateTimeKind.Utc).AddTicks(7105), 6993.4799999999996, 56207L, "Wilderman Group", "" },
                    { new Guid("9da21371-f35c-2aed-e8b3-3a640a662e52"), new DateTime(2026, 12, 21, 8, 30, 58, 893, DateTimeKind.Utc).AddTicks(7830), 4310.3500000000004, 53197L, "Beatty Inc", "$" },
                    { new Guid("9de41d5a-c08a-1dc2-f8b0-c9911c38ca99"), new DateTime(2027, 3, 13, 16, 33, 51, 896, DateTimeKind.Utc).AddTicks(45), 3123.4699999999998, 33825L, "Hills, Reichel and Zulauf", "$" },
                    { new Guid("9df5fe33-edd3-967e-ceb3-f99072005d28"), new DateTime(2026, 12, 1, 1, 34, 50, 790, DateTimeKind.Utc).AddTicks(4291), 9057.3799999999992, 8289L, "Murray, Towne and Auer", "$" },
                    { new Guid("9e34490a-ffec-0880-7fbc-6a6fbfe5c46a"), new DateTime(2026, 12, 2, 2, 59, 26, 228, DateTimeKind.Utc).AddTicks(7512), 4880.75, 74520L, "Wuckert - Franecki", "$" },
                    { new Guid("9e47fd0a-9a15-1b69-c3b4-fdd6ee91fbd0"), new DateTime(2027, 7, 11, 12, 48, 57, 831, DateTimeKind.Utc).AddTicks(3539), 5894.8800000000001, 86259L, "Beer and Sons", "Nu" },
                    { new Guid("9efab825-62a0-3977-be5d-616e71f6c529"), new DateTime(2027, 7, 30, 14, 17, 39, 291, DateTimeKind.Utc).AddTicks(801), 7819.25, 44093L, "Hauck Group", "" },
                    { new Guid("9f176e6a-5fa3-e13c-cf94-c785f637effc"), new DateTime(2027, 2, 18, 23, 56, 38, 260, DateTimeKind.Utc).AddTicks(4128), 6528.3100000000004, 8740L, "Balistreri - Mayer", "$" },
                    { new Guid("9f315870-7a19-234a-8c92-751c50ad1d39"), new DateTime(2027, 3, 13, 2, 15, 7, 949, DateTimeKind.Utc).AddTicks(5185), 959.69000000000005, 94454L, "Hessel, Koepp and Armstrong", "" },
                    { new Guid("9f6271bc-7221-3376-7b64-34f31323656d"), new DateTime(2027, 5, 28, 2, 19, 48, 818, DateTimeKind.Utc).AddTicks(4100), 4614.6700000000001, 71585L, "Corkery - Miller", "₨" },
                    { new Guid("9fc927f9-6121-2f8f-638c-f7c599534295"), new DateTime(2026, 10, 25, 6, 39, 45, 268, DateTimeKind.Utc).AddTicks(3642), 3926.0700000000002, 47263L, "Wisozk - Rosenbaum", "Db" },
                    { new Guid("9fce0d58-cd3f-3e15-0e82-99a5c614b996"), new DateTime(2026, 8, 23, 16, 26, 34, 821, DateTimeKind.Utc).AddTicks(4789), 8146.8599999999997, 20185L, "Greenfelder - Walker", "NT$" },
                    { new Guid("9fe2f8df-b49c-2b29-9fe7-e9ddea69583b"), new DateTime(2027, 2, 13, 9, 58, 49, 806, DateTimeKind.Utc).AddTicks(4186), 1808.8099999999999, 7845L, "DuBuque, Beahan and Miller", "S/." },
                    { new Guid("a039bdfa-8bfd-8873-5d31-32df2c1f4a9c"), new DateTime(2026, 11, 3, 18, 42, 20, 60, DateTimeKind.Utc).AddTicks(9250), 3012.6900000000001, 11448L, "Buckridge Group", "ƒ" },
                    { new Guid("a0694d88-8d2c-ec56-93b4-18a2f6e27841"), new DateTime(2027, 1, 29, 8, 32, 12, 1, DateTimeKind.Utc).AddTicks(2137), 1721.22, 46323L, "Buckridge - Hayes", "Php" },
                    { new Guid("a07d8657-cdb4-e364-4bea-2390410143fd"), new DateTime(2027, 6, 11, 4, 12, 36, 783, DateTimeKind.Utc).AddTicks(4479), 2440.9099999999999, 56440L, "Graham, Moore and Reichel", "ман" },
                    { new Guid("a0c22b84-288f-a908-6f3b-ef3cbd22f82c"), new DateTime(2027, 5, 18, 7, 46, 7, 125, DateTimeKind.Utc).AddTicks(1636), 9721.8299999999999, 89471L, "Dibbert - Sawayn", "MT" },
                    { new Guid("a224358c-c98e-d00a-f4c1-c15cbc59cecf"), new DateTime(2027, 3, 6, 17, 58, 20, 793, DateTimeKind.Utc).AddTicks(6216), 5833.8199999999997, 72056L, "Wisoky, Ondricka and Cormier", "" },
                    { new Guid("a2c14156-f379-b60d-518e-67ba30593dd7"), new DateTime(2027, 1, 17, 4, 47, 27, 294, DateTimeKind.Utc).AddTicks(9760), 8897.8099999999995, 1516L, "Prohaska, Wiza and Schaefer", "" },
                    { new Guid("a36e2596-92b6-e648-f2e8-4c11d0ea828c"), new DateTime(2027, 6, 5, 19, 57, 17, 917, DateTimeKind.Utc).AddTicks(3060), 35.229999999999997, 17690L, "Stark Group", "" },
                    { new Guid("a3dd87cd-5bf0-32f6-9af1-a562647c8050"), new DateTime(2027, 4, 13, 0, 0, 56, 654, DateTimeKind.Utc).AddTicks(3246), 7501.3299999999999, 42010L, "Oberbrunner and Sons", "" },
                    { new Guid("a3f31eb1-dcee-8d2b-1bca-aae6a8fe2269"), new DateTime(2027, 4, 16, 18, 41, 40, 485, DateTimeKind.Utc).AddTicks(523), 5833.4399999999996, 6806L, "MacGyver Inc", "" },
                    { new Guid("a46a104d-8c5d-e982-b7d3-71539ff502f9"), new DateTime(2027, 2, 15, 11, 31, 44, 644, DateTimeKind.Utc).AddTicks(8296), 3919.1900000000001, 40742L, "Aufderhar - Reichert", "" },
                    { new Guid("a498aaee-1e0a-5ba6-f435-495b57c89bfb"), new DateTime(2027, 4, 25, 21, 33, 54, 822, DateTimeKind.Utc).AddTicks(383), 4374.5699999999997, 17677L, "McClure, Kris and Maggio", "BZ$" },
                    { new Guid("a50057d2-cd96-0e54-cb40-3c5c36958293"), new DateTime(2026, 8, 29, 20, 0, 55, 466, DateTimeKind.Utc).AddTicks(1244), 8355.0400000000009, 9120L, "Heller, White and Hahn", "" },
                    { new Guid("a570e6cd-9f6d-bed2-65fe-cc3ca37dce0d"), new DateTime(2027, 6, 23, 3, 49, 48, 543, DateTimeKind.Utc).AddTicks(925), 5135.3400000000001, 56432L, "Klein and Sons", "$" },
                    { new Guid("a5a201c8-cf0d-3d21-63ad-735e372556ff"), new DateTime(2027, 2, 14, 21, 6, 15, 897, DateTimeKind.Utc).AddTicks(1978), 4474.0, 36489L, "Von Group", "kr" },
                    { new Guid("a5eb26b5-d5dc-110c-bac8-225d3c99cb24"), new DateTime(2026, 9, 8, 12, 9, 37, 318, DateTimeKind.Utc).AddTicks(1939), 8560.8799999999992, 64097L, "Stroman - Upton", "" },
                    { new Guid("a625790a-1bac-7843-62a8-0f7c56f36973"), new DateTime(2027, 7, 29, 9, 59, 27, 139, DateTimeKind.Utc).AddTicks(4859), 4925.0100000000002, 79073L, "Kohler - Miller", "R$" },
                    { new Guid("a63b1bee-fc39-5476-b5a8-0f1321d36c9b"), new DateTime(2026, 12, 20, 9, 28, 7, 214, DateTimeKind.Utc).AddTicks(175), 818.99000000000001, 32394L, "Marquardt Inc", "" },
                    { new Guid("a6736fb3-38fa-b482-1a40-b6881e304d27"), new DateTime(2026, 11, 23, 23, 32, 49, 26, DateTimeKind.Utc).AddTicks(7233), 7745.4200000000001, 8856L, "Lynch, Mohr and Konopelski", "CHF" },
                    { new Guid("a765863b-59a3-36b4-9973-61488c6e45df"), new DateTime(2027, 7, 19, 8, 52, 25, 269, DateTimeKind.Utc).AddTicks(4052), 9055.2700000000004, 62581L, "Trantow and Sons", "ден" },
                    { new Guid("a7cdd788-dd16-242e-92dc-d3d85598e4da"), new DateTime(2026, 9, 20, 15, 59, 1, 153, DateTimeKind.Utc).AddTicks(2286), 9004.7299999999996, 25690L, "Weimann, Weissnat and Parisian", "" },
                    { new Guid("a7dc5ef1-e847-e2ee-b1eb-0d9903303a6f"), new DateTime(2027, 3, 5, 17, 35, 52, 344, DateTimeKind.Utc).AddTicks(2736), 294.44, 27548L, "Roberts and Sons", "MT" },
                    { new Guid("a8046b3c-123d-0f36-0c4a-0e09c0d5c550"), new DateTime(2026, 8, 11, 15, 57, 44, 964, DateTimeKind.Utc).AddTicks(2744), 4119.9300000000003, 21847L, "Douglas and Sons", "Bs" },
                    { new Guid("a8440a6a-b251-34c0-56ba-b17fd1e585fd"), new DateTime(2026, 12, 14, 1, 24, 3, 809, DateTimeKind.Utc).AddTicks(351), 1457.9100000000001, 83645L, "Corkery, Homenick and Collins", "" },
                    { new Guid("a8541d59-b772-1ee0-dbfe-aac0c7dc4cce"), new DateTime(2026, 12, 1, 4, 12, 45, 14, DateTimeKind.Utc).AddTicks(7643), 9746.9899999999998, 14097L, "Lynch, Shanahan and Kris", "kr" },
                    { new Guid("a89bdbd0-8a9e-65ad-a494-66afdf6660e7"), new DateTime(2026, 8, 24, 20, 45, 17, 293, DateTimeKind.Utc).AddTicks(3522), 7999.7700000000004, 13049L, "Marks Group", "" },
                    { new Guid("a8b7475f-025f-9c6e-21a0-92df625f5e5c"), new DateTime(2027, 6, 3, 11, 25, 4, 595, DateTimeKind.Utc).AddTicks(4782), 9070.3899999999994, 58833L, "Ratke, Quigley and Halvorson", "؋" },
                    { new Guid("a8dabb0f-a25f-7592-cb5b-691ddf4106e2"), new DateTime(2027, 4, 25, 20, 33, 7, 141, DateTimeKind.Utc).AddTicks(4211), 2300.4400000000001, 39125L, "Hackett and Sons", "₺" },
                    { new Guid("a90c2d36-923c-ad5b-9644-0e161f47d356"), new DateTime(2026, 11, 18, 20, 6, 41, 316, DateTimeKind.Utc).AddTicks(3975), 6300.8000000000002, 39592L, "Kuhic - Feest", "Дин." },
                    { new Guid("a91a1356-6162-e3a7-c81f-9e9f2a823626"), new DateTime(2027, 6, 26, 20, 55, 20, 314, DateTimeKind.Utc).AddTicks(5254), 340.81, 16952L, "Nicolas and Sons", "kr" },
                    { new Guid("a9643a6e-a326-fa2f-d92a-51c50c95ac28"), new DateTime(2026, 9, 27, 0, 58, 58, 984, DateTimeKind.Utc).AddTicks(2607), 6901.21, 42287L, "Murray and Sons", "" },
                    { new Guid("a96c77a0-e1fd-10c4-03a0-2617e60328d3"), new DateTime(2027, 8, 5, 3, 29, 32, 317, DateTimeKind.Utc).AddTicks(4423), 9817.8299999999999, 16234L, "Walker - Johnson", "" },
                    { new Guid("a9b8a444-f236-c11d-68dd-9812d54a4e06"), new DateTime(2026, 11, 11, 11, 47, 41, 826, DateTimeKind.Utc).AddTicks(1950), 3074.3800000000001, 74960L, "McGlynn, Borer and Konopelski", "" },
                    { new Guid("aa81469c-19b4-d0d0-d3a1-19c1111d5a32"), new DateTime(2026, 10, 23, 17, 18, 27, 481, DateTimeKind.Utc).AddTicks(9094), 7251.8500000000004, 87377L, "Macejkovic, Douglas and Fahey", "$" },
                    { new Guid("aaac1152-b915-f528-7af2-7691d72316ce"), new DateTime(2027, 7, 10, 12, 17, 45, 764, DateTimeKind.Utc).AddTicks(2878), 4622.0900000000001, 80060L, "Beatty Group", "﷼" },
                    { new Guid("aad920a7-2e3d-98f0-eab3-18ac67cb614f"), new DateTime(2027, 5, 29, 12, 26, 53, 377, DateTimeKind.Utc).AddTicks(4352), 7680.7600000000002, 91629L, "DuBuque - Carroll", "RM" },
                    { new Guid("aadc227a-3317-099e-cf4c-f569e1901a1b"), new DateTime(2027, 8, 4, 2, 48, 52, 432, DateTimeKind.Utc).AddTicks(5213), 3151.46, 42131L, "Schroeder, Jast and Sauer", "" },
                    { new Guid("aaef9697-aebd-24aa-743a-8a310fe13ac5"), new DateTime(2027, 5, 28, 12, 2, 27, 917, DateTimeKind.Utc).AddTicks(5165), 6652.5600000000004, 83188L, "Quitzon - Willms", "$" },
                    { new Guid("ab29cb93-935f-5e73-08e2-e74d4601835c"), new DateTime(2027, 2, 11, 4, 4, 49, 381, DateTimeKind.Utc).AddTicks(5178), 5780.4799999999996, 49364L, "Stoltenberg - White", "$" },
                    { new Guid("ab6e8f80-9f77-b6a8-f347-7b2d3ec94997"), new DateTime(2026, 12, 8, 2, 43, 56, 485, DateTimeKind.Utc).AddTicks(1203), 7864.29, 81749L, "Ortiz - Hane", "Php" },
                    { new Guid("ab748453-de7d-cded-a973-13d749c59b0a"), new DateTime(2026, 12, 9, 13, 4, 0, 647, DateTimeKind.Utc).AddTicks(5719), 9637.9500000000007, 89208L, "Kulas - Hagenes", "KM" },
                    { new Guid("ac053a56-56c5-90f3-5257-49c6018ff551"), new DateTime(2026, 11, 11, 15, 57, 18, 833, DateTimeKind.Utc).AddTicks(2099), 279.20999999999998, 88017L, "Auer, Collins and Hermann", "" },
                    { new Guid("ac398ee3-bfec-934d-48e4-a770d6878cf5"), new DateTime(2027, 3, 25, 3, 34, 42, 911, DateTimeKind.Utc).AddTicks(3976), 3305.9499999999998, 32802L, "Nolan LLC", "S/." },
                    { new Guid("ac544cb7-acfb-09b2-8550-2f752ce01b9c"), new DateTime(2026, 12, 20, 0, 4, 3, 208, DateTimeKind.Utc).AddTicks(5031), 4799.8299999999999, 58859L, "Erdman Inc", "" },
                    { new Guid("ac555e36-2574-f0b6-4319-e27ba6d450c6"), new DateTime(2027, 5, 6, 15, 47, 10, 782, DateTimeKind.Utc).AddTicks(3162), 5414.9099999999999, 8969L, "Buckridge and Sons", "$" },
                    { new Guid("ac961dbb-3ddd-f80f-f947-0e423262f96a"), new DateTime(2026, 10, 1, 0, 39, 12, 336, DateTimeKind.Utc).AddTicks(2428), 6734.5100000000002, 99330L, "Windler, Cummings and Hayes", "S" },
                    { new Guid("acbae41c-96c0-66e0-54f3-6edac1d5acae"), new DateTime(2026, 11, 26, 15, 21, 15, 807, DateTimeKind.Utc).AddTicks(2533), 4280.8199999999997, 99636L, "Labadie Inc", "$" },
                    { new Guid("ace52fe9-3c73-ebad-5ee8-0d7b232e1082"), new DateTime(2026, 10, 21, 11, 47, 45, 318, DateTimeKind.Utc).AddTicks(9171), 1241.6199999999999, 7719L, "Prohaska - Collins", "ман" },
                    { new Guid("ace5e16b-9400-34ae-160d-1e1a49a4d7e7"), new DateTime(2026, 8, 26, 0, 27, 37, 480, DateTimeKind.Utc).AddTicks(7892), 5991.8199999999997, 90529L, "Stoltenberg, Hoeger and McClure", "kn" },
                    { new Guid("acfff376-7c10-2482-d792-2e7b2519c6e6"), new DateTime(2026, 10, 19, 16, 25, 42, 906, DateTimeKind.Utc).AddTicks(6837), 9956.1100000000006, 69515L, "Okuneva, Goyette and Quigley", "" },
                    { new Guid("ad054b69-9dfd-bde4-b2c0-0b93a2957a3d"), new DateTime(2026, 11, 27, 19, 40, 52, 616, DateTimeKind.Utc).AddTicks(4073), 6886.6599999999999, 19235L, "Shields, Stanton and Reilly", "" },
                    { new Guid("ad53db4f-9206-fced-9470-68dad2459531"), new DateTime(2027, 2, 2, 5, 6, 43, 973, DateTimeKind.Utc).AddTicks(5809), 5810.4499999999998, 89943L, "Yundt, Erdman and Nicolas", "kr" },
                    { new Guid("ad6ed5dd-8c30-ab5b-6521-d8bcc6f8b1aa"), new DateTime(2026, 12, 6, 23, 3, 52, 104, DateTimeKind.Utc).AddTicks(7017), 4292.1899999999996, 89958L, "Schuster, Grady and Emmerich", "R" },
                    { new Guid("ad828ce5-10ca-179c-8290-f0a7e2554b31"), new DateTime(2026, 12, 6, 19, 44, 0, 411, DateTimeKind.Utc).AddTicks(3723), 7949.0500000000002, 83278L, "Dibbert - Nikolaus", "₨" },
                    { new Guid("ad84a085-ae7e-66d0-e6aa-4534be0347fa"), new DateTime(2026, 12, 7, 7, 4, 2, 979, DateTimeKind.Utc).AddTicks(1696), 8776.9400000000005, 54787L, "Padberg and Sons", "$" },
                    { new Guid("ae17bc31-18e4-56c3-7676-f76d1479c79d"), new DateTime(2026, 9, 2, 15, 24, 32, 776, DateTimeKind.Utc).AddTicks(5140), 2838.9499999999998, 45734L, "MacGyver - Bashirian", "" },
                    { new Guid("ae1d051a-9578-313b-40b4-195fb60b073b"), new DateTime(2027, 7, 26, 18, 7, 27, 525, DateTimeKind.Utc).AddTicks(1713), 3840.52, 27510L, "Mraz - Cole", "" },
                    { new Guid("aeabdf37-4955-6341-183b-b3f8ae220343"), new DateTime(2027, 2, 2, 22, 10, 13, 428, DateTimeKind.Utc).AddTicks(2825), 850.20000000000005, 96210L, "Schroeder, Lesch and Carter", "₨" },
                    { new Guid("aed32956-cf55-3aa9-b901-f2168a128b8f"), new DateTime(2027, 7, 13, 13, 16, 46, 533, DateTimeKind.Utc).AddTicks(9666), 3751.4200000000001, 76554L, "Lockman - Gutkowski", "" },
                    { new Guid("af360b15-0974-8dbc-0613-9b8a12fe56bf"), new DateTime(2026, 11, 21, 4, 31, 18, 282, DateTimeKind.Utc).AddTicks(9504), 3729.4099999999999, 16643L, "Sauer - Reichert", "" },
                    { new Guid("afb7ee91-e766-7144-d24b-ec6feb7cb979"), new DateTime(2027, 2, 12, 5, 18, 25, 724, DateTimeKind.Utc).AddTicks(2928), 2647.04, 39809L, "Fritsch Inc", "£" },
                    { new Guid("b002a5f5-376b-7a00-836d-856a3907f5a0"), new DateTime(2026, 11, 25, 19, 55, 4, 522, DateTimeKind.Utc).AddTicks(6062), 2002.1199999999999, 98675L, "Kub, Terry and Metz", "" },
                    { new Guid("b03837e3-07c3-0d08-3bd2-c4a597e5c43a"), new DateTime(2027, 1, 11, 7, 58, 24, 120, DateTimeKind.Utc).AddTicks(2317), 8273.8600000000006, 9283L, "Sauer, O'Connell and Windler", "Nu" },
                    { new Guid("b03fd512-7557-0415-025d-1319bfad041a"), new DateTime(2026, 11, 16, 0, 57, 20, 736, DateTimeKind.Utc).AddTicks(7948), 7499.6400000000003, 63532L, "Dickinson - Kuphal", "£" },
                    { new Guid("b08a86ca-d8d8-4618-550e-58821375f9f8"), new DateTime(2026, 12, 9, 9, 17, 21, 147, DateTimeKind.Utc).AddTicks(135), 6725.71, 33771L, "Block, Lang and Koepp", "" },
                    { new Guid("b0902b30-84cf-51b7-4aa2-05900c1ed95b"), new DateTime(2027, 6, 23, 0, 6, 48, 381, DateTimeKind.Utc).AddTicks(236), 7016.1499999999996, 72449L, "Shanahan, D'Amore and Stokes", "£" },
                    { new Guid("b1610fb7-5a15-e285-884b-e33047b8d3e6"), new DateTime(2027, 7, 12, 21, 51, 49, 482, DateTimeKind.Utc).AddTicks(5599), 2786.1500000000001, 30697L, "Murray - Murazik", "£" },
                    { new Guid("b18acef6-6d1a-a5aa-d664-25f456533b43"), new DateTime(2027, 3, 31, 19, 12, 22, 897, DateTimeKind.Utc).AddTicks(7246), 5703.5200000000004, 74903L, "Hudson - Huels", "﷼" },
                    { new Guid("b1b1f56d-651a-05e3-2b7e-c7a8ba8c40ba"), new DateTime(2026, 12, 22, 22, 54, 17, 161, DateTimeKind.Utc).AddTicks(58), 852.25, 2679L, "Will, Zieme and Hermann", "" },
                    { new Guid("b22a9197-f67e-6d9f-99c3-6f97ad82c631"), new DateTime(2026, 11, 21, 21, 34, 55, 881, DateTimeKind.Utc).AddTicks(3648), 1054.1500000000001, 65969L, "Rath, Stracke and Senger", "" },
                    { new Guid("b25cac9c-f63a-1436-ae07-d2c6b2bb87f4"), new DateTime(2027, 2, 10, 4, 45, 33, 57, DateTimeKind.Utc).AddTicks(1284), 3613.3099999999999, 45509L, "Pfannerstill, Goodwin and Mann", "" },
                    { new Guid("b27e2f37-14c7-0ca0-ae52-d4e1f23d238c"), new DateTime(2026, 10, 19, 6, 5, 28, 707, DateTimeKind.Utc).AddTicks(4411), 1638.53, 57644L, "Muller, Casper and Mosciski", "Bs" },
                    { new Guid("b2831fcf-16ab-bca1-e8cf-0426140ca3d0"), new DateTime(2026, 12, 6, 7, 10, 39, 109, DateTimeKind.Utc).AddTicks(4552), 2638.9200000000001, 6873L, "Renner - Simonis", "﷼" },
                    { new Guid("b2849681-b64c-869a-33c7-1d13c4c29edc"), new DateTime(2026, 9, 20, 10, 26, 56, 368, DateTimeKind.Utc).AddTicks(9309), 3638.7800000000002, 41033L, "Feest Group", "£" },
                    { new Guid("b2d468d4-09cc-66cb-b97b-f1db8fa4d1b5"), new DateTime(2026, 11, 3, 22, 56, 30, 822, DateTimeKind.Utc).AddTicks(3643), 6382.0100000000002, 85729L, "Runte, Bins and Leffler", "" },
                    { new Guid("b2e7039e-79fa-2fd2-1708-284a56c7d986"), new DateTime(2026, 11, 14, 21, 41, 41, 203, DateTimeKind.Utc).AddTicks(1052), 5167.5, 39914L, "Senger, Halvorson and Bechtelar", "₨" },
                    { new Guid("b3be81d2-312e-d121-5060-100fca6f6035"), new DateTime(2027, 2, 22, 12, 24, 34, 406, DateTimeKind.Utc).AddTicks(2104), 41.530000000000001, 24491L, "Feeney and Sons", "" },
                    { new Guid("b3c9270a-b7b2-5b73-313c-d2c6f73c4f3b"), new DateTime(2027, 5, 7, 3, 46, 26, 176, DateTimeKind.Utc).AddTicks(9230), 6515.1099999999997, 18703L, "Beer - Mosciski", "" },
                    { new Guid("b40edd54-761e-e416-1483-206eb7091070"), new DateTime(2027, 4, 16, 16, 31, 8, 574, DateTimeKind.Utc).AddTicks(6467), 7925.04, 92651L, "Sawayn, Mann and Cormier", "$" },
                    { new Guid("b4cce863-2535-caa9-f196-497a986bf2fb"), new DateTime(2027, 5, 28, 11, 7, 7, 545, DateTimeKind.Utc).AddTicks(453), 9206.8500000000004, 41300L, "Jaskolski LLC", "" },
                    { new Guid("b51f432a-719c-1d10-bb56-eba5488c8828"), new DateTime(2026, 8, 29, 19, 43, 24, 660, DateTimeKind.Utc).AddTicks(7744), 4959.9899999999998, 22758L, "Mann - Blanda", "₱" },
                    { new Guid("b54cfc9c-6543-a11a-d205-b4de6e7a8102"), new DateTime(2027, 7, 3, 4, 40, 4, 196, DateTimeKind.Utc).AddTicks(3473), 6728.6999999999998, 7608L, "Shanahan - Zemlak", "₡" },
                    { new Guid("b5520d45-3ba4-e090-f26d-e4a1a33a6319"), new DateTime(2026, 12, 3, 8, 39, 18, 101, DateTimeKind.Utc).AddTicks(654), 2976.3800000000001, 7551L, "Hermiston - Boyle", "" },
                    { new Guid("b59984f3-ebc6-7b2b-e28f-9e5f03904de0"), new DateTime(2026, 8, 21, 23, 53, 17, 871, DateTimeKind.Utc).AddTicks(9035), 9921.25, 15903L, "Ruecker, Christiansen and Hansen", "" },
                    { new Guid("b5ca90ca-2aaf-9653-6c30-15cff95cc9cb"), new DateTime(2026, 12, 9, 21, 46, 36, 379, DateTimeKind.Utc).AddTicks(8814), 8838.4500000000007, 53919L, "O'Reilly, Schuppe and Lemke", "៛" },
                    { new Guid("b5f01216-c9f5-0b23-3be8-cdf8f2292e0d"), new DateTime(2027, 7, 24, 18, 23, 5, 395, DateTimeKind.Utc).AddTicks(4851), 1675.79, 41953L, "Schroeder, Kling and Koepp", "" },
                    { new Guid("b6564d53-ae23-b71a-4a3d-52885305b89e"), new DateTime(2026, 12, 17, 8, 16, 35, 572, DateTimeKind.Utc).AddTicks(92), 1300.2, 45052L, "Schuster, Torp and West", "£" },
                    { new Guid("b6a4ebec-a09a-9c4c-ee83-44986dc9ac6f"), new DateTime(2026, 9, 30, 15, 3, 1, 698, DateTimeKind.Utc).AddTicks(9960), 4768.4799999999996, 63126L, "Wiegand - Wisoky", "KM" },
                    { new Guid("b707b8ea-3e37-cdb6-1938-980344d67439"), new DateTime(2027, 4, 26, 8, 16, 30, 808, DateTimeKind.Utc).AddTicks(8765), 1778.97, 76394L, "McGlynn LLC", "Дин." },
                    { new Guid("b7197908-5aa2-8e0e-bacf-6da04d587864"), new DateTime(2027, 1, 10, 8, 6, 38, 434, DateTimeKind.Utc).AddTicks(7002), 4672.96, 55887L, "Koch, Botsford and Bogisich", "Bs" },
                    { new Guid("b78b7e9c-6348-c538-ad8b-31bc5fa3c115"), new DateTime(2026, 12, 10, 16, 55, 54, 761, DateTimeKind.Utc).AddTicks(9206), 7223.1499999999996, 86282L, "Cormier Inc", "฿" },
                    { new Guid("b797cdd0-6481-e892-0fce-16d184d69896"), new DateTime(2027, 1, 1, 14, 16, 20, 572, DateTimeKind.Utc).AddTicks(346), 1425.21, 79878L, "White and Sons", "£" },
                    { new Guid("b7feb936-d6ea-8d8f-4374-4148f1f7d07d"), new DateTime(2026, 10, 24, 12, 40, 55, 32, DateTimeKind.Utc).AddTicks(3623), 9189.4400000000005, 32281L, "Hahn, Conn and Cassin", "₩" },
                    { new Guid("b89d7509-2447-2ecd-5c54-fc91cb8f2fb6"), new DateTime(2026, 11, 17, 12, 48, 17, 458, DateTimeKind.Utc).AddTicks(7909), 4454.6000000000004, 68169L, "Hudson - Streich", "TT$" },
                    { new Guid("b8ce5f3d-fcc7-59b7-6f82-8c85107d6626"), new DateTime(2026, 10, 30, 6, 6, 50, 926, DateTimeKind.Utc).AddTicks(8097), 5337.1700000000001, 83187L, "VonRueden, Stokes and Schuster", "" },
                    { new Guid("b8ed8d13-6759-a583-9631-9151aa91daa6"), new DateTime(2026, 11, 14, 10, 53, 38, 745, DateTimeKind.Utc).AddTicks(4868), 7292.0200000000004, 18608L, "Wiegand, Kuhn and Rempel", "¥" },
                    { new Guid("b957628e-0a8b-3d32-c38e-4388eed39f3b"), new DateTime(2027, 7, 6, 13, 21, 15, 156, DateTimeKind.Utc).AddTicks(5963), 4043.4499999999998, 26292L, "Romaguera - Osinski", "$" },
                    { new Guid("b98e7c74-8087-1018-e044-80ea1527eeee"), new DateTime(2026, 11, 22, 15, 36, 24, 573, DateTimeKind.Utc).AddTicks(149), 5562.5500000000002, 55999L, "Tillman Inc", "" },
                    { new Guid("b9a57623-eb9d-326e-cc09-8bf55b34c392"), new DateTime(2026, 8, 9, 14, 36, 12, 599, DateTimeKind.Utc).AddTicks(5755), 8558.3500000000004, 19690L, "Spinka - Conn", "฿" },
                    { new Guid("ba03bd93-951d-337f-8282-4e13cd7e42e4"), new DateTime(2026, 12, 2, 23, 50, 2, 230, DateTimeKind.Utc).AddTicks(1643), 9175.8799999999992, 71497L, "Brakus, Weimann and O'Keefe", "₦" },
                    { new Guid("ba5d6375-29ab-9f8b-1d3d-a28f80e51210"), new DateTime(2027, 2, 28, 9, 43, 32, 255, DateTimeKind.Utc).AddTicks(7016), 4380.1000000000004, 19467L, "Hamill - Weimann", "kr" },
                    { new Guid("ba88e06b-062f-54f5-cebc-37a9323f1e3a"), new DateTime(2026, 11, 11, 1, 50, 41, 460, DateTimeKind.Utc).AddTicks(1897), 9083.5300000000007, 25941L, "Wuckert - Dickens", "" },
                    { new Guid("badf96e3-79cf-0887-2d3b-43ce588e1522"), new DateTime(2027, 4, 8, 14, 28, 8, 499, DateTimeKind.Utc).AddTicks(1020), 3582.3000000000002, 74886L, "Jakubowski, Trantow and Wiegand", "$" },
                    { new Guid("bc125f8e-7a5a-22f1-046d-cbf656fb2af7"), new DateTime(2026, 10, 21, 9, 2, 41, 969, DateTimeKind.Utc).AddTicks(6313), 4379.9200000000001, 6851L, "Gutkowski LLC", "$U" },
                    { new Guid("bc9abc81-198b-7348-6a78-982ef45e959d"), new DateTime(2027, 6, 26, 12, 18, 16, 549, DateTimeKind.Utc).AddTicks(6194), 1954.8099999999999, 33636L, "Turcotte - Hammes", "" },
                    { new Guid("bcccd8bd-8e2d-f75b-0768-b6e4ca7315cd"), new DateTime(2026, 8, 9, 21, 22, 27, 8, DateTimeKind.Utc).AddTicks(8733), 4073.6100000000001, 94372L, "Hagenes Inc", "₩" },
                    { new Guid("bd0a99eb-d6f1-8d9d-60a3-eeb903e5b5c3"), new DateTime(2027, 4, 10, 19, 0, 18, 568, DateTimeKind.Utc).AddTicks(7727), 5802.25, 94997L, "Barrows - Lind", "¥" },
                    { new Guid("be045b17-8e16-8b05-33a2-0c967da7cdcc"), new DateTime(2027, 6, 24, 13, 36, 24, 806, DateTimeKind.Utc).AddTicks(7182), 9878.0400000000009, 10648L, "Keeling - Zieme", "$" },
                    { new Guid("be54d9b3-84b4-a428-619a-9a975fb76295"), new DateTime(2026, 8, 27, 14, 6, 28, 493, DateTimeKind.Utc).AddTicks(1837), 5487.6000000000004, 83414L, "Treutel - Kilback", "" },
                    { new Guid("be5fd2ee-072b-9f78-4bd1-ceea786f3fa3"), new DateTime(2026, 10, 26, 17, 22, 53, 57, DateTimeKind.Utc).AddTicks(7698), 4339.9200000000001, 44334L, "Senger, Hilpert and Crona", "$" },
                    { new Guid("bea41545-199f-ee66-33ad-30af6706c91c"), new DateTime(2026, 8, 29, 18, 50, 28, 740, DateTimeKind.Utc).AddTicks(3636), 2490.8299999999999, 6129L, "Cummerata, Wolf and Mosciski", "лв" },
                    { new Guid("bf40ad51-7aa1-77a6-c1c4-24b06ddee749"), new DateTime(2026, 9, 22, 8, 21, 51, 0, DateTimeKind.Utc).AddTicks(5141), 4683.1300000000001, 17075L, "Sawayn - Hansen", "" },
                    { new Guid("bf44f053-8b66-0eab-729f-c929853cc4cc"), new DateTime(2026, 10, 29, 17, 4, 9, 268, DateTimeKind.Utc).AddTicks(3396), 1952.54, 34546L, "Borer - Dickinson", "" },
                    { new Guid("bf4cdcd4-a09d-921b-d4f1-4a29f0ec1c8d"), new DateTime(2026, 11, 27, 4, 16, 54, 797, DateTimeKind.Utc).AddTicks(9538), 3184.1599999999999, 16914L, "Orn, Tromp and O'Connell", "лв" },
                    { new Guid("bf56eedd-08dd-666a-0bdb-0bc92179053f"), new DateTime(2026, 12, 5, 14, 7, 43, 444, DateTimeKind.Utc).AddTicks(2141), 247.16999999999999, 78392L, "Mosciski Group", "$" },
                    { new Guid("bf9c65d6-1f3b-a75e-cdcb-735230985774"), new DateTime(2027, 7, 27, 22, 58, 38, 827, DateTimeKind.Utc).AddTicks(1955), 5119.6400000000003, 32162L, "Franecki and Sons", "$" },
                    { new Guid("bfe4a807-1263-c19c-8093-ca2c2ebb1272"), new DateTime(2026, 8, 21, 9, 9, 50, 42, DateTimeKind.Utc).AddTicks(1721), 3692.8699999999999, 13336L, "Moen, Bahringer and Nicolas", "$" },
                    { new Guid("c0142db2-2fbf-b676-4351-0e3a0f218b26"), new DateTime(2026, 10, 2, 11, 22, 48, 834, DateTimeKind.Utc).AddTicks(6777), 4079.1900000000001, 33089L, "Champlin, Osinski and Cassin", "" },
                    { new Guid("c01f7dbd-5948-46d9-454f-9f9dbc45871c"), new DateTime(2027, 4, 6, 2, 47, 1, 660, DateTimeKind.Utc).AddTicks(9008), 266.64999999999998, 81503L, "Schneider, Herzog and Kohler", "Gs" },
                    { new Guid("c06b6366-97ed-3dd5-794a-ead7ef722f1c"), new DateTime(2027, 3, 3, 16, 48, 27, 514, DateTimeKind.Utc).AddTicks(6171), 9929.5300000000007, 33049L, "Wiza, Barton and Nader", "лв" },
                    { new Guid("c0bb3609-3df3-3191-7294-237499a27d76"), new DateTime(2026, 11, 1, 14, 47, 27, 826, DateTimeKind.Utc).AddTicks(8565), 6230.4200000000001, 85440L, "Strosin and Sons", "Q" },
                    { new Guid("c11277f0-f632-e8b0-aec7-a28d7866d625"), new DateTime(2027, 6, 8, 18, 2, 3, 121, DateTimeKind.Utc).AddTicks(6851), 3047.48, 43310L, "McGlynn Group", "" },
                    { new Guid("c11a60fd-d228-74ea-c7a6-b53152361183"), new DateTime(2026, 8, 28, 6, 54, 34, 707, DateTimeKind.Utc).AddTicks(7815), 8813.3700000000008, 92146L, "Cummerata, Pfeffer and O'Hara", "¥" },
                    { new Guid("c12c9a3c-ba04-e561-7c26-9f09f3ae2faf"), new DateTime(2026, 9, 4, 14, 31, 50, 610, DateTimeKind.Utc).AddTicks(5938), 2247.0900000000001, 24933L, "Grady LLC", "₱" },
                    { new Guid("c1337a53-1979-92ff-f15d-09d04ce35a50"), new DateTime(2027, 4, 18, 16, 15, 13, 328, DateTimeKind.Utc).AddTicks(5841), 9903.7800000000007, 99397L, "Johnson - Simonis", "" },
                    { new Guid("c158e0ab-8871-d3df-da5f-f4175b8ac37c"), new DateTime(2027, 4, 26, 14, 48, 9, 537, DateTimeKind.Utc).AddTicks(204), 4806.2600000000002, 79916L, "Stracke, Abshire and Ebert", "Nu" },
                    { new Guid("c16fe096-b375-08f2-2ce4-8001499feb5c"), new DateTime(2027, 2, 6, 14, 57, 33, 755, DateTimeKind.Utc).AddTicks(9605), 432.45999999999998, 78300L, "Carroll Group", "" },
                    { new Guid("c1e036b2-103d-65a3-d4a3-5413cec4e962"), new DateTime(2027, 6, 23, 13, 19, 28, 96, DateTimeKind.Utc).AddTicks(3320), 7324.3199999999997, 58684L, "Hilpert Inc", "$" },
                    { new Guid("c20ee007-cadf-416b-c159-363db030879f"), new DateTime(2026, 11, 18, 19, 19, 48, 575, DateTimeKind.Utc).AddTicks(3865), 4591.0500000000002, 87713L, "Block, O'Conner and Mraz", "" },
                    { new Guid("c2dce34f-6783-2e16-706e-13c72f136ec4"), new DateTime(2027, 4, 8, 22, 15, 18, 465, DateTimeKind.Utc).AddTicks(5989), 498.22000000000003, 30686L, "Brakus - Kunde", "kr" },
                    { new Guid("c3120a27-1102-9b08-08c3-85745e7f4266"), new DateTime(2027, 2, 1, 22, 2, 43, 707, DateTimeKind.Utc).AddTicks(9790), 3917.29, 85748L, "O'Reilly Group", "" },
                    { new Guid("c37ec008-9405-8692-5dff-a74dceacf36c"), new DateTime(2027, 6, 28, 6, 14, 56, 774, DateTimeKind.Utc).AddTicks(488), 4356.3199999999997, 9079L, "Luettgen Group", "лв" },
                    { new Guid("c3908c7f-9007-e260-f5e4-784abf6ab33a"), new DateTime(2026, 9, 10, 4, 16, 26, 40, DateTimeKind.Utc).AddTicks(9551), 5589.2399999999998, 63460L, "Roberts LLC", "¥" },
                    { new Guid("c390e853-d00f-0517-db64-5a7433dde85d"), new DateTime(2026, 11, 22, 12, 25, 14, 119, DateTimeKind.Utc).AddTicks(7021), 5562.5699999999997, 9887L, "Herzog Group", "" },
                    { new Guid("c3950b2f-6e9b-412a-d6a9-3630d0a8be9f"), new DateTime(2026, 10, 20, 19, 13, 39, 398, DateTimeKind.Utc).AddTicks(4193), 1055.49, 99687L, "Metz - McCullough", "" },
                    { new Guid("c3a8cadf-0541-3cd1-2c82-37eb8e159619"), new DateTime(2027, 1, 5, 2, 52, 58, 653, DateTimeKind.Utc).AddTicks(6863), 2354.9400000000001, 56507L, "Hodkiewicz Inc", "kr" },
                    { new Guid("c3d6fdf0-abb0-527e-f2c0-2ddcb8fb4561"), new DateTime(2027, 4, 25, 1, 53, 55, 273, DateTimeKind.Utc).AddTicks(4052), 5117.8699999999999, 59521L, "Raynor - Boehm", "Kč" },
                    { new Guid("c4022493-6cd4-7969-c93e-f5090bc41f92"), new DateTime(2026, 11, 13, 7, 13, 53, 384, DateTimeKind.Utc).AddTicks(247), 7636.04, 4980L, "Schaden and Sons", "" },
                    { new Guid("c40e6030-4ee5-feeb-0eea-ec6e7e2975fc"), new DateTime(2027, 6, 13, 16, 34, 24, 681, DateTimeKind.Utc).AddTicks(4508), 3837.1399999999999, 68755L, "Labadie - O'Conner", "R$" },
                    { new Guid("c43e7607-3828-80ce-7d53-1fcb581c5d4b"), new DateTime(2027, 3, 10, 20, 51, 2, 986, DateTimeKind.Utc).AddTicks(752), 6171.8999999999996, 37400L, "Lueilwitz, Gusikowski and Doyle", "Ft" },
                    { new Guid("c48175a6-5bda-2a1b-9d76-ffb3dbfd9cc0"), new DateTime(2027, 2, 17, 10, 2, 30, 812, DateTimeKind.Utc).AddTicks(3423), 8257.1299999999992, 68645L, "Collins - Schiller", "₫" },
                    { new Guid("c4bae977-7045-0d0c-5516-66e75801c5e4"), new DateTime(2026, 12, 30, 4, 58, 50, 389, DateTimeKind.Utc).AddTicks(2995), 3904.3299999999999, 32220L, "Lesch - Breitenberg", "" },
                    { new Guid("c535b7ad-4210-99bd-4a70-c53008d4fceb"), new DateTime(2027, 2, 3, 2, 57, 10, 373, DateTimeKind.Utc).AddTicks(3637), 4393.0900000000001, 78399L, "Johnston, Keeling and Gottlieb", "₨" },
                    { new Guid("c5a8c007-51a2-1cdc-772a-c5c0b0f97804"), new DateTime(2027, 2, 17, 16, 4, 56, 662, DateTimeKind.Utc).AddTicks(9550), 2115.1999999999998, 41436L, "Harris, O'Connell and Hahn", "CHF" },
                    { new Guid("c5cf4326-81b9-795d-2b0d-8c64d5ae3892"), new DateTime(2027, 1, 13, 4, 15, 44, 935, DateTimeKind.Utc).AddTicks(2008), 7611.6599999999999, 80931L, "Skiles Group", "" },
                    { new Guid("c5d8abe5-baac-61f6-211b-47e97506fd82"), new DateTime(2027, 7, 14, 7, 10, 15, 287, DateTimeKind.Utc).AddTicks(4098), 886.0, 24193L, "Wilderman, Ritchie and Pfeffer", "₪" },
                    { new Guid("c6082b78-6f88-a497-c36a-ba74df504ed9"), new DateTime(2027, 4, 17, 9, 14, 32, 978, DateTimeKind.Utc).AddTicks(837), 8729.2900000000009, 44586L, "Luettgen - Pacocha", "$" },
                    { new Guid("c629eeb6-3a0c-eff3-c3d5-a8646822c33f"), new DateTime(2026, 11, 18, 20, 36, 42, 746, DateTimeKind.Utc).AddTicks(7560), 2595.6300000000001, 90497L, "Daniel and Sons", "R" },
                    { new Guid("c6597162-3c3d-7981-06e7-f1f32c877f34"), new DateTime(2027, 1, 16, 15, 7, 44, 988, DateTimeKind.Utc).AddTicks(8743), 6683.8599999999997, 73112L, "Welch - Heidenreich", "" },
                    { new Guid("c6649fbf-db01-e2db-a1e9-df1429365974"), new DateTime(2026, 8, 13, 14, 43, 8, 803, DateTimeKind.Utc).AddTicks(375), 4404.8599999999997, 2125L, "Schmitt - McCullough", "" },
                    { new Guid("c7089866-e055-1a08-1742-4207d1b369aa"), new DateTime(2027, 3, 29, 13, 23, 19, 735, DateTimeKind.Utc).AddTicks(792), 2590.7800000000002, 72038L, "Rempel - O'Connell", "kr" },
                    { new Guid("c76a76ff-a34d-7114-32a2-399813cf07d2"), new DateTime(2027, 7, 4, 17, 27, 8, 909, DateTimeKind.Utc).AddTicks(4681), 9031.75, 88622L, "Ernser - Torphy", "" },
                    { new Guid("c829c5c7-5b17-7009-e0cd-d857964e291b"), new DateTime(2027, 5, 18, 14, 38, 22, 460, DateTimeKind.Utc).AddTicks(989), 7086.5500000000002, 19501L, "Moore - Macejkovic", "" },
                    { new Guid("c856afaa-55f3-41b7-8026-563ea9904e58"), new DateTime(2026, 8, 25, 18, 29, 37, 963, DateTimeKind.Utc).AddTicks(2306), 2944.98, 37534L, "Paucek - Crona", "C$" },
                    { new Guid("c86ed461-37c5-4f72-bf9b-baf99b44a49a"), new DateTime(2026, 11, 1, 10, 33, 22, 74, DateTimeKind.Utc).AddTicks(1713), 5843.0200000000004, 68395L, "Beer, DuBuque and Kertzmann", "лв" },
                    { new Guid("c8d0da2c-8c88-0d81-1e5e-20d5ce4fde6e"), new DateTime(2027, 7, 28, 15, 6, 23, 771, DateTimeKind.Utc).AddTicks(6570), 7045.5, 57414L, "Bergnaum, Aufderhar and Schumm", "" },
                    { new Guid("c916fef0-d5f9-35a9-a1b6-0f86b8eb234b"), new DateTime(2027, 7, 11, 22, 6, 26, 3, DateTimeKind.Utc).AddTicks(3666), 587.13, 7530L, "Stiedemann - Predovic", "NT$" },
                    { new Guid("c93b2b6f-6b0f-58db-3df1-abc132f5a32c"), new DateTime(2026, 11, 7, 17, 21, 7, 983, DateTimeKind.Utc).AddTicks(2774), 1723.8299999999999, 87263L, "Ledner Group", "$" },
                    { new Guid("c970d0f4-83c9-2792-fb7d-9cf20605fc97"), new DateTime(2026, 12, 15, 14, 3, 5, 182, DateTimeKind.Utc).AddTicks(2212), 4626.8400000000001, 12103L, "Lehner and Sons", "" },
                    { new Guid("c9a3ea67-9717-7cc9-6fd9-bc288b4a7a15"), new DateTime(2026, 10, 27, 15, 6, 31, 331, DateTimeKind.Utc).AddTicks(6791), 4536.4200000000001, 30109L, "Rath LLC", "" },
                    { new Guid("c9c92c3b-2bc9-894e-9b9f-a26dfac9f31c"), new DateTime(2027, 2, 9, 19, 3, 38, 23, DateTimeKind.Utc).AddTicks(4408), 6112.1499999999996, 48443L, "Labadie - Jerde", "$" },
                    { new Guid("c9de2eb5-2e78-46dc-8fe3-30cc17bf36e1"), new DateTime(2027, 4, 10, 7, 53, 54, 314, DateTimeKind.Utc).AddTicks(6317), 4817.1099999999997, 18302L, "Kunde, Von and Harris", "" },
                    { new Guid("ca56c4e9-fade-abff-77cd-11a343720dc3"), new DateTime(2027, 6, 27, 7, 13, 22, 74, DateTimeKind.Utc).AddTicks(2277), 9133.8799999999992, 96976L, "Kozey - Streich", "R$" },
                    { new Guid("ca593015-963f-ce54-764c-b988a893e389"), new DateTime(2026, 9, 27, 11, 1, 4, 620, DateTimeKind.Utc).AddTicks(2318), 1629.5899999999999, 6846L, "Wisozk - Kunde", "₴" },
                    { new Guid("ca62bc5c-accb-eaad-aafe-5c3b544c936d"), new DateTime(2027, 4, 28, 19, 18, 30, 45, DateTimeKind.Utc).AddTicks(62), 3770.5100000000002, 39039L, "Johns, Kiehn and Conroy", "$" },
                    { new Guid("ca68c95e-2670-913b-ed66-6b02bfd1c275"), new DateTime(2027, 2, 20, 11, 18, 39, 472, DateTimeKind.Utc).AddTicks(3741), 1202.95, 56928L, "Balistreri, Bashirian and Murphy", "$" },
                    { new Guid("ca9a01c2-8bfe-0e4d-a217-759dbc115f6a"), new DateTime(2027, 6, 2, 5, 55, 4, 704, DateTimeKind.Utc).AddTicks(6121), 2580.2399999999998, 2004L, "Labadie - Brekke", "₹" },
                    { new Guid("cae76c55-6243-935e-9cc1-587273a27d12"), new DateTime(2026, 11, 11, 21, 29, 49, 782, DateTimeKind.Utc).AddTicks(6287), 654.24000000000001, 16402L, "Mosciski Inc", "$" },
                    { new Guid("cb6a151e-23d3-e626-6911-e053a4d8b093"), new DateTime(2026, 12, 16, 10, 46, 34, 235, DateTimeKind.Utc).AddTicks(3085), 8396.1000000000004, 26201L, "Daugherty, Marvin and Tromp", "Lt" },
                    { new Guid("cbe22206-8099-2244-873b-e8b3c4938a2d"), new DateTime(2027, 7, 27, 15, 17, 38, 345, DateTimeKind.Utc).AddTicks(7899), 4608.2700000000004, 80158L, "Fahey, Gutkowski and Zulauf", "" },
                    { new Guid("cbec50f8-dc08-9a47-0381-9e815c5a544a"), new DateTime(2027, 4, 14, 19, 25, 51, 712, DateTimeKind.Utc).AddTicks(5804), 8916.5300000000007, 67835L, "Mante - Stokes", "" },
                    { new Guid("cc0f8587-2e62-7534-96b9-79ca69c1b17d"), new DateTime(2027, 7, 22, 15, 5, 50, 926, DateTimeKind.Utc).AddTicks(4504), 1472.1700000000001, 87498L, "Metz Inc", "" },
                    { new Guid("cc1259f6-d1ca-2fd8-5371-6495d21d50aa"), new DateTime(2026, 11, 3, 2, 40, 43, 837, DateTimeKind.Utc).AddTicks(1890), 8297.8899999999994, 87878L, "Goldner LLC", "₺" },
                    { new Guid("cc4274fb-a52b-e881-da06-6ec570d3d2a1"), new DateTime(2026, 8, 14, 0, 22, 46, 646, DateTimeKind.Utc).AddTicks(2907), 9373.5100000000002, 89054L, "Considine, White and Moore", "" },
                    { new Guid("cc90471a-c16b-6352-aca1-6fbb4e35fa3a"), new DateTime(2026, 8, 14, 3, 38, 30, 491, DateTimeKind.Utc).AddTicks(3855), 7999.4399999999996, 75213L, "Fahey, Dooley and Gleichner", "$U" },
                    { new Guid("ccf0300a-f2be-635b-34f6-c1e79490e6f0"), new DateTime(2027, 1, 22, 13, 21, 7, 765, DateTimeKind.Utc).AddTicks(5481), 5933.0, 9275L, "Murphy Group", "лв" },
                    { new Guid("cd1a2e2c-9b6f-ec87-4850-dcee8908d8e4"), new DateTime(2027, 2, 27, 9, 11, 8, 862, DateTimeKind.Utc).AddTicks(7782), 6730.3699999999999, 27313L, "Stehr, Quigley and Welch", "Php" },
                    { new Guid("cd3238fc-2875-999b-2a50-40ee01e8d698"), new DateTime(2027, 3, 25, 7, 31, 1, 793, DateTimeKind.Utc).AddTicks(5338), 7061.25, 11405L, "Feil Inc", "" },
                    { new Guid("cdb81f89-d36c-be96-e646-34d8bb589c10"), new DateTime(2026, 9, 9, 2, 35, 49, 640, DateTimeKind.Utc).AddTicks(28), 5209.2399999999998, 45887L, "Sipes, Kulas and Morissette", "£" },
                    { new Guid("cdc42e04-d7ff-2c47-042b-18ba00e0171a"), new DateTime(2026, 11, 11, 16, 22, 46, 153, DateTimeKind.Utc).AddTicks(7397), 1879.6700000000001, 16770L, "Kirlin - Schinner", "$" },
                    { new Guid("ce0bf6e2-a854-4916-07de-e74728885be5"), new DateTime(2027, 7, 2, 2, 42, 14, 215, DateTimeKind.Utc).AddTicks(5464), 633.75999999999999, 83317L, "Hauck - Kilback", "" },
                    { new Guid("ce0e9b06-eb37-1178-8596-82c548f5db06"), new DateTime(2027, 5, 23, 12, 45, 45, 41, DateTimeKind.Utc).AddTicks(548), 1675.0999999999999, 11794L, "Olson - Gorczany", "" },
                    { new Guid("ceaac73c-9deb-75f6-85dd-57e62d10f0d3"), new DateTime(2027, 2, 1, 11, 51, 36, 140, DateTimeKind.Utc).AddTicks(3552), 13.66, 83118L, "Predovic, Strosin and Fay", "" },
                    { new Guid("cef42975-6d5a-f8b2-5b9d-ee791d1ed82f"), new DateTime(2026, 12, 23, 8, 19, 45, 395, DateTimeKind.Utc).AddTicks(2741), 1386.1800000000001, 38897L, "Gibson, Roberts and Labadie", "$" },
                    { new Guid("cf54278d-2ad4-bd93-9351-7082f724fc6c"), new DateTime(2027, 3, 23, 8, 10, 3, 43, DateTimeKind.Utc).AddTicks(776), 6935.8699999999999, 71496L, "Ruecker - Lockman", "" },
                    { new Guid("cf6cd49b-29fd-2808-a257-fe13e05471af"), new DateTime(2026, 12, 3, 0, 53, 25, 965, DateTimeKind.Utc).AddTicks(6496), 1001.84, 25679L, "Cormier Group", "₨" },
                    { new Guid("cf9cde0a-e06b-c593-9c5d-28f504610b31"), new DateTime(2027, 3, 7, 14, 14, 10, 343, DateTimeKind.Utc).AddTicks(7209), 3784.5900000000001, 64927L, "Mills - Prosacco", "" },
                    { new Guid("cfe16c2d-9d81-e132-4d45-097b7a22ab57"), new DateTime(2027, 3, 9, 17, 40, 49, 620, DateTimeKind.Utc).AddTicks(5208), 441.38, 19399L, "Dach Group", "$" },
                    { new Guid("d03a9926-7072-c892-db21-16ce62d57a42"), new DateTime(2027, 3, 30, 8, 34, 8, 411, DateTimeKind.Utc).AddTicks(202), 6583.5699999999997, 65341L, "Maggio, Witting and Erdman", "B/." },
                    { new Guid("d0cbeb93-ad86-ba04-3abd-4a3372ca6d95"), new DateTime(2027, 7, 5, 2, 36, 23, 116, DateTimeKind.Utc).AddTicks(6157), 4304.1999999999998, 54082L, "Rogahn Group", "៛" },
                    { new Guid("d1ce431c-f675-6a00-dc05-fc0b61f58cfc"), new DateTime(2026, 12, 6, 5, 1, 16, 346, DateTimeKind.Utc).AddTicks(7620), 1669.21, 64704L, "Jaskolski - Conroy", "﷼" },
                    { new Guid("d1e448dd-7100-95cb-3f4c-3af1d0393c83"), new DateTime(2026, 9, 26, 1, 32, 0, 436, DateTimeKind.Utc).AddTicks(918), 7881.3699999999999, 59320L, "Goyette, Hayes and Bins", "$" },
                    { new Guid("d1e86d8b-d1f8-3fc8-aa71-a2b2a7370b71"), new DateTime(2027, 5, 29, 21, 25, 16, 55, DateTimeKind.Utc).AddTicks(6690), 7292.1999999999998, 80802L, "Ebert - Bechtelar", "" },
                    { new Guid("d23af4ca-f88e-6a08-6b9f-957b13d52e6b"), new DateTime(2027, 2, 14, 15, 35, 6, 838, DateTimeKind.Utc).AddTicks(4590), 3159.2399999999998, 11164L, "Dach - Halvorson", "Дин." },
                    { new Guid("d24d60d9-ad46-2d75-f455-bd8637197906"), new DateTime(2027, 6, 14, 15, 28, 56, 82, DateTimeKind.Utc).AddTicks(4305), 6283.1800000000003, 56901L, "Wunsch - Gerlach", "£" },
                    { new Guid("d26e278d-a367-3e07-fab9-a98fe8e12875"), new DateTime(2027, 1, 7, 19, 56, 26, 361, DateTimeKind.Utc).AddTicks(9509), 3875.27, 8574L, "West, Koepp and Russel", "₺" },
                    { new Guid("d273413f-c3bb-2e76-2163-1ffaa868563f"), new DateTime(2027, 2, 20, 7, 24, 35, 952, DateTimeKind.Utc).AddTicks(4398), 6938.1899999999996, 81298L, "Predovic, Fahey and Hahn", "Gs" },
                    { new Guid("d2d1da89-b345-3f90-fab7-76f4fc438cd9"), new DateTime(2027, 1, 25, 9, 37, 12, 851, DateTimeKind.Utc).AddTicks(5989), 9312.6900000000005, 54325L, "Dibbert Group", "" },
                    { new Guid("d2ea7a62-46a9-f9b7-fc17-f691d3728e8f"), new DateTime(2027, 5, 19, 9, 23, 43, 978, DateTimeKind.Utc).AddTicks(2524), 3480.46, 49963L, "Barrows, Zemlak and Hessel", "B/." },
                    { new Guid("d36638e2-92b6-e91f-742f-a6c6c3d820a4"), new DateTime(2026, 8, 15, 23, 52, 34, 183, DateTimeKind.Utc).AddTicks(5067), 491.75, 52277L, "Hammes Inc", "" },
                    { new Guid("d3e20338-4a75-8e8e-3775-161c8db50c11"), new DateTime(2027, 7, 25, 1, 35, 9, 466, DateTimeKind.Utc).AddTicks(6365), 5387.4399999999996, 56452L, "Padberg, Barrows and Nienow", "" },
                    { new Guid("d436994f-f277-8a83-6756-6a5fc56897d4"), new DateTime(2027, 6, 25, 1, 3, 42, 415, DateTimeKind.Utc).AddTicks(7777), 4059.8000000000002, 80961L, "Stanton Inc", "" },
                    { new Guid("d4562987-2dc2-fdfa-3532-6003a215ecba"), new DateTime(2027, 3, 1, 7, 38, 0, 542, DateTimeKind.Utc).AddTicks(7650), 3690.1799999999998, 39325L, "Kuvalis - Reilly", "RD$" },
                    { new Guid("d45ec2d1-d6a0-efff-91bb-d6230b7ecbf7"), new DateTime(2026, 10, 30, 4, 28, 21, 631, DateTimeKind.Utc).AddTicks(8348), 3273.3699999999999, 29506L, "Pfeffer Group", "₴" },
                    { new Guid("d48bba46-3eba-65ff-58bf-5de637441191"), new DateTime(2026, 8, 8, 12, 46, 1, 417, DateTimeKind.Utc).AddTicks(6425), 2583.6999999999998, 36936L, "Spinka - Cassin", "ден" },
                    { new Guid("d50ba42f-02b8-50d1-4320-0ec8d6af89ab"), new DateTime(2026, 12, 24, 7, 33, 52, 281, DateTimeKind.Utc).AddTicks(4681), 291.83999999999997, 85931L, "Mills Group", "Lek" },
                    { new Guid("d600e6ed-2696-a0e1-a6de-1417581be8aa"), new DateTime(2027, 5, 18, 15, 28, 1, 931, DateTimeKind.Utc).AddTicks(6574), 6595.9700000000003, 12653L, "Zemlak, Swift and Mueller", "" },
                    { new Guid("d616d11c-b908-3785-26c4-5519c6292358"), new DateTime(2026, 9, 14, 10, 33, 37, 322, DateTimeKind.Utc).AddTicks(5287), 9716.9500000000007, 36559L, "Dare, Corkery and Hartmann", "NT$" },
                    { new Guid("d61ff7da-f2e6-3114-8af3-c57d95bfb26e"), new DateTime(2026, 11, 12, 3, 52, 38, 386, DateTimeKind.Utc).AddTicks(2537), 5477.0, 66841L, "Schulist Group", "$" },
                    { new Guid("d6546b73-2775-b0ae-9896-6e5c598d255f"), new DateTime(2027, 3, 3, 2, 9, 46, 251, DateTimeKind.Utc).AddTicks(5948), 9725.5400000000009, 73077L, "Pouros, Brekke and Wyman", "$U" },
                    { new Guid("d65ec07c-a945-5fdb-4aae-4c77baa5ce78"), new DateTime(2026, 9, 28, 20, 29, 52, 258, DateTimeKind.Utc).AddTicks(3684), 7909.8400000000001, 17683L, "Goodwin - Walsh", "" },
                    { new Guid("d6ea717d-f0c3-ab69-807f-07deba560e18"), new DateTime(2027, 1, 17, 16, 38, 18, 93, DateTimeKind.Utc).AddTicks(9987), 9923.1100000000006, 42759L, "Robel - Klocko", "$" },
                    { new Guid("d70f9b50-adb8-427f-e933-44776a465e80"), new DateTime(2026, 12, 22, 7, 36, 10, 874, DateTimeKind.Utc).AddTicks(9647), 7537.6099999999997, 72673L, "Steuber, Bernier and Rodriguez", "Rp" },
                    { new Guid("d7bd3aa6-9f87-0a5c-4ad0-1ebf8a1534c3"), new DateTime(2027, 1, 23, 2, 5, 57, 688, DateTimeKind.Utc).AddTicks(2769), 9862.5799999999999, 80568L, "Tromp - Zulauf", "Db" },
                    { new Guid("d7c03a6f-f143-547d-b16e-06cdfb33d7a0"), new DateTime(2026, 12, 20, 6, 49, 46, 797, DateTimeKind.Utc).AddTicks(351), 4686.6099999999997, 93589L, "Botsford - Marvin", "$" },
                    { new Guid("d874ee8c-6c8f-84ef-3922-6edc6de8200d"), new DateTime(2027, 7, 3, 6, 36, 7, 834, DateTimeKind.Utc).AddTicks(7572), 43.210000000000001, 70584L, "Prohaska, Little and Collins", "" },
                    { new Guid("d8ea1f1d-516c-a83d-9941-b7c2cc26318f"), new DateTime(2027, 7, 5, 2, 13, 34, 686, DateTimeKind.Utc).AddTicks(3886), 8029.5600000000004, 12539L, "Sipes and Sons", "₺" },
                    { new Guid("d923e682-84bf-1ff1-c2f2-5087b4b0f577"), new DateTime(2027, 4, 17, 8, 58, 38, 240, DateTimeKind.Utc).AddTicks(3493), 8066.8999999999996, 34665L, "Hoeger and Sons", "$" },
                    { new Guid("d95eb8a9-1d56-dd86-88ba-4988a24099eb"), new DateTime(2026, 9, 17, 16, 19, 9, 358, DateTimeKind.Utc).AddTicks(8167), 747.71000000000004, 33262L, "Herzog Group", "" },
                    { new Guid("d97476d6-5243-b4f7-9107-7a61ed9348fd"), new DateTime(2026, 8, 13, 14, 18, 26, 651, DateTimeKind.Utc).AddTicks(1585), 365.45999999999998, 83370L, "Denesik and Sons", "S" },
                    { new Guid("d9870d13-8576-60e8-36a1-ea4c378efd5f"), new DateTime(2027, 7, 15, 10, 39, 57, 158, DateTimeKind.Utc).AddTicks(9239), 5477.8400000000001, 44599L, "Sanford LLC", "Nu" },
                    { new Guid("d98e9ad8-b87c-9139-2d29-d9ee08b33112"), new DateTime(2026, 8, 13, 22, 56, 28, 927, DateTimeKind.Utc).AddTicks(4121), 967.75999999999999, 6517L, "Hagenes - Stark", "₨" },
                    { new Guid("da354d7e-af47-d30f-e6aa-7c0ad9e7ecc4"), new DateTime(2027, 1, 16, 7, 6, 22, 569, DateTimeKind.Utc).AddTicks(5287), 4282.5299999999997, 79643L, "Williamson, Wunsch and Ziemann", "" },
                    { new Guid("db036217-b2ca-a2a5-9cdb-faaf55f0bc9b"), new DateTime(2027, 1, 4, 23, 59, 3, 202, DateTimeKind.Utc).AddTicks(6925), 6359.1199999999999, 30110L, "Cartwright Inc", "$" },
                    { new Guid("db91c2de-b6e8-5c71-506d-3c67b653f0ab"), new DateTime(2027, 7, 23, 11, 37, 9, 77, DateTimeKind.Utc).AddTicks(148), 3482.46, 38350L, "Kohler, Powlowski and Sipes", "kr" },
                    { new Guid("dbb96db6-6180-3e1c-811a-b4c247b5bd54"), new DateTime(2026, 8, 7, 16, 57, 47, 557, DateTimeKind.Utc).AddTicks(2909), 6267.75, 65168L, "Hessel Group", "£" },
                    { new Guid("dc8472dc-1b46-a6ae-33dc-f395933b6142"), new DateTime(2027, 6, 9, 16, 15, 2, 508, DateTimeKind.Utc).AddTicks(1624), 9328.4799999999996, 16999L, "Lind - Ritchie", "" },
                    { new Guid("dcbbf088-997a-dd24-15fd-a1368e220127"), new DateTime(2026, 10, 1, 6, 58, 17, 121, DateTimeKind.Utc).AddTicks(3169), 5946.2700000000004, 35590L, "Bechtelar - Oberbrunner", "" },
                    { new Guid("dcbf2d34-459b-65c1-4872-4da94fa4d8aa"), new DateTime(2026, 8, 11, 21, 19, 9, 871, DateTimeKind.Utc).AddTicks(5870), 2643.6199999999999, 89632L, "Kuhic, Brekke and Cremin", "฿" },
                    { new Guid("dcf3576f-fb06-4c27-126f-d44e017ead05"), new DateTime(2026, 12, 13, 13, 19, 28, 811, DateTimeKind.Utc).AddTicks(7580), 3384.46, 96475L, "Kshlerin Inc", "CHF" },
                    { new Guid("dcf3b86e-16bf-93ee-ee61-a21f5c05454e"), new DateTime(2027, 5, 25, 23, 56, 3, 818, DateTimeKind.Utc).AddTicks(1797), 7759.5100000000002, 9797L, "Block - Schimmel", "₺" },
                    { new Guid("dd297e47-b107-da4b-425a-f5d86616f179"), new DateTime(2026, 11, 29, 1, 10, 20, 930, DateTimeKind.Utc).AddTicks(9852), 8707.0200000000004, 84243L, "O'Connell, Gleason and Boyer", "ƒ" },
                    { new Guid("ddb778f8-8a73-1ce8-cd64-44b72d5cad62"), new DateTime(2027, 5, 15, 16, 49, 4, 822, DateTimeKind.Utc).AddTicks(7755), 5259.4899999999998, 98373L, "Walsh and Sons", "Php" },
                    { new Guid("ddc0e12c-3792-f22a-23b7-c596ac69fd33"), new DateTime(2027, 2, 13, 14, 28, 31, 633, DateTimeKind.Utc).AddTicks(1775), 8667.8799999999992, 27156L, "Anderson, Bins and Stokes", "" },
                    { new Guid("dde17823-10b2-97df-70c1-77ad349968fd"), new DateTime(2026, 12, 24, 20, 49, 38, 280, DateTimeKind.Utc).AddTicks(9268), 4042.8400000000001, 44073L, "Powlowski - Bartell", "R" },
                    { new Guid("ddeb5ca9-943b-3f87-c1ae-7477f6fd5ba9"), new DateTime(2027, 4, 4, 0, 18, 55, 755, DateTimeKind.Utc).AddTicks(2308), 519.16999999999996, 60623L, "Leuschke, Kuvalis and Barton", "MT" },
                    { new Guid("ddff7e7a-73b6-1df4-3451-4102876b72b0"), new DateTime(2027, 7, 25, 7, 19, 50, 701, DateTimeKind.Utc).AddTicks(7512), 8098.8100000000004, 69324L, "Beier, McDermott and Veum", "€" },
                    { new Guid("de4e927e-b801-cb67-e7a9-c3f45bcc783c"), new DateTime(2027, 5, 25, 21, 38, 47, 183, DateTimeKind.Utc).AddTicks(334), 2103.5, 23911L, "Pacocha LLC", "" },
                    { new Guid("de58ad66-ee89-8f70-5fa9-1a3e2ea92e52"), new DateTime(2027, 5, 11, 4, 42, 40, 817, DateTimeKind.Utc).AddTicks(4989), 639.58000000000004, 41970L, "Schamberger, Dicki and Corwin", "" },
                    { new Guid("de5c9f67-3e29-f68d-5ece-5800ad89c49b"), new DateTime(2027, 4, 25, 1, 50, 13, 15, DateTimeKind.Utc).AddTicks(5828), 6386.6300000000001, 63517L, "Watsica, O'Conner and O'Connell", "" },
                    { new Guid("de7c0d94-40cb-62a3-a23f-ed001c9dc325"), new DateTime(2027, 4, 5, 14, 18, 40, 591, DateTimeKind.Utc).AddTicks(9165), 2782.9400000000001, 27597L, "Muller Group", "Kč" },
                    { new Guid("dea5c050-eb25-98f1-a53b-9d8c3b29d635"), new DateTime(2027, 3, 28, 21, 28, 30, 536, DateTimeKind.Utc).AddTicks(7326), 1886.0599999999999, 84843L, "Wunsch, Wyman and Reichert", "₫" },
                    { new Guid("deb23de1-d180-b885-8e24-d193377eea8d"), new DateTime(2027, 5, 26, 14, 4, 51, 444, DateTimeKind.Utc).AddTicks(7001), 5441.1000000000004, 54070L, "Connelly - Goodwin", "Ft" },
                    { new Guid("ded1ff73-13c3-c105-1254-f8a48a2e1458"), new DateTime(2027, 7, 17, 16, 44, 49, 625, DateTimeKind.Utc).AddTicks(1246), 5721.2799999999997, 56944L, "Streich and Sons", "" },
                    { new Guid("df145b10-f1f3-74ea-8903-a423b35f927d"), new DateTime(2026, 12, 28, 11, 31, 55, 689, DateTimeKind.Utc).AddTicks(2288), 4649.0600000000004, 20701L, "Boyer - Smith", "" },
                    { new Guid("df74de34-fc38-c618-f334-f5fa3dc61e36"), new DateTime(2026, 8, 21, 18, 24, 13, 676, DateTimeKind.Utc).AddTicks(2267), 7612.4899999999998, 42803L, "Rosenbaum, Wilkinson and Gutkowski", "" },
                    { new Guid("df89b9f2-a191-50e4-f09a-1be6f763401b"), new DateTime(2026, 10, 8, 17, 30, 4, 458, DateTimeKind.Utc).AddTicks(2026), 3435.8499999999999, 80656L, "O'Keefe - O'Conner", "$" },
                    { new Guid("e0a05c73-2903-a514-abb9-3e4b1b2de00f"), new DateTime(2027, 2, 6, 13, 25, 56, 831, DateTimeKind.Utc).AddTicks(3577), 5578.8000000000002, 81236L, "Gerhold Inc", "ман" },
                    { new Guid("e17a6641-be47-6fb2-56aa-3749ae6dfd3f"), new DateTime(2027, 1, 28, 14, 54, 10, 523, DateTimeKind.Utc).AddTicks(8647), 671.37, 7055L, "Leannon, Jacobson and Emmerich", "$" },
                    { new Guid("e1907635-52ee-c06b-cea3-534cd4a71d78"), new DateTime(2026, 9, 19, 23, 6, 31, 960, DateTimeKind.Utc).AddTicks(9874), 3425.9099999999999, 21287L, "Auer LLC", "₨" },
                    { new Guid("e2122f40-1ed9-2dcf-6de6-545be7df57d1"), new DateTime(2027, 6, 5, 3, 18, 17, 823, DateTimeKind.Utc).AddTicks(6883), 7579.5, 43578L, "Berge and Sons", "Gs" },
                    { new Guid("e294c7b5-9bb2-dc7a-05f3-bfcd64228bd4"), new DateTime(2027, 5, 29, 21, 45, 35, 718, DateTimeKind.Utc).AddTicks(7), 6272.3999999999996, 55118L, "Kuhn, Dooley and Thiel", "" },
                    { new Guid("e2bb306b-6dab-7d43-d753-b843e1e8b7cc"), new DateTime(2026, 8, 30, 7, 28, 6, 352, DateTimeKind.Utc).AddTicks(3054), 5086.1300000000001, 52717L, "Beatty - Ankunding", "₮" },
                    { new Guid("e2bed90a-12f0-6c16-8722-51e05fee0ac1"), new DateTime(2026, 8, 10, 23, 47, 27, 918, DateTimeKind.Utc).AddTicks(1995), 2465.3699999999999, 8242L, "Ward Group", "៛" },
                    { new Guid("e3b35873-3605-247e-817c-28df469c7e97"), new DateTime(2027, 6, 19, 7, 6, 56, 243, DateTimeKind.Utc).AddTicks(1397), 9096.2800000000007, 64751L, "Schinner - Satterfield", "$" },
                    { new Guid("e401301a-426c-013d-2e9b-06ee37324f5c"), new DateTime(2027, 1, 21, 9, 40, 9, 399, DateTimeKind.Utc).AddTicks(359), 6244.8000000000002, 34472L, "Schimmel Group", "£" },
                    { new Guid("e48921ff-3644-311e-9f31-8e4ba86c203c"), new DateTime(2026, 9, 29, 9, 55, 23, 763, DateTimeKind.Utc).AddTicks(7311), 6003.9300000000003, 61179L, "Schroeder, Abernathy and Turner", "" },
                    { new Guid("e4bff653-588c-1b7a-9fd0-32ce1cbd9b78"), new DateTime(2027, 4, 6, 7, 5, 30, 895, DateTimeKind.Utc).AddTicks(5682), 4913.2799999999997, 5115L, "Green - Doyle", "" },
                    { new Guid("e60523b5-febc-c22a-11c5-7284c373a5ae"), new DateTime(2026, 9, 6, 21, 33, 29, 889, DateTimeKind.Utc).AddTicks(4288), 6198.8199999999997, 46864L, "Crist Group", "$" },
                    { new Guid("e64503f2-60ad-c15b-5d43-16f6bb407983"), new DateTime(2027, 4, 7, 5, 30, 13, 111, DateTimeKind.Utc).AddTicks(1755), 6784.0299999999997, 10059L, "Jerde - Smith", "" },
                    { new Guid("e646c477-960d-8fcd-b461-3470e921405b"), new DateTime(2027, 6, 9, 22, 58, 28, 773, DateTimeKind.Utc).AddTicks(7971), 2773.2199999999998, 52726L, "Bailey - Trantow", "lei" },
                    { new Guid("e6a25d44-9164-a34a-ce63-754846e0a9f0"), new DateTime(2026, 12, 18, 21, 19, 45, 443, DateTimeKind.Utc).AddTicks(1470), 5187.3299999999999, 84560L, "Wehner - Rutherford", "MT" },
                    { new Guid("e6e50db5-4c05-1d3b-e55c-03c17be4f96e"), new DateTime(2027, 2, 18, 3, 2, 14, 337, DateTimeKind.Utc).AddTicks(9937), 9984.7299999999996, 26075L, "Prosacco Inc", "" },
                    { new Guid("e7154ab0-f828-07e7-2e52-d749c48e2ce4"), new DateTime(2027, 6, 12, 11, 59, 58, 336, DateTimeKind.Utc).AddTicks(4745), 7558.3800000000001, 16293L, "Hirthe Inc", "" },
                    { new Guid("e736b241-a0b1-8a6f-2cf5-3c43cc58596d"), new DateTime(2027, 2, 28, 0, 0, 7, 898, DateTimeKind.Utc).AddTicks(1506), 9560.2700000000004, 94290L, "Kulas Group", "C$" },
                    { new Guid("e76b676e-0df1-d846-27ba-ed2722fbb9e4"), new DateTime(2027, 1, 23, 10, 53, 44, 946, DateTimeKind.Utc).AddTicks(2028), 7978.3000000000002, 1204L, "Raynor Inc", "£" },
                    { new Guid("e78b5d32-d89f-cbcb-c1cb-af7c48a42fda"), new DateTime(2027, 3, 13, 20, 33, 15, 136, DateTimeKind.Utc).AddTicks(3354), 5160.8000000000002, 65494L, "Graham - Beier", "" },
                    { new Guid("e7c61a5f-e532-08d0-773a-0c69f1239910"), new DateTime(2027, 8, 6, 18, 2, 11, 338, DateTimeKind.Utc).AddTicks(7633), 4142.25, 71965L, "Smith, Kling and Schamberger", "" },
                    { new Guid("e7e594c0-3131-0d0f-18a3-d98ea2c2eb19"), new DateTime(2026, 11, 28, 15, 51, 22, 228, DateTimeKind.Utc).AddTicks(3192), 1522.05, 42505L, "Bashirian, Wiegand and Jones", "" },
                    { new Guid("e818db58-86ee-727a-eae5-9ef2a6dd430e"), new DateTime(2027, 1, 8, 5, 15, 43, 311, DateTimeKind.Utc).AddTicks(5771), 9403.8299999999999, 14574L, "Hansen Group", "" },
                    { new Guid("e82f77f8-fa30-8d21-cbc2-f965528c8c67"), new DateTime(2026, 10, 28, 4, 23, 51, 214, DateTimeKind.Utc).AddTicks(1655), 1715.45, 80202L, "Boyle - Thompson", "₨" },
                    { new Guid("e87df808-de35-3ef9-ddb7-7ac2798e24c1"), new DateTime(2026, 11, 7, 6, 8, 35, 926, DateTimeKind.Utc).AddTicks(532), 9787.4699999999993, 97551L, "Konopelski - Homenick", "" },
                    { new Guid("e928f5ca-130f-dd6b-beda-74b6fe6af482"), new DateTime(2027, 2, 8, 11, 54, 1, 306, DateTimeKind.Utc).AddTicks(6693), 5898.1099999999997, 14841L, "Dare, Roob and Reilly", "₩" },
                    { new Guid("e94865f2-d40b-c498-d74f-66ac81e4961f"), new DateTime(2026, 12, 8, 7, 56, 42, 25, DateTimeKind.Utc).AddTicks(9377), 3378.3699999999999, 62279L, "Nitzsche, Pollich and Bogan", "Ls" },
                    { new Guid("e957ff09-cbbc-257a-1aef-f10bdf14c496"), new DateTime(2026, 9, 4, 2, 45, 57, 268, DateTimeKind.Utc).AddTicks(5747), 7562.4799999999996, 80891L, "Flatley, Koch and Kautzer", "﷼" },
                    { new Guid("e9b5b584-90f0-1a77-a589-174f3265fd47"), new DateTime(2026, 11, 16, 18, 58, 45, 197, DateTimeKind.Utc).AddTicks(5729), 469.75999999999999, 32765L, "Dare, Tremblay and Bartoletti", "" },
                    { new Guid("ea76672f-9aab-2591-d174-620263bfe404"), new DateTime(2026, 9, 16, 1, 5, 59, 713, DateTimeKind.Utc).AddTicks(8872), 269.64999999999998, 95936L, "Heller LLC", "$" },
                    { new Guid("ea7fc2ed-95a9-2bc2-47fc-eda30db08357"), new DateTime(2026, 8, 13, 12, 54, 31, 88, DateTimeKind.Utc).AddTicks(1802), 7833.8500000000004, 28263L, "Price Inc", "" },
                    { new Guid("ea980200-1641-7c69-e3e2-d6356bd98b8b"), new DateTime(2027, 6, 15, 4, 11, 18, 713, DateTimeKind.Utc).AddTicks(5828), 4629.4300000000003, 25492L, "Jerde - Will", "Db" },
                    { new Guid("eaa63a19-ba2b-41fe-d0f8-b69c7b2d12c1"), new DateTime(2027, 7, 24, 15, 38, 47, 717, DateTimeKind.Utc).AddTicks(2485), 4212.8500000000004, 74234L, "Kassulke, Raynor and Hoppe", "₩" },
                    { new Guid("eacdd6cf-6db8-bb66-2698-d94fdfe6075e"), new DateTime(2027, 3, 9, 22, 53, 58, 264, DateTimeKind.Utc).AddTicks(2877), 5719.6700000000001, 25572L, "Treutel, Turner and Zemlak", "" },
                    { new Guid("eafd2a69-300f-4104-06d6-6c8e8f063af2"), new DateTime(2026, 9, 18, 13, 21, 15, 896, DateTimeKind.Utc).AddTicks(2799), 9756.9200000000001, 96221L, "DuBuque - Legros", "" },
                    { new Guid("eb6ad456-291c-f47d-3ba5-7605aeae8846"), new DateTime(2026, 11, 13, 22, 17, 25, 726, DateTimeKind.Utc).AddTicks(8483), 3604.3699999999999, 82061L, "Kihn, Ullrich and Dietrich", "TT$" },
                    { new Guid("ebe248e3-ae14-c85f-81d6-39a455ef9e72"), new DateTime(2027, 1, 26, 2, 56, 28, 35, DateTimeKind.Utc).AddTicks(4115), 820.20000000000005, 14385L, "Purdy Group", "" },
                    { new Guid("ebffebfb-9356-0159-cd8a-a8ef49dfc2d3"), new DateTime(2026, 10, 26, 7, 44, 32, 72, DateTimeKind.Utc).AddTicks(4389), 170.59, 32688L, "Murphy - Batz", "" },
                    { new Guid("ec5573dd-050b-354a-7c80-1c354d69d323"), new DateTime(2026, 8, 18, 11, 56, 1, 128, DateTimeKind.Utc).AddTicks(7063), 5611.6000000000004, 46908L, "Ritchie - Hilll", "" },
                    { new Guid("ecda893e-2e07-808f-e3c0-2e7a56eef5f5"), new DateTime(2026, 8, 7, 17, 6, 55, 429, DateTimeKind.Utc).AddTicks(989), 807.50999999999999, 76144L, "Lueilwitz, Kilback and Mertz", "Gs" },
                    { new Guid("ed07b168-5ed5-98e6-ad29-9068a67d4467"), new DateTime(2026, 11, 1, 21, 57, 8, 496, DateTimeKind.Utc).AddTicks(4813), 4583.7799999999997, 49898L, "Goldner Inc", "£" },
                    { new Guid("ed139941-b60b-33f3-4315-6d8eeefde44c"), new DateTime(2027, 7, 13, 21, 35, 5, 961, DateTimeKind.Utc).AddTicks(9319), 2658.7600000000002, 4320L, "Hauck, Pacocha and Ullrich", "﷼" },
                    { new Guid("ed92d776-2828-0b20-b41c-a88cfab63ff7"), new DateTime(2027, 5, 20, 7, 46, 43, 123, DateTimeKind.Utc).AddTicks(2031), 5788.4300000000003, 39152L, "Heaney, Batz and Grimes", "" },
                    { new Guid("ed951a87-d5ac-aeef-83b8-f3216af1fc8f"), new DateTime(2026, 10, 26, 4, 23, 56, 506, DateTimeKind.Utc).AddTicks(9048), 2787.3099999999999, 12543L, "O'Connell, Hamill and Koch", "" },
                    { new Guid("ed9f58bb-2458-1c0d-08b3-1a86e22d76bc"), new DateTime(2027, 4, 8, 11, 5, 52, 999, DateTimeKind.Utc).AddTicks(6403), 5722.6499999999996, 76133L, "Nitzsche - Hauck", "" },
                    { new Guid("edba22e8-4b6a-6f1a-6277-eacb34d22850"), new DateTime(2026, 12, 13, 15, 51, 40, 117, DateTimeKind.Utc).AddTicks(6677), 6249.8800000000001, 58180L, "Lind Group", "" },
                    { new Guid("ee01ac3f-5528-95a4-dac9-5ff4c09e1416"), new DateTime(2027, 6, 9, 5, 1, 1, 605, DateTimeKind.Utc).AddTicks(9137), 96.430000000000007, 38042L, "Breitenberg Group", "£" },
                    { new Guid("ee262572-8cc8-1f82-e5e8-64352b3a5215"), new DateTime(2027, 6, 23, 16, 49, 39, 309, DateTimeKind.Utc).AddTicks(2107), 4942.5699999999997, 4627L, "Rempel - Parisian", "" },
                    { new Guid("ee3e612f-798f-8b21-08b9-a475f6555dca"), new DateTime(2027, 2, 26, 16, 36, 3, 410, DateTimeKind.Utc).AddTicks(9367), 6761.8699999999999, 19155L, "Herzog and Sons", "R$" },
                    { new Guid("ee4cd459-98c5-b923-aff7-a2ecc7c4a8d1"), new DateTime(2026, 10, 31, 20, 4, 31, 399, DateTimeKind.Utc).AddTicks(2553), 2486.3000000000002, 9516L, "Dickinson and Sons", "Rp" },
                    { new Guid("ef4facc7-996c-ba10-7cd1-31e61bbac95c"), new DateTime(2027, 2, 3, 3, 10, 19, 511, DateTimeKind.Utc).AddTicks(6135), 9693.2999999999993, 42590L, "Schuster, Torphy and Prohaska", "£" },
                    { new Guid("ef5e9bc8-f6c1-b286-19d3-148ecf4c26a0"), new DateTime(2026, 9, 18, 23, 2, 41, 586, DateTimeKind.Utc).AddTicks(1328), 2617.8499999999999, 80312L, "O'Hara - Ritchie", "" },
                    { new Guid("ef65c8b7-ca33-df23-9adb-af862701b9b2"), new DateTime(2027, 3, 11, 22, 12, 6, 368, DateTimeKind.Utc).AddTicks(6525), 4704.04, 7646L, "Hackett and Sons", "ман" },
                    { new Guid("f0308f61-9243-19e2-16eb-de47443ab660"), new DateTime(2026, 10, 20, 20, 16, 13, 891, DateTimeKind.Utc).AddTicks(5904), 7067.6099999999997, 94796L, "Beier Inc", "฿" },
                    { new Guid("f173f881-fe3a-54b4-5070-92cac0721bec"), new DateTime(2026, 8, 19, 15, 26, 34, 438, DateTimeKind.Utc).AddTicks(2530), 1505.71, 67805L, "Labadie and Sons", "₨" },
                    { new Guid("f1cbdb07-e2b0-504a-d6a5-d892e499574a"), new DateTime(2027, 7, 20, 2, 30, 29, 240, DateTimeKind.Utc).AddTicks(5488), 2813.1700000000001, 85122L, "Padberg - Zieme", "" },
                    { new Guid("f1fc4ef5-d9cf-3a46-f757-6fd741193e40"), new DateTime(2027, 3, 29, 3, 48, 16, 957, DateTimeKind.Utc).AddTicks(4406), 6701.9899999999998, 18668L, "Morar, Metz and Lynch", "MT" },
                    { new Guid("f242f775-b186-0c08-409c-ad17b83d59bc"), new DateTime(2027, 1, 6, 0, 49, 45, 988, DateTimeKind.Utc).AddTicks(4104), 6248.4200000000001, 79456L, "Tromp, Cruickshank and Kautzer", "" },
                    { new Guid("f2da715a-29f3-9eee-9a91-4aaf8c2b4bab"), new DateTime(2026, 8, 23, 11, 9, 54, 214, DateTimeKind.Utc).AddTicks(1362), 5248.9399999999996, 1292L, "Sporer Group", "" },
                    { new Guid("f2dbd4f8-3a7a-8706-9453-be91bf6cdd54"), new DateTime(2026, 12, 3, 11, 30, 36, 963, DateTimeKind.Utc).AddTicks(68), 4522.6499999999996, 8172L, "Altenwerth - McKenzie", "Bs" },
                    { new Guid("f318b4df-b65e-7a6a-ef9f-45ede0cdb610"), new DateTime(2026, 8, 19, 0, 7, 2, 144, DateTimeKind.Utc).AddTicks(1404), 185.41999999999999, 4004L, "Rogahn - Jast", "" },
                    { new Guid("f33cdaf7-5fa3-ce31-a97d-3eb56f80ee6d"), new DateTime(2027, 5, 6, 23, 4, 59, 648, DateTimeKind.Utc).AddTicks(7415), 5350.3000000000002, 19135L, "Barrows, Durgan and Stanton", "" },
                    { new Guid("f39c0a54-7722-0571-73d3-9501b68ba240"), new DateTime(2027, 4, 4, 21, 8, 1, 129, DateTimeKind.Utc).AddTicks(7341), 7765.54, 90715L, "Okuneva, McClure and Oberbrunner", "" },
                    { new Guid("f3cc8050-098a-e031-691f-f79026e92674"), new DateTime(2026, 11, 10, 9, 18, 53, 934, DateTimeKind.Utc).AddTicks(2532), 6838.3199999999997, 97003L, "Bogan - Terry", "$" },
                    { new Guid("f3cf3206-9e02-3c20-cc7a-65239a806534"), new DateTime(2027, 5, 27, 21, 27, 59, 545, DateTimeKind.Utc).AddTicks(2593), 9970.9400000000005, 16173L, "Corwin Inc", "ƒ" },
                    { new Guid("f43d9937-3f27-3a62-bf01-25310548db4a"), new DateTime(2026, 9, 20, 7, 55, 23, 363, DateTimeKind.Utc).AddTicks(9212), 774.14999999999998, 65008L, "Pfeffer, Boyer and Labadie", "" },
                    { new Guid("f44f5585-0877-27a6-bb1d-2637169d54b9"), new DateTime(2027, 3, 18, 23, 39, 24, 529, DateTimeKind.Utc).AddTicks(5035), 3069.6100000000001, 88687L, "Luettgen - Goldner", "" },
                    { new Guid("f47add04-5d2c-4f14-d250-540a1e8af425"), new DateTime(2027, 7, 13, 21, 13, 15, 643, DateTimeKind.Utc).AddTicks(4424), 8035.6400000000003, 85543L, "Kirlin - Spencer", "" },
                    { new Guid("f47e513c-0685-7b50-e0ec-9bb411518f9e"), new DateTime(2026, 12, 19, 15, 0, 12, 797, DateTimeKind.Utc).AddTicks(1815), 9536.1100000000006, 13331L, "Walsh, Rippin and Connelly", "Ls" },
                    { new Guid("f4819b63-596a-9332-ece6-58aa5d6cde21"), new DateTime(2027, 6, 15, 3, 22, 59, 200, DateTimeKind.Utc).AddTicks(3579), 6959.6999999999998, 8171L, "Walsh - Turner", "¥" },
                    { new Guid("f4bd6d02-c6ae-00dc-534e-6bd8b5b61860"), new DateTime(2027, 2, 20, 8, 56, 35, 594, DateTimeKind.Utc).AddTicks(8488), 8268.3799999999992, 45149L, "Stroman Group", "" },
                    { new Guid("f4f43275-530a-9206-76a3-6a5422c76bd8"), new DateTime(2027, 2, 2, 8, 59, 32, 849, DateTimeKind.Utc).AddTicks(5545), 3303.2800000000002, 41061L, "Rowe - Robel", "RD$" },
                    { new Guid("f4fc8d7c-eb45-8ac0-91b7-674a0fd8796d"), new DateTime(2026, 8, 20, 21, 43, 49, 91, DateTimeKind.Utc).AddTicks(8685), 8688.1800000000003, 32200L, "Batz and Sons", "" },
                    { new Guid("f5059ac9-b330-5e2b-cf7e-16950d08ebb1"), new DateTime(2027, 3, 7, 5, 13, 28, 668, DateTimeKind.Utc).AddTicks(6538), 1941.53, 19486L, "Yundt, Durgan and Runolfsson", "" },
                    { new Guid("f5809164-c9bf-7d29-df89-60cbeee04806"), new DateTime(2027, 5, 25, 19, 53, 9, 773, DateTimeKind.Utc).AddTicks(5013), 8139.7200000000003, 38750L, "Torp Inc", "₮" },
                    { new Guid("f5c519d2-fc50-786f-cafe-c72971a3d2c7"), new DateTime(2027, 5, 6, 17, 18, 55, 250, DateTimeKind.Utc).AddTicks(963), 3110.21, 87165L, "Schneider - Turner", "﷼" },
                    { new Guid("f5c5c264-e73a-5416-8264-0383f9c6be75"), new DateTime(2027, 7, 17, 4, 54, 4, 876, DateTimeKind.Utc).AddTicks(3106), 2520.8200000000002, 38932L, "Tromp - Cassin", "$" },
                    { new Guid("f5e1d140-4a25-f6d3-5c51-e21795402ce4"), new DateTime(2026, 12, 12, 5, 14, 59, 533, DateTimeKind.Utc).AddTicks(2985), 1907.26, 72123L, "Klein - Hilpert", "" },
                    { new Guid("f66223d8-aea4-9643-e396-f64782dc232f"), new DateTime(2027, 6, 18, 21, 36, 26, 270, DateTimeKind.Utc).AddTicks(5373), 5853.7399999999998, 38003L, "Predovic and Sons", "₨" },
                    { new Guid("f6855ad2-2ac4-b313-a9c6-b5e5fa6f4142"), new DateTime(2027, 6, 21, 6, 54, 31, 581, DateTimeKind.Utc).AddTicks(1693), 8184.3000000000002, 23063L, "Wehner - Fisher", "$" },
                    { new Guid("f69021a0-6401-ad8e-1425-2c6584be77ff"), new DateTime(2027, 4, 11, 11, 9, 23, 153, DateTimeKind.Utc).AddTicks(8233), 3098.8400000000001, 54671L, "Howell - Schmidt", "" },
                    { new Guid("f6b6fffc-cb55-61b3-fd2a-f55a19e673b2"), new DateTime(2027, 1, 4, 1, 59, 37, 241, DateTimeKind.Utc).AddTicks(187), 9613.8199999999997, 69662L, "Hessel - Gutkowski", "S/." },
                    { new Guid("f7159705-3982-df6a-a67e-e1204353cd9e"), new DateTime(2027, 3, 11, 12, 48, 44, 570, DateTimeKind.Utc).AddTicks(5197), 8200.5300000000007, 16214L, "Simonis, Macejkovic and Hoeger", "" },
                    { new Guid("f7414ec8-6ac0-b022-8ab9-86afa4e38912"), new DateTime(2027, 2, 9, 21, 36, 10, 56, DateTimeKind.Utc).AddTicks(5277), 285.81, 18632L, "Kub and Sons", "S" },
                    { new Guid("f75e4c69-f376-75b6-b655-86f10e490752"), new DateTime(2027, 7, 9, 22, 30, 5, 605, DateTimeKind.Utc).AddTicks(6889), 5031.25, 46043L, "Okuneva - Lubowitz", "$" },
                    { new Guid("f7b6e137-d1a0-b022-43e0-ac9326effc42"), new DateTime(2027, 6, 4, 23, 54, 35, 613, DateTimeKind.Utc).AddTicks(3331), 9671.0699999999997, 66381L, "Koch, Harris and Franecki", "" },
                    { new Guid("f7d5eeb8-fe7b-6147-3212-862ac33f6229"), new DateTime(2027, 3, 14, 18, 48, 50, 214, DateTimeKind.Utc).AddTicks(3389), 3662.98, 12444L, "O'Connell - Brown", "¥" },
                    { new Guid("f87e7649-ef70-1f20-66a2-a06b0ca59268"), new DateTime(2026, 9, 3, 12, 30, 40, 737, DateTimeKind.Utc).AddTicks(7281), 2174.9200000000001, 48307L, "Shanahan - Mayer", "NT$" },
                    { new Guid("f89be166-8a99-1b64-10a7-93b62062144a"), new DateTime(2026, 9, 21, 2, 17, 45, 293, DateTimeKind.Utc).AddTicks(3235), 87.219999999999999, 80961L, "Flatley - Schumm", "៛" },
                    { new Guid("f8b55b2d-5d16-ffef-48cc-d1261d6a1789"), new DateTime(2027, 5, 11, 15, 33, 12, 723, DateTimeKind.Utc).AddTicks(9604), 1291.1400000000001, 18081L, "Bode - Simonis", "" },
                    { new Guid("f8cdb9bc-e929-731a-0966-e367f210adda"), new DateTime(2027, 4, 18, 3, 54, 42, 864, DateTimeKind.Utc).AddTicks(4363), 5893.75, 63430L, "Kilback - Corkery", "£" },
                    { new Guid("f9b3ef53-3cb7-85d1-ad23-aa3a2e6b8da0"), new DateTime(2026, 10, 16, 19, 8, 56, 699, DateTimeKind.Utc).AddTicks(8640), 9602.0799999999999, 74375L, "Renner - McGlynn", "" },
                    { new Guid("f9d5e82d-e9a5-561b-f755-d84763d23b2f"), new DateTime(2026, 10, 8, 21, 53, 38, 661, DateTimeKind.Utc).AddTicks(9237), 835.49000000000001, 36808L, "Raynor - Kohler", "zł" },
                    { new Guid("fa65b84c-528c-a8e4-ce15-37faf469f8f8"), new DateTime(2027, 2, 19, 16, 44, 1, 893, DateTimeKind.Utc).AddTicks(5178), 7238.2600000000002, 96033L, "Bode Inc", "" },
                    { new Guid("fa71891a-72ed-31c0-a4de-eac886b74d35"), new DateTime(2026, 10, 7, 2, 26, 1, 805, DateTimeKind.Utc).AddTicks(9923), 2947.8600000000001, 86074L, "O'Keefe, Connelly and Windler", "$" },
                    { new Guid("fa8c3d7f-895c-2f69-3222-1e7502b4c592"), new DateTime(2026, 12, 6, 16, 53, 30, 720, DateTimeKind.Utc).AddTicks(5600), 9488.3999999999996, 74370L, "Rau - Hilpert", "CHF" },
                    { new Guid("faa1fa19-5723-b122-4171-c4984518cd54"), new DateTime(2027, 1, 27, 4, 44, 47, 500, DateTimeKind.Utc).AddTicks(7360), 9140.0400000000009, 45649L, "Ondricka - Pouros", "£" },
                    { new Guid("fab3aaab-21fb-3431-c28c-69f0df52c19b"), new DateTime(2026, 12, 19, 22, 19, 44, 292, DateTimeKind.Utc).AddTicks(5242), 7833.4799999999996, 20361L, "Huel - Ward", "ман" },
                    { new Guid("fb010b57-6264-b39f-9091-fe5f4fc35a1a"), new DateTime(2026, 11, 27, 5, 13, 33, 483, DateTimeKind.Utc).AddTicks(5053), 7085.9899999999998, 62029L, "Hettinger Inc", "" },
                    { new Guid("fb12062d-eefd-ea19-1f71-cc0ef7caf188"), new DateTime(2027, 4, 14, 0, 9, 19, 284, DateTimeKind.Utc).AddTicks(3060), 5056.1300000000001, 39408L, "Purdy - Ullrich", "$" },
                    { new Guid("fb737c00-6ec9-798c-e955-b5d05737f1e4"), new DateTime(2026, 11, 24, 13, 11, 4, 555, DateTimeKind.Utc).AddTicks(8308), 9076.1100000000006, 69950L, "Kozey - Kiehn", "ƒ" },
                    { new Guid("fbecce42-f1fe-c9e3-8590-2f51b672b262"), new DateTime(2027, 4, 7, 23, 7, 50, 638, DateTimeKind.Utc).AddTicks(6026), 3956.7199999999998, 1464L, "Beer, Gorczany and Jacobson", "" },
                    { new Guid("fc2d7c8d-fb97-1d68-c448-1bde137177d9"), new DateTime(2027, 6, 25, 21, 55, 42, 316, DateTimeKind.Utc).AddTicks(2897), 8928.8199999999997, 2720L, "Hyatt and Sons", "" },
                    { new Guid("fcabbf88-1040-2a45-cd9d-c2c2b5d76ec3"), new DateTime(2027, 6, 16, 1, 17, 51, 722, DateTimeKind.Utc).AddTicks(221), 2415.1399999999999, 71464L, "Morar Group", "$" },
                    { new Guid("fcdf84cd-8357-2ae0-0f78-38287d5a5764"), new DateTime(2026, 9, 11, 19, 48, 14, 635, DateTimeKind.Utc).AddTicks(1022), 9151.1900000000005, 26659L, "Kuhlman - Steuber", "" },
                    { new Guid("fd272998-cc25-87a6-2e07-7bd41027fa96"), new DateTime(2026, 10, 1, 23, 11, 28, 97, DateTimeKind.Utc).AddTicks(3289), 3052.9099999999999, 57549L, "Von - Johnston", "" },
                    { new Guid("fd761907-5af6-0ad4-868c-8f5305fb6ab7"), new DateTime(2027, 4, 10, 22, 43, 18, 182, DateTimeKind.Utc).AddTicks(3604), 3451.0999999999999, 89834L, "Crist, Lowe and Abernathy", "" },
                    { new Guid("fd80e855-d4b2-b31b-725e-f670669c1ada"), new DateTime(2026, 8, 27, 23, 49, 28, 244, DateTimeKind.Utc).AddTicks(8218), 4746.8699999999999, 79857L, "Padberg - Beier", "៛" },
                    { new Guid("fda03720-0af6-05a9-bdbb-8f5ca96bc061"), new DateTime(2027, 8, 4, 19, 17, 8, 377, DateTimeKind.Utc).AddTicks(7655), 881.65999999999997, 19048L, "Hauck Inc", "$" },
                    { new Guid("fdb03e42-7a51-baf4-4892-384545e1a58d"), new DateTime(2026, 8, 11, 13, 54, 54, 554, DateTimeKind.Utc).AddTicks(6790), 9188.7600000000002, 69549L, "Mertz LLC", "R$" },
                    { new Guid("fdc4e613-9107-72a1-4372-43eee65e4ea0"), new DateTime(2027, 7, 15, 20, 17, 18, 823, DateTimeKind.Utc).AddTicks(9273), 6377.1499999999996, 34377L, "Powlowski, Olson and Waelchi", "" },
                    { new Guid("fe0aae75-b4f8-11d2-856e-d04af4a99027"), new DateTime(2027, 7, 9, 1, 32, 3, 721, DateTimeKind.Utc).AddTicks(6749), 3802.2399999999998, 11985L, "Bechtelar - Douglas", "﷼" },
                    { new Guid("fe578efe-de4a-a700-acea-5972fb76d3ab"), new DateTime(2026, 8, 27, 1, 3, 57, 368, DateTimeKind.Utc).AddTicks(2780), 358.5, 54342L, "Becker Inc", "" },
                    { new Guid("fe621176-e657-df6c-b64d-b78a8cd3d0ca"), new DateTime(2027, 6, 19, 23, 34, 37, 900, DateTimeKind.Utc).AddTicks(4325), 8457.75, 72377L, "Stoltenberg - Balistreri", "$" },
                    { new Guid("fed84acb-c1e3-5ce0-cd3c-07da284de237"), new DateTime(2027, 2, 24, 22, 27, 42, 317, DateTimeKind.Utc).AddTicks(1951), 943.79999999999995, 62431L, "McGlynn, Douglas and Johns", "$" },
                    { new Guid("fef58ba8-f850-736e-e136-b9dfc09fab5c"), new DateTime(2027, 7, 12, 22, 28, 37, 369, DateTimeKind.Utc).AddTicks(6576), 2503.6599999999999, 35005L, "Mills Group", "﷼" },
                    { new Guid("ff52f372-7e13-1b94-a6cb-ce54e63dad5d"), new DateTime(2027, 4, 6, 12, 53, 41, 989, DateTimeKind.Utc).AddTicks(4701), 7898.6300000000001, 47187L, "Dach Inc", "៛" },
                    { new Guid("ff56381d-0b3f-f825-84b2-42ad71b9f1d0"), new DateTime(2027, 5, 4, 13, 10, 13, 94, DateTimeKind.Utc).AddTicks(7619), 2495.1900000000001, 59119L, "Dickinson Group", "Дин." },
                    { new Guid("ffa226e9-e9f3-bfff-a500-18d21ad8b228"), new DateTime(2027, 4, 18, 7, 48, 6, 515, DateTimeKind.Utc).AddTicks(6237), 833.28999999999996, 8599L, "Ferry, Morar and Howe", "₺" }
                });

            migrationBuilder.InsertData(
                table: "SellOrders",
                columns: new[] { "SellOrderID", "DateAndTimeOfOrder", "Price", "Quantity", "StockName", "StockSymbol" },
                values: new object[,]
                {
                    { new Guid("00189643-a3df-3534-b665-bbac8a5df889"), new DateTime(2027, 1, 10, 1, 25, 43, 217, DateTimeKind.Utc).AddTicks(7829), 9044.4799999999996, 38080L, "Dare - Schumm", "₮" },
                    { new Guid("00497219-639f-2d9a-0fb5-a3aae5ffef35"), new DateTime(2026, 10, 4, 13, 43, 5, 796, DateTimeKind.Utc).AddTicks(2150), 8683.0599999999995, 95278L, "Roob LLC", "ƒ" },
                    { new Guid("006ae72c-b461-c58d-9d77-4444e930cbac"), new DateTime(2027, 2, 16, 17, 48, 43, 137, DateTimeKind.Utc).AddTicks(5982), 2008.29, 14099L, "Beatty, Veum and Torphy", "" },
                    { new Guid("00ebd308-9ebf-6e1b-9909-f67d0899059c"), new DateTime(2027, 3, 25, 19, 54, 49, 814, DateTimeKind.Utc).AddTicks(7450), 7630.2700000000004, 33895L, "Marks Inc", "¥" },
                    { new Guid("0127bf6f-e810-eb2c-412e-7dd332117c04"), new DateTime(2026, 10, 11, 5, 24, 16, 213, DateTimeKind.Utc).AddTicks(5865), 8717.3099999999995, 71239L, "Bergstrom LLC", "₩" },
                    { new Guid("0149b872-c341-ba53-34d0-7b01d2469649"), new DateTime(2027, 1, 22, 20, 40, 8, 624, DateTimeKind.Utc).AddTicks(1667), 944.13999999999999, 65500L, "Kshlerin - Abshire", "₦" },
                    { new Guid("021579ec-d810-3463-beff-e20f65cbda36"), new DateTime(2027, 4, 16, 11, 26, 7, 433, DateTimeKind.Utc).AddTicks(6734), 8859.2299999999996, 35206L, "White Group", "" },
                    { new Guid("022888e9-6234-f795-a812-6ec2d00a6704"), new DateTime(2027, 1, 26, 12, 24, 33, 453, DateTimeKind.Utc).AddTicks(5552), 6432.8100000000004, 46918L, "Hickle Inc", "₹" },
                    { new Guid("023c833f-e6ad-b2c5-7f84-b04fb547cb58"), new DateTime(2027, 6, 24, 10, 24, 22, 206, DateTimeKind.Utc).AddTicks(2895), 2568.04, 42998L, "Zulauf - Larson", "₡" },
                    { new Guid("0247be4c-0e05-e7b9-5384-8eb9b88f199b"), new DateTime(2027, 3, 2, 2, 0, 31, 275, DateTimeKind.Utc).AddTicks(577), 8570.8700000000008, 80532L, "O'Reilly - Johns", "$" },
                    { new Guid("0257c76a-3cf4-d2b7-7264-760e559118a9"), new DateTime(2026, 11, 7, 1, 19, 47, 12, DateTimeKind.Utc).AddTicks(9624), 1502.1800000000001, 36144L, "Ernser, Langosh and Gulgowski", "C$" },
                    { new Guid("025c3407-0ef6-d930-8438-6a2333a6ee3f"), new DateTime(2027, 1, 5, 23, 18, 20, 905, DateTimeKind.Utc).AddTicks(1573), 7514.7200000000003, 35915L, "Shields, Von and Daniel", "B/." },
                    { new Guid("02755d53-aa57-07b3-1eae-b80240471729"), new DateTime(2027, 4, 24, 20, 45, 19, 592, DateTimeKind.Utc).AddTicks(4140), 9118.2999999999993, 72405L, "Moore, Kemmer and Romaguera", "" },
                    { new Guid("027eab22-1b75-bf4e-a28e-4b396fc21c67"), new DateTime(2026, 12, 4, 17, 16, 26, 891, DateTimeKind.Utc).AddTicks(3829), 69.599999999999994, 69483L, "Breitenberg - Sawayn", "" },
                    { new Guid("02b30c7f-c7df-ba09-9264-793dcbf3278e"), new DateTime(2026, 12, 28, 11, 20, 2, 515, DateTimeKind.Utc).AddTicks(2626), 4678.2799999999997, 62553L, "Kozey and Sons", "" },
                    { new Guid("02c88bee-bed2-2a28-16e8-6d7907547baa"), new DateTime(2026, 9, 25, 18, 55, 8, 403, DateTimeKind.Utc).AddTicks(1866), 9875.9500000000007, 57767L, "Beatty Inc", "" },
                    { new Guid("03394887-ac91-dde2-6dc1-f2c6f69c22b7"), new DateTime(2027, 2, 28, 14, 24, 50, 131, DateTimeKind.Utc).AddTicks(2848), 184.5, 84847L, "Douglas and Sons", "" },
                    { new Guid("03d60abd-6aaa-f601-b9d6-68100954d639"), new DateTime(2027, 4, 12, 14, 50, 37, 966, DateTimeKind.Utc).AddTicks(8934), 4032.4299999999998, 97382L, "Reichert - Johnston", "" },
                    { new Guid("049eefd5-78f3-83d7-e3e3-4594a0bc0101"), new DateTime(2027, 2, 24, 7, 56, 53, 991, DateTimeKind.Utc).AddTicks(8018), 158.13999999999999, 41383L, "Lebsack, Walker and Bernhard", "£" },
                    { new Guid("051454a8-ff5f-e4ee-8186-3c4c41361f38"), new DateTime(2027, 6, 12, 19, 2, 22, 255, DateTimeKind.Utc).AddTicks(9069), 4686.79, 72771L, "Powlowski and Sons", "S/." },
                    { new Guid("05249669-339f-bc0f-c7d3-a19d5878d704"), new DateTime(2027, 8, 5, 12, 39, 47, 126, DateTimeKind.Utc).AddTicks(3859), 7013.71, 54363L, "Terry LLC", "R" },
                    { new Guid("05255bd2-a423-f038-bd20-d5e3f5cd00b9"), new DateTime(2026, 9, 16, 11, 14, 21, 238, DateTimeKind.Utc).AddTicks(4674), 3246.9899999999998, 72209L, "Upton, Emard and Rodriguez", "$" },
                    { new Guid("052f5e11-c14a-6507-ad90-b61869dd7d3e"), new DateTime(2027, 5, 8, 21, 28, 42, 688, DateTimeKind.Utc).AddTicks(877), 3224.4200000000001, 36785L, "Wilderman, Kuhn and Koss", "" },
                    { new Guid("0530b226-bb73-4b2a-366b-74af3d4fd829"), new DateTime(2026, 11, 25, 15, 1, 38, 657, DateTimeKind.Utc).AddTicks(2642), 236.63, 46081L, "Hayes, Moen and Friesen", "" },
                    { new Guid("066a3d7b-6f29-2fe2-3b54-7cfa6ee14364"), new DateTime(2027, 5, 25, 9, 57, 13, 210, DateTimeKind.Utc).AddTicks(9728), 9060.7199999999993, 9611L, "Koss, Rippin and Casper", "Bs" },
                    { new Guid("06a194e6-25d0-c71d-2b8b-d4f356cf52d1"), new DateTime(2027, 4, 6, 2, 16, 10, 237, DateTimeKind.Utc).AddTicks(7337), 3284.77, 52339L, "Braun, Kerluke and Greenholt", "" },
                    { new Guid("06b8a106-9c88-58de-8f3f-a2e491d995b6"), new DateTime(2026, 8, 24, 0, 16, 12, 298, DateTimeKind.Utc).AddTicks(3347), 4395.7600000000002, 91272L, "Stanton, Muller and Cartwright", "" },
                    { new Guid("06ccc6d5-e110-8782-eb9c-2ef127d798c2"), new DateTime(2026, 9, 3, 21, 26, 54, 764, DateTimeKind.Utc).AddTicks(2549), 7371.4399999999996, 67604L, "Farrell - Jones", "﷼" },
                    { new Guid("07ce89c3-5c93-1e03-90df-4ebbcef1adf2"), new DateTime(2027, 8, 3, 3, 40, 7, 31, DateTimeKind.Utc).AddTicks(557), 4571.8199999999997, 24178L, "Mayer, Lueilwitz and Orn", "" },
                    { new Guid("07f9abc7-1122-a208-19ad-cf74e631f539"), new DateTime(2026, 12, 5, 18, 56, 33, 940, DateTimeKind.Utc).AddTicks(3463), 4820.8000000000002, 74001L, "Kirlin and Sons", "$" },
                    { new Guid("087ec763-8925-da30-38b7-0d8160109410"), new DateTime(2027, 4, 13, 20, 42, 39, 379, DateTimeKind.Utc).AddTicks(9277), 1361.74, 36250L, "Brown and Sons", "N$" },
                    { new Guid("0948b497-2ce7-d6c5-8976-d27f72d804ab"), new DateTime(2027, 5, 1, 0, 7, 42, 967, DateTimeKind.Utc).AddTicks(6213), 495.44, 30747L, "Kub - Bins", "฿" },
                    { new Guid("09c844ef-9473-8c69-a010-f65ca319319c"), new DateTime(2026, 12, 5, 11, 43, 47, 668, DateTimeKind.Utc).AddTicks(5612), 1725.99, 45345L, "Gorczany, Hansen and Cruickshank", "" },
                    { new Guid("0ae62d86-2409-df9a-7caf-526c5f838418"), new DateTime(2027, 2, 26, 22, 48, 55, 295, DateTimeKind.Utc).AddTicks(4920), 7512.3199999999997, 23141L, "Volkman - Vandervort", "" },
                    { new Guid("0b60e523-0e0a-a4b7-f375-2e12d6b57f24"), new DateTime(2026, 12, 30, 18, 42, 58, 762, DateTimeKind.Utc).AddTicks(7023), 3764.9000000000001, 82399L, "Wisozk, Zulauf and Lang", "" },
                    { new Guid("0b78e129-0b86-3a20-edcb-9ab08bb25190"), new DateTime(2026, 9, 5, 16, 43, 30, 919, DateTimeKind.Utc).AddTicks(6458), 6289.6000000000004, 18926L, "Balistreri, Heaney and Wisozk", "kr" },
                    { new Guid("0bb434c4-e4a5-f43e-f477-5f00be34ca6b"), new DateTime(2027, 2, 26, 16, 53, 2, 840, DateTimeKind.Utc).AddTicks(3135), 8651.8400000000001, 17546L, "Kiehn - Runolfsson", "£" },
                    { new Guid("0c1dcf5f-e933-cba4-7a76-6ee56c6a42a1"), new DateTime(2026, 12, 24, 12, 1, 10, 823, DateTimeKind.Utc).AddTicks(3994), 9235.0599999999995, 95631L, "Ortiz and Sons", "Q" },
                    { new Guid("0c84598a-3807-8735-b7c2-9ec2728994ca"), new DateTime(2027, 7, 29, 14, 23, 2, 925, DateTimeKind.Utc).AddTicks(5183), 1312.77, 24983L, "Feeney and Sons", "" },
                    { new Guid("0ce839e2-2672-8289-0755-96935c4d4a22"), new DateTime(2027, 4, 8, 15, 59, 4, 999, DateTimeKind.Utc).AddTicks(9671), 1459.4400000000001, 25167L, "Kessler, Hackett and Treutel", "kr" },
                    { new Guid("0cf9f5c8-4549-7cb7-f8ca-9f655de5a22f"), new DateTime(2027, 2, 25, 13, 2, 31, 394, DateTimeKind.Utc).AddTicks(1248), 906.60000000000002, 81394L, "Herzog - Mante", "" },
                    { new Guid("0d4fe01c-a04f-ebf2-5c8d-6c9ebf27f6f1"), new DateTime(2027, 2, 3, 11, 49, 37, 572, DateTimeKind.Utc).AddTicks(5697), 1490.8900000000001, 3569L, "Leffler - Kiehn", "€" },
                    { new Guid("0d5223ca-b3d6-5d31-3b95-70e08681c395"), new DateTime(2026, 12, 24, 15, 27, 19, 597, DateTimeKind.Utc).AddTicks(1194), 3509.52, 4212L, "Hilll, Steuber and Schinner", "NT$" },
                    { new Guid("0d646398-c53e-c91f-30fe-786cb7a8471e"), new DateTime(2026, 12, 22, 7, 0, 44, 101, DateTimeKind.Utc).AddTicks(5531), 8337.7000000000007, 46962L, "Bergstrom and Sons", "" },
                    { new Guid("0d7bb118-ccce-6414-456f-31c5f6dba732"), new DateTime(2026, 9, 21, 15, 46, 52, 201, DateTimeKind.Utc).AddTicks(8643), 5965.0600000000004, 30832L, "Hegmann - Hills", "$" },
                    { new Guid("0d98ddaf-603c-5549-0b1c-9767566637a6"), new DateTime(2027, 2, 27, 16, 41, 29, 102, DateTimeKind.Utc).AddTicks(5265), 3851.7399999999998, 20348L, "Jones - McKenzie", "R$" },
                    { new Guid("0e066d3d-0bd9-6aa9-407c-a594f45e1fc5"), new DateTime(2027, 1, 15, 23, 56, 29, 893, DateTimeKind.Utc).AddTicks(196), 7153.6099999999997, 40527L, "Heller, Kihn and Nicolas", "" },
                    { new Guid("0e2b1de9-5d5e-fb5a-3a7b-a675c74194f7"), new DateTime(2027, 8, 3, 12, 3, 31, 469, DateTimeKind.Utc).AddTicks(3459), 2227.0900000000001, 18800L, "Wintheiser and Sons", "₡" },
                    { new Guid("0e77d200-9e0f-3f31-e83f-6bdbecc414b3"), new DateTime(2026, 10, 11, 17, 41, 33, 621, DateTimeKind.Utc).AddTicks(8661), 1435.25, 16670L, "Frami, Hermiston and Miller", "lei" },
                    { new Guid("0eb1924d-bc8f-c89f-b5e4-9b0d04236d2f"), new DateTime(2027, 3, 8, 2, 2, 25, 730, DateTimeKind.Utc).AddTicks(4754), 205.06, 16192L, "Nolan, DuBuque and Grimes", "" },
                    { new Guid("0eb88b08-6245-f3af-2b32-ba1bd07d06f4"), new DateTime(2026, 12, 31, 21, 50, 33, 785, DateTimeKind.Utc).AddTicks(5924), 3496.21, 81004L, "Marvin - Hyatt", "៛" },
                    { new Guid("0f53de2d-2c75-170d-90b8-9028708f22d7"), new DateTime(2027, 1, 27, 18, 58, 45, 327, DateTimeKind.Utc).AddTicks(8758), 965.89999999999998, 88792L, "Marquardt - Tremblay", "€" },
                    { new Guid("0f701b50-12f1-3211-b4f5-7dd137fe4043"), new DateTime(2027, 2, 1, 12, 57, 0, 420, DateTimeKind.Utc).AddTicks(2547), 9024.2399999999998, 31531L, "Romaguera and Sons", "kr" },
                    { new Guid("0fc1f0ca-f481-beaa-3029-988949bbba8a"), new DateTime(2027, 7, 23, 9, 4, 39, 831, DateTimeKind.Utc).AddTicks(5667), 1978.1099999999999, 73122L, "Kiehn - Bednar", "" },
                    { new Guid("0fdbf193-03ba-15a8-feb7-516574947d08"), new DateTime(2026, 12, 30, 13, 50, 15, 410, DateTimeKind.Utc).AddTicks(4108), 6185.2600000000002, 17128L, "Zemlak - Cormier", "" },
                    { new Guid("0ffa0b49-8961-3a8f-b3f7-18bdb04f6ca6"), new DateTime(2027, 5, 1, 1, 9, 34, 212, DateTimeKind.Utc).AddTicks(9304), 9619.7299999999996, 57303L, "Boehm LLC", "$" },
                    { new Guid("103d9a4b-a3bc-6fed-74b8-0cbf02eb3dbe"), new DateTime(2027, 6, 21, 15, 8, 46, 254, DateTimeKind.Utc).AddTicks(1851), 4566.0100000000002, 52930L, "Harvey - Schamberger", "Kč" },
                    { new Guid("10ec6366-5302-3ed8-e6f5-49f6ccc347c2"), new DateTime(2027, 2, 4, 4, 32, 9, 356, DateTimeKind.Utc).AddTicks(4989), 3634.4499999999998, 96649L, "Grimes - Collier", "$" },
                    { new Guid("117174f3-1c31-43db-8516-2d2be4c12cb7"), new DateTime(2026, 8, 23, 3, 45, 28, 169, DateTimeKind.Utc).AddTicks(298), 6142.2600000000002, 84856L, "Bruen Group", "" },
                    { new Guid("11a83600-6b74-f9a4-07b9-82ec1a74b810"), new DateTime(2026, 12, 2, 15, 1, 26, 818, DateTimeKind.Utc).AddTicks(9463), 7510.75, 6380L, "Yost, Okuneva and Moore", "лв" },
                    { new Guid("12376732-0c1b-754c-8cf9-8c887ecff16b"), new DateTime(2027, 1, 4, 22, 23, 22, 923, DateTimeKind.Utc).AddTicks(730), 3522.4099999999999, 65457L, "Hane, Rowe and Blanda", "CHF" },
                    { new Guid("126f303f-2f29-3741-a9a9-b8438f9ea503"), new DateTime(2027, 5, 1, 12, 54, 12, 400, DateTimeKind.Utc).AddTicks(9802), 5385.5900000000001, 97422L, "Heaney Group", "£" },
                    { new Guid("127b643e-c482-cc48-2a34-06e65a159bda"), new DateTime(2027, 1, 3, 17, 20, 35, 829, DateTimeKind.Utc).AddTicks(3854), 1664.22, 32314L, "Schneider Group", "zł" },
                    { new Guid("1286c7f7-6686-8409-cd72-e2b86b6c422a"), new DateTime(2026, 12, 15, 19, 33, 43, 829, DateTimeKind.Utc).AddTicks(5151), 4974.3400000000001, 56893L, "Keeling - Auer", "₨" },
                    { new Guid("12e531c2-65a1-8e94-8da9-9276acccd960"), new DateTime(2026, 12, 20, 22, 45, 19, 721, DateTimeKind.Utc).AddTicks(39), 9692.9899999999998, 90535L, "Wunsch, Boehm and Waelchi", "₪" },
                    { new Guid("13462e2e-6b33-2058-f772-b1f1c9888c81"), new DateTime(2027, 1, 8, 12, 8, 54, 158, DateTimeKind.Utc).AddTicks(4293), 9498.8999999999996, 40307L, "Conn, Hane and Schultz", "$" },
                    { new Guid("1382cf61-9f72-6efb-4c47-c7dd273c8d36"), new DateTime(2027, 4, 7, 22, 59, 50, 61, DateTimeKind.Utc).AddTicks(7226), 2327.46, 12701L, "Pagac - Rath", "лв" },
                    { new Guid("13c27723-7a4d-442f-b1d0-7204db033010"), new DateTime(2027, 2, 25, 10, 39, 54, 127, DateTimeKind.Utc).AddTicks(8640), 3686.7399999999998, 42380L, "Brekke and Sons", "" },
                    { new Guid("140d0b7c-4081-fa01-8fc0-7cbf08552f6e"), new DateTime(2027, 3, 16, 9, 25, 50, 956, DateTimeKind.Utc).AddTicks(2141), 200.47, 25415L, "Dibbert, Adams and Senger", "NT$" },
                    { new Guid("141adc71-c188-e04c-f5c2-1f30eba73e44"), new DateTime(2027, 6, 12, 13, 10, 24, 145, DateTimeKind.Utc).AddTicks(8692), 2178.6100000000001, 42559L, "Emard - Wisozk", "£" },
                    { new Guid("142d8b7b-5b50-8196-7583-e02d153065b8"), new DateTime(2027, 2, 5, 23, 17, 41, 847, DateTimeKind.Utc).AddTicks(4412), 1121.28, 59595L, "Johnson LLC", "﷼" },
                    { new Guid("1440ca0c-bd71-6509-0c59-9500384cde06"), new DateTime(2027, 5, 24, 5, 40, 50, 334, DateTimeKind.Utc).AddTicks(1933), 7253.46, 98881L, "Kuhn LLC", "" },
                    { new Guid("146970d4-d655-82cc-8f1d-8ff95f553e96"), new DateTime(2027, 2, 17, 12, 40, 17, 208, DateTimeKind.Utc).AddTicks(1302), 9109.4300000000003, 2717L, "Kassulke - Sawayn", "Ls" },
                    { new Guid("149c2796-7eb2-0d75-87c4-8cbb5eb0af17"), new DateTime(2026, 12, 26, 13, 3, 52, 943, DateTimeKind.Utc).AddTicks(6169), 8470.0, 14343L, "Wuckert - Marquardt", "" },
                    { new Guid("14d513da-9913-388f-6d8f-c23daa513b0d"), new DateTime(2027, 7, 13, 17, 32, 36, 520, DateTimeKind.Utc).AddTicks(1415), 8683.3700000000008, 19551L, "Mitchell and Sons", "﷼" },
                    { new Guid("14d6fcdd-6e5c-1aad-bccf-fba956e879fe"), new DateTime(2027, 1, 18, 17, 10, 14, 525, DateTimeKind.Utc).AddTicks(3716), 3547.04, 67579L, "Crona Inc", "" },
                    { new Guid("15726220-982e-8d94-8ff6-efa95af7fc2c"), new DateTime(2026, 11, 21, 22, 57, 47, 393, DateTimeKind.Utc).AddTicks(7335), 303.37, 7027L, "Davis - Jones", "" },
                    { new Guid("1624af64-aea4-0d53-56b1-9881e1395397"), new DateTime(2026, 11, 14, 22, 2, 23, 179, DateTimeKind.Utc).AddTicks(9273), 1459.8, 46199L, "Ferry and Sons", "" },
                    { new Guid("16b3c008-a12c-010a-7ce6-03204fdf32e5"), new DateTime(2027, 7, 30, 21, 36, 17, 951, DateTimeKind.Utc).AddTicks(1909), 6248.4799999999996, 86597L, "Hermiston Inc", "kr" },
                    { new Guid("172c540b-611c-6975-d62c-adf9e8cf1cdd"), new DateTime(2027, 2, 14, 10, 45, 46, 315, DateTimeKind.Utc).AddTicks(9061), 2529.3099999999999, 77224L, "Davis, Volkman and Bechtelar", "" },
                    { new Guid("173d340d-a0eb-93d4-e7fb-2edab4b04c5c"), new DateTime(2027, 7, 26, 12, 0, 51, 538, DateTimeKind.Utc).AddTicks(5985), 4205.9300000000003, 74752L, "VonRueden and Sons", "" },
                    { new Guid("17428aca-13a7-e7e9-52af-0fe84e45f45b"), new DateTime(2027, 1, 30, 20, 43, 44, 740, DateTimeKind.Utc).AddTicks(7165), 5233.5500000000002, 36564L, "Feil - Lang", "Db" },
                    { new Guid("178a7001-42a5-2dae-e61a-71d411bf20a4"), new DateTime(2027, 5, 12, 15, 3, 37, 72, DateTimeKind.Utc).AddTicks(4123), 1263.3299999999999, 70605L, "Farrell - Murazik", "zł" },
                    { new Guid("17d75dce-d7f9-364c-f49a-749a48be1f63"), new DateTime(2026, 12, 25, 10, 19, 22, 617, DateTimeKind.Utc).AddTicks(1912), 7022.2600000000002, 61069L, "Auer, Stehr and Abernathy", "¥" },
                    { new Guid("18d7d71e-01e2-0d0f-9f17-c20f0151c1e1"), new DateTime(2027, 6, 22, 10, 24, 45, 194, DateTimeKind.Utc).AddTicks(6359), 3564.7399999999998, 17848L, "Blanda, Bruen and Zulauf", "₫" },
                    { new Guid("190efbe4-488f-f074-c576-07f1309940b0"), new DateTime(2026, 10, 6, 18, 23, 45, 28, DateTimeKind.Utc).AddTicks(1817), 6100.5699999999997, 30250L, "Toy - Rice", "" },
                    { new Guid("19323a00-0699-fc63-11e0-01aacbe458d4"), new DateTime(2026, 10, 1, 8, 30, 20, 868, DateTimeKind.Utc).AddTicks(1503), 2943.7600000000002, 64334L, "Hoeger - Kshlerin", "CHF" },
                    { new Guid("195d283e-73d6-6498-044f-8de343ecc1cd"), new DateTime(2027, 1, 18, 1, 50, 5, 241, DateTimeKind.Utc).AddTicks(328), 1750.6900000000001, 62008L, "Hilpert - Lebsack", "$" },
                    { new Guid("1a126610-95d1-edb3-c01c-cb64f5d77f03"), new DateTime(2026, 12, 29, 4, 58, 39, 134, DateTimeKind.Utc).AddTicks(5942), 6750.5600000000004, 90774L, "Stroman - Price", "" },
                    { new Guid("1a27a754-1d02-8ee1-5c18-19e7fe342ba9"), new DateTime(2026, 11, 2, 10, 25, 18, 558, DateTimeKind.Utc).AddTicks(1229), 7982.6999999999998, 33179L, "Mitchell Group", "﷼" },
                    { new Guid("1a44cd78-7e1c-4d50-2152-6bc528706559"), new DateTime(2027, 2, 25, 18, 52, 31, 945, DateTimeKind.Utc).AddTicks(5429), 3998.5599999999999, 56125L, "Flatley, Lynch and Beer", "L" },
                    { new Guid("1b30fc92-c058-9413-a5d8-436579570da6"), new DateTime(2027, 1, 11, 1, 7, 12, 545, DateTimeKind.Utc).AddTicks(5414), 5620.5100000000002, 84064L, "Abshire, Heidenreich and Hahn", "" },
                    { new Guid("1b692d3b-b01d-7173-d85b-daad5ebb9b8b"), new DateTime(2027, 5, 7, 20, 1, 36, 842, DateTimeKind.Utc).AddTicks(6245), 6697.7299999999996, 91737L, "Balistreri - Hamill", "₨" },
                    { new Guid("1c0a51a2-d949-1a70-eb97-fd5792902bd8"), new DateTime(2026, 11, 26, 8, 59, 43, 873, DateTimeKind.Utc).AddTicks(395), 1872.25, 19676L, "Marquardt, Prosacco and Kiehn", "" },
                    { new Guid("1ca03552-4cf7-d46e-8d3e-5413ef0cd16f"), new DateTime(2026, 10, 3, 18, 50, 6, 513, DateTimeKind.Utc).AddTicks(4314), 2440.5799999999999, 62998L, "Luettgen - Gislason", "Nu" },
                    { new Guid("1ca7831d-b5f4-8f43-1743-e4191fa136a6"), new DateTime(2027, 5, 21, 3, 19, 1, 735, DateTimeKind.Utc).AddTicks(8826), 1209.9000000000001, 14119L, "Crona and Sons", "$" },
                    { new Guid("1d9f1717-f840-f2e9-7f68-f6ee52335cf9"), new DateTime(2027, 3, 9, 1, 33, 56, 425, DateTimeKind.Utc).AddTicks(991), 5234.6899999999996, 36324L, "Dach Group", "MT" },
                    { new Guid("1db52f97-4e9e-5f02-2e27-ebfe14e94fe5"), new DateTime(2027, 3, 7, 13, 20, 47, 692, DateTimeKind.Utc).AddTicks(3762), 3122.3499999999999, 59184L, "King Inc", "£" },
                    { new Guid("1df14eb6-7971-f066-49f6-162dbaef2234"), new DateTime(2027, 4, 26, 7, 54, 5, 583, DateTimeKind.Utc).AddTicks(3263), 1265.02, 29614L, "Johnson and Sons", "RD$" },
                    { new Guid("1e513e9b-2adf-81bd-82a0-a2e382d7d9d3"), new DateTime(2027, 4, 26, 15, 42, 50, 668, DateTimeKind.Utc).AddTicks(8980), 8948.4300000000003, 36403L, "Batz, Morar and Hartmann", "лв" },
                    { new Guid("1e6205cf-9d7b-5340-918b-284311b093eb"), new DateTime(2027, 6, 20, 3, 26, 33, 191, DateTimeKind.Utc).AddTicks(8302), 7960.1899999999996, 97083L, "Hettinger, Spinka and Graham", "RD$" },
                    { new Guid("1e876fb3-7cfa-4459-9263-9634482c7b66"), new DateTime(2027, 8, 4, 21, 50, 22, 677, DateTimeKind.Utc).AddTicks(9347), 5911.71, 96123L, "Gulgowski Group", "₨" },
                    { new Guid("1e936753-a9b0-dd30-b976-aa32d8ee441f"), new DateTime(2027, 2, 6, 17, 35, 13, 391, DateTimeKind.Utc).AddTicks(4729), 9858.0, 82573L, "Huel, Connelly and Schaefer", "﷼" },
                    { new Guid("1eb7e5de-577a-6d0a-d659-69a3c9e08405"), new DateTime(2026, 12, 15, 18, 59, 45, 747, DateTimeKind.Utc).AddTicks(7321), 1913.3299999999999, 42943L, "Crona - Abernathy", "Ft" },
                    { new Guid("1ecc1303-8955-bc52-0a6a-00d69d8153a2"), new DateTime(2026, 9, 17, 3, 57, 24, 348, DateTimeKind.Utc).AddTicks(5663), 746.63999999999999, 83407L, "Kihn, Gerhold and Hauck", "N$" },
                    { new Guid("1f04d05b-3739-3232-0c86-e18a96ca3d4d"), new DateTime(2027, 1, 31, 9, 27, 42, 451, DateTimeKind.Utc).AddTicks(1898), 434.25, 83687L, "Schneider and Sons", "₱" },
                    { new Guid("1f17fa6a-2813-5f06-20e2-ff23f7718869"), new DateTime(2027, 3, 5, 11, 55, 11, 454, DateTimeKind.Utc).AddTicks(632), 733.38, 80859L, "Pacocha - Jacobi", "" },
                    { new Guid("1f26e6fd-f014-0873-f306-fa5cfb697ebd"), new DateTime(2026, 11, 17, 5, 41, 4, 159, DateTimeKind.Utc).AddTicks(686), 4265.8599999999997, 27303L, "Smith - Herman", "" },
                    { new Guid("1fc7d64d-e698-1021-77af-9c3a7df5269c"), new DateTime(2027, 2, 4, 9, 8, 39, 4, DateTimeKind.Utc).AddTicks(7781), 4237.3100000000004, 78690L, "Ward - Miller", "" },
                    { new Guid("20b17eaa-89a5-bdaa-0ff5-3a5e2632a500"), new DateTime(2026, 10, 27, 1, 33, 17, 974, DateTimeKind.Utc).AddTicks(219), 4847.1400000000003, 66982L, "Roberts, Berge and Will", "" },
                    { new Guid("20f12575-47c8-2fb4-145d-1c2b431b8c67"), new DateTime(2026, 11, 6, 3, 37, 33, 600, DateTimeKind.Utc).AddTicks(6234), 6839.3199999999997, 94160L, "Leuschke - Bayer", "" },
                    { new Guid("214cd931-e01c-72c7-443b-539ad8ac335e"), new DateTime(2027, 1, 5, 2, 9, 24, 714, DateTimeKind.Utc).AddTicks(6022), 1275.28, 83825L, "Beatty - Green", "" },
                    { new Guid("2164bfbc-b2e5-6b82-4e84-97ecd7d3ff4c"), new DateTime(2027, 2, 12, 2, 31, 18, 77, DateTimeKind.Utc).AddTicks(9991), 200.63, 29449L, "Lowe and Sons", "" },
                    { new Guid("21a22f71-69a4-190c-f9d7-d79a19714960"), new DateTime(2027, 3, 3, 3, 13, 59, 560, DateTimeKind.Utc).AddTicks(1098), 5803.3000000000002, 2637L, "Runolfsdottir, Marvin and Hane", "KM" },
                    { new Guid("22101b4f-b698-c38f-c59c-cd2390312a72"), new DateTime(2027, 4, 16, 22, 34, 16, 602, DateTimeKind.Utc).AddTicks(9044), 5540.1199999999999, 31668L, "Kuhn Inc", "" },
                    { new Guid("22f5a974-4359-81a1-e79d-15e5d88d7e72"), new DateTime(2027, 1, 6, 0, 12, 15, 167, DateTimeKind.Utc).AddTicks(2060), 3084.8099999999999, 35834L, "Robel Group", "" },
                    { new Guid("239c172c-108c-3af7-a3e2-9c4fd050e1aa"), new DateTime(2027, 5, 22, 11, 41, 49, 5, DateTimeKind.Utc).AddTicks(6888), 1017.4, 74428L, "Raynor, Gorczany and Beer", "" },
                    { new Guid("23cc287e-4ed9-8feb-ab13-ca9723bb3033"), new DateTime(2027, 3, 24, 1, 22, 25, 245, DateTimeKind.Utc).AddTicks(5857), 7390.96, 60397L, "Johnson, Hand and Morar", "kr" },
                    { new Guid("243a2778-a54a-367d-066a-0fdd8a65be0e"), new DateTime(2026, 10, 8, 7, 52, 51, 786, DateTimeKind.Utc).AddTicks(9570), 3214.5500000000002, 86335L, "Stracke and Sons", "₪" },
                    { new Guid("2451f664-8ea1-2f1c-8c32-55ee53a659a3"), new DateTime(2027, 1, 29, 10, 31, 19, 385, DateTimeKind.Utc).AddTicks(721), 7303.8400000000001, 19266L, "Borer, Goodwin and Robel", "$" },
                    { new Guid("24f4c151-38d7-3f6a-a439-4a3d77f34b9c"), new DateTime(2027, 5, 14, 15, 26, 43, 957, DateTimeKind.Utc).AddTicks(5637), 2401.3899999999999, 95821L, "Tromp, Morissette and Fisher", "£" },
                    { new Guid("2500aa67-7477-3591-8c36-f5c0e5fa9088"), new DateTime(2027, 6, 10, 21, 30, 5, 458, DateTimeKind.Utc).AddTicks(6695), 6742.1199999999999, 68036L, "Block - Kub", "Gs" },
                    { new Guid("250f41a8-e326-fc2b-5904-dd718fbac7e8"), new DateTime(2026, 12, 5, 21, 4, 30, 257, DateTimeKind.Utc).AddTicks(6258), 6628.1999999999998, 42815L, "Nader and Sons", "" },
                    { new Guid("25538c9e-a01e-223c-1896-d7110e6ed7e9"), new DateTime(2026, 10, 30, 13, 29, 6, 175, DateTimeKind.Utc).AddTicks(6781), 6115.79, 57276L, "Buckridge - Mueller", "B/." },
                    { new Guid("25c13314-335f-18b5-0875-5943ac94358e"), new DateTime(2027, 4, 21, 15, 49, 31, 730, DateTimeKind.Utc).AddTicks(3993), 9890.6499999999996, 34478L, "Cronin - Nolan", "" },
                    { new Guid("25e553b8-403f-7e98-a7d2-5843bba6fb38"), new DateTime(2027, 7, 29, 9, 0, 44, 328, DateTimeKind.Utc).AddTicks(9579), 1995.54, 98306L, "Mohr, Fadel and Ondricka", "TT$" },
                    { new Guid("25e9b023-5f01-7973-9c41-2b83821c261e"), new DateTime(2026, 11, 18, 14, 15, 20, 406, DateTimeKind.Utc).AddTicks(5026), 4229.1099999999997, 88151L, "Runte, Funk and Steuber", "BZ$" },
                    { new Guid("26516e89-ecac-3663-aea6-3b1e22eaa401"), new DateTime(2027, 7, 10, 18, 56, 34, 993, DateTimeKind.Utc).AddTicks(4255), 5571.9700000000003, 67498L, "Grant, Wilderman and Fay", "₡" },
                    { new Guid("26861756-90b1-33bf-fba7-7359c777efc3"), new DateTime(2027, 2, 11, 23, 44, 51, 20, DateTimeKind.Utc).AddTicks(2492), 5656.2299999999996, 90424L, "Konopelski, Deckow and Daugherty", "R$" },
                    { new Guid("269bddb1-43fa-7d96-b792-f9782fa376d3"), new DateTime(2027, 1, 4, 12, 41, 13, 19, DateTimeKind.Utc).AddTicks(8110), 8093.5299999999997, 37028L, "Stoltenberg - Hegmann", "$" },
                    { new Guid("26a590fb-be09-a610-69b1-6c115e1860cb"), new DateTime(2026, 10, 3, 12, 22, 34, 142, DateTimeKind.Utc).AddTicks(514), 5068.1499999999996, 9347L, "Hermann Group", "" },
                    { new Guid("26a5ff75-fcc8-71a0-8d70-c20b59969a0d"), new DateTime(2027, 7, 2, 10, 56, 25, 547, DateTimeKind.Utc).AddTicks(4721), 7133.6000000000004, 14437L, "Cormier, Rutherford and Schowalter", "" },
                    { new Guid("26f8f7c9-7b05-db7f-de80-f5c08883ffe1"), new DateTime(2027, 1, 14, 0, 36, 18, 641, DateTimeKind.Utc).AddTicks(8509), 4179.7799999999997, 54418L, "Goldner - Wiegand", "$" },
                    { new Guid("27083a0d-69e0-1b00-cd27-0824419b148e"), new DateTime(2027, 2, 5, 10, 56, 30, 116, DateTimeKind.Utc).AddTicks(6542), 494.82999999999998, 10412L, "Purdy - Rolfson", "Bs" },
                    { new Guid("273dd369-4577-4085-7a53-ceceb82e837f"), new DateTime(2027, 5, 26, 13, 43, 36, 100, DateTimeKind.Utc).AddTicks(8466), 3613.96, 15445L, "Mueller, Jenkins and Miller", "" },
                    { new Guid("2744055f-291d-997d-9bc1-6eeea3b92c04"), new DateTime(2026, 8, 19, 10, 20, 40, 383, DateTimeKind.Utc).AddTicks(9211), 9809.2700000000004, 47797L, "Stoltenberg - Heidenreich", "" },
                    { new Guid("275e9646-60c3-1f5d-0a90-f31b51fa19ae"), new DateTime(2026, 8, 8, 0, 14, 45, 373, DateTimeKind.Utc).AddTicks(6829), 4185.8999999999996, 4919L, "Haag - Morar", "" },
                    { new Guid("27612610-37ca-6198-8ff9-8591a4546b8e"), new DateTime(2027, 3, 5, 23, 52, 59, 204, DateTimeKind.Utc).AddTicks(7680), 5460.3900000000003, 7005L, "Collier - Strosin", "" },
                    { new Guid("27b8b8b4-0dab-36a0-9c13-6e945d870a99"), new DateTime(2027, 3, 15, 1, 45, 32, 408, DateTimeKind.Utc).AddTicks(8594), 8153.8500000000004, 74594L, "Rodriguez Group", "" },
                    { new Guid("28617785-2127-d7b1-a7f2-47a4fed9b718"), new DateTime(2026, 10, 31, 6, 14, 32, 191, DateTimeKind.Utc).AddTicks(2666), 7743.1099999999997, 34775L, "Wiegand - Prohaska", "" },
                    { new Guid("287e5668-dc4f-c15c-cc33-0c48b468ed2c"), new DateTime(2027, 3, 24, 8, 26, 3, 158, DateTimeKind.Utc).AddTicks(7712), 60.079999999999998, 94299L, "Labadie - Barrows", "" },
                    { new Guid("28f2f08a-29fd-7e5e-8395-21eb4c56d6a4"), new DateTime(2026, 12, 7, 7, 50, 58, 553, DateTimeKind.Utc).AddTicks(1153), 2823.3200000000002, 52727L, "Kovacek Inc", "₨" },
                    { new Guid("29883e80-85fa-c2f0-9fbf-579b36965f76"), new DateTime(2027, 2, 1, 14, 7, 38, 403, DateTimeKind.Utc).AddTicks(9338), 9373.6900000000005, 83939L, "Lind, Howell and Olson", "" },
                    { new Guid("298ee7a7-81e8-6ad1-c9ce-986307f81aa5"), new DateTime(2026, 9, 20, 7, 32, 54, 340, DateTimeKind.Utc).AddTicks(7930), 5058.1999999999998, 51597L, "Bernier, Bartell and Mante", "лв" },
                    { new Guid("29b2e1fd-4b1b-05c5-b1e5-008ad5953b2b"), new DateTime(2027, 7, 24, 5, 31, 43, 392, DateTimeKind.Utc).AddTicks(185), 2600.9899999999998, 99674L, "MacGyver - Jones", "₡" },
                    { new Guid("29c8432c-b0b0-4a1b-5964-151e087c2d61"), new DateTime(2026, 12, 6, 10, 46, 55, 75, DateTimeKind.Utc).AddTicks(8393), 2824.0700000000002, 24255L, "Sauer and Sons", "" },
                    { new Guid("2ac311d7-a3d5-316b-36fa-163d5d56dbc2"), new DateTime(2026, 12, 9, 1, 14, 21, 651, DateTimeKind.Utc).AddTicks(6776), 7325.8500000000004, 99455L, "Morar - Padberg", "₫" },
                    { new Guid("2b27357d-cae7-a858-2891-ebfef6fa6100"), new DateTime(2026, 11, 15, 15, 11, 14, 661, DateTimeKind.Utc).AddTicks(7137), 8814.0300000000007, 83605L, "Hermiston LLC", "" },
                    { new Guid("2b315aba-d47c-34c3-2bde-6243bb6d6699"), new DateTime(2027, 5, 26, 11, 9, 25, 537, DateTimeKind.Utc).AddTicks(5073), 8281.7099999999991, 99007L, "Terry - Beatty", "" },
                    { new Guid("2b916b04-18e2-dc9e-c343-ba20b214f7cc"), new DateTime(2027, 8, 3, 13, 28, 35, 587, DateTimeKind.Utc).AddTicks(8953), 1010.85, 47489L, "Treutel and Sons", "MT" },
                    { new Guid("2b99b7a9-7be7-2ca8-367b-e7a386aabba3"), new DateTime(2026, 10, 17, 22, 42, 34, 834, DateTimeKind.Utc).AddTicks(710), 4005.3600000000001, 30600L, "Leffler, Marquardt and Johnston", "S/." },
                    { new Guid("2bedc2a7-70aa-09c9-2992-b07520ab82d2"), new DateTime(2026, 11, 9, 13, 28, 17, 532, DateTimeKind.Utc).AddTicks(7865), 2562.3400000000001, 88173L, "Hamill LLC", "" },
                    { new Guid("2caff4dd-7095-a8ac-c813-0b42996a0df0"), new DateTime(2027, 5, 17, 6, 16, 15, 846, DateTimeKind.Utc).AddTicks(7025), 4523.5100000000002, 11793L, "Rosenbaum, Heaney and Schultz", "$" },
                    { new Guid("2ce7950d-9bdc-5ff1-19b1-3a60049ce90d"), new DateTime(2026, 12, 10, 12, 58, 32, 716, DateTimeKind.Utc).AddTicks(9373), 7429.3199999999997, 35662L, "Spencer, Kulas and Heidenreich", "₨" },
                    { new Guid("2d8389b7-39dc-9717-c262-f7b648cc57d7"), new DateTime(2027, 1, 16, 4, 18, 21, 815, DateTimeKind.Utc).AddTicks(2686), 4037.8299999999999, 46422L, "Wiza - Johnson", "$" },
                    { new Guid("2dd3fe01-fdda-88e5-ef64-c6f6a696c5ac"), new DateTime(2027, 1, 16, 21, 46, 41, 55, DateTimeKind.Utc).AddTicks(2723), 1411.78, 31326L, "Nikolaus Group", "" },
                    { new Guid("2dd53c46-4764-2740-d34d-497f0f3ed06e"), new DateTime(2027, 6, 15, 17, 3, 23, 775, DateTimeKind.Utc).AddTicks(38), 5814.2700000000004, 5616L, "Ward, Homenick and Adams", "" },
                    { new Guid("2e4bfa14-a186-932e-7aed-0547d814236d"), new DateTime(2027, 3, 27, 11, 5, 13, 192, DateTimeKind.Utc).AddTicks(9079), 7165.4700000000003, 7210L, "Orn, West and Ritchie", "" },
                    { new Guid("2e4fc238-a3e5-c4f2-6658-413171ea7b11"), new DateTime(2027, 1, 7, 21, 39, 50, 347, DateTimeKind.Utc).AddTicks(6176), 8647.9699999999993, 9840L, "Kris, Torphy and Ledner", "S/." },
                    { new Guid("2e802f11-fef8-e633-cf53-92d50ff5b754"), new DateTime(2027, 5, 21, 12, 49, 15, 763, DateTimeKind.Utc).AddTicks(4426), 9393.3099999999995, 34183L, "Weber and Sons", "" },
                    { new Guid("2ececc20-8e0a-870f-cb5e-e1e6c92ab8d1"), new DateTime(2027, 2, 14, 15, 11, 38, 971, DateTimeKind.Utc).AddTicks(357), 2838.8299999999999, 16127L, "Stokes - Donnelly", "" },
                    { new Guid("2f0f19b3-a5a1-c116-d0ef-8e69449c87e3"), new DateTime(2027, 4, 9, 15, 13, 44, 539, DateTimeKind.Utc).AddTicks(5050), 798.80999999999995, 33052L, "Rath - White", "лв" },
                    { new Guid("2f5845d5-ac7f-6200-eecc-71f45397efec"), new DateTime(2027, 3, 8, 19, 22, 39, 234, DateTimeKind.Utc).AddTicks(2992), 516.36000000000001, 73410L, "Emmerich, Morar and Schulist", "$" },
                    { new Guid("2f7f9539-2036-753c-8b72-d0e1ad221c36"), new DateTime(2026, 9, 28, 1, 41, 11, 224, DateTimeKind.Utc).AddTicks(7302), 4289.0799999999999, 37211L, "Johns - Orn", "" },
                    { new Guid("300b3f49-1c6d-dd2f-7a2a-ef6582f89c1a"), new DateTime(2026, 12, 29, 17, 44, 55, 940, DateTimeKind.Utc).AddTicks(8461), 8884.6700000000001, 70401L, "Ullrich - Mueller", "$" },
                    { new Guid("30631523-ee4a-57e7-c73f-53f001016bd2"), new DateTime(2026, 10, 24, 6, 14, 50, 810, DateTimeKind.Utc).AddTicks(624), 8168.8100000000004, 74245L, "Erdman - Lesch", "" },
                    { new Guid("306fc058-18d6-282b-608e-cc443a520176"), new DateTime(2027, 7, 11, 8, 17, 6, 98, DateTimeKind.Utc).AddTicks(6626), 8385.9699999999993, 35227L, "Lynch, Olson and Schmitt", "B/." },
                    { new Guid("3088610a-6dc5-3f32-eb86-da1359a75417"), new DateTime(2027, 3, 24, 15, 35, 2, 299, DateTimeKind.Utc).AddTicks(5459), 6220.1899999999996, 29670L, "Mayer - Hegmann", "" },
                    { new Guid("30a1e08a-27bb-5a9f-4d2a-25979404643c"), new DateTime(2026, 12, 21, 2, 56, 35, 223, DateTimeKind.Utc).AddTicks(224), 2089.4899999999998, 38568L, "Konopelski - Bode", "؋" },
                    { new Guid("30b03e08-8b8f-88e4-8cfb-c23d9f5fa595"), new DateTime(2027, 8, 6, 19, 4, 42, 115, DateTimeKind.Utc).AddTicks(7527), 5992.46, 98701L, "Brakus - Reichert", "$" },
                    { new Guid("31146c86-d446-792a-a511-ddd7119a5a20"), new DateTime(2026, 12, 17, 10, 31, 11, 29, DateTimeKind.Utc).AddTicks(2046), 1054.6900000000001, 63439L, "Konopelski LLC", "﷼" },
                    { new Guid("312a88ba-69e3-92bb-0e88-d0fc50b00da9"), new DateTime(2026, 8, 10, 11, 11, 40, 641, DateTimeKind.Utc).AddTicks(2208), 5860.7799999999997, 2170L, "Flatley Inc", "RM" },
                    { new Guid("3140f183-f430-3601-0227-9135c7377e9b"), new DateTime(2027, 2, 2, 22, 1, 41, 398, DateTimeKind.Utc).AddTicks(9939), 2170.2800000000002, 50720L, "Schulist - Zemlak", "" },
                    { new Guid("315fb6b4-cdaf-ef32-e219-9635aa5245f6"), new DateTime(2027, 6, 11, 10, 25, 16, 229, DateTimeKind.Utc).AddTicks(4276), 6798.8699999999999, 5660L, "Bergstrom - Koelpin", "£" },
                    { new Guid("316969be-71f8-3dc8-7c11-53a4b7a0ee36"), new DateTime(2027, 4, 1, 8, 55, 9, 228, DateTimeKind.Utc).AddTicks(603), 4804.5600000000004, 64392L, "Stark, Doyle and Homenick", "B/." },
                    { new Guid("3188f453-423f-8e46-2cc5-77166ddf2a01"), new DateTime(2027, 1, 1, 23, 22, 33, 897, DateTimeKind.Utc).AddTicks(6760), 6669.0, 51607L, "Ortiz Inc", "" },
                    { new Guid("318d0cfe-269d-d32e-edc6-02f3b4e6f08f"), new DateTime(2027, 3, 1, 13, 48, 59, 501, DateTimeKind.Utc).AddTicks(2696), 1972.49, 32301L, "Brown - Schowalter", "₹" },
                    { new Guid("31b862f4-d783-5434-6374-235a681971cb"), new DateTime(2026, 9, 23, 13, 23, 58, 925, DateTimeKind.Utc).AddTicks(9061), 6500.29, 86422L, "Rolfson - VonRueden", "" },
                    { new Guid("32113500-7080-cb3c-9ff9-dd8bcecc8b0b"), new DateTime(2027, 2, 26, 21, 8, 51, 589, DateTimeKind.Utc).AddTicks(780), 7841.7399999999998, 3633L, "Stoltenberg - Terry", "" },
                    { new Guid("328d907e-5962-2024-3a77-0fff502bac5f"), new DateTime(2027, 7, 1, 4, 34, 7, 557, DateTimeKind.Utc).AddTicks(5666), 9223.8700000000008, 87218L, "MacGyver Group", "₨" },
                    { new Guid("328e58f0-6626-51be-acec-c06eb01321f0"), new DateTime(2026, 9, 28, 0, 9, 47, 230, DateTimeKind.Utc).AddTicks(7180), 223.44999999999999, 5959L, "Altenwerth, Prosacco and Prohaska", "" },
                    { new Guid("329840dd-e409-6878-a0ba-0eb100796c6d"), new DateTime(2026, 9, 14, 19, 40, 35, 502, DateTimeKind.Utc).AddTicks(4561), 9236.2399999999998, 47737L, "Gibson, Pfannerstill and Witting", "" },
                    { new Guid("32b17cb6-56b1-0c69-9798-fc2330aeda72"), new DateTime(2027, 5, 11, 21, 3, 33, 199, DateTimeKind.Utc).AddTicks(3752), 8360.6800000000003, 65137L, "Christiansen, Hagenes and Labadie", "Php" },
                    { new Guid("3323889b-c72c-011d-ca33-51d5c2f0280e"), new DateTime(2027, 2, 15, 7, 28, 54, 664, DateTimeKind.Utc).AddTicks(8639), 2667.9099999999999, 30459L, "Haley - Kunde", "" },
                    { new Guid("337098b8-791b-32b2-d3b3-e702962d65d5"), new DateTime(2026, 9, 12, 13, 48, 7, 677, DateTimeKind.Utc).AddTicks(2759), 9604.6299999999992, 51079L, "Muller - Ratke", "NT$" },
                    { new Guid("33c5a51c-6fd0-9d56-360e-1dfd22b63b9a"), new DateTime(2027, 3, 14, 5, 44, 10, 571, DateTimeKind.Utc).AddTicks(7537), 7731.3800000000001, 62622L, "Greenholt - Rempel", "" },
                    { new Guid("33e59475-f75a-2b96-0683-1a80d08c171b"), new DateTime(2026, 11, 29, 4, 33, 25, 648, DateTimeKind.Utc).AddTicks(4823), 4459.6099999999997, 39892L, "Huels - Wiza", "" },
                    { new Guid("34c41193-59e6-a152-ecf8-5aca1030bf7b"), new DateTime(2026, 10, 14, 15, 14, 2, 406, DateTimeKind.Utc).AddTicks(1876), 343.13, 99559L, "Wuckert, Fritsch and Jakubowski", "₡" },
                    { new Guid("34df9c5f-6af0-c348-1515-005d411fafcd"), new DateTime(2027, 3, 9, 3, 3, 12, 46, DateTimeKind.Utc).AddTicks(2797), 9729.4599999999991, 12580L, "Hoeger Inc", "$" },
                    { new Guid("34ec9e48-5d13-e68b-cc8f-2eef67f86730"), new DateTime(2026, 8, 16, 18, 57, 49, 125, DateTimeKind.Utc).AddTicks(8406), 227.63, 86092L, "Parisian, Lehner and Kunze", "B/." },
                    { new Guid("352b25d8-818c-4566-51bc-5a9eeba991f1"), new DateTime(2027, 3, 8, 11, 52, 42, 299, DateTimeKind.Utc).AddTicks(5237), 3925.48, 18431L, "Jakubowski, Leannon and Kuhn", "" },
                    { new Guid("353e9a40-a8cc-f979-f257-273026be74b5"), new DateTime(2026, 12, 3, 16, 42, 17, 480, DateTimeKind.Utc).AddTicks(5485), 7882.5100000000002, 18289L, "Metz - Donnelly", "$" },
                    { new Guid("354c3a50-31e1-d32c-a730-8b06ee2b36ad"), new DateTime(2027, 1, 11, 18, 11, 1, 968, DateTimeKind.Utc).AddTicks(3641), 3758.8800000000001, 64020L, "Collier - Becker", "﷼" },
                    { new Guid("35e406c4-943b-2482-44d6-a8760a55acd7"), new DateTime(2027, 3, 10, 20, 57, 31, 297, DateTimeKind.Utc).AddTicks(6980), 6644.6000000000004, 27292L, "Hermann - Wisozk", "" },
                    { new Guid("35e752c7-f153-4aae-70d0-a5bda114871e"), new DateTime(2027, 5, 25, 6, 50, 55, 93, DateTimeKind.Utc).AddTicks(5292), 5840.8699999999999, 51161L, "Daugherty, Haag and Braun", "лв" },
                    { new Guid("36300ec4-599a-8435-8d1a-47cc71ad1b83"), new DateTime(2026, 9, 7, 22, 38, 54, 908, DateTimeKind.Utc).AddTicks(2620), 9914.2000000000007, 84553L, "Goyette - Blanda", "" },
                    { new Guid("365ea239-dcf4-599a-121d-5db18b7fe9e4"), new DateTime(2027, 7, 6, 7, 57, 21, 207, DateTimeKind.Utc).AddTicks(4047), 5083.1099999999997, 48941L, "Fritsch - Zemlak", "$" },
                    { new Guid("36d89efb-c2e8-c348-9392-3d11b0d83fb0"), new DateTime(2027, 5, 11, 16, 37, 52, 950, DateTimeKind.Utc).AddTicks(8184), 4370.6099999999997, 42017L, "Kihn - Kiehn", "" },
                    { new Guid("3755177b-14bf-ecdb-ebb8-bc98ed476a25"), new DateTime(2027, 4, 17, 18, 32, 4, 285, DateTimeKind.Utc).AddTicks(6458), 1827.52, 28303L, "Goldner and Sons", "CHF" },
                    { new Guid("37d23e04-b2bf-4496-68f3-915b260ac392"), new DateTime(2027, 1, 10, 7, 54, 29, 91, DateTimeKind.Utc).AddTicks(823), 3516.9699999999998, 54879L, "Brown - Jacobs", "" },
                    { new Guid("37fa8622-af4d-9cf5-4ba6-32fcfb9341a2"), new DateTime(2027, 2, 20, 19, 12, 3, 552, DateTimeKind.Utc).AddTicks(6681), 3879.6900000000001, 68644L, "Murray - Beer", "RD$" },
                    { new Guid("38bbd89c-39d9-a579-d1a4-3a4bf6c2bd91"), new DateTime(2026, 8, 25, 3, 17, 46, 960, DateTimeKind.Utc).AddTicks(1642), 219.91, 48781L, "Weimann - Rice", "៛" },
                    { new Guid("38be24bc-ad9a-e73f-cd89-2ee949bddf01"), new DateTime(2027, 7, 19, 2, 30, 7, 347, DateTimeKind.Utc).AddTicks(8693), 415.10000000000002, 28422L, "Ernser - Stokes", "Ft" },
                    { new Guid("38d180ff-1063-1d83-00bb-eeded203625f"), new DateTime(2026, 11, 29, 21, 59, 19, 472, DateTimeKind.Utc).AddTicks(8836), 5501.7299999999996, 32804L, "Balistreri, Haley and Fahey", "£" },
                    { new Guid("398c3c77-d563-7a35-57ea-59843aee765e"), new DateTime(2027, 3, 4, 18, 29, 32, 758, DateTimeKind.Utc).AddTicks(3826), 2140.1399999999999, 38151L, "Gutmann and Sons", "$" },
                    { new Guid("39e74dc8-5c91-b572-ced6-b4c3294413c9"), new DateTime(2026, 12, 29, 16, 5, 13, 949, DateTimeKind.Utc).AddTicks(2317), 316.52999999999997, 15341L, "Kirlin, Morissette and Leuschke", "" },
                    { new Guid("3a632e26-9502-2ac0-c5b8-12eae696c726"), new DateTime(2026, 11, 21, 19, 10, 15, 654, DateTimeKind.Utc).AddTicks(6840), 2070.23, 82811L, "Ziemann Group", "﷼" },
                    { new Guid("3abc0e5d-0516-da86-8fec-3ce9400776c7"), new DateTime(2026, 12, 27, 4, 58, 6, 503, DateTimeKind.Utc).AddTicks(1752), 8910.1599999999999, 46988L, "Nolan - O'Kon", "" },
                    { new Guid("3ac46f34-3d0c-e4cd-2651-feb13bb506cc"), new DateTime(2027, 6, 30, 6, 20, 10, 690, DateTimeKind.Utc).AddTicks(8920), 1372.55, 6183L, "Luettgen LLC", "$" },
                    { new Guid("3b0ce50a-eef2-3be3-7c89-d8666719bcc7"), new DateTime(2026, 8, 11, 6, 34, 20, 534, DateTimeKind.Utc).AddTicks(2608), 1192.3499999999999, 47810L, "Adams - Abshire", "NT$" },
                    { new Guid("3b3ee3ef-85f8-b29e-21b0-899c73c05e2a"), new DateTime(2026, 9, 5, 10, 54, 15, 701, DateTimeKind.Utc).AddTicks(3385), 2763.27, 2590L, "Gibson Group", "RM" },
                    { new Guid("3b6b6719-4c91-5d4c-20ec-e60cf9b1c815"), new DateTime(2027, 7, 13, 14, 5, 36, 885, DateTimeKind.Utc).AddTicks(3109), 531.90999999999997, 531L, "Christiansen LLC", "S/." },
                    { new Guid("3b95b2e8-fbca-cbc4-4c5e-43462398e749"), new DateTime(2026, 11, 29, 15, 33, 32, 214, DateTimeKind.Utc).AddTicks(3349), 2419.3099999999999, 29695L, "Parker, Fahey and Wilderman", "Ls" },
                    { new Guid("3b988e26-db20-ad82-71a4-76ce51c0f3ed"), new DateTime(2027, 2, 20, 10, 27, 15, 635, DateTimeKind.Utc).AddTicks(8559), 3086.4200000000001, 14302L, "Heidenreich, Tillman and Feeney", "kr" },
                    { new Guid("3bffab24-1d61-2280-5182-0f1235be3dac"), new DateTime(2027, 6, 7, 21, 46, 29, 219, DateTimeKind.Utc).AddTicks(9403), 9680.6499999999996, 12314L, "Stoltenberg LLC", "Kč" },
                    { new Guid("3c1f17f3-4ccb-c11f-4c24-90903b258820"), new DateTime(2027, 8, 6, 1, 14, 56, 725, DateTimeKind.Utc).AddTicks(9530), 6661.1700000000001, 60140L, "Yundt - Padberg", "₨" },
                    { new Guid("3c410185-fec7-1ae2-f024-d8c1e4a85ac4"), new DateTime(2026, 11, 24, 21, 50, 33, 145, DateTimeKind.Utc).AddTicks(9453), 3512.4299999999998, 63132L, "Weimann, Walsh and Schneider", "P" },
                    { new Guid("3c58b513-09cc-ccc8-62ad-31d0aee09337"), new DateTime(2026, 8, 19, 3, 1, 49, 466, DateTimeKind.Utc).AddTicks(1744), 7281.8800000000001, 7682L, "Friesen - Frami", "$" },
                    { new Guid("3cac43d3-5f9d-306b-fcec-eab01ddc0e36"), new DateTime(2026, 12, 15, 16, 55, 7, 476, DateTimeKind.Utc).AddTicks(774), 9265.4200000000001, 39514L, "Koss, Walter and Stoltenberg", "" },
                    { new Guid("3cb680a1-6546-e561-da54-074fc3c2b2c7"), new DateTime(2026, 10, 2, 15, 8, 25, 832, DateTimeKind.Utc).AddTicks(4747), 9881.7099999999991, 51081L, "Lindgren Inc", "" },
                    { new Guid("3ce4ef9d-c5c8-06f5-fd40-bc5c9ce68203"), new DateTime(2027, 3, 1, 19, 27, 0, 740, DateTimeKind.Utc).AddTicks(1890), 8489.2299999999996, 2200L, "Kub Group", "kr" },
                    { new Guid("3ce9c5c9-85fc-cc83-15ed-b38de5dcfb37"), new DateTime(2027, 4, 19, 12, 21, 0, 906, DateTimeKind.Utc).AddTicks(1820), 788.88999999999999, 23616L, "Stiedemann Inc", "" },
                    { new Guid("3cf81234-0d4a-6a87-bb85-3c5bc07d4f09"), new DateTime(2027, 4, 10, 23, 10, 19, 662, DateTimeKind.Utc).AddTicks(1752), 8701.3600000000006, 27447L, "Ernser LLC", "" },
                    { new Guid("3d516dfd-488a-bee4-0c0a-bdc81e6e01c0"), new DateTime(2027, 1, 25, 7, 40, 19, 66, DateTimeKind.Utc).AddTicks(3245), 1803.23, 34576L, "Bashirian, Gusikowski and Huel", "£" },
                    { new Guid("3d669478-ff38-847a-56ac-33bb19f7a86c"), new DateTime(2027, 4, 20, 8, 51, 40, 777, DateTimeKind.Utc).AddTicks(2139), 5564.8900000000003, 81143L, "Braun LLC", "$" },
                    { new Guid("3d76af98-118f-afdd-54fd-38c2e9016eae"), new DateTime(2026, 8, 26, 20, 51, 2, 866, DateTimeKind.Utc).AddTicks(8903), 6487.4700000000003, 83343L, "Becker - Kuvalis", "" },
                    { new Guid("3d872d08-0a52-6ff7-bf7d-fbf8907c7e9a"), new DateTime(2026, 9, 10, 12, 9, 40, 131, DateTimeKind.Utc).AddTicks(8158), 8964.7399999999998, 23326L, "Goyette Inc", "₪" },
                    { new Guid("3daa85bb-a0e0-6607-62b1-93be2d6516cc"), new DateTime(2026, 9, 23, 21, 50, 15, 0, DateTimeKind.Utc).AddTicks(3160), 9921.7199999999993, 2689L, "Kuhic, Hills and Larkin", "P" },
                    { new Guid("3dba681a-20e4-0100-2ccf-dbf909714c9e"), new DateTime(2026, 12, 3, 22, 10, 58, 696, DateTimeKind.Utc).AddTicks(1251), 108.98999999999999, 87679L, "McKenzie Group", "" },
                    { new Guid("3e10966e-5948-dc70-8dcc-7b2530df2741"), new DateTime(2027, 4, 23, 14, 45, 27, 986, DateTimeKind.Utc).AddTicks(8036), 2943.6700000000001, 86322L, "Lehner, Bartoletti and Klocko", "" },
                    { new Guid("3e116d27-49d0-f16f-ec3d-3be71260bcb6"), new DateTime(2027, 7, 9, 18, 37, 44, 720, DateTimeKind.Utc).AddTicks(1216), 5352.3999999999996, 23076L, "Schumm, Trantow and Wilderman", "" },
                    { new Guid("3e1f38b0-0ed6-8fa7-1037-c44ad5967882"), new DateTime(2026, 12, 20, 4, 35, 37, 489, DateTimeKind.Utc).AddTicks(8458), 5577.0900000000001, 64570L, "Abbott, Klein and Nicolas", "" },
                    { new Guid("3ea39e96-cb10-ad13-6684-502c0d58f5c9"), new DateTime(2026, 11, 13, 8, 48, 47, 973, DateTimeKind.Utc).AddTicks(5523), 1139.47, 93541L, "Zemlak Inc", "" },
                    { new Guid("3eb2f80d-d391-5b40-f66b-2ba2d135c803"), new DateTime(2027, 8, 5, 18, 45, 42, 324, DateTimeKind.Utc).AddTicks(1070), 2537.5300000000002, 8238L, "Berge, Runolfsson and West", "ден" },
                    { new Guid("3ec015d4-8a8e-11ac-3df5-96d959966512"), new DateTime(2026, 8, 12, 5, 41, 51, 24, DateTimeKind.Utc).AddTicks(4607), 1706.8900000000001, 96802L, "Heidenreich, Bernier and Block", "MT" },
                    { new Guid("3f38e251-0c0d-42e8-b3c2-42ffffd9dec5"), new DateTime(2026, 12, 2, 12, 20, 0, 945, DateTimeKind.Utc).AddTicks(1067), 4937.2700000000004, 12810L, "Gulgowski - Watsica", "Ft" },
                    { new Guid("3f988505-e61c-e633-2ca9-36b40d05f312"), new DateTime(2027, 2, 1, 3, 39, 33, 783, DateTimeKind.Utc).AddTicks(9754), 8373.2900000000009, 45822L, "Dietrich, Fadel and Weber", "₨" },
                    { new Guid("3fa282cf-c385-f30e-4ca2-cc5f6ce42ae4"), new DateTime(2027, 1, 9, 8, 7, 36, 340, DateTimeKind.Utc).AddTicks(7725), 402.98000000000002, 91745L, "Ruecker - Howell", "RD$" },
                    { new Guid("3fb9a0d4-c4be-32f3-106f-8950cf212ab8"), new DateTime(2027, 2, 21, 8, 5, 33, 87, DateTimeKind.Utc).AddTicks(2159), 2142.2800000000002, 37338L, "Ruecker Inc", "" },
                    { new Guid("3fd485b2-f273-7424-da42-efbc53ab350a"), new DateTime(2026, 12, 22, 9, 57, 21, 46, DateTimeKind.Utc).AddTicks(4480), 275.79000000000002, 67329L, "Kertzmann Inc", "лв" },
                    { new Guid("3fdc28d9-ef3a-5b1c-e778-906505693b5e"), new DateTime(2027, 2, 21, 19, 10, 10, 586, DateTimeKind.Utc).AddTicks(7932), 6256.6700000000001, 78876L, "Schumm and Sons", "ман" },
                    { new Guid("406ab17d-6ebc-da36-0e96-77d8cb64a311"), new DateTime(2026, 8, 7, 16, 21, 21, 483, DateTimeKind.Utc).AddTicks(309), 3328.8899999999999, 38868L, "Stamm, Green and White", "" },
                    { new Guid("4073c01d-b3fe-0d02-828c-b76cde2a8787"), new DateTime(2026, 9, 18, 12, 57, 29, 170, DateTimeKind.Utc).AddTicks(9674), 3225.0300000000002, 32425L, "Hamill, Hamill and Keebler", "Gs" },
                    { new Guid("40baa9e9-cfdd-3fe8-4d0f-0b62c1306b37"), new DateTime(2026, 9, 26, 22, 14, 24, 687, DateTimeKind.Utc).AddTicks(9602), 7445.5600000000004, 66755L, "Kirlin - Klocko", "лв" },
                    { new Guid("40e82304-c91c-b001-a1bc-ae525b556735"), new DateTime(2027, 5, 4, 8, 1, 28, 765, DateTimeKind.Utc).AddTicks(3408), 8527.4799999999996, 58000L, "Ryan - Littel", "Lek" },
                    { new Guid("40f34c87-e0af-12d3-99d0-ce47f30ac14f"), new DateTime(2026, 12, 26, 10, 19, 44, 654, DateTimeKind.Utc).AddTicks(1021), 159.28999999999999, 68397L, "Thompson Group", "" },
                    { new Guid("41000dbd-38d6-1b2a-4b87-e8143cc0f67f"), new DateTime(2027, 1, 18, 6, 20, 16, 414, DateTimeKind.Utc).AddTicks(443), 904.75, 4837L, "Mraz and Sons", "" },
                    { new Guid("4107bb19-c253-4ec1-5935-10bb4100d0b0"), new DateTime(2027, 5, 26, 17, 52, 15, 126, DateTimeKind.Utc).AddTicks(5891), 2736.4699999999998, 67415L, "Douglas LLC", "Db" },
                    { new Guid("4189a120-f75e-8dde-1006-0d48801a8f5d"), new DateTime(2027, 7, 14, 2, 59, 3, 109, DateTimeKind.Utc).AddTicks(8068), 5853.25, 92019L, "Volkman Group", "£" },
                    { new Guid("4191ba18-32b6-5613-806a-4706aef89df4"), new DateTime(2027, 1, 12, 11, 11, 0, 793, DateTimeKind.Utc).AddTicks(9933), 4547.8500000000004, 70164L, "Marquardt LLC", "$" },
                    { new Guid("42094f6b-2bce-737d-569d-5ed24c13b5fb"), new DateTime(2027, 2, 4, 17, 52, 36, 454, DateTimeKind.Utc).AddTicks(4788), 4878.8000000000002, 74017L, "Price and Sons", "RD$" },
                    { new Guid("427a6ae0-8efa-d41a-ae8a-8c219d3ae011"), new DateTime(2026, 9, 17, 20, 34, 39, 743, DateTimeKind.Utc).AddTicks(9380), 2957.5500000000002, 77356L, "Gerhold, Balistreri and Thiel", "ƒ" },
                    { new Guid("429b31dd-a1b8-cc9c-fd64-07cc92cf560a"), new DateTime(2027, 7, 26, 6, 29, 27, 86, DateTimeKind.Utc).AddTicks(4916), 1729.8599999999999, 17803L, "Streich - Kertzmann", "Ft" },
                    { new Guid("43a082d5-0af0-61ab-3ba3-e7359700d2b2"), new DateTime(2026, 11, 9, 20, 32, 48, 570, DateTimeKind.Utc).AddTicks(8415), 8622.9400000000005, 3327L, "Cummerata - Braun", "" },
                    { new Guid("43eef565-5b2c-bbec-d152-aa8ce0bf3d20"), new DateTime(2026, 10, 1, 10, 35, 32, 990, DateTimeKind.Utc).AddTicks(5027), 3801.8600000000001, 50409L, "Howell - Lind", "$" },
                    { new Guid("44458ece-f124-89b5-8e7a-4a3d3fd5a06e"), new DateTime(2027, 7, 24, 15, 3, 32, 301, DateTimeKind.Utc).AddTicks(2649), 4036.7399999999998, 56594L, "Schuster, Maggio and King", "" },
                    { new Guid("44b99ff5-4c0c-1056-300c-7fc891b3ea66"), new DateTime(2027, 7, 21, 19, 42, 19, 205, DateTimeKind.Utc).AddTicks(8332), 5566.4099999999999, 40366L, "Barrows, Littel and Runolfsdottir", "" },
                    { new Guid("44c8b161-785c-d464-6a02-1c6547caf670"), new DateTime(2026, 11, 13, 22, 45, 52, 459, DateTimeKind.Utc).AddTicks(8299), 8966.6000000000004, 32924L, "Gutmann Group", "лв" },
                    { new Guid("45506fa3-a33f-cd2c-8376-4118e4c5d7d4"), new DateTime(2027, 3, 8, 13, 17, 23, 125, DateTimeKind.Utc).AddTicks(3135), 6744.2200000000003, 44729L, "Roob, Tremblay and Ortiz", "£" },
                    { new Guid("45a6311e-017a-feeb-bec3-ef5d3b7c2b7a"), new DateTime(2027, 5, 23, 19, 36, 9, 295, DateTimeKind.Utc).AddTicks(1616), 9688.2600000000002, 48496L, "Hane, Marvin and Swift", "" },
                    { new Guid("45a8bb93-c315-0f57-360f-55be8a0fb830"), new DateTime(2027, 1, 25, 13, 49, 53, 119, DateTimeKind.Utc).AddTicks(4334), 7815.29, 2534L, "Klocko - Hilpert", "$" },
                    { new Guid("45c693ed-b907-c319-14df-25d032e98f43"), new DateTime(2027, 7, 29, 1, 24, 51, 903, DateTimeKind.Utc).AddTicks(3310), 3689.8800000000001, 13178L, "Reichel, Block and Langosh", "₨" },
                    { new Guid("45c82ab9-0eac-5a55-82e1-ae97a17fcac0"), new DateTime(2027, 7, 5, 10, 12, 11, 336, DateTimeKind.Utc).AddTicks(2237), 6969.5100000000002, 83188L, "Stiedemann - Hauck", "" },
                    { new Guid("460a81f0-2114-650f-3b06-74e273f7be90"), new DateTime(2026, 10, 20, 14, 45, 6, 144, DateTimeKind.Utc).AddTicks(1775), 2607.9699999999998, 72027L, "Greenfelder Group", "₨" },
                    { new Guid("464dba9c-660e-9885-32c5-90d63a8df0b1"), new DateTime(2027, 5, 31, 7, 29, 18, 153, DateTimeKind.Utc).AddTicks(83), 4797.8800000000001, 11786L, "Jaskolski Group", "" },
                    { new Guid("465800d2-5614-61db-e51c-027247d5189b"), new DateTime(2027, 4, 5, 6, 55, 10, 648, DateTimeKind.Utc).AddTicks(1112), 3252.0700000000002, 63324L, "Moen Group", "؋" },
                    { new Guid("467663f1-331a-3879-9fae-25763c886f4e"), new DateTime(2027, 7, 11, 21, 2, 45, 332, DateTimeKind.Utc).AddTicks(4501), 4180.9899999999998, 89178L, "Mohr, Zieme and Torp", "" },
                    { new Guid("46b0b9f3-8b14-3c52-3298-294a19dfb85c"), new DateTime(2027, 4, 2, 15, 42, 6, 494, DateTimeKind.Utc).AddTicks(2182), 5650.6800000000003, 67486L, "Schimmel, Casper and Huels", "$" },
                    { new Guid("46d65c5f-e3b9-88fe-64b2-a9b72e131f59"), new DateTime(2027, 7, 9, 4, 51, 28, 984, DateTimeKind.Utc).AddTicks(5993), 6418.8199999999997, 17616L, "Kovacek, Kemmer and Dibbert", "$" },
                    { new Guid("473df8d7-9887-87ec-234b-bd77dee197e8"), new DateTime(2026, 11, 19, 0, 16, 24, 443, DateTimeKind.Utc).AddTicks(4829), 7886.1899999999996, 81694L, "Konopelski, Kuvalis and King", "" },
                    { new Guid("47669cf4-caa3-237f-8e85-068d4ca7d1d1"), new DateTime(2026, 8, 31, 0, 22, 42, 398, DateTimeKind.Utc).AddTicks(235), 2055.96, 94469L, "Windler, Heaney and Koelpin", "£" },
                    { new Guid("476c7d26-3ee8-0a76-120a-7528c8801282"), new DateTime(2026, 9, 3, 15, 43, 49, 344, DateTimeKind.Utc).AddTicks(7408), 185.88, 88221L, "Christiansen LLC", "៛" },
                    { new Guid("47ac9172-5809-ba8c-0750-683a1b6153f0"), new DateTime(2026, 12, 28, 20, 2, 45, 687, DateTimeKind.Utc).AddTicks(616), 8485.3400000000001, 64952L, "Reinger LLC", "" },
                    { new Guid("4829af85-1897-6d6e-1622-39b017b2ad8e"), new DateTime(2027, 7, 1, 17, 2, 37, 281, DateTimeKind.Utc).AddTicks(579), 1911.3800000000001, 32575L, "King - Towne", "" },
                    { new Guid("483c1232-b86b-5be0-dd8b-c261051d7bc6"), new DateTime(2027, 6, 30, 4, 23, 54, 145, DateTimeKind.Utc).AddTicks(2498), 6681.6199999999999, 11225L, "Paucek Group", "kr" },
                    { new Guid("48b62f3e-a0d1-99c9-0dfa-ec9b7633b326"), new DateTime(2026, 11, 24, 2, 47, 26, 586, DateTimeKind.Utc).AddTicks(9915), 544.40999999999997, 77472L, "Ratke Group", "руб" },
                    { new Guid("48cd140c-5328-1bac-e509-883a6deaff3f"), new DateTime(2027, 7, 28, 11, 6, 44, 185, DateTimeKind.Utc).AddTicks(497), 6180.5699999999997, 80972L, "Balistreri - Marks", "TT$" },
                    { new Guid("48de45ad-88e2-3ce1-8d65-95ba1d1a7a63"), new DateTime(2027, 2, 16, 17, 52, 12, 456, DateTimeKind.Utc).AddTicks(4132), 8851.0, 54754L, "Gislason LLC", "" },
                    { new Guid("48de637d-010b-9ecb-df3c-6638f813e7fa"), new DateTime(2026, 11, 1, 16, 18, 19, 510, DateTimeKind.Utc).AddTicks(3726), 6188.3000000000002, 11550L, "Denesik - Romaguera", "₮" },
                    { new Guid("4915937b-0c42-2746-4bbc-1ffce30b138c"), new DateTime(2027, 8, 4, 15, 19, 48, 352, DateTimeKind.Utc).AddTicks(8611), 3252.8600000000001, 39114L, "Monahan, Lind and Trantow", "KM" },
                    { new Guid("494851bf-228d-2f00-7f71-831dd77b420c"), new DateTime(2027, 1, 21, 3, 58, 36, 424, DateTimeKind.Utc).AddTicks(3253), 8059.9300000000003, 82633L, "McKenzie - Mayert", "฿" },
                    { new Guid("4973aa55-0d93-f8bc-3afd-1e71dbc2c3ab"), new DateTime(2027, 7, 29, 1, 35, 49, 394, DateTimeKind.Utc).AddTicks(1252), 5498.4399999999996, 42069L, "Ruecker - Gleichner", "TT$" },
                    { new Guid("4a044a2e-7fdb-9127-a79f-b89b18d922e9"), new DateTime(2027, 7, 15, 17, 44, 59, 151, DateTimeKind.Utc).AddTicks(6067), 3786.9400000000001, 97439L, "Corwin Inc", "$" },
                    { new Guid("4a273331-e5df-306e-d3f0-e55e4fede98b"), new DateTime(2026, 11, 26, 4, 7, 58, 781, DateTimeKind.Utc).AddTicks(8330), 8272.0900000000001, 16415L, "Lebsack LLC", "" },
                    { new Guid("4a2aafd6-8a9a-091c-a922-c182fd80ba95"), new DateTime(2026, 10, 29, 15, 22, 16, 41, DateTimeKind.Utc).AddTicks(5171), 1603.79, 68205L, "Rogahn - Lubowitz", "$" },
                    { new Guid("4a6039e1-f875-2199-a6f1-d1b8d093999b"), new DateTime(2027, 2, 16, 22, 29, 27, 491, DateTimeKind.Utc).AddTicks(6249), 1993.8699999999999, 26582L, "Glover - Crona", "" },
                    { new Guid("4a8cb745-518c-5350-8e31-bf89f435edbd"), new DateTime(2026, 11, 28, 14, 40, 50, 19, DateTimeKind.Utc).AddTicks(4556), 6801.8800000000001, 20327L, "Hyatt - Mraz", "S/." },
                    { new Guid("4a935bb1-8699-0afc-e519-66d8422fc5fb"), new DateTime(2026, 10, 5, 5, 14, 47, 504, DateTimeKind.Utc).AddTicks(386), 8162.1400000000003, 40680L, "Wuckert LLC", "kr" },
                    { new Guid("4abc3dce-940e-09f9-fe6b-0f0f153ebe41"), new DateTime(2027, 7, 5, 20, 8, 29, 264, DateTimeKind.Utc).AddTicks(6460), 515.47000000000003, 65550L, "Braun Group", "" },
                    { new Guid("4adea0fd-4498-0a9a-ee4d-8fabdd1ea6ec"), new DateTime(2026, 10, 7, 8, 43, 30, 440, DateTimeKind.Utc).AddTicks(5582), 6335.2299999999996, 16209L, "Brekke, Schmitt and Wisoky", "" },
                    { new Guid("4b745184-fac8-fb20-0861-0a95fb94ece6"), new DateTime(2027, 4, 14, 14, 52, 18, 536, DateTimeKind.Utc).AddTicks(2143), 8266.0699999999997, 45154L, "Rowe, Thompson and Hoppe", "J$" },
                    { new Guid("4ba1e124-f79a-598c-f3b9-4622ca26503a"), new DateTime(2026, 10, 16, 23, 48, 42, 520, DateTimeKind.Utc).AddTicks(9606), 35.770000000000003, 65280L, "Koss, Mills and Dickinson", "Lt" },
                    { new Guid("4baf5b03-e8d8-b5d4-606a-301f5250ac7d"), new DateTime(2026, 10, 12, 0, 36, 59, 477, DateTimeKind.Utc).AddTicks(7018), 8673.0400000000009, 54481L, "Wyman, Johnson and Zieme", "₩" },
                    { new Guid("4c0440cf-1dd7-afde-2381-f823c0d6cbdf"), new DateTime(2027, 4, 27, 7, 9, 56, 493, DateTimeKind.Utc).AddTicks(6474), 8071.1800000000003, 66493L, "Ondricka LLC", "kn" },
                    { new Guid("4c14d37e-e043-0bad-08f6-dc69904f76ed"), new DateTime(2027, 4, 23, 22, 32, 53, 491, DateTimeKind.Utc).AddTicks(8218), 1815.6900000000001, 2529L, "Purdy - Franecki", "$" },
                    { new Guid("4c891a08-a621-f399-9fea-8df7c32ee496"), new DateTime(2026, 10, 18, 3, 47, 14, 516, DateTimeKind.Utc).AddTicks(6142), 2765.0300000000002, 82852L, "Mayert, Ullrich and Walker", "" },
                    { new Guid("4c9e2a51-8251-ebaf-c059-a4ba12afa526"), new DateTime(2026, 11, 20, 22, 55, 43, 930, DateTimeKind.Utc).AddTicks(6756), 7459.9499999999998, 30737L, "Muller LLC", "" },
                    { new Guid("4cdfb65f-3b99-1947-f735-66edd231e595"), new DateTime(2026, 12, 28, 6, 1, 9, 213, DateTimeKind.Utc).AddTicks(4987), 4284.9799999999996, 59391L, "Torp, Boyer and Rempel", "$" },
                    { new Guid("4d626339-98c9-5491-b8f3-355a15055ef6"), new DateTime(2027, 1, 30, 7, 53, 38, 756, DateTimeKind.Utc).AddTicks(6883), 5570.1800000000003, 91698L, "Schmidt - Douglas", "" },
                    { new Guid("4dc95ec6-324c-e82a-05b7-b205732a26cd"), new DateTime(2027, 1, 29, 0, 36, 8, 866, DateTimeKind.Utc).AddTicks(9975), 3343.7199999999998, 40269L, "Conroy, Schimmel and Franecki", "$" },
                    { new Guid("4de12553-e512-2025-bbb6-1e71088858ff"), new DateTime(2026, 12, 31, 23, 50, 4, 117, DateTimeKind.Utc).AddTicks(3281), 4600.3900000000003, 89735L, "Schaefer, Barrows and Zemlak", "лв" },
                    { new Guid("4e2c529d-9f89-0d77-c9e1-10f1eca339c1"), new DateTime(2027, 1, 15, 19, 31, 0, 316, DateTimeKind.Utc).AddTicks(4965), 6744.6099999999997, 72777L, "Kertzmann Group", "" },
                    { new Guid("4e30b767-4745-b078-62d0-2c28084da8b9"), new DateTime(2027, 1, 23, 18, 0, 31, 531, DateTimeKind.Utc).AddTicks(1330), 2109.4899999999998, 10057L, "O'Hara - Douglas", "R" },
                    { new Guid("4e3eac90-0c65-2055-e455-ffdd47822df5"), new DateTime(2027, 1, 1, 6, 9, 15, 67, DateTimeKind.Utc).AddTicks(896), 3558.6500000000001, 94519L, "Bins - Conn", "B/." },
                    { new Guid("4e4a051d-3a76-7306-c70e-a5d7fe79ec77"), new DateTime(2027, 5, 3, 17, 33, 9, 677, DateTimeKind.Utc).AddTicks(1305), 9041.3099999999995, 33683L, "Okuneva Group", "$" },
                    { new Guid("4e569e56-11aa-c18c-3a36-f1fb805c6d2f"), new DateTime(2027, 1, 16, 2, 11, 45, 410, DateTimeKind.Utc).AddTicks(9242), 2360.3600000000001, 10838L, "D'Amore Inc", "₨" },
                    { new Guid("4e744122-93a7-63a6-a61c-08e65494bae0"), new DateTime(2027, 7, 22, 0, 20, 12, 751, DateTimeKind.Utc).AddTicks(4912), 7641.46, 36245L, "Mann - Hirthe", "" },
                    { new Guid("4e8b01a1-c514-6c94-3f8d-b5e4dc87ffed"), new DateTime(2027, 2, 8, 20, 28, 51, 130, DateTimeKind.Utc).AddTicks(3238), 5583.0799999999999, 8370L, "Wisozk, Sporer and Kuhn", "" },
                    { new Guid("4edaee46-94fe-0a6b-ce5d-f35f4f1d5731"), new DateTime(2026, 12, 27, 18, 34, 14, 14, DateTimeKind.Utc).AddTicks(5351), 174.99000000000001, 14447L, "Schuppe Group", "S/." },
                    { new Guid("4f3d3d01-a91f-1916-b311-bfc5b1576583"), new DateTime(2027, 5, 6, 14, 1, 3, 945, DateTimeKind.Utc).AddTicks(3482), 6582.6099999999997, 2067L, "Swift - Bogan", "ман" },
                    { new Guid("4f90425d-026b-2318-d15e-7fe34a92eb22"), new DateTime(2027, 2, 4, 16, 39, 3, 512, DateTimeKind.Utc).AddTicks(1514), 1368.1900000000001, 96441L, "Volkman Inc", "$" },
                    { new Guid("4f968d73-4d15-cb39-cfe2-aa93825065ae"), new DateTime(2026, 10, 17, 21, 15, 18, 224, DateTimeKind.Utc).AddTicks(9552), 9442.0400000000009, 53299L, "Treutel, Keeling and Kutch", "₦" },
                    { new Guid("4fd8472c-00ae-4e13-e1bc-6cb8d174fc0b"), new DateTime(2026, 8, 28, 1, 37, 11, 165, DateTimeKind.Utc).AddTicks(5420), 8401.5499999999993, 99555L, "Abshire Inc", "" },
                    { new Guid("5047ecdc-6c76-d5fb-4725-14ff70836284"), new DateTime(2027, 4, 11, 14, 54, 26, 701, DateTimeKind.Utc).AddTicks(765), 4840.3299999999999, 82237L, "Erdman - Renner", "Db" },
                    { new Guid("5049287d-a3f4-f481-e6a7-189d9c89e004"), new DateTime(2026, 9, 3, 14, 2, 24, 766, DateTimeKind.Utc).AddTicks(5964), 9144.9799999999996, 89170L, "O'Conner Inc", "" },
                    { new Guid("5094b49d-4877-49ea-9d1a-afd3e4e7e652"), new DateTime(2027, 5, 7, 10, 24, 54, 527, DateTimeKind.Utc).AddTicks(2968), 2256.8000000000002, 94314L, "Roob, Wuckert and Schiller", "₪" },
                    { new Guid("50a5c70f-6095-0dc6-8a7f-a4e863b57fee"), new DateTime(2027, 2, 24, 6, 58, 53, 146, DateTimeKind.Utc).AddTicks(3535), 9489.2399999999998, 20303L, "Murazik - Hagenes", "" },
                    { new Guid("50cbf8be-5e02-7a9f-3c1c-9323ba6b898b"), new DateTime(2027, 5, 12, 1, 6, 58, 40, DateTimeKind.Utc).AddTicks(596), 4981.9099999999999, 18889L, "Streich - Altenwerth", "Ls" },
                    { new Guid("514ff565-9390-56b9-96b6-62ed9d6b4ba9"), new DateTime(2026, 9, 28, 11, 40, 16, 227, DateTimeKind.Utc).AddTicks(4235), 8626.9899999999998, 27477L, "Murazik Group", "Rp" },
                    { new Guid("51e89737-24d7-3b69-7bcd-5aa911c0dda3"), new DateTime(2027, 2, 17, 6, 18, 1, 77, DateTimeKind.Utc).AddTicks(682), 8664.7199999999993, 10706L, "Heaney, Bergstrom and Hermiston", "лв" },
                    { new Guid("51ea2fc5-ecc0-7d63-d26a-d4d183bc96f1"), new DateTime(2026, 11, 7, 16, 59, 0, 89, DateTimeKind.Utc).AddTicks(4394), 9287.7999999999993, 99009L, "Littel, Cummerata and Williamson", "﷼" },
                    { new Guid("51ecf0db-fec3-81a7-4a53-64c5e582601c"), new DateTime(2027, 3, 11, 8, 6, 3, 466, DateTimeKind.Utc).AddTicks(4352), 6883.6599999999999, 48907L, "Champlin, Hettinger and Nitzsche", "" },
                    { new Guid("52248aca-9351-4083-76b4-2ab64cfe41df"), new DateTime(2026, 12, 21, 9, 17, 34, 416, DateTimeKind.Utc).AddTicks(728), 5111.1599999999999, 2220L, "Kirlin, Gleason and Schaefer", "$" },
                    { new Guid("523029cd-b462-e5e5-df76-f8be2ecbcd11"), new DateTime(2026, 11, 3, 0, 50, 15, 325, DateTimeKind.Utc).AddTicks(7059), 3400.8499999999999, 35210L, "Brown Group", "S" },
                    { new Guid("5279d398-5c01-370e-e31c-cc0e2ea6e3d4"), new DateTime(2026, 10, 3, 12, 26, 45, 64, DateTimeKind.Utc).AddTicks(3960), 9572.0799999999999, 64787L, "Bailey - Goldner", "€" },
                    { new Guid("5284e6b2-1cff-e0ae-9973-7c24f52243ad"), new DateTime(2027, 4, 11, 17, 56, 22, 573, DateTimeKind.Utc).AddTicks(760), 1546.0799999999999, 43141L, "Haag - Purdy", "" },
                    { new Guid("53aeb25e-7a55-2b1c-1323-3d39da9b97f6"), new DateTime(2027, 2, 14, 14, 25, 17, 249, DateTimeKind.Utc).AddTicks(70), 8341.4599999999991, 60579L, "Hamill Inc", "" },
                    { new Guid("53d74a8f-c579-2d92-1b37-2e668f926e10"), new DateTime(2027, 5, 14, 13, 14, 57, 519, DateTimeKind.Utc).AddTicks(8144), 1479.26, 70835L, "Bashirian, Schamberger and Langosh", "Kč" },
                    { new Guid("53e27c39-cead-9872-70b1-c024faa7a634"), new DateTime(2027, 5, 5, 0, 51, 42, 329, DateTimeKind.Utc).AddTicks(1144), 4313.2700000000004, 87817L, "Weimann - Okuneva", "RD$" },
                    { new Guid("549aff3f-ce3b-694d-9536-55aeb1bb42fa"), new DateTime(2026, 9, 11, 7, 31, 49, 389, DateTimeKind.Utc).AddTicks(2299), 2157.1199999999999, 92439L, "Zemlak and Sons", "" },
                    { new Guid("549f8c84-f832-a145-c949-f31f8ee1bc20"), new DateTime(2026, 12, 30, 4, 55, 0, 538, DateTimeKind.Utc).AddTicks(7788), 4869.0500000000002, 65903L, "Langworth Inc", "" },
                    { new Guid("556c2374-fc68-fc36-0876-1974cadca54f"), new DateTime(2027, 7, 5, 22, 26, 58, 138, DateTimeKind.Utc).AddTicks(431), 6488.9399999999996, 14184L, "Pouros Group", "" },
                    { new Guid("5578113b-7a87-c248-f029-7b91017456ec"), new DateTime(2027, 8, 3, 10, 36, 41, 496, DateTimeKind.Utc).AddTicks(2427), 9047.3899999999994, 49741L, "Halvorson, Sporer and Turcotte", "" },
                    { new Guid("5594d37b-50b6-c4f1-d56e-89ec83bd958f"), new DateTime(2026, 12, 29, 22, 47, 36, 9, DateTimeKind.Utc).AddTicks(1316), 9411.9200000000001, 63176L, "Thompson Group", "" },
                    { new Guid("55fdfc60-269a-f862-a1d7-0146fe0a6993"), new DateTime(2027, 2, 14, 5, 10, 37, 958, DateTimeKind.Utc).AddTicks(2346), 2524.46, 65071L, "Dare LLC", "" },
                    { new Guid("56093aeb-bb27-d6b6-fb52-19c3319b7a79"), new DateTime(2026, 10, 3, 6, 11, 53, 662, DateTimeKind.Utc).AddTicks(3442), 732.33000000000004, 4959L, "Schultz, Fisher and Keebler", "₨" },
                    { new Guid("56921ced-6356-096d-b02c-ee9aa6af3167"), new DateTime(2026, 12, 28, 3, 24, 45, 880, DateTimeKind.Utc).AddTicks(5001), 7342.1499999999996, 90094L, "Tromp, Lemke and Gerhold", "₨" },
                    { new Guid("56a382e6-3e4c-b31c-01fa-92014e4e3402"), new DateTime(2027, 4, 20, 6, 5, 43, 332, DateTimeKind.Utc).AddTicks(4627), 491.18000000000001, 96577L, "Fay - Johns", "Rp" },
                    { new Guid("57505924-b7a3-c047-7321-cc67430b1584"), new DateTime(2027, 5, 8, 21, 21, 3, 304, DateTimeKind.Utc).AddTicks(9245), 485.56999999999999, 76459L, "Kuhn - Feeney", "" },
                    { new Guid("578ecf58-6ab7-37d4-4517-ee4a61e698f2"), new DateTime(2026, 11, 22, 15, 39, 53, 323, DateTimeKind.Utc).AddTicks(9525), 9509.7000000000007, 64275L, "Klein, Rau and Wilderman", "L" },
                    { new Guid("580d8712-2176-199a-25a7-d46611d45335"), new DateTime(2026, 8, 20, 15, 22, 19, 383, DateTimeKind.Utc).AddTicks(5712), 3690.52, 31661L, "Reichel, Tillman and Greenholt", "£" },
                    { new Guid("58107049-bc28-843f-6389-9d13fd935c22"), new DateTime(2026, 11, 9, 4, 9, 17, 279, DateTimeKind.Utc).AddTicks(8107), 4582.3900000000003, 38738L, "Satterfield - Funk", "£" },
                    { new Guid("584e8c38-bb87-34f1-6afd-a146659cce30"), new DateTime(2027, 4, 26, 4, 10, 54, 952, DateTimeKind.Utc).AddTicks(8303), 2588.3600000000001, 33798L, "Abshire LLC", "ден" },
                    { new Guid("5891faef-1d17-c7da-2253-973744b63e8e"), new DateTime(2027, 3, 9, 23, 6, 3, 294, DateTimeKind.Utc).AddTicks(9115), 5377.7799999999997, 8365L, "Lockman and Sons", "៛" },
                    { new Guid("58f4966f-808c-e6e9-a54c-75ce92970874"), new DateTime(2027, 3, 20, 15, 22, 17, 235, DateTimeKind.Utc).AddTicks(3707), 813.08000000000004, 82202L, "Trantow, Haag and McClure", "ƒ" },
                    { new Guid("5905e046-c6dd-a964-9ad7-6da78ae6952c"), new DateTime(2027, 6, 9, 12, 37, 51, 939, DateTimeKind.Utc).AddTicks(5807), 6102.4099999999999, 61196L, "Mraz - Stehr", "ман" },
                    { new Guid("595cf74b-73ab-08b2-0cb7-f9fe60501abf"), new DateTime(2027, 5, 14, 6, 34, 2, 521, DateTimeKind.Utc).AddTicks(513), 4119.9700000000003, 94453L, "Krajcik, Reynolds and Hessel", "C$" },
                    { new Guid("59a54ec3-ba31-ba24-7d7f-149a356034d4"), new DateTime(2027, 7, 21, 5, 33, 56, 954, DateTimeKind.Utc).AddTicks(2689), 8781.3600000000006, 42372L, "Ziemann and Sons", "" },
                    { new Guid("59a62bfa-ff70-7e92-217a-f8467317468f"), new DateTime(2026, 8, 24, 15, 30, 57, 178, DateTimeKind.Utc).AddTicks(1440), 489.0, 77073L, "O'Kon, Doyle and Crona", "Rp" },
                    { new Guid("59bda653-c5e4-a1de-6fb9-994ca9f3d7a9"), new DateTime(2026, 12, 3, 14, 44, 7, 401, DateTimeKind.Utc).AddTicks(4328), 2367.0900000000001, 56272L, "Spencer, Morar and Medhurst", "£" },
                    { new Guid("59e84080-d52a-2431-34bf-a8cf52e84b14"), new DateTime(2026, 12, 27, 19, 8, 56, 879, DateTimeKind.Utc).AddTicks(911), 4699.1199999999999, 16516L, "Hammes - Schaden", "₩" },
                    { new Guid("5a14f67e-20f5-1faa-ac6b-81490b5b4c93"), new DateTime(2027, 6, 7, 6, 45, 12, 220, DateTimeKind.Utc).AddTicks(1555), 7174.3500000000004, 26984L, "Dibbert Group", "Php" },
                    { new Guid("5ab49097-aa65-6c2b-6e4a-881e9460a817"), new DateTime(2027, 5, 22, 2, 50, 52, 45, DateTimeKind.Utc).AddTicks(6191), 437.13999999999999, 26278L, "Blick, Jacobs and Lesch", "" },
                    { new Guid("5ac2b19b-4a27-7b19-362d-57a099532f51"), new DateTime(2026, 12, 30, 11, 18, 2, 695, DateTimeKind.Utc).AddTicks(6751), 501.05000000000001, 13877L, "Huel - Yost", "kr" },
                    { new Guid("5b6bc9b1-4762-5c73-3615-d6018c1864f9"), new DateTime(2027, 6, 20, 8, 24, 43, 489, DateTimeKind.Utc).AddTicks(9142), 300.37, 30652L, "Prosacco - Waelchi", "₨" },
                    { new Guid("5c9a7856-f631-bc74-698c-119aa2c12e97"), new DateTime(2026, 9, 22, 1, 0, 28, 940, DateTimeKind.Utc).AddTicks(372), 6153.1899999999996, 23200L, "Leuschke, Bernhard and Lubowitz", "$" },
                    { new Guid("5cef2b6e-6fa2-1f81-183c-1ed0780e43f5"), new DateTime(2027, 4, 17, 22, 35, 46, 324, DateTimeKind.Utc).AddTicks(5051), 7337.9899999999998, 9629L, "McKenzie, O'Reilly and Wehner", "" },
                    { new Guid("5cf30e2c-6f81-e0d5-ae2e-50c8cfcd20d0"), new DateTime(2026, 12, 5, 6, 2, 38, 346, DateTimeKind.Utc).AddTicks(9829), 302.00999999999999, 21496L, "Brekke - Mitchell", "Ft" },
                    { new Guid("5da589d1-ac2e-f52a-e821-44c82cd16dd5"), new DateTime(2026, 10, 16, 2, 31, 23, 508, DateTimeKind.Utc).AddTicks(9596), 9036.6800000000003, 45276L, "Haag and Sons", "₡" },
                    { new Guid("5e07c01b-db3b-b674-56d4-2e0c22f85029"), new DateTime(2027, 7, 31, 12, 11, 46, 578, DateTimeKind.Utc).AddTicks(7590), 9496.6900000000005, 39296L, "Toy and Sons", "$" },
                    { new Guid("5e168085-ddc4-34ff-8b4e-1ec53f603866"), new DateTime(2026, 11, 5, 17, 3, 7, 330, DateTimeKind.Utc).AddTicks(7718), 1855.03, 46458L, "Yost Inc", "" },
                    { new Guid("5e43e2e2-febe-2042-d530-f3a551224d24"), new DateTime(2027, 4, 20, 13, 2, 21, 74, DateTimeKind.Utc).AddTicks(1767), 5743.71, 53714L, "Stoltenberg Inc", "" },
                    { new Guid("5e9c06dc-10cd-c2ad-3a22-14d09b7bb6d4"), new DateTime(2026, 9, 18, 16, 39, 43, 124, DateTimeKind.Utc).AddTicks(2320), 1287.05, 33670L, "Pfannerstill and Sons", "Bs" },
                    { new Guid("5ef6f68d-48a7-cc70-ea37-a5fb0a09c6cd"), new DateTime(2027, 5, 16, 14, 38, 44, 488, DateTimeKind.Utc).AddTicks(9960), 7705.0200000000004, 67990L, "Waters LLC", "₱" },
                    { new Guid("5f470508-e6a7-ddbc-6045-a8a8cb9dd641"), new DateTime(2026, 12, 12, 13, 24, 37, 284, DateTimeKind.Utc).AddTicks(3933), 4349.4099999999999, 65214L, "Effertz - Cremin", "" },
                    { new Guid("5f5451a8-5a08-0279-5ae2-c2305d8a234c"), new DateTime(2027, 3, 18, 6, 33, 33, 209, DateTimeKind.Utc).AddTicks(4286), 4955.3900000000003, 16729L, "Beer Group", "kr" },
                    { new Guid("5f5501cc-e22f-fe0b-85e8-475fb5d6f638"), new DateTime(2027, 4, 7, 3, 16, 56, 633, DateTimeKind.Utc).AddTicks(2016), 4961.7700000000004, 28739L, "Upton - Ratke", "" },
                    { new Guid("5fdc4275-fc8b-473d-6209-8d98e008617e"), new DateTime(2027, 4, 6, 23, 20, 53, 113, DateTimeKind.Utc).AddTicks(9656), 7395.1099999999997, 76295L, "West - Quigley", "₴" },
                    { new Guid("601f0ed7-fd66-e036-2f9e-9efe5dfeb80b"), new DateTime(2027, 4, 13, 14, 31, 15, 315, DateTimeKind.Utc).AddTicks(6921), 522.85000000000002, 74679L, "Hilll Inc", "₪" },
                    { new Guid("60bcd444-1be3-fa72-0383-eff37d5c81dc"), new DateTime(2026, 12, 3, 6, 2, 31, 239, DateTimeKind.Utc).AddTicks(8390), 6642.6499999999996, 92879L, "Lowe and Sons", "$" },
                    { new Guid("61de063d-a3e1-395a-7467-d94d0d0cccfd"), new DateTime(2026, 10, 2, 8, 27, 9, 931, DateTimeKind.Utc).AddTicks(7783), 8139.0, 35150L, "Cole - Swift", "₦" },
                    { new Guid("61ee86c1-267c-55ad-76ea-1e8a4896fcde"), new DateTime(2026, 12, 25, 21, 30, 13, 139, DateTimeKind.Utc).AddTicks(244), 2264.5900000000001, 55896L, "Mayer Group", "؋" },
                    { new Guid("620ce4b0-d211-8663-968e-8087fec080ab"), new DateTime(2026, 11, 5, 23, 14, 45, 51, DateTimeKind.Utc).AddTicks(9353), 6545.0200000000004, 19227L, "Zieme Group", "$" },
                    { new Guid("620e1217-caa0-ed7e-bf2b-1b692ef1a560"), new DateTime(2026, 9, 18, 0, 0, 11, 801, DateTimeKind.Utc).AddTicks(2727), 5117.7700000000004, 6963L, "Murazik, Gibson and Mitchell", "" },
                    { new Guid("6245ef83-3e6f-9b79-f66b-85cef57019df"), new DateTime(2027, 6, 3, 16, 33, 36, 988, DateTimeKind.Utc).AddTicks(9947), 3147.1199999999999, 22760L, "Hettinger and Sons", "" },
                    { new Guid("62ba77dc-f56a-3318-0ff0-0acae8c8e2f2"), new DateTime(2026, 8, 18, 20, 15, 55, 951, DateTimeKind.Utc).AddTicks(3390), 8814.0100000000002, 98634L, "Murray, Tremblay and Emmerich", "" },
                    { new Guid("62eafb53-6af2-0fbc-494d-aa9060fcf07b"), new DateTime(2027, 2, 27, 4, 47, 3, 723, DateTimeKind.Utc).AddTicks(1832), 2146.77, 45087L, "Feest, Orn and Beer", "zł" },
                    { new Guid("632ecc57-5b58-c205-4255-8e8cc7c756c0"), new DateTime(2027, 6, 22, 12, 15, 21, 415, DateTimeKind.Utc).AddTicks(4715), 1985.1500000000001, 34654L, "Gutmann and Sons", "" },
                    { new Guid("633be4dd-4b47-392f-8ba8-1c067593d11d"), new DateTime(2027, 5, 25, 11, 8, 22, 825, DateTimeKind.Utc).AddTicks(7019), 3122.3400000000001, 99614L, "Deckow - Vandervort", "$" },
                    { new Guid("635b81a5-8541-8710-3929-28c6f85f57ac"), new DateTime(2026, 9, 7, 22, 54, 48, 162, DateTimeKind.Utc).AddTicks(6562), 2670.5100000000002, 65547L, "Lang, Leuschke and Cruickshank", "B/." },
                    { new Guid("6451f670-d391-79bf-11b3-b94b55299e0b"), new DateTime(2027, 4, 11, 20, 43, 9, 199, DateTimeKind.Utc).AddTicks(3094), 3528.3899999999999, 4892L, "Hodkiewicz and Sons", "MT" },
                    { new Guid("65128b1c-55c8-ecd7-c52d-41f77ca968f5"), new DateTime(2026, 9, 30, 4, 44, 7, 9, DateTimeKind.Utc).AddTicks(7524), 7381.5600000000004, 6389L, "Wehner Group", "" },
                    { new Guid("6512a205-ac2b-d2a5-ba57-a870ee19d1ed"), new DateTime(2026, 9, 7, 16, 21, 57, 674, DateTimeKind.Utc).AddTicks(6614), 4718.0, 4577L, "Deckow Group", "Kč" },
                    { new Guid("65573d6f-6aa3-8a41-3861-58a2a97a6d47"), new DateTime(2027, 5, 16, 4, 22, 40, 728, DateTimeKind.Utc).AddTicks(2121), 8713.3999999999996, 40802L, "Hilpert and Sons", "" },
                    { new Guid("657e26c2-ba34-393d-2e3c-115b2cb8f642"), new DateTime(2027, 3, 2, 9, 3, 29, 392, DateTimeKind.Utc).AddTicks(5353), 840.32000000000005, 57860L, "Kozey - Koch", "Php" },
                    { new Guid("65cf6f9a-3390-0693-f957-fce1ba7411e9"), new DateTime(2027, 3, 16, 22, 51, 0, 872, DateTimeKind.Utc).AddTicks(2281), 9673.8099999999995, 92803L, "Prohaska, Bogisich and Ritchie", "$" },
                    { new Guid("66af9a84-a060-cbc7-e71b-eb0717a98c4d"), new DateTime(2027, 6, 7, 13, 13, 44, 71, DateTimeKind.Utc).AddTicks(1471), 769.74000000000001, 76953L, "Roob - Kuhn", "៛" },
                    { new Guid("66cf419e-cfea-cb6c-81f6-405ca0129ab3"), new DateTime(2027, 1, 4, 7, 6, 24, 956, DateTimeKind.Utc).AddTicks(8240), 4531.3699999999999, 70935L, "Bernhard - Vandervort", "лв" },
                    { new Guid("66f0e326-37f6-43ab-b611-d845e962751c"), new DateTime(2026, 8, 29, 9, 49, 32, 277, DateTimeKind.Utc).AddTicks(6865), 636.03999999999996, 75207L, "Kertzmann, Zulauf and Doyle", "$" },
                    { new Guid("677de6f6-4a3f-9f35-7a53-983c6752417f"), new DateTime(2027, 1, 29, 22, 53, 47, 347, DateTimeKind.Utc).AddTicks(8020), 1315.25, 43757L, "Haag - Stehr", "CHF" },
                    { new Guid("6783acb0-5c9d-25cc-7bbc-29b51df4cafb"), new DateTime(2027, 3, 20, 0, 18, 11, 770, DateTimeKind.Utc).AddTicks(692), 1832.5599999999999, 28439L, "Howe, Hermann and Lindgren", "Дин." },
                    { new Guid("67d803d1-5670-2ae3-fd13-05d40be6fec5"), new DateTime(2027, 8, 4, 8, 12, 22, 305, DateTimeKind.Utc).AddTicks(3991), 1361.5899999999999, 81099L, "Runolfsdottir - O'Hara", "" },
                    { new Guid("688f9624-47cd-e6f0-f804-55fe45e42a09"), new DateTime(2027, 2, 7, 11, 49, 45, 267, DateTimeKind.Utc).AddTicks(4077), 4858.5799999999999, 33505L, "Spinka LLC", "" },
                    { new Guid("68e4b2f7-b4f2-ff89-64a6-5acb8a99d822"), new DateTime(2027, 7, 1, 0, 3, 55, 7, DateTimeKind.Utc).AddTicks(8565), 7428.8400000000001, 76193L, "Langworth, Schowalter and Legros", "лв" },
                    { new Guid("68e9f859-c4bf-0ae9-bdd1-3e30f7b5ab72"), new DateTime(2027, 7, 16, 0, 58, 44, 190, DateTimeKind.Utc).AddTicks(8581), 6583.8000000000002, 27895L, "Pouros, Schmeler and Aufderhar", "₺" },
                    { new Guid("68ebc8c4-1116-a41c-4260-c26819e76a17"), new DateTime(2027, 1, 30, 15, 48, 15, 428, DateTimeKind.Utc).AddTicks(3656), 9146.6399999999994, 39221L, "Fadel and Sons", "Nu" },
                    { new Guid("69527193-d145-00ee-96f8-17de84abaa79"), new DateTime(2026, 11, 9, 2, 21, 50, 557, DateTimeKind.Utc).AddTicks(8807), 6286.1899999999996, 82270L, "Auer - Russel", "₮" },
                    { new Guid("697ec571-772d-7067-8cef-d076d8762936"), new DateTime(2026, 10, 28, 9, 8, 23, 376, DateTimeKind.Utc).AddTicks(9263), 8498.2000000000007, 42846L, "Keebler, Dickinson and Sauer", "руб" },
                    { new Guid("6981617b-d393-9aaa-4d3f-364cb9a28fdb"), new DateTime(2027, 1, 21, 21, 29, 58, 521, DateTimeKind.Utc).AddTicks(4532), 8719.1000000000004, 96072L, "Ondricka - Sporer", "" },
                    { new Guid("698ffed0-32bf-0be9-c641-8a06f761ad60"), new DateTime(2026, 11, 1, 19, 50, 57, 420, DateTimeKind.Utc).AddTicks(3717), 9659.4500000000007, 46724L, "Schaefer, Ankunding and Schinner", "" },
                    { new Guid("69998509-c4f8-b68d-4bce-62cffa0b1327"), new DateTime(2027, 5, 3, 22, 57, 13, 437, DateTimeKind.Utc).AddTicks(8983), 287.69999999999999, 10608L, "Brown - Dooley", "﷼" },
                    { new Guid("69ba779f-7dce-a11b-b353-db0d83ce94b3"), new DateTime(2026, 8, 26, 16, 13, 49, 711, DateTimeKind.Utc).AddTicks(6934), 9782.4099999999999, 64907L, "Mann - Gutmann", "₪" },
                    { new Guid("6a3d69f8-a364-0273-9e59-8dea5c7a93d8"), new DateTime(2027, 3, 8, 13, 12, 40, 423, DateTimeKind.Utc).AddTicks(7936), 8817.2900000000009, 85768L, "Kassulke and Sons", "zł" },
                    { new Guid("6a6cf73c-b971-f87c-3886-ad7e9c848be2"), new DateTime(2026, 11, 15, 14, 22, 53, 421, DateTimeKind.Utc).AddTicks(1052), 7887.8400000000001, 44628L, "Mills - Klein", "" },
                    { new Guid("6b145324-7636-dece-4af8-c58c34374178"), new DateTime(2026, 11, 7, 12, 39, 18, 138, DateTimeKind.Utc).AddTicks(6535), 7484.3599999999997, 47627L, "Bernhard - Batz", "" },
                    { new Guid("6bc317d4-503c-e891-af9a-b40c32aed920"), new DateTime(2027, 4, 21, 11, 48, 42, 275, DateTimeKind.Utc).AddTicks(3581), 4440.6499999999996, 6721L, "Cummings, Kreiger and Ferry", "£" },
                    { new Guid("6be74c4c-38cc-76bd-6f65-6f1fe72fb1f9"), new DateTime(2027, 7, 8, 0, 7, 1, 593, DateTimeKind.Utc).AddTicks(1943), 9763.0200000000004, 36514L, "Borer - Flatley", "" },
                    { new Guid("6c2e6d46-98a5-1752-145b-f0230d42b823"), new DateTime(2026, 8, 12, 3, 24, 40, 108, DateTimeKind.Utc).AddTicks(8956), 8205.7099999999991, 16391L, "O'Conner, Klein and Stracke", "" },
                    { new Guid("6c5781d8-3f56-6ffa-7330-6539d355e3d2"), new DateTime(2026, 8, 7, 12, 59, 23, 363, DateTimeKind.Utc).AddTicks(834), 9979.5, 48127L, "Baumbach - Corkery", "$" },
                    { new Guid("6c85752f-0d0c-8cb6-95f8-6d98987a71f4"), new DateTime(2027, 3, 21, 7, 51, 51, 550, DateTimeKind.Utc).AddTicks(2648), 1818.9400000000001, 59746L, "Bosco - Conn", "" },
                    { new Guid("6ca166e0-3604-265e-b78b-e678232d2f7b"), new DateTime(2026, 10, 12, 11, 49, 16, 431, DateTimeKind.Utc).AddTicks(3606), 8823.0, 68373L, "Barton Group", "kr" },
                    { new Guid("6cc79d56-eb91-500e-cd99-fd782cf363eb"), new DateTime(2026, 11, 24, 13, 42, 11, 38, DateTimeKind.Utc).AddTicks(3098), 4105.7299999999996, 42192L, "Runolfsdottir and Sons", "ман" },
                    { new Guid("6d036538-255f-c002-948f-ab111a1324f0"), new DateTime(2026, 10, 15, 17, 44, 3, 432, DateTimeKind.Utc).AddTicks(4902), 3156.21, 43019L, "Rohan - Hand", "BZ$" },
                    { new Guid("6eb11712-2300-d9f6-26ec-6b78bd9c7502"), new DateTime(2026, 9, 30, 19, 26, 11, 909, DateTimeKind.Utc).AddTicks(4946), 3432.3600000000001, 18054L, "Effertz, Leannon and Ryan", "ƒ" },
                    { new Guid("6ecf02c1-7302-b1fa-5758-449cd5794d7f"), new DateTime(2027, 5, 30, 18, 53, 23, 630, DateTimeKind.Utc).AddTicks(7244), 7747.3699999999999, 81933L, "Kunze - Nolan", "﷼" },
                    { new Guid("6eede5b2-b068-1207-6cd4-fd5fb9668321"), new DateTime(2026, 9, 8, 4, 26, 6, 72, DateTimeKind.Utc).AddTicks(1945), 1507.76, 40955L, "DuBuque - Sipes", "" },
                    { new Guid("6f0d748d-79ec-50b4-f7de-d4685cbf07ce"), new DateTime(2027, 4, 13, 19, 22, 50, 869, DateTimeKind.Utc).AddTicks(4470), 2814.6900000000001, 49094L, "Larson Group", "kr" },
                    { new Guid("6f433763-5cc3-fe8f-4816-061bb50ca37f"), new DateTime(2026, 9, 18, 21, 19, 13, 41, DateTimeKind.Utc).AddTicks(1880), 6524.8599999999997, 26986L, "Macejkovic Inc", "kr" },
                    { new Guid("6f4dc4dd-7bb7-a218-7f2d-4fff44183702"), new DateTime(2027, 5, 19, 3, 0, 24, 440, DateTimeKind.Utc).AddTicks(7954), 2536.25, 34206L, "Jast, Gaylord and Predovic", "£" },
                    { new Guid("6f783fa6-851b-4b45-41e1-1ff644d2ad37"), new DateTime(2027, 4, 11, 9, 39, 8, 241, DateTimeKind.Utc).AddTicks(150), 7343.04, 23147L, "Denesik, Harris and Weimann", "zł" },
                    { new Guid("6fbe0416-02fa-2881-b919-67ff3cb030d3"), new DateTime(2026, 9, 6, 3, 1, 51, 233, DateTimeKind.Utc).AddTicks(2580), 3398.75, 78534L, "Hirthe LLC", "" },
                    { new Guid("704a9fcc-b1bf-fd96-9a46-8180129e0f5f"), new DateTime(2026, 9, 14, 10, 54, 36, 40, DateTimeKind.Utc).AddTicks(4053), 936.32000000000005, 61880L, "Stanton Group", "N$" },
                    { new Guid("70695685-c246-6b68-f055-7457e9d3034d"), new DateTime(2027, 7, 1, 14, 32, 46, 97, DateTimeKind.Utc).AddTicks(8322), 3171.2399999999998, 80183L, "Rodriguez - Hartmann", "Q" },
                    { new Guid("70cd7a50-a386-5d78-24ad-e26bd1b494c4"), new DateTime(2026, 12, 28, 9, 21, 58, 622, DateTimeKind.Utc).AddTicks(6394), 6122.6199999999999, 65186L, "Hills - Aufderhar", "﷼" },
                    { new Guid("7109b1f9-71d8-469b-c5db-61c1c18e9a02"), new DateTime(2026, 10, 22, 3, 39, 30, 5, DateTimeKind.Utc).AddTicks(9271), 2781.0300000000002, 68761L, "Nolan Inc", "NT$" },
                    { new Guid("7121b5ed-6afd-42f4-e8e7-b84af349dadd"), new DateTime(2026, 9, 16, 7, 42, 18, 331, DateTimeKind.Utc).AddTicks(973), 8112.5900000000001, 74706L, "Corwin Group", "" },
                    { new Guid("7162de58-d6d8-2236-4aa1-b95494ce06e6"), new DateTime(2027, 5, 24, 16, 41, 46, 621, DateTimeKind.Utc).AddTicks(6639), 121.94, 29584L, "Mills Group", "₫" },
                    { new Guid("71682572-dc8e-9291-daf0-7dbb6e66d1e8"), new DateTime(2026, 11, 24, 20, 55, 26, 827, DateTimeKind.Utc).AddTicks(1588), 4788.1800000000003, 74799L, "Veum, Roob and O'Connell", "" },
                    { new Guid("721d2709-7069-9c46-eb9e-841374495d8c"), new DateTime(2027, 6, 9, 8, 52, 48, 622, DateTimeKind.Utc).AddTicks(7895), 2754.6199999999999, 32420L, "McCullough LLC", "£" },
                    { new Guid("72373ee7-5554-1577-a4c9-179c77f1e368"), new DateTime(2026, 10, 27, 10, 33, 5, 180, DateTimeKind.Utc).AddTicks(264), 8483.7199999999993, 91469L, "Botsford - Parisian", "R" },
                    { new Guid("723bc740-ddb0-0210-6d53-8be4a5221d93"), new DateTime(2027, 8, 3, 19, 28, 43, 24, DateTimeKind.Utc).AddTicks(1030), 485.91000000000003, 32115L, "Crist LLC", "₦" },
                    { new Guid("726f5f34-c402-23a3-19b8-2d613020d263"), new DateTime(2026, 12, 13, 4, 54, 37, 208, DateTimeKind.Utc).AddTicks(6114), 1647.3199999999999, 56683L, "Kirlin - Blanda", "zł" },
                    { new Guid("72878efa-f877-de5d-3587-ef0949bcce54"), new DateTime(2026, 9, 14, 20, 0, 51, 459, DateTimeKind.Utc).AddTicks(6014), 5664.4499999999998, 93199L, "Jerde - Wyman", "R" },
                    { new Guid("729c5f7f-0c41-9a78-0391-d97b538c5f6c"), new DateTime(2026, 10, 20, 20, 1, 52, 103, DateTimeKind.Utc).AddTicks(8406), 9810.8700000000008, 46272L, "Schamberger LLC", "$" },
                    { new Guid("72aa5734-aa29-9dea-dee3-6cf0217e5444"), new DateTime(2026, 9, 20, 14, 27, 31, 548, DateTimeKind.Utc).AddTicks(7805), 4233.9300000000003, 29838L, "Hayes and Sons", "£" },
                    { new Guid("72c5868f-f6a5-a4cb-8f30-81f86647f08f"), new DateTime(2026, 10, 29, 12, 58, 17, 983, DateTimeKind.Utc).AddTicks(9157), 9302.6100000000006, 40615L, "Kutch LLC", "C$" },
                    { new Guid("72fc1689-4243-7909-792e-2ebb51f31468"), new DateTime(2026, 10, 4, 15, 58, 20, 913, DateTimeKind.Utc).AddTicks(6163), 857.19000000000005, 24701L, "Predovic Group", "£" },
                    { new Guid("73772805-5fdb-0c6e-a3ed-eae485891073"), new DateTime(2026, 8, 28, 11, 40, 54, 326, DateTimeKind.Utc).AddTicks(5841), 6505.5200000000004, 69885L, "Schneider LLC", "$" },
                    { new Guid("738334de-7140-e15a-cdce-c12907eb9000"), new DateTime(2027, 7, 13, 2, 48, 11, 889, DateTimeKind.Utc).AddTicks(8429), 193.97, 63090L, "Kozey Group", "ƒ" },
                    { new Guid("73adf223-56f6-347e-a536-e9f3040cb75b"), new DateTime(2027, 7, 25, 13, 14, 21, 384, DateTimeKind.Utc).AddTicks(8806), 4490.46, 66347L, "Reichert LLC", "" },
                    { new Guid("742f5b0e-a3fb-aefd-2fa7-806007081473"), new DateTime(2027, 4, 28, 13, 37, 9, 356, DateTimeKind.Utc).AddTicks(1278), 6014.2600000000002, 16904L, "Okuneva - Cormier", "$" },
                    { new Guid("748c9721-4ae6-3de2-aeb1-58a01c987803"), new DateTime(2026, 11, 4, 11, 29, 43, 160, DateTimeKind.Utc).AddTicks(3628), 1309.8, 61729L, "Kozey, Grady and Cummings", "" },
                    { new Guid("7586ab60-d6e9-ae6a-d8dd-6c57dc94aa19"), new DateTime(2027, 4, 1, 9, 34, 0, 160, DateTimeKind.Utc).AddTicks(2859), 2974.6999999999998, 18245L, "Jacobs Inc", "ƒ" },
                    { new Guid("758e4d93-4b6e-1a57-27f6-3c395768c793"), new DateTime(2026, 10, 19, 2, 39, 46, 3, DateTimeKind.Utc).AddTicks(5952), 5743.5600000000004, 69236L, "Mayert Inc", "﷼" },
                    { new Guid("764db999-630b-6a20-0713-9931d8a5146d"), new DateTime(2026, 11, 11, 16, 29, 14, 685, DateTimeKind.Utc).AddTicks(8527), 5628.3800000000001, 30770L, "Rogahn - Shields", "" },
                    { new Guid("76ad7da7-ae05-4b45-f088-c5716568a1c2"), new DateTime(2027, 5, 27, 20, 50, 41, 757, DateTimeKind.Utc).AddTicks(5417), 8947.1700000000001, 67873L, "Luettgen - Rohan", "ƒ" },
                    { new Guid("770e744f-2268-83ae-687d-e54e2c324adb"), new DateTime(2026, 9, 9, 14, 36, 33, 700, DateTimeKind.Utc).AddTicks(1918), 7954.3599999999997, 85752L, "Powlowski - Feeney", "$" },
                    { new Guid("776e2ee8-56cc-90de-6080-645ba5f36c03"), new DateTime(2027, 7, 17, 6, 44, 39, 799, DateTimeKind.Utc).AddTicks(3102), 9646.1299999999992, 5348L, "Champlin Inc", "ƒ" },
                    { new Guid("7791281e-9493-7e80-5172-b30dfc3d187d"), new DateTime(2027, 3, 3, 21, 32, 9, 52, DateTimeKind.Utc).AddTicks(2871), 1244.8599999999999, 31923L, "Fadel, Smitham and Schaden", "KM" },
                    { new Guid("77c9b15b-9996-bfea-0c41-f8f8ce6d2f16"), new DateTime(2027, 2, 26, 12, 13, 5, 66, DateTimeKind.Utc).AddTicks(4082), 1669.76, 35912L, "Steuber, Dietrich and Nitzsche", "Db" },
                    { new Guid("77e958a1-e4fd-79e5-82aa-4106e329d69e"), new DateTime(2026, 9, 9, 6, 35, 21, 624, DateTimeKind.Utc).AddTicks(9775), 5913.8199999999997, 49107L, "Wunsch, Lynch and Leffler", "" },
                    { new Guid("787c8aa1-2606-a4cc-6745-7f680e6f9763"), new DateTime(2026, 11, 21, 8, 6, 36, 825, DateTimeKind.Utc).AddTicks(544), 2185.8899999999999, 35929L, "Okuneva, Beer and Rath", "" },
                    { new Guid("78e1786f-1b1f-113d-4df2-e2ed869a66de"), new DateTime(2027, 4, 17, 16, 53, 53, 787, DateTimeKind.Utc).AddTicks(2402), 7449.1599999999999, 87094L, "Reichel Group", "Kč" },
                    { new Guid("7923f155-7475-0544-f539-d874b6522db9"), new DateTime(2026, 11, 6, 4, 41, 52, 138, DateTimeKind.Utc).AddTicks(5713), 2195.6700000000001, 89324L, "Jast Inc", "" },
                    { new Guid("797773e5-d85e-a39a-e373-544782c17dcc"), new DateTime(2027, 2, 14, 3, 26, 49, 249, DateTimeKind.Utc).AddTicks(4184), 913.24000000000001, 95687L, "Lang, Kub and Kemmer", "₹" },
                    { new Guid("79c7e715-99d1-e199-dd7a-6e71fe21489f"), new DateTime(2026, 11, 18, 2, 21, 30, 969, DateTimeKind.Utc).AddTicks(167), 6186.1800000000003, 8927L, "Jacobson LLC", "" },
                    { new Guid("7a5feaa0-b4b8-0f23-6514-cf81b3535da7"), new DateTime(2026, 10, 19, 2, 31, 24, 576, DateTimeKind.Utc).AddTicks(2035), 3603.8299999999999, 52507L, "Hahn, Daugherty and Grimes", "$" },
                    { new Guid("7a950357-7c5f-754c-67d9-c2de2969ba9d"), new DateTime(2027, 5, 12, 11, 32, 14, 489, DateTimeKind.Utc).AddTicks(6048), 1760.96, 28202L, "Fahey and Sons", "₨" },
                    { new Guid("7add9f28-b60f-3891-1e42-c16faddac4c8"), new DateTime(2026, 8, 22, 7, 50, 15, 223, DateTimeKind.Utc).AddTicks(8471), 3550.5999999999999, 91366L, "Wilderman, Bechtelar and Williamson", "$" },
                    { new Guid("7b3d93f1-e528-6992-a216-08e1d0e17463"), new DateTime(2026, 11, 23, 14, 33, 16, 831, DateTimeKind.Utc).AddTicks(6263), 8205.1599999999999, 17493L, "Wuckert, O'Kon and Rodriguez", "₡" },
                    { new Guid("7b65970f-c5fe-a15c-8a76-80326c661192"), new DateTime(2027, 4, 9, 10, 52, 59, 738, DateTimeKind.Utc).AddTicks(6507), 872.97000000000003, 85877L, "Nader Group", "₮" },
                    { new Guid("7b88b6e3-49c6-7693-6e5a-b3a4ac54c94b"), new DateTime(2026, 9, 15, 20, 26, 28, 99, DateTimeKind.Utc).AddTicks(5748), 889.51999999999998, 35026L, "Rau, Friesen and Pagac", "" },
                    { new Guid("7bc4b4e2-0737-64c9-ef18-60086b5a5a49"), new DateTime(2027, 2, 21, 4, 56, 2, 902, DateTimeKind.Utc).AddTicks(7021), 6658.1800000000003, 29662L, "Howe, Graham and Hegmann", "£" },
                    { new Guid("7bc67a5e-fca8-4e2b-7e8c-7da1c396aad1"), new DateTime(2026, 11, 14, 11, 10, 50, 293, DateTimeKind.Utc).AddTicks(7148), 8619.3199999999997, 98281L, "Borer Group", "£" },
                    { new Guid("7c2cd407-3ec5-db6a-0c02-5fae9d0a2a9d"), new DateTime(2027, 4, 17, 2, 47, 11, 344, DateTimeKind.Utc).AddTicks(212), 289.50999999999999, 52663L, "Ferry LLC", "RD$" },
                    { new Guid("7c6ec265-a979-5628-948e-61234b2ff715"), new DateTime(2026, 12, 11, 19, 13, 22, 401, DateTimeKind.Utc).AddTicks(5910), 5231.3199999999997, 41127L, "Ledner - Rice", "₨" },
                    { new Guid("7c7cc5b0-4683-3238-2814-faa402216854"), new DateTime(2026, 12, 17, 11, 6, 0, 524, DateTimeKind.Utc).AddTicks(3616), 7775.6300000000001, 21268L, "Wyman, Rolfson and Kerluke", "" },
                    { new Guid("7ca7bb2d-223d-0a84-3f51-2505f534972e"), new DateTime(2026, 10, 17, 10, 42, 24, 941, DateTimeKind.Utc).AddTicks(2793), 7536.5200000000004, 3001L, "Kuhn - Rosenbaum", "лв" },
                    { new Guid("7cb0e247-0e0f-a91d-7910-5f6107248d67"), new DateTime(2026, 12, 16, 5, 49, 48, 489, DateTimeKind.Utc).AddTicks(3086), 7685.1499999999996, 47186L, "Mosciski, Jacobs and Parker", "" },
                    { new Guid("7cedf93a-1841-58a4-fc6b-0894076d6924"), new DateTime(2027, 5, 23, 4, 39, 42, 97, DateTimeKind.Utc).AddTicks(460), 2915.9499999999998, 84280L, "Prosacco, Windler and Corwin", "₡" },
                    { new Guid("7d6aed4a-d35a-e21d-8237-817d75006b38"), new DateTime(2026, 9, 7, 20, 19, 9, 616, DateTimeKind.Utc).AddTicks(5574), 81.409999999999997, 49221L, "Parisian LLC", "Дин." },
                    { new Guid("7dea9d8e-27e8-716d-0d56-b621e672b357"), new DateTime(2026, 8, 23, 0, 43, 58, 162, DateTimeKind.Utc).AddTicks(2235), 242.15000000000001, 28265L, "Botsford Group", "Q" },
                    { new Guid("7e27679f-f93b-5251-0350-e12fc13cf2a1"), new DateTime(2026, 11, 20, 16, 10, 4, 309, DateTimeKind.Utc).AddTicks(3069), 826.36000000000001, 7698L, "Kuphal, Murphy and Koelpin", "$" },
                    { new Guid("7e40cc4c-95c8-c9a1-4505-09350abc09de"), new DateTime(2027, 5, 7, 19, 0, 18, 342, DateTimeKind.Utc).AddTicks(6432), 8585.9599999999991, 68703L, "Bosco, Koelpin and Howe", "$" },
                    { new Guid("7eb2f8c9-32c3-8abc-1428-bc53958ae242"), new DateTime(2027, 3, 28, 3, 48, 22, 116, DateTimeKind.Utc).AddTicks(4223), 6814.1300000000001, 58417L, "Rogahn - Maggio", "" },
                    { new Guid("7eda15a9-0941-0fb4-b288-f3c3c860b0f2"), new DateTime(2027, 5, 9, 10, 10, 59, 561, DateTimeKind.Utc).AddTicks(9473), 8438.4300000000003, 33327L, "Muller, Hermiston and Tremblay", "£" },
                    { new Guid("7ee3ba41-6e30-5b5d-530b-1f01138ed898"), new DateTime(2026, 9, 1, 7, 30, 31, 701, DateTimeKind.Utc).AddTicks(1704), 192.80000000000001, 39978L, "Muller - Heathcote", "" },
                    { new Guid("7f7b8b30-da64-8d03-cd3b-f143246f1eab"), new DateTime(2026, 10, 8, 4, 3, 24, 144, DateTimeKind.Utc).AddTicks(8527), 2898.4699999999998, 63753L, "Schmeler, Cartwright and Robel", "" },
                    { new Guid("7f7bcd5c-27b6-8036-df88-17c5c37186a0"), new DateTime(2027, 3, 27, 1, 42, 4, 420, DateTimeKind.Utc).AddTicks(991), 6959.1199999999999, 24803L, "Bosco LLC", "$" },
                    { new Guid("7f8bc6c5-f809-8e8b-91ec-29382826903b"), new DateTime(2027, 2, 4, 10, 41, 9, 700, DateTimeKind.Utc).AddTicks(4991), 8889.8099999999995, 91246L, "Willms Inc", "$" },
                    { new Guid("7f8d07a9-ff0e-6273-3ad1-7503ce630965"), new DateTime(2026, 11, 8, 8, 8, 49, 805, DateTimeKind.Utc).AddTicks(2878), 3808.8800000000001, 88958L, "Beatty Group", "" },
                    { new Guid("7febb202-27b4-3563-011f-df7c92893304"), new DateTime(2026, 10, 26, 4, 59, 38, 399, DateTimeKind.Utc).AddTicks(9645), 9508.2600000000002, 17625L, "Pacocha, Nitzsche and Beatty", "L" },
                    { new Guid("808710af-8bea-0d74-46c2-3a462692b74b"), new DateTime(2027, 7, 8, 22, 56, 23, 454, DateTimeKind.Utc).AddTicks(8837), 7671.8599999999997, 58478L, "Padberg - Feeney", "kr" },
                    { new Guid("80a657a1-0dda-401e-db18-f429324c8953"), new DateTime(2026, 11, 10, 7, 28, 38, 144, DateTimeKind.Utc).AddTicks(1020), 1053.55, 54757L, "Kuhlman - Mueller", "" },
                    { new Guid("80e9e922-2468-cafe-820b-a7e2aa0a52f9"), new DateTime(2026, 10, 23, 20, 24, 13, 861, DateTimeKind.Utc).AddTicks(4812), 3939.04, 18602L, "Klocko - Breitenberg", "kr" },
                    { new Guid("80f40112-ce90-0fb7-8baa-f40d2c52f955"), new DateTime(2027, 2, 23, 0, 46, 26, 783, DateTimeKind.Utc).AddTicks(4310), 8467.3999999999996, 26096L, "Kling - Hermann", "₭" },
                    { new Guid("818a85a1-9e56-bc7f-eacf-768164104fce"), new DateTime(2027, 2, 7, 18, 29, 47, 316, DateTimeKind.Utc).AddTicks(75), 5712.6700000000001, 13384L, "Hauck LLC", "Nu" },
                    { new Guid("8297207f-0f66-fcdd-d3cb-132b3ef45254"), new DateTime(2027, 3, 18, 13, 58, 2, 375, DateTimeKind.Utc).AddTicks(1945), 7712.2399999999998, 75203L, "Mayert Group", "kr" },
                    { new Guid("829f054b-1395-d466-2b01-e1fb1245f6ec"), new DateTime(2026, 12, 20, 23, 16, 21, 846, DateTimeKind.Utc).AddTicks(1477), 6691.25, 2483L, "Okuneva - Hansen", "$" },
                    { new Guid("82fbe353-dfb7-941d-8702-b89b72a8f03e"), new DateTime(2026, 10, 22, 19, 24, 27, 876, DateTimeKind.Utc).AddTicks(3970), 6295.1599999999999, 76367L, "Klocko, Christiansen and Hayes", "Bs" },
                    { new Guid("83aaf209-aafe-aea4-4524-6ee383b51630"), new DateTime(2026, 9, 18, 14, 11, 12, 134, DateTimeKind.Utc).AddTicks(6882), 4204.1499999999996, 68877L, "Aufderhar - Casper", "" },
                    { new Guid("83d0dc7e-d18c-5790-2198-8918a475ba6c"), new DateTime(2026, 10, 26, 5, 10, 33, 237, DateTimeKind.Utc).AddTicks(9255), 5756.7799999999997, 89525L, "Weber, Okuneva and Armstrong", "" },
                    { new Guid("83d28f09-8c39-ba1e-f746-a251196fd7a6"), new DateTime(2027, 5, 30, 20, 9, 41, 552, DateTimeKind.Utc).AddTicks(7139), 3978.98, 15328L, "Torp, Hoeger and Tillman", "" },
                    { new Guid("847067fd-f794-e1ba-b2c8-ef153eb08382"), new DateTime(2027, 6, 25, 20, 16, 10, 717, DateTimeKind.Utc).AddTicks(7590), 8532.6700000000001, 71068L, "Donnelly, Crona and Glover", "lei" },
                    { new Guid("851c563c-0e07-2836-7390-a82028ca7882"), new DateTime(2026, 8, 21, 3, 30, 0, 162, DateTimeKind.Utc).AddTicks(9331), 7778.71, 94221L, "Pollich, Hagenes and Lakin", "C$" },
                    { new Guid("85694c21-0756-ff48-7280-523e6a8896ca"), new DateTime(2027, 3, 4, 4, 26, 52, 640, DateTimeKind.Utc).AddTicks(5669), 1505.8699999999999, 4861L, "Bogan, Mills and Adams", "" },
                    { new Guid("858983d3-b101-cc1b-cecb-d2b0d0bee1ba"), new DateTime(2026, 12, 26, 10, 51, 43, 841, DateTimeKind.Utc).AddTicks(5845), 7920.5699999999997, 29187L, "Watsica, Thompson and Sanford", "" },
                    { new Guid("85b28c26-1977-5e01-d1dc-6b4345be1da6"), new DateTime(2027, 5, 21, 21, 38, 22, 348, DateTimeKind.Utc).AddTicks(9882), 908.63999999999999, 49229L, "Russel, Hilpert and Lueilwitz", "$" },
                    { new Guid("85d8fb21-5dee-f271-af5d-0bd0ca7b2678"), new DateTime(2026, 11, 10, 0, 17, 48, 767, DateTimeKind.Utc).AddTicks(3072), 9519.8400000000001, 68625L, "Jacobi, Jenkins and Tremblay", "S" },
                    { new Guid("85db2b88-2881-a0a4-0046-f9d343b80c13"), new DateTime(2027, 6, 10, 14, 40, 24, 312, DateTimeKind.Utc).AddTicks(6193), 6070.21, 30513L, "Ortiz, Barton and Morar", "TT$" },
                    { new Guid("85fd3660-ed05-0fe8-dee3-fed08859296b"), new DateTime(2027, 2, 23, 19, 56, 28, 13, DateTimeKind.Utc).AddTicks(2365), 9748.1700000000001, 88896L, "Walter, Johnston and Green", "៛" },
                    { new Guid("86af31ad-ae89-0651-41da-d134a50e5e92"), new DateTime(2026, 10, 26, 5, 32, 36, 272, DateTimeKind.Utc).AddTicks(6337), 120.20999999999999, 34193L, "Goodwin Inc", "$" },
                    { new Guid("86bd21f7-62c5-e43c-b8d4-b13d99dc427a"), new DateTime(2027, 7, 27, 15, 55, 9, 244, DateTimeKind.Utc).AddTicks(9993), 3329.8400000000001, 91273L, "Hintz - Raynor", "₨" },
                    { new Guid("8729c15b-c045-0910-828a-3aeede4f676a"), new DateTime(2026, 9, 8, 20, 44, 14, 255, DateTimeKind.Utc).AddTicks(2331), 6090.9499999999998, 1271L, "Bradtke - Jones", "" },
                    { new Guid("8759b792-a317-ce24-d32c-f20f8f1e26fe"), new DateTime(2027, 7, 2, 21, 51, 24, 928, DateTimeKind.Utc).AddTicks(5897), 5776.5600000000004, 29788L, "Gusikowski, Leannon and Ziemann", "Rp" },
                    { new Guid("87adf735-aa02-8899-7f40-2c257240263b"), new DateTime(2026, 8, 28, 22, 2, 43, 107, DateTimeKind.Utc).AddTicks(7304), 6198.9300000000003, 91242L, "Grady, Fay and Lemke", "" },
                    { new Guid("887513a8-b98a-2618-0dc6-1c728735631c"), new DateTime(2026, 8, 15, 15, 19, 24, 726, DateTimeKind.Utc).AddTicks(9826), 2044.77, 28284L, "Dare, Connelly and Wilderman", "" },
                    { new Guid("88ca3f1b-658c-056a-3913-baa334e622bd"), new DateTime(2026, 10, 12, 16, 9, 28, 883, DateTimeKind.Utc).AddTicks(5771), 2820.0599999999999, 54831L, "Donnelly - Rohan", "R$" },
                    { new Guid("89ad7380-3ed0-ab7b-c529-0c7e724e2d6a"), new DateTime(2027, 1, 15, 8, 24, 26, 222, DateTimeKind.Utc).AddTicks(3836), 4970.71, 67361L, "Hayes - Wisoky", "¥" },
                    { new Guid("89c069ec-a0c6-2092-bd6e-dc8df2077345"), new DateTime(2026, 11, 23, 13, 24, 25, 240, DateTimeKind.Utc).AddTicks(2004), 3119.1799999999998, 81664L, "Jacobs - Kemmer", "" },
                    { new Guid("8a4d1ca6-ad7e-9807-bdef-148439e2afe2"), new DateTime(2027, 7, 19, 11, 21, 10, 192, DateTimeKind.Utc).AddTicks(1929), 2752.4400000000001, 66791L, "Jacobs LLC", "лв" },
                    { new Guid("8aa1cca8-5df0-8614-0d72-9dec3127e8e0"), new DateTime(2027, 7, 19, 0, 59, 48, 48, DateTimeKind.Utc).AddTicks(7795), 5049.7399999999998, 33616L, "Pfannerstill Inc", "؋" },
                    { new Guid("8ba09c5c-bb39-8643-b266-43b4f9b2cf26"), new DateTime(2026, 8, 15, 8, 25, 14, 141, DateTimeKind.Utc).AddTicks(8827), 7656.5900000000001, 16368L, "Kiehn, Pollich and Moen", "" },
                    { new Guid("8bcca438-14fb-1a32-2618-efa645060f00"), new DateTime(2027, 4, 25, 22, 10, 49, 823, DateTimeKind.Utc).AddTicks(5093), 6934.9300000000003, 38945L, "Gorczany, Keebler and Cole", "Php" },
                    { new Guid("8c2457d9-9a82-1ca7-5695-45a40a58a512"), new DateTime(2026, 8, 30, 14, 11, 42, 41, DateTimeKind.Utc).AddTicks(8716), 7881.9799999999996, 10959L, "Emmerich Group", "$" },
                    { new Guid("8d2ff505-b6bb-1d68-f674-fbadcde9c406"), new DateTime(2026, 12, 17, 23, 17, 55, 771, DateTimeKind.Utc).AddTicks(5310), 4508.6199999999999, 82051L, "Bruen LLC", "" },
                    { new Guid("8d631367-03a3-9b62-f12f-018eeb17412b"), new DateTime(2027, 8, 2, 7, 22, 50, 855, DateTimeKind.Utc).AddTicks(1874), 9785.7099999999991, 17728L, "Dietrich, O'Connell and Steuber", "S/." },
                    { new Guid("8e113de7-0eb8-4fdf-8798-4b50d5a8029a"), new DateTime(2027, 1, 11, 2, 59, 49, 330, DateTimeKind.Utc).AddTicks(2683), 3157.8400000000001, 55928L, "Wolff Group", "$U" },
                    { new Guid("8e22d1f6-c6e3-5721-ae89-ef91421c74ea"), new DateTime(2026, 9, 26, 0, 30, 0, 337, DateTimeKind.Utc).AddTicks(5700), 4260.3100000000004, 41242L, "Bahringer - Hagenes", "лв" },
                    { new Guid("8e5b7dd0-be3a-1a88-da94-c8a439a27307"), new DateTime(2027, 7, 8, 22, 5, 49, 923, DateTimeKind.Utc).AddTicks(9008), 1457.79, 15200L, "Kuhn - Klocko", "MT" },
                    { new Guid("8e7bb3bd-e6df-c8e5-f346-bbb05d8f34cd"), new DateTime(2027, 4, 18, 23, 49, 45, 742, DateTimeKind.Utc).AddTicks(9169), 2230.46, 44230L, "Nienow - Fisher", "៛" },
                    { new Guid("8ecbd1a2-d125-2e12-7a91-c2a406009634"), new DateTime(2027, 3, 29, 22, 26, 32, 826, DateTimeKind.Utc).AddTicks(6863), 7055.1099999999997, 8690L, "O'Hara, Spinka and Purdy", "zł" },
                    { new Guid("8efa5a7b-ce47-3465-dac2-ff054acca366"), new DateTime(2027, 6, 20, 13, 5, 11, 252, DateTimeKind.Utc).AddTicks(5657), 8667.9799999999996, 75284L, "King Inc", "﷼" },
                    { new Guid("8fa11d57-e62a-5a62-c947-dea6503e9475"), new DateTime(2027, 3, 12, 18, 48, 45, 815, DateTimeKind.Utc).AddTicks(1075), 2705.73, 59082L, "Hilpert and Sons", "" },
                    { new Guid("8fadb88f-9961-cdf8-024b-e89bf1bd81c9"), new DateTime(2027, 2, 13, 22, 54, 56, 974, DateTimeKind.Utc).AddTicks(1766), 649.63, 68279L, "Bashirian - Aufderhar", "$" },
                    { new Guid("9004ebdd-b4c6-2e3e-a513-3450af2e88fa"), new DateTime(2027, 5, 4, 9, 59, 21, 819, DateTimeKind.Utc).AddTicks(779), 9310.5, 89367L, "Davis, Rippin and Kohler", "Kč" },
                    { new Guid("908e9eae-14e1-ceb7-1a68-ebbab7df7f87"), new DateTime(2027, 2, 14, 13, 31, 58, 903, DateTimeKind.Utc).AddTicks(8738), 6478.8599999999997, 36680L, "Hand Inc", "$" },
                    { new Guid("90f73a51-a245-fc49-a78a-8f363d84f43c"), new DateTime(2027, 7, 29, 0, 28, 29, 805, DateTimeKind.Utc).AddTicks(1936), 8383.5799999999999, 27047L, "Lemke - Larkin", "BZ$" },
                    { new Guid("91acf1d4-0d1c-be73-2cd3-2d5a6a038621"), new DateTime(2027, 7, 18, 17, 28, 38, 929, DateTimeKind.Utc).AddTicks(8425), 1563.1099999999999, 77248L, "Ward, Cronin and Tremblay", "лв" },
                    { new Guid("91e6fa93-6694-3a8c-4820-72ef4a39afc5"), new DateTime(2027, 2, 21, 3, 38, 22, 475, DateTimeKind.Utc).AddTicks(8594), 3658.4400000000001, 96856L, "Gaylord, Wyman and Muller", "$" },
                    { new Guid("924c659d-72e8-82ae-9219-6ded0ede25d7"), new DateTime(2027, 1, 2, 8, 45, 12, 277, DateTimeKind.Utc).AddTicks(8217), 5853.5699999999997, 14071L, "Bergnaum - Runolfsdottir", "" },
                    { new Guid("92e71f42-6593-0377-ecb6-0dac597cf962"), new DateTime(2027, 4, 20, 2, 59, 57, 254, DateTimeKind.Utc).AddTicks(6846), 2831.8899999999999, 56347L, "Dach, Kirlin and Schimmel", "ƒ" },
                    { new Guid("930bf532-7da5-a5ed-0935-836294c2a673"), new DateTime(2027, 6, 25, 22, 12, 23, 869, DateTimeKind.Utc).AddTicks(3101), 679.39999999999998, 21920L, "Donnelly - Dibbert", "kr" },
                    { new Guid("9347602b-3128-7741-7693-2b9bd742c977"), new DateTime(2027, 2, 25, 11, 43, 39, 88, DateTimeKind.Utc).AddTicks(7494), 326.64999999999998, 50094L, "Wunsch, Mann and Witting", "L" },
                    { new Guid("93737a0a-7088-0588-d276-af9164b9a99f"), new DateTime(2027, 4, 21, 6, 58, 57, 666, DateTimeKind.Utc).AddTicks(773), 392.32999999999998, 36540L, "Goodwin Group", "£" },
                    { new Guid("9437f1d7-6887-a74e-c0a8-6bb91e6feb07"), new DateTime(2026, 9, 28, 5, 18, 15, 896, DateTimeKind.Utc).AddTicks(4107), 6337.6199999999999, 83591L, "Stiedemann Inc", "£" },
                    { new Guid("943a91d9-c01d-8cde-b046-846849ecd4d1"), new DateTime(2026, 8, 13, 7, 28, 28, 747, DateTimeKind.Utc).AddTicks(4148), 610.49000000000001, 55054L, "Bins Inc", "$" },
                    { new Guid("9463ef3d-09ca-e554-4cc8-590e2f7e89da"), new DateTime(2026, 12, 15, 1, 20, 25, 639, DateTimeKind.Utc).AddTicks(6881), 7890.6999999999998, 58665L, "Bernier, Farrell and Thompson", "₹" },
                    { new Guid("947516b0-cd39-7ec5-0e39-d128ac860d9a"), new DateTime(2027, 1, 26, 9, 39, 18, 991, DateTimeKind.Utc).AddTicks(7721), 7996.79, 28068L, "Dach, Hayes and Collier", "$" },
                    { new Guid("94901c90-3747-3c9c-8220-8d53ff41c4a0"), new DateTime(2026, 9, 26, 23, 2, 28, 303, DateTimeKind.Utc).AddTicks(4047), 4804.0, 78183L, "Walsh, Heller and Hermiston", "Ls" },
                    { new Guid("949df5ca-5c66-7641-52db-03532e5fdd27"), new DateTime(2027, 3, 20, 13, 49, 31, 332, DateTimeKind.Utc).AddTicks(6929), 7483.8900000000003, 90487L, "Daniel, Erdman and Kohler", "" },
                    { new Guid("949f743a-0795-5cd2-00c5-249635dc94ba"), new DateTime(2026, 11, 4, 13, 22, 36, 491, DateTimeKind.Utc).AddTicks(9133), 2854.1199999999999, 32425L, "Crooks, Weissnat and Spencer", "S" },
                    { new Guid("9505ae28-6f89-9425-1d93-2cf071a9fe6f"), new DateTime(2026, 11, 2, 11, 43, 30, 601, DateTimeKind.Utc).AddTicks(8193), 944.40999999999997, 62830L, "Dickens LLC", "" },
                    { new Guid("9589582d-d3a9-8174-40fc-09fa80534f84"), new DateTime(2026, 10, 22, 19, 49, 35, 223, DateTimeKind.Utc).AddTicks(9618), 3568.3099999999999, 33128L, "Legros, Bailey and Schmeler", "Q" },
                    { new Guid("959e5ad4-f3dc-6dc2-eb92-64742fb3a3f9"), new DateTime(2026, 9, 13, 0, 24, 52, 813, DateTimeKind.Utc).AddTicks(9426), 9924.2800000000007, 40848L, "Gutmann and Sons", "KM" },
                    { new Guid("95c2add7-8dcc-5d1c-5880-4037688cdba1"), new DateTime(2027, 4, 30, 12, 47, 32, 573, DateTimeKind.Utc).AddTicks(795), 8757.9799999999996, 48166L, "Mertz, Hammes and Bartell", "$" },
                    { new Guid("95d21676-c147-0ea9-a05b-4f62e524eba6"), new DateTime(2027, 3, 4, 10, 50, 13, 100, DateTimeKind.Utc).AddTicks(6017), 5541.1599999999999, 6892L, "McLaughlin, Johnston and Hane", "" },
                    { new Guid("95f72f1e-5888-dddb-a65c-902f5a392c88"), new DateTime(2026, 10, 30, 13, 39, 38, 813, DateTimeKind.Utc).AddTicks(7338), 4455.0500000000002, 61526L, "Casper, Gorczany and Harris", "N$" },
                    { new Guid("960371e7-bcba-dc28-cc98-1a7a99e30104"), new DateTime(2027, 5, 31, 23, 23, 35, 989, DateTimeKind.Utc).AddTicks(404), 2013.0899999999999, 20790L, "Donnelly, Wunsch and Armstrong", "₹" },
                    { new Guid("9613c015-ebaa-513f-da8f-dc86cb17ea32"), new DateTime(2027, 1, 9, 19, 39, 32, 986, DateTimeKind.Utc).AddTicks(7484), 9322.1200000000008, 12143L, "Lehner - Douglas", "₨" },
                    { new Guid("9615c9f7-ae57-44dc-8c66-e33af8247aff"), new DateTime(2026, 12, 11, 8, 11, 29, 207, DateTimeKind.Utc).AddTicks(9300), 42.219999999999999, 20200L, "Raynor Inc", "" },
                    { new Guid("962ac3f0-9cd2-733d-6020-dd64e0baaadd"), new DateTime(2027, 6, 12, 5, 21, 18, 917, DateTimeKind.Utc).AddTicks(6736), 2769.04, 1763L, "Miller Inc", "ƒ" },
                    { new Guid("96735af4-56c2-6f9a-0da3-240167ee84b8"), new DateTime(2027, 1, 4, 19, 23, 36, 782, DateTimeKind.Utc).AddTicks(9968), 1356.6099999999999, 72633L, "Bosco - Gusikowski", "Q" },
                    { new Guid("96ad4bbb-f2aa-c443-0be1-77e08132475e"), new DateTime(2027, 1, 19, 17, 31, 32, 804, DateTimeKind.Utc).AddTicks(9958), 3236.0900000000001, 71223L, "Gorczany Group", "ƒ" },
                    { new Guid("96dbf017-f446-1d18-2ea8-88f4158b6d2c"), new DateTime(2027, 1, 24, 19, 40, 28, 914, DateTimeKind.Utc).AddTicks(611), 301.5, 64458L, "Schuppe LLC", "ƒ" },
                    { new Guid("97ccad8d-5540-e3e7-d6da-0dd4e1b0a2b3"), new DateTime(2027, 7, 25, 14, 11, 43, 227, DateTimeKind.Utc).AddTicks(7281), 8731.2399999999998, 34547L, "Mann, Beer and McCullough", "€" },
                    { new Guid("980aa6f4-d6ea-d904-5bf6-99fcc5290817"), new DateTime(2027, 7, 1, 21, 55, 39, 659, DateTimeKind.Utc).AddTicks(2034), 5477.6899999999996, 86770L, "Bartell LLC", "" },
                    { new Guid("986b8f00-b1d1-b105-4422-ea42d685c1d6"), new DateTime(2026, 9, 20, 0, 31, 0, 518, DateTimeKind.Utc).AddTicks(834), 6406.6999999999998, 98185L, "Medhurst, Welch and Stiedemann", "₭" },
                    { new Guid("997b5a65-7530-ec57-dd4e-c83b889f5d4b"), new DateTime(2027, 6, 24, 6, 41, 7, 275, DateTimeKind.Utc).AddTicks(6153), 7392.7399999999998, 60937L, "Hagenes and Sons", "$" },
                    { new Guid("9a1441c2-9338-46c7-3b09-3aa5525715f3"), new DateTime(2027, 7, 17, 16, 9, 35, 537, DateTimeKind.Utc).AddTicks(2855), 4128.4099999999999, 93285L, "Marks, Quitzon and Gleichner", "руб" },
                    { new Guid("9a157133-ffe3-9e46-0fa7-a58ad67ce58c"), new DateTime(2026, 9, 23, 17, 39, 44, 38, DateTimeKind.Utc).AddTicks(8084), 2694.04, 1968L, "Sauer - Terry", "$U" },
                    { new Guid("9a4bcb39-9a34-328f-78ab-476ecb5a7870"), new DateTime(2027, 4, 17, 7, 40, 40, 229, DateTimeKind.Utc).AddTicks(7546), 5250.8800000000001, 84049L, "D'Amore - Kuphal", "P" },
                    { new Guid("9a5cc403-ef45-ce23-c748-e01684b9cc6e"), new DateTime(2026, 11, 18, 17, 46, 36, 771, DateTimeKind.Utc).AddTicks(2472), 5787.8299999999999, 78171L, "Wyman, Franecki and Mayer", "" },
                    { new Guid("9abf5b37-bfce-caa5-2789-a1a3d6560007"), new DateTime(2027, 2, 25, 15, 36, 54, 413, DateTimeKind.Utc).AddTicks(6353), 1234.1400000000001, 36853L, "Hyatt, West and Moore", "" },
                    { new Guid("9ada82a7-e398-1979-8b9a-fda45d29c6d6"), new DateTime(2027, 1, 24, 3, 53, 35, 68, DateTimeKind.Utc).AddTicks(2756), 8405.3700000000008, 92196L, "Koelpin, Rowe and Dietrich", "" },
                    { new Guid("9aec88c2-1f1d-4ed6-4fa7-56fa1a2b2502"), new DateTime(2027, 1, 17, 21, 58, 31, 119, DateTimeKind.Utc).AddTicks(2001), 8132.9799999999996, 2773L, "Koss Inc", "" },
                    { new Guid("9af6bd87-a0b8-3401-1b30-b1912dce1865"), new DateTime(2027, 7, 12, 21, 33, 51, 529, DateTimeKind.Utc).AddTicks(7430), 2112.9299999999998, 84369L, "Hermiston LLC", "Ft" },
                    { new Guid("9b0affca-4610-6f35-08a7-b43be0c83754"), new DateTime(2027, 5, 13, 19, 57, 55, 333, DateTimeKind.Utc).AddTicks(9822), 6707.3999999999996, 45351L, "Flatley, Conroy and Marquardt", "$" },
                    { new Guid("9b1eb4cf-b730-2deb-ed12-1e4fbf25b0d1"), new DateTime(2027, 1, 24, 1, 21, 46, 809, DateTimeKind.Utc).AddTicks(816), 6214.3400000000001, 70049L, "Collier - Renner", "₨" },
                    { new Guid("9b36c093-abac-9176-ca4e-84b82d9448c9"), new DateTime(2026, 10, 18, 5, 39, 36, 264, DateTimeKind.Utc).AddTicks(6741), 4943.1000000000004, 37151L, "Tromp - Nicolas", "" },
                    { new Guid("9bbada9e-f4fd-27da-1503-45dc55700688"), new DateTime(2027, 5, 31, 15, 32, 20, 275, DateTimeKind.Utc).AddTicks(3587), 9144.6399999999994, 51041L, "Okuneva and Sons", "$" },
                    { new Guid("9bd4ef07-ae1e-282d-dae8-8881a02e52ef"), new DateTime(2026, 9, 22, 23, 20, 13, 312, DateTimeKind.Utc).AddTicks(9849), 2863.0799999999999, 76662L, "Tremblay - Morar", "₦" },
                    { new Guid("9c8f5545-307d-da4f-e145-153431157c70"), new DateTime(2026, 9, 8, 16, 6, 49, 718, DateTimeKind.Utc).AddTicks(4434), 1863.5599999999999, 34904L, "Douglas - Bednar", "" },
                    { new Guid("9ca4b0b7-7c36-cfa5-c5ef-5f9095137d3e"), new DateTime(2027, 3, 11, 11, 32, 49, 176, DateTimeKind.Utc).AddTicks(3191), 8125.96, 68545L, "Green Group", "" },
                    { new Guid("9d45c856-2b1b-55a0-1759-f870a2dc1718"), new DateTime(2027, 8, 5, 8, 35, 42, 219, DateTimeKind.Utc).AddTicks(868), 8522.9799999999996, 91627L, "Rodriguez Group", "₪" },
                    { new Guid("9d77bc30-5a1a-b958-2600-272553b4f8f6"), new DateTime(2026, 10, 23, 15, 27, 38, 343, DateTimeKind.Utc).AddTicks(2635), 8128.2799999999997, 99367L, "Brown, Armstrong and Kuhlman", "RD$" },
                    { new Guid("9e761122-893b-bf00-029a-aad26ec6bbc5"), new DateTime(2027, 6, 28, 18, 56, 13, 795, DateTimeKind.Utc).AddTicks(1857), 3590.8499999999999, 56821L, "Jacobson and Sons", "RM" },
                    { new Guid("9e7cdc9a-e7bf-a363-46ca-c7475b79bd43"), new DateTime(2027, 2, 5, 6, 44, 47, 631, DateTimeKind.Utc).AddTicks(4527), 5195.1599999999999, 92020L, "Bechtelar - White", "R$" },
                    { new Guid("9e9f0ca7-3276-122b-a7e4-95d429deaa63"), new DateTime(2027, 6, 7, 5, 37, 2, 255, DateTimeKind.Utc).AddTicks(5577), 8010.3599999999997, 84185L, "Hudson and Sons", "₨" },
                    { new Guid("9f94cc83-e43e-9399-8cf2-baffbcb5d9f1"), new DateTime(2027, 4, 30, 19, 47, 13, 207, DateTimeKind.Utc).AddTicks(5710), 5013.25, 27694L, "O'Hara - Crona", "" },
                    { new Guid("a0265b6d-d90f-145b-b432-4a4157c5c7ae"), new DateTime(2026, 9, 20, 18, 56, 2, 449, DateTimeKind.Utc).AddTicks(6441), 7361.4399999999996, 6795L, "Hoppe - Yost", "" },
                    { new Guid("a0793640-1692-7be9-f968-9343fa6a7490"), new DateTime(2026, 10, 22, 12, 27, 17, 680, DateTimeKind.Utc).AddTicks(6738), 1187.3, 89861L, "Mante - DuBuque", "Nu" },
                    { new Guid("a0ded255-a330-8187-46dc-7df9e6b90d28"), new DateTime(2027, 3, 21, 4, 12, 15, 593, DateTimeKind.Utc).AddTicks(1127), 3708.8299999999999, 8047L, "Kilback, Goldner and Hahn", "$" },
                    { new Guid("a15525b0-7b9b-7f43-a02a-c98e2f922303"), new DateTime(2026, 12, 17, 23, 38, 49, 468, DateTimeKind.Utc).AddTicks(9631), 7650.4399999999996, 11985L, "Collins - Ebert", "$" },
                    { new Guid("a16ba5f9-470e-2c7c-e3fd-1e27de767670"), new DateTime(2027, 4, 18, 19, 30, 52, 788, DateTimeKind.Utc).AddTicks(5583), 2706.6500000000001, 18065L, "Leuschke - Von", "" },
                    { new Guid("a19b0013-9411-562c-315b-db0676022a97"), new DateTime(2027, 7, 14, 17, 46, 2, 148, DateTimeKind.Utc).AddTicks(1276), 1558.7, 58929L, "Stark - Dach", "﷼" },
                    { new Guid("a1a8fcb7-0e7c-4cc1-1784-50a1c3612e8a"), new DateTime(2027, 3, 31, 14, 14, 39, 825, DateTimeKind.Utc).AddTicks(2220), 8948.9200000000001, 96598L, "Ledner, Kemmer and Green", "£" },
                    { new Guid("a1b7c989-7e79-9789-ca08-bef38a0f54ba"), new DateTime(2027, 1, 16, 20, 52, 26, 780, DateTimeKind.Utc).AddTicks(7068), 9384.9300000000003, 6375L, "King, Labadie and Cruickshank", "лв" },
                    { new Guid("a1b89f6c-fd52-0f3b-d593-78f9c70290cb"), new DateTime(2027, 7, 31, 9, 44, 53, 245, DateTimeKind.Utc).AddTicks(2585), 9106.7299999999996, 81413L, "Adams - Witting", "" },
                    { new Guid("a1da595c-a1ea-54ba-2877-175580e676b6"), new DateTime(2026, 9, 17, 23, 29, 26, 645, DateTimeKind.Utc).AddTicks(2442), 8269.8500000000004, 86531L, "Corwin Inc", "" },
                    { new Guid("a1fde1eb-8f00-a610-c1c4-1128e2d3c2e0"), new DateTime(2027, 6, 12, 20, 27, 51, 825, DateTimeKind.Utc).AddTicks(9463), 5495.4099999999999, 51891L, "Johnston and Sons", "" },
                    { new Guid("a217a9f6-31cf-a3a7-2cf6-10e8f637512d"), new DateTime(2026, 10, 15, 22, 12, 10, 375, DateTimeKind.Utc).AddTicks(6255), 1468.74, 75036L, "Howell and Sons", "﷼" },
                    { new Guid("a245b3f7-fc19-0ff2-fc36-98d000676138"), new DateTime(2027, 5, 24, 23, 40, 35, 372, DateTimeKind.Utc).AddTicks(8165), 4589.0699999999997, 39058L, "Bartoletti, Langworth and Lebsack", "kr" },
                    { new Guid("a281d306-4af1-d332-40b6-0d9867bcd7b7"), new DateTime(2027, 4, 6, 0, 34, 40, 360, DateTimeKind.Utc).AddTicks(5448), 3357.48, 35017L, "Mertz LLC", "" },
                    { new Guid("a30b4436-e649-2f91-cd63-a820ab9e8cab"), new DateTime(2026, 12, 17, 0, 54, 26, 713, DateTimeKind.Utc).AddTicks(7178), 9978.8600000000006, 42855L, "Walter Group", "฿" },
                    { new Guid("a33f657e-7f36-561d-9a73-a3fbb211f9a6"), new DateTime(2026, 10, 29, 4, 16, 58, 175, DateTimeKind.Utc).AddTicks(8632), 3082.6500000000001, 22270L, "Hoeger, Schmidt and Monahan", "Ls" },
                    { new Guid("a387c6ac-35b6-3abb-56fb-d3b0fc323bd6"), new DateTime(2026, 9, 18, 0, 9, 22, 349, DateTimeKind.Utc).AddTicks(6982), 7086.4700000000003, 51338L, "Davis - Collins", "Bs" },
                    { new Guid("a465aa7f-6eb8-8d49-6be1-c043aeb76b18"), new DateTime(2026, 12, 29, 22, 56, 28, 171, DateTimeKind.Utc).AddTicks(8306), 8758.5300000000007, 53463L, "Ebert LLC", "$" },
                    { new Guid("a47a25f3-934b-dab6-6b5f-deb9102c0309"), new DateTime(2026, 8, 28, 23, 54, 9, 204, DateTimeKind.Utc).AddTicks(5362), 1178.95, 83475L, "Hermann, Rutherford and Wisozk", "lei" },
                    { new Guid("a49a67c0-6cc0-a35a-6ab3-cc6c0544ba24"), new DateTime(2027, 4, 8, 7, 48, 22, 906, DateTimeKind.Utc).AddTicks(2465), 4619.7600000000002, 83411L, "Kerluke, Yundt and Reynolds", "₱" },
                    { new Guid("a4f70c01-956d-fdb3-a250-8001b561d5ad"), new DateTime(2027, 4, 8, 17, 42, 37, 169, DateTimeKind.Utc).AddTicks(7037), 5547.7299999999996, 5626L, "Keeling - Legros", "L" },
                    { new Guid("a50b205e-3519-7a59-7c4f-ea6d67c1905d"), new DateTime(2027, 7, 9, 2, 52, 45, 471, DateTimeKind.Utc).AddTicks(9826), 8264.0, 94861L, "Gusikowski, Crooks and Nitzsche", "" },
                    { new Guid("a520427d-6744-6bb9-597a-287ca9239d7a"), new DateTime(2027, 3, 5, 8, 46, 21, 664, DateTimeKind.Utc).AddTicks(6261), 9337.9500000000007, 24628L, "Crona - Runolfsdottir", "$" },
                    { new Guid("a52888bb-8184-5374-6b78-92c7f4a1842d"), new DateTime(2026, 11, 13, 11, 14, 26, 172, DateTimeKind.Utc).AddTicks(1088), 9239.6599999999999, 97594L, "Fahey and Sons", "﷼" },
                    { new Guid("a5746b89-c27f-ea2e-1198-d597a5f78c83"), new DateTime(2027, 5, 23, 17, 47, 5, 822, DateTimeKind.Utc).AddTicks(642), 7914.4200000000001, 29013L, "Quigley Inc", "CHF" },
                    { new Guid("a6042ac7-460b-7690-91d6-f510ee6c608f"), new DateTime(2027, 6, 2, 8, 44, 21, 794, DateTimeKind.Utc).AddTicks(3298), 1192.22, 75310L, "Becker - Steuber", "" },
                    { new Guid("a635430f-9616-a0fb-86a9-e56eb377b3d5"), new DateTime(2027, 2, 14, 11, 46, 2, 944, DateTimeKind.Utc).AddTicks(6239), 7613.5500000000002, 54185L, "Kris, Oberbrunner and Kreiger", "" },
                    { new Guid("a67e6716-df1c-bdb4-e5f5-1add50fe936f"), new DateTime(2026, 9, 30, 0, 50, 23, 788, DateTimeKind.Utc).AddTicks(7506), 5881.8199999999997, 39989L, "Pouros, Hartmann and Osinski", "Db" },
                    { new Guid("a696e0df-7ea2-c484-6619-ae3ff9561ec2"), new DateTime(2026, 8, 23, 20, 27, 58, 716, DateTimeKind.Utc).AddTicks(4107), 6621.2299999999996, 71501L, "Glover, Kovacek and Reilly", "Lek" },
                    { new Guid("a6fa7b80-c81d-7c5a-9d2a-4da368b99c85"), new DateTime(2026, 9, 20, 7, 1, 29, 740, DateTimeKind.Utc).AddTicks(5136), 8956.6499999999996, 13211L, "Rogahn and Sons", "₨" },
                    { new Guid("a722be85-c0cc-a964-6518-046b283cb0d6"), new DateTime(2027, 6, 10, 1, 6, 25, 680, DateTimeKind.Utc).AddTicks(4567), 1526.2, 27434L, "Gleason, Runte and Schneider", "Ft" },
                    { new Guid("a7683125-fe80-037c-cd7c-f24d67dbcbe4"), new DateTime(2027, 8, 5, 21, 18, 31, 768, DateTimeKind.Utc).AddTicks(75), 3904.7399999999998, 70686L, "Kessler - Schaden", "₡" },
                    { new Guid("a76d2575-295b-35a2-9a58-43a5a31581ed"), new DateTime(2026, 11, 22, 12, 9, 35, 858, DateTimeKind.Utc).AddTicks(2463), 9794.3999999999996, 30551L, "Wilkinson Group", "" },
                    { new Guid("a7bc317f-b61e-8a78-6f2b-c235b8705150"), new DateTime(2026, 8, 31, 19, 17, 13, 502, DateTimeKind.Utc).AddTicks(2165), 3825.4899999999998, 74519L, "Miller - Bechtelar", "₹" },
                    { new Guid("a7c1c3d8-b286-71bf-1dd0-920336c54f2d"), new DateTime(2026, 9, 23, 8, 45, 26, 934, DateTimeKind.Utc).AddTicks(2640), 1320.8099999999999, 84380L, "Brekke Inc", "$" },
                    { new Guid("a7cf1a10-1d56-29ae-d7fe-a4c81d926981"), new DateTime(2026, 9, 7, 10, 1, 16, 860, DateTimeKind.Utc).AddTicks(4397), 292.83999999999997, 27464L, "Fadel, Hane and Parisian", "лв" },
                    { new Guid("a7eb6c52-5785-0683-84d1-f1591c49b184"), new DateTime(2027, 5, 28, 13, 25, 27, 425, DateTimeKind.Utc).AddTicks(5120), 9604.8199999999997, 3239L, "Mertz, Reinger and Hammes", "" },
                    { new Guid("a7ed51a3-7c28-d8e5-e679-1404df3d2050"), new DateTime(2027, 5, 28, 18, 9, 8, 944, DateTimeKind.Utc).AddTicks(680), 742.53999999999996, 44212L, "Littel - Ullrich", "¥" },
                    { new Guid("a8116ed2-c57e-0e52-dc7d-5c46015a8f0b"), new DateTime(2027, 5, 29, 17, 14, 13, 977, DateTimeKind.Utc).AddTicks(4703), 488.44999999999999, 14655L, "King, Metz and Kunde", "BZ$" },
                    { new Guid("a8291fe4-2a95-1e35-4f18-328e5d28555e"), new DateTime(2027, 7, 3, 10, 50, 23, 532, DateTimeKind.Utc).AddTicks(5540), 4603.3699999999999, 69515L, "O'Kon LLC", "CHF" },
                    { new Guid("a83b535f-7a91-9c9b-ad09-b3228f19c432"), new DateTime(2027, 4, 3, 9, 50, 49, 783, DateTimeKind.Utc).AddTicks(5413), 1934.9200000000001, 62656L, "Dietrich, Trantow and Little", "₭" },
                    { new Guid("a88573ca-5363-dbe3-0df5-8a9728af51a8"), new DateTime(2027, 8, 2, 19, 42, 53, 550, DateTimeKind.Utc).AddTicks(906), 1735.1700000000001, 34818L, "Sauer - Becker", "B/." },
                    { new Guid("a88d4159-a04d-de72-a7cb-c2cbd3abd0b2"), new DateTime(2026, 12, 9, 19, 16, 30, 131, DateTimeKind.Utc).AddTicks(9783), 9845.0900000000001, 94001L, "Wiza Group", "" },
                    { new Guid("a89c00b6-261c-b543-7439-6c1bf8a768fb"), new DateTime(2027, 2, 25, 13, 9, 5, 916, DateTimeKind.Utc).AddTicks(1347), 4588.9099999999999, 39159L, "Boyle, Ruecker and Hoppe", "" },
                    { new Guid("a8f902b8-014c-64ab-5565-7ddfbecb3a78"), new DateTime(2027, 3, 15, 15, 10, 53, 187, DateTimeKind.Utc).AddTicks(981), 3628.25, 44526L, "Bayer Inc", "₨" },
                    { new Guid("a904b606-89d6-e970-854b-86ccea545139"), new DateTime(2026, 11, 11, 6, 23, 17, 432, DateTimeKind.Utc).AddTicks(3725), 619.20000000000005, 1639L, "Gislason - Ledner", "" },
                    { new Guid("a9860a8f-18f1-d5cc-e5a4-af539f85b77c"), new DateTime(2027, 4, 2, 16, 18, 14, 237, DateTimeKind.Utc).AddTicks(5816), 4652.8000000000002, 98927L, "Beatty, Schulist and Will", "₴" },
                    { new Guid("a99bd730-1117-27a2-b29e-e3b428e972f1"), new DateTime(2027, 4, 8, 12, 23, 53, 802, DateTimeKind.Utc).AddTicks(8993), 479.63, 61276L, "Greenholt - Russel", "" },
                    { new Guid("aa201da5-46b2-3597-17ff-bacc1f95e0f0"), new DateTime(2026, 8, 7, 4, 53, 27, 61, DateTimeKind.Utc).AddTicks(1173), 8483.9099999999999, 69056L, "Wisozk, Gutmann and Jacobs", "£" },
                    { new Guid("aa735279-d820-ae41-a261-067a830ec371"), new DateTime(2026, 12, 20, 3, 53, 26, 521, DateTimeKind.Utc).AddTicks(2390), 2058.3200000000002, 55841L, "Volkman - Jaskolski", "лв" },
                    { new Guid("aa7ed04c-1049-477c-f263-412b128d38a9"), new DateTime(2027, 4, 24, 21, 49, 52, 497, DateTimeKind.Utc).AddTicks(3133), 6927.9200000000001, 21911L, "Swaniawski, Rice and Maggio", "Дин." },
                    { new Guid("aa97017e-235d-825c-9b18-fedbb2f2098d"), new DateTime(2027, 3, 18, 16, 47, 24, 661, DateTimeKind.Utc).AddTicks(8367), 7561.0200000000004, 85995L, "Lemke, Balistreri and Willms", "lei" },
                    { new Guid("aaa0fc09-baf2-43d2-834c-fdc4edf15339"), new DateTime(2027, 4, 17, 10, 58, 23, 256, DateTimeKind.Utc).AddTicks(3160), 2581.4499999999998, 98858L, "Kirlin LLC", "ƒ" },
                    { new Guid("aaafd231-d236-0896-c696-edadd3cb6e4f"), new DateTime(2026, 10, 26, 4, 47, 49, 355, DateTimeKind.Utc).AddTicks(3180), 7757.5900000000001, 29518L, "Adams and Sons", "" },
                    { new Guid("ab4bcb7c-e9da-f947-3a64-a45ab5065f12"), new DateTime(2027, 2, 13, 16, 28, 43, 522, DateTimeKind.Utc).AddTicks(8277), 8642.3600000000006, 25179L, "Beer, Paucek and D'Amore", "₨" },
                    { new Guid("ab74a46e-9871-fc08-209a-2b5f7ba33d70"), new DateTime(2027, 5, 14, 9, 11, 32, 172, DateTimeKind.Utc).AddTicks(4661), 4484.3699999999999, 41322L, "West, Olson and Rolfson", "" },
                    { new Guid("abb63ee7-0279-b9d7-47c9-2a8c5d0396cd"), new DateTime(2027, 2, 4, 8, 56, 54, 570, DateTimeKind.Utc).AddTicks(582), 9156.3500000000004, 44342L, "Dickinson LLC", "" },
                    { new Guid("abfa9b30-17eb-44a6-79b1-90f44bbcec4e"), new DateTime(2027, 4, 21, 0, 59, 16, 769, DateTimeKind.Utc).AddTicks(6012), 2047.29, 11320L, "Bahringer, Schoen and Sporer", "$U" },
                    { new Guid("ac09ac72-40ef-00c6-4632-e1cddb3299b9"), new DateTime(2026, 11, 9, 23, 52, 10, 881, DateTimeKind.Utc).AddTicks(2516), 8059.8500000000004, 98294L, "Lind LLC", "$" },
                    { new Guid("ac18e6a5-80c0-39a2-e1f6-b4d3180280d1"), new DateTime(2026, 9, 5, 1, 58, 7, 858, DateTimeKind.Utc).AddTicks(2161), 3520.1199999999999, 18712L, "Ernser Inc", "" },
                    { new Guid("ac3344d4-50bb-025f-8c96-c380b8ba84be"), new DateTime(2026, 8, 22, 16, 33, 15, 843, DateTimeKind.Utc).AddTicks(4313), 574.25999999999999, 71311L, "Hodkiewicz LLC", "ƒ" },
                    { new Guid("ac35b744-9940-1809-631e-f63c9ec020f0"), new DateTime(2026, 8, 22, 17, 4, 28, 454, DateTimeKind.Utc).AddTicks(4026), 9157.0400000000009, 30753L, "Braun Group", "$" },
                    { new Guid("aca27b20-db16-1f1f-fc06-343fd7b67706"), new DateTime(2027, 5, 3, 11, 39, 55, 538, DateTimeKind.Utc).AddTicks(2633), 6478.3400000000001, 21833L, "Littel - Quigley", "" },
                    { new Guid("ad030f66-25dd-a00f-8567-9cbf89542d41"), new DateTime(2027, 2, 9, 23, 51, 51, 139, DateTimeKind.Utc).AddTicks(890), 9907.4899999999998, 96912L, "Connelly, Hamill and Lynch", "TT$" },
                    { new Guid("adcdfb75-114a-3b79-7b4c-8d5475626242"), new DateTime(2026, 9, 24, 12, 46, 57, 624, DateTimeKind.Utc).AddTicks(4908), 7885.8000000000002, 9108L, "Rowe - Johnston", "₫" },
                    { new Guid("ae6db23c-7e38-39c8-51e5-354ce3aa0943"), new DateTime(2027, 8, 1, 4, 7, 57, 188, DateTimeKind.Utc).AddTicks(1502), 7637.6999999999998, 61176L, "Stark LLC", "$" },
                    { new Guid("aea76b24-d917-bd20-d8d6-6caecb73e828"), new DateTime(2027, 6, 17, 14, 41, 18, 349, DateTimeKind.Utc).AddTicks(7376), 4396.1199999999999, 22020L, "Weber LLC", "$" },
                    { new Guid("aefdc1b8-46bf-3cfa-446f-3eee7d502349"), new DateTime(2027, 5, 2, 9, 23, 54, 25, DateTimeKind.Utc).AddTicks(7187), 9908.8999999999996, 66168L, "Rau LLC", "£" },
                    { new Guid("af14ea8f-4576-a9d2-c2f6-b8b3ae149514"), new DateTime(2027, 5, 12, 16, 7, 56, 758, DateTimeKind.Utc).AddTicks(1088), 2767.9699999999998, 7488L, "Schultz - Lind", "₴" },
                    { new Guid("af1f4d28-7afd-53c2-178b-edc2b38beca8"), new DateTime(2027, 5, 26, 10, 5, 54, 33, DateTimeKind.Utc).AddTicks(329), 8529.0599999999995, 46150L, "Hodkiewicz and Sons", "" },
                    { new Guid("af2a0654-0e6c-313a-b657-328b461d9fd6"), new DateTime(2027, 3, 18, 18, 52, 42, 979, DateTimeKind.Utc).AddTicks(4549), 8594.7600000000002, 3958L, "Jakubowski - Hessel", "" },
                    { new Guid("af901d78-93f5-d583-1623-ae9bc5818e4b"), new DateTime(2026, 8, 25, 11, 50, 57, 485, DateTimeKind.Utc).AddTicks(8221), 2591.6599999999999, 89923L, "Runolfsson, Gleichner and Bednar", "$" },
                    { new Guid("af90d93b-f6ca-125e-7328-6636c86853c1"), new DateTime(2027, 6, 4, 10, 36, 53, 970, DateTimeKind.Utc).AddTicks(9463), 3011.9499999999998, 275L, "Koepp, Marquardt and Denesik", "₨" },
                    { new Guid("afd45eb8-9214-2fe3-b8fe-b4944a321136"), new DateTime(2026, 9, 22, 3, 19, 41, 935, DateTimeKind.Utc).AddTicks(3272), 9881.5799999999999, 51842L, "Padberg, Sanford and Koepp", "Rp" },
                    { new Guid("afdb8b95-9927-0f6a-8cda-12a471d118f0"), new DateTime(2027, 4, 2, 20, 19, 30, 717, DateTimeKind.Utc).AddTicks(9982), 4481.2600000000002, 10131L, "Krajcik, Beer and Hills", "RM" },
                    { new Guid("afe669cf-4fae-73d3-1a0b-84f6ffab5fac"), new DateTime(2026, 12, 9, 4, 9, 38, 840, DateTimeKind.Utc).AddTicks(3699), 5122.6499999999996, 41349L, "Mitchell LLC", "$" },
                    { new Guid("b0778b1d-7eca-8229-87fe-884cb8a61427"), new DateTime(2026, 12, 17, 1, 46, 29, 861, DateTimeKind.Utc).AddTicks(3075), 5439.2399999999998, 73771L, "Daugherty, Lang and Altenwerth", "$" },
                    { new Guid("b08a6b7f-6633-082a-c03f-3e4ed61bc5c1"), new DateTime(2027, 1, 26, 10, 29, 16, 378, DateTimeKind.Utc).AddTicks(8097), 8420.6700000000001, 66421L, "Spencer - Towne", "$" },
                    { new Guid("b0dd589a-07a2-4999-7428-0c8bff704702"), new DateTime(2026, 10, 3, 7, 40, 57, 32, DateTimeKind.Utc).AddTicks(2606), 9087.0300000000007, 55442L, "Watsica - Murazik", "" },
                    { new Guid("b11cc1fa-10e7-e7dd-452c-710bf539137c"), new DateTime(2027, 7, 27, 5, 44, 30, 725, DateTimeKind.Utc).AddTicks(186), 460.30000000000001, 56183L, "Schimmel, Brown and Berge", "﷼" },
                    { new Guid("b1285e52-7a3c-a1d3-1276-7baf0bf7c070"), new DateTime(2027, 6, 7, 7, 46, 17, 656, DateTimeKind.Utc).AddTicks(1229), 1167.72, 88055L, "Quigley - Halvorson", "£" },
                    { new Guid("b1875e5c-4e62-99d1-26db-de30f383b625"), new DateTime(2027, 1, 14, 9, 30, 9, 318, DateTimeKind.Utc).AddTicks(2948), 4685.2600000000002, 34835L, "Schumm and Sons", "TT$" },
                    { new Guid("b21a4480-41bc-51c6-0751-f305ab3ff611"), new DateTime(2027, 1, 5, 9, 41, 59, 845, DateTimeKind.Utc).AddTicks(3408), 1354.28, 48707L, "Douglas, Metz and Hermann", "$" },
                    { new Guid("b26814be-ed9c-4498-6532-f13a770ffac1"), new DateTime(2027, 3, 23, 12, 21, 20, 583, DateTimeKind.Utc).AddTicks(4551), 8873.0499999999993, 63624L, "Cremin LLC", "" },
                    { new Guid("b27b624f-b28c-0f35-73f2-f6e18af7b81d"), new DateTime(2027, 5, 19, 12, 17, 30, 348, DateTimeKind.Utc).AddTicks(510), 6382.1400000000003, 2341L, "Dietrich - Gottlieb", "£" },
                    { new Guid("b2b937ad-dc62-8add-e43f-f6a2744e7b6b"), new DateTime(2026, 10, 5, 17, 5, 3, 310, DateTimeKind.Utc).AddTicks(861), 6599.7299999999996, 92441L, "Wolff, Howe and Jaskolski", "﷼" },
                    { new Guid("b2bb744d-680d-d2d6-762f-91e82761c1e5"), new DateTime(2026, 10, 3, 15, 42, 23, 718, DateTimeKind.Utc).AddTicks(3604), 6494.3199999999997, 36784L, "Becker - Ward", "₭" },
                    { new Guid("b31ab633-ee36-ba44-b715-e55d89c704cb"), new DateTime(2026, 11, 29, 10, 47, 47, 125, DateTimeKind.Utc).AddTicks(9004), 6352.4799999999996, 4245L, "Gusikowski Group", "$" },
                    { new Guid("b31f1f2a-5685-d916-fe88-dcf8d110df87"), new DateTime(2027, 1, 14, 18, 40, 23, 995, DateTimeKind.Utc).AddTicks(1187), 4066.3200000000002, 75744L, "Friesen - Hahn", "" },
                    { new Guid("b322e704-caf2-77d6-6c90-4c511cd64389"), new DateTime(2026, 8, 27, 11, 6, 30, 919, DateTimeKind.Utc).AddTicks(3796), 494.77999999999997, 2898L, "Brekke, Barrows and Konopelski", "R$" },
                    { new Guid("b324663a-84c0-8bee-092c-a3cff980848f"), new DateTime(2027, 2, 10, 22, 36, 44, 676, DateTimeKind.Utc).AddTicks(6384), 5284.8500000000004, 96258L, "Abshire - Hackett", "B/." },
                    { new Guid("b3289ce9-28cc-9afd-a0c9-8973ed19cd5b"), new DateTime(2027, 6, 8, 10, 45, 3, 367, DateTimeKind.Utc).AddTicks(1091), 6025.1099999999997, 82903L, "Auer, Bode and Buckridge", "" },
                    { new Guid("b34d183d-5893-7ac5-c6ae-f6fa4f9cd5ba"), new DateTime(2026, 11, 7, 5, 14, 59, 157, DateTimeKind.Utc).AddTicks(9187), 4252.0100000000002, 41164L, "Corwin - Marquardt", "" },
                    { new Guid("b359dec8-21ad-07b2-3791-624152f81317"), new DateTime(2026, 9, 30, 10, 41, 42, 197, DateTimeKind.Utc).AddTicks(1987), 2770.98, 67073L, "Wehner - Yundt", "kn" },
                    { new Guid("b3655c78-610a-0848-8bab-9a326cd5ded0"), new DateTime(2027, 7, 3, 3, 14, 20, 129, DateTimeKind.Utc).AddTicks(4813), 1400.28, 39720L, "Howell - Champlin", "Db" },
                    { new Guid("b375f259-45bf-7fbc-6c8c-f17383d909d2"), new DateTime(2027, 4, 25, 1, 56, 18, 123, DateTimeKind.Utc).AddTicks(8235), 7107.3000000000002, 12761L, "Lesch, Hauck and Nicolas", "₺" },
                    { new Guid("b3bbb463-3e4f-cf03-8e75-be1f1851aa2d"), new DateTime(2027, 7, 11, 23, 46, 26, 492, DateTimeKind.Utc).AddTicks(4278), 5503.5299999999997, 60019L, "Adams Group", "" },
                    { new Guid("b419cf08-0697-27f9-5001-099816a2ae02"), new DateTime(2027, 2, 3, 4, 58, 58, 260, DateTimeKind.Utc).AddTicks(9275), 8255.0799999999999, 7001L, "Spencer - Altenwerth", "$" },
                    { new Guid("b424cf81-cc57-da3e-490a-1ff0500159aa"), new DateTime(2027, 7, 29, 0, 55, 48, 382, DateTimeKind.Utc).AddTicks(5242), 7296.5500000000002, 84142L, "Block, Quigley and Predovic", "R$" },
                    { new Guid("b451c3f5-7fe8-cfb0-5d59-7f6dd213f590"), new DateTime(2026, 8, 28, 21, 40, 54, 881, DateTimeKind.Utc).AddTicks(3233), 926.08000000000004, 33873L, "Cormier, Daugherty and Emard", "Q" },
                    { new Guid("b4586172-c81e-f853-9d41-2901326d38a3"), new DateTime(2027, 1, 4, 5, 11, 36, 533, DateTimeKind.Utc).AddTicks(9044), 4114.4300000000003, 27196L, "Yundt, Jast and Kreiger", "" },
                    { new Guid("b4641468-f171-2a7d-0954-c9728f34d908"), new DateTime(2027, 5, 30, 20, 36, 28, 704, DateTimeKind.Utc).AddTicks(7894), 8563.7999999999993, 32414L, "Bailey - Moore", "R" },
                    { new Guid("b4684b69-8e47-8472-bcf5-ecb395a20155"), new DateTime(2026, 10, 25, 4, 38, 44, 785, DateTimeKind.Utc).AddTicks(8249), 6307.3699999999999, 90916L, "Bins, Sauer and Pfeffer", "£" },
                    { new Guid("b4a1b942-5028-f8bd-0232-61d35977476c"), new DateTime(2027, 7, 21, 7, 54, 12, 747, DateTimeKind.Utc).AddTicks(8449), 1913.9400000000001, 10015L, "Collins Inc", "₩" },
                    { new Guid("b4c58a26-6d0f-a7b9-1e10-a14c7cf2ff90"), new DateTime(2026, 8, 16, 19, 33, 53, 4, DateTimeKind.Utc).AddTicks(8008), 7122.9700000000003, 64823L, "Kuvalis - Connelly", "" },
                    { new Guid("b4d90bb7-afa7-fcac-c22f-19c15caffc5f"), new DateTime(2027, 2, 27, 14, 35, 51, 676, DateTimeKind.Utc).AddTicks(7939), 9630.1800000000003, 35401L, "Hayes, Kuhn and Koepp", "" },
                    { new Guid("b535e964-39ca-2b90-00bc-1b43798d69a4"), new DateTime(2027, 5, 11, 4, 15, 10, 696, DateTimeKind.Utc).AddTicks(9776), 7878.6599999999999, 59679L, "Fadel - Robel", "Дин." },
                    { new Guid("b59fda69-a399-424c-bdcc-f27cf3e61ad7"), new DateTime(2027, 3, 16, 15, 24, 8, 375, DateTimeKind.Utc).AddTicks(7445), 2938.8499999999999, 29362L, "Bogan - Heidenreich", "L" },
                    { new Guid("b5e0f044-9dba-21e7-1d31-84326f0d33a7"), new DateTime(2027, 3, 16, 17, 24, 27, 448, DateTimeKind.Utc).AddTicks(717), 5103.79, 74274L, "Pollich - Renner", "" },
                    { new Guid("b6160a14-48ed-9988-5732-2dd627f9e076"), new DateTime(2027, 1, 7, 11, 20, 15, 959, DateTimeKind.Utc).AddTicks(1042), 4780.3599999999997, 83830L, "Hessel - Emmerich", "lei" },
                    { new Guid("b61ecccd-cc50-f498-6afe-cbda386a9928"), new DateTime(2026, 12, 22, 5, 58, 38, 349, DateTimeKind.Utc).AddTicks(6605), 9554.8099999999995, 94734L, "Oberbrunner - Schuster", "" },
                    { new Guid("b65348a7-56c1-4b0e-3f68-37db2b4e80d9"), new DateTime(2026, 11, 3, 8, 13, 53, 594, DateTimeKind.Utc).AddTicks(5134), 4636.1099999999997, 88823L, "Hudson - Huel", "BZ$" },
                    { new Guid("b6a70b96-4d1f-5339-f418-898b49944874"), new DateTime(2027, 6, 11, 6, 25, 36, 209, DateTimeKind.Utc).AddTicks(3057), 4427.8900000000003, 35618L, "Legros LLC", "₨" },
                    { new Guid("b6b4e289-2173-f354-93e2-15cf6887033d"), new DateTime(2027, 6, 19, 15, 44, 52, 86, DateTimeKind.Utc).AddTicks(268), 1696.3399999999999, 90407L, "Casper, Terry and Shanahan", "R$" },
                    { new Guid("b6efb19f-d318-e004-7c42-03e697bfb700"), new DateTime(2027, 6, 18, 10, 25, 8, 446, DateTimeKind.Utc).AddTicks(5369), 2464.8800000000001, 11049L, "McDermott - Kuphal", "" },
                    { new Guid("b73547b6-6521-2f14-a60b-86cfd606ffac"), new DateTime(2026, 11, 22, 9, 7, 41, 670, DateTimeKind.Utc).AddTicks(7127), 4924.6899999999996, 31435L, "Schneider, Mills and Kris", "" },
                    { new Guid("b76a41d1-ac94-717a-81d1-dd20fee446cf"), new DateTime(2026, 8, 16, 9, 51, 8, 735, DateTimeKind.Utc).AddTicks(5805), 8932.8199999999997, 15734L, "Kshlerin - Cormier", "kr" },
                    { new Guid("b7946d42-955a-e798-8891-31b4f1221cc9"), new DateTime(2026, 8, 20, 16, 30, 14, 599, DateTimeKind.Utc).AddTicks(2099), 7529.1700000000001, 26815L, "Bosco, Feeney and Fadel", "฿" },
                    { new Guid("b7b10027-46a1-04a2-fb54-f055833c03fd"), new DateTime(2026, 9, 22, 5, 21, 5, 457, DateTimeKind.Utc).AddTicks(7705), 2311.0700000000002, 92004L, "Marquardt - Howe", "" },
                    { new Guid("b7c74c06-b235-e9f0-b214-0c7549ebc340"), new DateTime(2026, 10, 7, 5, 25, 14, 7, DateTimeKind.Utc).AddTicks(8159), 3266.75, 54341L, "Russel LLC", "₮" },
                    { new Guid("b7cd54f2-ad46-dfb4-d7e5-40f569abe1d7"), new DateTime(2026, 9, 29, 7, 26, 58, 15, DateTimeKind.Utc).AddTicks(5617), 9162.8700000000008, 63158L, "Heidenreich - Runolfsson", "₨" },
                    { new Guid("b806a5f9-9d0d-1520-1482-8a7619d771a2"), new DateTime(2026, 9, 25, 0, 13, 4, 418, DateTimeKind.Utc).AddTicks(2502), 6397.1000000000004, 32475L, "Bergnaum, Williamson and Ritchie", "" },
                    { new Guid("b82aabb2-8c4e-729d-c768-3fc1edc0f589"), new DateTime(2026, 12, 1, 9, 54, 39, 823, DateTimeKind.Utc).AddTicks(5899), 8747.9099999999999, 17266L, "Ernser and Sons", "£" },
                    { new Guid("b84f0b5c-3036-0bb7-a95a-d9c78120572e"), new DateTime(2026, 9, 20, 10, 52, 13, 124, DateTimeKind.Utc).AddTicks(8739), 4893.46, 34569L, "Stamm Inc", "Db" },
                    { new Guid("b8572aba-ed16-5444-0cac-2d97a498ee57"), new DateTime(2026, 10, 17, 23, 36, 34, 962, DateTimeKind.Utc).AddTicks(8938), 1018.26, 51292L, "Towne, Borer and Streich", "₡" },
                    { new Guid("b884cc95-b64b-083b-6eee-6bee5cd1405a"), new DateTime(2026, 12, 21, 5, 56, 1, 177, DateTimeKind.Utc).AddTicks(7381), 165.68000000000001, 5886L, "Welch, Klein and Kihn", "" },
                    { new Guid("b8dcf8eb-cc62-5a0c-f819-af8b3f2a7d53"), new DateTime(2027, 2, 9, 7, 57, 1, 327, DateTimeKind.Utc).AddTicks(7205), 7800.5900000000001, 77189L, "Schoen and Sons", "kr" },
                    { new Guid("b945a40d-287a-bb13-fe09-17716a955971"), new DateTime(2026, 11, 12, 9, 56, 24, 656, DateTimeKind.Utc).AddTicks(9451), 6113.8000000000002, 65801L, "Howe and Sons", "R$" },
                    { new Guid("b967dce4-f789-b2e1-6f75-d3624770b95e"), new DateTime(2026, 10, 15, 17, 29, 2, 212, DateTimeKind.Utc).AddTicks(7186), 6315.0900000000001, 88272L, "Thiel LLC", "TT$" },
                    { new Guid("b9b385f2-f42b-04fa-bfad-96348fb1e965"), new DateTime(2027, 2, 15, 5, 50, 48, 239, DateTimeKind.Utc).AddTicks(8145), 8193.7900000000009, 5401L, "Bradtke, Welch and Grant", "Kč" },
                    { new Guid("b9d417d1-056d-20d1-75a9-f7f72f546012"), new DateTime(2026, 9, 20, 0, 48, 43, 565, DateTimeKind.Utc).AddTicks(3244), 5705.5799999999999, 24856L, "Wisoky Group", "S/." },
                    { new Guid("ba3f03d8-47a6-4b14-33ca-afd7e0c50e01"), new DateTime(2027, 2, 28, 6, 8, 50, 418, DateTimeKind.Utc).AddTicks(9690), 1583.3199999999999, 99817L, "Bergnaum, Kemmer and Nicolas", "₭" },
                    { new Guid("ba6ecdce-8897-5870-3d69-3d7b0ab67358"), new DateTime(2026, 11, 16, 7, 26, 45, 840, DateTimeKind.Utc).AddTicks(9600), 2329.6700000000001, 92350L, "Kilback Inc", "$" },
                    { new Guid("ba91e7cc-d839-14c7-523a-7d36b681d8eb"), new DateTime(2027, 3, 30, 17, 17, 4, 362, DateTimeKind.Utc).AddTicks(3469), 1397.8499999999999, 79081L, "Monahan, Kuvalis and Shanahan", "" },
                    { new Guid("bb2ae396-495a-f28e-2e20-23139f52006f"), new DateTime(2027, 7, 13, 12, 20, 23, 12, DateTimeKind.Utc).AddTicks(5342), 5039.3999999999996, 50813L, "Lesch, Schuppe and Dicki", "" },
                    { new Guid("bb5a336b-41bb-dade-57aa-496830deb316"), new DateTime(2026, 8, 10, 3, 42, 33, 135, DateTimeKind.Utc).AddTicks(5225), 9864.9799999999996, 34014L, "Luettgen, Tillman and Wiza", "" },
                    { new Guid("bb6f158f-35bf-eba0-f14c-a6b4634d4ced"), new DateTime(2027, 3, 13, 8, 52, 4, 628, DateTimeKind.Utc).AddTicks(3416), 1685.95, 79597L, "Dickens, Quigley and Monahan", "p." },
                    { new Guid("bb8490e8-1587-047d-fd60-ee56d8188867"), new DateTime(2026, 8, 24, 9, 17, 29, 942, DateTimeKind.Utc).AddTicks(8734), 3620.8299999999999, 34432L, "White - Kutch", "" },
                    { new Guid("bb9f92b9-b7bc-2c20-dbaa-06e4512c5227"), new DateTime(2027, 1, 3, 7, 36, 20, 432, DateTimeKind.Utc).AddTicks(3613), 2754.3000000000002, 30256L, "Cummings - McCullough", "" },
                    { new Guid("bc0e4740-fab9-bd1f-6dd6-83f0acecba41"), new DateTime(2027, 5, 31, 20, 55, 36, 767, DateTimeKind.Utc).AddTicks(9422), 7000.0699999999997, 33453L, "Barrows Group", "﷼" },
                    { new Guid("bc1c10a7-6642-9308-881e-f62d73a7358b"), new DateTime(2027, 2, 7, 6, 27, 51, 749, DateTimeKind.Utc).AddTicks(2405), 3952.25, 69844L, "Turner Inc", "руб" },
                    { new Guid("bc4c1260-7f78-ab4b-ac93-116601870467"), new DateTime(2027, 2, 14, 20, 0, 17, 562, DateTimeKind.Utc).AddTicks(5218), 8422.2700000000004, 32684L, "Ernser, Kub and Feest", "" },
                    { new Guid("bca3d8fb-5e7e-ba9b-845f-5591a9e73862"), new DateTime(2027, 1, 13, 10, 45, 32, 125, DateTimeKind.Utc).AddTicks(9541), 6608.8299999999999, 57741L, "Dietrich, Tromp and Wolff", "NT$" },
                    { new Guid("bcf8558e-941a-fef0-e830-fca5358a8502"), new DateTime(2026, 12, 15, 8, 34, 44, 571, DateTimeKind.Utc).AddTicks(6053), 6013.3699999999999, 90888L, "Lockman - Hudson", "R$" },
                    { new Guid("bd078c5c-3357-a5c6-f6ef-d347f5a337e8"), new DateTime(2026, 10, 28, 11, 17, 35, 895, DateTimeKind.Utc).AddTicks(9815), 8727.6100000000006, 83920L, "Hartmann, Heller and Haag", "" },
                    { new Guid("bd68b604-bdae-8a8e-26cb-3ccabffc697e"), new DateTime(2027, 6, 27, 21, 56, 58, 309, DateTimeKind.Utc).AddTicks(9067), 2841.8200000000002, 50749L, "White - Hayes", "Rp" },
                    { new Guid("bd8e6408-d652-9569-5e43-2f5992cd67bd"), new DateTime(2027, 6, 15, 14, 35, 56, 436, DateTimeKind.Utc).AddTicks(7325), 6825.2399999999998, 60013L, "Medhurst and Sons", "Ls" },
                    { new Guid("bdaeb22e-4a6e-df88-acfa-eb9fa9fa0420"), new DateTime(2026, 12, 21, 20, 20, 10, 728, DateTimeKind.Utc).AddTicks(8434), 2826.5100000000002, 32972L, "Lueilwitz LLC", "﷼" },
                    { new Guid("bdd81288-0bd0-9f3e-e802-7bd1ee9e00cf"), new DateTime(2027, 4, 26, 10, 4, 34, 121, DateTimeKind.Utc).AddTicks(3867), 1574.0, 28132L, "O'Keefe, Herman and Bartoletti", "" },
                    { new Guid("bde96e27-529c-9e69-ed96-d7c7be8cc996"), new DateTime(2027, 2, 12, 18, 43, 22, 159, DateTimeKind.Utc).AddTicks(6666), 3824.1700000000001, 18210L, "Langosh, Ferry and Flatley", "$" },
                    { new Guid("be312583-bd29-638c-3a0c-eb225671ba95"), new DateTime(2026, 11, 9, 0, 15, 33, 99, DateTimeKind.Utc).AddTicks(9759), 3466.52, 96361L, "Orn - Balistreri", "₱" },
                    { new Guid("be363375-eff8-7691-952a-3e6922cd5b40"), new DateTime(2027, 5, 4, 0, 30, 22, 121, DateTimeKind.Utc).AddTicks(638), 9285.5300000000007, 13014L, "Nicolas and Sons", "$" },
                    { new Guid("be3e771a-8e03-7b86-ef0f-117c36eebb49"), new DateTime(2027, 7, 10, 0, 14, 26, 828, DateTimeKind.Utc).AddTicks(1027), 8597.7800000000007, 32360L, "Carter and Sons", "Bs" },
                    { new Guid("beb31f4e-6c43-1137-2a40-1cf104eac8a5"), new DateTime(2027, 7, 28, 4, 45, 25, 329, DateTimeKind.Utc).AddTicks(6742), 6570.4899999999998, 59902L, "Robel - Weissnat", "$" },
                    { new Guid("bf067be1-58ec-f88f-92e0-1ebc7661db8d"), new DateTime(2027, 4, 24, 17, 58, 7, 145, DateTimeKind.Utc).AddTicks(4200), 7952.6800000000003, 8930L, "Bergstrom, Bergstrom and Dicki", "RD$" },
                    { new Guid("bf3321b1-6d72-e9b0-02d5-cc7e8e62882f"), new DateTime(2027, 1, 5, 21, 58, 26, 45, DateTimeKind.Utc).AddTicks(8755), 1526.24, 1300L, "Lebsack, Paucek and Rempel", "" },
                    { new Guid("bf40a7eb-dea0-1b99-edca-3785ce6bc8e8"), new DateTime(2027, 2, 1, 6, 24, 46, 396, DateTimeKind.Utc).AddTicks(9556), 1833.3299999999999, 30944L, "Pouros LLC", "" },
                    { new Guid("bf53da70-e9a4-375f-5059-5211b2e10880"), new DateTime(2026, 10, 21, 17, 22, 3, 942, DateTimeKind.Utc).AddTicks(1072), 9356.9699999999993, 21507L, "Funk, Raynor and Wolff", "" },
                    { new Guid("bf5f1978-84be-ff6f-2f78-f6af29a45d93"), new DateTime(2026, 10, 16, 4, 54, 11, 899, DateTimeKind.Utc).AddTicks(4129), 9152.1299999999992, 28191L, "Morissette - Mertz", "£" },
                    { new Guid("bf7898ab-9b10-71d7-2fa8-6148be64ca09"), new DateTime(2026, 9, 26, 11, 3, 48, 182, DateTimeKind.Utc).AddTicks(9979), 9020.2000000000007, 75068L, "Osinski Inc", "" },
                    { new Guid("bfbb217b-2c87-c4ed-c252-60bea10f434e"), new DateTime(2027, 1, 8, 7, 23, 20, 825, DateTimeKind.Utc).AddTicks(9841), 9771.6800000000003, 22576L, "Mraz, Cronin and Leuschke", "TT$" },
                    { new Guid("bfe601eb-3655-784b-5cee-48af77cb3a48"), new DateTime(2027, 5, 18, 9, 53, 47, 754, DateTimeKind.Utc).AddTicks(5369), 1757.0599999999999, 89030L, "Schoen and Sons", "Bs" },
                    { new Guid("c042ca68-54d7-78e9-bf9f-609b0b820a3c"), new DateTime(2027, 6, 5, 1, 25, 13, 478, DateTimeKind.Utc).AddTicks(431), 5067.9499999999998, 54052L, "Nolan Inc", "€" },
                    { new Guid("c09d87c7-4a0e-032e-9ad8-762c25d95e30"), new DateTime(2027, 2, 18, 16, 56, 16, 894, DateTimeKind.Utc).AddTicks(706), 990.76999999999998, 18461L, "Harvey - Hoppe", "£" },
                    { new Guid("c109d306-355c-4fcb-03c7-95d8f9b06eb7"), new DateTime(2026, 8, 21, 7, 51, 38, 344, DateTimeKind.Utc).AddTicks(9153), 1228.51, 95982L, "Kessler, Treutel and Blanda", "kr" },
                    { new Guid("c14f67b5-496d-364f-3dcc-d80858b79049"), new DateTime(2027, 6, 24, 15, 4, 55, 300, DateTimeKind.Utc).AddTicks(8158), 4329.6599999999999, 93187L, "Gerhold LLC", "" },
                    { new Guid("c14fe154-1673-55b1-3e2d-31a90670d117"), new DateTime(2027, 6, 19, 6, 51, 1, 720, DateTimeKind.Utc).AddTicks(9833), 8466.5200000000004, 90086L, "Denesik Inc", "£" },
                    { new Guid("c19200b3-8303-d96e-62b0-7c5c516dd1b9"), new DateTime(2026, 9, 20, 14, 12, 35, 390, DateTimeKind.Utc).AddTicks(2936), 6207.5799999999999, 84730L, "Lebsack - Lynch", "Ft" },
                    { new Guid("c23ec6de-f6d9-52b1-68d3-141356daabfb"), new DateTime(2027, 7, 9, 19, 52, 35, 190, DateTimeKind.Utc).AddTicks(9479), 2415.3899999999999, 2678L, "Stark Inc", "" },
                    { new Guid("c24f6460-229e-75c6-1634-f864b06bc186"), new DateTime(2027, 4, 9, 22, 30, 12, 304, DateTimeKind.Utc).AddTicks(7960), 3569.7199999999998, 96075L, "Daugherty Group", "﷼" },
                    { new Guid("c295ea0f-c02d-3029-f1ff-0105a992eb1f"), new DateTime(2026, 12, 23, 10, 51, 31, 486, DateTimeKind.Utc).AddTicks(9448), 6475.1300000000001, 53096L, "Ortiz LLC", "$" },
                    { new Guid("c2a3fadd-3b67-69d7-97c8-aa086cf9a75b"), new DateTime(2026, 8, 8, 6, 53, 25, 413, DateTimeKind.Utc).AddTicks(7589), 5292.9899999999998, 50265L, "Collins and Sons", "" },
                    { new Guid("c2b9413b-0049-28aa-bdca-baaf963b70e7"), new DateTime(2027, 4, 18, 3, 4, 8, 806, DateTimeKind.Utc).AddTicks(464), 6417.3699999999999, 83808L, "Fay, Braun and Adams", "BZ$" },
                    { new Guid("c2ba6703-90f2-eb9c-1804-a7a1440e4fab"), new DateTime(2027, 7, 11, 21, 0, 32, 429, DateTimeKind.Utc).AddTicks(371), 8337.0400000000009, 42210L, "Cummings LLC", "₨" },
                    { new Guid("c2e01e20-8a1f-4f82-ca91-309062775801"), new DateTime(2026, 9, 16, 12, 54, 20, 942, DateTimeKind.Utc).AddTicks(3128), 254.09999999999999, 28795L, "Walsh - O'Keefe", "" },
                    { new Guid("c2ee2ac0-5b40-df01-48a2-6da317b90dfa"), new DateTime(2027, 1, 27, 16, 23, 40, 241, DateTimeKind.Utc).AddTicks(4150), 9397.3099999999995, 64857L, "Kunze - Schaden", "" },
                    { new Guid("c2f76fd6-95e5-9561-ded7-0e57b6a3aa6b"), new DateTime(2026, 11, 1, 15, 55, 33, 537, DateTimeKind.Utc).AddTicks(3303), 1904.79, 72975L, "O'Connell and Sons", "$" },
                    { new Guid("c307c65c-7769-f6cd-a865-3c7f95d2962b"), new DateTime(2026, 12, 31, 2, 12, 36, 928, DateTimeKind.Utc).AddTicks(9656), 9485.5200000000004, 77683L, "Kunze, Satterfield and Watsica", "" },
                    { new Guid("c310ff80-281a-0773-38da-3cd4267fa542"), new DateTime(2026, 10, 16, 23, 12, 9, 39, DateTimeKind.Utc).AddTicks(3339), 5519.1599999999999, 83750L, "Gerlach, Renner and Stroman", "" },
                    { new Guid("c3186baf-5016-3ff0-be71-8410d4162f09"), new DateTime(2026, 11, 27, 5, 26, 27, 676, DateTimeKind.Utc).AddTicks(4544), 120.88, 41747L, "Auer - Gusikowski", "" },
                    { new Guid("c3471848-28cf-4fbd-85fe-9efb29cd5511"), new DateTime(2027, 5, 2, 11, 46, 4, 226, DateTimeKind.Utc).AddTicks(1382), 9174.3999999999996, 89258L, "Jaskolski, Shields and Gulgowski", "₮" },
                    { new Guid("c3796eac-90a4-f194-9b41-af74c4a03943"), new DateTime(2026, 10, 29, 0, 34, 50, 422, DateTimeKind.Utc).AddTicks(7066), 2409.8200000000002, 71808L, "Hessel - Nitzsche", "$U" },
                    { new Guid("c3ce0dba-800a-d7ea-ff04-de03e2284ca5"), new DateTime(2026, 12, 10, 4, 58, 46, 486, DateTimeKind.Utc).AddTicks(9558), 4484.4700000000003, 91465L, "Lindgren - Bechtelar", "" },
                    { new Guid("c3ce6354-6d11-55a5-9369-2860d45d3c0a"), new DateTime(2027, 7, 19, 7, 44, 13, 148, DateTimeKind.Utc).AddTicks(3561), 2881.4000000000001, 80182L, "Walker, Dach and Nikolaus", "" },
                    { new Guid("c3d53bdf-c0f0-3e04-cb87-739d4a70835c"), new DateTime(2027, 6, 18, 0, 18, 22, 646, DateTimeKind.Utc).AddTicks(755), 5337.0600000000004, 66227L, "Bechtelar LLC", "" },
                    { new Guid("c3dc8938-daa2-aea1-8e46-4e53eed0dbc4"), new DateTime(2026, 10, 13, 22, 59, 58, 378, DateTimeKind.Utc).AddTicks(9451), 8826.5799999999999, 77955L, "Tillman - Koelpin", "BZ$" },
                    { new Guid("c40df16f-c107-3340-91f9-aa6ef42b687a"), new DateTime(2027, 5, 10, 8, 48, 46, 758, DateTimeKind.Utc).AddTicks(661), 4579.8699999999999, 49339L, "Veum and Sons", "" },
                    { new Guid("c422a9c0-61ec-0506-90c2-f17e97cbcb31"), new DateTime(2026, 12, 3, 4, 3, 16, 192, DateTimeKind.Utc).AddTicks(5516), 9714.2900000000009, 38237L, "Wisoky - Kihn", "zł" },
                    { new Guid("c4259648-9a50-8049-fcab-911499a36d73"), new DateTime(2027, 7, 8, 4, 44, 39, 403, DateTimeKind.Utc).AddTicks(329), 7894.8500000000004, 37708L, "Deckow - Toy", "" },
                    { new Guid("c44e2c80-e2e4-7bc0-a8d3-d408159ab180"), new DateTime(2027, 2, 5, 10, 1, 2, 324, DateTimeKind.Utc).AddTicks(1409), 5489.04, 46822L, "Bradtke - Stamm", "" },
                    { new Guid("c44f821b-332c-fb57-6736-96648a9061c3"), new DateTime(2026, 9, 7, 17, 32, 16, 975, DateTimeKind.Utc).AddTicks(5321), 3649.5300000000002, 73569L, "Turcotte, Price and Toy", "$" },
                    { new Guid("c46765de-747e-640b-5a5f-6e8004e8dd57"), new DateTime(2026, 9, 30, 21, 29, 53, 28, DateTimeKind.Utc).AddTicks(4211), 7865.5500000000002, 7946L, "Veum and Sons", "$U" },
                    { new Guid("c49dff79-cff8-2dfc-030b-2ee6f17ece30"), new DateTime(2027, 4, 22, 20, 4, 46, 206, DateTimeKind.Utc).AddTicks(2590), 275.99000000000001, 75110L, "Watsica - Douglas", "" },
                    { new Guid("c4b7d140-b877-c940-2305-2b4d3dd8292d"), new DateTime(2027, 1, 3, 19, 43, 6, 39, DateTimeKind.Utc).AddTicks(4409), 9716.6100000000006, 29638L, "Witting and Sons", "₨" },
                    { new Guid("c5162e3a-05a1-1ddf-c5b3-13da5ebf848b"), new DateTime(2027, 5, 31, 6, 50, 25, 803, DateTimeKind.Utc).AddTicks(4807), 2151.8299999999999, 77256L, "O'Kon and Sons", "" },
                    { new Guid("c527050f-7779-0ff4-c24c-758d788eda4b"), new DateTime(2026, 10, 9, 4, 27, 5, 76, DateTimeKind.Utc).AddTicks(7221), 1108.21, 53280L, "Tillman - Gerlach", "" },
                    { new Guid("c534eeb3-cf05-8353-5ddf-f8bb589c58de"), new DateTime(2026, 9, 28, 8, 18, 29, 207, DateTimeKind.Utc).AddTicks(5823), 3489.96, 72494L, "Medhurst Group", "" },
                    { new Guid("c5bd03b9-8930-563f-7688-cd69477dbcd5"), new DateTime(2027, 6, 13, 19, 28, 44, 909, DateTimeKind.Utc).AddTicks(9743), 5393.54, 61339L, "Stehr - Batz", "R" },
                    { new Guid("c5fa7a16-d918-15c0-5c18-1c692fba6761"), new DateTime(2027, 3, 4, 9, 17, 9, 392, DateTimeKind.Utc).AddTicks(3956), 48.350000000000001, 7274L, "Zemlak Group", "Lek" },
                    { new Guid("c5fc6e6a-831e-269d-b667-bfd0c723f165"), new DateTime(2027, 6, 26, 1, 2, 39, 983, DateTimeKind.Utc).AddTicks(4565), 2738.3699999999999, 52978L, "Langworth, Wiegand and Donnelly", "" },
                    { new Guid("c6926ad2-f1a7-3e5e-494f-163cc4b4b5be"), new DateTime(2026, 12, 15, 6, 14, 57, 992, DateTimeKind.Utc).AddTicks(6012), 2989.9899999999998, 82735L, "Streich, Crona and Breitenberg", "$" },
                    { new Guid("c69d4fe8-0d9d-524f-3b34-686a1e1d2d56"), new DateTime(2027, 6, 2, 9, 15, 33, 73, DateTimeKind.Utc).AddTicks(8993), 6964.3000000000002, 49916L, "Mohr, Carroll and Pfannerstill", "$" },
                    { new Guid("c6c57809-6a66-094f-5e74-9d4ea415a77d"), new DateTime(2027, 4, 30, 20, 54, 53, 367, DateTimeKind.Utc).AddTicks(8524), 344.94, 57659L, "Dach, Tromp and Little", "руб" },
                    { new Guid("c6fc6b55-048c-fc0e-38a5-e1d4e0f60650"), new DateTime(2027, 3, 19, 8, 51, 26, 588, DateTimeKind.Utc).AddTicks(2649), 9490.6599999999999, 17312L, "Wunsch and Sons", "" },
                    { new Guid("c72ad459-a1ef-9c19-6d20-14bee74a851b"), new DateTime(2027, 4, 11, 21, 11, 8, 616, DateTimeKind.Utc).AddTicks(5698), 8912.8099999999995, 48654L, "Welch and Sons", "₨" },
                    { new Guid("c767bf9e-ff1f-3505-5fa8-6adba6ad427a"), new DateTime(2026, 8, 25, 20, 5, 31, 710, DateTimeKind.Utc).AddTicks(4300), 7719.9899999999998, 20982L, "Hodkiewicz, Gusikowski and Hills", "BZ$" },
                    { new Guid("c805794a-c3d6-2bda-c8b9-6a7602a864bc"), new DateTime(2026, 12, 25, 12, 31, 39, 417, DateTimeKind.Utc).AddTicks(6779), 8634.0499999999993, 38816L, "Nitzsche, Simonis and Torp", "$" },
                    { new Guid("c81f893e-a8be-ca4a-e02e-9eae304ed335"), new DateTime(2027, 7, 16, 13, 49, 15, 296, DateTimeKind.Utc).AddTicks(8189), 6765.3699999999999, 18112L, "Bashirian, Rosenbaum and Baumbach", "BZ$" },
                    { new Guid("c84fcf56-20e0-bf81-00e6-9a2e09f5d4d1"), new DateTime(2027, 6, 18, 1, 7, 10, 123, DateTimeKind.Utc).AddTicks(3070), 5355.6099999999997, 42069L, "Goodwin - Kirlin", "" },
                    { new Guid("c85022ee-3b6b-8832-bb8c-6ae7d5c9986c"), new DateTime(2026, 10, 7, 1, 58, 27, 55, DateTimeKind.Utc).AddTicks(694), 4445.8900000000003, 6779L, "Bosco - Bergnaum", "" },
                    { new Guid("c8ba8752-fcec-54f8-d806-af5f25f0f49d"), new DateTime(2026, 12, 18, 22, 6, 58, 831, DateTimeKind.Utc).AddTicks(205), 221.93000000000001, 11833L, "Medhurst - Schumm", "$" },
                    { new Guid("c8d9f1a5-ea5e-73d7-9dd3-c53b1bd39486"), new DateTime(2027, 3, 31, 15, 25, 0, 313, DateTimeKind.Utc).AddTicks(9829), 4300.6800000000003, 93965L, "Bartell Inc", "RD$" },
                    { new Guid("c90d5954-baad-1b8c-ad1d-6767ac4f2c44"), new DateTime(2026, 8, 21, 23, 24, 16, 88, DateTimeKind.Utc).AddTicks(1071), 3693.1399999999999, 28807L, "Kuhlman Inc", "" },
                    { new Guid("ca11145b-70fe-203f-1913-05ef5db395d0"), new DateTime(2026, 11, 24, 8, 51, 56, 51, DateTimeKind.Utc).AddTicks(4079), 7098.1300000000001, 74071L, "Wilderman, Wiza and Hane", "" },
                    { new Guid("ca970e12-c3e9-5ae4-b3cd-c00234b1193e"), new DateTime(2027, 6, 20, 3, 32, 15, 959, DateTimeKind.Utc).AddTicks(2004), 4969.7600000000002, 79456L, "Thompson Inc", "$" },
                    { new Guid("caf3061e-d88e-102a-007e-644349dcd289"), new DateTime(2026, 11, 27, 10, 38, 36, 814, DateTimeKind.Utc).AddTicks(836), 5411.04, 99428L, "Lehner, Mayert and Heaney", "$" },
                    { new Guid("caf7d008-feea-89ee-7f33-b484f543f757"), new DateTime(2026, 8, 26, 17, 8, 33, 850, DateTimeKind.Utc).AddTicks(1514), 5426.5799999999999, 68975L, "Dicki and Sons", "" },
                    { new Guid("cbabe165-5f63-f8a1-fa09-309c8d283a0f"), new DateTime(2027, 1, 20, 13, 26, 55, 605, DateTimeKind.Utc).AddTicks(5624), 4724.9399999999996, 47666L, "Barton, Leffler and Miller", "" },
                    { new Guid("cbc9856d-e35a-bed4-6129-e6b9d573be17"), new DateTime(2026, 9, 24, 23, 19, 30, 162, DateTimeKind.Utc).AddTicks(7037), 8412.3199999999997, 1262L, "Connelly Group", "¥" },
                    { new Guid("cbcc0cbc-6264-3629-dfd6-fc12110f97fc"), new DateTime(2027, 5, 27, 18, 16, 9, 51, DateTimeKind.Utc).AddTicks(1439), 1156.0599999999999, 21748L, "Nolan, Swift and Stamm", "£" },
                    { new Guid("cbda226a-5d9a-4af2-d8fb-1e9c511adbc6"), new DateTime(2027, 3, 5, 13, 57, 7, 683, DateTimeKind.Utc).AddTicks(8198), 9357.5100000000002, 66913L, "Keeling and Sons", "" },
                    { new Guid("cc4adb73-3c1a-c363-0dcf-bc777ce97d0f"), new DateTime(2027, 7, 20, 19, 26, 3, 55, DateTimeKind.Utc).AddTicks(4081), 5302.3900000000003, 24044L, "Hoppe - Rosenbaum", "лв" },
                    { new Guid("cc701185-aaae-4992-58da-fc56df80d26e"), new DateTime(2026, 9, 14, 3, 41, 52, 991, DateTimeKind.Utc).AddTicks(4930), 7149.6999999999998, 43787L, "Purdy LLC", "" },
                    { new Guid("ccbacf52-40a6-1e61-a53f-272e6272cc91"), new DateTime(2026, 11, 26, 8, 41, 41, 441, DateTimeKind.Utc).AddTicks(8029), 3088.4499999999998, 24182L, "Littel, Mosciski and Cartwright", "" },
                    { new Guid("cccadfef-b518-ba60-cb72-df67d1a06f75"), new DateTime(2027, 2, 24, 5, 31, 21, 95, DateTimeKind.Utc).AddTicks(6541), 5308.6999999999998, 66953L, "Carter, Windler and King", "£" },
                    { new Guid("cce27c77-13a8-1712-6e3e-e666f29103ed"), new DateTime(2027, 3, 2, 18, 37, 57, 497, DateTimeKind.Utc).AddTicks(3766), 3560.3600000000001, 98241L, "Barrows - Robel", "" },
                    { new Guid("cd5b6512-c95c-9de5-9a63-9d7ca07e6928"), new DateTime(2027, 6, 30, 7, 53, 52, 629, DateTimeKind.Utc).AddTicks(8374), 4489.46, 46276L, "Feeney, Greenholt and Stark", "" },
                    { new Guid("cda32114-b51d-f209-0089-d9ece4536915"), new DateTime(2026, 11, 16, 17, 13, 16, 792, DateTimeKind.Utc).AddTicks(6904), 6798.4399999999996, 51543L, "Moore Group", "" },
                    { new Guid("cdc78980-2bdd-c68e-0166-0b6da4fbddb9"), new DateTime(2026, 11, 19, 3, 58, 14, 66, DateTimeKind.Utc).AddTicks(3651), 8345.4500000000007, 80597L, "Deckow - Lesch", "₨" },
                    { new Guid("cdcbf933-c8cb-b031-3750-81a65b364d9e"), new DateTime(2026, 12, 2, 0, 21, 38, 451, DateTimeKind.Utc).AddTicks(5022), 956.14999999999998, 93824L, "Shields Group", "$" },
                    { new Guid("cdd8948a-cdef-bedb-01c1-bdff789e3ef4"), new DateTime(2026, 8, 17, 4, 24, 33, 440, DateTimeKind.Utc).AddTicks(8328), 3926.0500000000002, 88713L, "Strosin, Nicolas and Konopelski", "B/." },
                    { new Guid("ce15c5c1-04ef-ff2d-b7a1-0941ec6889da"), new DateTime(2026, 9, 25, 21, 42, 35, 83, DateTimeKind.Utc).AddTicks(2563), 6610.3999999999996, 84831L, "Hoppe Group", "" },
                    { new Guid("ce92e606-aa75-5ac3-3931-22f74d7e01df"), new DateTime(2027, 4, 26, 3, 35, 53, 154, DateTimeKind.Utc).AddTicks(325), 1414.7, 1930L, "McGlynn LLC", "" },
                    { new Guid("ced3d3d9-3d76-1a8e-f609-bdf105ecbb66"), new DateTime(2027, 3, 3, 21, 29, 29, 778, DateTimeKind.Utc).AddTicks(746), 3858.73, 91822L, "Schmeler - Roberts", "" },
                    { new Guid("cf88b9c9-6ed1-f934-de4d-e2c7949e9985"), new DateTime(2026, 10, 19, 17, 47, 52, 95, DateTimeKind.Utc).AddTicks(716), 8969.8700000000008, 44533L, "Nikolaus - Shields", "$" },
                    { new Guid("cfaf6b89-e6d8-b0d3-278f-5066688c64b3"), new DateTime(2027, 7, 9, 18, 0, 1, 740, DateTimeKind.Utc).AddTicks(5790), 1808.75, 17386L, "Goodwin, Nitzsche and Wuckert", "" },
                    { new Guid("cfe4754c-1dc4-fc98-51b9-45078fb75854"), new DateTime(2026, 11, 18, 15, 33, 36, 400, DateTimeKind.Utc).AddTicks(8005), 1743.0699999999999, 66227L, "Breitenberg LLC", "$" },
                    { new Guid("d0be4bf9-39ec-9a70-d785-9e26ffd49deb"), new DateTime(2026, 10, 13, 11, 58, 37, 648, DateTimeKind.Utc).AddTicks(8109), 9476.5499999999993, 92082L, "Nitzsche - Kuhlman", "£" },
                    { new Guid("d0d5650b-cc6f-e63a-3572-38497e7c6cf8"), new DateTime(2026, 12, 12, 16, 13, 22, 321, DateTimeKind.Utc).AddTicks(339), 5432.7700000000004, 62537L, "Abshire - DuBuque", "₨" },
                    { new Guid("d12d394c-ac4d-0d29-0232-0d90dc4af00a"), new DateTime(2026, 11, 29, 21, 4, 1, 271, DateTimeKind.Utc).AddTicks(6202), 2483.3699999999999, 22271L, "Larkin, Dickens and Kuhn", "ден" },
                    { new Guid("d13a72e6-8426-657a-88f2-e3655bd1e1aa"), new DateTime(2027, 2, 8, 11, 56, 19, 251, DateTimeKind.Utc).AddTicks(6199), 6494.3900000000003, 53316L, "Keebler, Krajcik and Dare", "$" },
                    { new Guid("d1f9cd89-ee0a-04e2-ce97-d640fec0dc2a"), new DateTime(2026, 10, 1, 10, 44, 33, 500, DateTimeKind.Utc).AddTicks(1293), 35.020000000000003, 2582L, "Streich - Walker", "B/." },
                    { new Guid("d217d544-544c-9627-ce0c-d3866626d6e6"), new DateTime(2027, 7, 10, 15, 7, 40, 354, DateTimeKind.Utc).AddTicks(6218), 7711.6400000000003, 52463L, "Collins - Maggio", "" },
                    { new Guid("d2286265-af57-41c6-2ac3-d051a8478767"), new DateTime(2026, 12, 14, 9, 55, 50, 400, DateTimeKind.Utc).AddTicks(7467), 9809.1100000000006, 71471L, "Hauck - Bergnaum", "kr" },
                    { new Guid("d23cc7d2-fc22-2c47-e447-6df9ebf123b0"), new DateTime(2026, 9, 10, 14, 30, 42, 509, DateTimeKind.Utc).AddTicks(7322), 730.28999999999996, 85276L, "Schroeder, Barrows and Ziemann", "ман" },
                    { new Guid("d2810dc7-679a-2e8f-77ab-811e9600d02a"), new DateTime(2026, 9, 20, 4, 46, 59, 949, DateTimeKind.Utc).AddTicks(5998), 326.69999999999999, 58170L, "Schaden and Sons", "kr" },
                    { new Guid("d29add55-88a5-3441-4067-dc24790e4d06"), new DateTime(2027, 6, 17, 8, 58, 12, 814, DateTimeKind.Utc).AddTicks(3503), 9873.9699999999993, 15793L, "Murphy LLC", "" },
                    { new Guid("d2e75b1c-48a7-d07b-6015-5cd861e5201b"), new DateTime(2026, 12, 30, 21, 36, 51, 679, DateTimeKind.Utc).AddTicks(4481), 939.78999999999996, 67115L, "Raynor LLC", "﷼" },
                    { new Guid("d2e9fdda-f8b7-ba81-0096-1bd9f4d7a647"), new DateTime(2027, 4, 15, 2, 22, 6, 705, DateTimeKind.Utc).AddTicks(7234), 1363.73, 63058L, "Emard, Jast and Jast", "₺" },
                    { new Guid("d33dc856-fbc2-c69e-b3c4-ffd8c3fd6623"), new DateTime(2026, 11, 12, 21, 45, 15, 761, DateTimeKind.Utc).AddTicks(3097), 4455.8500000000004, 11880L, "Trantow - Dicki", "" },
                    { new Guid("d3444035-c0b5-311d-457a-e11a0ac5454c"), new DateTime(2027, 1, 10, 9, 55, 36, 3, DateTimeKind.Utc).AddTicks(301), 1281.0799999999999, 85968L, "Ruecker - Gerhold", "៛" },
                    { new Guid("d393ce12-dc02-6c92-5525-d67416f33a72"), new DateTime(2027, 1, 7, 23, 19, 19, 642, DateTimeKind.Utc).AddTicks(696), 636.05999999999995, 87755L, "Gibson, Fritsch and Block", "" },
                    { new Guid("d3aa3530-c159-998f-e62a-9e9e2dd611b5"), new DateTime(2026, 11, 20, 14, 18, 30, 738, DateTimeKind.Utc).AddTicks(41), 5174.2700000000004, 59064L, "Toy - Hintz", "Lek" },
                    { new Guid("d4701e90-0fae-7be5-4b17-402ed507348f"), new DateTime(2027, 5, 22, 10, 9, 12, 956, DateTimeKind.Utc).AddTicks(9347), 6884.3500000000004, 58104L, "Powlowski, Hickle and Padberg", "£" },
                    { new Guid("d487078c-3578-5de7-8fb5-d7398c362364"), new DateTime(2026, 10, 12, 23, 47, 12, 905, DateTimeKind.Utc).AddTicks(1666), 6948.0600000000004, 31733L, "Fahey - Hodkiewicz", "" },
                    { new Guid("d4beba1a-98c7-9076-0237-1d73ced9a6bd"), new DateTime(2027, 5, 24, 3, 28, 24, 952, DateTimeKind.Utc).AddTicks(472), 6158.4200000000001, 62139L, "Feest - Hudson", "$" },
                    { new Guid("d4c8d3c7-6135-537e-10f3-9c2b0bb4f2c2"), new DateTime(2026, 12, 25, 12, 29, 1, 646, DateTimeKind.Utc).AddTicks(5252), 4742.4899999999998, 8380L, "Roberts, Hane and Turcotte", "$U" },
                    { new Guid("d5109521-02b6-67ad-be36-dee81310ef5e"), new DateTime(2026, 8, 7, 10, 6, 7, 682, DateTimeKind.Utc).AddTicks(5373), 9367.0699999999997, 63798L, "Wisozk, Mohr and Powlowski", "₱" },
                    { new Guid("d5125fb8-a976-6d1e-18b9-d7a91bb2a819"), new DateTime(2026, 8, 26, 17, 47, 49, 75, DateTimeKind.Utc).AddTicks(7251), 620.84000000000003, 81032L, "Macejkovic - Ruecker", "" },
                    { new Guid("d5533ca1-a18b-c139-6a80-f9a47317df6e"), new DateTime(2027, 5, 24, 23, 16, 9, 364, DateTimeKind.Utc).AddTicks(216), 5501.9200000000001, 50610L, "Fadel, Reichel and Lang", "" },
                    { new Guid("d5ccde73-a45d-f100-aa2a-096f86c85fd5"), new DateTime(2027, 5, 25, 4, 44, 16, 873, DateTimeKind.Utc).AddTicks(950), 7417.9499999999998, 66328L, "Ankunding - Emard", "£" },
                    { new Guid("d62a361b-00d2-9f5d-d278-c961f22e3cdf"), new DateTime(2027, 1, 8, 13, 36, 54, 583, DateTimeKind.Utc).AddTicks(9123), 6950.3800000000001, 37516L, "Mann, Ebert and O'Hara", "" },
                    { new Guid("d6346c72-d87d-61a7-3383-dfdf8003c2ff"), new DateTime(2026, 10, 23, 13, 36, 7, 298, DateTimeKind.Utc).AddTicks(7204), 9405.0799999999999, 5927L, "Jacobs and Sons", "₡" },
                    { new Guid("d664e8a1-39c4-a7c6-102b-c9b67af4feb2"), new DateTime(2026, 10, 12, 12, 54, 22, 756, DateTimeKind.Utc).AddTicks(8248), 4165.8999999999996, 55682L, "Oberbrunner LLC", "Kč" },
                    { new Guid("d692b0cf-8111-0bb8-ce14-9869a4624ad2"), new DateTime(2027, 6, 4, 19, 57, 56, 3, DateTimeKind.Utc).AddTicks(1606), 3109.9400000000001, 81757L, "Stiedemann, Auer and Stamm", "$" },
                    { new Guid("d7a672e5-7344-cd1d-1d15-66bb43931270"), new DateTime(2026, 10, 3, 9, 31, 5, 674, DateTimeKind.Utc).AddTicks(7687), 7783.9099999999999, 78917L, "Mitchell and Sons", "" },
                    { new Guid("d870459e-1a03-f06f-7c2f-829fa457aa4a"), new DateTime(2027, 2, 5, 16, 19, 26, 587, DateTimeKind.Utc).AddTicks(9701), 2394.6599999999999, 14594L, "Muller - Conroy", "" },
                    { new Guid("d87ae43e-659a-c040-1513-ebeb94614d61"), new DateTime(2027, 1, 16, 5, 15, 52, 151, DateTimeKind.Utc).AddTicks(7540), 3646.5100000000002, 18526L, "Wolf, Rath and Hyatt", "" },
                    { new Guid("d8a4876b-a74c-288d-762e-692ac3786ee7"), new DateTime(2027, 7, 11, 22, 18, 26, 213, DateTimeKind.Utc).AddTicks(2910), 1315.46, 12357L, "Leuschke, Schiller and Moore", "" },
                    { new Guid("d8e587db-0be8-b65b-f0ae-cdf9316adaa8"), new DateTime(2027, 3, 1, 5, 55, 0, 82, DateTimeKind.Utc).AddTicks(9526), 7299.0500000000002, 21056L, "Olson, Bosco and Blanda", "" },
                    { new Guid("d8fc81b2-bce8-5b1d-b320-8365f5cb5b4a"), new DateTime(2027, 6, 25, 14, 12, 51, 542, DateTimeKind.Utc).AddTicks(357), 3159.79, 71533L, "Weber, Hammes and Gleichner", "$" },
                    { new Guid("d93ae0f3-452c-dead-f2bb-90e6eea25ac9"), new DateTime(2026, 9, 11, 2, 55, 3, 362, DateTimeKind.Utc).AddTicks(245), 735.26999999999998, 20296L, "Bednar, Wisoky and Nader", "" },
                    { new Guid("d953ff04-865e-6d3b-de16-38c1847c1b54"), new DateTime(2026, 10, 7, 10, 12, 22, 826, DateTimeKind.Utc).AddTicks(7612), 5618.4799999999996, 16288L, "Haag Group", "﷼" },
                    { new Guid("d9db2588-229b-c00a-16a0-1721a5cbaa54"), new DateTime(2026, 9, 13, 10, 23, 32, 508, DateTimeKind.Utc).AddTicks(1049), 7449.8000000000002, 80543L, "O'Kon, McDermott and Weimann", "₫" },
                    { new Guid("d9ed46d2-9998-422c-8826-32a3d227fe19"), new DateTime(2026, 12, 24, 9, 58, 39, 51, DateTimeKind.Utc).AddTicks(6497), 6364.1400000000003, 51440L, "Torp - Bosco", "Bs" },
                    { new Guid("da85ed9b-a422-574c-12bd-406dfdfbd448"), new DateTime(2027, 4, 22, 5, 57, 30, 945, DateTimeKind.Utc).AddTicks(5988), 618.69000000000005, 3972L, "Kemmer, Jakubowski and Paucek", "R" },
                    { new Guid("dac4718f-d195-ead3-6897-1989ca1b6beb"), new DateTime(2027, 5, 4, 4, 38, 24, 721, DateTimeKind.Utc).AddTicks(5513), 1886.8699999999999, 52639L, "Hyatt LLC", "Bs" },
                    { new Guid("db4df98a-5ba4-4ae1-69a1-559c2cfeb3ef"), new DateTime(2027, 2, 2, 15, 32, 58, 714, DateTimeKind.Utc).AddTicks(4928), 8563.7299999999996, 18654L, "Marks - Cole", "Ls" },
                    { new Guid("db975706-1abd-56f5-68ac-354fe81a92f3"), new DateTime(2026, 8, 28, 9, 13, 36, 102, DateTimeKind.Utc).AddTicks(251), 8728.7199999999993, 43753L, "Koepp, Trantow and Reilly", "" },
                    { new Guid("dbfaa5c7-8928-17e8-8eb0-a16ec97619c7"), new DateTime(2026, 10, 21, 19, 18, 33, 676, DateTimeKind.Utc).AddTicks(341), 6308.3100000000004, 26107L, "Dare - Brakus", "₡" },
                    { new Guid("dc09bf04-8bf0-4a8b-c23c-eadf40a8538c"), new DateTime(2026, 10, 9, 15, 7, 43, 299, DateTimeKind.Utc).AddTicks(3499), 9767.8099999999995, 42955L, "Konopelski - Wyman", "" },
                    { new Guid("dcdf2b8e-fc67-24e8-f292-5e88ea9bdd2f"), new DateTime(2027, 7, 28, 5, 56, 9, 373, DateTimeKind.Utc).AddTicks(6527), 7461.1999999999998, 62373L, "Grimes - Russel", "Nu" },
                    { new Guid("dd29ac82-6bbb-b9f8-1d02-02289d234343"), new DateTime(2027, 3, 13, 7, 35, 52, 872, DateTimeKind.Utc).AddTicks(4297), 4554.3199999999997, 91664L, "Lubowitz - Renner", "NT$" },
                    { new Guid("dd3d04f7-011f-ef9a-2579-6d4d4a249403"), new DateTime(2026, 9, 7, 0, 12, 24, 710, DateTimeKind.Utc).AddTicks(2068), 3210.5300000000002, 42103L, "Champlin Inc", "$" },
                    { new Guid("dd3fff49-ddb8-fe9d-99e5-0629ea76d2b2"), new DateTime(2027, 6, 11, 7, 30, 31, 953, DateTimeKind.Utc).AddTicks(1118), 3409.5700000000002, 39018L, "Stracke - Goyette", "¥" },
                    { new Guid("dd7b0f9c-68ed-0a79-b7fb-0ee5367ae0ab"), new DateTime(2026, 10, 4, 7, 33, 54, 201, DateTimeKind.Utc).AddTicks(9270), 9553.7800000000007, 4409L, "Williamson - Ebert", "лв" },
                    { new Guid("ddc44139-133f-0863-3573-d7b80a4a190c"), new DateTime(2027, 2, 13, 16, 4, 33, 559, DateTimeKind.Utc).AddTicks(9860), 7460.96, 91280L, "Jerde Inc", "₺" },
                    { new Guid("ddf4fa2f-1b2d-5ed2-2579-539bd68de023"), new DateTime(2027, 1, 5, 4, 38, 17, 706, DateTimeKind.Utc).AddTicks(8112), 3625.2399999999998, 84053L, "Moen, Miller and Herman", "" },
                    { new Guid("de15f947-589f-ae85-38b5-d4d90a0c4f75"), new DateTime(2026, 8, 8, 21, 43, 38, 728, DateTimeKind.Utc).AddTicks(537), 1210.1500000000001, 75499L, "Aufderhar, Oberbrunner and Hauck", "" },
                    { new Guid("de1beb1d-08d5-37f2-c768-a6ac19227504"), new DateTime(2027, 1, 16, 3, 5, 27, 224, DateTimeKind.Utc).AddTicks(9712), 7488.6099999999997, 63567L, "Dicki, Towne and Raynor", "$" },
                    { new Guid("de2dd6b1-f1a8-cf2d-d585-ec5218e70123"), new DateTime(2026, 10, 24, 16, 21, 22, 258, DateTimeKind.Utc).AddTicks(9256), 5892.9300000000003, 9066L, "Turner, Rowe and Bartoletti", "" },
                    { new Guid("de2de7bb-3ec5-2ea3-8694-a570faf2d796"), new DateTime(2027, 5, 24, 9, 15, 45, 814, DateTimeKind.Utc).AddTicks(3830), 6320.8199999999997, 8516L, "Ondricka - Macejkovic", "" },
                    { new Guid("de585240-7bf7-e3fe-c1db-3412d5c1539c"), new DateTime(2027, 4, 9, 7, 27, 32, 807, DateTimeKind.Utc).AddTicks(4779), 8368.0400000000009, 42717L, "Rogahn, Lindgren and Connelly", "kr" },
                    { new Guid("de910881-4ae7-dd88-d5ff-b7bedf26813e"), new DateTime(2026, 10, 13, 20, 30, 5, 296, DateTimeKind.Utc).AddTicks(4521), 9296.9799999999996, 27587L, "Daniel - Tromp", "" },
                    { new Guid("decccbbe-e92b-7658-6f75-7012aaf49fb9"), new DateTime(2027, 5, 10, 9, 37, 27, 981, DateTimeKind.Utc).AddTicks(9106), 675.36000000000001, 9553L, "Berge, Dickinson and Reichert", "ман" },
                    { new Guid("df1f50a4-1194-226d-baf4-0cce3aed0a53"), new DateTime(2027, 5, 4, 22, 58, 30, 920, DateTimeKind.Utc).AddTicks(4412), 9061.1100000000006, 75909L, "Treutel - Parker", "" },
                    { new Guid("df32ffd0-6e3b-2db0-69c6-6fead68dbf8c"), new DateTime(2026, 11, 9, 18, 36, 12, 504, DateTimeKind.Utc).AddTicks(3212), 7325.1999999999998, 83134L, "O'Reilly Group", "" },
                    { new Guid("df578318-39c9-67e1-43e1-cc9857c2bbff"), new DateTime(2027, 7, 22, 19, 0, 4, 669, DateTimeKind.Utc).AddTicks(246), 6757.0200000000004, 81059L, "Grady - Rempel", "N$" },
                    { new Guid("dfd7c30f-83ba-d800-9c95-226eec17bbe1"), new DateTime(2027, 7, 20, 14, 23, 10, 699, DateTimeKind.Utc).AddTicks(859), 3381.02, 14491L, "Hansen, Mueller and Harvey", "" },
                    { new Guid("e018d08e-c780-f08b-3d11-3e94dd1cf63e"), new DateTime(2027, 1, 22, 6, 26, 29, 649, DateTimeKind.Utc).AddTicks(4988), 4253.5799999999999, 12835L, "Leuschke, Windler and Huels", "₫" },
                    { new Guid("e0b941dc-e6c9-8fa6-d2d2-348ad41ecc9f"), new DateTime(2027, 5, 3, 17, 48, 58, 160, DateTimeKind.Utc).AddTicks(934), 6683.1300000000001, 21620L, "Heller Inc", "руб" },
                    { new Guid("e0c34088-a2f7-b93d-10be-679fc65426db"), new DateTime(2027, 6, 22, 14, 53, 3, 605, DateTimeKind.Utc).AddTicks(3237), 1277.49, 5781L, "Prohaska - Brown", "Nu" },
                    { new Guid("e0dd2aa0-98a8-3dd6-3cd2-d43fd48e7d3c"), new DateTime(2026, 8, 16, 17, 25, 42, 316, DateTimeKind.Utc).AddTicks(3561), 620.05999999999995, 28445L, "Koepp - Swift", "" },
                    { new Guid("e1038d7a-2ded-219e-27ff-e58a3bce209b"), new DateTime(2026, 10, 18, 18, 56, 47, 757, DateTimeKind.Utc).AddTicks(5369), 1572.3499999999999, 48713L, "Kilback, Cruickshank and Heaney", "£" },
                    { new Guid("e17accf1-c9af-0cd3-cdd6-be4ddd4eec40"), new DateTime(2027, 1, 24, 12, 57, 7, 389, DateTimeKind.Utc).AddTicks(5593), 8071.0799999999999, 68788L, "Murphy and Sons", "" },
                    { new Guid("e1812753-8428-3b7a-886d-ba5226d03381"), new DateTime(2027, 4, 27, 17, 29, 32, 14, DateTimeKind.Utc).AddTicks(407), 3667.5599999999999, 72866L, "Pfannerstill - Wehner", "" },
                    { new Guid("e1afc708-a631-19bb-64a0-b5445cdb7363"), new DateTime(2027, 2, 6, 4, 25, 9, 774, DateTimeKind.Utc).AddTicks(2773), 5778.1800000000003, 56169L, "Schamberger LLC", "NT$" },
                    { new Guid("e1be382e-6214-f0eb-56af-c87c4aa61acb"), new DateTime(2027, 3, 29, 0, 47, 19, 671, DateTimeKind.Utc).AddTicks(1036), 2311.0799999999999, 2152L, "Casper - Jaskolski", "₫" },
                    { new Guid("e2ed1e59-50da-1bd2-ed68-3ca507a9f090"), new DateTime(2027, 1, 10, 4, 38, 1, 263, DateTimeKind.Utc).AddTicks(9478), 3637.8400000000001, 68320L, "Heaney - Koepp", "" },
                    { new Guid("e3bb9072-3322-71d6-ffe0-a09be645a90b"), new DateTime(2026, 12, 9, 14, 27, 53, 808, DateTimeKind.Utc).AddTicks(9599), 9912.8099999999995, 68330L, "Murphy Group", "$" },
                    { new Guid("e3bd90f0-fa17-d063-b474-7aa854d12377"), new DateTime(2027, 1, 13, 23, 15, 42, 34, DateTimeKind.Utc).AddTicks(9238), 6079.8599999999997, 29005L, "MacGyver, Conn and Roob", "Gs" },
                    { new Guid("e3fade1c-9ddb-8c2c-bce9-b01230c112a6"), new DateTime(2027, 6, 7, 23, 15, 16, 729, DateTimeKind.Utc).AddTicks(4130), 3016.1799999999998, 43549L, "Cole, Muller and Legros", "" },
                    { new Guid("e405234a-4bb8-13f8-09b8-d6bd7b62dac7"), new DateTime(2026, 11, 26, 11, 15, 8, 916, DateTimeKind.Utc).AddTicks(5806), 1442.79, 12887L, "Dietrich - Herzog", "₪" },
                    { new Guid("e43f88ac-ffbb-611d-7a78-2c9bdb50886d"), new DateTime(2027, 8, 3, 10, 19, 2, 661, DateTimeKind.Utc).AddTicks(9188), 8207.4099999999999, 33027L, "Bergnaum - Koch", "$" },
                    { new Guid("e481e415-e305-9b3f-50b3-6a34ca346163"), new DateTime(2027, 3, 27, 2, 39, 39, 146, DateTimeKind.Utc).AddTicks(4177), 1742.3599999999999, 4760L, "Kuhn Inc", "£" },
                    { new Guid("e4ed2bdc-3e7b-99f6-b187-5cca2b96db84"), new DateTime(2026, 9, 28, 8, 6, 21, 583, DateTimeKind.Utc).AddTicks(7825), 5905.8299999999999, 65466L, "Pagac LLC", "$" },
                    { new Guid("e50b6940-7e94-8bbb-abd4-28d2187b4f79"), new DateTime(2027, 4, 17, 3, 9, 54, 462, DateTimeKind.Utc).AddTicks(3656), 5781.1999999999998, 64883L, "Morissette - DuBuque", "" },
                    { new Guid("e535aec3-8495-d8ac-3be0-faba39c63147"), new DateTime(2027, 6, 7, 9, 32, 11, 462, DateTimeKind.Utc).AddTicks(4119), 8412.7600000000002, 10901L, "Mraz - Weissnat", "₡" },
                    { new Guid("e5997205-83f9-cc50-2dba-484f9687822b"), new DateTime(2027, 4, 24, 2, 18, 57, 398, DateTimeKind.Utc).AddTicks(4748), 2338.1500000000001, 48253L, "Koelpin, Kerluke and Wyman", "Ls" },
                    { new Guid("e5fdbbb5-bf6d-7b5b-201a-272dd941122d"), new DateTime(2027, 5, 6, 4, 40, 9, 635, DateTimeKind.Utc).AddTicks(2349), 1057.8599999999999, 15064L, "Stroman - Shields", "B/." },
                    { new Guid("e6284836-2c6b-fc6f-7683-0d51a4455e29"), new DateTime(2027, 6, 5, 10, 42, 38, 947, DateTimeKind.Utc).AddTicks(843), 3112.48, 58674L, "White - Emmerich", "лв" },
                    { new Guid("e650836a-3440-bf03-7f83-7e2e6da23ac8"), new DateTime(2026, 9, 6, 8, 53, 37, 267, DateTimeKind.Utc).AddTicks(3241), 8121.1000000000004, 119L, "Heidenreich - Considine", "" },
                    { new Guid("e655ea30-4ab4-146d-4f79-c13b7337f9f7"), new DateTime(2027, 4, 28, 6, 5, 52, 572, DateTimeKind.Utc).AddTicks(5005), 1850.3, 40088L, "Torphy - Bogan", "" },
                    { new Guid("e6aebe02-88f2-6956-8a44-f4cf72e4856f"), new DateTime(2026, 12, 19, 7, 32, 4, 840, DateTimeKind.Utc).AddTicks(195), 6876.3800000000001, 35560L, "Mayer, Stiedemann and Jacobson", "¥" },
                    { new Guid("e6ea0853-7837-359a-3469-d0e6c83bfa35"), new DateTime(2026, 9, 23, 3, 46, 14, 766, DateTimeKind.Utc).AddTicks(3475), 6800.5500000000002, 8680L, "Lehner Inc", "" },
                    { new Guid("e6ec1888-d774-ab78-fb0b-510b66db2ff4"), new DateTime(2027, 2, 19, 15, 54, 6, 66, DateTimeKind.Utc).AddTicks(2089), 9675.8299999999999, 37218L, "Steuber - D'Amore", "" },
                    { new Guid("e734065c-f238-37d8-c7c7-37dcd3211f03"), new DateTime(2027, 5, 13, 1, 52, 24, 587, DateTimeKind.Utc).AddTicks(822), 135.41999999999999, 26791L, "Effertz and Sons", "C$" },
                    { new Guid("e7477a1c-d750-c060-8b0f-b44d958630fd"), new DateTime(2027, 7, 5, 7, 44, 28, 38, DateTimeKind.Utc).AddTicks(9710), 2481.9299999999998, 62741L, "Armstrong, Fay and Boyle", "S" },
                    { new Guid("e74a3c17-87ab-f620-c8ba-f8f50040f69f"), new DateTime(2026, 10, 16, 21, 50, 26, 982, DateTimeKind.Utc).AddTicks(5544), 4235.6400000000003, 20482L, "Kulas, Parker and Keebler", "" },
                    { new Guid("e7957e8d-7279-0fc2-3ae3-17d5d8636470"), new DateTime(2026, 9, 5, 13, 35, 30, 397, DateTimeKind.Utc).AddTicks(1377), 8383.1399999999994, 90395L, "Emard - Watsica", "BZ$" },
                    { new Guid("e7b15111-014c-b180-cb5f-92d40ef07559"), new DateTime(2026, 8, 22, 2, 24, 25, 294, DateTimeKind.Utc).AddTicks(796), 1508.98, 33273L, "Lemke and Sons", "" },
                    { new Guid("e7c68bf5-2a2b-8617-cc31-ee8a2a70bd2b"), new DateTime(2027, 3, 12, 4, 13, 35, 247, DateTimeKind.Utc).AddTicks(2110), 1422.8399999999999, 71472L, "Ratke, Cole and Barrows", "Ft" },
                    { new Guid("e860c0d9-1e88-41b6-1d35-bac5e51ab3bd"), new DateTime(2026, 11, 16, 13, 1, 57, 918, DateTimeKind.Utc).AddTicks(3124), 6186.9099999999999, 28589L, "Schmitt - Jaskolski", "" },
                    { new Guid("e87c0bc3-10a0-5ff5-b4f6-76b659fdd439"), new DateTime(2027, 1, 22, 5, 54, 38, 745, DateTimeKind.Utc).AddTicks(747), 8521.6399999999994, 27326L, "Beahan - Schuster", "$" },
                    { new Guid("e90f0297-d940-daca-b1fd-9c449963315c"), new DateTime(2026, 9, 10, 14, 19, 59, 110, DateTimeKind.Utc).AddTicks(6384), 4824.5200000000004, 93822L, "Boyle, Reichert and Walsh", "" },
                    { new Guid("e93e1048-0131-89d0-df85-fdba0a727a7e"), new DateTime(2027, 4, 26, 4, 48, 20, 676, DateTimeKind.Utc).AddTicks(3124), 3449.4000000000001, 68983L, "Hansen LLC", "$" },
                    { new Guid("e979766c-19a4-c068-de88-3bc5e12db020"), new DateTime(2026, 10, 13, 15, 56, 14, 530, DateTimeKind.Utc).AddTicks(8812), 3170.3800000000001, 19973L, "Altenwerth, Maggio and Schinner", "P" },
                    { new Guid("ea0ffcb0-7a4d-5820-0394-c17125f0d635"), new DateTime(2026, 9, 12, 2, 10, 42, 32, DateTimeKind.Utc).AddTicks(6404), 3864.23, 72662L, "Cruickshank - Conn", "₫" },
                    { new Guid("ea1cf46f-fd83-5981-0d4a-400814a6b678"), new DateTime(2026, 12, 13, 22, 21, 56, 11, DateTimeKind.Utc).AddTicks(4070), 7208.29, 84122L, "Skiles Inc", "" },
                    { new Guid("ea77061f-c9f5-7a15-30b2-9465baf3fbf7"), new DateTime(2026, 8, 15, 21, 38, 51, 419, DateTimeKind.Utc).AddTicks(1182), 9331.6000000000004, 8597L, "Mante and Sons", "Db" },
                    { new Guid("ea7a33df-1d02-4d62-cfd9-3943b01e159f"), new DateTime(2027, 1, 12, 15, 57, 59, 857, DateTimeKind.Utc).AddTicks(7325), 6531.04, 45394L, "Wolff LLC", "" },
                    { new Guid("ea996c5c-843d-936d-766d-e13ed82ac712"), new DateTime(2027, 3, 2, 4, 39, 33, 326, DateTimeKind.Utc).AddTicks(832), 1915.46, 22585L, "Nicolas, Bergnaum and Watsica", "лв" },
                    { new Guid("eaa2362d-502e-fe93-1131-18bf96013229"), new DateTime(2027, 7, 22, 18, 43, 31, 4, DateTimeKind.Utc).AddTicks(5620), 2776.6500000000001, 24481L, "Padberg, Funk and Spencer", "лв" },
                    { new Guid("eab2dd63-6df9-6a6b-cd81-9d408b2543ca"), new DateTime(2027, 6, 16, 12, 38, 20, 943, DateTimeKind.Utc).AddTicks(3354), 1034.8699999999999, 92733L, "Reichert, Cartwright and Hand", "" },
                    { new Guid("eb5cabd3-9ff0-4ce8-fa4a-a5359672d9e1"), new DateTime(2027, 8, 5, 2, 26, 30, 833, DateTimeKind.Utc).AddTicks(7876), 8914.6000000000004, 22816L, "Predovic Group", "£" },
                    { new Guid("eb8f3381-c980-3892-2212-e8b6ec0a2c56"), new DateTime(2026, 12, 27, 1, 58, 32, 218, DateTimeKind.Utc).AddTicks(4236), 1067.96, 4712L, "Lynch - Thiel", "" },
                    { new Guid("eba83bdc-0fa4-04d3-c889-00f82c7acfee"), new DateTime(2026, 10, 10, 13, 15, 34, 290, DateTimeKind.Utc).AddTicks(5579), 3441.73, 44145L, "Russel, Runolfsdottir and Lakin", "$" },
                    { new Guid("ebbcfa75-a2ae-9b98-b4f4-731c92e489a9"), new DateTime(2027, 1, 13, 2, 53, 36, 894, DateTimeKind.Utc).AddTicks(5451), 1960.26, 16924L, "Baumbach - Nitzsche", "" },
                    { new Guid("ebc195ef-3b7a-d701-b25b-ab25c579834c"), new DateTime(2027, 4, 3, 7, 19, 23, 518, DateTimeKind.Utc).AddTicks(9508), 3355.9299999999998, 44171L, "Satterfield, Klein and Kshlerin", "$" },
                    { new Guid("ebdd56fa-d974-96ff-58fe-491c8767bbcd"), new DateTime(2026, 11, 11, 11, 21, 11, 764, DateTimeKind.Utc).AddTicks(882), 1635.9100000000001, 13554L, "Brekke - Nader", "" },
                    { new Guid("ec35e699-b21d-9aac-f9ce-dfaa338a5ef1"), new DateTime(2027, 5, 12, 5, 8, 17, 560, DateTimeKind.Utc).AddTicks(1970), 8182.8999999999996, 5798L, "Stoltenberg - Stamm", "kr" },
                    { new Guid("ec3e222f-485c-bbf4-a988-92029b8557cf"), new DateTime(2026, 8, 19, 13, 19, 32, 955, DateTimeKind.Utc).AddTicks(7798), 589.88999999999999, 11755L, "Leuschke, McDermott and Senger", "$" },
                    { new Guid("ec588ebe-3258-4a11-1728-74b2fb40bf93"), new DateTime(2026, 11, 17, 0, 25, 51, 492, DateTimeKind.Utc).AddTicks(6979), 3736.9400000000001, 25003L, "Schmeler - Smitham", "J$" },
                    { new Guid("ec9a92b0-ac26-6fd4-409e-3b9be3443098"), new DateTime(2027, 5, 12, 2, 26, 21, 782, DateTimeKind.Utc).AddTicks(1495), 3936.1199999999999, 99364L, "Schuppe - Murphy", "Ls" },
                    { new Guid("ec9f5db0-752a-0e24-01b1-7966ce67ad0a"), new DateTime(2026, 9, 4, 21, 51, 10, 798, DateTimeKind.Utc).AddTicks(5555), 3986.3699999999999, 64753L, "Kuhn - Grimes", "" },
                    { new Guid("ecef8332-76b7-12a7-774a-c0bfde1d5a3a"), new DateTime(2027, 6, 3, 1, 50, 15, 130, DateTimeKind.Utc).AddTicks(1080), 8382.1299999999992, 44118L, "Nienow - Runolfsson", "" },
                    { new Guid("ee27a451-203a-f669-2797-5e203c81e4e1"), new DateTime(2027, 4, 21, 21, 19, 52, 703, DateTimeKind.Utc).AddTicks(4874), 1327.01, 47100L, "Powlowski - Hayes", "₨" },
                    { new Guid("ee3df0e0-d987-4e6c-eef3-bbfa8036f4f1"), new DateTime(2026, 12, 7, 20, 56, 44, 517, DateTimeKind.Utc).AddTicks(8698), 9554.3299999999999, 26832L, "Ferry, Wolf and Flatley", "KM" },
                    { new Guid("ee6420df-72e7-bb72-7e95-56df5da9a7ee"), new DateTime(2027, 8, 3, 14, 23, 39, 781, DateTimeKind.Utc).AddTicks(1441), 5104.6499999999996, 43858L, "Green, Gusikowski and Paucek", "¥" },
                    { new Guid("ee9c098d-383c-3ca0-4125-20ee981f3bf7"), new DateTime(2026, 10, 4, 23, 42, 32, 813, DateTimeKind.Utc).AddTicks(4470), 655.05999999999995, 40629L, "Grady, Mraz and Bashirian", "" },
                    { new Guid("eec7bea9-a77b-abbd-a25e-92f8fb69d152"), new DateTime(2027, 5, 6, 13, 55, 27, 384, DateTimeKind.Utc).AddTicks(2965), 8914.9500000000007, 82219L, "Orn, Wuckert and Dickinson", "$" },
                    { new Guid("ef465e20-44b5-5a37-9586-bb7f12ef06c0"), new DateTime(2027, 1, 12, 3, 1, 6, 999, DateTimeKind.Utc).AddTicks(8519), 3378.02, 28894L, "Windler, Torphy and Jacobs", "" },
                    { new Guid("ef69fb99-c430-5d38-ef68-96eb4bf99dd1"), new DateTime(2026, 12, 24, 19, 12, 3, 628, DateTimeKind.Utc).AddTicks(6965), 2570.9699999999998, 15772L, "Howe and Sons", "₦" },
                    { new Guid("ef863cfb-98a5-dabb-f519-55e467bbb567"), new DateTime(2027, 5, 14, 9, 51, 3, 199, DateTimeKind.Utc).AddTicks(5515), 7954.3599999999997, 64197L, "Feest - Collier", "lei" },
                    { new Guid("f02d7f2e-659c-2ded-c3de-73ba88a37db0"), new DateTime(2027, 4, 7, 20, 8, 50, 981, DateTimeKind.Utc).AddTicks(1839), 7337.6000000000004, 46634L, "Friesen - Hansen", "" },
                    { new Guid("f04a2a1b-b296-7bf3-d163-b0b48b3964d5"), new DateTime(2027, 3, 22, 2, 2, 12, 789, DateTimeKind.Utc).AddTicks(503), 772.44000000000005, 3441L, "Kirlin - Hermann", "" },
                    { new Guid("f058e03c-970f-5c64-0aa8-48ecab1e1c8e"), new DateTime(2027, 1, 18, 5, 22, 12, 813, DateTimeKind.Utc).AddTicks(6753), 1309.27, 57164L, "Ledner, Raynor and Abbott", "$" },
                    { new Guid("f06cf036-e85f-d5e6-6219-3b673b5361e9"), new DateTime(2026, 10, 27, 14, 50, 18, 463, DateTimeKind.Utc).AddTicks(7875), 5417.3599999999997, 23946L, "Crona - Huels", "$" },
                    { new Guid("f0cdea2a-7375-5bd9-9e77-44646db4e3c1"), new DateTime(2027, 7, 19, 4, 49, 11, 917, DateTimeKind.Utc).AddTicks(8766), 8026.6599999999999, 56782L, "Wunsch Group", "ƒ" },
                    { new Guid("f15049da-66b4-6be7-d874-89816c82e6a6"), new DateTime(2027, 4, 24, 14, 36, 42, 361, DateTimeKind.Utc).AddTicks(6185), 8822.9300000000003, 63812L, "Douglas - Frami", "S/." },
                    { new Guid("f187de33-a024-f134-d238-038ac99dfe10"), new DateTime(2027, 7, 22, 6, 5, 10, 52, DateTimeKind.Utc).AddTicks(616), 1647.3199999999999, 568L, "Powlowski - Stark", "kr" },
                    { new Guid("f20d6dbd-d3e5-58cb-edb4-1599af0c5de3"), new DateTime(2027, 1, 30, 1, 13, 37, 170, DateTimeKind.Utc).AddTicks(7485), 6650.4399999999996, 94084L, "Roberts Inc", "﷼" },
                    { new Guid("f246761c-43f1-51fe-0231-6605c806b67a"), new DateTime(2027, 7, 30, 16, 18, 32, 885, DateTimeKind.Utc).AddTicks(4386), 8475.6200000000008, 91225L, "Grimes, Halvorson and Hintz", "" },
                    { new Guid("f29b302a-3b11-3de2-2bc6-1c4dc7187ba0"), new DateTime(2026, 10, 23, 7, 19, 31, 336, DateTimeKind.Utc).AddTicks(3212), 72.629999999999995, 84622L, "Runolfsdottir Group", "NT$" },
                    { new Guid("f2ae15e0-3f8b-b012-bba1-08cea30900a4"), new DateTime(2027, 1, 3, 8, 56, 36, 33, DateTimeKind.Utc).AddTicks(4458), 4080.0799999999999, 18092L, "Ritchie - Sipes", "€" },
                    { new Guid("f3f2b95f-6fd4-4dd1-8304-bfbee3b0932a"), new DateTime(2027, 6, 15, 16, 27, 34, 95, DateTimeKind.Utc).AddTicks(2004), 8900.4699999999993, 67293L, "Rosenbaum and Sons", "J$" },
                    { new Guid("f4116c9c-25e0-1afe-bf10-9e968492bd10"), new DateTime(2026, 8, 25, 16, 56, 54, 491, DateTimeKind.Utc).AddTicks(25), 9384.0400000000009, 71560L, "O'Reilly - Johnson", "₡" },
                    { new Guid("f421eca4-ff2e-2e7b-ab07-1d9dbdc2522b"), new DateTime(2026, 8, 14, 16, 50, 30, 964, DateTimeKind.Utc).AddTicks(4699), 8596.6100000000006, 27406L, "Hermann LLC", "L" },
                    { new Guid("f4813ad6-a3f8-c65d-05de-c098aef59d08"), new DateTime(2027, 2, 14, 5, 36, 38, 365, DateTimeKind.Utc).AddTicks(3159), 6415.5200000000004, 93212L, "Frami, Renner and O'Connell", "€" },
                    { new Guid("f4845e54-4831-1a1e-ecd5-61ebbb4b6bdc"), new DateTime(2027, 1, 8, 2, 50, 49, 390, DateTimeKind.Utc).AddTicks(9517), 3548.4099999999999, 23609L, "Thiel - Flatley", "﷼" },
                    { new Guid("f48998f2-d7f7-3a27-1407-c86189076185"), new DateTime(2026, 10, 28, 16, 58, 19, 293, DateTimeKind.Utc).AddTicks(1797), 5132.8500000000004, 15155L, "Daugherty, Jerde and Mills", "" },
                    { new Guid("f4a9d858-692f-bbdc-105f-993e106e7d55"), new DateTime(2027, 5, 18, 23, 18, 41, 119, DateTimeKind.Utc).AddTicks(6005), 5634.5299999999997, 88055L, "Kunze - Cole", "" },
                    { new Guid("f5bf2c61-87b7-1a93-5325-ef8ddc2e3f03"), new DateTime(2027, 5, 5, 15, 7, 38, 131, DateTimeKind.Utc).AddTicks(3206), 2675.48, 77313L, "Veum Group", "$" },
                    { new Guid("f5da2d12-823c-908f-8f36-36fbccff2d58"), new DateTime(2027, 1, 26, 3, 43, 4, 357, DateTimeKind.Utc).AddTicks(640), 1671.6700000000001, 77170L, "Cole, Cruickshank and Bins", "﷼" },
                    { new Guid("f5e7900d-371e-7665-355a-74f8be756b8f"), new DateTime(2027, 6, 12, 1, 38, 8, 608, DateTimeKind.Utc).AddTicks(5114), 202.94, 79061L, "Miller, Veum and Kris", "" },
                    { new Guid("f60364bf-c90e-9f33-3834-25acd098ef70"), new DateTime(2027, 7, 26, 11, 59, 15, 237, DateTimeKind.Utc).AddTicks(6635), 5332.9200000000001, 53504L, "Mills - Pollich", "ден" },
                    { new Guid("f67257d3-7dfa-a7b4-e857-db928ea0ecf8"), new DateTime(2027, 6, 24, 20, 39, 53, 602, DateTimeKind.Utc).AddTicks(2022), 7246.5799999999999, 24589L, "Gaylord - Bayer", "L" },
                    { new Guid("f6ca0c0e-9e7d-6892-b186-dfb1bf63e5d8"), new DateTime(2027, 6, 20, 13, 27, 24, 805, DateTimeKind.Utc).AddTicks(3572), 4394.6199999999999, 21570L, "Konopelski Group", "" },
                    { new Guid("f720e954-142f-8f65-ebc9-f10bd32aff1c"), new DateTime(2027, 7, 27, 20, 41, 22, 812, DateTimeKind.Utc).AddTicks(9820), 3521.04, 95817L, "Harvey Inc", "" },
                    { new Guid("f74c3c2b-e6b5-7ff7-c0c7-eb07823a0a68"), new DateTime(2027, 3, 10, 15, 51, 16, 843, DateTimeKind.Utc).AddTicks(2587), 3189.7199999999998, 44630L, "Fritsch and Sons", "ман" },
                    { new Guid("f751033c-230f-c676-ebec-8ea20f4eb22c"), new DateTime(2026, 8, 13, 11, 43, 42, 140, DateTimeKind.Utc).AddTicks(6406), 7036.1300000000001, 20754L, "Goyette - Boyer", "Q" },
                    { new Guid("f764159f-4cea-4223-bab0-b25cd1eb83f2"), new DateTime(2027, 6, 14, 14, 57, 2, 951, DateTimeKind.Utc).AddTicks(9664), 4366.9499999999998, 88122L, "Turcotte and Sons", "" },
                    { new Guid("f7d2a351-2b37-fe07-4974-b35460fee0d1"), new DateTime(2026, 8, 13, 2, 22, 50, 682, DateTimeKind.Utc).AddTicks(6928), 123.34999999999999, 92262L, "Nolan and Sons", "R$" },
                    { new Guid("f865fd58-bc8a-ff51-81a2-eb9531026889"), new DateTime(2027, 7, 13, 10, 36, 29, 729, DateTimeKind.Utc).AddTicks(4304), 5538.2700000000004, 61879L, "Kshlerin, Braun and Koch", "฿" },
                    { new Guid("f8ac0900-0049-456a-7278-254e547891f5"), new DateTime(2026, 12, 27, 17, 3, 38, 302, DateTimeKind.Utc).AddTicks(4872), 5580.1000000000004, 21825L, "Farrell - Toy", "Bs" },
                    { new Guid("f8be7536-005b-e8ae-0f31-fd606d337ccd"), new DateTime(2026, 11, 23, 2, 0, 49, 107, DateTimeKind.Utc).AddTicks(4987), 1776.96, 88216L, "Bahringer, Becker and Barton", "﷼" },
                    { new Guid("f8dfc6e7-e20f-ba9c-caa8-c56c14868138"), new DateTime(2026, 8, 25, 6, 51, 47, 508, DateTimeKind.Utc).AddTicks(8823), 3769.3800000000001, 45765L, "Kuvalis Inc", "₺" },
                    { new Guid("f9837551-f677-4447-2bdb-28a4687cef7e"), new DateTime(2027, 4, 29, 2, 29, 40, 112, DateTimeKind.Utc).AddTicks(6612), 9842.4300000000003, 70768L, "Keeling Inc", "" },
                    { new Guid("fa26181c-3918-87db-23c0-5118a053f132"), new DateTime(2026, 8, 13, 1, 15, 23, 823, DateTimeKind.Utc).AddTicks(453), 8165.6099999999997, 62489L, "Medhurst, Kshlerin and Willms", "" },
                    { new Guid("fa6640e1-5fe6-48f0-7863-b61a42ea65f9"), new DateTime(2027, 4, 1, 19, 40, 11, 402, DateTimeKind.Utc).AddTicks(3568), 9852.0799999999999, 13931L, "Kuphal Inc", "" },
                    { new Guid("fa8e557d-8d2a-dfbd-245b-dd8837ea8d33"), new DateTime(2027, 4, 24, 5, 6, 4, 712, DateTimeKind.Utc).AddTicks(3531), 6385.3400000000001, 98400L, "Mitchell - Bogan", "" },
                    { new Guid("faa3df53-ce3d-6524-5949-db684a56b95a"), new DateTime(2027, 7, 14, 4, 45, 20, 64, DateTimeKind.Utc).AddTicks(2296), 2305.71, 9992L, "Jacobson - Reynolds", "" },
                    { new Guid("fab36099-f1ac-795e-6329-562962b539ca"), new DateTime(2026, 9, 19, 10, 3, 14, 345, DateTimeKind.Utc).AddTicks(5532), 6255.3999999999996, 26503L, "Stanton - Altenwerth", "ман" },
                    { new Guid("fb2e716c-58ff-98ad-805e-c292f6debfdb"), new DateTime(2026, 8, 11, 0, 11, 46, 523, DateTimeKind.Utc).AddTicks(5131), 6421.71, 43900L, "Schroeder - Hills", "₨" },
                    { new Guid("fba260c6-4724-e773-c1d2-833b0ccdea83"), new DateTime(2027, 5, 31, 6, 12, 35, 648, DateTimeKind.Utc).AddTicks(1542), 8065.7299999999996, 63748L, "Predovic Group", "" },
                    { new Guid("fbd3ea89-1d84-eaaf-171b-204574cbed4c"), new DateTime(2027, 1, 19, 18, 23, 45, 57, DateTimeKind.Utc).AddTicks(1551), 7273.2399999999998, 90386L, "Jones - Pfeffer", "" },
                    { new Guid("fbdb2107-ef44-2d15-aa90-e59b247c8501"), new DateTime(2026, 9, 12, 11, 47, 0, 582, DateTimeKind.Utc).AddTicks(5898), 6958.1499999999996, 89968L, "D'Amore - Thiel", "" },
                    { new Guid("fc4b70aa-c92b-69d5-8503-dc10cc81aee8"), new DateTime(2027, 2, 2, 19, 5, 18, 125, DateTimeKind.Utc).AddTicks(8010), 800.03999999999996, 75020L, "Reichel Inc", "" },
                    { new Guid("fcf86a7b-47a9-d244-00ff-070f2734e1e5"), new DateTime(2027, 2, 1, 13, 38, 7, 248, DateTimeKind.Utc).AddTicks(6008), 904.75, 18004L, "Gleichner, Moore and Rosenbaum", "$" },
                    { new Guid("fd6828f8-14ee-14f1-94d8-831f270f7592"), new DateTime(2026, 9, 1, 22, 49, 45, 49, DateTimeKind.Utc).AddTicks(2767), 2660.1300000000001, 85125L, "Beatty - Toy", "lei" },
                    { new Guid("fd8255c9-c30c-5675-eead-4926f0c151d6"), new DateTime(2026, 10, 17, 11, 25, 17, 769, DateTimeKind.Utc).AddTicks(2727), 5448.8299999999999, 68552L, "Wolf, Weissnat and Emmerich", "£" },
                    { new Guid("fe11f867-a3c6-46f6-f00d-65e8a52847c9"), new DateTime(2026, 10, 14, 10, 7, 47, 855, DateTimeKind.Utc).AddTicks(4091), 5312.0200000000004, 85647L, "Green, Christiansen and Hermann", "" },
                    { new Guid("fe1fbc3b-f7d7-caf9-2242-cc533c28a961"), new DateTime(2027, 1, 1, 7, 7, 56, 340, DateTimeKind.Utc).AddTicks(4253), 8809.2000000000007, 63078L, "Smith, Will and Rowe", "₩" },
                    { new Guid("fe250b86-c37d-091a-a708-2f02a270cc27"), new DateTime(2027, 5, 16, 4, 44, 53, 357, DateTimeKind.Utc).AddTicks(4420), 1088.24, 62736L, "Daniel LLC", "$" },
                    { new Guid("fecb35a1-0bea-06f3-9362-1aff05a54708"), new DateTime(2026, 9, 16, 5, 43, 27, 982, DateTimeKind.Utc).AddTicks(7547), 5624.6499999999996, 53360L, "Halvorson Group", "" },
                    { new Guid("ff2fd3fb-03e9-7ce2-6cc5-0bf23b903314"), new DateTime(2027, 1, 19, 16, 45, 36, 505, DateTimeKind.Utc).AddTicks(601), 1532.54, 87057L, "Ullrich, Schoen and Roob", "C$" },
                    { new Guid("ff6c57bd-82aa-9184-5527-96a4780fc8e8"), new DateTime(2027, 7, 17, 22, 43, 47, 416, DateTimeKind.Utc).AddTicks(7265), 2350.8200000000002, 66516L, "Ritchie and Sons", "$" },
                    { new Guid("ff8ad2d9-b854-33d5-2a3b-bcb0172b5484"), new DateTime(2026, 9, 6, 8, 45, 40, 487, DateTimeKind.Utc).AddTicks(8356), 6809.8500000000004, 1206L, "Schaefer - Pacocha", "" },
                    { new Guid("ffdd2354-6b18-5f4d-0a81-ee3e78e8d45b"), new DateTime(2026, 11, 23, 22, 24, 18, 254, DateTimeKind.Utc).AddTicks(2547), 1283.45, 94765L, "Spinka, Borer and Dietrich", "" },
                    { new Guid("fff96342-8e9e-34d5-4976-1abc786f1c46"), new DateTime(2027, 4, 12, 3, 53, 9, 785, DateTimeKind.Utc).AddTicks(4806), 2062.1199999999999, 43331L, "Raynor, Schmidt and Ratke", "$" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("00169571-229e-1f5b-8721-bfb1d952a2e6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("005ad229-a2a2-667b-1078-ff2081fc03a4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0061b8ad-4a19-7ec3-6a56-7ee4bcb99485"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("00754472-05c6-05ae-cb4e-2410d546b4a3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("00802371-f1c9-a9e0-5696-2d8f286d2082"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("00b27d9f-2035-6b20-69e0-75767ba6179a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("00df9efd-b340-31b9-1f7b-8d06b39cb1f8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("010440c0-01f1-2799-7179-d3d5aa42c7bf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("01d4cf3c-a5a6-501b-db1f-6ccdb87f4fed"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("01e79412-23c0-fedc-3ede-502ec5d7eabe"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("01eb7423-d8df-f3c2-f4d4-163ad975a61e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("01f37192-2eb0-9afa-f258-3cafeb868e1c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("025951a3-6e9b-a6e0-fc38-2a7e67746e0c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("026179fb-6366-587e-47fc-a0106ce4a87c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("02bab5af-da41-dda8-2673-4a0fb23e788c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("03131ab3-b51c-c888-2b5f-a44740c8f40b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0362aef5-c1d3-0564-f120-b80b8e96d7d7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0365cb57-4d72-1949-8554-522f8dfff504"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("03775e33-63b3-7dd7-310b-bec6b02cb285"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0378f923-7cd2-d9b2-c871-34b77ee238d1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("03c62b53-fa38-18db-1d6a-78e9658b049e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("03c64df0-1b68-6936-4f36-54401785d8f0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("03df7668-6842-d0fe-4b16-1ebeaaa494d1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("03ee69ae-d957-8704-4858-5dd45615f6e4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0570e33d-f832-bc0a-36c6-331710e88ae6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0599cb8d-dc7e-695c-2218-349c464779b0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("05b288c1-238b-26f1-5163-794459ccac06"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("06b6e1e6-f38a-8129-c7c2-bf0c7b0d9fe2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("06ba630a-f151-5157-dc64-5ff81db33f15"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("06e7a0fb-68e1-cd4b-adef-3c38d2113e3a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("072076fa-051a-4048-396c-12ed168e0413"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("074b6738-3a18-c2f8-9425-bc9cdb5e34fc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0793c009-40e5-c835-ef05-f4acc62c0788"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("07e1f565-9464-3bcd-f817-4a2c71fc1066"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0888e797-87f7-2f84-e38d-a04706841996"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("08a5f8a9-e773-cf13-ac62-ddc4282199d2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("08ff2009-6f0f-dca5-0b3b-69b1418bd596"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("08ff9876-774b-c96b-f2c4-b15d32a64e00"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("091de8d0-ee47-9b84-1ab3-1b3986e6356c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0966f020-5c98-a49c-03e6-04de417e9711"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("098b6ecc-5714-b09a-36cf-d6280bb3c707"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("09cf8d21-4bef-674e-22e3-717b065c0529"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0a363319-6d5e-cb0b-0906-a887caed9ee9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0aadb675-ad70-73e1-6335-248b9b8d5a4f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0b424345-ac1a-f5e5-88e9-d72edb4b0b37"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0b472700-f4e5-2fde-0478-e97c23b8001a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0b679869-5392-a8b6-2c34-7adf470786da"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0b6d82ee-ca51-675a-3d21-950fbb21e891"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0bd0bf25-e516-0354-b8a6-aa71bae89d6a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0bf4dc5d-8a6a-dba7-eac1-6417732308ea"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0c0012dc-a9cf-916e-1a1e-346569b2533f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0c5c3e37-1bb8-9526-afaa-5524951b9a14"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0c615dbb-36a2-5d9d-c820-3523c9cd0d4b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0ca38fdd-9c50-1b5d-4abc-60bcfc7a4094"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0ca4181b-2620-f988-72f8-90961234a2df"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0d062f64-b4ec-2168-5c6e-f3553416f0d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0d179ca5-49a6-c241-daa4-4e368bf846de"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0d61cab4-079e-95d9-eb33-891f92b7f7b4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0da5b4af-42a5-1be1-3a08-99108ea588a1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0e1b6d51-0518-a19f-0abf-5f9db9126d18"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0e1de641-0cf1-5a6d-0644-6ef3df5f932b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0e30ae4b-c64a-6797-68a3-c011ea1a231f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0e52aed8-2b54-f39d-494d-ea4e84cae0e7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0e5dd057-0733-3bca-ca73-80e57cb327f1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0ed89a06-fea1-1516-cac5-468a06072911"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0ef5e0e4-0571-7e2d-efe9-b3e53e429bcf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0f1afa0c-67f3-3029-6685-3324a1995e9c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0f478f4c-975f-d30b-920b-bfde080779b7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0f4a4da7-63c6-e198-0e78-b6b2cc2b58f3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("0f98133a-952b-370a-3c0d-c0ebf649e5ea"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("10638ec8-d1f3-8510-7364-ca29d8156922"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("10808bfa-4bfe-15cf-a339-fed11a93e926"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("10c15313-22ee-714f-53ec-c87ce3ad5551"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("10c23b2e-5959-c714-e16a-751004364871"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1101c5f4-a724-ea39-bab6-cc9733fbd8e5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("11115780-1f8e-a92c-cce4-61c0c8c198d4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("11284ab8-052f-8592-8bec-19bb4d15acb9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1141948a-5315-8d1a-fc0b-4666dbbd8e94"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("115795bb-8e43-9905-bed3-7f23c53d4f9c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("118d63ea-636b-47ce-aecf-b3bef89e8f4f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("11d95557-0dd3-eb83-f1d7-37d2b0da5007"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1216ee5a-4f64-aadb-d5b9-9cfe69251ed5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1237f4be-cd74-6dd2-7ca2-2e6daac34152"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("126a230b-44b5-32e7-23db-8e6059f21f8c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("13412e73-f410-df4f-f886-2f887e361070"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("13a15f40-7b5a-bb16-f515-1b5051bb3c22"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("13b21b6f-872e-e65a-af0f-82e46b34a44c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("13ce50a9-2c4f-59af-21d4-12608eee1845"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("13dab998-2c53-3c6b-47cd-164ebf45dcf5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("13f36d03-6ac8-5a30-9c1c-bd63900594ba"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("14425992-c857-e39e-c155-96bfc2dd0161"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("14562bd5-90f8-9064-6bbc-bed9f68e89c6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("14582bbf-8109-1cb2-4d90-ee1b7e732450"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("148573a1-266d-eabc-e6d1-4ee2184ea439"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("148833ad-f8d5-914f-fa4c-0fe845c0385d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1489e9ea-4b93-14e1-37c4-a7d24a402885"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1511f43e-b2e7-0856-e957-c95d7bca54f3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("15b7c6f5-45c1-d3be-4da8-95ec846e31d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("164d1dc3-fd02-67a9-96e9-86746e88e7cf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("16811694-7d17-e93a-155e-dc307fb3fe82"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("16ab8c5d-80e1-d350-389b-ed2052b9bd4b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("17476a1b-91d8-904f-fb8e-b4b0c857f077"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("174af80b-fd3e-841d-62c0-09ca91815435"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("17591031-9ed3-e5c7-1975-550d97abe757"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("17e99a11-dfff-5612-6eb0-a669756cf566"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("185a0589-a29f-16d5-bd50-7a08cfa28551"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("190110a3-5331-b961-a532-d071d91fe6e9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1901167e-6596-cc6f-3db6-b95c0431451d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("191d9535-41f8-a7e5-5e47-dffa50b1307c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("198a485a-5c30-0e3e-c62d-281b63125090"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("19ddf8d2-94e8-5214-6a74-fccf260329c6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1a438df7-304d-239c-d30c-9d3e2eecc81f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1a5b35bf-f287-8b10-385d-cad3e712aeb6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b1c691f-6a2c-8fff-e7fe-e085856de3c5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b31b2eb-5b32-619b-b344-92baf5d2a3c1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b42904a-f20c-bb4f-2c0b-637ff68ccc9d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b484a2b-e9ff-571e-410d-2ff4a0a29704"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b51bad3-86b4-1335-d89b-02a8a7f078eb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b78fb46-19b6-6846-5a76-55c8087ac590"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1b959cbd-2b6f-1397-0c53-d77f212db57d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1bd262c7-42c3-3466-5e63-76f8653fd88b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1c107289-bccd-fea9-37ef-1efec18fe13b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1c4aefcf-3f50-1dbe-bc37-dc2c83eba16a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1c582406-f88d-fcf9-66cf-7645d14c44f8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1d026139-d5a5-f43d-fdb1-69142f5c2053"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1d0557d0-384a-00e1-8f49-74c8e0efba78"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1d0bcb70-9c0b-d0f2-d489-000376a4ed73"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1d2d3ca5-00e8-6c85-fec7-a2921927dacf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1d59eaae-0d36-735b-7e51-076d7dca4949"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1d5d2718-8715-4277-5ab7-5aea0e57d175"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1da43eee-9bed-d4a2-12a2-cd8dc6d604b4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1e0fb905-3153-6a0b-19a7-d0d54442f2f9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1e7c9d12-7a71-36a1-0685-0e84b8681543"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1f01b87a-65b7-6318-9785-0c470bacabe3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1f12a5c4-175c-11af-58b8-27a41584180f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1f65c0d1-d081-3cef-26dd-b139258afc19"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("1faac5dd-edd5-8212-8f20-fa703f965e61"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("202c05ca-5965-3577-34e0-8bcffbd931b6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("204952ca-b348-a3b3-d1ab-401d3e00b382"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2051282c-47f0-a66e-4896-535232181c8f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2051d62f-8df4-71af-2a6e-65c3d54e950c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("20b5179c-c592-9bf9-4b2a-d5244f4675b5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("20d09489-497d-d5e9-1df2-af7bc47c80cc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("20d3a550-84e7-e58a-e96c-07b8ae7cded9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("216491db-ab51-3f73-7ef4-32c02c3d85a9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("21986ee1-9a47-6d79-f759-e811c375c184"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("21bc803a-4b02-2330-66b1-d820f6f57229"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("21f16ae9-ac4a-1979-19b4-a74df625b7cf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("222abfcb-f185-be6c-f1c2-3f1be3ff196b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("226c8338-fc98-30ae-b59f-8367dc63d399"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("22befc39-34d2-8518-20e2-5cfa9bc1f9f6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("22c11349-110f-8781-9639-cc9cfc3885fd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("22cd7a79-26aa-c7f8-67a7-886c5828665f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("238da285-0159-0f2d-6bc7-dc494865e472"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("23f85c1f-c19f-80db-5ce8-e311f21b204b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2410f4f1-3592-74b9-d3af-4a848bea4913"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("243a7bd5-42ec-da71-f6dc-4209689087b2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2460d26f-e18c-fd22-972f-42fd65e71a23"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("247605d9-1ed8-ce9c-9d01-d341eb459663"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("24761e0e-d3a5-bffa-80e5-8645cb1d5705"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("24ac461b-9523-b58d-7aa2-b92baede2b3b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("252b0343-7453-69e1-f933-1e4ac24f2119"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2539dda9-256b-e837-751a-0352c268cda9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("25443e8c-8a6e-72b7-b5e7-c8d7120bc6ab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("25a8e077-e859-4f99-da18-8a1a1964f36e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("265da8c8-26ce-e3c3-bbe9-638dcff1ef05"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("266d130b-a476-8eac-11c9-0dc3d64d2df0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("26f29e11-53cd-2328-0045-a6bcc69b2e97"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("27065d98-402e-a894-514e-d8cab43d1e2b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("27df1ccd-8f3d-32c7-5390-06ae7aae4757"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("27e2e12d-038b-e1e7-2d47-fc1d083298af"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("27f41c13-5c3f-c8a2-71ed-24025f1e70c7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("287445ad-b108-5548-6b38-dba611251863"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("28945082-0e0a-82d9-8606-4c84b517bf8d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("28da1074-0f1a-d79f-fdbe-03bb910a84fa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("29796f3b-b3af-8559-d97a-b83246c0a9ef"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("29a1429b-5bc5-92af-b3b4-f20247e1d480"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("29cac353-5be0-6053-9880-dbfdebb5cc68"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2a84fe2f-8f62-902f-ebb9-9bfd27fb366b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2b178c4c-c4ae-3266-d7bd-56bc9abdd32d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2b3d9c01-d361-053d-2fda-2a458fb1d696"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2b454b75-2ce7-05f8-c4ef-19204e95c74a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2b9f7a2f-cfc5-3e1a-5ae3-f0e1d7afacba"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2ba5ce3e-108d-74a0-d1b5-ddfb16482c7e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2c475fd8-c993-7e08-cc48-9824a8c159e2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2ca5cc38-ca7d-c4bb-c80e-5b83be5b41c2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2e19cd36-5081-e812-37e7-3d63953d25e5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2e7b5d70-2ab0-664b-1859-4031cc96a5a6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2eefbf36-3fc9-4fd4-c6a4-e8ef1bf4362c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2f3b1f3b-1cf8-32a0-9903-0931a115bb25"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2f52b200-4a6c-744a-3276-c72041140a3d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2f5372f4-e48a-cd92-b5f0-358bc8ba9c55"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2fad8f9d-c983-0aa5-0cce-c7bdd8e1b60c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2faee5e5-fc3b-66f0-554d-2bdb158a6d9a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("2fd8d15c-a1b9-93e0-532b-a674adb46a88"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("303e8c4c-99b7-fa77-7ffc-006170b880aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("31484e42-d07a-198d-3f11-bd5fcf61a1c9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("315b02c0-5003-e1df-07e9-f1f51d9e1dda"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("315f7231-5ee0-2512-58f3-60b5513839c3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("317e0405-8f87-24bf-250e-4f6c641b8f82"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("31b0333e-45c2-069e-58c2-9e8c362bd7a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("31cdfd4a-02fb-e83a-8b07-a7def834acce"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3217a348-823f-ac26-31a9-7dc1269f2193"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("32247015-31b4-c3ea-7483-075f10f8d1e7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("324724fb-f243-33ae-34e9-0bd56d4cbb43"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("327411fa-91b3-babf-fc4a-01e10ff3cd75"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("327dc006-03e4-5edb-3256-71f1aaadb19a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("32b6f203-92df-8d7e-abc3-618706bcc87b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("330b04ac-ddc6-c439-613a-c9a4be853e45"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("332d349a-af2c-98b2-ddc4-54442e9c8f70"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("33a1084e-756c-bbe2-b6de-7b86dca104ae"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3403a6ca-21bc-54cf-8b1f-438e4f8d0297"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("34146925-c581-5ab7-b858-428e069e5888"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3417e8dd-f5d2-7bd6-b2f3-daf5e5c754f6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("34794256-47a4-90af-cd34-e6f739a0277d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("34cdff5d-5024-c1fa-6b5e-0f3ad4ad1f81"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("356ad7b0-1494-e140-2507-b1e7f4e0ebd4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("356f7a1b-7841-9f8e-5f22-461c9013967f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("35ce262e-fa17-78c2-1d9e-f243b13eed46"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("364ee84a-b945-da34-01d3-f8390386619e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("374a9343-84e7-175d-a75f-f74666af864b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("37ba370e-f3df-f23d-181b-cc13af0c3358"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("37fd754c-bbec-ebd2-d206-a187c26c05f6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("380c6c06-ec41-ca7e-5fde-284a205f9a47"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("387429e5-cb71-ddee-c5e5-ae412ef0406b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("38cf2138-d5fc-d753-7c8e-650472e70335"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("38dfac58-b0d4-9543-c41b-bbbec22fd667"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3939572a-ec43-3666-8224-4acd101ecdc5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("393e018b-bf54-367f-4343-7fa068f5ba70"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("399fae4c-1009-00d3-a521-bb7c04124161"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3ac6a3b7-7cc9-320c-66ae-5a55bed3220d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3b085a98-b13c-3f7a-2705-3ff6ed2f4e54"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3bd975a0-9a03-1f6c-a694-cf917bc10fed"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3c70e5e5-bd2c-29b0-7445-1f8b03735d3e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3c7569ae-60e5-d031-18a1-c399d79fd4fb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3cbb5025-8967-901b-4f04-7542e33cf452"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3cef2c1d-f613-ef05-ecae-d32c4853b8c3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3d2187cb-a0ae-a8c7-2862-b7b4b57c3eff"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3e203f0d-f8dc-4163-af91-150720531207"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3e4dae95-3309-2363-0759-8a5a9e73471e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3e58af11-c272-4984-71a4-b1e03540f9cc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3e6bba0b-c749-d3c3-2005-11016f22a2c9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3ee2dbaa-985a-20f0-7590-9b6d13603175"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3eedc00e-ecb1-65d6-10cf-f37596107fbc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3f26674e-78d3-7674-3877-02e78ffeea9c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3f9f41e9-2c4c-e653-cfe5-8484d4a0b4cd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3fb3dfb6-5684-1e6d-4120-909680fde230"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("3fdf17a1-367a-3cad-eb35-082a0700410c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("402b8d6e-d999-349a-4b41-5c26697d46ae"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("40707ef2-39cc-40b1-ae97-c7ef78d15c01"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("40753f06-e224-cb2d-c6de-5c1364b5ba8c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("40b4241d-a7d7-c6b6-5e30-bd7c13f14e68"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("40b63821-1a95-14d5-e4d8-e364931a09b9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("412d529f-0f82-e033-e86c-59203093af1b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("414d4203-7244-8d2d-cdc7-7457c6984e46"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4280e11f-668e-a858-50bd-ea058034ecd2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("431307b1-451d-b41f-8bda-dfa2cd312a5a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("43579918-0503-dc20-25c9-91d889b8d55c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("43ad92fa-b47b-2927-bdcd-235fe95ec372"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("43c408c7-69bc-1087-1214-44607a299e82"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("43df9b23-49c0-612c-a6ef-32d735c6f1df"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("43e0aec8-fa5b-1234-dc1d-87c9b07a4141"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("43f5bab5-d2bc-0f4d-dda1-a6f333894ff7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("44192a69-d2fc-3cbd-2fd6-68e8d97adeb0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("44a66f8d-562a-1dbf-30fd-86094d864332"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("44e4ac3c-925a-346f-c202-fe1ceb8e6840"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("452e9051-9f76-2445-8075-9102da5e5a35"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4534d281-f073-8519-5dcf-dc5239b6670f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("46248ae8-78b5-c0e9-77a7-04bcbea16e3f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("465868c8-5dd7-31a6-bb0f-15b149c07278"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("46af79ee-09d9-3635-8554-860d415e002a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4726c7c9-5ca7-1849-a34b-448ee9890164"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("47477869-8ee3-f441-25b3-e71aac8ae2c9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("47746c94-91b6-0d84-d373-5eaa17417801"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("47d0ec3a-7bba-0024-e381-d25b7bf03a29"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("47d6d779-eb70-a14b-cf24-b8ccf772c5ad"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("480d00ca-93fd-4bcf-0bcb-764c743b2398"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("48a4a59f-0052-b668-c7ad-815da96104e7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("48b8e2b5-7929-e188-dd20-8dc391470cf3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("490475d5-d98e-4236-fda9-c93822e14268"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("493a0cd3-c137-846e-bcb6-2f1dac11605f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("493ee353-12c3-1d2c-eb6d-0c0d45c20717"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("49584ad0-cea9-3d06-8c46-38cb5975ea73"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("49b0220d-b27e-90b2-050f-101dcf20c059"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("49e9f04c-8a73-25de-a68a-d7006952e922"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4a21be93-b855-65c4-d969-edb36179203e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4a6fd641-0278-d8d9-a961-836444519ffa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4a9c4c4c-6201-4563-1566-891dfe2ffe15"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4aaeecb0-08f6-34eb-1010-c6795ef01891"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4ac4ad2f-6e45-6a0c-1e88-6cd9f761860c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4ade61f1-d176-061e-6ff1-6bc971a712da"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4b021375-6822-1c63-ea87-b8dfd2630268"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4b204e09-abbd-0dd4-ae11-f2d59ab04495"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4b249b11-6e90-54ad-9a09-c97babdcd2c0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4b4bedef-ffed-b35e-4e5b-55e8946893f6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4b706dee-acde-9de0-0c13-bd20b7554e69"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4b870147-0b6e-312b-c8a6-a40d14726939"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4bf7957e-1da0-8afc-0a1d-5a17a4565cc9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4c238d1e-6445-ccf9-8612-2741b9132e33"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4c945bcf-f817-76d5-de63-f66dec122e97"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4cd39cba-c6de-4531-7f3a-bbf778a9c6eb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4d03a2c2-f34e-2e73-db7a-e1557ad707d7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4d198d07-93a8-eaad-c9cc-e7fc11a91cab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4d1c385f-3252-321d-5285-5f9967677f27"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4d4952a0-6f3e-39f5-2224-99a4fae4bb50"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4da4900d-ba01-148d-c6b1-122152c2b0b8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4ed6457e-49fe-2b9a-f610-9f54791faff7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("4f5514c5-47a6-ff6e-cf63-7ffbadc634c7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("501168ab-b471-2b70-23e6-6ef6ca037767"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("511c57fa-38b7-5b54-81f6-a3c445440c23"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("512465da-f756-1ddf-f8b6-32899890a482"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("51308fa1-b6f6-0d22-6c2e-c757675ffea9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("513c2e36-0a6a-20df-dbd2-e5968249b100"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("516c9c93-1752-568b-f409-eb2da65e225d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("51ad100d-2a38-acc9-30f2-1317daf80e5f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("522553b5-c4be-9e0b-e2d7-67b5c1120e7b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("52704dcf-fe36-e661-6198-b4e865b255f9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("52c28139-8ea2-49d5-986e-3336a5c10f4e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5306caeb-5233-3868-e282-7be95fc027f3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("532a3c56-3a1f-0bf2-2f78-183f108adc3b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5347ec37-44e9-65f0-de72-0eb60a2f156a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("534d6504-46aa-9f5e-7873-2d474c3398d2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("534f0616-b81b-6628-847e-072ed5c275cb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("53e7c164-0aea-78ad-6a31-cf51df5bc0cf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("53ef4162-2510-a59d-2b97-57e53850a7c8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("53fb9190-cae3-df73-ef33-df5327c21106"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("541059a5-5365-55eb-fba8-74cdb2ef5f6c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("54382476-8bc5-b2ea-bc48-8af6aa9aefe0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("54660cf4-dafe-0828-e699-7d92da51e0d5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("54a45fb2-d26f-3799-33ac-bc11149a52dc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("54b84671-1d16-d12d-8aa0-8ea72d9821cb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("54bfc257-3fa5-fad5-3163-954c4c9af546"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5537aaa5-0c87-369f-88cb-39e8110ff6ab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("563d852a-075f-258e-842c-ace876f962da"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("56744e95-241a-bdf2-d5e6-59231ca9e037"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("56baf62b-e151-5e8b-6d9e-b97ee24d3cfb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("57809d73-5040-970a-1659-5b6c31b80f2a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("578438c0-f670-76d7-3797-bf2bd0a0bd70"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("57a885f9-1291-a931-56b0-b04f6be5a982"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("57c6abb0-68ec-f305-1182-5279bc79929c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("57da2236-c236-0645-9a5a-f362d5bae4f8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("580d649b-633b-bec7-5b72-3563bee0ebaf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("583ccdbe-7295-9489-8ed3-29e43b08d46f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("585a7be1-a868-8d54-6840-b08d69f7756c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("59354a34-3333-3a67-bfba-9823150bb6cb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5951e896-9fd7-9fb1-439e-ef6028f87c4a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("59fd0ee6-bba7-8032-3741-7c43a7cd12d1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5a6d0e68-bb1e-46db-593e-50e882441313"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5a86fe1c-6396-d48d-1a80-a3bea9f0b2a2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5a91bec8-a1d5-ae3e-5da2-37b209df8ef3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5acbdbd2-b8cf-441b-4f1d-d2e8b2bcad53"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5b0aa95c-ce61-4058-faee-3d08d8b9d4a8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5b483318-490f-2dac-21f8-0d068478d22b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5b6b5beb-3b95-834d-df6f-e047a781a0d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5b7a2c93-bcf0-9720-61e2-1298181f1760"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5b7ffee3-c459-a2f1-ebf1-8fdc4a104adf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5b84b13f-b16a-a9e8-57c9-83a5d417515f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5c1465a5-5e64-57aa-9ed7-a574b201ff5c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5c435c64-b77a-5b03-b982-2ca26e88cdfd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5c618a90-0a8b-3fcd-2399-9b90b3515a17"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5cce2960-85e6-5a8c-1ce8-ac7fd9e7af92"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5cf8208b-da0a-41eb-fb0d-61cac5c1ecff"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5d1ee8dd-07b3-ea80-ddc3-5f49be9c7148"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5d472b78-1d30-df74-960f-f4a0dc541a45"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5d6bcb46-276e-5dad-c737-eed6236f1398"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5d855284-015e-0c12-79e3-df3b5b318f71"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5dad05aa-fc1b-4b7f-8d8c-b090e013e59d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5dd395fd-1c31-4d31-3aab-768d88855ac7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5dfb3bbe-bb6a-2d12-6229-84338da8caf4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5e067ee4-5304-1bc0-6423-b80983ae61ee"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5e23bd8a-8ba7-875a-19ab-bdd051f413cc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5e411d0d-7f5e-9c9a-2f7a-aa123621ab61"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5ed0f430-17e0-81ca-d86b-5dbae4f16137"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("5f96d857-7b02-8fe0-59e7-e5bf16c1d509"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6010982e-6972-480e-3756-f9a9c860b317"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("603c3c3e-7507-f10c-f8b7-e03d31906a4d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("60673fbe-22a6-d955-f4d2-e4e0a0f87ae1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("608cdd91-a905-2fd8-da59-8520ece2389c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6099e608-600b-0fe3-4fd5-9b18ee52acde"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("60dda251-d5db-dd27-4ee1-1b88b5ad3f6e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("619344e9-8fff-b827-e3ab-227cd958696c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("61cb7012-2565-b6da-ed1f-ec5eb6cc7921"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("61fc9a0a-5b20-a809-95f2-00374121735c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("623e3a1e-a53d-140b-c88a-4f8e0bce2796"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("62baf4bd-555f-5a31-6902-9b849d7de53f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("636f9c91-f72e-5485-de3b-75368eb7c730"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("63a8bd6f-f227-97a1-495d-53775aec2060"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("63d6a1ba-7e32-41c0-3a18-01ce415314ac"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("63f2aa37-6139-bdf6-33c2-30302b079951"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("64401233-f729-8703-076c-7c6082973edf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("64a7c775-9f80-a723-d7c6-757a67ce4e0e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("65236362-7cf4-772a-0fee-aa6e56ed3ac0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6552ee21-d54a-62e4-6b33-ea8dd13cc59f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("65d2a6ab-29b3-a012-68d0-7de4598d83ec"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("668feaae-3a84-7f48-7166-408f2b656505"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("67ab1076-fea5-0ce2-3b23-dada52241549"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("67c896ca-b4a9-b036-47ad-8d651a7de49a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("68521623-487f-9d71-de49-5e0c11a697dc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("686e21fb-2490-76a0-fe51-c2574d289a26"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("689c9b81-693b-cd25-db74-5275ce6beae3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("690c7509-3f0c-00ca-f069-101866af4321"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("691b8c0d-4cc0-e0a8-3f05-846b67345a65"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("692f165d-77a5-d7fe-d51a-8d387975c185"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("69cf949d-545d-88a0-2d9a-6f7c66a05596"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6a3b12ff-9f38-4eea-4a0f-a90675d73ba4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6acee898-3073-e833-0ab3-40e8df9fcf76"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6ad8e88b-90d4-9cd0-46cc-498e69ace031"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6b009e1d-e71a-a670-3513-063eaf81c4c8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6b41dcec-de86-bf74-5840-1e0910e6ee19"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6bbdba9f-78a0-eea6-fa1b-432dc4537731"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6bc7fb09-5dc5-d2fe-25a5-cf5ce6b47373"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6c2949c4-a684-2f22-6f0b-39164346a331"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6ca43125-2a15-bb13-d489-a19386d0da2c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6cb477bb-eb47-3e50-b5e1-d6b14a5f4881"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6cc16352-536f-22ed-eb90-6fd5d8b42264"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6cc33791-b1c1-5a68-953a-6212a7cf7627"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6cd2a506-1416-b985-f591-a6ed5f91e796"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d0b5560-c9c2-2987-6f3f-0e2b81c56b32"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d5fc5e5-34f6-1479-ede2-1a93773906a9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d67b608-9611-54d4-c034-4ec56d530bcf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d786d4f-dfdd-61b5-a4fc-1c853b335082"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d7bd228-30eb-a546-2dd4-09972654c0c7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d81a4a0-5aa0-03f5-989f-99a9b77da195"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6d86dafe-fb84-d0c1-5289-0e79b4041785"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6e38c1c5-c91b-b3cf-6d80-df142f6789c7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6ec8e04f-cf2c-150a-d499-df0e7fe8ca2b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6ed22a68-d6d4-1af6-36d7-d40393342648"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6eda1f0b-bb5a-880b-39ef-31d17a2020a5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6ef64432-385f-a33a-4e92-953eb9f3d14d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6f0b2b7f-7bc2-55b0-81ee-bd1b4ed30b8b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6f36d41b-58c6-3fc9-fb83-ad438ed3382d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6f3fe828-e504-8fb0-f987-c330081ca8fe"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6f7058cf-8da2-c05a-92c1-da8f4a8fb3ab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6fa05b67-ac06-1760-5001-ba85671a78a1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6fd55596-f82b-c2e8-3b70-7ff304851d90"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("6fffc9ac-704f-baa8-24cf-ce1b6155c4e7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7041373d-9d82-8489-0c2a-4b5a84b510d7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7072eb2a-c3bd-2a7f-934d-cbefae54e6aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("70c49c57-9ae2-bd99-d77c-3723706d0a29"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("70e8a1d5-0f6f-c0ba-1364-0f91182bf0a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("718cecef-edcf-11e8-7e1b-251fd6e5372a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("71ad1149-5f73-e603-25f2-842151578466"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("72294e50-1333-5d51-7642-d7f700a22740"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("72630819-d453-dd91-5456-24419822ac41"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("72a4e933-0e00-5fe3-64f4-612aa57deec2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("72afa886-6376-81a7-3769-819aadebb3bf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("72fff58d-dba7-fdc0-d1b6-ca4683318ab6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("73876b73-2f57-0535-7fc9-d672c1b224d2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("73bba4b0-8120-27ed-cfea-d381fc3651aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("744386d3-8a84-b3e7-934d-a78295d054ea"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("747cf847-7096-a9c6-801e-82c05452a7d2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("753e11bf-18e1-4404-7576-f9a2fb09ab47"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("762cd93f-cc5c-25fb-3364-b1fcbe79ee70"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7666c381-9a82-fd55-9a3b-216d4b52abf0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("769f81c3-6188-7e79-39e2-30b720ac4d5d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("76cb6188-5630-a7e6-0125-f58c5fcf85b7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("76f59e02-4f16-1851-bf8b-d22cb87ffac9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7704e733-9ee2-a8f4-ccd8-6754f8b510c6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7741cff6-9323-4c4f-94f4-6a18c03d1bc2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7783d12d-ff77-1a25-b3ca-e6d5100f7409"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("778ad253-62f3-1407-f1c1-eae87cd19fc4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("77a219a7-563a-1e71-0fe9-1234ac2dc337"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("77c61d40-445e-6251-efdf-310fb6d846b2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("78039622-e8c6-2f0d-b547-65011544c384"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("780476a4-f3ab-5def-55e2-21e1cc35e4d0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("79f05f69-4cdc-71e1-1249-ae83d5433431"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7a06bb77-fa6d-c433-89fe-eb5ebd69adfd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7a70fa32-b740-f422-6186-f5b8c4d3ca8b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7aec1ce0-95e6-4ea4-ef5f-e245462b5618"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7b0914c0-ad8e-3a06-40bf-b4e8d0189a50"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7b181888-8bfb-8c18-b556-252d944e0bbb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7b193112-fbb1-2ab9-6592-80549d9c247c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7b54986c-bc6c-534c-115a-5dd0c28341a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7b5fa917-3ee1-f36c-12e1-77e4d30c0f72"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7bea3968-17df-33bb-84cb-b4b6e03ea7c3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7c2a46a5-d5eb-fd0b-eb95-6d4ed7199e30"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7c506a94-c30c-8c0b-0114-42bd1a05ddc4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7c52ddfb-8d56-a0b1-8a3e-3faa11a1c7d0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7c727f79-b998-2adc-a92e-87f746e88f4d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7ce182a9-8274-45eb-ee38-1e3fe649c742"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7d3e0f11-3172-509d-3e39-27b82f55013e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7ddcdb03-cb6e-7122-d8f1-cd8d3e2d207a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7deb7b75-acff-29e1-c175-6bb9bfe05b8e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7e07e9e4-e177-ead3-4062-ff1c211548d1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7eae23f7-dd17-75aa-bc5b-966724454dfb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7f4032a2-f0f0-64b0-b64e-15362a772a5a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7f54ccf4-35e2-30eb-86bc-505f03e8f8ba"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7f5d1633-f3f4-6af9-9a14-202f2dfd2a50"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("7fb4aaea-ea82-5575-1b3e-68220dcd67e3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("802946e2-b538-f31d-0b69-46ff8b8d6d60"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("80430f59-d29b-854a-9239-de9a566919c2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8099b02a-35e0-3778-0b16-370d741caf43"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("809b4772-6540-7f6a-165d-9978e36cb453"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("80d64754-af16-5f15-a840-b66a6232ed64"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("810690c1-99fa-0d07-11de-1b579102d35a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("81340fee-7262-36c8-165e-e731a3deec29"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("815d016b-41a5-cfe7-f04e-2d6655593520"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8184cf37-ae74-b4d5-7d83-3835c3c20b14"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("81bcd594-d6fe-3287-7eab-556928dbb5f6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8220c285-e45f-05e2-8deb-8212a9098701"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8246bf9f-d269-3a70-6154-e49936253d1a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8256eb6c-87ad-6f39-9280-df866bfbb740"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("82eca56c-3f21-c6e1-42f9-dc37bee9511e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("82fea160-6263-dd20-5ec1-82afeece4634"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("830cd727-6e4b-daf0-2170-84218930f378"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("831dfef2-8f3d-5e90-12cb-acb04502c768"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8321ab6a-690a-7fe3-8e68-1fa2795612c6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("83320788-1cd7-8908-f864-c561b4ce4e9a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8358b6da-ce64-8853-3bf3-9a6a84b32a3b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("84b8d0cc-cfd7-5624-ae90-cad21dd1d23a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("84d9a632-ba58-5e62-f116-040fd44b95ee"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("850944b8-df58-87ec-15ec-997a06059037"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("85589261-ad16-391c-7de1-2420d53ac39c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8585a9ee-d41d-aa9d-01f2-255cc6201f96"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8628db1b-54b1-772e-6b69-ca3a836f8399"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("866136f3-3b80-7cde-06b9-fc52ddff25dd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("866f1628-d48e-668f-f0ea-83fe805e6a59"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("86c67375-4c42-0930-f84f-a9a868d13b97"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("86fb0feb-adb9-c470-21d4-89e51bf28777"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8795d370-9456-b71d-fcb0-e541575abb6f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("87ffa6f7-6715-d8c0-693c-1b2846124076"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("88192754-814f-87cb-3fb3-3ee0a5cb8260"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("886c1010-62ad-bf20-e993-e2c11f3ab568"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8872cf67-44ea-70c7-6ae4-59be075226f7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("88fd47a0-7c87-578a-79df-58c712aeb8d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("890ce33d-c7df-4faf-102b-8e078aecde08"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("890db3ec-d5a4-cabf-91de-8d23317e319c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("892a4517-97b5-7479-34cd-b95db266a663"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("89526104-632a-6967-0f92-2ddbecb831f4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8968b3cd-cfe4-44d2-396a-0b27359a97de"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("898a48bc-ec42-6ffd-5b57-4f97bfaba94a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("89928f57-925f-6085-61c8-4bf3b51b41a5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("89df9686-966b-f70d-45c1-05b7f00fd6a2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8a309b0e-9aa4-bc57-1d8b-3311869ceee4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8aa79b46-2d61-e290-003e-5f970bbfefa4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8aca6524-8265-7150-54c8-64c9b5a90d4a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8b34bf40-e9b9-128b-4ad4-488b7a2afb90"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8b43a96d-a75a-0690-45a8-e633ea707e10"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8bbdeac2-d336-75ee-d6ca-b7b28ad69fb1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8bc727ce-69c5-37b5-251c-4457d6942dc1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8c083ccb-08ba-f2d9-ad86-4102b3a0f918"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8cab24c8-1f04-c418-2e93-313fb68da757"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8d21d44d-0ff8-7dfe-c6bb-ec77f954f4dc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8d257f04-b0b0-1060-a1c4-6aa1de500424"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8d4c902d-cfc7-c768-2808-fc43e2208b25"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8deb6efe-905c-f0e2-cc18-8dc5268e0b5d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8e0c856e-7e9d-fa0d-eda3-26fa2b410d1a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8e1ab9a0-ee4f-5351-8b36-50a87d9b7d1b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8e214dcc-477b-b0c4-001b-856740d2b386"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8e283a86-c065-1fc7-1e65-96542e2ee49d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8eb36b6e-8031-f944-82e6-be8952984b8b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8edb0133-255e-411f-f560-0731ff0a1931"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8efeab9b-0325-8693-a9c8-0858804a2f1e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8f3d1663-8fd8-a5cb-6e2f-a85d4916165d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8f75f8f1-4a4e-6186-ff5f-da4b5481b8df"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8f7d9f1f-a4b3-5d9b-3836-b741b0cc062a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8f93ce2d-0e45-45ae-1c01-3d9ec9a14403"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8f9849a3-ac83-07db-3f98-d73c817ba151"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8fb4415b-f183-c2fc-5d0e-0b8f61bbefc4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("8fe8cea3-d553-895e-0980-62effd59330e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("90759361-4f15-6128-0f80-1d0395c86830"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("907709cb-e5ef-9dc4-f914-e6dcdfd9b0b7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("90986fe6-434d-830c-42cc-3d122a935f57"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("90a3d78b-bc0d-319f-879c-35b7d533a0e6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("90af9248-af55-5c81-3878-3e8469d01f31"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("90ce02ed-0b67-6984-40d5-78aeee4830ad"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("91180619-ccd8-bbe9-f8ae-cc32356dd22c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("913b47e5-4656-12f5-93d0-41fca0c63b18"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("915a90b2-836d-86b8-1737-e1059036c89a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9171db25-59b6-f683-5753-747ac13115e8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("91856bdc-b239-2b08-bb90-e3394e39a149"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("91a13832-0dc8-4ade-ac22-491705102f04"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("91af6b81-b8ff-311c-bcde-a7d337a91d19"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("922a818d-9725-a9f7-7eff-494c2635fcae"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("923037dd-f9df-af73-1943-2ce783286c01"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("92313abf-3903-a9d5-93c3-a73d1245e4af"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("92821288-8547-aa88-e17e-a149a5cb694e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("92f532ba-b2e8-f5c7-2df8-55a08d9a0bec"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("92fa2400-1282-8e71-4be2-75f7670beb89"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9349b9bf-8b3f-8fff-fd08-7c0d7b75a270"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("93520263-8889-9ffc-86ff-fe48ecf6aebd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("937fe4ae-1c8c-def3-da30-a9867cf7f71c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9459c2ac-047a-9bbb-5275-9bbb43f4b527"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("94c0d15f-d9d2-ef4e-aa44-d05b50e8d0c2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9507883d-d5c5-3e2e-e3bc-46cd47005280"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("951c3d6b-f091-5370-b2d5-765263275bb2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("95454751-17dc-2ae1-0f12-6380079b534f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("95543df1-61d8-8d9d-4332-631818a6a658"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("955a4066-eed6-48a8-1803-acf61246bec8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("95a03258-c591-3c88-66ed-b821a01c4efd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("95bb4be2-3c25-7625-59f0-efe0b7e50e6d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("96ba173e-04ae-3bcd-9986-9e56f0adbf3a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("96cbc724-a3d3-0326-bd10-31849f07d947"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("96ceb23f-19f0-5045-d786-a691091f9982"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("978676e4-34bc-148c-7bfe-acaa54194809"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("97b3db46-dc20-1e5c-1209-4637b25341f5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9856b3c6-de6b-3323-92bf-0102af88a7dd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9865a3a5-7da7-4701-d1e1-19a1c8bab606"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("98a79e3d-9183-1df1-f7f3-44f681974173"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("98b5d4e3-442d-5801-8cbd-42feee7b20a7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("98c8777d-6f28-a784-c6fd-909e84206cf9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("99aef068-2924-ed07-d9fe-a9c793d37f22"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("99b58f1d-522d-2cc0-6874-3f0df9dbd14c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("99de2625-4292-a1be-8246-3c87e3ad71e2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("99e63b22-78bd-6bf6-edc8-7577752ff9e5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9a19a4b3-1f3f-6373-a104-9aa1d04cf32d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9a55be5b-48fb-3214-0bd6-c4148f3df0b9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9adf27cd-269e-60e3-13ea-be3030602782"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9b04a2b7-3486-fb8e-e30f-fbeeaba8d181"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9b2100bd-168b-8d44-4f7c-9ed6f9c1319a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9b34151d-3b8e-e784-a6bf-329b571f18a1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9b58a966-74f2-ea2b-1632-391abd36cef2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9b885bcc-bce0-3def-4f4d-a8a13bf6386a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9c068e4b-cafe-0765-2e6a-8473ce0e8b92"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9c480ed8-4688-4b99-ddde-dca4857919fd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9c8b967a-c8bf-8429-9525-12c929c94b00"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9c911090-df69-85f9-f3fe-c57bd8ffa96c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9d2faa9d-30d4-8e7d-e8ee-51413667ba08"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9d3bc80f-f26e-0565-9e4c-3104629639c3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9d46b827-7a4a-80d7-dfb3-bf40e8fabd0e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9d55af6c-53eb-79e4-1bf1-42435a23843c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9da21371-f35c-2aed-e8b3-3a640a662e52"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9de41d5a-c08a-1dc2-f8b0-c9911c38ca99"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9df5fe33-edd3-967e-ceb3-f99072005d28"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9e34490a-ffec-0880-7fbc-6a6fbfe5c46a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9e47fd0a-9a15-1b69-c3b4-fdd6ee91fbd0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9efab825-62a0-3977-be5d-616e71f6c529"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9f176e6a-5fa3-e13c-cf94-c785f637effc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9f315870-7a19-234a-8c92-751c50ad1d39"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9f6271bc-7221-3376-7b64-34f31323656d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9fc927f9-6121-2f8f-638c-f7c599534295"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9fce0d58-cd3f-3e15-0e82-99a5c614b996"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("9fe2f8df-b49c-2b29-9fe7-e9ddea69583b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a039bdfa-8bfd-8873-5d31-32df2c1f4a9c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a0694d88-8d2c-ec56-93b4-18a2f6e27841"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a07d8657-cdb4-e364-4bea-2390410143fd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a0c22b84-288f-a908-6f3b-ef3cbd22f82c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a224358c-c98e-d00a-f4c1-c15cbc59cecf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a2c14156-f379-b60d-518e-67ba30593dd7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a36e2596-92b6-e648-f2e8-4c11d0ea828c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a3dd87cd-5bf0-32f6-9af1-a562647c8050"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a3f31eb1-dcee-8d2b-1bca-aae6a8fe2269"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a46a104d-8c5d-e982-b7d3-71539ff502f9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a498aaee-1e0a-5ba6-f435-495b57c89bfb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a50057d2-cd96-0e54-cb40-3c5c36958293"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a570e6cd-9f6d-bed2-65fe-cc3ca37dce0d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a5a201c8-cf0d-3d21-63ad-735e372556ff"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a5eb26b5-d5dc-110c-bac8-225d3c99cb24"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a625790a-1bac-7843-62a8-0f7c56f36973"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a63b1bee-fc39-5476-b5a8-0f1321d36c9b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a6736fb3-38fa-b482-1a40-b6881e304d27"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a765863b-59a3-36b4-9973-61488c6e45df"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a7cdd788-dd16-242e-92dc-d3d85598e4da"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a7dc5ef1-e847-e2ee-b1eb-0d9903303a6f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a8046b3c-123d-0f36-0c4a-0e09c0d5c550"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a8440a6a-b251-34c0-56ba-b17fd1e585fd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a8541d59-b772-1ee0-dbfe-aac0c7dc4cce"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a89bdbd0-8a9e-65ad-a494-66afdf6660e7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a8b7475f-025f-9c6e-21a0-92df625f5e5c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a8dabb0f-a25f-7592-cb5b-691ddf4106e2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a90c2d36-923c-ad5b-9644-0e161f47d356"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a91a1356-6162-e3a7-c81f-9e9f2a823626"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a9643a6e-a326-fa2f-d92a-51c50c95ac28"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a96c77a0-e1fd-10c4-03a0-2617e60328d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("a9b8a444-f236-c11d-68dd-9812d54a4e06"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aa81469c-19b4-d0d0-d3a1-19c1111d5a32"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aaac1152-b915-f528-7af2-7691d72316ce"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aad920a7-2e3d-98f0-eab3-18ac67cb614f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aadc227a-3317-099e-cf4c-f569e1901a1b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aaef9697-aebd-24aa-743a-8a310fe13ac5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ab29cb93-935f-5e73-08e2-e74d4601835c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ab6e8f80-9f77-b6a8-f347-7b2d3ec94997"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ab748453-de7d-cded-a973-13d749c59b0a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ac053a56-56c5-90f3-5257-49c6018ff551"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ac398ee3-bfec-934d-48e4-a770d6878cf5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ac544cb7-acfb-09b2-8550-2f752ce01b9c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ac555e36-2574-f0b6-4319-e27ba6d450c6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ac961dbb-3ddd-f80f-f947-0e423262f96a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("acbae41c-96c0-66e0-54f3-6edac1d5acae"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ace52fe9-3c73-ebad-5ee8-0d7b232e1082"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ace5e16b-9400-34ae-160d-1e1a49a4d7e7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("acfff376-7c10-2482-d792-2e7b2519c6e6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ad054b69-9dfd-bde4-b2c0-0b93a2957a3d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ad53db4f-9206-fced-9470-68dad2459531"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ad6ed5dd-8c30-ab5b-6521-d8bcc6f8b1aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ad828ce5-10ca-179c-8290-f0a7e2554b31"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ad84a085-ae7e-66d0-e6aa-4534be0347fa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ae17bc31-18e4-56c3-7676-f76d1479c79d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ae1d051a-9578-313b-40b4-195fb60b073b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aeabdf37-4955-6341-183b-b3f8ae220343"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("aed32956-cf55-3aa9-b901-f2168a128b8f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("af360b15-0974-8dbc-0613-9b8a12fe56bf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("afb7ee91-e766-7144-d24b-ec6feb7cb979"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b002a5f5-376b-7a00-836d-856a3907f5a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b03837e3-07c3-0d08-3bd2-c4a597e5c43a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b03fd512-7557-0415-025d-1319bfad041a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b08a86ca-d8d8-4618-550e-58821375f9f8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b0902b30-84cf-51b7-4aa2-05900c1ed95b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b1610fb7-5a15-e285-884b-e33047b8d3e6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b18acef6-6d1a-a5aa-d664-25f456533b43"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b1b1f56d-651a-05e3-2b7e-c7a8ba8c40ba"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b22a9197-f67e-6d9f-99c3-6f97ad82c631"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b25cac9c-f63a-1436-ae07-d2c6b2bb87f4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b27e2f37-14c7-0ca0-ae52-d4e1f23d238c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b2831fcf-16ab-bca1-e8cf-0426140ca3d0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b2849681-b64c-869a-33c7-1d13c4c29edc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b2d468d4-09cc-66cb-b97b-f1db8fa4d1b5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b2e7039e-79fa-2fd2-1708-284a56c7d986"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b3be81d2-312e-d121-5060-100fca6f6035"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b3c9270a-b7b2-5b73-313c-d2c6f73c4f3b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b40edd54-761e-e416-1483-206eb7091070"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b4cce863-2535-caa9-f196-497a986bf2fb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b51f432a-719c-1d10-bb56-eba5488c8828"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b54cfc9c-6543-a11a-d205-b4de6e7a8102"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b5520d45-3ba4-e090-f26d-e4a1a33a6319"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b59984f3-ebc6-7b2b-e28f-9e5f03904de0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b5ca90ca-2aaf-9653-6c30-15cff95cc9cb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b5f01216-c9f5-0b23-3be8-cdf8f2292e0d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b6564d53-ae23-b71a-4a3d-52885305b89e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b6a4ebec-a09a-9c4c-ee83-44986dc9ac6f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b707b8ea-3e37-cdb6-1938-980344d67439"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b7197908-5aa2-8e0e-bacf-6da04d587864"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b78b7e9c-6348-c538-ad8b-31bc5fa3c115"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b797cdd0-6481-e892-0fce-16d184d69896"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b7feb936-d6ea-8d8f-4374-4148f1f7d07d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b89d7509-2447-2ecd-5c54-fc91cb8f2fb6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b8ce5f3d-fcc7-59b7-6f82-8c85107d6626"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b8ed8d13-6759-a583-9631-9151aa91daa6"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b957628e-0a8b-3d32-c38e-4388eed39f3b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b98e7c74-8087-1018-e044-80ea1527eeee"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("b9a57623-eb9d-326e-cc09-8bf55b34c392"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ba03bd93-951d-337f-8282-4e13cd7e42e4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ba5d6375-29ab-9f8b-1d3d-a28f80e51210"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ba88e06b-062f-54f5-cebc-37a9323f1e3a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("badf96e3-79cf-0887-2d3b-43ce588e1522"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bc125f8e-7a5a-22f1-046d-cbf656fb2af7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bc9abc81-198b-7348-6a78-982ef45e959d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bcccd8bd-8e2d-f75b-0768-b6e4ca7315cd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bd0a99eb-d6f1-8d9d-60a3-eeb903e5b5c3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("be045b17-8e16-8b05-33a2-0c967da7cdcc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("be54d9b3-84b4-a428-619a-9a975fb76295"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("be5fd2ee-072b-9f78-4bd1-ceea786f3fa3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bea41545-199f-ee66-33ad-30af6706c91c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bf40ad51-7aa1-77a6-c1c4-24b06ddee749"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bf44f053-8b66-0eab-729f-c929853cc4cc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bf4cdcd4-a09d-921b-d4f1-4a29f0ec1c8d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bf56eedd-08dd-666a-0bdb-0bc92179053f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bf9c65d6-1f3b-a75e-cdcb-735230985774"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("bfe4a807-1263-c19c-8093-ca2c2ebb1272"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c0142db2-2fbf-b676-4351-0e3a0f218b26"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c01f7dbd-5948-46d9-454f-9f9dbc45871c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c06b6366-97ed-3dd5-794a-ead7ef722f1c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c0bb3609-3df3-3191-7294-237499a27d76"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c11277f0-f632-e8b0-aec7-a28d7866d625"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c11a60fd-d228-74ea-c7a6-b53152361183"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c12c9a3c-ba04-e561-7c26-9f09f3ae2faf"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c1337a53-1979-92ff-f15d-09d04ce35a50"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c158e0ab-8871-d3df-da5f-f4175b8ac37c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c16fe096-b375-08f2-2ce4-8001499feb5c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c1e036b2-103d-65a3-d4a3-5413cec4e962"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c20ee007-cadf-416b-c159-363db030879f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c2dce34f-6783-2e16-706e-13c72f136ec4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c3120a27-1102-9b08-08c3-85745e7f4266"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c37ec008-9405-8692-5dff-a74dceacf36c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c3908c7f-9007-e260-f5e4-784abf6ab33a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c390e853-d00f-0517-db64-5a7433dde85d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c3950b2f-6e9b-412a-d6a9-3630d0a8be9f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c3a8cadf-0541-3cd1-2c82-37eb8e159619"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c3d6fdf0-abb0-527e-f2c0-2ddcb8fb4561"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c4022493-6cd4-7969-c93e-f5090bc41f92"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c40e6030-4ee5-feeb-0eea-ec6e7e2975fc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c43e7607-3828-80ce-7d53-1fcb581c5d4b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c48175a6-5bda-2a1b-9d76-ffb3dbfd9cc0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c4bae977-7045-0d0c-5516-66e75801c5e4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c535b7ad-4210-99bd-4a70-c53008d4fceb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c5a8c007-51a2-1cdc-772a-c5c0b0f97804"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c5cf4326-81b9-795d-2b0d-8c64d5ae3892"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c5d8abe5-baac-61f6-211b-47e97506fd82"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c6082b78-6f88-a497-c36a-ba74df504ed9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c629eeb6-3a0c-eff3-c3d5-a8646822c33f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c6597162-3c3d-7981-06e7-f1f32c877f34"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c6649fbf-db01-e2db-a1e9-df1429365974"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c7089866-e055-1a08-1742-4207d1b369aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c76a76ff-a34d-7114-32a2-399813cf07d2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c829c5c7-5b17-7009-e0cd-d857964e291b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c856afaa-55f3-41b7-8026-563ea9904e58"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c86ed461-37c5-4f72-bf9b-baf99b44a49a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c8d0da2c-8c88-0d81-1e5e-20d5ce4fde6e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c916fef0-d5f9-35a9-a1b6-0f86b8eb234b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c93b2b6f-6b0f-58db-3df1-abc132f5a32c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c970d0f4-83c9-2792-fb7d-9cf20605fc97"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c9a3ea67-9717-7cc9-6fd9-bc288b4a7a15"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c9c92c3b-2bc9-894e-9b9f-a26dfac9f31c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("c9de2eb5-2e78-46dc-8fe3-30cc17bf36e1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ca56c4e9-fade-abff-77cd-11a343720dc3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ca593015-963f-ce54-764c-b988a893e389"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ca62bc5c-accb-eaad-aafe-5c3b544c936d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ca68c95e-2670-913b-ed66-6b02bfd1c275"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ca9a01c2-8bfe-0e4d-a217-759dbc115f6a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cae76c55-6243-935e-9cc1-587273a27d12"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cb6a151e-23d3-e626-6911-e053a4d8b093"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cbe22206-8099-2244-873b-e8b3c4938a2d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cbec50f8-dc08-9a47-0381-9e815c5a544a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cc0f8587-2e62-7534-96b9-79ca69c1b17d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cc1259f6-d1ca-2fd8-5371-6495d21d50aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cc4274fb-a52b-e881-da06-6ec570d3d2a1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cc90471a-c16b-6352-aca1-6fbb4e35fa3a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ccf0300a-f2be-635b-34f6-c1e79490e6f0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cd1a2e2c-9b6f-ec87-4850-dcee8908d8e4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cd3238fc-2875-999b-2a50-40ee01e8d698"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cdb81f89-d36c-be96-e646-34d8bb589c10"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cdc42e04-d7ff-2c47-042b-18ba00e0171a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ce0bf6e2-a854-4916-07de-e74728885be5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ce0e9b06-eb37-1178-8596-82c548f5db06"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ceaac73c-9deb-75f6-85dd-57e62d10f0d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cef42975-6d5a-f8b2-5b9d-ee791d1ed82f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cf54278d-2ad4-bd93-9351-7082f724fc6c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cf6cd49b-29fd-2808-a257-fe13e05471af"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cf9cde0a-e06b-c593-9c5d-28f504610b31"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("cfe16c2d-9d81-e132-4d45-097b7a22ab57"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d03a9926-7072-c892-db21-16ce62d57a42"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d0cbeb93-ad86-ba04-3abd-4a3372ca6d95"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d1ce431c-f675-6a00-dc05-fc0b61f58cfc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d1e448dd-7100-95cb-3f4c-3af1d0393c83"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d1e86d8b-d1f8-3fc8-aa71-a2b2a7370b71"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d23af4ca-f88e-6a08-6b9f-957b13d52e6b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d24d60d9-ad46-2d75-f455-bd8637197906"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d26e278d-a367-3e07-fab9-a98fe8e12875"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d273413f-c3bb-2e76-2163-1ffaa868563f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d2d1da89-b345-3f90-fab7-76f4fc438cd9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d2ea7a62-46a9-f9b7-fc17-f691d3728e8f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d36638e2-92b6-e91f-742f-a6c6c3d820a4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d3e20338-4a75-8e8e-3775-161c8db50c11"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d436994f-f277-8a83-6756-6a5fc56897d4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d4562987-2dc2-fdfa-3532-6003a215ecba"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d45ec2d1-d6a0-efff-91bb-d6230b7ecbf7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d48bba46-3eba-65ff-58bf-5de637441191"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d50ba42f-02b8-50d1-4320-0ec8d6af89ab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d600e6ed-2696-a0e1-a6de-1417581be8aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d616d11c-b908-3785-26c4-5519c6292358"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d61ff7da-f2e6-3114-8af3-c57d95bfb26e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d6546b73-2775-b0ae-9896-6e5c598d255f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d65ec07c-a945-5fdb-4aae-4c77baa5ce78"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d6ea717d-f0c3-ab69-807f-07deba560e18"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d70f9b50-adb8-427f-e933-44776a465e80"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d7bd3aa6-9f87-0a5c-4ad0-1ebf8a1534c3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d7c03a6f-f143-547d-b16e-06cdfb33d7a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d874ee8c-6c8f-84ef-3922-6edc6de8200d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d8ea1f1d-516c-a83d-9941-b7c2cc26318f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d923e682-84bf-1ff1-c2f2-5087b4b0f577"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d95eb8a9-1d56-dd86-88ba-4988a24099eb"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d97476d6-5243-b4f7-9107-7a61ed9348fd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d9870d13-8576-60e8-36a1-ea4c378efd5f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("d98e9ad8-b87c-9139-2d29-d9ee08b33112"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("da354d7e-af47-d30f-e6aa-7c0ad9e7ecc4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("db036217-b2ca-a2a5-9cdb-faaf55f0bc9b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("db91c2de-b6e8-5c71-506d-3c67b653f0ab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dbb96db6-6180-3e1c-811a-b4c247b5bd54"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dc8472dc-1b46-a6ae-33dc-f395933b6142"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dcbbf088-997a-dd24-15fd-a1368e220127"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dcbf2d34-459b-65c1-4872-4da94fa4d8aa"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dcf3576f-fb06-4c27-126f-d44e017ead05"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dcf3b86e-16bf-93ee-ee61-a21f5c05454e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dd297e47-b107-da4b-425a-f5d86616f179"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ddb778f8-8a73-1ce8-cd64-44b72d5cad62"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ddc0e12c-3792-f22a-23b7-c596ac69fd33"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dde17823-10b2-97df-70c1-77ad349968fd"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ddeb5ca9-943b-3f87-c1ae-7477f6fd5ba9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ddff7e7a-73b6-1df4-3451-4102876b72b0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("de4e927e-b801-cb67-e7a9-c3f45bcc783c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("de58ad66-ee89-8f70-5fa9-1a3e2ea92e52"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("de5c9f67-3e29-f68d-5ece-5800ad89c49b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("de7c0d94-40cb-62a3-a23f-ed001c9dc325"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("dea5c050-eb25-98f1-a53b-9d8c3b29d635"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("deb23de1-d180-b885-8e24-d193377eea8d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ded1ff73-13c3-c105-1254-f8a48a2e1458"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("df145b10-f1f3-74ea-8903-a423b35f927d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("df74de34-fc38-c618-f334-f5fa3dc61e36"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("df89b9f2-a191-50e4-f09a-1be6f763401b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e0a05c73-2903-a514-abb9-3e4b1b2de00f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e17a6641-be47-6fb2-56aa-3749ae6dfd3f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e1907635-52ee-c06b-cea3-534cd4a71d78"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e2122f40-1ed9-2dcf-6de6-545be7df57d1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e294c7b5-9bb2-dc7a-05f3-bfcd64228bd4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e2bb306b-6dab-7d43-d753-b843e1e8b7cc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e2bed90a-12f0-6c16-8722-51e05fee0ac1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e3b35873-3605-247e-817c-28df469c7e97"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e401301a-426c-013d-2e9b-06ee37324f5c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e48921ff-3644-311e-9f31-8e4ba86c203c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e4bff653-588c-1b7a-9fd0-32ce1cbd9b78"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e60523b5-febc-c22a-11c5-7284c373a5ae"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e64503f2-60ad-c15b-5d43-16f6bb407983"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e646c477-960d-8fcd-b461-3470e921405b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e6a25d44-9164-a34a-ce63-754846e0a9f0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e6e50db5-4c05-1d3b-e55c-03c17be4f96e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e7154ab0-f828-07e7-2e52-d749c48e2ce4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e736b241-a0b1-8a6f-2cf5-3c43cc58596d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e76b676e-0df1-d846-27ba-ed2722fbb9e4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e78b5d32-d89f-cbcb-c1cb-af7c48a42fda"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e7c61a5f-e532-08d0-773a-0c69f1239910"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e7e594c0-3131-0d0f-18a3-d98ea2c2eb19"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e818db58-86ee-727a-eae5-9ef2a6dd430e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e82f77f8-fa30-8d21-cbc2-f965528c8c67"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e87df808-de35-3ef9-ddb7-7ac2798e24c1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e928f5ca-130f-dd6b-beda-74b6fe6af482"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e94865f2-d40b-c498-d74f-66ac81e4961f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e957ff09-cbbc-257a-1aef-f10bdf14c496"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("e9b5b584-90f0-1a77-a589-174f3265fd47"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ea76672f-9aab-2591-d174-620263bfe404"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ea7fc2ed-95a9-2bc2-47fc-eda30db08357"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ea980200-1641-7c69-e3e2-d6356bd98b8b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("eaa63a19-ba2b-41fe-d0f8-b69c7b2d12c1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("eacdd6cf-6db8-bb66-2698-d94fdfe6075e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("eafd2a69-300f-4104-06d6-6c8e8f063af2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("eb6ad456-291c-f47d-3ba5-7605aeae8846"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ebe248e3-ae14-c85f-81d6-39a455ef9e72"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ebffebfb-9356-0159-cd8a-a8ef49dfc2d3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ec5573dd-050b-354a-7c80-1c354d69d323"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ecda893e-2e07-808f-e3c0-2e7a56eef5f5"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ed07b168-5ed5-98e6-ad29-9068a67d4467"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ed139941-b60b-33f3-4315-6d8eeefde44c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ed92d776-2828-0b20-b41c-a88cfab63ff7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ed951a87-d5ac-aeef-83b8-f3216af1fc8f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ed9f58bb-2458-1c0d-08b3-1a86e22d76bc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("edba22e8-4b6a-6f1a-6277-eacb34d22850"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ee01ac3f-5528-95a4-dac9-5ff4c09e1416"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ee262572-8cc8-1f82-e5e8-64352b3a5215"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ee3e612f-798f-8b21-08b9-a475f6555dca"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ee4cd459-98c5-b923-aff7-a2ecc7c4a8d1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ef4facc7-996c-ba10-7cd1-31e61bbac95c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ef5e9bc8-f6c1-b286-19d3-148ecf4c26a0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ef65c8b7-ca33-df23-9adb-af862701b9b2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f0308f61-9243-19e2-16eb-de47443ab660"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f173f881-fe3a-54b4-5070-92cac0721bec"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f1cbdb07-e2b0-504a-d6a5-d892e499574a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f1fc4ef5-d9cf-3a46-f757-6fd741193e40"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f242f775-b186-0c08-409c-ad17b83d59bc"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f2da715a-29f3-9eee-9a91-4aaf8c2b4bab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f2dbd4f8-3a7a-8706-9453-be91bf6cdd54"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f318b4df-b65e-7a6a-ef9f-45ede0cdb610"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f33cdaf7-5fa3-ce31-a97d-3eb56f80ee6d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f39c0a54-7722-0571-73d3-9501b68ba240"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f3cc8050-098a-e031-691f-f79026e92674"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f3cf3206-9e02-3c20-cc7a-65239a806534"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f43d9937-3f27-3a62-bf01-25310548db4a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f44f5585-0877-27a6-bb1d-2637169d54b9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f47add04-5d2c-4f14-d250-540a1e8af425"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f47e513c-0685-7b50-e0ec-9bb411518f9e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f4819b63-596a-9332-ece6-58aa5d6cde21"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f4bd6d02-c6ae-00dc-534e-6bd8b5b61860"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f4f43275-530a-9206-76a3-6a5422c76bd8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f4fc8d7c-eb45-8ac0-91b7-674a0fd8796d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f5059ac9-b330-5e2b-cf7e-16950d08ebb1"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f5809164-c9bf-7d29-df89-60cbeee04806"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f5c519d2-fc50-786f-cafe-c72971a3d2c7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f5c5c264-e73a-5416-8264-0383f9c6be75"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f5e1d140-4a25-f6d3-5c51-e21795402ce4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f66223d8-aea4-9643-e396-f64782dc232f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f6855ad2-2ac4-b313-a9c6-b5e5fa6f4142"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f69021a0-6401-ad8e-1425-2c6584be77ff"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f6b6fffc-cb55-61b3-fd2a-f55a19e673b2"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f7159705-3982-df6a-a67e-e1204353cd9e"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f7414ec8-6ac0-b022-8ab9-86afa4e38912"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f75e4c69-f376-75b6-b655-86f10e490752"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f7b6e137-d1a0-b022-43e0-ac9326effc42"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f7d5eeb8-fe7b-6147-3212-862ac33f6229"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f87e7649-ef70-1f20-66a2-a06b0ca59268"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f89be166-8a99-1b64-10a7-93b62062144a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f8b55b2d-5d16-ffef-48cc-d1261d6a1789"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f8cdb9bc-e929-731a-0966-e367f210adda"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f9b3ef53-3cb7-85d1-ad23-aa3a2e6b8da0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("f9d5e82d-e9a5-561b-f755-d84763d23b2f"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fa65b84c-528c-a8e4-ce15-37faf469f8f8"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fa71891a-72ed-31c0-a4de-eac886b74d35"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fa8c3d7f-895c-2f69-3222-1e7502b4c592"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("faa1fa19-5723-b122-4171-c4984518cd54"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fab3aaab-21fb-3431-c28c-69f0df52c19b"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fb010b57-6264-b39f-9091-fe5f4fc35a1a"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fb12062d-eefd-ea19-1f71-cc0ef7caf188"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fb737c00-6ec9-798c-e955-b5d05737f1e4"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fbecce42-f1fe-c9e3-8590-2f51b672b262"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fc2d7c8d-fb97-1d68-c448-1bde137177d9"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fcabbf88-1040-2a45-cd9d-c2c2b5d76ec3"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fcdf84cd-8357-2ae0-0f78-38287d5a5764"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fd272998-cc25-87a6-2e07-7bd41027fa96"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fd761907-5af6-0ad4-868c-8f5305fb6ab7"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fd80e855-d4b2-b31b-725e-f670669c1ada"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fda03720-0af6-05a9-bdbb-8f5ca96bc061"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fdb03e42-7a51-baf4-4892-384545e1a58d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fdc4e613-9107-72a1-4372-43eee65e4ea0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fe0aae75-b4f8-11d2-856e-d04af4a99027"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fe578efe-de4a-a700-acea-5972fb76d3ab"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fe621176-e657-df6c-b64d-b78a8cd3d0ca"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fed84acb-c1e3-5ce0-cd3c-07da284de237"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("fef58ba8-f850-736e-e136-b9dfc09fab5c"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ff52f372-7e13-1b94-a6cb-ce54e63dad5d"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ff56381d-0b3f-f825-84b2-42ad71b9f1d0"));

            migrationBuilder.DeleteData(
                table: "BuyOrders",
                keyColumn: "BuyOrderID",
                keyValue: new Guid("ffa226e9-e9f3-bfff-a500-18d21ad8b228"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("00189643-a3df-3534-b665-bbac8a5df889"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("00497219-639f-2d9a-0fb5-a3aae5ffef35"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("006ae72c-b461-c58d-9d77-4444e930cbac"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("00ebd308-9ebf-6e1b-9909-f67d0899059c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0127bf6f-e810-eb2c-412e-7dd332117c04"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0149b872-c341-ba53-34d0-7b01d2469649"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("021579ec-d810-3463-beff-e20f65cbda36"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("022888e9-6234-f795-a812-6ec2d00a6704"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("023c833f-e6ad-b2c5-7f84-b04fb547cb58"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0247be4c-0e05-e7b9-5384-8eb9b88f199b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0257c76a-3cf4-d2b7-7264-760e559118a9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("025c3407-0ef6-d930-8438-6a2333a6ee3f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("02755d53-aa57-07b3-1eae-b80240471729"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("027eab22-1b75-bf4e-a28e-4b396fc21c67"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("02b30c7f-c7df-ba09-9264-793dcbf3278e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("02c88bee-bed2-2a28-16e8-6d7907547baa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("03394887-ac91-dde2-6dc1-f2c6f69c22b7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("03d60abd-6aaa-f601-b9d6-68100954d639"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("049eefd5-78f3-83d7-e3e3-4594a0bc0101"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("051454a8-ff5f-e4ee-8186-3c4c41361f38"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("05249669-339f-bc0f-c7d3-a19d5878d704"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("05255bd2-a423-f038-bd20-d5e3f5cd00b9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("052f5e11-c14a-6507-ad90-b61869dd7d3e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0530b226-bb73-4b2a-366b-74af3d4fd829"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("066a3d7b-6f29-2fe2-3b54-7cfa6ee14364"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("06a194e6-25d0-c71d-2b8b-d4f356cf52d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("06b8a106-9c88-58de-8f3f-a2e491d995b6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("06ccc6d5-e110-8782-eb9c-2ef127d798c2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("07ce89c3-5c93-1e03-90df-4ebbcef1adf2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("07f9abc7-1122-a208-19ad-cf74e631f539"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("087ec763-8925-da30-38b7-0d8160109410"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0948b497-2ce7-d6c5-8976-d27f72d804ab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("09c844ef-9473-8c69-a010-f65ca319319c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0ae62d86-2409-df9a-7caf-526c5f838418"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0b60e523-0e0a-a4b7-f375-2e12d6b57f24"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0b78e129-0b86-3a20-edcb-9ab08bb25190"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0bb434c4-e4a5-f43e-f477-5f00be34ca6b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0c1dcf5f-e933-cba4-7a76-6ee56c6a42a1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0c84598a-3807-8735-b7c2-9ec2728994ca"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0ce839e2-2672-8289-0755-96935c4d4a22"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0cf9f5c8-4549-7cb7-f8ca-9f655de5a22f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0d4fe01c-a04f-ebf2-5c8d-6c9ebf27f6f1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0d5223ca-b3d6-5d31-3b95-70e08681c395"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0d646398-c53e-c91f-30fe-786cb7a8471e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0d7bb118-ccce-6414-456f-31c5f6dba732"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0d98ddaf-603c-5549-0b1c-9767566637a6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0e066d3d-0bd9-6aa9-407c-a594f45e1fc5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0e2b1de9-5d5e-fb5a-3a7b-a675c74194f7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0e77d200-9e0f-3f31-e83f-6bdbecc414b3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0eb1924d-bc8f-c89f-b5e4-9b0d04236d2f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0eb88b08-6245-f3af-2b32-ba1bd07d06f4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0f53de2d-2c75-170d-90b8-9028708f22d7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0f701b50-12f1-3211-b4f5-7dd137fe4043"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0fc1f0ca-f481-beaa-3029-988949bbba8a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0fdbf193-03ba-15a8-feb7-516574947d08"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("0ffa0b49-8961-3a8f-b3f7-18bdb04f6ca6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("103d9a4b-a3bc-6fed-74b8-0cbf02eb3dbe"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("10ec6366-5302-3ed8-e6f5-49f6ccc347c2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("117174f3-1c31-43db-8516-2d2be4c12cb7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("11a83600-6b74-f9a4-07b9-82ec1a74b810"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("12376732-0c1b-754c-8cf9-8c887ecff16b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("126f303f-2f29-3741-a9a9-b8438f9ea503"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("127b643e-c482-cc48-2a34-06e65a159bda"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1286c7f7-6686-8409-cd72-e2b86b6c422a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("12e531c2-65a1-8e94-8da9-9276acccd960"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("13462e2e-6b33-2058-f772-b1f1c9888c81"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1382cf61-9f72-6efb-4c47-c7dd273c8d36"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("13c27723-7a4d-442f-b1d0-7204db033010"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("140d0b7c-4081-fa01-8fc0-7cbf08552f6e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("141adc71-c188-e04c-f5c2-1f30eba73e44"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("142d8b7b-5b50-8196-7583-e02d153065b8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1440ca0c-bd71-6509-0c59-9500384cde06"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("146970d4-d655-82cc-8f1d-8ff95f553e96"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("149c2796-7eb2-0d75-87c4-8cbb5eb0af17"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("14d513da-9913-388f-6d8f-c23daa513b0d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("14d6fcdd-6e5c-1aad-bccf-fba956e879fe"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("15726220-982e-8d94-8ff6-efa95af7fc2c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1624af64-aea4-0d53-56b1-9881e1395397"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("16b3c008-a12c-010a-7ce6-03204fdf32e5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("172c540b-611c-6975-d62c-adf9e8cf1cdd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("173d340d-a0eb-93d4-e7fb-2edab4b04c5c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("17428aca-13a7-e7e9-52af-0fe84e45f45b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("178a7001-42a5-2dae-e61a-71d411bf20a4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("17d75dce-d7f9-364c-f49a-749a48be1f63"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("18d7d71e-01e2-0d0f-9f17-c20f0151c1e1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("190efbe4-488f-f074-c576-07f1309940b0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("19323a00-0699-fc63-11e0-01aacbe458d4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("195d283e-73d6-6498-044f-8de343ecc1cd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1a126610-95d1-edb3-c01c-cb64f5d77f03"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1a27a754-1d02-8ee1-5c18-19e7fe342ba9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1a44cd78-7e1c-4d50-2152-6bc528706559"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1b30fc92-c058-9413-a5d8-436579570da6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1b692d3b-b01d-7173-d85b-daad5ebb9b8b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1c0a51a2-d949-1a70-eb97-fd5792902bd8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1ca03552-4cf7-d46e-8d3e-5413ef0cd16f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1ca7831d-b5f4-8f43-1743-e4191fa136a6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1d9f1717-f840-f2e9-7f68-f6ee52335cf9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1db52f97-4e9e-5f02-2e27-ebfe14e94fe5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1df14eb6-7971-f066-49f6-162dbaef2234"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1e513e9b-2adf-81bd-82a0-a2e382d7d9d3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1e6205cf-9d7b-5340-918b-284311b093eb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1e876fb3-7cfa-4459-9263-9634482c7b66"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1e936753-a9b0-dd30-b976-aa32d8ee441f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1eb7e5de-577a-6d0a-d659-69a3c9e08405"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1ecc1303-8955-bc52-0a6a-00d69d8153a2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1f04d05b-3739-3232-0c86-e18a96ca3d4d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1f17fa6a-2813-5f06-20e2-ff23f7718869"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1f26e6fd-f014-0873-f306-fa5cfb697ebd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("1fc7d64d-e698-1021-77af-9c3a7df5269c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("20b17eaa-89a5-bdaa-0ff5-3a5e2632a500"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("20f12575-47c8-2fb4-145d-1c2b431b8c67"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("214cd931-e01c-72c7-443b-539ad8ac335e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2164bfbc-b2e5-6b82-4e84-97ecd7d3ff4c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("21a22f71-69a4-190c-f9d7-d79a19714960"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("22101b4f-b698-c38f-c59c-cd2390312a72"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("22f5a974-4359-81a1-e79d-15e5d88d7e72"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("239c172c-108c-3af7-a3e2-9c4fd050e1aa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("23cc287e-4ed9-8feb-ab13-ca9723bb3033"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("243a2778-a54a-367d-066a-0fdd8a65be0e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2451f664-8ea1-2f1c-8c32-55ee53a659a3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("24f4c151-38d7-3f6a-a439-4a3d77f34b9c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2500aa67-7477-3591-8c36-f5c0e5fa9088"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("250f41a8-e326-fc2b-5904-dd718fbac7e8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("25538c9e-a01e-223c-1896-d7110e6ed7e9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("25c13314-335f-18b5-0875-5943ac94358e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("25e553b8-403f-7e98-a7d2-5843bba6fb38"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("25e9b023-5f01-7973-9c41-2b83821c261e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("26516e89-ecac-3663-aea6-3b1e22eaa401"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("26861756-90b1-33bf-fba7-7359c777efc3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("269bddb1-43fa-7d96-b792-f9782fa376d3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("26a590fb-be09-a610-69b1-6c115e1860cb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("26a5ff75-fcc8-71a0-8d70-c20b59969a0d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("26f8f7c9-7b05-db7f-de80-f5c08883ffe1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("27083a0d-69e0-1b00-cd27-0824419b148e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("273dd369-4577-4085-7a53-ceceb82e837f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2744055f-291d-997d-9bc1-6eeea3b92c04"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("275e9646-60c3-1f5d-0a90-f31b51fa19ae"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("27612610-37ca-6198-8ff9-8591a4546b8e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("27b8b8b4-0dab-36a0-9c13-6e945d870a99"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("28617785-2127-d7b1-a7f2-47a4fed9b718"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("287e5668-dc4f-c15c-cc33-0c48b468ed2c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("28f2f08a-29fd-7e5e-8395-21eb4c56d6a4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("29883e80-85fa-c2f0-9fbf-579b36965f76"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("298ee7a7-81e8-6ad1-c9ce-986307f81aa5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("29b2e1fd-4b1b-05c5-b1e5-008ad5953b2b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("29c8432c-b0b0-4a1b-5964-151e087c2d61"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2ac311d7-a3d5-316b-36fa-163d5d56dbc2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2b27357d-cae7-a858-2891-ebfef6fa6100"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2b315aba-d47c-34c3-2bde-6243bb6d6699"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2b916b04-18e2-dc9e-c343-ba20b214f7cc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2b99b7a9-7be7-2ca8-367b-e7a386aabba3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2bedc2a7-70aa-09c9-2992-b07520ab82d2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2caff4dd-7095-a8ac-c813-0b42996a0df0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2ce7950d-9bdc-5ff1-19b1-3a60049ce90d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2d8389b7-39dc-9717-c262-f7b648cc57d7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2dd3fe01-fdda-88e5-ef64-c6f6a696c5ac"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2dd53c46-4764-2740-d34d-497f0f3ed06e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2e4bfa14-a186-932e-7aed-0547d814236d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2e4fc238-a3e5-c4f2-6658-413171ea7b11"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2e802f11-fef8-e633-cf53-92d50ff5b754"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2ececc20-8e0a-870f-cb5e-e1e6c92ab8d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2f0f19b3-a5a1-c116-d0ef-8e69449c87e3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2f5845d5-ac7f-6200-eecc-71f45397efec"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("2f7f9539-2036-753c-8b72-d0e1ad221c36"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("300b3f49-1c6d-dd2f-7a2a-ef6582f89c1a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("30631523-ee4a-57e7-c73f-53f001016bd2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("306fc058-18d6-282b-608e-cc443a520176"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3088610a-6dc5-3f32-eb86-da1359a75417"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("30a1e08a-27bb-5a9f-4d2a-25979404643c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("30b03e08-8b8f-88e4-8cfb-c23d9f5fa595"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("31146c86-d446-792a-a511-ddd7119a5a20"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("312a88ba-69e3-92bb-0e88-d0fc50b00da9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3140f183-f430-3601-0227-9135c7377e9b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("315fb6b4-cdaf-ef32-e219-9635aa5245f6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("316969be-71f8-3dc8-7c11-53a4b7a0ee36"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3188f453-423f-8e46-2cc5-77166ddf2a01"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("318d0cfe-269d-d32e-edc6-02f3b4e6f08f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("31b862f4-d783-5434-6374-235a681971cb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("32113500-7080-cb3c-9ff9-dd8bcecc8b0b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("328d907e-5962-2024-3a77-0fff502bac5f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("328e58f0-6626-51be-acec-c06eb01321f0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("329840dd-e409-6878-a0ba-0eb100796c6d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("32b17cb6-56b1-0c69-9798-fc2330aeda72"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3323889b-c72c-011d-ca33-51d5c2f0280e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("337098b8-791b-32b2-d3b3-e702962d65d5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("33c5a51c-6fd0-9d56-360e-1dfd22b63b9a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("33e59475-f75a-2b96-0683-1a80d08c171b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("34c41193-59e6-a152-ecf8-5aca1030bf7b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("34df9c5f-6af0-c348-1515-005d411fafcd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("34ec9e48-5d13-e68b-cc8f-2eef67f86730"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("352b25d8-818c-4566-51bc-5a9eeba991f1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("353e9a40-a8cc-f979-f257-273026be74b5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("354c3a50-31e1-d32c-a730-8b06ee2b36ad"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("35e406c4-943b-2482-44d6-a8760a55acd7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("35e752c7-f153-4aae-70d0-a5bda114871e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("36300ec4-599a-8435-8d1a-47cc71ad1b83"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("365ea239-dcf4-599a-121d-5db18b7fe9e4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("36d89efb-c2e8-c348-9392-3d11b0d83fb0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3755177b-14bf-ecdb-ebb8-bc98ed476a25"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("37d23e04-b2bf-4496-68f3-915b260ac392"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("37fa8622-af4d-9cf5-4ba6-32fcfb9341a2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("38bbd89c-39d9-a579-d1a4-3a4bf6c2bd91"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("38be24bc-ad9a-e73f-cd89-2ee949bddf01"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("38d180ff-1063-1d83-00bb-eeded203625f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("398c3c77-d563-7a35-57ea-59843aee765e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("39e74dc8-5c91-b572-ced6-b4c3294413c9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3a632e26-9502-2ac0-c5b8-12eae696c726"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3abc0e5d-0516-da86-8fec-3ce9400776c7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3ac46f34-3d0c-e4cd-2651-feb13bb506cc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3b0ce50a-eef2-3be3-7c89-d8666719bcc7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3b3ee3ef-85f8-b29e-21b0-899c73c05e2a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3b6b6719-4c91-5d4c-20ec-e60cf9b1c815"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3b95b2e8-fbca-cbc4-4c5e-43462398e749"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3b988e26-db20-ad82-71a4-76ce51c0f3ed"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3bffab24-1d61-2280-5182-0f1235be3dac"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3c1f17f3-4ccb-c11f-4c24-90903b258820"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3c410185-fec7-1ae2-f024-d8c1e4a85ac4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3c58b513-09cc-ccc8-62ad-31d0aee09337"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3cac43d3-5f9d-306b-fcec-eab01ddc0e36"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3cb680a1-6546-e561-da54-074fc3c2b2c7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3ce4ef9d-c5c8-06f5-fd40-bc5c9ce68203"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3ce9c5c9-85fc-cc83-15ed-b38de5dcfb37"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3cf81234-0d4a-6a87-bb85-3c5bc07d4f09"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3d516dfd-488a-bee4-0c0a-bdc81e6e01c0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3d669478-ff38-847a-56ac-33bb19f7a86c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3d76af98-118f-afdd-54fd-38c2e9016eae"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3d872d08-0a52-6ff7-bf7d-fbf8907c7e9a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3daa85bb-a0e0-6607-62b1-93be2d6516cc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3dba681a-20e4-0100-2ccf-dbf909714c9e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3e10966e-5948-dc70-8dcc-7b2530df2741"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3e116d27-49d0-f16f-ec3d-3be71260bcb6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3e1f38b0-0ed6-8fa7-1037-c44ad5967882"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3ea39e96-cb10-ad13-6684-502c0d58f5c9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3eb2f80d-d391-5b40-f66b-2ba2d135c803"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3ec015d4-8a8e-11ac-3df5-96d959966512"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3f38e251-0c0d-42e8-b3c2-42ffffd9dec5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3f988505-e61c-e633-2ca9-36b40d05f312"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3fa282cf-c385-f30e-4ca2-cc5f6ce42ae4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3fb9a0d4-c4be-32f3-106f-8950cf212ab8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3fd485b2-f273-7424-da42-efbc53ab350a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("3fdc28d9-ef3a-5b1c-e778-906505693b5e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("406ab17d-6ebc-da36-0e96-77d8cb64a311"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4073c01d-b3fe-0d02-828c-b76cde2a8787"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("40baa9e9-cfdd-3fe8-4d0f-0b62c1306b37"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("40e82304-c91c-b001-a1bc-ae525b556735"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("40f34c87-e0af-12d3-99d0-ce47f30ac14f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("41000dbd-38d6-1b2a-4b87-e8143cc0f67f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4107bb19-c253-4ec1-5935-10bb4100d0b0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4189a120-f75e-8dde-1006-0d48801a8f5d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4191ba18-32b6-5613-806a-4706aef89df4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("42094f6b-2bce-737d-569d-5ed24c13b5fb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("427a6ae0-8efa-d41a-ae8a-8c219d3ae011"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("429b31dd-a1b8-cc9c-fd64-07cc92cf560a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("43a082d5-0af0-61ab-3ba3-e7359700d2b2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("43eef565-5b2c-bbec-d152-aa8ce0bf3d20"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("44458ece-f124-89b5-8e7a-4a3d3fd5a06e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("44b99ff5-4c0c-1056-300c-7fc891b3ea66"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("44c8b161-785c-d464-6a02-1c6547caf670"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("45506fa3-a33f-cd2c-8376-4118e4c5d7d4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("45a6311e-017a-feeb-bec3-ef5d3b7c2b7a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("45a8bb93-c315-0f57-360f-55be8a0fb830"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("45c693ed-b907-c319-14df-25d032e98f43"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("45c82ab9-0eac-5a55-82e1-ae97a17fcac0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("460a81f0-2114-650f-3b06-74e273f7be90"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("464dba9c-660e-9885-32c5-90d63a8df0b1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("465800d2-5614-61db-e51c-027247d5189b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("467663f1-331a-3879-9fae-25763c886f4e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("46b0b9f3-8b14-3c52-3298-294a19dfb85c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("46d65c5f-e3b9-88fe-64b2-a9b72e131f59"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("473df8d7-9887-87ec-234b-bd77dee197e8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("47669cf4-caa3-237f-8e85-068d4ca7d1d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("476c7d26-3ee8-0a76-120a-7528c8801282"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("47ac9172-5809-ba8c-0750-683a1b6153f0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4829af85-1897-6d6e-1622-39b017b2ad8e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("483c1232-b86b-5be0-dd8b-c261051d7bc6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("48b62f3e-a0d1-99c9-0dfa-ec9b7633b326"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("48cd140c-5328-1bac-e509-883a6deaff3f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("48de45ad-88e2-3ce1-8d65-95ba1d1a7a63"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("48de637d-010b-9ecb-df3c-6638f813e7fa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4915937b-0c42-2746-4bbc-1ffce30b138c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("494851bf-228d-2f00-7f71-831dd77b420c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4973aa55-0d93-f8bc-3afd-1e71dbc2c3ab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4a044a2e-7fdb-9127-a79f-b89b18d922e9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4a273331-e5df-306e-d3f0-e55e4fede98b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4a2aafd6-8a9a-091c-a922-c182fd80ba95"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4a6039e1-f875-2199-a6f1-d1b8d093999b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4a8cb745-518c-5350-8e31-bf89f435edbd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4a935bb1-8699-0afc-e519-66d8422fc5fb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4abc3dce-940e-09f9-fe6b-0f0f153ebe41"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4adea0fd-4498-0a9a-ee4d-8fabdd1ea6ec"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4b745184-fac8-fb20-0861-0a95fb94ece6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4ba1e124-f79a-598c-f3b9-4622ca26503a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4baf5b03-e8d8-b5d4-606a-301f5250ac7d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4c0440cf-1dd7-afde-2381-f823c0d6cbdf"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4c14d37e-e043-0bad-08f6-dc69904f76ed"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4c891a08-a621-f399-9fea-8df7c32ee496"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4c9e2a51-8251-ebaf-c059-a4ba12afa526"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4cdfb65f-3b99-1947-f735-66edd231e595"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4d626339-98c9-5491-b8f3-355a15055ef6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4dc95ec6-324c-e82a-05b7-b205732a26cd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4de12553-e512-2025-bbb6-1e71088858ff"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e2c529d-9f89-0d77-c9e1-10f1eca339c1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e30b767-4745-b078-62d0-2c28084da8b9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e3eac90-0c65-2055-e455-ffdd47822df5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e4a051d-3a76-7306-c70e-a5d7fe79ec77"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e569e56-11aa-c18c-3a36-f1fb805c6d2f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e744122-93a7-63a6-a61c-08e65494bae0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4e8b01a1-c514-6c94-3f8d-b5e4dc87ffed"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4edaee46-94fe-0a6b-ce5d-f35f4f1d5731"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4f3d3d01-a91f-1916-b311-bfc5b1576583"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4f90425d-026b-2318-d15e-7fe34a92eb22"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4f968d73-4d15-cb39-cfe2-aa93825065ae"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("4fd8472c-00ae-4e13-e1bc-6cb8d174fc0b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5047ecdc-6c76-d5fb-4725-14ff70836284"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5049287d-a3f4-f481-e6a7-189d9c89e004"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5094b49d-4877-49ea-9d1a-afd3e4e7e652"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("50a5c70f-6095-0dc6-8a7f-a4e863b57fee"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("50cbf8be-5e02-7a9f-3c1c-9323ba6b898b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("514ff565-9390-56b9-96b6-62ed9d6b4ba9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("51e89737-24d7-3b69-7bcd-5aa911c0dda3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("51ea2fc5-ecc0-7d63-d26a-d4d183bc96f1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("51ecf0db-fec3-81a7-4a53-64c5e582601c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("52248aca-9351-4083-76b4-2ab64cfe41df"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("523029cd-b462-e5e5-df76-f8be2ecbcd11"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5279d398-5c01-370e-e31c-cc0e2ea6e3d4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5284e6b2-1cff-e0ae-9973-7c24f52243ad"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("53aeb25e-7a55-2b1c-1323-3d39da9b97f6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("53d74a8f-c579-2d92-1b37-2e668f926e10"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("53e27c39-cead-9872-70b1-c024faa7a634"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("549aff3f-ce3b-694d-9536-55aeb1bb42fa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("549f8c84-f832-a145-c949-f31f8ee1bc20"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("556c2374-fc68-fc36-0876-1974cadca54f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5578113b-7a87-c248-f029-7b91017456ec"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5594d37b-50b6-c4f1-d56e-89ec83bd958f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("55fdfc60-269a-f862-a1d7-0146fe0a6993"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("56093aeb-bb27-d6b6-fb52-19c3319b7a79"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("56921ced-6356-096d-b02c-ee9aa6af3167"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("56a382e6-3e4c-b31c-01fa-92014e4e3402"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("57505924-b7a3-c047-7321-cc67430b1584"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("578ecf58-6ab7-37d4-4517-ee4a61e698f2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("580d8712-2176-199a-25a7-d46611d45335"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("58107049-bc28-843f-6389-9d13fd935c22"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("584e8c38-bb87-34f1-6afd-a146659cce30"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5891faef-1d17-c7da-2253-973744b63e8e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("58f4966f-808c-e6e9-a54c-75ce92970874"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5905e046-c6dd-a964-9ad7-6da78ae6952c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("595cf74b-73ab-08b2-0cb7-f9fe60501abf"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("59a54ec3-ba31-ba24-7d7f-149a356034d4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("59a62bfa-ff70-7e92-217a-f8467317468f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("59bda653-c5e4-a1de-6fb9-994ca9f3d7a9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("59e84080-d52a-2431-34bf-a8cf52e84b14"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5a14f67e-20f5-1faa-ac6b-81490b5b4c93"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5ab49097-aa65-6c2b-6e4a-881e9460a817"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5ac2b19b-4a27-7b19-362d-57a099532f51"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5b6bc9b1-4762-5c73-3615-d6018c1864f9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5c9a7856-f631-bc74-698c-119aa2c12e97"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5cef2b6e-6fa2-1f81-183c-1ed0780e43f5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5cf30e2c-6f81-e0d5-ae2e-50c8cfcd20d0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5da589d1-ac2e-f52a-e821-44c82cd16dd5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5e07c01b-db3b-b674-56d4-2e0c22f85029"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5e168085-ddc4-34ff-8b4e-1ec53f603866"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5e43e2e2-febe-2042-d530-f3a551224d24"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5e9c06dc-10cd-c2ad-3a22-14d09b7bb6d4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5ef6f68d-48a7-cc70-ea37-a5fb0a09c6cd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5f470508-e6a7-ddbc-6045-a8a8cb9dd641"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5f5451a8-5a08-0279-5ae2-c2305d8a234c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5f5501cc-e22f-fe0b-85e8-475fb5d6f638"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("5fdc4275-fc8b-473d-6209-8d98e008617e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("601f0ed7-fd66-e036-2f9e-9efe5dfeb80b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("60bcd444-1be3-fa72-0383-eff37d5c81dc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("61de063d-a3e1-395a-7467-d94d0d0cccfd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("61ee86c1-267c-55ad-76ea-1e8a4896fcde"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("620ce4b0-d211-8663-968e-8087fec080ab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("620e1217-caa0-ed7e-bf2b-1b692ef1a560"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6245ef83-3e6f-9b79-f66b-85cef57019df"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("62ba77dc-f56a-3318-0ff0-0acae8c8e2f2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("62eafb53-6af2-0fbc-494d-aa9060fcf07b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("632ecc57-5b58-c205-4255-8e8cc7c756c0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("633be4dd-4b47-392f-8ba8-1c067593d11d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("635b81a5-8541-8710-3929-28c6f85f57ac"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6451f670-d391-79bf-11b3-b94b55299e0b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("65128b1c-55c8-ecd7-c52d-41f77ca968f5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6512a205-ac2b-d2a5-ba57-a870ee19d1ed"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("65573d6f-6aa3-8a41-3861-58a2a97a6d47"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("657e26c2-ba34-393d-2e3c-115b2cb8f642"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("65cf6f9a-3390-0693-f957-fce1ba7411e9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("66af9a84-a060-cbc7-e71b-eb0717a98c4d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("66cf419e-cfea-cb6c-81f6-405ca0129ab3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("66f0e326-37f6-43ab-b611-d845e962751c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("677de6f6-4a3f-9f35-7a53-983c6752417f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6783acb0-5c9d-25cc-7bbc-29b51df4cafb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("67d803d1-5670-2ae3-fd13-05d40be6fec5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("688f9624-47cd-e6f0-f804-55fe45e42a09"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("68e4b2f7-b4f2-ff89-64a6-5acb8a99d822"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("68e9f859-c4bf-0ae9-bdd1-3e30f7b5ab72"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("68ebc8c4-1116-a41c-4260-c26819e76a17"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("69527193-d145-00ee-96f8-17de84abaa79"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("697ec571-772d-7067-8cef-d076d8762936"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6981617b-d393-9aaa-4d3f-364cb9a28fdb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("698ffed0-32bf-0be9-c641-8a06f761ad60"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("69998509-c4f8-b68d-4bce-62cffa0b1327"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("69ba779f-7dce-a11b-b353-db0d83ce94b3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6a3d69f8-a364-0273-9e59-8dea5c7a93d8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6a6cf73c-b971-f87c-3886-ad7e9c848be2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6b145324-7636-dece-4af8-c58c34374178"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6bc317d4-503c-e891-af9a-b40c32aed920"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6be74c4c-38cc-76bd-6f65-6f1fe72fb1f9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6c2e6d46-98a5-1752-145b-f0230d42b823"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6c5781d8-3f56-6ffa-7330-6539d355e3d2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6c85752f-0d0c-8cb6-95f8-6d98987a71f4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6ca166e0-3604-265e-b78b-e678232d2f7b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6cc79d56-eb91-500e-cd99-fd782cf363eb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6d036538-255f-c002-948f-ab111a1324f0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6eb11712-2300-d9f6-26ec-6b78bd9c7502"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6ecf02c1-7302-b1fa-5758-449cd5794d7f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6eede5b2-b068-1207-6cd4-fd5fb9668321"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6f0d748d-79ec-50b4-f7de-d4685cbf07ce"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6f433763-5cc3-fe8f-4816-061bb50ca37f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6f4dc4dd-7bb7-a218-7f2d-4fff44183702"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6f783fa6-851b-4b45-41e1-1ff644d2ad37"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("6fbe0416-02fa-2881-b919-67ff3cb030d3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("704a9fcc-b1bf-fd96-9a46-8180129e0f5f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("70695685-c246-6b68-f055-7457e9d3034d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("70cd7a50-a386-5d78-24ad-e26bd1b494c4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7109b1f9-71d8-469b-c5db-61c1c18e9a02"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7121b5ed-6afd-42f4-e8e7-b84af349dadd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7162de58-d6d8-2236-4aa1-b95494ce06e6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("71682572-dc8e-9291-daf0-7dbb6e66d1e8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("721d2709-7069-9c46-eb9e-841374495d8c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("72373ee7-5554-1577-a4c9-179c77f1e368"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("723bc740-ddb0-0210-6d53-8be4a5221d93"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("726f5f34-c402-23a3-19b8-2d613020d263"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("72878efa-f877-de5d-3587-ef0949bcce54"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("729c5f7f-0c41-9a78-0391-d97b538c5f6c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("72aa5734-aa29-9dea-dee3-6cf0217e5444"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("72c5868f-f6a5-a4cb-8f30-81f86647f08f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("72fc1689-4243-7909-792e-2ebb51f31468"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("73772805-5fdb-0c6e-a3ed-eae485891073"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("738334de-7140-e15a-cdce-c12907eb9000"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("73adf223-56f6-347e-a536-e9f3040cb75b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("742f5b0e-a3fb-aefd-2fa7-806007081473"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("748c9721-4ae6-3de2-aeb1-58a01c987803"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7586ab60-d6e9-ae6a-d8dd-6c57dc94aa19"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("758e4d93-4b6e-1a57-27f6-3c395768c793"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("764db999-630b-6a20-0713-9931d8a5146d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("76ad7da7-ae05-4b45-f088-c5716568a1c2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("770e744f-2268-83ae-687d-e54e2c324adb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("776e2ee8-56cc-90de-6080-645ba5f36c03"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7791281e-9493-7e80-5172-b30dfc3d187d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("77c9b15b-9996-bfea-0c41-f8f8ce6d2f16"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("77e958a1-e4fd-79e5-82aa-4106e329d69e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("787c8aa1-2606-a4cc-6745-7f680e6f9763"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("78e1786f-1b1f-113d-4df2-e2ed869a66de"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7923f155-7475-0544-f539-d874b6522db9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("797773e5-d85e-a39a-e373-544782c17dcc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("79c7e715-99d1-e199-dd7a-6e71fe21489f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7a5feaa0-b4b8-0f23-6514-cf81b3535da7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7a950357-7c5f-754c-67d9-c2de2969ba9d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7add9f28-b60f-3891-1e42-c16faddac4c8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7b3d93f1-e528-6992-a216-08e1d0e17463"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7b65970f-c5fe-a15c-8a76-80326c661192"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7b88b6e3-49c6-7693-6e5a-b3a4ac54c94b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7bc4b4e2-0737-64c9-ef18-60086b5a5a49"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7bc67a5e-fca8-4e2b-7e8c-7da1c396aad1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7c2cd407-3ec5-db6a-0c02-5fae9d0a2a9d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7c6ec265-a979-5628-948e-61234b2ff715"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7c7cc5b0-4683-3238-2814-faa402216854"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7ca7bb2d-223d-0a84-3f51-2505f534972e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7cb0e247-0e0f-a91d-7910-5f6107248d67"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7cedf93a-1841-58a4-fc6b-0894076d6924"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7d6aed4a-d35a-e21d-8237-817d75006b38"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7dea9d8e-27e8-716d-0d56-b621e672b357"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7e27679f-f93b-5251-0350-e12fc13cf2a1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7e40cc4c-95c8-c9a1-4505-09350abc09de"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7eb2f8c9-32c3-8abc-1428-bc53958ae242"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7eda15a9-0941-0fb4-b288-f3c3c860b0f2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7ee3ba41-6e30-5b5d-530b-1f01138ed898"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7f7b8b30-da64-8d03-cd3b-f143246f1eab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7f7bcd5c-27b6-8036-df88-17c5c37186a0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7f8bc6c5-f809-8e8b-91ec-29382826903b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7f8d07a9-ff0e-6273-3ad1-7503ce630965"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("7febb202-27b4-3563-011f-df7c92893304"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("808710af-8bea-0d74-46c2-3a462692b74b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("80a657a1-0dda-401e-db18-f429324c8953"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("80e9e922-2468-cafe-820b-a7e2aa0a52f9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("80f40112-ce90-0fb7-8baa-f40d2c52f955"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("818a85a1-9e56-bc7f-eacf-768164104fce"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8297207f-0f66-fcdd-d3cb-132b3ef45254"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("829f054b-1395-d466-2b01-e1fb1245f6ec"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("82fbe353-dfb7-941d-8702-b89b72a8f03e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("83aaf209-aafe-aea4-4524-6ee383b51630"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("83d0dc7e-d18c-5790-2198-8918a475ba6c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("83d28f09-8c39-ba1e-f746-a251196fd7a6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("847067fd-f794-e1ba-b2c8-ef153eb08382"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("851c563c-0e07-2836-7390-a82028ca7882"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("85694c21-0756-ff48-7280-523e6a8896ca"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("858983d3-b101-cc1b-cecb-d2b0d0bee1ba"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("85b28c26-1977-5e01-d1dc-6b4345be1da6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("85d8fb21-5dee-f271-af5d-0bd0ca7b2678"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("85db2b88-2881-a0a4-0046-f9d343b80c13"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("85fd3660-ed05-0fe8-dee3-fed08859296b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("86af31ad-ae89-0651-41da-d134a50e5e92"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("86bd21f7-62c5-e43c-b8d4-b13d99dc427a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8729c15b-c045-0910-828a-3aeede4f676a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8759b792-a317-ce24-d32c-f20f8f1e26fe"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("87adf735-aa02-8899-7f40-2c257240263b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("887513a8-b98a-2618-0dc6-1c728735631c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("88ca3f1b-658c-056a-3913-baa334e622bd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("89ad7380-3ed0-ab7b-c529-0c7e724e2d6a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("89c069ec-a0c6-2092-bd6e-dc8df2077345"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8a4d1ca6-ad7e-9807-bdef-148439e2afe2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8aa1cca8-5df0-8614-0d72-9dec3127e8e0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8ba09c5c-bb39-8643-b266-43b4f9b2cf26"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8bcca438-14fb-1a32-2618-efa645060f00"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8c2457d9-9a82-1ca7-5695-45a40a58a512"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8d2ff505-b6bb-1d68-f674-fbadcde9c406"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8d631367-03a3-9b62-f12f-018eeb17412b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8e113de7-0eb8-4fdf-8798-4b50d5a8029a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8e22d1f6-c6e3-5721-ae89-ef91421c74ea"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8e5b7dd0-be3a-1a88-da94-c8a439a27307"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8e7bb3bd-e6df-c8e5-f346-bbb05d8f34cd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8ecbd1a2-d125-2e12-7a91-c2a406009634"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8efa5a7b-ce47-3465-dac2-ff054acca366"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8fa11d57-e62a-5a62-c947-dea6503e9475"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("8fadb88f-9961-cdf8-024b-e89bf1bd81c9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9004ebdd-b4c6-2e3e-a513-3450af2e88fa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("908e9eae-14e1-ceb7-1a68-ebbab7df7f87"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("90f73a51-a245-fc49-a78a-8f363d84f43c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("91acf1d4-0d1c-be73-2cd3-2d5a6a038621"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("91e6fa93-6694-3a8c-4820-72ef4a39afc5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("924c659d-72e8-82ae-9219-6ded0ede25d7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("92e71f42-6593-0377-ecb6-0dac597cf962"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("930bf532-7da5-a5ed-0935-836294c2a673"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9347602b-3128-7741-7693-2b9bd742c977"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("93737a0a-7088-0588-d276-af9164b9a99f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9437f1d7-6887-a74e-c0a8-6bb91e6feb07"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("943a91d9-c01d-8cde-b046-846849ecd4d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9463ef3d-09ca-e554-4cc8-590e2f7e89da"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("947516b0-cd39-7ec5-0e39-d128ac860d9a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("94901c90-3747-3c9c-8220-8d53ff41c4a0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("949df5ca-5c66-7641-52db-03532e5fdd27"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("949f743a-0795-5cd2-00c5-249635dc94ba"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9505ae28-6f89-9425-1d93-2cf071a9fe6f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9589582d-d3a9-8174-40fc-09fa80534f84"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("959e5ad4-f3dc-6dc2-eb92-64742fb3a3f9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("95c2add7-8dcc-5d1c-5880-4037688cdba1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("95d21676-c147-0ea9-a05b-4f62e524eba6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("95f72f1e-5888-dddb-a65c-902f5a392c88"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("960371e7-bcba-dc28-cc98-1a7a99e30104"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9613c015-ebaa-513f-da8f-dc86cb17ea32"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9615c9f7-ae57-44dc-8c66-e33af8247aff"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("962ac3f0-9cd2-733d-6020-dd64e0baaadd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("96735af4-56c2-6f9a-0da3-240167ee84b8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("96ad4bbb-f2aa-c443-0be1-77e08132475e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("96dbf017-f446-1d18-2ea8-88f4158b6d2c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("97ccad8d-5540-e3e7-d6da-0dd4e1b0a2b3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("980aa6f4-d6ea-d904-5bf6-99fcc5290817"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("986b8f00-b1d1-b105-4422-ea42d685c1d6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("997b5a65-7530-ec57-dd4e-c83b889f5d4b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9a1441c2-9338-46c7-3b09-3aa5525715f3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9a157133-ffe3-9e46-0fa7-a58ad67ce58c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9a4bcb39-9a34-328f-78ab-476ecb5a7870"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9a5cc403-ef45-ce23-c748-e01684b9cc6e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9abf5b37-bfce-caa5-2789-a1a3d6560007"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9ada82a7-e398-1979-8b9a-fda45d29c6d6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9aec88c2-1f1d-4ed6-4fa7-56fa1a2b2502"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9af6bd87-a0b8-3401-1b30-b1912dce1865"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9b0affca-4610-6f35-08a7-b43be0c83754"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9b1eb4cf-b730-2deb-ed12-1e4fbf25b0d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9b36c093-abac-9176-ca4e-84b82d9448c9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9bbada9e-f4fd-27da-1503-45dc55700688"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9bd4ef07-ae1e-282d-dae8-8881a02e52ef"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9c8f5545-307d-da4f-e145-153431157c70"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9ca4b0b7-7c36-cfa5-c5ef-5f9095137d3e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9d45c856-2b1b-55a0-1759-f870a2dc1718"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9d77bc30-5a1a-b958-2600-272553b4f8f6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9e761122-893b-bf00-029a-aad26ec6bbc5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9e7cdc9a-e7bf-a363-46ca-c7475b79bd43"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9e9f0ca7-3276-122b-a7e4-95d429deaa63"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("9f94cc83-e43e-9399-8cf2-baffbcb5d9f1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a0265b6d-d90f-145b-b432-4a4157c5c7ae"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a0793640-1692-7be9-f968-9343fa6a7490"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a0ded255-a330-8187-46dc-7df9e6b90d28"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a15525b0-7b9b-7f43-a02a-c98e2f922303"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a16ba5f9-470e-2c7c-e3fd-1e27de767670"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a19b0013-9411-562c-315b-db0676022a97"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a1a8fcb7-0e7c-4cc1-1784-50a1c3612e8a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a1b7c989-7e79-9789-ca08-bef38a0f54ba"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a1b89f6c-fd52-0f3b-d593-78f9c70290cb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a1da595c-a1ea-54ba-2877-175580e676b6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a1fde1eb-8f00-a610-c1c4-1128e2d3c2e0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a217a9f6-31cf-a3a7-2cf6-10e8f637512d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a245b3f7-fc19-0ff2-fc36-98d000676138"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a281d306-4af1-d332-40b6-0d9867bcd7b7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a30b4436-e649-2f91-cd63-a820ab9e8cab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a33f657e-7f36-561d-9a73-a3fbb211f9a6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a387c6ac-35b6-3abb-56fb-d3b0fc323bd6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a465aa7f-6eb8-8d49-6be1-c043aeb76b18"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a47a25f3-934b-dab6-6b5f-deb9102c0309"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a49a67c0-6cc0-a35a-6ab3-cc6c0544ba24"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a4f70c01-956d-fdb3-a250-8001b561d5ad"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a50b205e-3519-7a59-7c4f-ea6d67c1905d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a520427d-6744-6bb9-597a-287ca9239d7a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a52888bb-8184-5374-6b78-92c7f4a1842d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a5746b89-c27f-ea2e-1198-d597a5f78c83"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a6042ac7-460b-7690-91d6-f510ee6c608f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a635430f-9616-a0fb-86a9-e56eb377b3d5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a67e6716-df1c-bdb4-e5f5-1add50fe936f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a696e0df-7ea2-c484-6619-ae3ff9561ec2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a6fa7b80-c81d-7c5a-9d2a-4da368b99c85"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a722be85-c0cc-a964-6518-046b283cb0d6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a7683125-fe80-037c-cd7c-f24d67dbcbe4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a76d2575-295b-35a2-9a58-43a5a31581ed"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a7bc317f-b61e-8a78-6f2b-c235b8705150"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a7c1c3d8-b286-71bf-1dd0-920336c54f2d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a7cf1a10-1d56-29ae-d7fe-a4c81d926981"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a7eb6c52-5785-0683-84d1-f1591c49b184"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a7ed51a3-7c28-d8e5-e679-1404df3d2050"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a8116ed2-c57e-0e52-dc7d-5c46015a8f0b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a8291fe4-2a95-1e35-4f18-328e5d28555e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a83b535f-7a91-9c9b-ad09-b3228f19c432"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a88573ca-5363-dbe3-0df5-8a9728af51a8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a88d4159-a04d-de72-a7cb-c2cbd3abd0b2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a89c00b6-261c-b543-7439-6c1bf8a768fb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a8f902b8-014c-64ab-5565-7ddfbecb3a78"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a904b606-89d6-e970-854b-86ccea545139"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a9860a8f-18f1-d5cc-e5a4-af539f85b77c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("a99bd730-1117-27a2-b29e-e3b428e972f1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aa201da5-46b2-3597-17ff-bacc1f95e0f0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aa735279-d820-ae41-a261-067a830ec371"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aa7ed04c-1049-477c-f263-412b128d38a9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aa97017e-235d-825c-9b18-fedbb2f2098d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aaa0fc09-baf2-43d2-834c-fdc4edf15339"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aaafd231-d236-0896-c696-edadd3cb6e4f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ab4bcb7c-e9da-f947-3a64-a45ab5065f12"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ab74a46e-9871-fc08-209a-2b5f7ba33d70"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("abb63ee7-0279-b9d7-47c9-2a8c5d0396cd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("abfa9b30-17eb-44a6-79b1-90f44bbcec4e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ac09ac72-40ef-00c6-4632-e1cddb3299b9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ac18e6a5-80c0-39a2-e1f6-b4d3180280d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ac3344d4-50bb-025f-8c96-c380b8ba84be"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ac35b744-9940-1809-631e-f63c9ec020f0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aca27b20-db16-1f1f-fc06-343fd7b67706"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ad030f66-25dd-a00f-8567-9cbf89542d41"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("adcdfb75-114a-3b79-7b4c-8d5475626242"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ae6db23c-7e38-39c8-51e5-354ce3aa0943"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aea76b24-d917-bd20-d8d6-6caecb73e828"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("aefdc1b8-46bf-3cfa-446f-3eee7d502349"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("af14ea8f-4576-a9d2-c2f6-b8b3ae149514"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("af1f4d28-7afd-53c2-178b-edc2b38beca8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("af2a0654-0e6c-313a-b657-328b461d9fd6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("af901d78-93f5-d583-1623-ae9bc5818e4b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("af90d93b-f6ca-125e-7328-6636c86853c1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("afd45eb8-9214-2fe3-b8fe-b4944a321136"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("afdb8b95-9927-0f6a-8cda-12a471d118f0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("afe669cf-4fae-73d3-1a0b-84f6ffab5fac"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b0778b1d-7eca-8229-87fe-884cb8a61427"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b08a6b7f-6633-082a-c03f-3e4ed61bc5c1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b0dd589a-07a2-4999-7428-0c8bff704702"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b11cc1fa-10e7-e7dd-452c-710bf539137c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b1285e52-7a3c-a1d3-1276-7baf0bf7c070"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b1875e5c-4e62-99d1-26db-de30f383b625"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b21a4480-41bc-51c6-0751-f305ab3ff611"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b26814be-ed9c-4498-6532-f13a770ffac1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b27b624f-b28c-0f35-73f2-f6e18af7b81d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b2b937ad-dc62-8add-e43f-f6a2744e7b6b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b2bb744d-680d-d2d6-762f-91e82761c1e5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b31ab633-ee36-ba44-b715-e55d89c704cb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b31f1f2a-5685-d916-fe88-dcf8d110df87"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b322e704-caf2-77d6-6c90-4c511cd64389"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b324663a-84c0-8bee-092c-a3cff980848f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b3289ce9-28cc-9afd-a0c9-8973ed19cd5b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b34d183d-5893-7ac5-c6ae-f6fa4f9cd5ba"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b359dec8-21ad-07b2-3791-624152f81317"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b3655c78-610a-0848-8bab-9a326cd5ded0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b375f259-45bf-7fbc-6c8c-f17383d909d2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b3bbb463-3e4f-cf03-8e75-be1f1851aa2d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b419cf08-0697-27f9-5001-099816a2ae02"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b424cf81-cc57-da3e-490a-1ff0500159aa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b451c3f5-7fe8-cfb0-5d59-7f6dd213f590"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b4586172-c81e-f853-9d41-2901326d38a3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b4641468-f171-2a7d-0954-c9728f34d908"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b4684b69-8e47-8472-bcf5-ecb395a20155"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b4a1b942-5028-f8bd-0232-61d35977476c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b4c58a26-6d0f-a7b9-1e10-a14c7cf2ff90"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b4d90bb7-afa7-fcac-c22f-19c15caffc5f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b535e964-39ca-2b90-00bc-1b43798d69a4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b59fda69-a399-424c-bdcc-f27cf3e61ad7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b5e0f044-9dba-21e7-1d31-84326f0d33a7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b6160a14-48ed-9988-5732-2dd627f9e076"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b61ecccd-cc50-f498-6afe-cbda386a9928"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b65348a7-56c1-4b0e-3f68-37db2b4e80d9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b6a70b96-4d1f-5339-f418-898b49944874"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b6b4e289-2173-f354-93e2-15cf6887033d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b6efb19f-d318-e004-7c42-03e697bfb700"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b73547b6-6521-2f14-a60b-86cfd606ffac"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b76a41d1-ac94-717a-81d1-dd20fee446cf"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b7946d42-955a-e798-8891-31b4f1221cc9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b7b10027-46a1-04a2-fb54-f055833c03fd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b7c74c06-b235-e9f0-b214-0c7549ebc340"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b7cd54f2-ad46-dfb4-d7e5-40f569abe1d7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b806a5f9-9d0d-1520-1482-8a7619d771a2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b82aabb2-8c4e-729d-c768-3fc1edc0f589"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b84f0b5c-3036-0bb7-a95a-d9c78120572e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b8572aba-ed16-5444-0cac-2d97a498ee57"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b884cc95-b64b-083b-6eee-6bee5cd1405a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b8dcf8eb-cc62-5a0c-f819-af8b3f2a7d53"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b945a40d-287a-bb13-fe09-17716a955971"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b967dce4-f789-b2e1-6f75-d3624770b95e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b9b385f2-f42b-04fa-bfad-96348fb1e965"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("b9d417d1-056d-20d1-75a9-f7f72f546012"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ba3f03d8-47a6-4b14-33ca-afd7e0c50e01"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ba6ecdce-8897-5870-3d69-3d7b0ab67358"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ba91e7cc-d839-14c7-523a-7d36b681d8eb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bb2ae396-495a-f28e-2e20-23139f52006f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bb5a336b-41bb-dade-57aa-496830deb316"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bb6f158f-35bf-eba0-f14c-a6b4634d4ced"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bb8490e8-1587-047d-fd60-ee56d8188867"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bb9f92b9-b7bc-2c20-dbaa-06e4512c5227"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bc0e4740-fab9-bd1f-6dd6-83f0acecba41"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bc1c10a7-6642-9308-881e-f62d73a7358b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bc4c1260-7f78-ab4b-ac93-116601870467"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bca3d8fb-5e7e-ba9b-845f-5591a9e73862"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bcf8558e-941a-fef0-e830-fca5358a8502"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bd078c5c-3357-a5c6-f6ef-d347f5a337e8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bd68b604-bdae-8a8e-26cb-3ccabffc697e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bd8e6408-d652-9569-5e43-2f5992cd67bd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bdaeb22e-4a6e-df88-acfa-eb9fa9fa0420"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bdd81288-0bd0-9f3e-e802-7bd1ee9e00cf"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bde96e27-529c-9e69-ed96-d7c7be8cc996"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("be312583-bd29-638c-3a0c-eb225671ba95"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("be363375-eff8-7691-952a-3e6922cd5b40"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("be3e771a-8e03-7b86-ef0f-117c36eebb49"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("beb31f4e-6c43-1137-2a40-1cf104eac8a5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bf067be1-58ec-f88f-92e0-1ebc7661db8d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bf3321b1-6d72-e9b0-02d5-cc7e8e62882f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bf40a7eb-dea0-1b99-edca-3785ce6bc8e8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bf53da70-e9a4-375f-5059-5211b2e10880"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bf5f1978-84be-ff6f-2f78-f6af29a45d93"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bf7898ab-9b10-71d7-2fa8-6148be64ca09"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bfbb217b-2c87-c4ed-c252-60bea10f434e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("bfe601eb-3655-784b-5cee-48af77cb3a48"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c042ca68-54d7-78e9-bf9f-609b0b820a3c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c09d87c7-4a0e-032e-9ad8-762c25d95e30"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c109d306-355c-4fcb-03c7-95d8f9b06eb7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c14f67b5-496d-364f-3dcc-d80858b79049"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c14fe154-1673-55b1-3e2d-31a90670d117"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c19200b3-8303-d96e-62b0-7c5c516dd1b9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c23ec6de-f6d9-52b1-68d3-141356daabfb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c24f6460-229e-75c6-1634-f864b06bc186"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c295ea0f-c02d-3029-f1ff-0105a992eb1f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c2a3fadd-3b67-69d7-97c8-aa086cf9a75b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c2b9413b-0049-28aa-bdca-baaf963b70e7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c2ba6703-90f2-eb9c-1804-a7a1440e4fab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c2e01e20-8a1f-4f82-ca91-309062775801"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c2ee2ac0-5b40-df01-48a2-6da317b90dfa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c2f76fd6-95e5-9561-ded7-0e57b6a3aa6b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c307c65c-7769-f6cd-a865-3c7f95d2962b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c310ff80-281a-0773-38da-3cd4267fa542"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3186baf-5016-3ff0-be71-8410d4162f09"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3471848-28cf-4fbd-85fe-9efb29cd5511"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3796eac-90a4-f194-9b41-af74c4a03943"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3ce0dba-800a-d7ea-ff04-de03e2284ca5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3ce6354-6d11-55a5-9369-2860d45d3c0a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3d53bdf-c0f0-3e04-cb87-739d4a70835c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c3dc8938-daa2-aea1-8e46-4e53eed0dbc4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c40df16f-c107-3340-91f9-aa6ef42b687a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c422a9c0-61ec-0506-90c2-f17e97cbcb31"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c4259648-9a50-8049-fcab-911499a36d73"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c44e2c80-e2e4-7bc0-a8d3-d408159ab180"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c44f821b-332c-fb57-6736-96648a9061c3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c46765de-747e-640b-5a5f-6e8004e8dd57"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c49dff79-cff8-2dfc-030b-2ee6f17ece30"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c4b7d140-b877-c940-2305-2b4d3dd8292d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c5162e3a-05a1-1ddf-c5b3-13da5ebf848b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c527050f-7779-0ff4-c24c-758d788eda4b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c534eeb3-cf05-8353-5ddf-f8bb589c58de"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c5bd03b9-8930-563f-7688-cd69477dbcd5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c5fa7a16-d918-15c0-5c18-1c692fba6761"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c5fc6e6a-831e-269d-b667-bfd0c723f165"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c6926ad2-f1a7-3e5e-494f-163cc4b4b5be"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c69d4fe8-0d9d-524f-3b34-686a1e1d2d56"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c6c57809-6a66-094f-5e74-9d4ea415a77d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c6fc6b55-048c-fc0e-38a5-e1d4e0f60650"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c72ad459-a1ef-9c19-6d20-14bee74a851b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c767bf9e-ff1f-3505-5fa8-6adba6ad427a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c805794a-c3d6-2bda-c8b9-6a7602a864bc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c81f893e-a8be-ca4a-e02e-9eae304ed335"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c84fcf56-20e0-bf81-00e6-9a2e09f5d4d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c85022ee-3b6b-8832-bb8c-6ae7d5c9986c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c8ba8752-fcec-54f8-d806-af5f25f0f49d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c8d9f1a5-ea5e-73d7-9dd3-c53b1bd39486"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("c90d5954-baad-1b8c-ad1d-6767ac4f2c44"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ca11145b-70fe-203f-1913-05ef5db395d0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ca970e12-c3e9-5ae4-b3cd-c00234b1193e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("caf3061e-d88e-102a-007e-644349dcd289"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("caf7d008-feea-89ee-7f33-b484f543f757"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cbabe165-5f63-f8a1-fa09-309c8d283a0f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cbc9856d-e35a-bed4-6129-e6b9d573be17"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cbcc0cbc-6264-3629-dfd6-fc12110f97fc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cbda226a-5d9a-4af2-d8fb-1e9c511adbc6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cc4adb73-3c1a-c363-0dcf-bc777ce97d0f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cc701185-aaae-4992-58da-fc56df80d26e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ccbacf52-40a6-1e61-a53f-272e6272cc91"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cccadfef-b518-ba60-cb72-df67d1a06f75"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cce27c77-13a8-1712-6e3e-e666f29103ed"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cd5b6512-c95c-9de5-9a63-9d7ca07e6928"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cda32114-b51d-f209-0089-d9ece4536915"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cdc78980-2bdd-c68e-0166-0b6da4fbddb9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cdcbf933-c8cb-b031-3750-81a65b364d9e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cdd8948a-cdef-bedb-01c1-bdff789e3ef4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ce15c5c1-04ef-ff2d-b7a1-0941ec6889da"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ce92e606-aa75-5ac3-3931-22f74d7e01df"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ced3d3d9-3d76-1a8e-f609-bdf105ecbb66"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cf88b9c9-6ed1-f934-de4d-e2c7949e9985"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cfaf6b89-e6d8-b0d3-278f-5066688c64b3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("cfe4754c-1dc4-fc98-51b9-45078fb75854"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d0be4bf9-39ec-9a70-d785-9e26ffd49deb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d0d5650b-cc6f-e63a-3572-38497e7c6cf8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d12d394c-ac4d-0d29-0232-0d90dc4af00a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d13a72e6-8426-657a-88f2-e3655bd1e1aa"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d1f9cd89-ee0a-04e2-ce97-d640fec0dc2a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d217d544-544c-9627-ce0c-d3866626d6e6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d2286265-af57-41c6-2ac3-d051a8478767"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d23cc7d2-fc22-2c47-e447-6df9ebf123b0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d2810dc7-679a-2e8f-77ab-811e9600d02a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d29add55-88a5-3441-4067-dc24790e4d06"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d2e75b1c-48a7-d07b-6015-5cd861e5201b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d2e9fdda-f8b7-ba81-0096-1bd9f4d7a647"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d33dc856-fbc2-c69e-b3c4-ffd8c3fd6623"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d3444035-c0b5-311d-457a-e11a0ac5454c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d393ce12-dc02-6c92-5525-d67416f33a72"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d3aa3530-c159-998f-e62a-9e9e2dd611b5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d4701e90-0fae-7be5-4b17-402ed507348f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d487078c-3578-5de7-8fb5-d7398c362364"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d4beba1a-98c7-9076-0237-1d73ced9a6bd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d4c8d3c7-6135-537e-10f3-9c2b0bb4f2c2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d5109521-02b6-67ad-be36-dee81310ef5e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d5125fb8-a976-6d1e-18b9-d7a91bb2a819"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d5533ca1-a18b-c139-6a80-f9a47317df6e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d5ccde73-a45d-f100-aa2a-096f86c85fd5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d62a361b-00d2-9f5d-d278-c961f22e3cdf"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d6346c72-d87d-61a7-3383-dfdf8003c2ff"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d664e8a1-39c4-a7c6-102b-c9b67af4feb2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d692b0cf-8111-0bb8-ce14-9869a4624ad2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d7a672e5-7344-cd1d-1d15-66bb43931270"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d870459e-1a03-f06f-7c2f-829fa457aa4a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d87ae43e-659a-c040-1513-ebeb94614d61"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d8a4876b-a74c-288d-762e-692ac3786ee7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d8e587db-0be8-b65b-f0ae-cdf9316adaa8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d8fc81b2-bce8-5b1d-b320-8365f5cb5b4a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d93ae0f3-452c-dead-f2bb-90e6eea25ac9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d953ff04-865e-6d3b-de16-38c1847c1b54"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d9db2588-229b-c00a-16a0-1721a5cbaa54"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("d9ed46d2-9998-422c-8826-32a3d227fe19"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("da85ed9b-a422-574c-12bd-406dfdfbd448"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dac4718f-d195-ead3-6897-1989ca1b6beb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("db4df98a-5ba4-4ae1-69a1-559c2cfeb3ef"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("db975706-1abd-56f5-68ac-354fe81a92f3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dbfaa5c7-8928-17e8-8eb0-a16ec97619c7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dc09bf04-8bf0-4a8b-c23c-eadf40a8538c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dcdf2b8e-fc67-24e8-f292-5e88ea9bdd2f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dd29ac82-6bbb-b9f8-1d02-02289d234343"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dd3d04f7-011f-ef9a-2579-6d4d4a249403"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dd3fff49-ddb8-fe9d-99e5-0629ea76d2b2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dd7b0f9c-68ed-0a79-b7fb-0ee5367ae0ab"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ddc44139-133f-0863-3573-d7b80a4a190c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ddf4fa2f-1b2d-5ed2-2579-539bd68de023"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("de15f947-589f-ae85-38b5-d4d90a0c4f75"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("de1beb1d-08d5-37f2-c768-a6ac19227504"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("de2dd6b1-f1a8-cf2d-d585-ec5218e70123"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("de2de7bb-3ec5-2ea3-8694-a570faf2d796"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("de585240-7bf7-e3fe-c1db-3412d5c1539c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("de910881-4ae7-dd88-d5ff-b7bedf26813e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("decccbbe-e92b-7658-6f75-7012aaf49fb9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("df1f50a4-1194-226d-baf4-0cce3aed0a53"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("df32ffd0-6e3b-2db0-69c6-6fead68dbf8c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("df578318-39c9-67e1-43e1-cc9857c2bbff"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("dfd7c30f-83ba-d800-9c95-226eec17bbe1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e018d08e-c780-f08b-3d11-3e94dd1cf63e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e0b941dc-e6c9-8fa6-d2d2-348ad41ecc9f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e0c34088-a2f7-b93d-10be-679fc65426db"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e0dd2aa0-98a8-3dd6-3cd2-d43fd48e7d3c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e1038d7a-2ded-219e-27ff-e58a3bce209b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e17accf1-c9af-0cd3-cdd6-be4ddd4eec40"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e1812753-8428-3b7a-886d-ba5226d03381"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e1afc708-a631-19bb-64a0-b5445cdb7363"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e1be382e-6214-f0eb-56af-c87c4aa61acb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e2ed1e59-50da-1bd2-ed68-3ca507a9f090"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e3bb9072-3322-71d6-ffe0-a09be645a90b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e3bd90f0-fa17-d063-b474-7aa854d12377"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e3fade1c-9ddb-8c2c-bce9-b01230c112a6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e405234a-4bb8-13f8-09b8-d6bd7b62dac7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e43f88ac-ffbb-611d-7a78-2c9bdb50886d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e481e415-e305-9b3f-50b3-6a34ca346163"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e4ed2bdc-3e7b-99f6-b187-5cca2b96db84"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e50b6940-7e94-8bbb-abd4-28d2187b4f79"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e535aec3-8495-d8ac-3be0-faba39c63147"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e5997205-83f9-cc50-2dba-484f9687822b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e5fdbbb5-bf6d-7b5b-201a-272dd941122d"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e6284836-2c6b-fc6f-7683-0d51a4455e29"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e650836a-3440-bf03-7f83-7e2e6da23ac8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e655ea30-4ab4-146d-4f79-c13b7337f9f7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e6aebe02-88f2-6956-8a44-f4cf72e4856f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e6ea0853-7837-359a-3469-d0e6c83bfa35"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e6ec1888-d774-ab78-fb0b-510b66db2ff4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e734065c-f238-37d8-c7c7-37dcd3211f03"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e7477a1c-d750-c060-8b0f-b44d958630fd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e74a3c17-87ab-f620-c8ba-f8f50040f69f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e7957e8d-7279-0fc2-3ae3-17d5d8636470"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e7b15111-014c-b180-cb5f-92d40ef07559"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e7c68bf5-2a2b-8617-cc31-ee8a2a70bd2b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e860c0d9-1e88-41b6-1d35-bac5e51ab3bd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e87c0bc3-10a0-5ff5-b4f6-76b659fdd439"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e90f0297-d940-daca-b1fd-9c449963315c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e93e1048-0131-89d0-df85-fdba0a727a7e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("e979766c-19a4-c068-de88-3bc5e12db020"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ea0ffcb0-7a4d-5820-0394-c17125f0d635"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ea1cf46f-fd83-5981-0d4a-400814a6b678"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ea77061f-c9f5-7a15-30b2-9465baf3fbf7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ea7a33df-1d02-4d62-cfd9-3943b01e159f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ea996c5c-843d-936d-766d-e13ed82ac712"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("eaa2362d-502e-fe93-1131-18bf96013229"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("eab2dd63-6df9-6a6b-cd81-9d408b2543ca"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("eb5cabd3-9ff0-4ce8-fa4a-a5359672d9e1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("eb8f3381-c980-3892-2212-e8b6ec0a2c56"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("eba83bdc-0fa4-04d3-c889-00f82c7acfee"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ebbcfa75-a2ae-9b98-b4f4-731c92e489a9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ebc195ef-3b7a-d701-b25b-ab25c579834c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ebdd56fa-d974-96ff-58fe-491c8767bbcd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ec35e699-b21d-9aac-f9ce-dfaa338a5ef1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ec3e222f-485c-bbf4-a988-92029b8557cf"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ec588ebe-3258-4a11-1728-74b2fb40bf93"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ec9a92b0-ac26-6fd4-409e-3b9be3443098"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ec9f5db0-752a-0e24-01b1-7966ce67ad0a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ecef8332-76b7-12a7-774a-c0bfde1d5a3a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ee27a451-203a-f669-2797-5e203c81e4e1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ee3df0e0-d987-4e6c-eef3-bbfa8036f4f1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ee6420df-72e7-bb72-7e95-56df5da9a7ee"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ee9c098d-383c-3ca0-4125-20ee981f3bf7"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("eec7bea9-a77b-abbd-a25e-92f8fb69d152"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ef465e20-44b5-5a37-9586-bb7f12ef06c0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ef69fb99-c430-5d38-ef68-96eb4bf99dd1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ef863cfb-98a5-dabb-f519-55e467bbb567"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f02d7f2e-659c-2ded-c3de-73ba88a37db0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f04a2a1b-b296-7bf3-d163-b0b48b3964d5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f058e03c-970f-5c64-0aa8-48ecab1e1c8e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f06cf036-e85f-d5e6-6219-3b673b5361e9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f0cdea2a-7375-5bd9-9e77-44646db4e3c1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f15049da-66b4-6be7-d874-89816c82e6a6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f187de33-a024-f134-d238-038ac99dfe10"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f20d6dbd-d3e5-58cb-edb4-1599af0c5de3"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f246761c-43f1-51fe-0231-6605c806b67a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f29b302a-3b11-3de2-2bc6-1c4dc7187ba0"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f2ae15e0-3f8b-b012-bba1-08cea30900a4"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f3f2b95f-6fd4-4dd1-8304-bfbee3b0932a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f4116c9c-25e0-1afe-bf10-9e968492bd10"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f421eca4-ff2e-2e7b-ab07-1d9dbdc2522b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f4813ad6-a3f8-c65d-05de-c098aef59d08"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f4845e54-4831-1a1e-ecd5-61ebbb4b6bdc"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f48998f2-d7f7-3a27-1407-c86189076185"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f4a9d858-692f-bbdc-105f-993e106e7d55"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f5bf2c61-87b7-1a93-5325-ef8ddc2e3f03"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f5da2d12-823c-908f-8f36-36fbccff2d58"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f5e7900d-371e-7665-355a-74f8be756b8f"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f60364bf-c90e-9f33-3834-25acd098ef70"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f67257d3-7dfa-a7b4-e857-db928ea0ecf8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f6ca0c0e-9e7d-6892-b186-dfb1bf63e5d8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f720e954-142f-8f65-ebc9-f10bd32aff1c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f74c3c2b-e6b5-7ff7-c0c7-eb07823a0a68"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f751033c-230f-c676-ebec-8ea20f4eb22c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f764159f-4cea-4223-bab0-b25cd1eb83f2"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f7d2a351-2b37-fe07-4974-b35460fee0d1"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f865fd58-bc8a-ff51-81a2-eb9531026889"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f8ac0900-0049-456a-7278-254e547891f5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f8be7536-005b-e8ae-0f31-fd606d337ccd"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f8dfc6e7-e20f-ba9c-caa8-c56c14868138"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("f9837551-f677-4447-2bdb-28a4687cef7e"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fa26181c-3918-87db-23c0-5118a053f132"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fa6640e1-5fe6-48f0-7863-b61a42ea65f9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fa8e557d-8d2a-dfbd-245b-dd8837ea8d33"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("faa3df53-ce3d-6524-5949-db684a56b95a"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fab36099-f1ac-795e-6329-562962b539ca"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fb2e716c-58ff-98ad-805e-c292f6debfdb"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fba260c6-4724-e773-c1d2-833b0ccdea83"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fbd3ea89-1d84-eaaf-171b-204574cbed4c"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fbdb2107-ef44-2d15-aa90-e59b247c8501"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fc4b70aa-c92b-69d5-8503-dc10cc81aee8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fcf86a7b-47a9-d244-00ff-070f2734e1e5"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fd6828f8-14ee-14f1-94d8-831f270f7592"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fd8255c9-c30c-5675-eead-4926f0c151d6"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fe11f867-a3c6-46f6-f00d-65e8a52847c9"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fe1fbc3b-f7d7-caf9-2242-cc533c28a961"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fe250b86-c37d-091a-a708-2f02a270cc27"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fecb35a1-0bea-06f3-9362-1aff05a54708"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ff2fd3fb-03e9-7ce2-6cc5-0bf23b903314"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ff6c57bd-82aa-9184-5527-96a4780fc8e8"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ff8ad2d9-b854-33d5-2a3b-bcb0172b5484"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("ffdd2354-6b18-5f4d-0a81-ee3e78e8d45b"));

            migrationBuilder.DeleteData(
                table: "SellOrders",
                keyColumn: "SellOrderID",
                keyValue: new Guid("fff96342-8e9e-34d5-4976-1abc786f1c46"));

            migrationBuilder.RenameColumn(
                name: "StockSymbol",
                table: "SellOrders",
                newName: "StcokSymbol");
        }
    }
}
