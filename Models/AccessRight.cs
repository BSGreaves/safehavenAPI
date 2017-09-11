using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHavenAPI.Models
{
  public class AccessRight
  {
    [Key]
    public int AccessRightID { get; set; }
    [Required]
    public int GrantorID { get; set; }
    [Required]
    public int AccessorID { get; set; }
    public User Grantor { get; set; }
    public User Accessor { get; set; }
  }
}