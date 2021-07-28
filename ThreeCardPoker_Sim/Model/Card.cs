using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCardPoker_Sim.Model
{
    public class Card : ICard
    {
        public Number number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Suit suit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
