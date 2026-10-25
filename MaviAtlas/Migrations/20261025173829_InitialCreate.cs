using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaviAtlas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 1,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/5/57/Octopus2.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 2,
                column: "FotoKaynak",
                value: "https://www.bilgiustam.com/resimler/2014/08/5608_cupra-2.jpg");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 3,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/b/be/Black_sea_mullus_barbatus_ponticus_01.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 4,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/9/9b/Tripneustes_ventricosus_%28West_Indian_Sea_Egg-top%29_and_Echinometra_viridis_%28Reef_Urchin_-_bottom%29.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 5,
                column: "FotoKaynak",
                value: "https://thumb.wikimedia.org/wikipedia/commons/thumb/9/93/Epfus_u0_white_bg.gif/500px-Epfus_u0_white_bg.gif?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 6,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/c/cb/Georgia_Aquarium_-_Cuttlefish_Jan_2006.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 8,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/6/68/Dicentrarchus_labrax01.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 9,
                column: "FotoKaynak",
                value: "https://thumb.wikimedia.org/wikipedia/commons/thumb/d/dc/Mújol_%28Mugil_cephalus%29%2C_Parque_natural_de_la_Arrábida%2C_Portugal%2C_2021-09-09%2C_DD_25.jpg/500px-Mújol_%28Mugil_cephalus%29%2C_Parque_natural_de_la_Arrábida%2C_Portugal%2C_2021-09-09%2C_DD_25.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 10,
                column: "FotoKaynak",
                value: "https://thumb.wikimedia.org/wikipedia/commons/thumb/8/8f/CrownofThornsStarfish_Fiji_2005-10-12.jpg/500px-CrownofThornsStarfish_Fiji_2005-10-12.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 11,
                column: "FotoKaynak",
                value: "https://thumb.wikimedia.org/wikipedia/commons/thumb/c/c1/Anemone_monterey_madrabbit.jpg/500px-Anemone_monterey_madrabbit.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 12,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/4/45/CornishMussels.JPG?utm_source=tr.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 13,
                column: "FotoKaynak",
                value: "https://upload.wikimedia.org/wikipedia/commons/1/13/Loggerhead_turtle.jpg?utm_source=tr.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 14,
                column: "FotoKaynak",
                value: "https://thumb.wikimedia.org/wikipedia/commons/thumb/e/e1/Billy_monk_seal_2.jpg/500px-Billy_monk_seal_2.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 15,
                column: "FotoKaynak",
                value: "https://thumb.wikimedia.org/wikipedia/commons/thumb/b/bc/Tursiops_truncatus_01-cropped.jpg/500px-Tursiops_truncatus_01-cropped.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 1,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 2,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 3,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 4,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 5,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 6,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 8,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 9,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 10,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 11,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 12,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 13,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 14,
                column: "FotoKaynak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 15,
                column: "FotoKaynak",
                value: "");
        }
    }
}
