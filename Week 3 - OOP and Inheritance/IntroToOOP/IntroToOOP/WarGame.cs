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
        int Round { get; set; } = 1; 
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
            Console.WriteLine();
            Console.WriteLine("Round: "+Round);
            Round++;
            if (p1Deck.Count == 0)
            {
                if(p1Discard.Count == 0)
                {
                    Console.WriteLine("Player 1 loses");
                    return;
                }
                else
                {
                    Shuffle(p1Discard);
                    p1Deck.AddRange(p1Discard);
                    p1Discard.Clear();
                }
            }

            if(p2Deck.Count == 0)
            {
                if(p2Discard.Count == 0)
                {
                    Console.WriteLine("Player 2 loses");
                    return;
                }
                else
                {
                    Shuffle(p2Discard);
                    p2Deck.AddRange(p2Discard);
                    p2Discard.Clear();
                }
            }
            Card p1 = p1Deck[0];
            Card p2 = p2Deck[0];
            //Card p1 = new Card("Hearts", 5);
            //Card p2 = new Card("Hearts", 5);
            p1Deck.Remove(p1);
            p2Deck.Remove(p2);
            Console.WriteLine("Player 1 draws: ");
            p1.PrintInfo();
            Console.WriteLine("Player 2 draws: ");
            p2.PrintInfo();
            if (p1.Value > p2.Value)
            {
                //Player 1 wins the round 
                p1Discard.Add(p1);
                p1Discard.Add(p2);
                Console.WriteLine("Player 1 wins the round");
            }
            else if(p2.Value > p1.Value)
            {
                p2Discard.Add(p1);
                p2Discard.Add(p2);
                Console.WriteLine("Player 2 wins the round");
            }
            else if(p2.Value == p1.Value) 
            {
                Console.WriteLine("Draw, let's the next cards");
            }

            RunTurn();
        }

    }
}
