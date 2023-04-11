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
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", null, "Danışanman", "Consultant", "CONSULTANT" },
                    { "c3fd5009-ad6e-4079-a668-7b007c1ac98c", null, "Yönetici", "Admin", "ADMIN" },
                    { "d7fe43d9-043c-4860-afbd-d49707cad173", null, "Kullanıcı", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0222e488-3879-4166-9b86-9205d177c1d9", 0, "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", "İstanbul", "65e46b41-d30c-4386-9956-f23ff334e9ab", new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "melis.ozturk@gmail.com", true, "Melis", "Kadın", "Öztürk", false, null, "MELIS.OZTURK@GMAIL.COM", "MELISOZTURK", null, null, false, "02f84f26-443d-4b4b-b93a-20950ee1085f", false, "melisozturk" },
                    { "46011f1e-158e-4662-8c72-5780301b9935", 0, "Turan Cd. No:7 Bornova", "İzmir", "a2976286-fa40-41f0-bf88-6ab06bf95c8f", new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.ergun@gmail.com", true, "Can", "Erkek", "Ergün", false, null, "CAN.ERGUN@GMAIL.COM", "CANERGUN", null, null, false, "a3a476a8-3531-4856-ab40-d448a470a95e", false, "canergun" },
                    { "53b875d2-c8d2-4241-a2c2-cb2363fed268", 0, "Halilpaşa Konağı Ap. No:18 Beşiktaş", "İstanbul", "bb879b8b-dbd9-41f4-bd94-61b685638734", new DateTime(1985, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "deniz@asdasd.com", true, "Deniz", "Kadın", "Kartal", false, null, "DENIZ@ASDASD.COM", "DENIZ", null, null, false, "f5392379-1716-48d7-86df-90c69e476e9b", false, "deniz" },
                    { "618a9587-0777-4025-a9e8-e00cbf5f8032", 0, "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli", "İstanbul", "d6cb471e-e2d7-475a-80ef-87ac97ea98ba", new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.yildirim@hotmail.com", true, "Ali", "Erkek", "Yıldırım", false, null, "ALI.YILDIRIM@HOTMAIL.COM", "ALIYILDIRIM", null, null, false, "e451276d-def5-4bc9-ab41-15ae059fff95", false, "aliyildirim" },
                    { "635aaef7-edd5-4d60-ae13-e7c687142967", 0, " Özger Cad.No:6 Beşiktaş", "İstanbul", "34fe789d-5f98-4054-a262-4ff219537997", new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@consultancy.com", true, "Hakan", "Erkek", "Aslan", false, null, "ADMIN.CONSULTANCY.COM", "ADMIN", null, null, false, "cd9e946a-649a-4794-81f3-7c134279aba6", false, "admin" },
                    { "88f0eb29-bd71-4273-864c-9842e3b96a27", 0, "Karşıyaka Cd. No:8/3 Alsancak", "İzmir", "8cb3efed-ffdb-46a3-83c8-b245a947edc0", new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.gunes@gmail.com", true, "Zeynep", "Kadın", "Güneş", false, null, "ZEYNEP.GUNES@GMAIL.COM", "ZEYNEPGUNES", null, null, false, "0672dd42-b338-4402-a0aa-bb8b5ed59395", false, "zeynepgunes" },
                    { "9b9ec15d-8213-4579-8dce-4b68f5a0011d", 0, "Atatürk Mah. No:4 Bahçelievler", "İstanbul", "fce9d50d-9cef-4b3b-aff6-47309075a796", new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.demir@gmail.com", true, "Ali", "Erkek", "Demir", false, null, "ALI.DEMIR@GMAIL.COM", "ALIDEMIR", null, null, false, "eac91b4e-3aa8-4a85-a7cc-eafc729a07f9", false, "alidemir" },
                    { "c0c74e57-fc4d-449b-9855-eeb94e6c15ee", 0, "Cemal Gürsel Cd. No:5 Kadıköy", "İstanbul", "da6ab417-c42b-4268-9994-d45b4650274a", new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@gmail.com", true, "Ayşe", "Kadın", "Yılmaz", false, null, "AYSE.YILMAZ@GMAIL.COM", "AYSEYILMAZ", null, null, false, "165c419c-f79d-47ad-be07-4f5c0580472b", false, "ayseyilmaz" },
                    { "cd43e623-b7f7-4b25-8cd9-6f4f62bc41fd", 0, "Mecidiyeköy Cd. No:23 Şişli", "İstanbul", "cbfd39aa-a0ea-4f06-a3b9-96677df59b00", new DateTime(1987, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "gizem.aydin@gmail.com", true, "Gizem", "Kadın", "Aydın", false, null, "GIZEM.AYDIN@GMAIL.COM", "GIZEMAYDIN", null, null, false, "a88f4a8d-f557-48fb-a39a-f83951c28c4f", false, "gizemaydin" },
                    { "d1c5bc6f-5e02-410a-9f53-06a80eb712ef", 0, "Etiler Mah. Bebek Cad. No:17 Beşiktaş", "İstanbul", "9d402df2-1d86-473d-b390-c750a7a72276", new DateTime(1983, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "esra.avci@gmail.com", true, "Esra", "Kadın", "Avcı", false, null, "ESRA.AVCI@GMAIL.COM", "ESRAAVCI", null, null, false, "1d24fdda-8c49-421e-8881-b72cbf180906", false, "esraavci" },
                    { "d838b305-c9fe-40e8-84ab-1d872299e235", 0, "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", "İstanbul", "17d262b5-3cb1-4634-9e02-6718f2bcc955", new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "can.sahin@hotmail.com", true, "Can", "Erkek", "Şahin", false, null, "CAN.SAHIN@HOTMAIL.COM", "CANSAHIN", null, null, false, "42d27122-0e04-47b8-aa6e-03c9a3d24f20", false, "cansahin" },
                    { "e41edcca-174d-4b77-b926-3b242da02fee", 0, "Atatürk Cd. No:15/4 Çankaya", "Ankara", "791cb032-ccb6-4620-b9c3-f44255ed62c3", new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.ozkan@gmail.com", true, "Mehmet", "Erkek", "Özkan", false, null, "MEHMET.OZKAN@GMAIL.COM", "MEHMETOZKAN", null, null, false, "4ed4c5dc-c6b9-44d6-94be-55067ebb789e", false, "mehmetozkan" },
                    { "f0331525-2680-4b01-a168-f766e6660895", 0, "İnönü Cd. No:12/1 Kartal", "İstanbul", "2280df21-7942-404d-adb2-d425b3c33204", new DateTime(1997, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.kara@gmail.com", true, "Fatma", "Kadın", "Kara", false, null, "FATMA.KARA@GMAIL.COM", "FATMAKARA", null, null, false, "7a89ee05-0e37-41b5-ac43-39ee71751e6a", false, "fatmakara" }
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
                    { "d7fe43d9-043c-4860-afbd-d49707cad173", "0222e488-3879-4166-9b86-9205d177c1d9" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "46011f1e-158e-4662-8c72-5780301b9935" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "53b875d2-c8d2-4241-a2c2-cb2363fed268" },
                    { "d7fe43d9-043c-4860-afbd-d49707cad173", "618a9587-0777-4025-a9e8-e00cbf5f8032" },
                    { "c3fd5009-ad6e-4079-a668-7b007c1ac98c", "635aaef7-edd5-4d60-ae13-e7c687142967" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "88f0eb29-bd71-4273-864c-9842e3b96a27" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "9b9ec15d-8213-4579-8dce-4b68f5a0011d" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "c0c74e57-fc4d-449b-9855-eeb94e6c15ee" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "cd43e623-b7f7-4b25-8cd9-6f4f62bc41fd" },
                    { "d7fe43d9-043c-4860-afbd-d49707cad173", "d1c5bc6f-5e02-410a-9f53-06a80eb712ef" },
                    { "d7fe43d9-043c-4860-afbd-d49707cad173", "d838b305-c9fe-40e8-84ab-1d872299e235" },
                    { "a743e6cd-3ef3-41fb-8762-15f35532d5bb", "e41edcca-174d-4b77-b926-3b242da02fee" },
                    { "d7fe43d9-043c-4860-afbd-d49707cad173", "f0331525-2680-4b01-a168-f766e6660895" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "JobTitle", "Promotion", "UserId", "VisitsPrice" },
                values: new object[,]
                {
                    { 1, "Psikolojik Danışman", "Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", "c0c74e57-fc4d-449b-9855-eeb94e6c15ee", 100m },
                    { 2, "Klinik Psikolog", "Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", "e41edcca-174d-4b77-b926-3b242da02fee", 100m },
                    { 3, "Psikolog", "Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", "88f0eb29-bd71-4273-864c-9842e3b96a27", 100m },
                    { 4, "Psikolojik Danışman", "Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", "9b9ec15d-8213-4579-8dce-4b68f5a0011d", 100m },
                    { 5, "Psikolojik Danışman", "Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", "cd43e623-b7f7-4b25-8cd9-6f4f62bc41fd", 100m },
                    { 6, "Psikolojik Danışman", "Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", "46011f1e-158e-4662-8c72-5780301b9935", 100m },
                    { 7, "Psikolojik Danışman", "Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", "635aaef7-edd5-4d60-ae13-e7c687142967", 100m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "618a9587-0777-4025-a9e8-e00cbf5f8032" },
                    { 2, "0222e488-3879-4166-9b86-9205d177c1d9" },
                    { 3, "d838b305-c9fe-40e8-84ab-1d872299e235" },
                    { 4, "d1c5bc6f-5e02-410a-9f53-06a80eb712ef" },
                    { 5, "f0331525-2680-4b01-a168-f766e6660895" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6177), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6189), "1.jpg", "635aaef7-edd5-4d60-ae13-e7c687142967" },
                    { 2, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6195), "2.jpg", "c0c74e57-fc4d-449b-9855-eeb94e6c15ee" },
                    { 3, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6197), "3.jpg", "e41edcca-174d-4b77-b926-3b242da02fee" },
                    { 4, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6199), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6200), "4.jpg", "88f0eb29-bd71-4273-864c-9842e3b96a27" },
                    { 5, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6202), "5.jpg", "9b9ec15d-8213-4579-8dce-4b68f5a0011d" },
                    { 6, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6205), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6206), "6.jpg", "cd43e623-b7f7-4b25-8cd9-6f4f62bc41fd" },
                    { 7, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6208), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6208), "7.jpg", "46011f1e-158e-4662-8c72-5780301b9935" },
                    { 8, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6211), "8.jpg", "53b875d2-c8d2-4241-a2c2-cb2363fed268" },
                    { 9, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6213), "9.jpg", "618a9587-0777-4025-a9e8-e00cbf5f8032" },
                    { 10, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6217), "10.jpg", "0222e488-3879-4166-9b86-9205d177c1d9" },
                    { 11, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6219), "11.jpg", "d838b305-c9fe-40e8-84ab-1d872299e235" },
                    { 12, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6222), "12.jpg", "d1c5bc6f-5e02-410a-9f53-06a80eb712ef" },
                    { 13, new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 4, 11, 13, 20, 9, 280, DateTimeKind.Local).AddTicks(6224), "13.jpg", "f0331525-2680-4b01-a168-f766e6660895" }
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
