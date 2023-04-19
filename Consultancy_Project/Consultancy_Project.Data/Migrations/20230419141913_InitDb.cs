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
                    { "0bf85f80-8aa1-4284-82db-6bdd536a2e86", null, "Yönetici", "Admin", "ADMIN" },
                    { "6ad5acb5-2df8-4e44-81fb-6069c19ff853", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", null, "Danışanman", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "0c566017-e3dc-4aca-8d38-742d962f503a", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "7f61e336-5bba-4767-97ad-c29c8306a75c", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4223), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEFrx/0YlDe8Qcbmz1pRNEnlY6GyZC9mr7jNzvrVIm4MWgYe4JGZUQCBenjj+cBd7Sw==", null, false, "19d4757e-3d22-47e9-8611-e0efdac1df86", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4238), "admin" },
                    { "0c7d89a7-a1df-44f0-a021-a142bd2dbfa4", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "f266da7e-5a05-4963-95ac-0c724c3b66f2", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4642), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEKs9YI+WwtC1ALmkt4JcUuxL8gPUTlvE0EhiCPZPa0o7TDrp7rZmU7P5H/+4fK7EgA==", null, false, "3e7e0850-37d9-4f80-bd63-49f6d450b01d", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4643), "esraavci" },
                    { "21cf4c10-162f-43f9-8f7a-75796eb62cb4", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "2f90e6a7-fdb6-42ed-9e97-fdf240629120", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4366), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAENk505QniKCrWYldkTNpGitJfvgjeOqvVUp0D4UkDSfC6PGpKai1r9f04UTqrzfYTw==", null, false, "b3c7fd5b-12b5-456f-95aa-18fae4ecc4f9", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4367), "gizemaydin" },
                    { "259f82c1-b0af-493b-857b-16ba7d273f7b", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "2098ea9f-5e46-4ac4-a405-22b4ce44beeb", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4398), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEFZKbgdwAybPxypIoyc9Oy7ap3n2W5Ti2LmjD82T+J85S4cHCDqprFilrC661xIYZg==", null, false, "f720e521-5192-42f0-8cb1-6674e2b0ce29", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4399), "deniz" },
                    { "38346e1e-9715-4ecf-abc0-cb4a55511594", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "320b3a7b-1abb-47e4-aa78-053309d5eb9d", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4450), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAENtfdFjNRATzzSla5zxXCYrbBfqGmI7iS9gSmr6cWYWT1bDKBvDF1my9BJ4QwqjywA==", null, false, "48c02e26-22d7-4345-b5a8-6d0c924fc09b", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4451), "melisozturk" },
                    { "3fd9d087-584a-4d0e-8dc5-9576b75a60df", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "801337d5-a540-4019-935f-cd6ce0427b52", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4329), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAENg+bgnPempdnAC3gCzbgKH14gXijyUBiWqttTMbB+PaQhhcPHhsziRZkNiM31mKhw==", null, false, "6e61cfd2-07d3-4174-980c-3e5f7af4c26e", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4329), "zeynepgunes" },
                    { "40c67e4f-af51-4e89-87f7-5cdfaab0fe2c", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "8f2cf075-2048-42d9-a782-04f654023818", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4662), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAEIwn3zhxSwB3hI3tCY17TZR/xWjWagCCqkv1BixrIOoFEZqQG2skk6QUJe82yT1W7Q==", null, false, "017bceeb-8621-4ae1-ac57-a469345b1a47", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4663), "fatmakara" },
                    { "5d160224-35b5-44da-aa43-5e80aef0e972", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "136a7ff8-9e2f-4fb6-9b30-dbe820018706", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4346), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAED2s3rOFSl4dOvw5YkVsK7rosjDzcJ4cMgvotKO8FguiYDnoEr4HxSo3xHuLeQCHfw==", null, false, "a94eaf62-5ebd-448b-90a8-920179c68e0f", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4347), "alidemir" },
                    { "63c318f9-4d11-4bd0-bb0b-9f322b0a64b5", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "3c67e40e-be61-4eba-86c4-629a94acb4ac", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4470), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAEKGYacynp6xL11LXWRaI+2lt1IbO0hlUR0Ktqh6gMpVIMo5cS7nXNgvXODfXUK9buA==", null, false, "3d373d97-fec8-4347-85a2-af96835b69da", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4471), "cansahin" },
                    { "b8e3dacd-30b8-46ea-90b3-1412459ec7f5", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "b8dac4e2-2fda-44d3-8abf-ea996e264636", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4413), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEHuBIB6odSBdKhkMOjSCZVj0X/3RT3HtqAN0F66mk94Z0/5DartRWCESbf8MUSAaSw==", null, false, "0ee4a45d-a4b1-4e28-bc07-78c16685f708", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4414), "aliyildirim" },
                    { "cf880548-9deb-46d6-9004-216654ddd651", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "4f06b641-810e-48f6-bd82-7429e77c8ef3", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4311), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEFUybzntySDE1DCNUBFg83srGH/vn87qeSxrYx4fKk0ZlMR+mHhcFOzMyX+CJF22uQ==", null, false, "27f820c3-284a-4bb6-9b8b-688afd6d98e7", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4312), "mehmetozkan" },
                    { "d89001b9-dcd1-45e3-a98c-6bec5c05b3e3", 0, "Turan Cd. No:7 Bornova", "İzmir", "17440cfc-8bc3-42d3-9c0d-7201d80e3fce", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4381), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEODheUt4LSBVF//GZk15sh9Yu7diJ+NIDYuMYpLvWtDDQAmOz8aZ7CyJf9pefHIpVQ==", null, false, "a83214a9-e523-4667-a197-301958898112", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4381), "canergun" },
                    { "db371fc7-33ca-4a38-b8cf-959905d73b34", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "7cf221f7-321b-4699-8b98-cea55cb0c569", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4277), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAECNacWqdtwn4ab07ESiBRK18zVom3e2dfCaN/3UKgUf+v+RDiBFJ1HHVxcz3H6ixqQ==", null, false, "5d065bc1-9175-4ba0-a329-f65b2d0e6704", false, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(4278), "ayseyilmaz" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "ConsultantId", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5227), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5231) },
                    { 2, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5236), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5244) },
                    { 3, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5258), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5259) },
                    { 4, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5261), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5262) },
                    { 5, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5264), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5266) },
                    { 6, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5270), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5271) },
                    { 7, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5273), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5274) },
                    { 8, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5276), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5276) },
                    { 9, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5278), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5280) },
                    { 10, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5285), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5285) },
                    { 11, null, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5288), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5289) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0bf85f80-8aa1-4284-82db-6bdd536a2e86", "0c566017-e3dc-4aca-8d38-742d962f503a" },
                    { "6ad5acb5-2df8-4e44-81fb-6069c19ff853", "0c7d89a7-a1df-44f0-a021-a142bd2dbfa4" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "21cf4c10-162f-43f9-8f7a-75796eb62cb4" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "259f82c1-b0af-493b-857b-16ba7d273f7b" },
                    { "6ad5acb5-2df8-4e44-81fb-6069c19ff853", "38346e1e-9715-4ecf-abc0-cb4a55511594" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "3fd9d087-584a-4d0e-8dc5-9576b75a60df" },
                    { "6ad5acb5-2df8-4e44-81fb-6069c19ff853", "40c67e4f-af51-4e89-87f7-5cdfaab0fe2c" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "5d160224-35b5-44da-aa43-5e80aef0e972" },
                    { "6ad5acb5-2df8-4e44-81fb-6069c19ff853", "63c318f9-4d11-4bd0-bb0b-9f322b0a64b5" },
                    { "6ad5acb5-2df8-4e44-81fb-6069c19ff853", "b8e3dacd-30b8-46ea-90b3-1412459ec7f5" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "cf880548-9deb-46d6-9004-216654ddd651" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "d89001b9-dcd1-45e3-a98c-6bec5c05b3e3" },
                    { "a418e4a1-7041-4037-88f0-0f12019fdb66", "db371fc7-33ca-4a38-b8cf-959905d73b34" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "CreatedTime", "JobTitle", "Promotion", "UpdatedTime", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5415), "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5417), "db371fc7-33ca-4a38-b8cf-959905d73b34", 100m },
                    { 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5428), "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5429), "cf880548-9deb-46d6-9004-216654ddd651", 100m },
                    { 3, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5432), "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5433), "3fd9d087-584a-4d0e-8dc5-9576b75a60df", 100m },
                    { 4, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5436), "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5437), "5d160224-35b5-44da-aa43-5e80aef0e972", 100m },
                    { 5, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5440), "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5441), "21cf4c10-162f-43f9-8f7a-75796eb62cb4", 100m },
                    { 6, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5446), "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5447), "d89001b9-dcd1-45e3-a98c-6bec5c05b3e3", 100m },
                    { 7, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5450), "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5451), "259f82c1-b0af-493b-857b-16ba7d273f7b", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5344), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5345), "b8e3dacd-30b8-46ea-90b3-1412459ec7f5" },
                    { 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5351), "38346e1e-9715-4ecf-abc0-cb4a55511594" },
                    { 3, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5354), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5355), "63c318f9-4d11-4bd0-bb0b-9f322b0a64b5" },
                    { 4, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5358), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5359), "0c7d89a7-a1df-44f0-a021-a142bd2dbfa4" },
                    { 5, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5362), "40c67e4f-af51-4e89-87f7-5cdfaab0fe2c" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5981), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5983), "1.jpg", "0c566017-e3dc-4aca-8d38-742d962f503a" },
                    { 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5990), "2.jpg", "db371fc7-33ca-4a38-b8cf-959905d73b34" },
                    { 3, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5993), "3.jpg", "cf880548-9deb-46d6-9004-216654ddd651" },
                    { 4, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5997), "4.jpg", "3fd9d087-584a-4d0e-8dc5-9576b75a60df" },
                    { 5, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6000), "5.jpg", "5d160224-35b5-44da-aa43-5e80aef0e972" },
                    { 6, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6011), "6.jpg", "21cf4c10-162f-43f9-8f7a-75796eb62cb4" },
                    { 7, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6015), "7.jpg", "d89001b9-dcd1-45e3-a98c-6bec5c05b3e3" },
                    { 8, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6018), "8.jpg", "259f82c1-b0af-493b-857b-16ba7d273f7b" },
                    { 9, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6021), "9.jpg", "b8e3dacd-30b8-46ea-90b3-1412459ec7f5" },
                    { 10, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6026), "10.jpg", "38346e1e-9715-4ecf-abc0-cb4a55511594" },
                    { 11, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6029), "11.jpg", "63c318f9-4d11-4bd0-bb0b-9f322b0a64b5" },
                    { 12, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6032), "12.jpg", "0c7d89a7-a1df-44f0-a021-a142bd2dbfa4" },
                    { 13, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(6035), "13.jpg", "40c67e4f-af51-4e89-87f7-5cdfaab0fe2c" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5729), "Amerikan Psikoloji Derneği", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5731) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5737), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5739) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5741), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5742) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5744), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5745) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5751), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5752) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5754), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5755) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5758), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5759) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5761), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5762) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5766), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5766) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5769), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5769) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5747), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5748) }
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
                    { 1, 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5507), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5508) },
                    { 2, 2, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5514), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5515) },
                    { 3, 3, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5577), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5579) },
                    { 4, 4, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5581), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5582) },
                    { 5, 5, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5585), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5586) },
                    { 6, 6, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5591), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5591) },
                    { 7, 7, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5594), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5595) },
                    { 8, 1, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5598), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5598) },
                    { 9, 3, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5601), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5602) },
                    { 10, 7, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5607), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5608) },
                    { 11, 5, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5610), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 4, 19, 17, 19, 11, 324, DateTimeKind.Local).AddTicks(5611) }
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
