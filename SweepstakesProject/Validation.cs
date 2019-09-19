using System;
using System.Text.RegularExpressions;

namespace SweepstakesProject
{
  class Validation
  {
    public static bool AlphanumericCharactersAndSpace(string input)
    {
      Regex nonAlphaNumericChars = new Regex("[^a-zA-Z0-9 ]");
      if (!nonAlphaNumericChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter only numbers, letters and spaces.");
      return false;
    }
    public static bool AlphabetCharacters(string input)
    {
      Regex nonAlphabetChars = new Regex("[^a-zA-Z]");
      if (!nonAlphabetChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter only letters.");
      return false;
    }
    public static bool EmailCharacters(string input)
    {
      Regex nonAlphabetChars = new Regex("[^a-zA-Z0-9 @.]");
      if (!nonAlphabetChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter email address in the format \"UserName123@example.com\".");
      return false;
    }
    public static bool NumericCharacters(string input)
    {
      Regex nonNumericChars = new Regex("[^0-9]");
      if (!nonNumericChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Invalid input. Please enter only a number.");
      return false;
    }
    public static bool NumericCharactersWithDecimal(string input)
    {
      Regex nonNumericOrDecimalChars = new Regex("[^0-9.]");
      if (!nonNumericOrDecimalChars.IsMatch(input) && input.Contains("."))
      {
        return true;
      }
      Console.WriteLine("Invalid input. Please enter a number with a decimal.");
      return false;
    }

    public static bool SweepstakesManagerTypes(string input)
    {
      if (input.ToLower() == "stack" ||
         input.ToLower() == "queue")
      {
        return true;
      }
      Console.WriteLine("Please enter \"stack\" or \"queue\".");
      return false;
    }


    public static bool YesNo(string input)
    {
      if (input.ToLower() == "yes" ||
          input.ToLower() == "y" ||
          input.ToLower() == "no" ||
          input.ToLower() == "n")
      {
        return true;
      }
      Console.WriteLine("Please enter yes (y) or no (n).");
      return false;
    }
  }
}
