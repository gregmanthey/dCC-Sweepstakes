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
    public int Count { get => contestants.Count; }
    public Sweepstakes(string name)
    {
      this.name = name;
      contestants = new Dictionary<int, Contestant>();
    }

    public void RegisterContestant(Contestant contestant)
    {
      contestant.registrationNumber = contestants.Count + 1;
      contestants.Add(contestant.registrationNumber, contestant);
    }
    public Contestant PickWinner()
    {
      Random rng = new Random();
      int winnerKey = rng.Next(1, contestants.Count + 1); 
      contestants.TryGetValue(winnerKey, out Contestant winner);
      return winner;
    }
    public void PrintContestantInfo(Contestant contestant)
    {
      UI.Display("-----------------------------------------------------------------");
      UI.Display($"               Name: {contestant.FirstName} {contestant.LastName}");
      UI.Display($"      Email Address: {contestant.EmailAddress}");
      UI.Display($"Registration Number: {contestant.registrationNumber}");
      UI.Display("-----------------------------------------------------------------");
      UI.Pause();
    }
  }
}
