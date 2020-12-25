using Microsoft.EntityFrameworkCore.Migrations;

namespace PluralsightAspNetCore.Migrations
{
    public partial class addMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, null, null, null, false, null, "Apple Pie", 12.95m, "Our famous apple pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, null, null, null, false, null, "Apple Pie", 12.95m, "Our famous apple pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 4, null, null, null, false, null, "Apple Pie", 12.95m, "Our famous apple pies" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);
        }
    }
}
