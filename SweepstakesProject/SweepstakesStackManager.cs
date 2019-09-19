﻿using System;
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
      return sweepstakesStack.Pop();
    }

    public void InsertSweepstakes(Sweepstakes sweepstakes)
    {
      sweepstakesStack.Push(sweepstakes);
    }
  }
}
