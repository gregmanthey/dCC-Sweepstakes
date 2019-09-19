using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  static class SweepstakesManagerFactory
  {
    public static ISweepstakesManager ChooseSweepstakesManager(string choice)
    {
      ISweepstakesManager sweepstakesManager = null;
      switch (choice)
      {
        case "queue":
          sweepstakesManager = new SweepstakesQueueManager();
          break;
        case "stack":
          sweepstakesManager = new SweepstakesStackManager();
          break;
        default:
          break;
      }
      return sweepstakesManager;
    }
  }
}
