using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCardPoker_Sim.Model
{
    public class Card : ICard
    {
        public Number number { get; set; }
        public Suit suit { get; set; }
    }
}
