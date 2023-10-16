using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    //Card is a model - Models are meant to contain and represent data 
    internal class Card
    {
        //1) Properties - Suit, Value: number values, Jack, Queen, King, Joker (get set) 
        //2) Constructors - fill in values via parameters, no other setup is needed
        //3) Methods - Random Generate card and shuffling
        //You should ask yourself, which parts will I need, and what do those want to have in them. 

        public string Suit { get; set; } 
        public int Value { get; set; } 

        public Card(string suit, int value) {
            Suit = suit; 
            Value = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Value: " +Value +" of "+  Suit);
        }

        public static Card GetRandomCard()
        {
            Random r = new Random();
            int value = r.Next(1, 15);

            string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            int suitPick = r.Next(0, suits.Length);
            string suit = suits[suitPick];

            //New keyword means we're calling a constructor 
            Card output = new Card(suit, value);
            return output;
        }
    }
}
