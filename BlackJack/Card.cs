using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BlackJack.Suit;
using static BlackJack.Face;

namespace BlackJack
{

    public enum Suit
    {
        Kreuz,
        Herz,
        Pik,
        Karo
    }

    public enum Face
    {
        Ass,
        Zwei,
        Drei,
        Vier,
        Fuenf,
        Sechs,
        Sieben,
        Acht,
        Neun,
        Zehn,
        Bube,
        Dame,
        Koenig
    }
    class Card
    {
        public Suit Suit { get; }
        public Face Face { get; }
        public int Value { get; set; }
        public char Symbol { get; }

        public Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;

            switch (Suit)
            {
                case Kreuz:
                    Symbol = '♣';
                    break;
                case Pik:
                    Symbol = '♠';
                    break;
                case Karo:
                    Symbol = '♦';
                    break;
                case Herz:
                    Symbol = '♥';
                    break;
            }

            switch (Face)
            {
                case Zehn:
                case Bube:
                case Dame:
                case Koenig:
                    Value = 10;
                    break;
                case Ass:
                    Value = 1;
                    break;
                default:
                    Value = (int)Face + 1;
                    break;

            }


        }

    }
}
