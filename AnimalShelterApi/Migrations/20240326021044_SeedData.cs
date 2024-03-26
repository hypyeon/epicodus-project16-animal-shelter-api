using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Dogs",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Dogs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Name", "NeuteredSpayed", "Sex" },
                values: new object[,]
                {
                    { 1, "3 years (estimate)", "Australian Cattle Dog mix", "Beanie", true, "Male" },
                    { 2, "Unknown", "American Staffordshire Terrier mix", "Bronx", true, "Male" },
                    { 3, "2 years (estimate)", "American Staffordshire Terrir mix", "Russell", true, "Male" },
                    { 4, "9 months", "Bull Terrier mix", "Two", true, "Female" },
                    { 5, "18 months", "Belgian Shepherd mix", "Loverboy", true, "Male" },
                    { 6, "2 years (estimate)", "Border Collie mix", "Hera", true, "Female" },
                    { 7, "8 weeks", "Dachshund mix", "Burrito", false, null },
                    { 8, "4 years (estimate)", "Husky mix", "King", true, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Dogs");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
