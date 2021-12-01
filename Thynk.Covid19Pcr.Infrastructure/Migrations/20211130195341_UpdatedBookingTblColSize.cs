using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Thynk.Covid19Pcr.Infrastructure.Migrations
{
    public partial class UpdatedBookingTblColSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookingReference",
                table: "TestBookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Elaine19", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 55, 2L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Wilma.McClure15", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 4L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Guy70", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 52, 4L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Marianne5", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 90 });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Robin24", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 72, 11L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Lynn.Batz", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 79, 3L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Cathy58", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 85, 5L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Gretchen39", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 92, 5L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Shelley87", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 97, 5L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Kristopher_Wolff70", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 74, 6L });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Dwayne.Kirlin", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1964, 4, 14, 12, 52, 21, 493, DateTimeKind.Local).AddTicks(4543), "Dwayne_Kirlin@gmail.com", "German", "Wuckert", "07042951339" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Adrienne19", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1958, 4, 20, 8, 52, 22, 260, DateTimeKind.Local).AddTicks(9226), "Adrienne_Boyer@hotmail.com", "Brandy", "Female", "Robel", "07048492317" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Christopher95", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1974, 6, 7, 23, 36, 48, 747, DateTimeKind.Local).AddTicks(9276), "Christopher.Rath@gmail.com", "Kathleen", "Bergstrom", "07019993749" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Bridget.Goodwin46", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1986, 10, 23, 4, 33, 46, 466, DateTimeKind.Local).AddTicks(3610), "Bridget_Goodwin74@hotmail.com", "Dayne", "Kutch", "07067774125" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Joanne.Botsford", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1971, 12, 5, 5, 58, 44, 331, DateTimeKind.Local).AddTicks(4588), "Joanne.Botsford@hotmail.com", "Jefferey", "Lakin", "07004681381" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Leonard_Reynolds", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1967, 5, 1, 14, 12, 48, 190, DateTimeKind.Local).AddTicks(273), "Leonard70@gmail.com", "Ricky", "Wyman", "07033130782" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Johnathan_Aufderhar10", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1977, 7, 13, 8, 18, 45, 680, DateTimeKind.Local).AddTicks(1755), "Johnathan.Aufderhar96@yahoo.com", "Elisabeth", "Ruecker", "07050474687" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Rachael21", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1989, 7, 14, 23, 9, 31, 604, DateTimeKind.Local).AddTicks(1183), "Rachael.Wintheiser66@yahoo.com", "Darren", "Male", "Adams", "07041236737" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Samantha79", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1973, 8, 29, 2, 19, 34, 800, DateTimeKind.Local).AddTicks(652), "Samantha5@hotmail.com", "Fredy", "Male", "Howell", "07055652708" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Horace.Ortiz99", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1977, 12, 21, 4, 46, 56, 366, DateTimeKind.Local).AddTicks(3422), "Horace.Ortiz68@gmail.com", "Bethel", "Female", "Schamberger", "07077386138" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Troy_Labadie", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1959, 6, 8, 7, 34, 18, 300, DateTimeKind.Local).AddTicks(4240), "Troy_Labadie@gmail.com", "Lawson", "Rice", "07010630484" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Kelli5", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1989, 7, 28, 23, 52, 25, 483, DateTimeKind.Local).AddTicks(9196), "Kelli_Russel@hotmail.com", "Germaine", "Gusikowski", "07091241938" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Judith6", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1999, 7, 17, 21, 21, 16, 40, DateTimeKind.Local).AddTicks(1056), "Judith.Raynor73@yahoo.com", "Trycia", "King", "07095923369" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Preston.Heller", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1959, 9, 8, 5, 48, 22, 445, DateTimeKind.Local).AddTicks(2630), "Preston.Heller@hotmail.com", "Nathen", "Grant", "07077453508" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Bryan_VonRueden", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1951, 12, 3, 9, 12, 14, 300, DateTimeKind.Local).AddTicks(4355), "Bryan97@gmail.com", "Casey", "Male", "Windler", "07068496873" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Ethel.Considine", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1964, 8, 3, 19, 30, 17, 385, DateTimeKind.Local).AddTicks(9770), "Ethel_Considine@hotmail.com", "Monique", "Male", "Vandervort", "07067899280" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Belinda61", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1965, 6, 27, 13, 13, 30, 406, DateTimeKind.Local).AddTicks(6246), "Belinda.Brown60@hotmail.com", "Noelia", "Rosenbaum", "07084552173" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Karla71", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1965, 10, 4, 7, 24, 34, 329, DateTimeKind.Local).AddTicks(1854), "Karla.Ruecker@gmail.com", "Kamryn", "Female", "Wiegand", "07009197119" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Joanne70", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1991, 3, 17, 3, 56, 24, 753, DateTimeKind.Local).AddTicks(9366), "Joanne_Kuphal@yahoo.com", "Mollie", "Streich", "07009143101" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Wendy.Quigley93", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1956, 1, 2, 16, 41, 53, 437, DateTimeKind.Local).AddTicks(5509), "Wendy.Quigley29@gmail.com", "Jed", "Cremin", "07018008620" });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 9L, "MQIUE9G9VJ", "Gertrude0", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 9L, "PFNFGHZHJU", "Sophia_Langosh", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 6L, "DDGSC5GOWX", "Joy_Tromp", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 8L, "XCHULY35Y6", "Amber44", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 6L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 5L, "KIBNCZYHG0", "Ramon45", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 6L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Freddie.Kemmer73", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Melvin_Halvorson81", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Candace_Schulist94", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Bethany47", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Louis23", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Tommie.Dibbert14", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Barry.Hammes51", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Ida.Herman14", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Belinda.OHara25", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Janice_Leuschke38", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Eric.Moore14", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Seth.Hegmann77", new DateTime(2021, 11, 30, 20, 53, 38, 850, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Holly.Ward", new DateTime(2021, 11, 30, 20, 53, 38, 850, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Omar.Cronin71", new DateTime(2021, 11, 30, 20, 53, 38, 850, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Olive30", new DateTime(2021, 11, 30, 20, 53, 38, 910, DateTimeKind.Local).AddTicks(6817), "sensor copy Algerian Dinar open-source connecting quantify global IB Argentine Peso Personal Loan Account monitor Gorgeous Fresh Gloves parse Rubber benchmark Niue Auto Loan Account Turnpike circuit Inverse", true, 511 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Tomas_Wilkinson", new DateTime(2021, 11, 30, 20, 53, 38, 910, DateTimeKind.Local).AddTicks(6817), "Home Loan Account invoice redefine Stream Strategist leverage Isle Intranet scalable Handcrafted Incredible Grocery, Home & Industrial extranet Tools & Jewelery navigating Customer Security Tasty Cotton Checking Account", true, 502 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Violet24", new DateTime(2021, 11, 30, 20, 53, 38, 910, DateTimeKind.Local).AddTicks(6817), "matrix e-business facilitate Personal Loan Account value-added Customer Fantastic Fresh Salad sensor SMS Configuration dot-com high-level Gambia Fantastic Metal Pants Marketing invoice hack yellow infrastructures New Jersey", 805 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookingReference",
                table: "TestBookings",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Darlene.Kuhlman", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 8L });

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
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Amy.Ledner", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 68 });

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
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 43, 33, 693, DateTimeKind.Local).AddTicks(9709), "Tanya.Mante", new DateTime(2021, 11, 30, 20, 43, 33, 700, DateTimeKind.Local).AddTicks(189), 94, 1L });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Mario49", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1983, 1, 21, 19, 6, 46, 240, DateTimeKind.Local).AddTicks(5162), "Mario_DuBuque96@yahoo.com", "Laurel", "Grant", "07021672209" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Joel.Leuschke", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1962, 4, 20, 2, 2, 29, 145, DateTimeKind.Local).AddTicks(8326), "Joel.Leuschke@hotmail.com", "Rowan", "Steuber", "07069127229" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Stewart.Raynor", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1997, 11, 13, 0, 0, 48, 706, DateTimeKind.Local).AddTicks(4149), "Stewart88@gmail.com", "Willow", "Bashirian", "07065488423" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Omar24", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1971, 8, 25, 10, 41, 22, 244, DateTimeKind.Local).AddTicks(1850), "Omar_Zieme47@hotmail.com", "Makenzie", "Heathcote", "07050406475" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Laverne41", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1954, 9, 11, 21, 29, 19, 202, DateTimeKind.Local).AddTicks(9772), "Laverne.Wiegand@gmail.com", "Dominique", "Male", "Langworth", "07001618960" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Damon.Oberbrunner", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1963, 10, 28, 5, 50, 49, 422, DateTimeKind.Local).AddTicks(301), "Damon.Oberbrunner@gmail.com", "Summer", "Collier", "07050199664" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Melvin_Beahan", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1980, 10, 9, 7, 52, 43, 223, DateTimeKind.Local).AddTicks(7615), "Melvin.Beahan@gmail.com", "Novella", "Moen", "07092176694" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Guadalupe.White99", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1952, 10, 3, 18, 31, 47, 996, DateTimeKind.Local).AddTicks(48), "Guadalupe.White29@hotmail.com", "Soledad", "Russel", "07075368833" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Alice_Daugherty9", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1996, 2, 19, 18, 0, 18, 591, DateTimeKind.Local).AddTicks(6754), "Alice.Daugherty@hotmail.com", "Victoria", "Female", "Becker", "07006591099" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Irene96", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1956, 7, 29, 14, 10, 54, 845, DateTimeKind.Local).AddTicks(328), "Irene.Kuhn81@gmail.com", "Milo", "Female", "Borer", "07081866084" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Susan_Sauer", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1957, 8, 6, 12, 1, 34, 826, DateTimeKind.Local).AddTicks(4063), "Susan79@yahoo.com", "Jovanny", "Beer", "07081619558" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Felicia_Green5", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(2001, 2, 1, 8, 18, 10, 986, DateTimeKind.Local).AddTicks(3662), "Felicia.Green@yahoo.com", "Maurice", "Male", "Hermiston", "07063968714" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Teresa.Cummings44", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1986, 5, 5, 16, 2, 19, 167, DateTimeKind.Local).AddTicks(971), "Teresa25@yahoo.com", "Walton", "Mante", "07090268023" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Sherman11", new DateTime(2021, 11, 30, 20, 43, 33, 838, DateTimeKind.Local).AddTicks(2774), new DateTime(1957, 2, 20, 22, 2, 18, 819, DateTimeKind.Local).AddTicks(8678), "Sherman18@yahoo.com", "Rachel", "Hilll", "07016646797" });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 5L, "NS5CRJZNE9", "Jerome_Turcotte", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 4L, 2L });

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
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 9L, "I9WEXDJF8R", "Marco_Dicki92", new DateTime(2021, 11, 30, 20, 43, 33, 902, DateTimeKind.Local).AddTicks(8111), 3L });

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
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Travis_Stokes", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945) });

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
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Jacob.Williamson44", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Renee56", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Stewart87", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 2L });

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
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Ramon_Spinka", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Terrance35", new DateTime(2021, 11, 30, 20, 43, 34, 126, DateTimeKind.Local).AddTicks(2945) });

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
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Terence.Auer72", new DateTime(2021, 11, 30, 20, 43, 34, 262, DateTimeKind.Local).AddTicks(4670), "Sleek channels Checking Account Credit Card Account Handmade Steel Tuna Palladium Lock Incredible Cotton Gloves multi-byte backing up deposit CFA Franc BCEAO Investor invoice Vatu client-server Global morph repurpose Wooden", false, 1000 });

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
    }
}
