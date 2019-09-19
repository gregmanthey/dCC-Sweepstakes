using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
static class UI
  {
    public static Contestant ContestantSetUp()
    {
      string firstName = PromptFor("What is the contestant's first name?", Validation.AlphabetCharacters);
      string lastName = PromptFor("What is the contestant's last name?", Validation.AlphabetCharacters);
      string emailAddress = PromptFor("What is the contestant's email address?", Validation.EmailCharacters);
      return new Contestant(firstName, lastName, emailAddress);
    }
    public static string SweepstakesManagerSetup()
    {
      return PromptFor("Which type of sweepstakes manager would you like? Stack or queue?", Validation.SweepstakesManagerTypes);
    }
    public static string PromptFor(string context, Func<string, bool> valid)
    {
      string userInput;
      do
      {
        Console.WriteLine(context);
        userInput = Console.ReadLine().Trim();
      } while (userInput == null || userInput == "" || !valid(userInput));
      return userInput;
    }
    public static void Display(string content)
    {
      Console.WriteLine(content);
    }
    public static void Pause()
    {
      Console.ReadLine();
      Console.WriteLine("Press Enter to continue.");
    }
  }
}
