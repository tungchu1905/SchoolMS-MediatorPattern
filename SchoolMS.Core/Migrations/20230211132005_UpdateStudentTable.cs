using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMS.Core.Migrations
{
    public partial class UpdateStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InforClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InforClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "InforStudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InforStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InforStudent_InforClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "InforClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "InforClass",
                columns: new[] { "Id", "ClassName", "Grade", "TeacherName" },
                values: new object[,]
                {
                    { 1, "1A", 1, "Nguyen Thi Hanh" },
                    { 2, "1B", 1, "Nguyen Thi Hoa" },
                    { 3, "2A", 2, "Nguyen Van Thanh" },
                    { 4, "2B", 2, "Chu Thi Hanh" },
                    { 5, "3A", 3, "Nguyen Thi Thuy" },
                    { 6, "3B", 3, "Chu Thi Thuy" },
                    { 7, "4A", 4, "Hoang Thi Tham" },
                    { 8, "4B", 4, "Vuong Thi Minh Hanh" },
                    { 9, "5A", 5, "Hoang Thi Hoa" },
                    { 10, "5B", 5, "Pham Thi Chuc" },
                    { 11, "1C", 1, "Hoang Thi Tham" },
                    { 12, "1D", 1, "Vuong Thi Minh Hanh" },
                    { 13, "2C", 2, "Hoang Thi Hoa" },
                    { 14, "2D", 2, "Pham Thi Chuc" }
                });

            migrationBuilder.InsertData(
                table: "InforStudent",
                columns: new[] { "Id", "Address", "ClassId", "DateOfBirth", "FatherName", "Gender", "MotherName", "StudentName" },
                values: new object[,]
                {
                    { 1, "Ha Noi", 1, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Nguyen Khanh Toan" },
                    { 2, "Ha Noi", 1, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "", "Nguyen Ngoc Long" },
                    { 3, "Ha Noi", 2, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Chu Khanh Toan" },
                    { 4, "Ha Noi", 2, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Hoang Van Long" },
                    { 5, "Ha Noi", 3, new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "", "Pham Thanh Xuan" },
                    { 6, "Ha Noi", 3, new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Vu Duc Khanh" },
                    { 7, "Ha Noi", 4, new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "", "Chuong Thi Khanh Toan" },
                    { 8, "Ha Noi", 4, new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Nguyen Thanh Long" },
                    { 9, "Ha Noi", 5, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "", "Do Thi Huong" },
                    { 10, "Ha Noi", 5, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Truong Dang Hieu" },
                    { 11, "Ha Noi", 6, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Truong Quoc Sinh" },
                    { 12, "Ha Noi", 6, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "", "Nguyen Thu Huong" },
                    { 13, "Ha Noi", 6, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "", "Do Thi Mai" },
                    { 14, "Ha Noi", 1, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, "", "Nguyen Khanh Mai" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InforStudent_ClassId",
                table: "InforStudent",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "InforStudent");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "InforClass");
        }
    }
}
