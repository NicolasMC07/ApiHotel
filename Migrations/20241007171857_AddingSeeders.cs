using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiHotel.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "guests",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "employes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Habitación Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Habitación Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Suite" },
                    { 4, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitación Familiar" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_person", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, (byte)1, 50.0, "1-1", 1 },
                    { 2, false, (byte)1, 50.0, "1-2", 1 },
                    { 3, true, (byte)2, 80.0, "1-3", 2 },
                    { 4, false, (byte)2, 80.0, "1-4", 2 },
                    { 5, true, (byte)2, 150.0, "1-5", 3 },
                    { 6, false, (byte)2, 150.0, "1-6", 3 },
                    { 7, true, (byte)4, 200.0, "1-7", 4 },
                    { 8, false, (byte)4, 200.0, "1-8", 4 },
                    { 9, true, (byte)1, 50.0, "1-9", 1 },
                    { 10, false, (byte)1, 50.0, "1-10", 1 },
                    { 11, true, (byte)2, 80.0, "2-1", 2 },
                    { 12, false, (byte)2, 80.0, "2-2", 2 },
                    { 13, true, (byte)2, 150.0, "2-3", 3 },
                    { 14, false, (byte)2, 150.0, "2-4", 3 },
                    { 15, true, (byte)4, 200.0, "2-5", 4 },
                    { 16, false, (byte)4, 200.0, "2-6", 4 },
                    { 17, true, (byte)1, 50.0, "2-7", 1 },
                    { 18, false, (byte)1, 50.0, "2-8", 1 },
                    { 19, true, (byte)2, 80.0, "2-9", 2 },
                    { 20, false, (byte)2, 80.0, "2-10", 2 },
                    { 21, true, (byte)2, 150.0, "3-1", 3 },
                    { 22, false, (byte)2, 150.0, "3-2", 3 },
                    { 23, true, (byte)4, 200.0, "3-3", 4 },
                    { 24, false, (byte)4, 200.0, "3-4", 4 },
                    { 25, true, (byte)1, 50.0, "3-5", 1 },
                    { 26, false, (byte)1, 50.0, "3-6", 1 },
                    { 27, true, (byte)2, 80.0, "3-7", 2 },
                    { 28, false, (byte)2, 80.0, "3-8", 2 },
                    { 29, true, (byte)2, 150.0, "3-9", 3 },
                    { 30, false, (byte)2, 150.0, "3-10", 3 },
                    { 31, true, (byte)4, 200.0, "4-1", 4 },
                    { 32, false, (byte)4, 200.0, "4-2", 4 },
                    { 33, true, (byte)1, 50.0, "4-3", 1 },
                    { 34, false, (byte)1, 50.0, "4-4", 1 },
                    { 35, true, (byte)2, 80.0, "4-5", 2 },
                    { 36, false, (byte)2, 80.0, "4-6", 2 },
                    { 37, true, (byte)2, 150.0, "4-7", 3 },
                    { 38, false, (byte)2, 150.0, "4-8", 3 },
                    { 39, true, (byte)4, 200.0, "4-9", 4 },
                    { 40, false, (byte)4, 200.0, "4-10", 4 },
                    { 41, true, (byte)1, 50.0, "5-1", 1 },
                    { 42, false, (byte)1, 50.0, "5-2", 1 },
                    { 43, true, (byte)2, 80.0, "5-3", 2 },
                    { 44, false, (byte)2, 80.0, "5-4", 2 },
                    { 45, true, (byte)2, 150.0, "5-5", 3 },
                    { 46, false, (byte)2, 150.0, "5-6", 3 },
                    { 47, true, (byte)4, 200.0, "5-7", 4 },
                    { 48, false, (byte)4, 200.0, "5-8", 4 },
                    { 49, true, (byte)1, 50.0, "5-9", 1 },
                    { 50, false, (byte)1, 50.0, "5-10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "guests",
                keyColumn: "phone_number",
                keyValue: null,
                column: "phone_number",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "guests",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "employes",
                keyColumn: "password",
                keyValue: null,
                column: "password",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "employes",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
