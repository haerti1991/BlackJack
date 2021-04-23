using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        private static Deck deck = new Deck();
        private  static Hand dealer = new Hand();
        private static Hand player = new Hand();

        static void Main(string[] args)
        {
            Console.WriteLine("This is Just a TEST");   
            deck.Initialize();

          
            dealer.AddCard(deck.DrawCard());
            dealer.AddCard(deck.DrawCard());

            player.AddCard(deck.DrawCard());
            player.AddCard(deck.DrawCard());

            
            int j = 0;
            foreach (Card card in dealer.Handcards)
            {
                
                Console.WriteLine(dealer.Handcards[j].Suit + " " + dealer.Handcards[j].Face + " " + dealer.Handcards[j].Symbol + dealer.Handcards[j].Value);
                j++;
            }

            Console.WriteLine("Your Handvalue = " + dealer.GetHandValue());
            
        }






    }
}

