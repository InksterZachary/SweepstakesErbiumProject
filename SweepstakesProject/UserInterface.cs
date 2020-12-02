using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        public static string GetFirst()
        {
            Console.WriteLine("Please enter your first name");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetLast()
        {
            Console.WriteLine("Please enter your last name");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetEmail()
        {
            Console.WriteLine("Please enter your email");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static double AssignRegistrationNumber() //I want to make this better later: To go through a list of Contestants and assign a number not already given to the new Contestant
        {
            Random num = new Random();
            double regNumber = num.Next(1, 1000);
            Console.WriteLine("Your registration number is {0}.", regNumber);
            return regNumber;
        }
    }
}
