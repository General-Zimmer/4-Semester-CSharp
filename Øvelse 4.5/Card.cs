using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._5
{
    internal class Card
    {

        public Suit suit;
        public Number number;



        public Card(Suit suit, Number number)
        {
            this.suit = suit;
            this.number = number;
        }

        public override string ToString()
        {
            return number + " of " + suit;
        }



        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum Number
        {
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
            King = 13,
            Ace = 14
        }
    }
}
