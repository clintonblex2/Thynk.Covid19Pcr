using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Thynk.Covid19Pcr.Infrastructure.Migrations
{
    public partial class AddedReportStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestObject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<int>(type: "int", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    CancelledOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportEntity", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Jackie.Kuhic", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 80, 10L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Franklin_Gottlieb", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 100, 2L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Carlos.Reilly", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 94, 7L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Renee28", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 79, 9L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Pat_Leffler18", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 91, 3L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Shannon_Armstrong16", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 94, 10L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Kathryn90", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 96, 11L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Doreen.Wisoky", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 58, 3L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Joel.Lind1", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 98, 2L });

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 2, 17, 3, 54, 946, DateTimeKind.Local).AddTicks(7744), "Catherine_Gerhold62", new DateTime(2021, 12, 1, 17, 3, 54, 950, DateTimeKind.Local).AddTicks(8316), 81, 4L });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Patty.Stroman42", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1997, 1, 14, 0, 33, 59, 532, DateTimeKind.Local).AddTicks(9728), "Patty52@gmail.com", "Eda", "Schoen", "07018484438" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Grady.Turner30", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1987, 8, 15, 7, 12, 55, 824, DateTimeKind.Local).AddTicks(4425), "Grady9@gmail.com", "Damion", "Female", "Cummerata", "07002453515" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Florence_Reichel", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1983, 5, 18, 6, 32, 10, 930, DateTimeKind.Local).AddTicks(4909), "Florence84@gmail.com", "Reed", "Schaefer", "07082478059" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Gerald.Hammes", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1992, 2, 23, 5, 34, 59, 815, DateTimeKind.Local).AddTicks(2165), "Gerald_Hammes51@gmail.com", "Giovanna", "Male", "Rippin", "07004915374" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Melvin_Boyer", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1965, 9, 28, 14, 28, 36, 996, DateTimeKind.Local).AddTicks(6757), "Melvin.Boyer35@gmail.com", "Carolyne", "Female", "Hermann", "07077153720" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Henry.Davis", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1967, 4, 28, 13, 36, 2, 116, DateTimeKind.Local).AddTicks(4775), "Henry_Davis48@hotmail.com", "Giovanny", "Gorczany", "07010243314" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Franklin.Mayert", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1968, 12, 18, 1, 5, 17, 365, DateTimeKind.Local).AddTicks(7848), "Franklin48@gmail.com", "Loy", "Miller", "07035028822" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Lindsay_Abbott", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1955, 9, 17, 10, 57, 28, 967, DateTimeKind.Local).AddTicks(4999), "Lindsay43@hotmail.com", "Elenor", "Female", "Hilll", "07019772188" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Marsha95", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1972, 3, 23, 23, 25, 16, 279, DateTimeKind.Local).AddTicks(7839), "Marsha.Dach88@yahoo.com", "Adriel", "Male", "Schiller", "07043187494" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Gina.Wehner82", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1962, 12, 8, 13, 21, 59, 22, DateTimeKind.Local).AddTicks(9890), "Gina.Wehner81@yahoo.com", "Larue", "Male", "Haag", "07056991642" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Nicolas_Abshire92", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1994, 5, 20, 15, 11, 53, 713, DateTimeKind.Local).AddTicks(4422), "Nicolas19@yahoo.com", "Gerard", "Male", "Boehm", "07079279175" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Antonia57", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1966, 10, 19, 23, 39, 14, 414, DateTimeKind.Local).AddTicks(8948), "Antonia_Weber@hotmail.com", "Gerry", "Male", "King", "07076350756" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Diane.Cassin80", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1954, 8, 27, 6, 45, 12, 206, DateTimeKind.Local).AddTicks(3125), "Diane_Cassin92@hotmail.com", "Dawn", "Male", "Zemlak", "07047239045" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Neil27", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1951, 12, 31, 6, 2, 41, 958, DateTimeKind.Local).AddTicks(3519), "Neil_Kreiger@hotmail.com", "Vallie", "Wolff", "07093448968" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Megan_Weber35", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1981, 7, 23, 16, 38, 0, 247, DateTimeKind.Local).AddTicks(5227), "Megan.Weber50@yahoo.com", "Rosalind", "Cremin", "07012488978" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Luke_Purdy", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1972, 6, 21, 3, 16, 24, 247, DateTimeKind.Local).AddTicks(8241), "Luke.Purdy84@yahoo.com", "Jevon", "Female", "Ratke", "07076756250" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Sophia.Adams", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1987, 1, 13, 1, 48, 17, 878, DateTimeKind.Local).AddTicks(9143), "Sophia.Adams@yahoo.com", "Demetrius", "Lueilwitz", "07069840573" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Sammy.Berge50", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1962, 8, 29, 18, 28, 23, 331, DateTimeKind.Local).AddTicks(2195), "Sammy_Berge@hotmail.com", "Megane", "Will", "07075611389" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Gwen_Wintheiser20", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1956, 3, 12, 20, 8, 14, 830, DateTimeKind.Local).AddTicks(8608), "Gwen_Wintheiser@hotmail.com", "Florian", "Kessler", "07031557914" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Camille.OConnell24", new DateTime(2021, 12, 1, 17, 3, 55, 17, DateTimeKind.Local).AddTicks(135), new DateTime(1994, 8, 26, 14, 37, 23, 479, DateTimeKind.Local).AddTicks(6912), "Camille.OConnell15@gmail.com", "Jocelyn", "Male", "Hettinger", "07096557640" });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 4L, "GARUPPL8LP", "Nichole29", new DateTime(2021, 12, 1, 17, 3, 55, 42, DateTimeKind.Local).AddTicks(3026), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 7L, "ZNI7WM7875", "Rebecca13", new DateTime(2021, 12, 1, 17, 3, 55, 42, DateTimeKind.Local).AddTicks(3026), 2L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 5L, "0EPSJ3OISY", "Leo_Gorczany20", new DateTime(2021, 12, 1, 17, 3, 55, 42, DateTimeKind.Local).AddTicks(3026), 3L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 2L, "8LXF7SFIR2", "Beulah.Bartell", new DateTime(2021, 12, 1, 17, 3, 55, 42, DateTimeKind.Local).AddTicks(3026), 9L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 5L, "LT2LM4ZEHY", "Elvira_Schaefer", new DateTime(2021, 12, 1, 17, 3, 55, 42, DateTimeKind.Local).AddTicks(3026), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Mindy33", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Erick84", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Casey56", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Beatrice.Lowe57", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Tommie_Schaefer", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Mary.Hirthe71", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Jackie17", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Hilda.Heidenreich", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 2L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Olive.Rohan", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 1L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Blake57", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 3L });

            migrationBuilder.UpdateData(
                table: "TestLabs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Brandy.Bogan", new DateTime(2021, 12, 1, 17, 3, 55, 107, DateTimeKind.Local).AddTicks(35), 3L });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Margaret7", new DateTime(2021, 12, 1, 17, 3, 55, 115, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Wallace4", new DateTime(2021, 12, 1, 17, 3, 55, 115, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "TestLocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { "Roger13", new DateTime(2021, 12, 1, 17, 3, 55, 115, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Gina0", new DateTime(2021, 12, 1, 17, 3, 55, 123, DateTimeKind.Local).AddTicks(9426), "Accounts solid state Gorgeous Fresh Salad maximize Public-key matrix interfaces applications Organized Rial Omani Optional Delaware Avon functionalities Borders mission-critical Missouri Face to face Home Loan Account Route", true, 813 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsApproved", "TotalSupplied" },
                values: new object[] { "Michael_Reilly14", new DateTime(2021, 12, 1, 17, 3, 55, 123, DateTimeKind.Local).AddTicks(9426), "Music, Home & Tools Cambridgeshire Oklahoma Uganda TCP deposit hack Rubber Enhanced Markets plum online interface New Caledonia Credit Card Account Burundi Cordoba Oro deposit firmware withdrawal", true, 630 });

            migrationBuilder.UpdateData(
                table: "VaccineTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "TotalSupplied" },
                values: new object[] { "Andrew_Dare", new DateTime(2021, 12, 1, 17, 3, 55, 123, DateTimeKind.Local).AddTicks(9426), "implementation facilitate transmitter Lock withdrawal SSL Forward Industrial & Health Kuwait Assistant Generic interactive unleash Licensed whiteboard withdrawal Small deposit Liaison Configuration", 963 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportEntity");

            migrationBuilder.UpdateData(
                table: "AvailableTestDays",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Caroline75", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 55, 7L });

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
                columns: new[] { "AvailableDate", "CreatedBy", "CreatedOn", "OpenSlots", "TestLabId" },
                values: new object[] { new DateTime(2021, 12, 1, 21, 37, 30, 944, DateTimeKind.Local).AddTicks(4473), "Vicki9", new DateTime(2021, 11, 30, 21, 37, 30, 954, DateTimeKind.Local).AddTicks(6729), 92, 10L });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Shane.Bergstrom", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1965, 9, 8, 9, 22, 51, 458, DateTimeKind.Local).AddTicks(576), "Shane.Bergstrom89@gmail.com", "Sylvia", "Buckridge", "07077534069" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Stella48", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1970, 5, 19, 2, 21, 32, 52, DateTimeKind.Local).AddTicks(9521), "Stella_Schamberger35@yahoo.com", "Mabelle", "O'Reilly", "07056162897" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Ollie96", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1957, 3, 10, 17, 41, 38, 609, DateTimeKind.Local).AddTicks(600), "Ollie_Reynolds@hotmail.com", "Casimer", "Simonis", "07096978553" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Janie_Murphy", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1999, 7, 4, 11, 30, 1, 260, DateTimeKind.Local).AddTicks(243), "Janie61@hotmail.com", "Everette", "Windler", "07071477751" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Michael_Franecki", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1962, 8, 5, 6, 50, 17, 947, DateTimeKind.Local).AddTicks(5481), "Michael.Franecki@gmail.com", "Tomas", "Male", "Kunze", "07018591557" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Miriam_Strosin", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1981, 6, 23, 3, 40, 45, 598, DateTimeKind.Local).AddTicks(8775), "Miriam_Strosin@hotmail.com", "Dudley", "Female", "King", "07060659606" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Domingo_McCullough", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1997, 7, 4, 1, 9, 58, 626, DateTimeKind.Local).AddTicks(5029), "Domingo.McCullough@gmail.com", "Evert", "Female", "Kreiger", "07032905599" });

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
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Damon_MacGyver69", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1952, 7, 28, 0, 57, 44, 481, DateTimeKind.Local).AddTicks(4452), "Damon_MacGyver@yahoo.com", "Zackary", "Ortiz", "07090492598" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Brian65", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1985, 10, 19, 21, 15, 24, 420, DateTimeKind.Local).AddTicks(1716), "Brian34@hotmail.com", "Dorcas", "Collins", "07083426360" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Pablo63", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1988, 8, 31, 19, 43, 38, 277, DateTimeKind.Local).AddTicks(1184), "Pablo.Sanford69@gmail.com", "Vidal", "Male", "Weimann", "07063057183" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Julian37", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1984, 1, 21, 11, 37, 29, 702, DateTimeKind.Local).AddTicks(9652), "Julian.Johnston@hotmail.com", "Maude", "Homenick", "07095316645" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Elmer.Jones91", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1995, 9, 4, 6, 28, 7, 928, DateTimeKind.Local).AddTicks(1095), "Elmer.Jones@yahoo.com", "Jamir", "Cartwright", "07010361595" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Mamie.Bruen", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(2001, 10, 14, 13, 9, 22, 337, DateTimeKind.Local).AddTicks(4644), "Mamie.Bruen75@gmail.com", "Lucius", "O'Conner", "07035855513" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { "Robyn.Tillman21", new DateTime(2021, 11, 30, 21, 37, 31, 101, DateTimeKind.Local).AddTicks(1606), new DateTime(1956, 6, 26, 21, 22, 35, 595, DateTimeKind.Local).AddTicks(821), "Robyn_Tillman77@gmail.com", "Kaitlin", "Female", "Heaney", "07095178345" });

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
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 9L, "Y833IA8RA4", "Eloise_Jacobi62", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 5L });

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
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId" },
                values: new object[] { 6L, "2VQ9B1JWHC", "Shaun_Schneider40", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 8L });

            migrationBuilder.UpdateData(
                table: "TestBookings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailableTestDayId", "BookingReference", "CreatedBy", "CreatedOn", "PatientId", "VaccineTypeId" },
                values: new object[] { 9L, "I8YJEL47X0", "Della_Turcotte92", new DateTime(2021, 11, 30, 21, 37, 31, 158, DateTimeKind.Local).AddTicks(2738), 6L, 1L });

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
                columns: new[] { "CreatedBy", "CreatedOn", "TestLocationId" },
                values: new object[] { "Courtney_Beer", new DateTime(2021, 11, 30, 21, 37, 31, 417, DateTimeKind.Local).AddTicks(7926), 3L });

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
    }
}
