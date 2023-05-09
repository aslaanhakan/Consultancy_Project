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
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    Confirmation = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    Url = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    AppointmentDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    AppointmentTime = table.Column<string>(type: "TEXT", nullable: false),
                    AppointmentState = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
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
                    { "119df383-e36b-484e-b3f3-11ec5da34dd6", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "1c5fee95-1ff4-4c03-9fd6-190c28f89d9d", null, "Yönetici", "Admin", "ADMIN" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", null, "Danışanman", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "04d30f2e-caec-404f-b505-70fb1196a025", 0, "Turan Cd. No:7 Bornova", "İzmir", "9929709f-429c-4ae2-9347-04cf2250cd5a", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3990), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAECtyFj/rr4UKxWVhbGOJuHF/TDqNPhjjsMfNrPRKEq6t0B4xeUayyITRKmbw6AI6Pg==", null, false, "61789081-acb9-4e6f-9d1f-0bc367286e81", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3990), "canergun" },
                    { "1042ba8d-2316-49d4-94a3-1f5e1e852f2b", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "493cf4a1-7937-45fe-a852-d9292207e273", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4105), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAEP0nWsX/mB04LiMJd5+066kdRhaVn2LR0ht0yP+AheVom9LMFQQTkYam/8xpHG3LZA==", null, false, "bf321aa5-1cf0-418d-9464-a1b1cc53d4c9", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4106), "fatmakara" },
                    { "1c036192-5499-40ea-80b0-4c1c0920889b", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "21ffd54a-5aae-4c05-9fb0-18cb7d8431c0", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3954), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEEuYlml0nIkIz8PSqd+IN4864KdfiijT4oOw/q3UpDiWGGS0IaeNmj5eZgeXWPEdjw==", null, false, "f7fd6a5a-4de0-4f55-b790-9a00a3375882", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3955), "alidemir" },
                    { "33690bb7-9a39-462d-8e6d-286f1ec548cb", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "4919119b-1f47-4a23-9495-688878b6aa15", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4003), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAED2qZTFwhO7XWrLJt+fleNnx7FuqCqt1tMTtrTXYuV0t83/Rt50xIsN+9PlFdrC01A==", null, false, "4b822704-4e0a-4a46-aa64-0e1782487d93", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4003), "deniz" },
                    { "4837edea-c694-4273-8f9a-2bbc98ff9396", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "c7a02acd-998f-45e5-bc5a-05bd15a8aba7", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3920), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEJJ1kdwLbnlVeoI35DQbHWC8Qk7+I2o5GEBV9wqO+n3C+4eOPOdBiar23lODOK5DRw==", null, false, "f163d3ca-7531-4280-b328-acec4fffea6c", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3921), "mehmetozkan" },
                    { "4e90ec0e-8076-4c59-80af-3ad19f0cc829", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "f434c9ac-20ea-4ae4-8af4-f0e50c36431e", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4052), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEKt7c/9kbiWwHR8Ke0PtCgJES7u35iGqKr1LFdMz9jZQO8Qj/GGq89Q18pD6tiNaeA==", null, false, "631c7a9f-aa90-4f3e-b8f3-c29cbb88d72e", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4053), "melisozturk" },
                    { "594f7db0-f7b2-45a0-be4c-081876555572", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "d56d9d4d-69dd-45f2-a7c0-5af60bbb131d", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3938), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAEGGFBriUlMh7YRiGCqeevWY7aHdNDIV6eK1qYux2c3qhAjmpwRKimAYeuObtbnpzaQ==", null, false, "5aedde3e-27a4-458a-87f3-e8944e2ff60e", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3939), "zeynepgunes" },
                    { "5bef4dc4-18bd-476c-a40d-34cc43825716", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "c6edba63-f509-427b-b4f5-d3346559c0b1", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3904), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAEH/bCqJy2E4MKpWlZDOOEpA/UcqbNZfXgVXiGGaVr/yatsK/3KbKx0bQyjxngoxi0Q==", null, false, "e6065c39-1051-459c-a781-a3611ee1ec2f", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3905), "ayseyilmaz" },
                    { "942ccabe-e292-4f30-86c9-de496389a002", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "7dfa22f3-a0a3-4edd-a23e-21505f03101c", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4075), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAECMiXVeJxswNQrLjtjMyvL0DTZJQNfaY5Lx4aGVjB0dYoQf9XN7MAdAwfSK25hRkrg==", null, false, "6b1855c3-9800-42d8-a46f-2ec3100794fa", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4076), "cansahin" },
                    { "bb5b1305-b7bd-43bc-8134-a79891fe3d30", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "a0ac990d-3fa5-42a6-a476-7b68d7e67f2d", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4092), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEBMGPM3bvw54+JX5gW3RFJB3xMIPUeKtzbuzWUxZX4MeHoqQ2IODDcZMMcJNOVFjJQ==", null, false, "e4e01a4d-5b2c-4035-84e9-bd77bd7c860b", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4093), "esraavci" },
                    { "f8931c0e-4b89-4d8b-b34e-a082a5ff49e1", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "2fa7fad1-4940-4414-9a2d-84cb2fbddffe", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4016), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEKtxMsYNvDi8tobv/2ckyIDpMeZa7S9jx9PDuXPIquChOnrxKlT6iN1xV2aZjqEktg==", null, false, "64c95b9a-7498-48c9-bd64-12d99fc0577e", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4017), "aliyildirim" },
                    { "fb68072b-4beb-4b89-9cc9-0ae9f82746fa", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "a5e34ea5-c919-485d-8878-660819b95949", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3843), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEBjrRH6tXRDSyGM69CS/dTplPwTClC7NTGeMk9L8s2p/0U+vkX2paQ0OMAX86gq5Pw==", null, false, "ccefdc35-d746-41f2-af4f-c4adbb7c2041", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3859), "admin" },
                    { "ffc0e2c7-0d42-4a4e-86db-535968ae85db", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "c67bb667-c146-427e-885f-d9eb09133aac", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3972), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEHK28L+5W/Yh3i3JMttqfz1Wijon/Uk0gNxcMbkv35sRLj+3wc+zzZA5OdLxmYWNPw==", null, false, "3f57e3c2-4b38-4f6b-a024-8a4b96dd044b", false, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(3973), "gizemaydin" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4583), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4586) },
                    { 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4591), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4596) },
                    { 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4610), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4611) },
                    { 4, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4613), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4613) },
                    { 5, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4615), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4616) },
                    { 6, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4622), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4623) },
                    { 7, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4624), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4625) },
                    { 8, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4626), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4627) },
                    { 9, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4629), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4629) },
                    { 10, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4633), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4633) },
                    { 11, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4635), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4636) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "04d30f2e-caec-404f-b505-70fb1196a025" },
                    { "119df383-e36b-484e-b3f3-11ec5da34dd6", "1042ba8d-2316-49d4-94a3-1f5e1e852f2b" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "1c036192-5499-40ea-80b0-4c1c0920889b" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "33690bb7-9a39-462d-8e6d-286f1ec548cb" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "4837edea-c694-4273-8f9a-2bbc98ff9396" },
                    { "119df383-e36b-484e-b3f3-11ec5da34dd6", "4e90ec0e-8076-4c59-80af-3ad19f0cc829" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "594f7db0-f7b2-45a0-be4c-081876555572" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "5bef4dc4-18bd-476c-a40d-34cc43825716" },
                    { "119df383-e36b-484e-b3f3-11ec5da34dd6", "942ccabe-e292-4f30-86c9-de496389a002" },
                    { "119df383-e36b-484e-b3f3-11ec5da34dd6", "bb5b1305-b7bd-43bc-8134-a79891fe3d30" },
                    { "119df383-e36b-484e-b3f3-11ec5da34dd6", "f8931c0e-4b89-4d8b-b34e-a082a5ff49e1" },
                    { "1c5fee95-1ff4-4c03-9fd6-190c28f89d9d", "fb68072b-4beb-4b89-9cc9-0ae9f82746fa" },
                    { "cf071a51-eaef-4d9a-bbce-7f9bca26bfb3", "ffc0e2c7-0d42-4a4e-86db-535968ae85db" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "Confirmation", "JobTitle", "Promotion", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, true, "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", "5bef4dc4-18bd-476c-a40d-34cc43825716", 100m },
                    { 2, true, "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", "4837edea-c694-4273-8f9a-2bbc98ff9396", 100m },
                    { 3, true, "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", "594f7db0-f7b2-45a0-be4c-081876555572", 100m },
                    { 4, true, "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", "1c036192-5499-40ea-80b0-4c1c0920889b", 100m },
                    { 5, true, "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", "ffc0e2c7-0d42-4a4e-86db-535968ae85db", 100m },
                    { 6, true, "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", "04d30f2e-caec-404f-b505-70fb1196a025", 100m },
                    { 7, true, "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", "33690bb7-9a39-462d-8e6d-286f1ec548cb", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "f8931c0e-4b89-4d8b-b34e-a082a5ff49e1" },
                    { 2, "4e90ec0e-8076-4c59-80af-3ad19f0cc829" },
                    { 3, "942ccabe-e292-4f30-86c9-de496389a002" },
                    { 4, "bb5b1305-b7bd-43bc-8134-a79891fe3d30" },
                    { 5, "1042ba8d-2316-49d4-94a3-1f5e1e852f2b" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5193), "1.jpg", "fb68072b-4beb-4b89-9cc9-0ae9f82746fa" },
                    { 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5199), "2.jpg", "5bef4dc4-18bd-476c-a40d-34cc43825716" },
                    { 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5202), "3.jpg", "4837edea-c694-4273-8f9a-2bbc98ff9396" },
                    { 4, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5205), "4.jpg", "594f7db0-f7b2-45a0-be4c-081876555572" },
                    { 5, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5208), "5.jpg", "1c036192-5499-40ea-80b0-4c1c0920889b" },
                    { 6, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5217), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5218), "6.jpg", "ffc0e2c7-0d42-4a4e-86db-535968ae85db" },
                    { 7, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5221), "7.jpg", "04d30f2e-caec-404f-b505-70fb1196a025" },
                    { 8, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5224), "8.jpg", "33690bb7-9a39-462d-8e6d-286f1ec548cb" },
                    { 9, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5226), "9.jpg", "f8931c0e-4b89-4d8b-b34e-a082a5ff49e1" },
                    { 10, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5230), "10.jpg", "4e90ec0e-8076-4c59-80af-3ad19f0cc829" },
                    { 11, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5233), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5233), "11.jpg", "942ccabe-e292-4f30-86c9-de496389a002" },
                    { 12, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5235), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5236), "12.jpg", "bb5b1305-b7bd-43bc-8134-a79891fe3d30" },
                    { 13, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5335), new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5336), "13.jpg", "1042ba8d-2316-49d4-94a3-1f5e1e852f2b" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentState", "AppointmentTime", "ConsultantId", "CreatedTime", "CustomerId", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 1, 1), 1, "10:00-11:00", 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4791), 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4792) },
                    { 2, new DateOnly(2023, 1, 1), 2, "13:00-14:00", 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4798), 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4799) },
                    { 3, new DateOnly(2023, 5, 20), 0, "15:00-16:00", 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4802), 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4803) },
                    { 4, new DateOnly(2023, 5, 25), 3, "18:00-19:00", 4, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4806), 4, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4807) }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5030), "Amerikan Psikoloji Derneği", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5031) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5036), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5037) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5039), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5040) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5041), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5042) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5048), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5049) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5051), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5052) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5053), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5054) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5057), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5058) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5061), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5062) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5064), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5065) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5044), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(5045) }
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
                    { 1, 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4853), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4855) },
                    { 2, 2, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4860), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4860) },
                    { 3, 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4863), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4864) },
                    { 4, 4, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4866), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4867) },
                    { 5, 5, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4869), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4870) },
                    { 6, 6, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4874), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4874) },
                    { 7, 7, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4877), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4878) },
                    { 8, 1, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4880), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4881) },
                    { 9, 3, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4883), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4884) },
                    { 10, 7, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4888), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4889) },
                    { 11, 5, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4891), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 5, 9, 16, 15, 37, 866, DateTimeKind.Local).AddTicks(4892) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ConsultantId",
                table: "Appointments",
                column: "ConsultantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                unique: true);

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
