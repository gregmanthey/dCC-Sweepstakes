using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
  class Contestant
  {
    string firstName;
    string lastName;
    string emailAddress;
    int registrationNumber;

    public Contestant(string firstName, string lastName, string emailAddress)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.emailAddress = emailAddress;
    }
  }
}
