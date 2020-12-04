using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    interface INotify
    {
        /// <summary>
        /// Sends message to winner congratulating them and all other contestants a message to notify end of sweepstakes.
        /// </summary>
        void CongratulateWinner();
    }
}
