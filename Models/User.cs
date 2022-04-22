using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace exam_01.Models
{
  public class User
  {
    [Key]
    public int UserId { get; set; }
    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(255, MinimumLength = 8)]
    public string Password { get; set; }
    [NotMapped]
    [DataType(DataType.Password)]
    [StringLength(255, MinimumLength = 8)]
    [Compare("Password")]
    public string Confirm { get; set; }

    // navigation property
    public List<Meetup> MeetupsCreated { get; set; }
    public List<Reservation> MeetupList { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}