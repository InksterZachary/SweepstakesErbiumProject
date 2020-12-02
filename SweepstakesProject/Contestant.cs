using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant 
    {
        public string firstName;
        public string lastName;
        public string email;
        public double registrationNumber;

        public Contestant()
        {
            firstName = UserInterface.GetFirst();
            lastName = UserInterface.GetLast();
            email = UserInterface.GetEmail();
            registrationNumber = UserInterface.AssignRegistrationNumber();
        }
    }
}
