using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeCardPoker_Sim.Model;

namespace ThreeCardPoker_Sim
{
    class RunSim
    {
        void PlayGame()
        {
            int cardNo = 4;
            List<ICard> cards = Deck.ReturnAllCards();
            Console.WriteLine("RunSim");
            Console.WriteLine("The {} card is {}", cardNo, cards[cardNo]);
        }
    }
}
