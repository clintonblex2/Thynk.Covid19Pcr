using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Thynk.Covid19Pcr.Infrastructure.Migrations
{
    public partial class AddedInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestLocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IsOperational = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestLabs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TestLocationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestLabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestLabs_TestLocations_TestLocationId",
                        column: x => x.TestLocationId,
                        principalTable: "TestLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailableTestDays",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenSlots = table.Column<int>(type: "int", nullable: false),
                    AvailableDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestLabId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableTestDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableTestDays_TestLabs_TestLabId",
                        column: x => x.TestLabId,
                        principalTable: "TestLabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccineTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    RecommendedAge = table.Column<int>(type: "int", nullable: false),
                    TotalSupplied = table.Column<int>(type: "int", nullable: false),
                    TestLabsId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccineTypes_TestLabs_TestLabsId",
                        column: x => x.TestLabsId,
                        principalTable: "TestLabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestBookings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingReference = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VaccineTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    AvailableTestDayId = table.Column<long>(type: "bigint", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TestResult_ResultType = table.Column<int>(type: "int", nullable: true),
                    TestResult_TestResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestBookings_AvailableTestDays_AvailableTestDayId",
                        column: x => x.AvailableTestDayId,
                        principalTable: "AvailableTestDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestBookings_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestBookings_VaccineTypes_VaccineTypeId",
                        column: x => x.VaccineTypeId,
                        principalTable: "VaccineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Age", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "LastModifiedBy", "LastModifiedOn", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1L, 0, "Henry.Fisher", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(2001, 1, 4, 16, 17, 56, 482, DateTimeKind.Local).AddTicks(8725), "Henry.Fisher@yahoo.com", "Dulce", "Female", null, null, "Klocko", "07009771037" },
                    { 20L, 0, "Mandy.Langosh50", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1953, 8, 21, 13, 31, 52, 563, DateTimeKind.Local).AddTicks(8829), "Mandy.Langosh@gmail.com", "Shany", "Male", null, null, "Runolfsson", "07049199534" },
                    { 19L, 0, "Myrtle.Purdy62", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1971, 9, 7, 6, 42, 53, 302, DateTimeKind.Local).AddTicks(3257), "Myrtle97@yahoo.com", "Dianna", "Female", null, null, "Cassin", "07065404457" },
                    { 18L, 0, "Marion91", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1955, 9, 29, 14, 25, 47, 536, DateTimeKind.Local).AddTicks(8346), "Marion_Greenfelder@hotmail.com", "Emmalee", "Male", null, null, "Smith", "07086697214" },
                    { 17L, 0, "Clark.Stehr35", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1976, 11, 16, 23, 32, 6, 586, DateTimeKind.Local).AddTicks(938), "Clark_Stehr57@yahoo.com", "Rosetta", "Male", null, null, "Satterfield", "07064914760" },
                    { 16L, 0, "Muriel76", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1955, 6, 30, 18, 40, 8, 476, DateTimeKind.Local).AddTicks(881), "Muriel.Leffler45@yahoo.com", "Alda", "Female", null, null, "Labadie", "07029281945" },
                    { 15L, 0, "Nora_Goyette", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(2001, 9, 1, 23, 43, 26, 698, DateTimeKind.Local).AddTicks(8859), "Nora15@yahoo.com", "Terry", "Female", null, null, "Bashirian", "07082513283" },
                    { 14L, 0, "Martin.Weissnat", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1993, 9, 6, 13, 6, 29, 961, DateTimeKind.Local).AddTicks(484), "Martin.Weissnat72@yahoo.com", "Oceane", "Male", null, null, "Strosin", "07072690773" },
                    { 12L, 0, "Malcolm48", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1965, 6, 14, 1, 31, 22, 142, DateTimeKind.Local).AddTicks(4736), "Malcolm11@hotmail.com", "Christopher", "Male", null, null, "Mayer", "07069758123" },
                    { 11L, 0, "Ebony.Beahan85", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(2000, 5, 23, 8, 59, 39, 740, DateTimeKind.Local).AddTicks(6929), "Ebony.Beahan@hotmail.com", "Caroline", "Male", null, null, "Dicki", "07098239305" },
                    { 13L, 0, "Henrietta71", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1967, 10, 4, 0, 57, 1, 510, DateTimeKind.Local).AddTicks(3536), "Henrietta.OConner3@hotmail.com", "Maritza", "Female", null, null, "Block", "07096605242" },
                    { 9L, 0, "Sheila_Moore29", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1994, 3, 6, 22, 55, 58, 228, DateTimeKind.Local).AddTicks(8607), "Sheila61@yahoo.com", "Samara", "Male", null, null, "White", "07074918893" },
                    { 8L, 0, "Trevor_Runolfsson", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1969, 10, 3, 19, 26, 40, 557, DateTimeKind.Local).AddTicks(9577), "Trevor32@gmail.com", "Tristian", "Male", null, null, "Auer", "07096501269" },
                    { 7L, 0, "Isabel.Mraz", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1982, 12, 4, 11, 59, 44, 61, DateTimeKind.Local).AddTicks(1442), "Isabel59@gmail.com", "Finn", "Male", null, null, "Wunsch", "07063623449" },
                    { 6L, 0, "Tracy.Cole66", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1987, 2, 21, 16, 45, 31, 685, DateTimeKind.Local).AddTicks(3170), "Tracy.Cole@gmail.com", "Clara", "Male", null, null, "Cassin", "07027265594" },
                    { 5L, 0, "Margaret.Collins80", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1984, 5, 11, 20, 49, 38, 557, DateTimeKind.Local).AddTicks(5476), "Margaret_Collins@hotmail.com", "Grady", "Female", null, null, "Wilkinson", "07059435826" },
                    { 4L, 0, "Jay_Cormier", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1955, 11, 26, 7, 42, 50, 84, DateTimeKind.Local).AddTicks(4896), "Jay.Cormier65@gmail.com", "Rhea", "Female", null, null, "Hodkiewicz", "07067074236" },
                    { 3L, 0, "Manuel.Emard", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1997, 2, 25, 6, 29, 29, 912, DateTimeKind.Local).AddTicks(2777), "Manuel_Emard55@hotmail.com", "Maximo", "Male", null, null, "Gutmann", "07084927225" },
                    { 2L, 0, "Daniel40", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1997, 4, 16, 14, 45, 36, 621, DateTimeKind.Local).AddTicks(2898), "Daniel97@gmail.com", "Wallace", "Female", null, null, "Haley", "07070090011" },
                    { 10L, 0, "Elvira33", new DateTime(2021, 11, 30, 20, 16, 1, 834, DateTimeKind.Local).AddTicks(9461), new DateTime(1997, 4, 3, 6, 57, 44, 802, DateTimeKind.Local).AddTicks(3745), "Elvira.Grant@yahoo.com", "Mariam", "Male", null, null, "Miller", "07038115492" }
                });

            migrationBuilder.InsertData(
                table: "TestLocations",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "IsOperational", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { 1L, "Abuja", "Nigeria", "Laurence_Cormier", new DateTime(2021, 11, 30, 20, 16, 1, 944, DateTimeKind.Local).AddTicks(4478), true, null, null },
                    { 2L, "Lagos", "Nigeria", "Eleanor96", new DateTime(2021, 11, 30, 20, 16, 1, 944, DateTimeKind.Local).AddTicks(4478), true, null, null },
                    { 3L, "Port-harcourt", "Nigeria", "Hugh4", new DateTime(2021, 11, 30, 20, 16, 1, 944, DateTimeKind.Local).AddTicks(4478), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "VaccineTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsApproved", "LastModifiedBy", "LastModifiedOn", "Manufacturer", "Name", "RecommendedAge", "TestLabsId", "TotalSupplied" },
                values: new object[,]
                {
                    { 2L, "Michelle.Moore", new DateTime(2021, 11, 30, 20, 16, 1, 954, DateTimeKind.Local).AddTicks(1398), "Steel Industrial HDD Bedfordshire Buckinghamshire incubate invoice Brand Sports, Kids & Music Street maroon Highway methodical Practical Wooden Sausages 24 hour Awesome Concrete Gloves Jewelery, Tools & Health Circle wireless teal", true, null, null, null, "Moderna", 18, null, 527 },
                    { 1L, "Stephen94", new DateTime(2021, 11, 30, 20, 16, 1, 954, DateTimeKind.Local).AddTicks(1398), "Lane connecting District Intuitive morph Sleek Cotton Salad communities Liberia port Polarised blockchains Wisconsin Licensed Plastic Computer foreground Awesome parsing Awesome Frozen Tuna Bedfordshire Dynamic Associate", false, null, null, null, "Pfizer-BioNTech", 5, null, 691 },
                    { 3L, "Mildred35", new DateTime(2021, 11, 30, 20, 16, 1, 954, DateTimeKind.Local).AddTicks(1398), "Intelligent Frozen Salad bandwidth Concrete Music, Kids & Movies analyzing Concrete Team-oriented Realigned feed user-centric circuit Bedfordshire Fantastic Cotton Car Practical Home Money Market Account paradigm cutting-edge Chief array", false, null, null, null, "Johnson & Johnson’s", 18, null, 823 }
                });

            migrationBuilder.InsertData(
                table: "TestLabs",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "LabName", "LastModifiedBy", "LastModifiedOn", "TestLocationId" },
                values: new object[,]
                {
                    { 1L, "Teri43", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Medbury Services Limited", null, null, 1L },
                    { 2L, "Horace.Towne", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Sahel Lab", null, null, 1L },
                    { 5L, "Alonzo.Stehr", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "A-Medik Molecular Laboratory", null, null, 1L },
                    { 9L, "Jordan84", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Clinix Healthcare", null, null, 1L },
                    { 8L, "Jenny36", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Biologix Support Services", null, null, 2L },
                    { 10L, "Leroy.Dicki91", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Reddington Zainelab", null, null, 2L },
                    { 3L, "Beulah.Schaefer65", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Epiconsult clinic and Diagnostics Center", null, null, 3L },
                    { 4L, "Kara_Lubowitz52", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Centolab", null, null, 3L },
                    { 6L, "Jacquelyn_Littel0", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Cedarcrest Hospital Molecular Laboratory", null, null, 3L },
                    { 7L, "Charlie_Kuphal", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Clina Lancet", null, null, 3L },
                    { 11L, "Joan.Walsh", new DateTime(2021, 11, 30, 20, 16, 1, 933, DateTimeKind.Local).AddTicks(1679), true, "Medbury Services Limited", null, null, 3L }
                });

            migrationBuilder.InsertData(
                table: "AvailableTestDays",
                columns: new[] { "Id", "AvailableDate", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "OpenSlots", "TestLabId" },
                values: new object[,]
                {
                    { 10L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Sophia32", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 89, 1L },
                    { 11L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Kristopher_Frami", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 95, 1L },
                    { 4L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "David45", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 92, 5L },
                    { 5L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Marion.Cole60", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 72, 10L },
                    { 9L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Pearl.Wunsch", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 67, 10L },
                    { 2L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Gilbert_Jerde", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 77, 4L },
                    { 8L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Misty.Corwin57", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 66, 4L },
                    { 3L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Everett_Feeney", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 100, 7L },
                    { 6L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Allison_Davis67", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 72, 7L },
                    { 7L, new DateTime(2021, 12, 1, 20, 16, 1, 750, DateTimeKind.Local).AddTicks(7859), "Andre.West32", new DateTime(2021, 11, 30, 20, 16, 1, 756, DateTimeKind.Local).AddTicks(7838), null, null, 68, 11L }
                });

            migrationBuilder.InsertData(
                table: "TestBookings",
                columns: new[] { "Id", "AvailableTestDayId", "BookingReference", "BookingStatus", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "PatientId", "VaccineTypeId" },
                values: new object[,]
                {
                    { 2L, 4L, "SGSZKHLF0W", "Booked", "Dean.Berge17", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), null, null, 2L, 1L },
                    { 4L, 9L, "EWLSWVS3Q4", "Booked", "Luz.Cormier", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), null, null, 6L, 2L },
                    { 5L, 9L, "CSUVAF43R0", "Booked", "Sheldon75", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), null, null, 6L, 1L },
                    { 3L, 2L, "F08156AENG", "Booked", "Phil_Hagenes", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), null, null, 4L, 3L },
                    { 1L, 3L, "NWBIZMGOI5", "Booked", "Tommie.Jast", new DateTime(2021, 11, 30, 20, 16, 1, 859, DateTimeKind.Local).AddTicks(5441), null, null, 2L, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableTestDays_TestLabId",
                table: "AvailableTestDays",
                column: "TestLabId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PhoneNumber_Email",
                table: "Patient",
                columns: new[] { "PhoneNumber", "Email" });

            migrationBuilder.CreateIndex(
                name: "IX_TestBookings_AvailableTestDayId",
                table: "TestBookings",
                column: "AvailableTestDayId");

            migrationBuilder.CreateIndex(
                name: "IX_TestBookings_BookingReference",
                table: "TestBookings",
                column: "BookingReference");

            migrationBuilder.CreateIndex(
                name: "IX_TestBookings_PatientId",
                table: "TestBookings",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TestBookings_VaccineTypeId",
                table: "TestBookings",
                column: "VaccineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TestLabs_LabName",
                table: "TestLabs",
                column: "LabName");

            migrationBuilder.CreateIndex(
                name: "IX_TestLabs_TestLocationId",
                table: "TestLabs",
                column: "TestLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TestLocations_City",
                table: "TestLocations",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineTypes_Name",
                table: "VaccineTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineTypes_TestLabsId",
                table: "VaccineTypes",
                column: "TestLabsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestBookings");

            migrationBuilder.DropTable(
                name: "AvailableTestDays");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "VaccineTypes");

            migrationBuilder.DropTable(
                name: "TestLabs");

            migrationBuilder.DropTable(
                name: "TestLocations");
        }
    }
}
