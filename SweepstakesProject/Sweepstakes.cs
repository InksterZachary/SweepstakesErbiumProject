using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        //member variables
        public Dictionary<double, Contestant> contestants;
        public string name;
        //constructor
        public Sweepstakes(string name)            
        {                                          
            contestants = new Dictionary<double, Contestant>();
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber,contestant);
        }
        public Contestant PickWinner() //Maybe to make more efficient: Create foreach loop to create list of all available Keys and then pick random number from key list
        {
            Random rand = new Random();
            foreach (KeyValuePair<double, Contestant> person in contestants)
            {
                double regNumber = rand.Next(1, 1000);
                while (person.Key != regNumber)
                {
                    if (person.Key == regNumber)
                    {
                        return person.Value;
                    }
                    else
                    {
                        //System.Threading.Thread.Sleep(250); //Allows new seed for regNumber //Not needed because not using multiple objects
                        regNumber = rand.Next(1, 1000);
                    }
                }
            }
            return null;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1} \n" +
                "{2}",contestant.firstName,contestant.lastName,contestant.email);
        }
    }
}
