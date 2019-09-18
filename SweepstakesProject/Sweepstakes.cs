using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class Sweepstakes
  {
    string name;
    Dictionary<int, Contestant> contestants;
    public Sweepstakes(string name)
    {
      this.name = name;
    }

    void RegisterContestant(Contestant contestant)
    {

    }
    Contestant PickWinner()
    {
      Contestant winner;
      Random rng = new Random();
      int winnerKey = rng.Next(1, contestants.Count); 
      contestants.TryGetValue(winnerKey, out winner);
      return winner;
    }
    void PrintContestantInfo(Contestant contestant)
    {

    }
  }
}
