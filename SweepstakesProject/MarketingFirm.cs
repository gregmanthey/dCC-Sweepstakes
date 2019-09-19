using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class MarketingFirm
  {
    ISweepstakesManager sweepstakesManager;
    Sweepstakes currentSweepstakes;

    public void AddContestant()
    {
      string firstName = UI.PromptFor("What is the contestant's first name?", Validation.AlphabetCharacters);
      string lastName = UI.PromptFor("What is the contestant's last name?", Validation.AlphabetCharacters);
      string emailAddress = UI.PromptFor("What is the contestant's email address?", Validation.EmailCharacters);
      Contestant contestant = new Contestant(firstName, lastName, emailAddress);
      currentSweepstakes.RegisterContestant(contestant);
    }
    public void BeginSweepstakes()
    {
      Sweepstakes newSweepstakes = new Sweepstakes(UI.PromptFor("What do you want to name the sweepstakes?", Validation.AlphanumericCharactersAndSpace));
      sweepstakesManager.InsertSweepstakes(newSweepstakes);
    }
    public void EndSweepstakes()
    {
      Sweepstakes finishedSweepstakes = sweepstakesManager.GetSweepstakes();
      Contestant winner = finishedSweepstakes.PickWinner();
      finishedSweepstakes.PrintContestantInfo(winner);
    }
  }
}
