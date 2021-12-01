using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Thynk.Covid19Pcr.Infrastructure.Migrations
{
    public partial class AddedCovidTestResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestResult_ResultType",
                table: "TestBookings");

            migrationBuilder.DropColumn(
                name: "TestResult_TestResultDate",
                table: "TestBookings");

            migrationBuilder.CreateTable(
                name: "CovidTestResult",
                columns: table => new
                {
                    TestBookingsId = table.Column<long>(type: "bigint", nullable: false),
                    ResultType = table.Column<int>(type: "int", nullable: false),
                    TestResultDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidTestResult", x => x.TestBookingsId);
                    table.ForeignKey(
                        name: "FK_CovidTestResult_TestBookings_TestBookingsId",
                        column: x => x.TestBookingsId,
                        principalTable: "TestBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Caroline75", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 7L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Alfredo7", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 50, 10L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Robin46", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 82, 11L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Melinda_Klein98", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 66, 11L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Miriam17", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 80, 9L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Tiffany.Wolf75", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 82, 7L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Lamar36", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 67, 7L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Vicki9", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 10L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Lucia.Schuster", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 58, 8L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Gilbert.Watsica", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 63, 1L });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Shane.Bergstrom", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1965, 9, 8, 9, 22, 51, 458, DateTimeKind.Local).AddTicks(576), "Shane.Bergstrom89@gmail.com", "Sylvia", "Female", "Buckridge", "07077534069" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Todd_Kulas", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1953, 9, 3, 13, 54, 36, 12, DateTimeKind.Local).AddTicks(7252), "Todd.Kulas29@gmail.com", "Marilou", "Male", "Huels", "07059303463" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Stella48", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1970, 5, 19, 2, 21, 32, 52, DateTimeKind.Local).AddTicks(9521), "Stella_Schamberger35@yahoo.com", "Mabelle", "Male", "O'Reilly", "07056162897" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Hugh.Schiller", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(2000, 8, 5, 11, 49, 32, 894, DateTimeKind.Local).AddTicks(1393), "Hugh60@yahoo.com", "Everardo", "Female", "Klocko", "07052882712" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Sherri.Gutmann74", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1998, 7, 17, 2, 42, 40, 212, DateTimeKind.Local).AddTicks(315), "Sherri51@yahoo.com", "Malcolm", "Male", "Yundt", "07019509071" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Ollie96", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1957, 3, 10, 17, 41, 38, 609, DateTimeKind.Local).AddTicks(600), "Ollie_Reynolds@hotmail.com", "Casimer", "Male", "Simonis", "07096978553" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Janie_Murphy", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1999, 7, 4, 11, 30, 1, 260, DateTimeKind.Local).AddTicks(243), "Janie61@hotmail.com", "Everette", "Female", "Windler", "07071477751" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Michael_Franecki", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1962, 8, 5, 6, 50, 17, 947, DateTimeKind.Local).AddTicks(5481), "Michael.Franecki@gmail.com", "Tomas", "Kunze", "07018591557" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Lynn.Rodriguez", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1959, 1, 2, 0, 51, 1, 639, DateTimeKind.Local).AddTicks(9371), "Lynn32@hotmail.com", "Ahmad", "Female", "Rohan", "07048696900" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Miriam_Strosin", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1981, 6, 23, 3, 40, 45, 598, DateTimeKind.Local).AddTicks(8775), "Miriam_Strosin@hotmail.com", "Dudley", "King", "07060659606" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Domingo_McCullough", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1997, 7, 4, 1, 9, 58, 626, DateTimeKind.Local).AddTicks(5029), "Domingo.McCullough@gmail.com", "Evert", "Kreiger", "07032905599" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Harriet.Corwin", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1968, 6, 8, 8, 36, 4, 7, DateTimeKind.Local).AddTicks(1478), "Harriet28@hotmail.com", "Edythe", "Female", "Schneider", "07028878985" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Richard.Grady", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1991, 10, 27, 13, 3, 4, 319, DateTimeKind.Local).AddTicks(3751), "Richard_Grady1@hotmail.com", "Antone", "Female", "Jacobi", "07061965703" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Damon_MacGyver69", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1952, 7, 28, 0, 57, 44, 481, DateTimeKind.Local).AddTicks(4452), "Damon_MacGyver@yahoo.com", "Zackary", "Male", "Ortiz", "07090492598" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Brian65", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1985, 10, 19, 21, 15, 24, 420, DateTimeKind.Local).AddTicks(1716), "Brian34@hotmail.com", "Dorcas", "Female", "Collins", "07083426360" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Pablo63", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1988, 8, 31, 19, 43, 38, 277, DateTimeKind.Local).AddTicks(1184), "Pablo.Sanford69@gmail.com", "Vidal", "Weimann", "07063057183" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Julian37", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1984, 1, 21, 11, 37, 29, 702, DateTimeKind.Local).AddTicks(9652), "Julian.Johnston@hotmail.com", "Maude", "Male", "Homenick", "07095316645" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Elmer.Jones91", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1995, 9, 4, 6, 28, 7, 928, DateTimeKind.Local).AddTicks(1095), "Elmer.Jones@yahoo.com", "Jamir", "Male", "Cartwright", "07010361595" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Mamie.Bruen", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(2001, 10, 14, 13, 9, 22, 337, DateTimeKind.Local).AddTicks(4644), "Mamie.Bruen75@gmail.com", "Lucius", "Female", "O'Conner", "07035855513" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Robyn.Tillman21", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1956, 6, 26, 21, 22, 35, 595, DateTimeKind.Local).AddTicks(821), "Robyn_Tillman77@gmail.com", "Kaitlin", "Heaney", "07095178345" });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 7L, "7HU1EFFV0H", "Joan_Littel", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { "Y833IA8RA4", "Eloise_Jacobi62", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 5L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 10L, "H2YB8Z116G", "Kathy_Gorczany91", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 7L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 6L, "2VQ9B1JWHC", "Shaun_Schneider40", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn" },
                values: new object[] { 9L, "I8YJEL47X0", "Della_Turcotte92", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Paul_Willms5", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Glen37", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Anna_Weber", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Courtney_Beer", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Marguerite.Sauer88", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Horace.Greenholt19", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Krista47", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Barbara.Thiel95", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Eileen_Wiza99", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Jessie.Bogan80", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Meredith.Shanahan", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 1L });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Angel_Nitzsche", new DateTime(2021, 11, 30, 21, 37, 31, 454, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Kendra_Goyette88", new DateTime(2021, 11, 30, 21, 37, 31, 454, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Katherine.Johnston33", new DateTime(2021, 11, 30, 21, 37, 31, 454, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Willis98", new DateTime(2021, 11, 30, 21, 37, 31, 480, DateTimeKind.Local).AddTicks(6899), "Forest hack navigating payment Facilitator virtual hard drive cross-platform policy Games & Baby Roads Avon Manager internet solution Solutions adapter Checking Account Savings Account California neural", false, 873 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Rochelle34", new DateTime(2021, 11, 30, 21, 37, 31, 480, DateTimeKind.Local).AddTicks(6899), "Phased capacitor methodical Granite secured line interfaces Money Market Account Innovative Rubber empower Summit platforms didactic quantifying Berkshire compressing architect yellow payment context-sensitive", false, 564 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Mack.Mante64", new DateTime(2021, 11, 30, 21, 37, 31, 480, DateTimeKind.Local).AddTicks(6899), "reboot input fuchsia turn-key Baby metrics coherent payment Handcrafted synthesize complexity Trail matrix parse Internal parse Circles Electronics Generic deposit", 549 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidTestResult");

            migrationBuilder.AddColumn<int>(
                name: "TestResult_ResultType",
                table: "TestBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TestResult_TestResultDate",
                table: "TestBookings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Elaine19", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 2L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Wilma.McClure15", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 98, 4L });

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
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Marianne5", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 90, 2L });

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
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 53, 38, 192, DateTimeKind.Local).AddTicks(4409), "Gretchen39", new DateTime(2021, 11, 30, 20, 53, 38, 208, DateTimeKind.Local).AddTicks(5668), 5L });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Dwayne.Kirlin", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1964, 4, 14, 12, 52, 21, 493, DateTimeKind.Local).AddTicks(4543), "Dwayne_Kirlin@gmail.com", "German", "Male", "Wuckert", "07042951339" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Christopher95", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1974, 6, 7, 23, 36, 48, 747, DateTimeKind.Local).AddTicks(9276), "Christopher.Rath@gmail.com", "Kathleen", "Female", "Bergstrom", "07019993749" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Bridget.Goodwin46", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1986, 10, 23, 4, 33, 46, 466, DateTimeKind.Local).AddTicks(3610), "Bridget_Goodwin74@hotmail.com", "Dayne", "Male", "Kutch", "07067774125" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Joanne.Botsford", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1971, 12, 5, 5, 58, 44, 331, DateTimeKind.Local).AddTicks(4588), "Joanne.Botsford@hotmail.com", "Jefferey", "Female", "Lakin", "07004681381" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Leonard_Reynolds", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1967, 5, 1, 14, 12, 48, 190, DateTimeKind.Local).AddTicks(273), "Leonard70@gmail.com", "Ricky", "Female", "Wyman", "07033130782" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Johnathan_Aufderhar10", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1977, 7, 13, 8, 18, 45, 680, DateTimeKind.Local).AddTicks(1755), "Johnathan.Aufderhar96@yahoo.com", "Elisabeth", "Male", "Ruecker", "07050474687" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Rachael21", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1989, 7, 14, 23, 9, 31, 604, DateTimeKind.Local).AddTicks(1183), "Rachael.Wintheiser66@yahoo.com", "Darren", "Adams", "07041236737" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Horace.Ortiz99", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1977, 12, 21, 4, 46, 56, 366, DateTimeKind.Local).AddTicks(3422), "Horace.Ortiz68@gmail.com", "Bethel", "Schamberger", "07077386138" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Kelli5", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1989, 7, 28, 23, 52, 25, 483, DateTimeKind.Local).AddTicks(9196), "Kelli_Russel@hotmail.com", "Germaine", "Male", "Gusikowski", "07091241938" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Judith6", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1999, 7, 17, 21, 21, 16, 40, DateTimeKind.Local).AddTicks(1056), "Judith.Raynor73@yahoo.com", "Trycia", "Male", "King", "07095923369" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Preston.Heller", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1959, 9, 8, 5, 48, 22, 445, DateTimeKind.Local).AddTicks(2630), "Preston.Heller@hotmail.com", "Nathen", "Female", "Grant", "07077453508" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Ethel.Considine", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1964, 8, 3, 19, 30, 17, 385, DateTimeKind.Local).AddTicks(9770), "Ethel_Considine@hotmail.com", "Monique", "Vandervort", "07067899280" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Belinda61", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1965, 6, 27, 13, 13, 30, 406, DateTimeKind.Local).AddTicks(6246), "Belinda.Brown60@hotmail.com", "Noelia", "Female", "Rosenbaum", "07084552173" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Joanne70", new DateTime(2021, 11, 30, 20, 53, 38, 431, DateTimeKind.Local).AddTicks(6349), new DateTime(1991, 3, 17, 3, 56, 24, 753, DateTimeKind.Local).AddTicks(9366), "Joanne_Kuphal@yahoo.com", "Mollie", "Male", "Streich", "07009143101" });

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
                columns: new[] { "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { "PFNFGHZHJU", "Sophia_Langosh", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 7L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 6L, "DDGSC5GOWX", "Joy_Tromp", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 6L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 8L, "XCHULY35Y6", "Amber44", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn" },
                values: new object[] { 5L, "KIBNCZYHG0", "Ramon45", new DateTime(2021, 11, 30, 20, 53, 38, 531, DateTimeKind.Local).AddTicks(6109) });

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
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Candace_Schulist94", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Bethany47", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723) });

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
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Eric.Moore14", new DateTime(2021, 11, 30, 20, 53, 38, 803, DateTimeKind.Local).AddTicks(9723), 2L });

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
    }
}
