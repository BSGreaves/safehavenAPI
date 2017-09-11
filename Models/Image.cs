using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHavenAPI.Models
{
  public class Image
  {
    [Key]
    public int ImageID { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateCreated { get; set; }
    [Required]
    public int DocumentID {get; set; }
    public Document Document { get; set; }
    [Required]
    public int PageNumber { get; set; }
    [Required]
    public string FilePath {get; set; }
  }
}