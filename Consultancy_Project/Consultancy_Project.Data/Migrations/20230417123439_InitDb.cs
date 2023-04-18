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
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    { "11ad09bb-1078-4882-9c50-a537a254dc9c", null, "Yönetici", "Admin", "ADMIN" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", null, "Danışanman", "Consultant", "CONSULTANT" },
                    { "475521ed-2cba-4da4-9b88-b166f5966f55", null, "Kullanıcı", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "3ee5e687-3a26-4f1b-9a40-10bad3e75419", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "a7204247-3020-4ecf-897b-05dd8a824708", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4837), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAECbRDnqMKF7QpxYn3V3mD9bLHRV+lDw8wv4C2aJTa1YzzSvyTcbH0xeu8AlPWtJDiw==", null, false, "f01f1e4a-7303-496c-867a-5ab0545461d5", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4838), "gizemaydin" },
                    { "5d2f0c4c-91b8-4d19-b768-28d53b500683", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "6facfba8-004e-46a1-b4d3-b04222dd27f2", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4811), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAEIfAnREu8RBAkG/fYp9w0aK3EcDdE/ojJBE/yI4A7lRMz+ZZRqWVXGnwa8A6BUcTRA==", null, false, "e09d9ec1-f92d-4671-bdb0-439679286335", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4811), "zeynepgunes" },
                    { "6992bbea-a922-4cab-b8e0-b2d2bdcd1afc", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "1d94f05e-c4da-43b0-843a-0fcb44f57cc9", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4795), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEGYDXaN/c8RnoRhmjinqCQCmga+2JJjJgEAduFhEo3jZRRmsY+Ecbr7vtj3KnJA/rg==", null, false, "1b3a2cb3-628d-4713-abc2-4c664920001b", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4796), "mehmetozkan" },
                    { "69afb770-d3ab-46c6-9d20-8503ad5e48ee", 0, "Turan Cd. No:7 Bornova", "İzmir", "d904a4fd-63e3-40da-b9ee-dd0044822647", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4853), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEKk3SIZeRe7aoy+mw5L5oRBP18w3Tu4qMc7fzky0MlrK3W0BRKuD9A8ruO10rDFUHQ==", null, false, "ddae402d-0f36-4106-936d-481b6d586d04", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4853), "canergun" },
                    { "7f3edf88-2b2d-4048-ab60-e05be8d14aac", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "6b796682-8705-46e8-96df-992e0cd73263", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4823), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEB4q+EdHbTm8Q4okkfzfMQuQdlFMTaF46WeU2f16MzrDvmuDVFhmU7IAhnkteOlRKg==", null, false, "dac4f8c2-3c02-4fdd-a31c-d77a5c3c7e2c", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4824), "alidemir" },
                    { "880cefef-3a03-4c56-b7a6-1b3bdefc4515", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "c4c5ecd3-3c93-4461-be38-77790460f7d9", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4951), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAECK4IBLLKSXIT/mMN1w7hVQPgVBe/2E9mD0X3tH64nJUWnIqolF9gh/CQTB76c4bIA==", null, false, "e1fa7338-ca42-4d1b-afc7-72f13b566d9b", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4952), "fatmakara" },
                    { "8f2a5636-607a-4879-b349-45533acb52ff", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "ffe769bc-c48b-49fa-9fd4-91c5fe4edc0b", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4925), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAEC5mQV3r0NNUXhqxIrUbHi7n8PmUvenx82ww7zpQjpvifuJqH0JSBVdzBXJZYSa/Fg==", null, false, "6b44f4e1-5d59-4fd5-974e-5959531253cb", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4926), "cansahin" },
                    { "967f829a-2d6f-4d11-8a4b-e6fb34cc04d4", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "eb5617c1-c76b-4f18-b5e1-48c2b8b67e70", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4912), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEDukKXs7K+ENVcMDG+T7li+8VFtI1+Sg7+0YioIheXSHk0QiUxMkl7ZGgSjrpVri0g==", null, false, "24012482-68d7-4699-b2f7-2d8d12dff202", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4913), "melisozturk" },
                    { "96c9641e-24ac-41ed-a72d-46b814b945b7", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "70420235-9d26-4f7c-875c-90e818f804dc", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4939), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEMJNuWD7LNwQJ2oMGWaoR6kDsR4r3a2IpKkgN6UUbqZckueON3ziAFnwzLwvNfAR8g==", null, false, "423fe046-e5cf-40a0-aed1-5749ebdf5507", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4939), "esraavci" },
                    { "a1c135c1-04b5-4d40-b388-394ac4778a19", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "fdc8769a-1d54-46ad-9af1-b41ca7963aac", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4880), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEAyFkOxYenbaU2eulByQJCtWzE26X51jouoajoQdgCvXUVSPlzxL4d0G6poVyJHXEg==", null, false, "08c7af87-e45d-4180-8f57-9e45a76f7d80", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4880), "aliyildirim" },
                    { "a950a3d8-d54c-48cc-9168-2cb9baaa8783", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "e09b21d1-d5cd-45ac-a7f7-8fc2578a0a7c", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4781), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAEBReebCEKvEGyM66cAGWmaljlNED8TYDLTTbrViR3ZdpN30X0ch1ULvszb4HG9I9LA==", null, false, "ab35f781-2821-4997-96e6-e8cd68fe26f3", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4782), "ayseyilmaz" },
                    { "deedc854-e16b-4fc8-8271-9202b28f2308", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "e8d6618a-9f2f-4b93-a48c-9edd05fa266c", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4865), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEH0IxlQXMGkXXWMzwpjxS0lYuAA6wTDh4CwrJYvbHoW6/WdpOTJeOyKLNtLkCo0Kow==", null, false, "5c37a909-c6da-41f9-a05e-6abe92aeb637", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4866), "deniz" },
                    { "fde1f674-50c4-41f2-a034-d05b278e2644", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "492e8f47-0664-4c3d-9e81-9d5b93358d27", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4740), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEM7XzVq3U/K1i79JsdVSZvdfM3LTy8nsudJDwa2niGAErfPUQi+Q4CU+FC8Rm+tzmA==", null, false, "b93d5d33-9c8b-4207-afa8-39abb454eaa8", false, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(4755), "admin" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "ConsultantId", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5363), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5364) },
                    { 2, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5369), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5373) },
                    { 3, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5385), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5386) },
                    { 4, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5387), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5388) },
                    { 5, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5389), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5390) },
                    { 6, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5393), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5394) },
                    { 7, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5395), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5396) },
                    { 8, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5397), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5398) },
                    { 9, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5399), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5400) },
                    { 10, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5403), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5404) },
                    { 11, null, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5405), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5406) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "3ee5e687-3a26-4f1b-9a40-10bad3e75419" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "5d2f0c4c-91b8-4d19-b768-28d53b500683" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "6992bbea-a922-4cab-b8e0-b2d2bdcd1afc" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "69afb770-d3ab-46c6-9d20-8503ad5e48ee" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "7f3edf88-2b2d-4048-ab60-e05be8d14aac" },
                    { "475521ed-2cba-4da4-9b88-b166f5966f55", "880cefef-3a03-4c56-b7a6-1b3bdefc4515" },
                    { "475521ed-2cba-4da4-9b88-b166f5966f55", "8f2a5636-607a-4879-b349-45533acb52ff" },
                    { "475521ed-2cba-4da4-9b88-b166f5966f55", "967f829a-2d6f-4d11-8a4b-e6fb34cc04d4" },
                    { "475521ed-2cba-4da4-9b88-b166f5966f55", "96c9641e-24ac-41ed-a72d-46b814b945b7" },
                    { "475521ed-2cba-4da4-9b88-b166f5966f55", "a1c135c1-04b5-4d40-b388-394ac4778a19" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "a950a3d8-d54c-48cc-9168-2cb9baaa8783" },
                    { "32f68bf3-5b3c-48ee-b9bd-4fc560d00a3a", "deedc854-e16b-4fc8-8271-9202b28f2308" },
                    { "11ad09bb-1078-4882-9c50-a537a254dc9c", "fde1f674-50c4-41f2-a034-d05b278e2644" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "CreatedTime", "JobTitle", "Promotion", "UpdatedTime", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5497), "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5498), "a950a3d8-d54c-48cc-9168-2cb9baaa8783", 100m },
                    { 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5507), "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5508), "6992bbea-a922-4cab-b8e0-b2d2bdcd1afc", 100m },
                    { 3, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5511), "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5512), "5d2f0c4c-91b8-4d19-b768-28d53b500683", 100m },
                    { 4, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5515), "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5515), "7f3edf88-2b2d-4048-ab60-e05be8d14aac", 100m },
                    { 5, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5519), "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5519), "3ee5e687-3a26-4f1b-9a40-10bad3e75419", 100m },
                    { 6, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5523), "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5524), "69afb770-d3ab-46c6-9d20-8503ad5e48ee", 100m },
                    { 7, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5527), "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5528), "deedc854-e16b-4fc8-8271-9202b28f2308", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5443), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5444), "a1c135c1-04b5-4d40-b388-394ac4778a19" },
                    { 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5452), "967f829a-2d6f-4d11-8a4b-e6fb34cc04d4" },
                    { 3, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5455), "8f2a5636-607a-4879-b349-45533acb52ff" },
                    { 4, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5458), "96c9641e-24ac-41ed-a72d-46b814b945b7" },
                    { 5, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5460), "880cefef-3a03-4c56-b7a6-1b3bdefc4515" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5906), "1.jpg", "fde1f674-50c4-41f2-a034-d05b278e2644" },
                    { 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5913), "2.jpg", "a950a3d8-d54c-48cc-9168-2cb9baaa8783" },
                    { 3, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5916), "3.jpg", "6992bbea-a922-4cab-b8e0-b2d2bdcd1afc" },
                    { 4, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5919), "4.jpg", "5d2f0c4c-91b8-4d19-b768-28d53b500683" },
                    { 5, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5922), "5.jpg", "7f3edf88-2b2d-4048-ab60-e05be8d14aac" },
                    { 6, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5933), "6.jpg", "3ee5e687-3a26-4f1b-9a40-10bad3e75419" },
                    { 7, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5936), "7.jpg", "69afb770-d3ab-46c6-9d20-8503ad5e48ee" },
                    { 8, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5939), "8.jpg", "deedc854-e16b-4fc8-8271-9202b28f2308" },
                    { 9, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5941), "9.jpg", "a1c135c1-04b5-4d40-b388-394ac4778a19" },
                    { 10, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5945), "10.jpg", "967f829a-2d6f-4d11-8a4b-e6fb34cc04d4" },
                    { 11, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5948), "11.jpg", "8f2a5636-607a-4879-b349-45533acb52ff" },
                    { 12, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5951), "12.jpg", "96c9641e-24ac-41ed-a72d-46b814b945b7" },
                    { 13, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5954), "13.jpg", "880cefef-3a03-4c56-b7a6-1b3bdefc4515" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5747), "Amerikan Psikoloji Derneği", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5748) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5753), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5754) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5756), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5756) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5758), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5759) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5765), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5766) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5768), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5769) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5771), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5771) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5773), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5774) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5777), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5778) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5780), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5780) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5761), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5762) }
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
                    { 1, 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5568), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5569) },
                    { 2, 2, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5574), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5575) },
                    { 3, 3, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5577), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5578) },
                    { 4, 4, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5580), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5581) },
                    { 5, 5, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5584), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5585) },
                    { 6, 6, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5588), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5589) },
                    { 7, 7, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5591), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5592) },
                    { 8, 1, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5595), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5596) },
                    { 9, 3, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5599), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5600) },
                    { 10, 7, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5603), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5604) },
                    { 11, 5, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5607), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 4, 17, 15, 34, 37, 426, DateTimeKind.Local).AddTicks(5608) }
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
