using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  public static class UI
  {
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
  }
}
