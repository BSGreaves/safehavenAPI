using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHavenAPI.Models
{
  public class User
  {
    [Key]
    public int UserID { get; set; }

    public string FirstName { get; set; } 
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }
    public string Street { get; set;}

    [Range(0, 99999)]
    public int ZIP { get; set; }
    public string State {get; set; }
    public ICollection<Document> Documents;
    public ICollection<AccessRight> AccessGranted;
    public ICollection<AccessRight> AccessAllowed;
  }
}