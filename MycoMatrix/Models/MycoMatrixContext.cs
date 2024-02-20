using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace MycoMatrix.Models;

public class MycoMatrixContext : IdentityDbContext<ApplicationUser>
{
  public DbSet<Mushroom> Mushrooms { get; set; }

  public MycoMatrixContext(DbContextOptions<MycoMatrixContext> options) : base(options)
  {
  }

  // protected override void OnModelCreating(ModelBuilder builder)
  //   {
  //     builder.Entity<Mushroom>()
  //       .HasData(
          
  //         new Mushroom { 
  //           MushroomId = 1, 
  //           CommonName = "Black Trumpet", 
  //           Genus = "Craterellus", 
  //           Species = "cornucopioides", 
  //           GillType = "Ridged", 
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", 
  //           ToxicityLevel = 0, 
  //           Notes = "choice edible, grows under oak and beech trees",
  //           Editor = "Kim Robinson"
  //           },
          
  //         new Mushroom { 
  //           MushroomId = 2, 
  //           CommonName = "Golden Chanterelle", 
  //           Genus = "Cantharellus", 
  //           Species = "cibarius", 
  //           GillType = "Ridged", 
  //           ImageURL = "https://d2ci82p1s8eczl.cloudfront.net/wp-content/uploads/20231219151006/castatemushroom-scaled.jpg", 
  //           ToxicityLevel = 0, 
  //           Notes = "choice edible, grows in conifer forests under Douglas Fir, spruce and hemlocks",
  //           Editor = "Mickey Mouse"
  //         },

  //         new Mushroom { 
  //           MushroomId = 3, 
  //           CommonName = "Morel", 
  //           Genus = "Morchella", 
  //           Species = "esculenta", 
  //           GillType = "None", 
  //           ImageURL = "https://media.istockphoto.com/id/1059075136/photo/a-large-group-of-morels-by-a-stream.jpg?s=612x612&w=0&k=20&c=QU-hajnz7xC60AGuQhsJWOAx7MpVB4sWbMB0xEE3vVI=", 
  //           ToxicityLevel = 3, 
  //           Notes = "may cause some stomach upset in certain individuals, must cook thoroughly",
  //           Editor = "Kim Robinson"
  //         },
          
  //         new Mushroom { 
  //           MushroomId = 4, 
  //           CommonName = "Chicken of the woods", 
  //           Genus = "Laetiporus", 
  //           Species = "sulphureus", 
  //           GillType = "Polypore", 
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Laetiporus_sulphureus_JPG01.jpg/1920px-Laetiporus_sulphureus_JPG01.jpg", 
  //           ToxicityLevel = 3, 
  //           Notes = "may cause some GI upset in some individuals, grows on dead or dying trees",
  //           Editor = "Henry Oberholtzer"
  //         },
          
  //         new Mushroom { 
  //           MushroomId = 5, 
  //           CommonName = "Black Trumpet", 
  //           Genus = "Craterellus", 
  //           Species = "cornucopioides", 
  //           GillType = "Ridged", 
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", 
  //           ToxicityLevel = 0, 
  //           Notes = "choice edible, grows under oak and beech trees",
  //           Editor = "Kim Robinson"
  //         },
          
  //         new Mushroom { 
  //           MushroomId = 6, 
  //           CommonName = "Deadly Galerina", 
  //           Genus = "Galerina", 
  //           Species = "marginata", 
  //           GillType = "Gills", 
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", 
  //           ToxicityLevel = 10, 
  //           Notes = "contains amatoxins, has been confused with Psilocybe stuntzii",
  //           Editor = "Paul Stamets"
  //         },
          
  //         new Mushroom { 
  //           MushroomId = 7, 
  //           CommonName = "Fly Agaric", 
  //           Genus = "Amanita", 
  //           Species = "muscaria", 
  //           GillType = "Gills", 
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Amanita_muscaria_3_vliegenzwammen_op_rij.jpg/1920px-Amanita_muscaria_3_vliegenzwammen_op_rij.jpg", ToxicityLevel = 5, 
  //           Notes = "won't kill you",
  //           Editor = "Henry Oberholtzer"
  //         },

  //         new Mushroom { 
  //           MushroomId = 8, 
  //           CommonName = "toxic black mold", 
  //           Genus = "Stachybotrys", 
  //           Species = "chartarum", 
  //           GillType = "None", 
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/7/7c/2009-05-09_Stachybotrys_chartarum_%28Ehrenb.%29_S._Hughes_43158.jpg", 
  //           ToxicityLevel = 8, 
  //           Notes = "One of the worst fungi to encounter",
  //           Editor = "Paul Stamets"
  //         },
  //         new Mushroom { 
  //           MushroomId = 9,
  //           CommonName = "Turkey Tail",
  //           Genus = "Trametes",
  //           Species = "versicolor",
  //           GillType = "Pores",
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Trametes_versicolor_G4_%281%29.JPG/1280px-Trametes_versicolor_G4_%281%29.JPG", ToxicityLevel = 0,
  //           Notes = "edible, medicinal",
  //           Editor = "Kim Robinson"

  //         },
  //         new Mushroom { 
  //           MushroomId = 10, 
  //           CommonName = "Crystal Brain",
  //           Genus = "Myxarium",
  //           Species = "nucleatum",
  //           GillType = "None",
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/9/95/Crystal_Brain_Fungus_%28Exidia_nucleata%29_-_geograph.org.uk_-_1000447.jpg",
  //           ToxicityLevel = 0,
  //           Notes = "Unknown if edible or not",
  //           Editor = "Henry Oberholtzer"
  //         },
  //         new Mushroom { 
  //           MushroomId = 11, 
  //           CommonName = "Magic Mushrooms",
  //           Genus = "Psilocybe",
  //           Species = "cubensis",
  //           GillType = "Gills",
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Cubensis_Xalapa.jpg/1280px-Cubensis_Xalapa.jpg",
  //           ToxicityLevel = 2,
  //           Notes = "The classic tripper's delight",
  //           Editor = "Paul Stamets"
  //         },
  //         new Mushroom { 
  //           MushroomId = 12, 
  //           CommonName = "Cordyceps",
  //           Genus = "Ophiocordyceps ",
  //           Species = "unilateralis",
  //           GillType = "None",
  //           ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Ophiocordyceps_unilateralis.png/800px-Ophiocordyceps_unilateralis.png",
  //           ToxicityLevel = 2,
  //           Notes = "If you're an ant it's bad news, otherwise it's medicinal",
  //           Editor = "Pedro Pascal"
  //         }
  //       );
  //   }
}
