using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MycoMatrix.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mushrooms",
                columns: new[] { "MushroomId", "CommonName", "Genus", "GillType", "ImageURL", "Notes", "Species", "ToxicityLevel" },
                values: new object[,]
                {
                    { 1, "Black Trumpet", "Craterellus", "Ridged", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", "choice edible, grows under oak and beech trees", "cornucopioides", 0 },
                    { 2, "Golden Chanterelle", "Cantharellus", "Ridged", "https://d2ci82p1s8eczl.cloudfront.net/wp-content/uploads/20231219151006/castatemushroom-scaled.jpg", "choice edible, grows in conifer forests under Douglas Fir, spruce and hemlocks", "cibarius", 0 },
                    { 3, "Morel", "Morchella", "None", "https://media.istockphoto.com/id/1059075136/photo/a-large-group-of-morels-by-a-stream.jpg?s=612x612&w=0&k=20&c=QU-hajnz7xC60AGuQhsJWOAx7MpVB4sWbMB0xEE3vVI=", "may cause some stomach upset in certain individuals, must cook thoroughly", "esculenta", 3 },
                    { 4, "Chicken of the woods", "Laetiporus", "Polypore", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Laetiporus_sulphureus_JPG01.jpg/1920px-Laetiporus_sulphureus_JPG01.jpg", "may cause some GI upset in some individuals, grows on dead or dying trees", "sulphureus", 3 },
                    { 5, "Black Trumpet", "Craterellus", "Ridged", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", "choice edible, grows under oak and beech trees", "cornucopioides", 0 },
                    { 6, "Deadly Galerina", "Galerina", "Gills", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", "contains amatoxins, has been confused with Psilocybe stuntzii", "marginata", 10 },
                    { 7, "Fly Agaric", "Amanita", "Gills", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Amanita_muscaria_3_vliegenzwammen_op_rij.jpg/1920px-Amanita_muscaria_3_vliegenzwammen_op_rij.jpg", "won't kill you", "muscaria", 5 },
                    { 8, "toxic black mold", "Stachybotrys", "None", "https://upload.wikimedia.org/wikipedia/commons/7/7c/2009-05-09_Stachybotrys_chartarum_%28Ehrenb.%29_S._Hughes_43158.jpg", "One of the worst fungi to encounter", "chartarum", 8 },
                    { 9, "Turkey Tail", "Trametes", "Pores", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Trametes_versicolor_G4_%281%29.JPG/1280px-Trametes_versicolor_G4_%281%29.JPG", "edible, medicinal", "versicolor", 0 },
                    { 10, "Crystal Brain", "Myxarium", "None", "https://upload.wikimedia.org/wikipedia/commons/9/95/Crystal_Brain_Fungus_%28Exidia_nucleata%29_-_geograph.org.uk_-_1000447.jpg", "Unknown if edible or not", "nucleatum", 0 },
                    { 11, "Magic Mushrooms", "Psilocybe", "Gills", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Cubensis_Xalapa.jpg/1280px-Cubensis_Xalapa.jpg", "The classic tripper's delight", "cubensis", 2 },
                    { 12, "Cordyceps", "Ophiocordyceps ", "None", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Ophiocordyceps_unilateralis.png/800px-Ophiocordyceps_unilateralis.png", "If you're an ant it's bad news, otherwise it's medicinal", "unilateralis", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 12);
        }
    }
}
