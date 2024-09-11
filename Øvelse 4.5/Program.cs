using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._5
{
    internal class Program
    {
        public delegate bool FilterCard(Card card);
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Number number in Enum.GetValues(typeof(Card.Number)))
                {
                    cards.Add(new Card(suit, number));
                }
            }

            List<Card> filteredCards = Filter(cards, isEven);
            foreach (Card card in filteredCards)
            {
                Console.WriteLine(card);
            }
            Console.ReadLine();
        }

        public static List<Card> Filter(List<Card> cards, FilterCard filter)
        {
            List<Card> filteredCards = new List<Card>();
            foreach (Card card in cards)
            {
                if (filter(card))
                {
                    filteredCards.Add(card);
                }
            }
            return filteredCards;
        }

        public static bool isEven(Card card)
        {
            return ((int)card.number) % 2 == 0;
        }
    }
}
