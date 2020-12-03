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
        public Dictionary<double, Contestant> contestants;
        //constructor

        //member methods
        public Contestant Sweepstakes(string name) //I'm not sure what this one is supposed to do. Is this just supposed to be the name of the actual Sweepstakes or retrieve a contestant from the Dictionary?
        {                                          //Either change the name so not a constructor OR delete scope and add name of Sweepstakes
            foreach(KeyValuePair<double,Contestant> person in contestants)
            {
                if(person.Value.lastName == name)
                {
                    return person.Value;
                }
            }
            return null;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber,contestant);
        }
        public Contestant PickWinner()
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
                        System.Threading.Thread.Sleep(250); //Allows new seed for regNumber
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
