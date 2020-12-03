using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public ISweepstakesManager Manager { get => _manager; set => _manager = value; }
        /// <summary>
        /// MarketingFirm uses Dependency Injection because you have the ability to use either Stack or Queue DataStructure being that both Manager classes inherit from ISweepstakesManager
        /// </summary>
        /// <param name="_manager"></param>
        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager;
        }
        
        public void CreateSweepstakes()
        {
            Console.WriteLine("What is the name of your Sweepstakes?");
            string userInput = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(userInput);
        }
    }
}
