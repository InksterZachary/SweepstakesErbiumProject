using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Simulation : IFactoryDesign
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm newFirm = new MarketingFirm(ManagerStyleChoice());
            newFirm.CreateSweepstakes();
        }
        public ISweepstakesManager ManagerStyleChoice()
        {
            Console.WriteLine("Please choose your managerial style:\n" +
                "type (1) for Stack\n" +
                "type (2) for Queue");
            string userInput = Console.ReadLine();
            int val = Convert.ToInt16(userInput);
            if (val == 1)
            {
                MarketingFirm stackManager = new MarketingFirm(new SweepstakesStackManager());
                SweepstakesStackManager stackMan = new SweepstakesStackManager();
                return stackMan;
            }
            else if (val == 2)
            {
                MarketingFirm queueManager = new MarketingFirm(new SweepstakesQueueManager());
                SweepstakesQueueManager queueMan = new SweepstakesQueueManager();
                return queueMan;
            }
            else
            {
                ManagerStyleChoice();
            }
            return null;
        }
    }
}
