using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSchema : Migration
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
                    { 1, "Armando Patton", "(236) 513-0630" },
                    { 2, "Molly Wright", "(329) 973-2452" },
                    { 3, "Erika Hood", "(282) 752-3677" },
                    { 4, "Myah Boyle", "(592) 670-0518" },
                    { 5, "Haiden Pugh", "(337) 834-2577" },
                    { 6, "Quinn Wise", "(426) 849-3991" },
                    { 7, "Alyssa Heath", "(641) 251-3768" },
                    { 8, "Yareli Duke", "(374) 570-4013" },
                    { 9, "Taniya Brewer", "(844) 498-9272" },
                    { 10, "Nayeli Todd", "(402) 862-4708" },
                    { 11, "Alina Weeks", "(992) 494-9494" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Amount", "CustomerId", "OrderNumber" },
                values: new object[,]
                {
                    { 1, 392m, 1, "ORDNUM-001" },
                    { 2, 442m, 2, "ORDNUM-002" },
                    { 3, 613m, 2, "ORDNUM-003" },
                    { 4, 876m, 3, "ORDNUM-004" },
                    { 5, 820m, 3, "ORDNUM-005" },
                    { 6, 985m, 3, "ORDNUM-006" },
                    { 7, 710m, 3, "ORDNUM-007" },
                    { 8, 267m, 4, "ORDNUM-008" },
                    { 9, 382m, 5, "ORDNUM-009" },
                    { 10, 226m, 7, "ORDNUM-010" },
                    { 11, 316m, 7, "ORDNUM-011" },
                    { 12, 398m, 8, "ORDNUM-012" },
                    { 13, 641m, 9, "ORDNUM-013" },
                    { 14, 578m, 9, "ORDNUM-014" },
                    { 15, 492m, 9, "ORDNUM-015" },
                    { 16, 905m, 9, "ORDNUM-016" },
                    { 17, 279m, 9, "ORDNUM-017" },
                    { 18, 936m, 10, "ORDNUM-018" },
                    { 19, 610m, 10, "ORDNUM-019" },
                    { 20, 281m, 11, "ORDNUM-020" },
                    { 21, 328m, 11, "ORDNUM-021" },
                    { 22, 943m, 11, "ORDNUM-022" },
                    { 23, 578m, 11, "ORDNUM-023" }
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
