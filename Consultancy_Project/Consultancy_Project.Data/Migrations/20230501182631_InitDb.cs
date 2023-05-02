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
                    { "466ca290-6760-4ca8-a512-47b62e5ac2f6", null, "Yönetici", "Admin", "ADMIN" },
                    { "ab4f1221-f5ec-4aaf-8855-ec3837b7ed5e", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", null, "Danışanman", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "213f5bf5-06e9-4be5-ab0a-61feb5350a5c", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "e41041c7-bfe1-4998-af88-6cf40cea7268", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9048), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAEEpQhnuKqOZZiK8ZO47kzAyi5maM4nn3bZns2hFdQaIEYl/NwMQqTyKRuGCUwoEQbg==", null, false, "ec5c6dfb-ddb1-45ad-b194-35e5dfe718c1", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9052), "fatmakara" },
                    { "299044fb-191d-4c72-a529-92e2b513730c", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "64a9af37-4f9e-4478-95bc-89f78b71c94a", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8925), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEE+OSZalucTyRexRwqxx8LXfVic4r7TIZ/oPfsTm3dn+jNwX5k76TLhQ5BX6UR5wew==", null, false, "fe05b625-e519-4caf-894e-3e7485bde43b", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8926), "aliyildirim" },
                    { "2d312aea-02f1-46be-8734-ba98b98a3331", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "a915e120-1459-40b4-9689-50ce3664bb16", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8981), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAEAJ0R+EJ522oXpGooyM8yOIHB+DygyG5UZXJ031d8mXL7R0w1li8tTMt1H0BSu3Qbw==", null, false, "01ea7498-518f-489c-96be-96b27e554378", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8982), "cansahin" },
                    { "44180815-7620-476f-a4d2-1659b840c14f", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "37c55c40-62f4-46dd-adce-d5b1cc09ed93", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8851), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAEEdWen6FDXVcbcbnOWX2aTE7YjE3b7Uif5ruaJEdkzCw/zrobYOfwGmf/ecCMOb3NQ==", null, false, "bff1f139-bf17-45ca-be5a-7e0362f1a9e8", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8852), "zeynepgunes" },
                    { "4af08614-6b74-49ad-899d-35691452cab4", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "56e1b6dd-b035-4625-96a6-35bfd0ee360f", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8959), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEDU9pS3hGkOz3Ptz2hkjuZ3K6bHCQ7HCtGwXq0JC8l1u4YhbUqjK18pgW8yKttdKeA==", null, false, "9bd3eb85-6fd2-4c9f-ad0d-0342161c82bf", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8960), "melisozturk" },
                    { "5f382ac2-9935-4b4e-b6c4-5429069869aa", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "d4e6b629-1b66-418a-b4a1-292a473a7854", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8911), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEJ2nW2dcrks3s18E8bmNCBTgmK0N+EnSMPCCQC89zC6JF9udrHjJbN/CSFm0sjXdBg==", null, false, "cada29e0-be5a-4df4-a07a-666f57983a7e", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8912), "deniz" },
                    { "5fbe203c-e93a-4090-bb00-9515d8d5a4b8", 0, "Turan Cd. No:7 Bornova", "İzmir", "e24b3072-7b64-4cb9-9ab9-97a5dde3bf7d", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8899), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEK7B0iJ0X3HAPee8QHyIfoGryr9nznp1kLNupnTAFXxLyt2mzNJwjHDrKnSE5EwZ2Q==", null, false, "0f13465c-6027-461e-9e4d-d29c7de5ab5f", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8900), "canergun" },
                    { "69e298b9-82ac-48e6-a43d-ce59f8cb7660", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "9d8028b0-7da5-4488-a978-ed266e79a3e3", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8760), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEAflXVuJPykUJ/Ffs+7OLEYeA06JNbjh1plFX8B7LfhiFJyh/mxqZeDq5DiWNtjbtg==", null, false, "b6e44f9b-df44-4c4e-8b9c-0fd6a369c6d5", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8774), "admin" },
                    { "8c99b3cb-b89a-4e02-ae81-9153682ea88e", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "e4bc10d1-278e-4d3c-b204-b2070efaaeef", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8999), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAENvQ7TZGYK2VhmgGTuL58nNyg3jJAU3N7GY7JFBbJIQBE5U4n2GQTHHNsem3Q4dNUQ==", null, false, "a7bfa04d-aeb9-4beb-b6c3-a18c1d5d634a", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9000), "esraavci" },
                    { "987ea5c3-c11e-43f5-a263-e38be560425e", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "be16c2c3-5a33-48d8-ae5b-1167a5a2d0ba", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8883), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEECNveaBGeaMMQSZTMi/DyDnKrt4SUzVobCVt7lvbklSEf1bjIn7s1XJpr5GDJXGxA==", null, false, "a6961edc-aafa-4f3d-ac77-c73cedfa2282", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8884), "gizemaydin" },
                    { "a06a802f-75d2-43e3-bd20-c0f7e4bece63", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "7c2a5070-5479-47c4-9666-48754835107f", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8824), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAENx3Zmu4Ir4FPPAHsgfWFiSxY4+860S/aHrFqp/aCUI1jOhet9jSOuYjgXSjlx8TLA==", null, false, "7120d208-f79d-43b9-98ba-eaacdc96e50c", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8825), "ayseyilmaz" },
                    { "aed1901a-a771-4d58-b361-66abf4458e1d", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "db7683de-22b6-484f-9cfd-b9509e0abaca", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8838), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEJN9fCgenQ6MjdToZ9iMkxB//ECuL32X3bvwCgpPDUzN4CWhEIfNL1AM3JZIq/XwwQ==", null, false, "2e1332d0-e605-4708-b54c-95256e4536bd", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8839), "mehmetozkan" },
                    { "ed879df0-576c-4223-86b8-ab542ec21858", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "78a09f68-f921-4646-ae62-dfe9c25d09e9", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8867), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEI8zDCD2fxVEbozLL7BYfnriWwQ33IldMPEeeqz8KBltnS3WZesZBVZP3bc4P24T0g==", null, false, "b031f88a-63bd-422a-a6d7-447701ed1081", false, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(8868), "alidemir" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9791), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9797) },
                    { 2, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9800), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9804) },
                    { 3, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9823), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9824) },
                    { 4, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9825), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9826) },
                    { 5, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9828), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9828) },
                    { 6, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9832), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9832) },
                    { 7, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9834), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9835) },
                    { 8, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9836), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9837) },
                    { 9, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9839), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9839) },
                    { 10, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9842), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9843) },
                    { 11, new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9844), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 5, 1, 21, 26, 28, 754, DateTimeKind.Local).AddTicks(9845) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ab4f1221-f5ec-4aaf-8855-ec3837b7ed5e", "213f5bf5-06e9-4be5-ab0a-61feb5350a5c" },
                    { "ab4f1221-f5ec-4aaf-8855-ec3837b7ed5e", "299044fb-191d-4c72-a529-92e2b513730c" },
                    { "ab4f1221-f5ec-4aaf-8855-ec3837b7ed5e", "2d312aea-02f1-46be-8734-ba98b98a3331" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "44180815-7620-476f-a4d2-1659b840c14f" },
                    { "ab4f1221-f5ec-4aaf-8855-ec3837b7ed5e", "4af08614-6b74-49ad-899d-35691452cab4" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "5f382ac2-9935-4b4e-b6c4-5429069869aa" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "5fbe203c-e93a-4090-bb00-9515d8d5a4b8" },
                    { "466ca290-6760-4ca8-a512-47b62e5ac2f6", "69e298b9-82ac-48e6-a43d-ce59f8cb7660" },
                    { "ab4f1221-f5ec-4aaf-8855-ec3837b7ed5e", "8c99b3cb-b89a-4e02-ae81-9153682ea88e" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "987ea5c3-c11e-43f5-a263-e38be560425e" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "a06a802f-75d2-43e3-bd20-c0f7e4bece63" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "aed1901a-a771-4d58-b361-66abf4458e1d" },
                    { "c689d395-7fcd-437d-98fd-246dca4f0965", "ed879df0-576c-4223-86b8-ab542ec21858" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "JobTitle", "Promotion", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", "a06a802f-75d2-43e3-bd20-c0f7e4bece63", 100m },
                    { 2, "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", "aed1901a-a771-4d58-b361-66abf4458e1d", 100m },
                    { 3, "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", "44180815-7620-476f-a4d2-1659b840c14f", 100m },
                    { 4, "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", "ed879df0-576c-4223-86b8-ab542ec21858", 100m },
                    { 5, "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", "987ea5c3-c11e-43f5-a263-e38be560425e", 100m },
                    { 6, "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", "5fbe203c-e93a-4090-bb00-9515d8d5a4b8", 100m },
                    { 7, "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", "5f382ac2-9935-4b4e-b6c4-5429069869aa", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "299044fb-191d-4c72-a529-92e2b513730c" },
                    { 2, "4af08614-6b74-49ad-899d-35691452cab4" },
                    { 3, "2d312aea-02f1-46be-8734-ba98b98a3331" },
                    { 4, "8c99b3cb-b89a-4e02-ae81-9153682ea88e" },
                    { 5, "213f5bf5-06e9-4be5-ab0a-61feb5350a5c" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(351), "1.jpg", "69e298b9-82ac-48e6-a43d-ce59f8cb7660" },
                    { 2, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(357), "2.jpg", "a06a802f-75d2-43e3-bd20-c0f7e4bece63" },
                    { 3, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(360), "3.jpg", "aed1901a-a771-4d58-b361-66abf4458e1d" },
                    { 4, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(363), "4.jpg", "44180815-7620-476f-a4d2-1659b840c14f" },
                    { 5, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(367), "5.jpg", "ed879df0-576c-4223-86b8-ab542ec21858" },
                    { 6, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(380), "6.jpg", "987ea5c3-c11e-43f5-a263-e38be560425e" },
                    { 7, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(383), "7.jpg", "5fbe203c-e93a-4090-bb00-9515d8d5a4b8" },
                    { 8, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(386), "8.jpg", "5f382ac2-9935-4b4e-b6c4-5429069869aa" },
                    { 9, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(388), "9.jpg", "299044fb-191d-4c72-a529-92e2b513730c" },
                    { 10, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(391), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(392), "10.jpg", "4af08614-6b74-49ad-899d-35691452cab4" },
                    { 11, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(395), "11.jpg", "2d312aea-02f1-46be-8734-ba98b98a3331" },
                    { 12, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(397), "12.jpg", "8c99b3cb-b89a-4e02-ae81-9153682ea88e" },
                    { 13, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(400), "13.jpg", "213f5bf5-06e9-4be5-ab0a-61feb5350a5c" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(128), "Amerikan Psikoloji Derneği", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(130) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(134), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(135) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(137), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(137) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(198), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(199) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(206), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(206) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(210), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(210) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(212), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(213) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(215), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(215) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(219), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(220) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(222), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(222) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(201), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(201) }
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
                    { 1, 1, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(2), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(3) },
                    { 2, 2, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(8), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(9) },
                    { 3, 3, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(11), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(12) },
                    { 4, 4, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(14), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(15) },
                    { 5, 5, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(17), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(18) },
                    { 6, 6, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(21), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(22) },
                    { 7, 7, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(24), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(25) },
                    { 8, 1, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(28), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(28) },
                    { 9, 3, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(31), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(31) },
                    { 10, 7, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(35), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(36) },
                    { 11, 5, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(38), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 5, 1, 21, 26, 28, 755, DateTimeKind.Local).AddTicks(39) }
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
