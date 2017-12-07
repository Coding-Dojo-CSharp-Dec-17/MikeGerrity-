using System;
using System.Collections.Generic; 

namespace card
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Console.WriteLine(myDeck);
            Player player1 = new Player("Mike");
            myDeck.Shuffle();
            Console.WriteLine($"Hello {player1.name}, Let's Play some cards!"); 
            player1.DrawFrom(myDeck); 
        
        }
    }
}
