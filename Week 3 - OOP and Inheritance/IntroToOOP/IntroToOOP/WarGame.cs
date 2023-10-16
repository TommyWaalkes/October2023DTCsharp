using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    //This is a runner class, its job is to delegate to other classes decide who needs to run and when 
    //Most functionality lives in runner classes 
    internal class WarGame
    {
        //1) Properties - wins and losses, players (actually lets make a plsyer class), deck lists 
        //2) Constructors - Player1 and Player2 objects, fill out decks 
        //3) Methods - game logic - compare the draws between the 2 players
        List<Card> p1Deck { get; set; } = new List<Card>();
        List<Card> p2Deck { get; set; } = new List<Card>();
        int currentDeckIndex = 0; 
        List<Card> p1Discard { get; set; } = new List<Card>();
        List<Card> p2Discard { get; set; } = new List<Card>();

        public WarGame() { 
            for(int i = 0; i < 10; i++)
            {
                Card p1Card = Card.GetRandomCard();
                Card p2Card = Card.GetRandomCard();
                p1Deck.Add(p1Card);
                p2Deck.Add(p2Card);
            }
            Shuffle(p2Deck);
            Shuffle(p1Deck);

        }

        public void Shuffle(List<Card> deck)
        {
            Random r = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        public void RunTurn()
        {
            Card p1 = p1Deck[currentDeckIndex];
            Card p2 = p2Deck[currentDeckIndex];

            if(p1.Value > p2.Value)
            {
                //Player 1 wins the round 
                p1Deck.Remove(p1);
                p2Deck.Remove(p2);
                p1Discard.Add(p1);
                p1Discard.Add(p2);
            }
        }

    }
}
