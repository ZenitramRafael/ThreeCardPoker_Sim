using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeCardPoker_Sim.Model;

namespace ThreeCardPoker_Sim.Players
{
    class Player
    {
        public enum IsDealer
        {
            Player = 0,
            Dealer = 1
        }

        public IsDealer isDealer { get; set; }
        public Hand hand { get; set; }
    }
}
