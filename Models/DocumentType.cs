using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHavenAPI.Models
{
  public class DocumentType
  {
    [Key]
    public int DocumentTypeID { get; set; }
    [Required]
    public string Title { get; set; }
    public ICollection<Document> Documents;
  }
}