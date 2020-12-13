using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBy.Repositorio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FORM_PAYMENT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORM_PAYMENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    PRICE = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EMAIL = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    PASSWORD = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    SURNAME = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DATE_ORDER = table.Column<DateTime>(type: "datetime", nullable: false),
                    USER_ID = table.Column<int>(nullable: false),
                    PREVIOUS_DELIVERY_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    ESTATE = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    CITY = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    FULL_ADDRESS = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    NUMBER = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    FORM_PAYMENT_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ORDER_FORM_PAYMENT_FORM_PAYMENT_ID",
                        column: x => x.FORM_PAYMENT_ID,
                        principalTable: "FORM_PAYMENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITEM_ORDER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PRODUCT_ID = table.Column<int>(nullable: false),
                    ORDER_ID = table.Column<int>(nullable: false),
                    QUANTITY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM_ORDER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEM_ORDER_ORDER_ID",
                        column: x => x.ORDER_ID,
                        principalTable: "ORDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_ORDER_PRODUCT_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "PRODUCT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_ORDER_ORDER_ID",
                table: "ITEM_ORDER",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_ORDER_PRODUCT_ID",
                table: "ITEM_ORDER",
                column: "PRODUCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_FORM_PAYMENT_ID",
                table: "ORDER",
                column: "FORM_PAYMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_USER_ID",
                table: "ORDER",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITEM_ORDER");

            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "FORM_PAYMENT");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}
