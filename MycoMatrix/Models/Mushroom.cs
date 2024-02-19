using System.ComponentModel.DataAnnotations;

namespace MycoMatrix.Models;

public class Mushroom
{
  public int MushroomId { get; set; }

  [Required]
  [StringLength(255)]
  public string CommonName { get; set; }

  [StringLength(255)]
  public string Genus { get; set; }

  [StringLength(255)]
  public string Species { get; set; }

  [StringLength(255)]
  public string GillType { get; set; }

  [StringLength(255)]
  public string ImageURL { get; set; }

  [Range(0, 10, ErrorMessage = "Toxicity levels range 0-10")]
  public int ToxicityLevel { get; set; }
  public string Notes { get; set; }
  [StringLength(45)]
  public string Editor { get; set; }
}