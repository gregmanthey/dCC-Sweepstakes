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

    void BeginSweepstakes()
    {
      Sweepstakes newSweepstakes = new Sweepstakes(UI.PromptFor("What do you want to name the sweepstakes?", Validation.AlphanumericCharactersAndSpace));
      sweepstakesManager.InsertSweepstakes(newSweepstakes);
    }
    void EndSweepstakes()
    {
      Sweepstakes finishedSweepstakes = sweepstakesManager.GetSweepstakes();
      Contestant winner = finishedSweepstakes.PickWinner();
      //notify winner
    }
  }
}
