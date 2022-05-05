using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
    public string Description { get; set; }
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

    //////////////
    public static ValidationResult ValidatePassword(string password)
    {
      var input = password;

      if (string.IsNullOrWhiteSpace(input))
      {
        // throw new Exception("Password should not be empty");
        return new ValidationResult("Password should not be empty");
      }

      var hasNumber = new Regex(@"[0-9]+");
      var hasUpperChar = new Regex(@"[A-Z]+");
      var hasMiniMaxChars = new Regex(@".{8,100}");
      var hasLowerChar = new Regex(@"[a-z]+");
      var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

      if (!hasLowerChar.IsMatch(input))
      {

        return new ValidationResult("Password should contain at least one lower case letter");
      }
      else if (!hasUpperChar.IsMatch(input))
      {
        return new ValidationResult("Password should contain at least one upper case letter");

      }
      else if (!hasNumber.IsMatch(input))
      {
        return new ValidationResult("Password should contain at least one number");
      }

      else if (!hasSymbols.IsMatch(input))
      {
        return new ValidationResult("Password should contain at least one special character");
      }
      else
      {
        return ValidationResult.Success;
      }
    }
  }
}