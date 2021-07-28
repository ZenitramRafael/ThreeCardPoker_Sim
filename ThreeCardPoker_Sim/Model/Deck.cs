using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCardPoker_Sim.Model
{
    class Deck
    {
        public static List<ICard> ReturnAllCards() {
            List<ICard> cards = new List<ICard>();

            cards.Add(new Card { number = Number.Ace, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Two, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Three, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Four, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Five, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Six, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Seven, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Eight, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Nine, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Ten, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Jack, suit = Suit.Spade });
            cards.Add(new Card { number = Number.Queen, suit = Suit.Spade });
            cards.Add(new Card { number = Number.King, suit = Suit.Spade });

            cards.Add(new Card { number = Number.Ace, suit = Suit.Club });
            cards.Add(new Card { number = Number.Two, suit = Suit.Club });
            cards.Add(new Card { number = Number.Three, suit = Suit.Club });
            cards.Add(new Card { number = Number.Four, suit = Suit.Club });
            cards.Add(new Card { number = Number.Five, suit = Suit.Club });
            cards.Add(new Card { number = Number.Six, suit = Suit.Club });
            cards.Add(new Card { number = Number.Seven, suit = Suit.Club });
            cards.Add(new Card { number = Number.Eight, suit = Suit.Club });
            cards.Add(new Card { number = Number.Nine, suit = Suit.Club });
            cards.Add(new Card { number = Number.Ten, suit = Suit.Club });
            cards.Add(new Card { number = Number.Jack, suit = Suit.Club });
            cards.Add(new Card { number = Number.Queen, suit = Suit.Club });
            cards.Add(new Card { number = Number.King, suit = Suit.Club });

            cards.Add(new Card { number = Number.Ace, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Two, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Three, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Four, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Five, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Six, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Seven, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Eight, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Nine, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Ten, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Jack, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.Queen, suit = Suit.Dimond });
            cards.Add(new Card { number = Number.King, suit = Suit.Dimond });

            cards.Add(new Card { number = Number.Ace, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Two, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Three, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Four, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Five, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Six, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Seven, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Eight, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Nine, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Ten, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Jack, suit = Suit.Heart });
            cards.Add(new Card { number = Number.Queen, suit = Suit.Heart });
            cards.Add(new Card { number = Number.King, suit = Suit.Heart });

            return cards;
        }
    }
}
