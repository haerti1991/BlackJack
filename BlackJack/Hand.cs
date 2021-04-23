using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {

        public List<Card> Handcards { get; set; }
        public int Counter { get; set; }

        public Hand()
        {

            Initialize();
        }

        public void Initialize()
        {
            Handcards = new List<Card>();
        }

        public int GetHandValue()
        {
            int value = 0;

            foreach (Card card in Handcards)
            {
                value += card.Value;
            }
            return value;
        }

        public int Count()
        {
            int count = 0;

            foreach (Card card in Handcards)
            {
                count++;
            }
            return count;
        }

        public void AddCard(Card card)
        {
            Handcards.Add(card);
            Counter++;
        }

    }
}
