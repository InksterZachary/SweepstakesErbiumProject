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
        public string name;
        //constructor
        public Sweepstakes(string name)            //I'm not sure what this one is supposed to do. Is this just supposed to be the name of the actual Sweepstakes or retrieve a contestant from the Dictionary?
        {                                          //Either change the name so not a constructor OR delete scope and add name of Sweepstakes
                                                   //I deleted return type 'Contestant' and instantiated a new Dictionary because every sweepstakes will have a name and a Dictionary
            contestants = new Dictionary<double, Contestant>();
            this.name = name;
            //foreach(KeyValuePair<double,Contestant> person in contestants)
            //{
            //    if(person.Value.lastName == name)
            //    {
            //        return person.Value;
            //    }
            //}
            //return null;
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
