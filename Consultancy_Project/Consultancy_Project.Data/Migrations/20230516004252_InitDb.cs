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
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", null, "Danışanman", "Consultant", "CONSULTANT" },
                    { "a888d4f6-beb3-4775-9574-7833a3e5c4b1", null, "Kullanıcı", "Customer", "CUSTOMER" },
                    { "ae3523aa-4848-46d9-92ee-a061b2e1bb82", null, "Yönetici", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { "1d9038fa-5093-4d1d-bd35-054c55a60199", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "5758d5a0-0c2c-4ef8-a00a-f45cf1502099", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(767), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", "AQAAAAIAAYagAAAAEDblT86kxc5y9CAohvYcEKHuICx7EeWhWfGnvWach6CEx2un31dcRG6Qge/InJEawA==", null, false, "e5f3348d-764a-4db5-b9e6-2b9a35b26919", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(770), "mehmetozkan" },
                    { "422e96a8-1d24-495e-9610-4241e794ca6d", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "35b6113a-81eb-4c76-9ba9-a831e046fe39", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(932), new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", "AQAAAAIAAYagAAAAEPapm7BfhpWPbyl0s6eL0/epiUgjKCrhmbMyseXrz9plygodXMKpQTV+p3cUgMBc1Q==", null, false, "0b433d09-d65c-4a92-b4f8-c8e09b895edb", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(936), "gizemaydin" },
                    { "633c517c-d461-4627-b3a0-179c65f6626f", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "a2b6238b-db31-4b40-9080-78a420cc7c78", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(724), new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", "AQAAAAIAAYagAAAAEJFVN0L3dqUh1O5LNUutSGMBGDvD0/46erLJFoMyTugdUfxs+kRqFwR5HMmqSWhTHg==", null, false, "a784288f-34cf-43f2-853c-4d15a79d53ed", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(729), "ayseyilmaz" },
                    { "681b7b2d-0b42-424c-8871-61efaf4385bb", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "2b2c1429-e4d9-49b0-b670-958f5104bc70", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1189), new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", "AQAAAAIAAYagAAAAEOcYoPWqM6FSQKi+f4PFRCgR7BDnSSgfVfOQCc09AHZOqwLZ0E9bRScBDRRxAWG/Og==", null, false, "71815372-ffac-4ed7-9827-8ebb447d7da2", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1193), "fatmakara" },
                    { "700cc93a-e0dc-43f9-8bec-25d101f1aa07", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "be888c2f-45f6-474e-96a4-f0263a5de38a", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1103), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", "AQAAAAIAAYagAAAAECBXVVsiitH6sWRfT6c537F2xd7lPJlM80zOCgiy3J7Y+LiMGUEfRHQSAwNb23X6yg==", null, false, "696835b1-cc85-43d0-8147-d4035913b441", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1107), "cansahin" },
                    { "7e2035bc-412f-4d3e-aea5-e7ff5a406c1e", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "dd4b823c-5749-47b6-beed-6367c6348417", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1146), new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", "AQAAAAIAAYagAAAAELWA9kYzJYj8A6kPPiWq+Sh3yvqINYyadubJi/y/kQysGoADID7+TOotp2sjIrX3QA==", null, false, "14ffd567-54a9-41ff-b06f-d59cbddf68f9", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1150), "esraavci" },
                    { "8a4de71a-ab39-413f-82ba-7877977d2ffc", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "bbdb2921-f739-468c-a740-5278967661e4", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(908), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", "AQAAAAIAAYagAAAAEI9mfOEmO/37CU2wHuNAaAg07mZ0xNj6uQdKOh0WD0JDXe5vfiph8YYYR0L2Ng9qcg==", null, false, "f33a8585-efeb-43a0-8452-950ad66a70c3", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(909), "alidemir" },
                    { "8d0a5564-0390-4355-8534-9204be00a418", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "2215bb38-a980-4699-b475-e59db2726243", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1009), new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", "AQAAAAIAAYagAAAAEGwBSiSQXUpsIGrg9wZHPlo0Z9OU0kd8zqBRfkzLMlqg6JdeVSWazXbw82NsLo6Sdg==", null, false, "81ec875b-eb60-4bbd-8f32-bc5c6adfa3aa", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1010), "aliyildirim" },
                    { "ab0b4c71-84fd-4d50-bd32-26a7ebef9ef9", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "d57c0ebb-068a-42a6-bb5d-bbc3589b5f63", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1062), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", "AQAAAAIAAYagAAAAEFeyAU0t89jd/Iso0RVkxOC7jT4WUNwWorMYys3Tp7YDzuiuw9HQ6w7Ikic0hghsZg==", null, false, "b7458011-ab2a-40e7-a79e-dde59bc89f74", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1067), "melisozturk" },
                    { "ac1e2980-0bad-4e1e-9996-8311297248b7", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "379cd207-b213-4331-a0c1-c89f1b69ee80", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(989), new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", "AQAAAAIAAYagAAAAEF6kS25CrxHaXyvozSoIlUPejYJ2n5FscpmDvOaL9AjkUQzBTrLQBe3rZDU4h6aVyg==", null, false, "0f68d424-6874-4d6c-8d7e-1f3ccb5ccbce", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(993), "deniz" },
                    { "c2cbe566-1db4-4a5b-ada3-813e74ee2a38", 0, "Turan Cd. No:7 Bornova", "İzmir", "ff222348-6e31-4c17-84cb-21f8a6abc1ad", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(961), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", "AQAAAAIAAYagAAAAEAvQthxFjBwDqqAc+yz8BOZcHBY//h6zkzMIH7ibZfKtaFGWV0oLJq1OwwnRnYZQgA==", null, false, "bbbda6de-43e8-48ee-94a5-1912a0fe4fec", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(962), "canergun" },
                    { "ea14b91f-073e-41bd-b55b-9eb9b1471ac2", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "884d7054-1f91-477a-9edb-fcf2a5568cf8", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(654), new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", "AQAAAAIAAYagAAAAEAT8FXQ32yLl/4zYvfNLamnpWmPCoMORtoiZqFo6mYdDjHPRhgQNvKMDeReAeQD/9g==", null, false, "f6785924-b7d5-47ef-90cb-1d5e1ba53e86", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(668), "admin" },
                    { "fd9f764a-cc69-48c0-a20f-268305752050", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "87eccdbd-49fa-486f-8aab-a763df19f681", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(884), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", "AQAAAAIAAYagAAAAEKP1pJHQx+8HyFV6NDfnjYDbU2iF2lgIsdQJTbE+Se/PYOLN/SBbDFJtgCBlD1cWBQ==", null, false, "b5932a4f-8524-46fa-b3f7-cbae411e92eb", false, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(886), "zeynepgunes" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1988), "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak.", "Depresyon", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(1993) },
                    { 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2002), "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak.", "Kaygı Bozukluğu", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2148) },
                    { 3, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2167), "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Bağımlılık", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2170) },
                    { 4, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2175), "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Öfke Kontrolü", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2177) },
                    { 5, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2179), "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak.", "Aile Terapisi", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2180) },
                    { 6, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2190), "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak.", "Stres Yönetimi", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2193) },
                    { 7, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2195), "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak.", "Kişisel Gelişim", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2196) },
                    { 8, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2200), "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak.", "Cinsel Sorunlar", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2202) },
                    { 9, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2207), "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak.", "Çift Terapisi", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2209) },
                    { 10, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2215), "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak.", "Travma Sonrası Stres Bozukluğu", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2219) },
                    { 11, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2223), "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak.", "Yeme Bozuklukları", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2224) }
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
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "1d9038fa-5093-4d1d-bd35-054c55a60199" },
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "422e96a8-1d24-495e-9610-4241e794ca6d" },
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "633c517c-d461-4627-b3a0-179c65f6626f" },
                    { "a888d4f6-beb3-4775-9574-7833a3e5c4b1", "681b7b2d-0b42-424c-8871-61efaf4385bb" },
                    { "a888d4f6-beb3-4775-9574-7833a3e5c4b1", "700cc93a-e0dc-43f9-8bec-25d101f1aa07" },
                    { "a888d4f6-beb3-4775-9574-7833a3e5c4b1", "7e2035bc-412f-4d3e-aea5-e7ff5a406c1e" },
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "8a4de71a-ab39-413f-82ba-7877977d2ffc" },
                    { "a888d4f6-beb3-4775-9574-7833a3e5c4b1", "8d0a5564-0390-4355-8534-9204be00a418" },
                    { "a888d4f6-beb3-4775-9574-7833a3e5c4b1", "ab0b4c71-84fd-4d50-bd32-26a7ebef9ef9" },
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "ac1e2980-0bad-4e1e-9996-8311297248b7" },
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "c2cbe566-1db4-4a5b-ada3-813e74ee2a38" },
                    { "ae3523aa-4848-46d9-92ee-a061b2e1bb82", "ea14b91f-073e-41bd-b55b-9eb9b1471ac2" },
                    { "71ac5a8c-0d2f-41a3-949a-14793245a769", "fd9f764a-cc69-48c0-a20f-268305752050" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "Confirmation", "JobTitle", "Promotion", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, true, "Psikolojik Danışman", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "633c517c-d461-4627-b3a0-179c65f6626f", 250m },
                    { 2, true, "Klinik Psikolog", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "1d9038fa-5093-4d1d-bd35-054c55a60199", 100m },
                    { 3, true, "Psikolog", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "fd9f764a-cc69-48c0-a20f-268305752050", 100m },
                    { 4, true, "Psikolojik Danışman", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "8a4de71a-ab39-413f-82ba-7877977d2ffc", 100m },
                    { 5, true, "Psikolojik Danışman", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "422e96a8-1d24-495e-9610-4241e794ca6d", 100m },
                    { 6, true, "Psikolojik Danışman", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "c2cbe566-1db4-4a5b-ada3-813e74ee2a38", 100m },
                    { 7, true, "Psikolojik Danışman", "<p>Elif Tuncel, lisans eğitimini Boğazi&ccedil;i &Uuml;niversitesi Psikoloji b&ouml;l&uuml;m&uuml;nde tamamlamıştır. Aynı &uuml;niversitede Klinik Psikoloji Y&uuml;ksek Lisans programını tamamlayarak Uzman Klinik Psikolog unvanını almıştır. Doktora programına devam etmektedir.</p>", "ac1e2980-0bad-4e1e-9996-8311297248b7", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "8d0a5564-0390-4355-8534-9204be00a418" },
                    { 2, "ab0b4c71-84fd-4d50-bd32-26a7ebef9ef9" },
                    { 3, "700cc93a-e0dc-43f9-8bec-25d101f1aa07" },
                    { 4, "7e2035bc-412f-4d3e-aea5-e7ff5a406c1e" },
                    { 5, "681b7b2d-0b42-424c-8871-61efaf4385bb" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3930), "1.jpg", "ea14b91f-073e-41bd-b55b-9eb9b1471ac2" },
                    { 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3947), "2.jpg", "633c517c-d461-4627-b3a0-179c65f6626f" },
                    { 3, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3952), "3.jpg", "1d9038fa-5093-4d1d-bd35-054c55a60199" },
                    { 4, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3955), "4.jpg", "fd9f764a-cc69-48c0-a20f-268305752050" },
                    { 5, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3958), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3958), "5.jpg", "8a4de71a-ab39-413f-82ba-7877977d2ffc" },
                    { 6, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3970), "6.jpg", "422e96a8-1d24-495e-9610-4241e794ca6d" },
                    { 7, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3974), "7.jpg", "c2cbe566-1db4-4a5b-ada3-813e74ee2a38" },
                    { 8, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3980), "8.jpg", "ac1e2980-0bad-4e1e-9996-8311297248b7" },
                    { 9, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3986), "9.jpg", "8d0a5564-0390-4355-8534-9204be00a418" },
                    { 10, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3997), "10.jpg", "ab0b4c71-84fd-4d50-bd32-26a7ebef9ef9" },
                    { 11, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(4004), "11.jpg", "700cc93a-e0dc-43f9-8bec-25d101f1aa07" },
                    { 12, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(4007), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(4008), "12.jpg", "7e2035bc-412f-4d3e-aea5-e7ff5a406c1e" },
                    { 13, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(4010), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(4011), "13.jpg", "681b7b2d-0b42-424c-8871-61efaf4385bb" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentState", "AppointmentTime", "ConsultantId", "CreatedTime", "CustomerId", "Price", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 1, 1), 1, "10:00-11:00", 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2775), 1, 200m, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2777) },
                    { 2, new DateOnly(2023, 1, 1), 2, "13:00-14:00", 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2793), 2, 200m, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2794) },
                    { 3, new DateOnly(2023, 5, 20), 0, "15:00-16:00", 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2800), 3, 150m, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2804) },
                    { 4, new DateOnly(2023, 5, 25), 3, "18:00-19:00", 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2809), 4, 150m, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2810) }
                });

            migrationBuilder.InsertData(
                table: "Availables",
                columns: new[] { "Id", "ConsultantId", "CreatedTime", "Date", "UpdatedTime", "WorkingHoursId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2617), new DateOnly(2023, 5, 15), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2621), 15 },
                    { 2, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2630), new DateOnly(2023, 5, 16), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2633), 20 },
                    { 3, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2638), new DateOnly(2023, 5, 17), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2639), 16 },
                    { 4, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2645), new DateOnly(2023, 5, 22), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2648), 13 },
                    { 5, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2653), new DateOnly(2023, 5, 22), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2654), 14 },
                    { 6, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2664), new DateOnly(2023, 5, 22), new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2667), 15 }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateName", "CertificateTime", "ConsultantId", "CreatedTime", "Institution", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3518), "Amerikan Psikoloji Derneği", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3522) },
                    { 2, "Psikologlar için Uzmanlık Sertifikası", 2015, 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3530), "Amerikan Psikoloji Derneği (APA)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3534) },
                    { 3, "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", 2015, 3, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3538), "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3539) },
                    { 4, "Avrupa Psikolog (EuroPsy) Sertifikası", 2015, 4, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3541), "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3544) },
                    { 5, "Psikologlar için Özel Uzmanlık Sertifikası", 2015, 6, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3557), "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3561) },
                    { 6, "Psikodrama Uzmanlık Sertifikası", 2015, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3567), "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3568) },
                    { 7, "Sanat Terapisi Sertifikası", 2015, 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3571), "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3573) },
                    { 8, "Hipnoterapi Sertifikası", 2015, 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3578), "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3581) },
                    { 9, "Oyun Terapisi Sertifikası", 2015, 6, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3586), "Oyun Terapisi Derneği (Association for Play Therapy, APT)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3589) },
                    { 10, "Çift ve Aile Terapisi Sertifikası", 2015, 7, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3598), "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3599) },
                    { 11, "Kognitif Davranış Terapisi (KDT) Sertifikası", 2015, 5, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3549), "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(3552) }
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
                    { 1, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2908), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "İktisadi ve İdari Bilimler Fakültesi", 2013, "Anadolu Üniversitesi", 2009, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2912) },
                    { 2, 2, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2922), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2015, "Hacettepe Üniversitesi", 2013, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2923) },
                    { 3, 3, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2928), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2016, "Dokuz Eylül Üniversitesi", 2012, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2929) },
                    { 4, 4, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2934), "Lisans", "Psikolojik Danışmanlık ve Rehberlik", "Eğitim Bilimleri Fakültesi", 2017, "Gazi Üniversitesi", 2013, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2935) },
                    { 5, 5, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2942), "Lisans", "Rehberlik ve Psikolojik Danışmanlık", "Eğitim Bilimleri Fakültesi", 2018, "Marmara Üniversitesi", 2014, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2943) },
                    { 6, 6, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2952), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2015, "Gazi Üniversitesi", 2011, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2956) },
                    { 7, 7, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2958), "Lisans", "Özel Eğitim", "Eğitim Bilimleri Fakültesi", 2017, "Ankara Üniversitesi", 2013, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2959) },
                    { 8, 1, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2965), "Yüksek Lisans", "Psikiyatri", "Cerrahpaşa Tıp Fakültesi", 2015, "İstanbul Üniversitesi", 2013, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2967) },
                    { 9, 3, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2972), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2018, "Ege Üniversitesi", 2016, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2973) },
                    { 10, 7, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2985), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2019, "Ege Üniversitesi", 2017, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2986) },
                    { 11, 5, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2988), "Yüksek Lisans", "Psikiyatri", "Tıp Fakültesi", 2020, "Ege Üniversitesi", 2018, new DateTime(2023, 5, 16, 3, 42, 50, 449, DateTimeKind.Local).AddTicks(2991) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ConsultantId",
                table: "Appointments",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId");

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
