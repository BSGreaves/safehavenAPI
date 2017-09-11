using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHavenAPI.Models
{
  public class Document
  {
    [Key]
    public int DocumentID { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateCreated { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public int DocumentTypeID {get; set; }
    public DocumentType DocumentType { get; set; }
    public string PhysicalLocation {get; set; }
    public string Notes {get; set; }
  }
}