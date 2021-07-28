using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCardPoker_Sim.Model
{
    public enum Suit
    {
        Spade = 1,
        Club = 2,
        Dimond = 3,
        Heart = 4
    }

    public enum Number
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    public interface ICard
    {
        public Number number { get; set; }
        public Suit suit { get; set; }
    }
}
