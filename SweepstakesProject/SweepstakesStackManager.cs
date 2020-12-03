using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Sweepstakes in stack: ");
            foreach(Sweepstakes contest in stack)
            {
                Console.WriteLine(contest);
            }
            Sweepstakes topOfStack = stack.Pop();
            return topOfStack;
        }
    }
}
