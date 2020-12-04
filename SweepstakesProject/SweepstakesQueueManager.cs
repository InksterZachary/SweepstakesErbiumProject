using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>(); //perhaps I should instantiate the queue in an instructor but not sure yet
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes firstInLine = queue.Dequeue();
            return firstInLine;
        }
    }
}
