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

    public MarketingFirm(ISweepstakesManager sweepstakesManager)
    {
      this.sweepstakesManager = sweepstakesManager;
    }
    public void AddContestant()
    {
      currentSweepstakes.RegisterContestant(UI.ContestantSetUp());
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
