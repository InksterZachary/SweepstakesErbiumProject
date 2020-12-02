using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //member variables
        Dictionary<double, Contestant> contestants;
        //constructor

        //member methods
        public string Sweepstakes(string name)
        {

        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber,contestant);
        }
        public Contestant PickWinner()
        {

        }
        public void PrintContestantInfo()
        {

        }
    }
}
