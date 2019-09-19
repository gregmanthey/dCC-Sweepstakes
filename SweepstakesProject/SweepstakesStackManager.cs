using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class SweepstakesStackManager : ISweepstakesManager
  {
    Stack<Sweepstakes> sweepstakesStack;

    public SweepstakesStackManager()
    {
      sweepstakesStack = new Stack<Sweepstakes>();
    }
    public Sweepstakes GetSweepstakes()
    {
      throw new NotImplementedException();
    }

    public void InsertSweepstakes(Sweepstakes sweepstakes)
    {
      throw new NotImplementedException();
    }
  }
}
