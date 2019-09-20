using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class Program
  {
    static void Main(string[] args)
    {
      string managerChoice = UI.SweepstakesManagerSetup();
      ISweepstakesManager manager = SweepstakesManagerFactory.ChooseSweepstakesManager(managerChoice);
      MarketingFirm firmMarketing = new MarketingFirm(manager);
    }
  }
}
