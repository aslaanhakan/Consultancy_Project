using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consultancy_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Promotion = table.Column<string>(type: "TEXT", nullable: false),
                    VisitsPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Institution = table.Column<string>(type: "TEXT", nullable: true),
                    CertificateName = table.Column<string>(type: "TEXT", nullable: false),
                    CertificateTime = table.Column<int>(type: "INTEGER", nullable: false),
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultantsSpecializations",
                columns: table => new
                {
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpecializationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantsSpecializations", x => new { x.ConsultantId, x.SpecializationId });
                    table.ForeignKey(
                        name: "FK_ConsultantsSpecializations_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultantsSpecializations_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SchoolName = table.Column<string>(type: "TEXT", nullable: false),
                    FacultyName = table.Column<string>(type: "TEXT", nullable: false),
                    DepartmentName = table.Column<string>(type: "TEXT", nullable: false),
                    DegreeofGraduation = table.Column<string>(type: "TEXT", nullable: false),
                    StartYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    GraduationYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersConsultans",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersConsultans", x => new { x.ConsultantId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_CustomersConsultans_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersConsultans_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", null, "Danışanman", "Consultant", "CONSULTANT" },
                    { "81a7cd0d-1a10-4bb8-8c56-ec882cb21fab", null, "Yönetici", "Admin", "ADMIN" },
                    { "c374ca7c-eee2-4c14-a95a-512150581312", null, "Kullanıcı", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "05b3d752-0546-4c73-80ea-db8b76a1d2b3", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "7e52c22b-f3b7-4af0-a878-7c1f941b1171", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3075), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEDqp8V3lrilPRW0xWL8Go68BKfzURFEUOTcb+czxEUv8fmLr6Bcq/oVjs/BvPKrGqQ==", null, false, "d1fcbbcd-0933-4531-a954-197505917101", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3087), "admin" },
                    { "1f4adf05-e534-4187-855b-d6d3e46d3c21", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "be910080-8880-45af-b774-af6eddca102e", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3244), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEJQHOtS6mmCDdMzyvMB6/SOLSSroIYuvsdzc10Bd6F0ySVFw3IDDUL2QOs8ZFiCwfA==", null, false, "0eb57fb3-217f-48b5-acb1-275431ae11dc", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3244), "aliyildirim" },
                    { "2201d025-5b76-464d-aae3-edfe7aa48834", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "85aa2979-d38e-416f-9f8f-f394a9746ca2", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3134), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAEHQcTOOhhTbu5PcO1Qo0sJWkyhbcZaWimzhbSMx52+05s/tKeYB1OXlKuuKZEiXX2g==", null, false, "9b284261-75f2-4bf5-9344-fa7fe011b3fa", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3136), "ayseyilmaz" },
                    { "2cb2f7e6-e238-4695-b794-faf3433291f3", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "299928f1-c00e-4500-b651-8d7ca939ff0c", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3149), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEDyIBMrDAX6v0HUK6C9poVJzCCfDPKk5xr4n0Xv5cdCdQSalketFiWuNdInElR4Ceg==", null, false, "f85be3fc-f447-4bd8-b813-b83373b87224", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3150), "mehmetozkan" },
                    { "2da82f70-29cf-4f0f-9ea1-56f94c0278fc", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "9025603d-5729-4973-9b2b-3d681acca891", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3231), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEJ81VriggG7uKn6Y70QKOzxqsupQsOENFJRi8s1/B5h4bvkECbl/7G/aohiNx2IIIA==", null, false, "b4f2a540-7e5f-4d90-a138-5938b2ed68ae", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3231), "deniz" },
                    { "47de91d5-5a68-420a-8492-5118b25b4d03", 0, "Turan Cd. No:7 Bornova", "İzmir", "24aeec22-4f8d-4e24-bae1-3b49cac7072a", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3217), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAENVydPgip5cPyWo9c1jPRv3QjeqIojzCUVFfWaFTQ/yb0rlMsEcPYLGtPUAqyYe8Yg==", null, false, "5920ecff-9eac-4cb6-9379-166e5e16825e", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3218), "canergun" },
                    { "4b9ebee9-26df-4513-afc8-88bda801b68c", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "076c9fa6-8923-4e15-aef3-d9dcd7abf305", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3199), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEDUG66IagdemEAcA4yOD94EmZc7Jdc3vDPJ4JKkI0EatDtW1QGbkEeHMkfOXQEQepA==", null, false, "9adb8790-efd4-4d88-a136-ddbeec53e006", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3200), "gizemaydin" },
                    { "66ce77b9-9237-4a93-a746-dfb276bb9c1b", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "e2c38fe7-c6f6-4e07-aaef-347e9412d025", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3167), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAECpF/x607gsL5UnpRX2+F2qmxY4vHmUEkNaPTr8nAn0VmF60zcLAkOVUdXMwg+LKgw==", null, false, "aab3ecbf-f83e-4d29-bbd2-dac4d2cbb7a0", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3168), "zeynepgunes" },
                    { "68cd7577-2024-4580-bbee-1460bfa02a51", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "8933590b-4b99-4ebc-bb6a-a6003fe5d32c", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3283), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEGygaugHl7Pi30kwpdhQki7ydMl0pNylELFr6p1B3th79njyT5y35mzTAQ1UwlgVNA==", null, false, "f10307fb-619f-4499-922c-fc66897369ab", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3284), "melisozturk" },
                    { "69296ea0-8cd2-4740-8fee-f188bd4c16ef", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "03bbc799-fa8c-49d0-9bf5-fd22ec1aaf6f", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3369), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEOB5gf1vhc+AYslu10T4VGUrjhg1eBVUGOA8eEoxA7YtOK8fyf7xoq4XWbnHeRIG+g==", null, false, "fe0a9cf9-983b-4d95-84cc-13d5ae881137", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3370), "esraavci" },
                    { "92f1cf4c-8094-4225-8193-feaad9432475", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "3f4a10c7-9643-4aff-9a15-0f446348fa8a", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3383), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAEMb6GzUf0LA9akhj01OkwrqarP/0n3szlXhF/ODzO4xhaL2ItyY3FSZ0We8bW2UOoA==", null, false, "558c9133-bcdb-4d3c-b000-b0a054d24c2c", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3383), "fatmakara" },
                    { "b9aae3cf-7715-4293-bd17-4f2b4dac52c8", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "e2614eb9-05eb-4efa-9db0-6c873a23d603", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3352), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAEBWj2MF5Ge6tZ7uuWCf6AMbIThwXprH/H/x/MPgkYPxMpFRHSGgrvfGMLKaEnpFYMA==", null, false, "c25f3b09-bf6a-45f4-af35-8e4484b6a70b", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3352), "cansahin" },
                    { "f84c1788-aa1c-4d9f-96a9-00e81ec7e580", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "3372080d-9c3d-4ace-8d66-1b0a4890fb43", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3181), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEFkFNc1R9vMHkDdD0tnPKS2aF8biMCoDXf4i9zQB4PJn7zU3FbgurY8VFJZkYyCeFQ==", null, false, "76ba3da3-047d-4ee8-97f4-6b72d587937d", false, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3182), "alidemir" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3869), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3871) },
                    { 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3875), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3882) },
                    { 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3903), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3904) },
                    { 4, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3906), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3907) },
                    { 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3909), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3910) },
                    { 6, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3913), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3914) },
                    { 7, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3916), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3917) },
                    { 8, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3919), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3920) },
                    { 9, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3922), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3923) },
                    { 10, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3926), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3927) },
                    { 11, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3929), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3930) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "81a7cd0d-1a10-4bb8-8c56-ec882cb21fab", "05b3d752-0546-4c73-80ea-db8b76a1d2b3" },
                    { "c374ca7c-eee2-4c14-a95a-512150581312", "1f4adf05-e534-4187-855b-d6d3e46d3c21" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "2201d025-5b76-464d-aae3-edfe7aa48834" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "2cb2f7e6-e238-4695-b794-faf3433291f3" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "2da82f70-29cf-4f0f-9ea1-56f94c0278fc" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "47de91d5-5a68-420a-8492-5118b25b4d03" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "4b9ebee9-26df-4513-afc8-88bda801b68c" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "66ce77b9-9237-4a93-a746-dfb276bb9c1b" },
                    { "c374ca7c-eee2-4c14-a95a-512150581312", "68cd7577-2024-4580-bbee-1460bfa02a51" },
                    { "c374ca7c-eee2-4c14-a95a-512150581312", "69296ea0-8cd2-4740-8fee-f188bd4c16ef" },
                    { "c374ca7c-eee2-4c14-a95a-512150581312", "92f1cf4c-8094-4225-8193-feaad9432475" },
                    { "c374ca7c-eee2-4c14-a95a-512150581312", "b9aae3cf-7715-4293-bd17-4f2b4dac52c8" },
                    { "03cff1bb-c7b3-4122-aa83-3bba504b500d", "f84c1788-aa1c-4d9f-96a9-00e81ec7e580" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "CreatedTime", "JobTitle", "Promotion", "UpdatedTime", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4037), "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4039), "2201d025-5b76-464d-aae3-edfe7aa48834", 100m },
                    { 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4048), "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4049), "2cb2f7e6-e238-4695-b794-faf3433291f3", 100m },
                    { 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4054), "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4055), "66ce77b9-9237-4a93-a746-dfb276bb9c1b", 100m },
                    { 4, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4058), "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4059), "f84c1788-aa1c-4d9f-96a9-00e81ec7e580", 100m },
                    { 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4062), "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4063), "4b9ebee9-26df-4513-afc8-88bda801b68c", 100m },
                    { 6, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4067), "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4068), "47de91d5-5a68-420a-8492-5118b25b4d03", 100m },
                    { 7, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4071), "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4072), "2da82f70-29cf-4f0f-9ea1-56f94c0278fc", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3974), "1f4adf05-e534-4187-855b-d6d3e46d3c21" },
                    { 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3981), "68cd7577-2024-4580-bbee-1460bfa02a51" },
                    { 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3985), "b9aae3cf-7715-4293-bd17-4f2b4dac52c8" },
                    { 4, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3987), "69296ea0-8cd2-4740-8fee-f188bd4c16ef" },
                    { 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(3991), "92f1cf4c-8094-4225-8193-feaad9432475" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4608), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4610), "1.jpg", "05b3d752-0546-4c73-80ea-db8b76a1d2b3" },
                    { 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4618), "2.jpg", "2201d025-5b76-464d-aae3-edfe7aa48834" },
                    { 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4621), "3.jpg", "2cb2f7e6-e238-4695-b794-faf3433291f3" },
                    { 4, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4624), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4625), "4.jpg", "66ce77b9-9237-4a93-a746-dfb276bb9c1b" },
                    { 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4627), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4628), "5.jpg", "f84c1788-aa1c-4d9f-96a9-00e81ec7e580" },
                    { 6, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4639), "6.jpg", "4b9ebee9-26df-4513-afc8-88bda801b68c" },
                    { 7, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4642), "7.jpg", "47de91d5-5a68-420a-8492-5118b25b4d03" },
                    { 8, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4645), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4646), "8.jpg", "2da82f70-29cf-4f0f-9ea1-56f94c0278fc" },
                    { 9, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4648), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4649), "9.jpg", "1f4adf05-e534-4187-855b-d6d3e46d3c21" },
                    { 10, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4653), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4653), "10.jpg", "68cd7577-2024-4580-bbee-1460bfa02a51" },
                    { 11, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4656), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4657), "11.jpg", "b9aae3cf-7715-4293-bd17-4f2b4dac52c8" },
                    { 12, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4660), "12.jpg", "69296ea0-8cd2-4740-8fee-f188bd4c16ef" },
                    { 13, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4662), new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4663), "13.jpg", "92f1cf4c-8094-4225-8193-feaad9432475" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4369), "Amerikan Psikoloji Derneği", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4370) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4376), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4376) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4379), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4380) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4382), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4383) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4390), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4391) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4393), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4394) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4396), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4397) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4399), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4400) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4403), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4404) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4406), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4407) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4385), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4386) }
                });

            migrationBuilder.InsertData(
                table: "ConsultantsSpecializations",
                columns: new[] { "ConsultantId", "SpecializationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 9 },
                    { 1, 11 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 11 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 7 },
                    { 7, 10 }
                });

            migrationBuilder.InsertData(
                table: "CustomersConsultans",
                columns: new[] { "ConsultantId", "CustomerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 },
                    { 3, 2 },
                    { 4, 4 },
                    { 5, 5 },
                    { 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "ConsultantId", "CreatedTime", "DegreeofGraduation", "DepartmentName", "FacultyName", "GraduationYear", "SchoolName", "StartYear", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4205), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4206) },
                    { 2, 2, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4214), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4215) },
                    { 3, 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4218), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4219) },
                    { 4, 4, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4222), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4223) },
                    { 5, 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4225), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4226) },
                    { 6, 6, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4230), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4231) },
                    { 7, 7, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4236), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4236) },
                    { 8, 1, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4240), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4240) },
                    { 9, 3, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4243), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4244) },
                    { 10, 7, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4247), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4248) },
                    { 11, 5, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4251), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 4, 28, 16, 51, 35, 535, DateTimeKind.Local).AddTicks(4252) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_ConsultantId",
                table: "Certificates",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_UserId",
                table: "Consultants",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantsSpecializations_SpecializationId",
                table: "ConsultantsSpecializations",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersConsultans_CustomerId",
                table: "CustomersConsultans",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ConsultantId",
                table: "Educations",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserId",
                table: "Images",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

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
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "ConsultantsSpecializations");

            migrationBuilder.DropTable(
                name: "CustomersConsultans");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
