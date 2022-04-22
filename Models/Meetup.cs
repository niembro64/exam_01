using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace exam_01.Models
{
  public class Meetup
  {
    [Key]
    public int MeetupId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [CustomValidation(typeof(CustomValidationMethods), nameof(CustomValidationMethods.FutureDate))]
    public DateTime Date { get; set; }
    [Required]
    public string Duration_String { get; set; }
    [Required]
    public int Duration_Int { get; set; }

    public int UserId { get; set; }

    public User Creator { get; set; }
    // navigation property
    public List<Reservation> UserList { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }

  public class CustomValidationMethods
  {
    public static ValidationResult FutureDate(DateTime date)
    {
      return DateTime.Compare(date, DateTime.Today) < 0 ? new ValidationResult("Date cannot be in the past") : ValidationResult.Success;
    }
    public static ValidationResult PastDate(DateTime date)
    {
      return DateTime.Compare(date, DateTime.Today) > 0 ? new ValidationResult("Date cannot be in the future") : ValidationResult.Success;
    }

    public static ValidationResult Not18(DateTime date)
    {
      DateTime today = DateTime.Today;
      return DateTime.Compare(date, DateTime.Today.AddYears(-18)) > 0 ? new ValidationResult("Must be at least 18") : ValidationResult.Success;
    }
  }
}