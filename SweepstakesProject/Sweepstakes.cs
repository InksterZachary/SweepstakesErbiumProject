using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes : INotify
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
            contestants.Add(contestant.registrationNumber, contestant);
        }
        
        public Contestant PickWinner() //Maybe to make more efficient: Create foreach loop to create list of all available Keys and then pick random number from key list
        {
            Random rand = new Random();
            foreach (KeyValuePair<double, Contestant> person in contestants)
            {
                double winNumber = rand.Next(1, 1000);
                while (person.Key != winNumber)
                {
                    if (person.Key == winNumber)
                    {
                        return person.Value;
                    }
                    else
                    {
                        winNumber = rand.Next(1, 1000);
                    }
                }
            }
            return null;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1} \n" +
                "{2}", contestant.firstName, contestant.lastName, contestant.email);
        }
        public void CongratulateWinner() //The idea is that when calling PickWinner we will have already assigned it it's value. Does this keep calling for a new winner?
        {
            foreach(KeyValuePair<Double,Contestant> players in contestants)
            {
                if(players.Key != PickWinner().registrationNumber)
                {
                    Console.WriteLine("Message to all contestants, we have just picked the lucky winner and this player's name is: " + PickWinner().firstName + " " + PickWinner().lastName);
                }
                else
                {
                    Console.WriteLine("Congratulations "+PickWinner().firstName+PickWinner().lastName+"\n" +
                        "An email has been delivered to: "+PickWinner().email+"\n" +
                        "Please contact our offices as soon as you recieve your confirmation email, thank you!");
                }
            }
        }
    }
}
