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
                name: "WorkingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hour = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingHours", x => x.Id);
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
                name: "Availables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConsultantId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    WorkingHoursId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availables_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Availables_WorkingHours_WorkingHoursId",
                        column: x => x.WorkingHoursId,
                        principalTable: "WorkingHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
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
                    { "5764b7d0-abb9-45b5-853e-1feb1f8afd78", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", null, "Danışanman", "Consultant", "CONSULTANT" },
                    { "c5d0125a-6b1b-44f0-b8f1-5df761b2fdad", null, "Yönetici", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "0199b3ad-9def-40f4-b963-38aa8f589b13", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "e524ef47-4c80-4ee2-9061-cb155c197155", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(775), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEMNsB63xM15LVdrJS5rqjLzZZRFLZpfyQOg587GhGnSC/gmit9forSfnp6GuLNKxPg==", null, false, "1e7ae9da-8a75-4bd9-a2cf-5f743eba88a9", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(775), "deniz" },
                    { "12fbb621-20b4-46d6-a7d7-1decb47cb8d6", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "b43963f0-0981-4a4a-96c7-baf8cdef86f3", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(703), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEMX9Ez4hmpefCuLCqYT7jZlxiVVct9idGE93CnU9LhVntazVuZNAr/Cg3L3M2mSHFQ==", null, false, "01e2bf70-e354-466d-99c9-606244547eaa", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(704), "mehmetozkan" },
                    { "3325d6fb-f0c5-4658-a263-cd9ff59f2c9f", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "87ebdde2-dee6-43b7-a032-9bf8c6c8d1a9", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(820), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEOzPnoUAfn7+NAU7dOHRpwvCP5nxPZP7CaFp7VD1joryaKtkg0eaWOrMYGaX3y0EWQ==", null, false, "5f78056e-24e5-4a25-bb6b-da73bc8a989a", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(821), "melisozturk" },
                    { "53e24d2a-55f7-4c6e-9f77-97b91abd4240", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "3f339685-ae88-4707-a984-c4fa1b4737be", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(841), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAEF9mY+eJzESzSnHWGF2jeoiI5PCJbdpsfamDHXz/+lxNyQvESRmKd9m0NmzsCuU34Q==", null, false, "f5c80478-f493-49d6-b620-ccc816d6f7f5", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(842), "cansahin" },
                    { "64028b84-a9f4-4402-8fb2-ebde010aa9d5", 0, "Turan Cd. No:7 Bornova", "İzmir", "4895e840-b253-4631-89fa-48e6ed6dd718", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(762), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEMnLoQzSRCd+yHswFiLB0LSCEZtDe3lXpTjnW9AfgOaQojkRY7W4aXnUXrv+D1mjPA==", null, false, "2a1d57e4-0c99-4805-8fb1-eef066b4495e", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(763), "canergun" },
                    { "8a71d934-9e20-4cca-b36c-4a92479e7688", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "9add0682-4588-42c0-b5fd-ff1c509574a6", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(685), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAEPZIGgFUpSqlg+KW4astprrxjhY9LpyFKecp787ehvi6BciYjeg26S75nbXOXgA68g==", null, false, "45b09f61-6067-4acf-8c02-bd9bbe860863", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(686), "ayseyilmaz" },
                    { "8d510f94-282e-48a8-9d29-8417b1b92363", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "7ce3a88b-3ec6-457c-8f26-402de467cda0", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(731), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEJzZ3g09aNhYoB7yRevMcDqQ/tGFnEicObIRglpJALIgScLAob6stY+5FoJYG7Lq3Q==", null, false, "5f3184a2-f317-4aa3-aabb-a6d39272cb9d", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(732), "alidemir" },
                    { "9cc64765-4239-4c42-b17f-87990db646a2", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "cd5b7e7a-30a4-4727-9897-d2ad2cb385d8", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(647), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEFu5RrVGAGPjfAz7zu3egDOTYxnQp77xyASAsxatGgL2fmo3fT5gsBG3ToWVH5cMnA==", null, false, "b126afed-ba18-4fa2-8666-4788048cea46", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(662), "admin" },
                    { "cc01034f-bca2-400f-b85c-6b1e10c8ea03", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "ab979b58-4801-4b7a-9765-5f1605bb26ab", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(749), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEHKpuVXSAN37qEQf0nmY2fcTg21OmNwYSDKlNzeK9Pu1xsPjG6bbQkNkjf2sDhZJUw==", null, false, "48f235da-2783-4a7b-af85-db4af8ab38e3", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(750), "gizemaydin" },
                    { "d7eaffa1-5d36-48a1-b3ed-e3a792e9f403", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "ae1c8fa1-ab52-4423-b13d-340e398d6d4b", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(964), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAEOIkCInECYPimTjg2NZfkIr4izmx1EA7rtWQBJPARKdikEUHI2rYrf5kEHfrYFrC1g==", null, false, "7e0f64b7-f59e-4ea3-bcea-0f5af86056b4", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(965), "esraavci" },
                    { "d8a4ead4-ab81-48fe-b579-cee04873290e", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "ae3dfd23-9941-401c-a2dc-bf45ad23ad59", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(717), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAELtsbSq2cQwQsBNcEGF81Vhj+yybvV/hgojKhxXlHCyT7boLdUv9m/khN8IPqmoQaA==", null, false, "422dd896-e6cb-4455-a97a-4bdf7ef4ae99", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(718), "zeynepgunes" },
                    { "de075b3e-d5ed-4e01-924f-d512677385a7", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "35890e79-a75c-40f0-a95b-d7ccb9b908dd", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(790), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEBhrNS1kIuhrizKyqq8mZChgOW74GR6q5ReShr61tKCWTmAG83t6MEXYScpmitrZ2w==", null, false, "e0f8e832-676f-4505-a880-16f42cec1cdc", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(791), "aliyildirim" },
                    { "e22c0505-5996-47c6-a11d-3a88d7fc9385", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "c9570a0e-5fc9-4c88-8789-4c7bb4d9648b", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(977), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAEFqDzC4/1+Mma1nxJqg8J/mpm3kHOWlvTgktJeSbfrj2R//oEZwJ+xikph/BxIU+4Q==", null, false, "933de0de-d507-43d8-9bf5-bf903fdc5b59", false, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(978), "fatmakara" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1257), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1260) },
                    { 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1263), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1269) },
                    { 3, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1287), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1287) },
                    { 4, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1289), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1290) },
                    { 5, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1292), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1293) },
                    { 6, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1296), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1297) },
                    { 7, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1298), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1299) },
                    { 8, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1301), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1301) },
                    { 9, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1303), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1304) },
                    { 10, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1307), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1307) },
                    { 11, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1309), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1310) }
                });

            migrationBuilder.InsertData(
                table: "WorkingHours",
                columns: new[] { "Id", "Hour" },
                values: new object[,]
                {
                    { 1, "00:00-01:00" },
                    { 2, "01:00-02:00" },
                    { 3, "02:00-03:00" },
                    { 4, "03:00-04:00" },
                    { 5, "04:00-05:00" },
                    { 6, "05:00-06:00" },
                    { 7, "06:00-07:00" },
                    { 8, "07:00-08:00" },
                    { 9, "08:00-09:00" },
                    { 10, "09:00-10:00" },
                    { 11, "10:00-11:00" },
                    { 12, "11:00-12:00" },
                    { 13, "12:00-13:00" },
                    { 14, "13:00-14:00" },
                    { 15, "14:00-15:00" },
                    { 16, "15:00-16:00" },
                    { 17, "16:00-17:00" },
                    { 18, "17:00-18:00" },
                    { 19, "18:00-19:00" },
                    { 20, "19:00-20:00" },
                    { 21, "20:00-21:00" },
                    { 22, "21:00-22:00" },
                    { 23, "22:00-23:00" },
                    { 24, "23:00-00:00" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "0199b3ad-9def-40f4-b963-38aa8f589b13" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "12fbb621-20b4-46d6-a7d7-1decb47cb8d6" },
                    { "5764b7d0-abb9-45b5-853e-1feb1f8afd78", "3325d6fb-f0c5-4658-a263-cd9ff59f2c9f" },
                    { "5764b7d0-abb9-45b5-853e-1feb1f8afd78", "53e24d2a-55f7-4c6e-9f77-97b91abd4240" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "64028b84-a9f4-4402-8fb2-ebde010aa9d5" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "8a71d934-9e20-4cca-b36c-4a92479e7688" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "8d510f94-282e-48a8-9d29-8417b1b92363" },
                    { "c5d0125a-6b1b-44f0-b8f1-5df761b2fdad", "9cc64765-4239-4c42-b17f-87990db646a2" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "cc01034f-bca2-400f-b85c-6b1e10c8ea03" },
                    { "5764b7d0-abb9-45b5-853e-1feb1f8afd78", "d7eaffa1-5d36-48a1-b3ed-e3a792e9f403" },
                    { "917dc531-7d54-4610-bbd8-ba19d58a3bc1", "d8a4ead4-ab81-48fe-b579-cee04873290e" },
                    { "5764b7d0-abb9-45b5-853e-1feb1f8afd78", "de075b3e-d5ed-4e01-924f-d512677385a7" },
                    { "5764b7d0-abb9-45b5-853e-1feb1f8afd78", "e22c0505-5996-47c6-a11d-3a88d7fc9385" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "Confirmation", "JobTitle", "Promotion", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, true, "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", "8a71d934-9e20-4cca-b36c-4a92479e7688", 250m },
                    { 2, true, "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", "12fbb621-20b4-46d6-a7d7-1decb47cb8d6", 100m },
                    { 3, true, "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", "d8a4ead4-ab81-48fe-b579-cee04873290e", 100m },
                    { 4, true, "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", "8d510f94-282e-48a8-9d29-8417b1b92363", 100m },
                    { 5, true, "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", "cc01034f-bca2-400f-b85c-6b1e10c8ea03", 100m },
                    { 6, true, "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", "64028b84-a9f4-4402-8fb2-ebde010aa9d5", 100m },
                    { 7, true, "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", "0199b3ad-9def-40f4-b963-38aa8f589b13", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "de075b3e-d5ed-4e01-924f-d512677385a7" },
                    { 2, "3325d6fb-f0c5-4658-a263-cd9ff59f2c9f" },
                    { 3, "53e24d2a-55f7-4c6e-9f77-97b91abd4240" },
                    { 4, "d7eaffa1-5d36-48a1-b3ed-e3a792e9f403" },
                    { 5, "e22c0505-5996-47c6-a11d-3a88d7fc9385" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2008), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2011), "1.jpg", "9cc64765-4239-4c42-b17f-87990db646a2" },
                    { 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2018), "2.jpg", "8a71d934-9e20-4cca-b36c-4a92479e7688" },
                    { 3, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2020), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2021), "3.jpg", "12fbb621-20b4-46d6-a7d7-1decb47cb8d6" },
                    { 4, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2023), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2024), "4.jpg", "d8a4ead4-ab81-48fe-b579-cee04873290e" },
                    { 5, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2026), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2027), "5.jpg", "8d510f94-282e-48a8-9d29-8417b1b92363" },
                    { 6, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2037), "6.jpg", "cc01034f-bca2-400f-b85c-6b1e10c8ea03" },
                    { 7, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2040), "7.jpg", "64028b84-a9f4-4402-8fb2-ebde010aa9d5" },
                    { 8, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2042), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2043), "8.jpg", "0199b3ad-9def-40f4-b963-38aa8f589b13" },
                    { 9, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2045), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2046), "9.jpg", "de075b3e-d5ed-4e01-924f-d512677385a7" },
                    { 10, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2049), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2050), "10.jpg", "3325d6fb-f0c5-4658-a263-cd9ff59f2c9f" },
                    { 11, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2053), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2053), "11.jpg", "53e24d2a-55f7-4c6e-9f77-97b91abd4240" },
                    { 12, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2057), "12.jpg", "d7eaffa1-5d36-48a1-b3ed-e3a792e9f403" },
                    { 13, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(2060), "13.jpg", "e22c0505-5996-47c6-a11d-3a88d7fc9385" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentState", "AppointmentTime", "ConsultantId", "CreatedTime", "CustomerId", "Price", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 1, 1), 1, "10:00-11:00", 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1594), 1, 200m, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1595) },
                    { 2, new DateOnly(2023, 1, 1), 2, "13:00-14:00", 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1602), 2, 200m, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1603) },
                    { 3, new DateOnly(2023, 5, 20), 0, "15:00-16:00", 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1607), 3, 0m, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1608) },
                    { 4, new DateOnly(2023, 5, 25), 3, "18:00-19:00", 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1610), 4, 0m, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1611) }
                });

            migrationBuilder.InsertData(
                table: "Availables",
                columns: new[] { "Id", "ConsultantId", "CreatedTime", "Date", "UpdatedTime", "WorkingHoursId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1468), new DateOnly(2023, 5, 15), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1469), 15 },
                    { 2, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1475), new DateOnly(2023, 5, 16), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1476), 20 },
                    { 3, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1478), new DateOnly(2023, 5, 17), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1479), 16 },
                    { 4, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1481), new DateOnly(2023, 5, 22), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1482), 13 },
                    { 5, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1484), new DateOnly(2023, 5, 22), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1485), 14 },
                    { 6, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1489), new DateOnly(2023, 5, 22), new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1489), 15 }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1775), "Amerikan Psikoloji Derneği", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1776) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1780), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1781) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1783), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1784) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1786), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1787) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1793), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1794) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1795), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1796) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1798), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1799) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1801), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1802) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1805), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1806) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1808), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1808) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1789), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1789) }
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
                    { 1, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1649), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1652) },
                    { 2, 2, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1656), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1657) },
                    { 3, 3, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1659), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1660) },
                    { 4, 4, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1662), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1663) },
                    { 5, 5, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1665), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1666) },
                    { 6, 6, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1670), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1670) },
                    { 7, 7, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1673), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1674) },
                    { 8, 1, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1676), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1677) },
                    { 9, 3, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1679), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1680) },
                    { 10, 7, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1683), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1684) },
                    { 11, 5, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1687), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 5, 11, 0, 7, 2, 323, DateTimeKind.Local).AddTicks(1687) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ConsultantId",
                table: "Appointments",
                column: "ConsultantId");

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
                name: "IX_Availables_ConsultantId",
                table: "Availables",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Availables_WorkingHoursId",
                table: "Availables",
                column: "WorkingHoursId");

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
                name: "Availables");

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
                name: "WorkingHours");

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
