﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class Sweepstakes
  {
    string name;
    int count;
    Dictionary<int, Contestant> contestants;
    public int Count { get => count; }
    public Sweepstakes(string name)
    {
      this.name = name;
      contestants = new Dictionary<int, Contestant>();
      count = 0;
    }

    public void RegisterContestant(Contestant contestant)
    {
      count++;
      contestant.registrationNumber = count;
      contestants.Add(contestant.registrationNumber, contestant);
    }
    public Contestant PickWinner()
    {
      Contestant winner;
      Random rng = new Random();
      int winnerKey = rng.Next(1, contestants.Count); 
      contestants.TryGetValue(winnerKey, out winner);
      return winner;
    }
    public void PrintContestantInfo(Contestant contestant)
    {

    }
  }
}
