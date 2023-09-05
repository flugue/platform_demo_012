using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDbSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Test Customer 1", "+63123445784" },
                    { 2, "Test Customer 2", "+63123445784" },
                    { 3, "Test Customer 3", "+63123445784" },
                    { 4, "Test Customer 4", "+63123445784" },
                    { 5, "Test Customer 5", "+63123445784" },
                    { 6, "Test Customer 6", "+63123445784" },
                    { 7, "Test Customer 7", "+63123445784" },
                    { 8, "Test Customer 8", "+63123445784" },
                    { 9, "Test Customer 9", "+63123445784" },
                    { 10, "Test Customer 10", "+63123445784" },
                    { 11, "Test Customer 11", "+63123445784" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Amount", "CustomerId", "OrderNumber" },
                values: new object[,]
                {
                    { 1, 617m, 1, "ORDNUM-1" },
                    { 2, 163m, 2, "ORDNUM-2" },
                    { 3, 494m, 2, "ORDNUM-3" },
                    { 4, 113m, 3, "ORDNUM-4" },
                    { 5, 337m, 3, "ORDNUM-5" },
                    { 6, 993m, 3, "ORDNUM-6" },
                    { 7, 51m, 3, "ORDNUM-7" },
                    { 8, 52m, 4, "ORDNUM-8" },
                    { 9, 266m, 5, "ORDNUM-9" },
                    { 10, 463m, 7, "ORDNUM-10" },
                    { 11, 522m, 7, "ORDNUM-11" },
                    { 12, 550m, 8, "ORDNUM-12" },
                    { 13, 804m, 9, "ORDNUM-13" },
                    { 14, 692m, 9, "ORDNUM-14" },
                    { 15, 693m, 9, "ORDNUM-15" },
                    { 16, 893m, 9, "ORDNUM-16" },
                    { 17, 222m, 9, "ORDNUM-17" },
                    { 18, 814m, 10, "ORDNUM-18" },
                    { 19, 13m, 10, "ORDNUM-19" },
                    { 20, 324m, 11, "ORDNUM-20" },
                    { 21, 402m, 11, "ORDNUM-21" },
                    { 22, 463m, 11, "ORDNUM-22" },
                    { 23, 24m, 11, "ORDNUM-23" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
