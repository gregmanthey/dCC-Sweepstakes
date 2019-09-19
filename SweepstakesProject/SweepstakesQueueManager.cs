using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class SweepstakesQueueManager : ISweepstakesManager
  {
    Queue<Sweepstakes> sweepstakesQueue;

    public SweepstakesQueueManager()
    {
      sweepstakesQueue = new Queue<Sweepstakes>();
    }
    public Sweepstakes GetSweepstakes()
    {
      return sweepstakesQueue.Dequeue();
    }

    public void InsertSweepstakes(Sweepstakes sweepstakes)
    {
      sweepstakesQueue.Enqueue(sweepstakes);
    }
  }
}
