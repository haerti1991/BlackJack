using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BlackJack
{

    

    class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            Initialize();
        }

    public static List<Card> GetColdDeck()
        {
            List<Card> coldDeck = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    coldDeck.Add(new Card((Suit)j, (Face)i));
                }
            }

            return coldDeck;
        }

        public Card DrawCard()
        {
            Card card = cards[0];
            cards.Remove(card);

            return card;
        }
        
        

          
    public void Initialize()
        {
            cards = GetColdDeck();
            cards.Shuffle();
        }
    
    
    
    }




    // Deck initialisieren



    //Deck shuffle



    //












}
