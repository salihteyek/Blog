using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Blog.Data.Migrations
{
    public partial class InıtialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 383, DateTimeKind.Local).AddTicks(5576)),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 383, DateTimeKind.Local).AddTicks(5812)),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    CreatedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ModifiedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 385, DateTimeKind.Local).AddTicks(7275)),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 385, DateTimeKind.Local).AddTicks(7516)),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    CreatedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ModifiedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    UserName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImagePateh = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 387, DateTimeKind.Local).AddTicks(2963)),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 387, DateTimeKind.Local).AddTicks(3223)),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    CreatedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ModifiedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 374, DateTimeKind.Local).AddTicks(5493)),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 379, DateTimeKind.Local).AddTicks(7750)),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 379, DateTimeKind.Local).AddTicks(8002)),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    CreatedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ModifiedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 384, DateTimeKind.Local).AddTicks(6146)),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 12, 21, 22, 54, 33, 384, DateTimeKind.Local).AddTicks(6367)),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    CreatedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ModifiedUser = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Description", "IsActive", "ModifiedDate", "ModifiedUser", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 21, 22, 54, 33, 387, DateTimeKind.Local).AddTicks(8933), "System", "Admin tüm yetkilere sahiptir.", true, new DateTime(2021, 12, 21, 22, 54, 33, 387, DateTimeKind.Local).AddTicks(9350), "System", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Description", "Email", "FullName", "ImagePateh", "IsActive", "ModifiedDate", "ModifiedUser", "PasswordHash", "RoleId", "UserName" },
                values: new object[] { 1, new DateTime(2021, 12, 21, 22, 54, 33, 389, DateTimeKind.Local).AddTicks(973), "system", "", "salihteyek@hotmail.com", "Salih Teyek", "", true, new DateTime(2021, 12, 21, 22, 54, 33, 389, DateTimeKind.Local).AddTicks(979), "system", new byte[] { 101, 49, 48, 97, 100, 99, 51, 57, 52, 57, 98, 97, 53, 57, 97, 98, 98, 101, 53, 54, 101, 48, 53, 55, 102, 50, 48, 102, 56, 56, 51, 101 }, 1, "salihteyek" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
