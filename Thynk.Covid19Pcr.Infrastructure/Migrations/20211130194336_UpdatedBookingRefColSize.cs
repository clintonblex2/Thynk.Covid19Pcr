using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Thynk.Covid19Pcr.Infrastructure.Migrations
{
    public partial class UpdatedBookingRefColSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "TestLocations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingStatus",
                table: "TestBookings",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Clifford_Bergstrom68", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 90, 5L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Darlene.Kuhlman", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 98, 8L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Sandy36", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 88, 2L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Amy.Ledner", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 68, 2L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Christopher40", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 80, 9L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Dennis_Littel", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 78, 6L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Christina_Jerde5", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 95, 3L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Toni.Flatley", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 76, 8L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Tanya.Mante", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 94 });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Marsha.Boyle58", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 56, 3L });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Mario49", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1983, 1, 21, 19, 6, 46, 240, DateTimeKind.Local).AddTicks(5162), "Mario_DuBuque96@yahoo.com", "Laurel", "Male", "Grant", "07021672209" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Damon.Nicolas91", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1964, 12, 8, 22, 45, 53, 930, DateTimeKind.Local).AddTicks(1323), "Damon_Nicolas@hotmail.com", "Frederik", "Male", "Jacobs", "07027604472" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Joel.Leuschke", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1962, 4, 20, 2, 2, 29, 145, DateTimeKind.Local).AddTicks(8326), "Joel.Leuschke@hotmail.com", "Rowan", "Female", "Steuber", "07069127229" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Stewart.Raynor", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1997, 11, 13, 0, 0, 48, 706, DateTimeKind.Local).AddTicks(4149), "Stewart88@gmail.com", "Willow", "Male", "Bashirian", "07065488423" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Teri.Koss", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1971, 6, 24, 20, 30, 0, 616, DateTimeKind.Local).AddTicks(2279), "Teri22@yahoo.com", "Nettie", "Hessel", "07017293072" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Omar24", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1971, 8, 25, 10, 41, 22, 244, DateTimeKind.Local).AddTicks(1850), "Omar_Zieme47@hotmail.com", "Makenzie", "Female", "Heathcote", "07050406475" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Allison_Romaguera", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1962, 2, 1, 4, 10, 54, 11, DateTimeKind.Local).AddTicks(653), "Allison_Romaguera@gmail.com", "Anthony", "Runte", "07087265285" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Brandy_Cronin10", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1977, 8, 26, 5, 32, 37, 535, DateTimeKind.Local).AddTicks(3602), "Brandy_Cronin@gmail.com", "Alessandro", "Female", "McGlynn", "07095457447" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Craig_Stamm", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1959, 11, 27, 16, 26, 17, 774, DateTimeKind.Local).AddTicks(142), "Craig.Stamm61@hotmail.com", "Francesco", "Female", "Jacobi", "07092015226" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Laverne41", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1954, 9, 11, 21, 29, 19, 202, DateTimeKind.Local).AddTicks(9772), "Laverne.Wiegand@gmail.com", "Dominique", "Langworth", "07001618960" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Damon.Oberbrunner", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1963, 10, 28, 5, 50, 49, 422, DateTimeKind.Local).AddTicks(301), "Damon.Oberbrunner@gmail.com", "Summer", "Female", "Collier", "07050199664" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Iris_Dooley", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1952, 11, 6, 8, 0, 19, 473, DateTimeKind.Local).AddTicks(3738), "Iris.Dooley20@yahoo.com", "Everardo", "Kunde", "07032817360" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Melvin_Beahan", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1980, 10, 9, 7, 52, 43, 223, DateTimeKind.Local).AddTicks(7615), "Melvin.Beahan@gmail.com", "Novella", "Male", "Moen", "07092176694" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Guadalupe.White99", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1952, 10, 3, 18, 31, 47, 996, DateTimeKind.Local).AddTicks(48), "Guadalupe.White29@hotmail.com", "Soledad", "Female", "Russel", "07075368833" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Alice_Daugherty9", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1996, 2, 19, 18, 0, 18, 591, DateTimeKind.Local).AddTicks(6754), "Alice.Daugherty@hotmail.com", "Victoria", "Becker", "07006591099" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Irene96", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1956, 7, 29, 14, 10, 54, 845, DateTimeKind.Local).AddTicks(328), "Irene.Kuhn81@gmail.com", "Milo", "Borer", "07081866084" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Susan_Sauer", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1957, 8, 6, 12, 1, 34, 826, DateTimeKind.Local).AddTicks(4063), "Susan79@yahoo.com", "Jovanny", "Female", "Beer", "07081619558" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Felicia_Green5", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(2001, 2, 1, 8, 18, 10, 986, DateTimeKind.Local).AddTicks(3662), "Felicia.Green@yahoo.com", "Maurice", "Hermiston", "07063968714" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Teresa.Cummings44", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1986, 5, 5, 16, 2, 19, 167, DateTimeKind.Local).AddTicks(971), "Teresa25@yahoo.com", "Walton", "Male", "Mante", "07090268023" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Sherman11", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1957, 2, 20, 22, 2, 18, 819, DateTimeKind.Local).AddTicks(8678), "Sherman18@yahoo.com", "Rachel", "Female", "Hilll", "07016646797" });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 5L, "NS5CRJZNE9", "Jerome_Turcotte", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 4L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 8L, "FX0LLST6HK", "Loretta_Shields", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 7L, "NG9JXUD5X6", "Irma_Pfannerstill", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { "I9WEXDJF8R", "Marco_Dicki92", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 3L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 6L, "OKW93C0VJ7", "Faye_Will31", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 4L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Vicki78", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Peggy85", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Travis_Stokes", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Jeanette36", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Traci.Kiehn94", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Jacob.Williamson44", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Renee56", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Stewart87", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Rudolph66", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Ramon_Spinka", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Terrance35", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 2L });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Shawn_Stokes37", new DateTime(2021, 11, 30, 20, 43, 34, 193, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Cornelius.Lueilwitz", new DateTime(2021, 11, 30, 20, 43, 34, 193, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Pauline95", new DateTime(2021, 11, 30, 20, 43, 34, 193, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Terence.Auer72", new DateTime(2021, 11, 30, 20, 43, 34, 262, DateTimeKind.Local).AddTicks(4670), "Sleek channels Checking Account Credit Card Account Handmade Steel Tuna Palladium Lock Incredible Cotton Gloves multi-byte backing up deposit CFA Franc BCEAO Investor invoice Vatu client-server Global morph repurpose Wooden", 1000 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Steve68", new DateTime(2021, 11, 30, 20, 43, 34, 262, DateTimeKind.Local).AddTicks(4670), "connect e-business Guyana Dollar Fantastic Rubber Keyboard SCSI Designer Concrete Exclusive Dynamic protocol XSS Ville optimize Interactions Auto Loan Account Portugal Front-line Nebraska Gorgeous Fresh Pizza analyzer", false, 912 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Marguerite_Treutel56", new DateTime(2021, 11, 30, 20, 43, 34, 262, DateTimeKind.Local).AddTicks(4670), "Camp Stravenue Investment Account Agent Czech Koruna Developer initiatives Small Wooden Shoes Investor throughput Unbranded multi-tasking San Marino Electronics & Home Intelligent Rubber Mouse transmitting Massachusetts Lakes Concrete Stravenue", 743 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "TestLocations",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingStatus",
                table: "TestBookings",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Gilbert_Jerde", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 77, 4L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Everett_Feeney", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 100, 7L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "David45", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 92, 5L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Marion.Cole60", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 72, 10L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Allison_Davis67", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 72, 7L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Andre.West32", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 68, 11L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Misty.Corwin57", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 66, 4L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Pearl.Wunsch", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 67, 10L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Sophia32", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 89 });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Kristopher_Frami", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), 95, 1L });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Henry.Fisher", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(2001, 1, 4, 16, 17, 56, 482, DateTimeKind.Local).AddTicks(8725), "Henry.Fisher@yahoo.com", "Dulce", "Female", "Klocko", "07009771037" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Daniel40", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1997, 4, 16, 14, 45, 36, 621, DateTimeKind.Local).AddTicks(2898), "Daniel97@gmail.com", "Wallace", "Female", "Haley", "07070090011" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Manuel.Emard", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1997, 2, 25, 6, 29, 29, 912, DateTimeKind.Local).AddTicks(2777), "Manuel_Emard55@hotmail.com", "Maximo", "Male", "Gutmann", "07084927225" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Jay_Cormier", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1955, 11, 26, 7, 42, 50, 84, DateTimeKind.Local).AddTicks(4896), "Jay.Cormier65@gmail.com", "Rhea", "Female", "Hodkiewicz", "07067074236" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Margaret.Collins80", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1984, 5, 11, 20, 49, 38, 557, DateTimeKind.Local).AddTicks(5476), "Margaret_Collins@hotmail.com", "Grady", "Wilkinson", "07059435826" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Tracy.Cole66", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1987, 2, 21, 16, 45, 31, 685, DateTimeKind.Local).AddTicks(3170), "Tracy.Cole@gmail.com", "Clara", "Male", "Cassin", "07027265594" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Isabel.Mraz", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1982, 12, 4, 11, 59, 44, 61, DateTimeKind.Local).AddTicks(1442), "Isabel59@gmail.com", "Finn", "Wunsch", "07063623449" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Trevor_Runolfsson", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1969, 10, 3, 19, 26, 40, 557, DateTimeKind.Local).AddTicks(9577), "Trevor32@gmail.com", "Tristian", "Male", "Auer", "07096501269" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Sheila_Moore29", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1994, 3, 6, 22, 55, 58, 228, DateTimeKind.Local).AddTicks(8607), "Sheila61@yahoo.com", "Samara", "Male", "White", "07074918893" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Elvira33", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1997, 4, 3, 6, 57, 44, 802, DateTimeKind.Local).AddTicks(3745), "Elvira.Grant@yahoo.com", "Mariam", "Miller", "07038115492" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Ebony.Beahan85", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(2000, 5, 23, 8, 59, 39, 740, DateTimeKind.Local).AddTicks(6929), "Ebony.Beahan@hotmail.com", "Caroline", "Male", "Dicki", "07098239305" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Malcolm48", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1965, 6, 14, 1, 31, 22, 142, DateTimeKind.Local).AddTicks(4736), "Malcolm11@hotmail.com", "Christopher", "Mayer", "07069758123" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Henrietta71", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1967, 10, 4, 0, 57, 1, 510, DateTimeKind.Local).AddTicks(3536), "Henrietta.OConner3@hotmail.com", "Maritza", "Female", "Block", "07096605242" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Martin.Weissnat", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1993, 9, 6, 13, 6, 29, 961, DateTimeKind.Local).AddTicks(484), "Martin.Weissnat72@yahoo.com", "Oceane", "Male", "Strosin", "07072690773" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Nora_Goyette", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(2001, 9, 1, 23, 43, 26, 698, DateTimeKind.Local).AddTicks(8859), "Nora15@yahoo.com", "Terry", "Bashirian", "07082513283" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Muriel76", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1955, 6, 30, 18, 40, 8, 476, DateTimeKind.Local).AddTicks(881), "Muriel.Leffler45@yahoo.com", "Alda", "Labadie", "07029281945" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Clark.Stehr35", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1976, 11, 16, 23, 32, 6, 586, DateTimeKind.Local).AddTicks(938), "Clark_Stehr57@yahoo.com", "Rosetta", "Male", "Satterfield", "07064914760" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Marion91", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1955, 9, 29, 14, 25, 47, 536, DateTimeKind.Local).AddTicks(8346), "Marion_Greenfelder@hotmail.com", "Emmalee", "Smith", "07086697214" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Myrtle.Purdy62", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1971, 9, 7, 6, 42, 53, 302, DateTimeKind.Local).AddTicks(3257), "Myrtle97@yahoo.com", "Dianna", "Female", "Cassin", "07065404457" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Mandy.Langosh50", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1953, 8, 21, 13, 31, 52, 563, DateTimeKind.Local).AddTicks(8829), "Mandy.Langosh@gmail.com", "Shany", "Male", "Runolfsson", "07049199534" });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 3L, "NWBIZMGOI5", "Tommie.Jast", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), 2L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 4L, "SGSZKHLF0W", "Dean.Berge17", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 2L, "F08156AENG", "Phil_Hagenes", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { "EWLSWVS3Q4", "Luz.Cormier", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), 6L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 9L, "CSUVAF43R0", "Sheldon75", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), 6L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Teri43", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Horace.Towne", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Beulah.Schaefer65", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Kara_Lubowitz52", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Alonzo.Stehr", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Jacquelyn_Littel0", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Charlie_Kuphal", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Jenny36", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Jordan84", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Leroy.Dicki91", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Joan.Walsh", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), 3L });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Laurence_Cormier", new DateTime(2021, 11, 30, 20, 16, 1, 944, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Eleanor96", new DateTime(2021, 11, 30, 20, 16, 1, 944, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Hugh4", new DateTime(2021, 11, 30, 20, 16, 1, 944, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Stephen94", new DateTime(2021, 11, 30, 20, 16, 1, 954, DateTimeKind.Local).AddTicks(1398), "Lane connecting District Intuitive morph Sleek Cotton Salad communities Liberia port Polarised blockchains Wisconsin Licensed Plastic Computer foreground Awesome parsing Awesome Frozen Tuna Bedfordshire Dynamic Associate", 691 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Michelle.Moore", new DateTime(2021, 11, 30, 20, 16, 1, 954, DateTimeKind.Local).AddTicks(1398), "Steel Industrial HDD Bedfordshire Buckinghamshire incubate invoice Brand Sports, Kids & Music Street maroon Highway methodical Practical Wooden Sausages 24 hour Awesome Concrete Gloves Jewelery, Tools & Health Circle wireless teal", true, 527 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Mildred35", new DateTime(2021, 11, 30, 20, 16, 1, 954, DateTimeKind.Local).AddTicks(1398), "Intelligent Frozen Salad bandwidth Concrete Music, Kids & Movies analyzing Concrete Team-oriented Realigned feed user-centric circuit Bedfordshire Fantastic Cotton Car Practical Home Money Market Account paradigm cutting-edge Chief array", 823 });
        }
    }
}
