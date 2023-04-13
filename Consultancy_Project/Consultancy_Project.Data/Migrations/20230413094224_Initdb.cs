using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consultancy_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initdb : Migration
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
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false)
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
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false)
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
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specializations_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09eb9be9-ab6f-4a7d-b782-d57ec2900ef9", null, "Yönetici", "Admin", "ADMIN" },
                    { "7cb4fdf0-da38-4c39-b094-c0132e7d27e3", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", null, "Danışanman", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04d4aec4-3564-4ac3-a099-b9a6ec4d3a42", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "fca46bdd-15ad-4b11-aadf-9d811b4e6bca", new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEEHrKShi6cXsMf9sOyKAbdz6rIaTyXIBuKk63allxlqZbivO7S6pENfqHD90fY5u+Q==", null, false, "4b55c569-b516-4621-9628-eac75dcad2a4", false, "deniz" },
                    { "4e7eb8c8-03ba-41a1-9db0-b66a34fae9ce", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "8ff8788e-ba7c-45c1-af00-4b8c2d3a314e", new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEMjjG1stlC4OBqHRy0suOGknHO7Em9nw2N8BOUT6nShL5KEavMMBImYSJd+T7P/V8A==", null, false, "9df302f0-9a78-414e-91f5-a913841345ed", false, "gizemaydin" },
                    { "657e8e0f-118e-4058-ad8a-226953ed48e4", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "8c30317b-86c4-45e7-8cc8-2605a267e2c5", new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAELch1YHGBvZmCVj4vUPFoxZWCOW70inUlyJkvmuxnoPRY03fZmCVyBFkaSAmeGvnFg==", null, false, "b0adc425-9754-4a97-8bf1-ae60c1015a2e", false, "zeynepgunes" },
                    { "663b5466-d86d-4292-ae29-e739536907a8", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "8fb14392-6fa9-4523-9546-4ee27d0a6517", new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAEM5gfg2aAoPsdtYv9FRMnLVu0p5TLAoazOdz++CQLMKOfecjYwPUvsUrtK3ex1Evsw==", null, false, "40db63b9-a7b0-40c6-9ad3-6c19cfd0ebb4", false, "cansahin" },
                    { "6ffdfd51-0f9a-43c9-a05a-0bc15e972d30", 0, "Turan Cd. No:7 Bornova", "İzmir", "3aaca2e2-8b33-44a5-ba44-23a8b5f33a7a", new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEBGLxtX7IagXLVNe1WuY4D5WO6zebIpCqGo7hjTIrQr42amJfvteKBHZPY3jsFzPBw==", null, false, "9acd2c94-926f-44c2-b7a2-7bf0ebb94378", false, "canergun" },
                    { "7832aad9-0518-48ca-9517-d1dfd3529d42", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "54773efc-c9c8-44d9-9167-69eb611be68c", new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEDS+vYUV9bFX+UH3sgbYW774IdtuwwTD1zAIVr7vilSq5iErNBNsJKRmaxngu3CAUQ==", null, false, "c5bcaa2e-f98b-48e4-9d71-23e91f3110dd", false, "melisozturk" },
                    { "828e41dd-39e6-4750-a450-282812353eef", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "e1c1a6c1-b4dd-417e-951e-011a0223d819", new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEP+1X/9Ywa9y+AhLW6q6DEq4I+KsFxw0+pd+0w8A1bQqfuQ6tySa9j8NuOcOqy4Dsw==", null, false, "36bc8546-7516-43ca-8407-9a5fc8840c12", false, "esraavci" },
                    { "86c2a29c-ea3a-42a2-ae55-28aad964a648", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "9efddf5e-d3eb-4bcb-9eed-180216f313cc", new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEKdt05FoFemg2EcJYVzeGctA8gCCXpevoAEqb0HhNRAzArjwDk1cm0oVR290ye+llA==", null, false, "8543c353-51f2-4504-89b2-971caa70ef97", false, "mehmetozkan" },
                    { "88f06875-4ba5-4fde-b05b-3e4570532296", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "4f0f6889-b9e2-40cf-a00d-c7a202379e21", new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAECL0adxbkgPiUjwJMDeu/mnW1cNvHAGL5cGWaYHR8TIrZHTxpweN/IYKM7kCVLcaKQ==", null, false, "7075e0a9-5694-4bae-8c4d-99663475653c", false, "alidemir" },
                    { "a7b3df57-5c10-4ac6-934d-646b471f1262", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "f792df35-ea77-416d-a617-63d5c966fa7e", new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAELhNh4nXa7gnqQ335asYjkkWTg+S9i0jCj9MfI3Vsd8UyvxnW/PkFlw0FzuKlN/tUg==", null, false, "9c89bab4-911a-45aa-b56c-8b34137cd410", false, "fatmakara" },
                    { "bb4ae640-5453-4ad6-af0d-341899aeeaec", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "94d396bb-b5b4-4a86-ace8-0cc9185b3851", new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAELoFfcKkopJjsZ1WGRcrZMzhaPUMt4BAjkzTwyVwixklqGBV0OjNVn0nUblcOz5Reg==", null, false, "9d6d1944-2e87-45d3-a5e6-845d0e64b332", false, "ayseyilmaz" },
                    { "da225905-150f-48e6-9f42-68cf86864986", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "69d9f670-38b6-43b4-b592-8de29837bdb2", new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEO4/1pL+UTKyHNHllMpaPqGX6JFoHdcZsZSa0pzrVFlI0eKHkAUJ6kG1NSQVdDpCug==", null, false, "0e8ae0d9-3d16-48f2-9a52-7a3f8bafc555", false, "admin" },
                    { "f987533b-0204-49f7-9d8b-72ea008ff4b6", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "3b705823-3ea2-4781-9557-25238e68698f", new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEGHeaBeu4SFOapsYxuhbjjRs8OR5qC5kHe4f/U97sqRpyPhxBBBV7RKCKXBYUQ2Omg==", null, false, "0b88741a-e83b-4504-944c-f96cfb87bcc4", false, "aliyildirim" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "ConsultantId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon" },
                    { 2, null, "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu" },
                    { 3, null, "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık" },
                    { 4, null, "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü" },
                    { 5, null, "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi" },
                    { 6, null, "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi" },
                    { 7, null, "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim" },
                    { 8, null, "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar" },
                    { 9, null, "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi" },
                    { 10, null, "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu" },
                    { 11, null, "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "04d4aec4-3564-4ac3-a099-b9a6ec4d3a42" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "4e7eb8c8-03ba-41a1-9db0-b66a34fae9ce" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "657e8e0f-118e-4058-ad8a-226953ed48e4" },
                    { "7cb4fdf0-da38-4c39-b094-c0132e7d27e3", "663b5466-d86d-4292-ae29-e739536907a8" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "6ffdfd51-0f9a-43c9-a05a-0bc15e972d30" },
                    { "7cb4fdf0-da38-4c39-b094-c0132e7d27e3", "7832aad9-0518-48ca-9517-d1dfd3529d42" },
                    { "7cb4fdf0-da38-4c39-b094-c0132e7d27e3", "828e41dd-39e6-4750-a450-282812353eef" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "86c2a29c-ea3a-42a2-ae55-28aad964a648" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "88f06875-4ba5-4fde-b05b-3e4570532296" },
                    { "7cb4fdf0-da38-4c39-b094-c0132e7d27e3", "a7b3df57-5c10-4ac6-934d-646b471f1262" },
                    { "d6a9f350-cab9-4f80-8692-0c2bde055bbc", "bb4ae640-5453-4ad6-af0d-341899aeeaec" },
                    { "09eb9be9-ab6f-4a7d-b782-d57ec2900ef9", "da225905-150f-48e6-9f42-68cf86864986" },
                    { "7cb4fdf0-da38-4c39-b094-c0132e7d27e3", "f987533b-0204-49f7-9d8b-72ea008ff4b6" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "JobTitle", "Promotion", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", "bb4ae640-5453-4ad6-af0d-341899aeeaec", 100m },
                    { 2, "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", "86c2a29c-ea3a-42a2-ae55-28aad964a648", 100m },
                    { 3, "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", "657e8e0f-118e-4058-ad8a-226953ed48e4", 100m },
                    { 4, "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", "88f06875-4ba5-4fde-b05b-3e4570532296", 100m },
                    { 5, "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", "4e7eb8c8-03ba-41a1-9db0-b66a34fae9ce", 100m },
                    { 6, "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", "6ffdfd51-0f9a-43c9-a05a-0bc15e972d30", 100m },
                    { 7, "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", "da225905-150f-48e6-9f42-68cf86864986", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "f987533b-0204-49f7-9d8b-72ea008ff4b6" },
                    { 2, "7832aad9-0518-48ca-9517-d1dfd3529d42" },
                    { 3, "663b5466-d86d-4292-ae29-e739536907a8" },
                    { 4, "828e41dd-39e6-4750-a450-282812353eef" },
                    { 5, "a7b3df57-5c10-4ac6-934d-646b471f1262" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5613), "1.jpg", "da225905-150f-48e6-9f42-68cf86864986" },
                    { 2, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5619), "2.jpg", "bb4ae640-5453-4ad6-af0d-341899aeeaec" },
                    { 3, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5622), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5623), "3.jpg", "86c2a29c-ea3a-42a2-ae55-28aad964a648" },
                    { 4, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5625), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5626), "4.jpg", "657e8e0f-118e-4058-ad8a-226953ed48e4" },
                    { 5, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5628), "5.jpg", "88f06875-4ba5-4fde-b05b-3e4570532296" },
                    { 6, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5639), "6.jpg", "4e7eb8c8-03ba-41a1-9db0-b66a34fae9ce" },
                    { 7, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5642), "7.jpg", "6ffdfd51-0f9a-43c9-a05a-0bc15e972d30" },
                    { 8, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5644), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5645), "8.jpg", "04d4aec4-3564-4ac3-a099-b9a6ec4d3a42" },
                    { 9, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5648), "9.jpg", "f987533b-0204-49f7-9d8b-72ea008ff4b6" },
                    { 10, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5651), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5652), "10.jpg", "7832aad9-0518-48ca-9517-d1dfd3529d42" },
                    { 11, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5654), "11.jpg", "663b5466-d86d-4292-ae29-e739536907a8" },
                    { 12, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5656), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5657), "12.jpg", "828e41dd-39e6-4750-a450-282812353eef" },
                    { 13, new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5659), new DateTime(2023, 4, 13, 12, 42, 21, 931, DateTimeKind.Local).AddTicks(5660), "13.jpg", "a7b3df57-5c10-4ac6-934d-646b471f1262" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "Institution" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, "Amerikan Psikoloji Derneği" },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, "Amerikan Psikoloji Derneği (APA)" },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)" },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)" },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)" },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)" },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)" },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)" },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, "Oyun Terapisi Derneği (Association for Play Therapy, APT)" },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)" },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, "İngiliz Psikoloji Derneği (British Psychological Society, BPS)" }
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
                columns: new[] { "Id", "ConsultantId", "DegreeofGraduation", "DepartmentName", "FacultyName", "GraduationYear", "SchoolName", "StartYear" },
                values: new object[,]
                {
                    { 1, 1, "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009 },
                    { 2, 2, "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013 },
                    { 3, 3, "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012 },
                    { 4, 4, "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013 },
                    { 5, 5, "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014 },
                    { 6, 6, "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011 },
                    { 7, 7, "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013 },
                    { 8, 1, "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013 },
                    { 9, 3, "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016 },
                    { 10, 7, "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017 },
                    { 11, 5, "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018 }
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
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantsSpecializations_SpecializationId",
                table: "ConsultantsSpecializations",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_ConsultantId",
                table: "Specializations",
                column: "ConsultantId");
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
