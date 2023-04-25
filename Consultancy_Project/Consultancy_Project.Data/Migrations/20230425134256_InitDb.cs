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
                    { "38b01197-6e65-479c-846c-cdbc97bc05e8", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "693d2e26-8e77-4ffb-bc56-10ac00b0143e", null, "Yönetici", "Admin", "ADMIN" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", null, "Danışanman", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "2d2a26fc-ebfd-41ab-8cdd-3b836f758d84", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "e996b976-5b47-4bd3-8597-0905fe5fd279", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6623), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEAazFYbvvHojd6MaiCfKI0Ga9jn4sjnV0CPiW3LnUfjwFqYGMgxtwSy1dAEfTlNrIg==", null, false, "247debb5-71ab-4df4-8f4f-42d6361b590b", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6625), "deniz" },
                    { "3c5daa4c-67ad-4df1-82eb-ad0f065f8f9b", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "036ea6b5-88dc-4252-9505-37df0fdea834", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6636), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEKeIrxYhI0wYpdO1RNiZ2zCauOnmyYoCBYJkQy2UkZV8g9k+1Pn/rvsq2ZzO5MatKg==", null, false, "28bd79a8-504f-4668-8d01-c92f9280c579", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6638), "aliyildirim" },
                    { "4a5459d2-77d5-4490-86ce-ce03a741d8ff", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "adb12668-f17f-4657-8512-60c7c7364988", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6792), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAELsOmyk65OSEwLxknh74OqBmxxPQcwGVpWfzNWvR3LDdkk4FfT9mD2eGTku+craFyQ==", null, false, "ad5b8f7c-df88-448d-8ab9-31df3dbc6eb8", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6792), "cansahin" },
                    { "50835d3d-d60d-42dd-b252-1b2246d10eb9", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "5cc05897-43e7-4581-b1f1-fae448322dd3", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6773), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEJcw6xWz40kgtctvZSuRmVCqENu70rd3eP1eLSVHwCxJi6G1LTJ3LV0XllQxadPa3A==", null, false, "a34e34ce-4ccf-4aa5-bfb0-85f27e2e7ecb", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6775), "melisozturk" },
                    { "5314f669-d35e-4683-ac85-cfb51c03e0d9", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "3ca7c804-d991-4974-af0a-8112e17c8a61", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6520), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAEGXuMJpYe5BKldo5M+Xb5yS3N0tp3UrTBmvWJNSzI9udlm8HHGuXxO/hEdIfHe21TA==", null, false, "070eb1f2-baac-4c9d-bc5b-680b58852f74", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6521), "ayseyilmaz" },
                    { "54a970b0-9f71-49ec-8b4a-bc278ed975fb", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "250b3e3f-c4a5-4f17-a07e-8f808ae9b129", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6595), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEM9rHUyG8OYjtg5S/Hch++yQ0Ms46HDNyxolvUibHcfDCxj+N8h/gBP4QT9hTifXag==", null, false, "b3d6ab90-d770-49c3-a421-e84f72b604df", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6596), "gizemaydin" },
                    { "8105cf00-98d1-4e1c-85e8-ff59f08495cb", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "eaa6a9c9-60a2-4a45-8e57-a1b805ba76be", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6549), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEPZvJkYM2Zsi8Xj0rV0XfSIKzP/2wK1Qh2+90FaG51+I7lCadxt6oVLKKlFIARWe6g==", null, false, "126a1fb3-1999-4fc0-9408-19026fcb7525", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6550), "mehmetozkan" },
                    { "a4c2a0de-5829-4ce2-bf48-5f77a4d34f33", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "832bc8cc-bd59-4c53-bd54-d517742de5a6", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6806), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEBl86dpHNYjpLxqE79+SLFaXShRsoxr3e6JKJiber05AHYNO57U9/kh3hr2EO7JqUw==", null, false, "416afa3e-acd5-41d6-b7fa-d0e3fc648799", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6807), "esraavci" },
                    { "af0b4cbd-f511-402a-a893-64c081598a74", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "335245f2-2723-483f-bb63-bc210fbfc427", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6561), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAELGBS1uptZZp1kehL4BwH/9m7DcvURUpk33owcmKuYP9ZGV7UjKma7uxjEz7yw4vRg==", null, false, "fd5d7c08-823b-4765-b2fe-de93a66e95bd", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6562), "zeynepgunes" },
                    { "e43769c3-5ad5-424a-9e59-b7cfb1d59ed4", 0, "Turan Cd. No:7 Bornova", "İzmir", "5a814ca6-c9e5-47db-ab26-65219c8d0789", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6607), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEKVoi+ZfyA8YpaNJlFeFazPAOSATRAa74Z7/MSNl/QlB73ftQZFESeNEMUVOxILZEQ==", null, false, "ed60a740-54ea-43e3-878f-dcb3979a87fb", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6609), "canergun" },
                    { "e4dc147e-1b4d-4d21-b833-fedfbb6114d4", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "e4afa130-99b0-4fc5-90b5-446995df5a1a", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6822), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAENSjrC1CfhFFjckzBrjaHB4eOvycLsiYSalXicQPTaB8HsUYmy5cYXQKi3n0sMWakw==", null, false, "dd0c0080-21bf-4029-985c-1a4cee8541bf", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6823), "fatmakara" },
                    { "ec40bfe8-297b-4a6e-9843-bb6ab63f3628", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "449229c8-3163-492d-b012-482b8e05dd5b", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6480), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEJaVfID4sx08G0DM3mGCbqKuLgN5xmCD8oZvyJnlzvsC5nmUD3RIaMM40/G2K9PaZg==", null, false, "022bf6a6-56cf-4b24-8744-5e686b70f696", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6494), "admin" },
                    { "f23b11a4-46e3-45ec-a315-b06d584ca6f4", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "c8da70d5-2a66-42be-97b7-93602da704e7", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6575), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEC6KkLkqPTRxvltixHbt7/wavBAhwjKrQzMKDOfkYU8quDDsI7FmBoLJWKFUUGKFKg==", null, false, "84df651a-42b2-4657-9e70-668ce8ef62a4", false, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(6576), "alidemir" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7251), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7253) },
                    { 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7257), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7261) },
                    { 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7273), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7274) },
                    { 4, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7276), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7277) },
                    { 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7278), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7279) },
                    { 6, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7282), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7283) },
                    { 7, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7285), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7285) },
                    { 8, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7287), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7288) },
                    { 9, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7289), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7290) },
                    { 10, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7293), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7294) },
                    { 11, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7295), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7296) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "2d2a26fc-ebfd-41ab-8cdd-3b836f758d84" },
                    { "38b01197-6e65-479c-846c-cdbc97bc05e8", "3c5daa4c-67ad-4df1-82eb-ad0f065f8f9b" },
                    { "38b01197-6e65-479c-846c-cdbc97bc05e8", "4a5459d2-77d5-4490-86ce-ce03a741d8ff" },
                    { "38b01197-6e65-479c-846c-cdbc97bc05e8", "50835d3d-d60d-42dd-b252-1b2246d10eb9" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "5314f669-d35e-4683-ac85-cfb51c03e0d9" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "54a970b0-9f71-49ec-8b4a-bc278ed975fb" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "8105cf00-98d1-4e1c-85e8-ff59f08495cb" },
                    { "38b01197-6e65-479c-846c-cdbc97bc05e8", "a4c2a0de-5829-4ce2-bf48-5f77a4d34f33" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "af0b4cbd-f511-402a-a893-64c081598a74" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "e43769c3-5ad5-424a-9e59-b7cfb1d59ed4" },
                    { "38b01197-6e65-479c-846c-cdbc97bc05e8", "e4dc147e-1b4d-4d21-b833-fedfbb6114d4" },
                    { "693d2e26-8e77-4ffb-bc56-10ac00b0143e", "ec40bfe8-297b-4a6e-9843-bb6ab63f3628" },
                    { "c79a1131-8a14-4b88-accd-0dff6d607dad", "f23b11a4-46e3-45ec-a315-b06d584ca6f4" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "CreatedTime", "JobTitle", "Promotion", "UpdatedTime", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7387), "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7388), "5314f669-d35e-4683-ac85-cfb51c03e0d9", 100m },
                    { 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7397), "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7398), "8105cf00-98d1-4e1c-85e8-ff59f08495cb", 100m },
                    { 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7401), "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7402), "af0b4cbd-f511-402a-a893-64c081598a74", 100m },
                    { 4, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7404), "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7405), "f23b11a4-46e3-45ec-a315-b06d584ca6f4", 100m },
                    { 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7459), "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7460), "54a970b0-9f71-49ec-8b4a-bc278ed975fb", 100m },
                    { 6, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7466), "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7466), "e43769c3-5ad5-424a-9e59-b7cfb1d59ed4", 100m },
                    { 7, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7469), "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7470), "2d2a26fc-ebfd-41ab-8cdd-3b836f758d84", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7336), "3c5daa4c-67ad-4df1-82eb-ad0f065f8f9b" },
                    { 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7340), "50835d3d-d60d-42dd-b252-1b2246d10eb9" },
                    { 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7343), "4a5459d2-77d5-4490-86ce-ce03a741d8ff" },
                    { 4, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7346), "a4c2a0de-5829-4ce2-bf48-5f77a4d34f33" },
                    { 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7348), "e4dc147e-1b4d-4d21-b833-fedfbb6114d4" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7849), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7851), "1.jpg", "ec40bfe8-297b-4a6e-9843-bb6ab63f3628" },
                    { 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7857), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7858), "2.jpg", "5314f669-d35e-4683-ac85-cfb51c03e0d9" },
                    { 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7862), "3.jpg", "8105cf00-98d1-4e1c-85e8-ff59f08495cb" },
                    { 4, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7864), "4.jpg", "af0b4cbd-f511-402a-a893-64c081598a74" },
                    { 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7867), "5.jpg", "f23b11a4-46e3-45ec-a315-b06d584ca6f4" },
                    { 6, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7877), "6.jpg", "54a970b0-9f71-49ec-8b4a-bc278ed975fb" },
                    { 7, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7879), "7.jpg", "e43769c3-5ad5-424a-9e59-b7cfb1d59ed4" },
                    { 8, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7882), "8.jpg", "2d2a26fc-ebfd-41ab-8cdd-3b836f758d84" },
                    { 9, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7884), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7885), "9.jpg", "3c5daa4c-67ad-4df1-82eb-ad0f065f8f9b" },
                    { 10, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7889), "10.jpg", "50835d3d-d60d-42dd-b252-1b2246d10eb9" },
                    { 11, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7891), "11.jpg", "4a5459d2-77d5-4490-86ce-ce03a741d8ff" },
                    { 12, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7894), "12.jpg", "a4c2a0de-5829-4ce2-bf48-5f77a4d34f33" },
                    { 13, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7896), new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7897), "13.jpg", "e4dc147e-1b4d-4d21-b833-fedfbb6114d4" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7649), "Amerikan Psikoloji Derneği", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7650) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7654), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7655) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7657), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7658) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7660), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7660) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7665), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7666) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7668), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7669) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7671), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7671) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7673), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7674) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7677), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7678) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7680), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7681) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7662), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7663) }
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
                    { 1, 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7515), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7515) },
                    { 2, 2, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7520), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7521) },
                    { 3, 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7525), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7526) },
                    { 4, 4, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7530), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7531) },
                    { 5, 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7534), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7535) },
                    { 6, 6, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7539), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7540) },
                    { 7, 7, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7543), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7543) },
                    { 8, 1, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7546), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7547) },
                    { 9, 3, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7549), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7550) },
                    { 10, 7, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7554), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7554) },
                    { 11, 5, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7557), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 4, 25, 16, 42, 54, 151, DateTimeKind.Local).AddTicks(7557) }
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
