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
    public int registrationNumber;
    string FirstName { get => firstName; }
    string LastName { get => lastName; }
    string EmailAddress { get => emailAddress; }

    public Contestant(string firstName, string lastName, string emailAddress)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.emailAddress = emailAddress;
    }
  }
}
