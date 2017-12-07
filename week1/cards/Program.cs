using System;
using System.Collections.Generic; 
namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck(); 
            mydeck.Shuffle();
            Player player1 = new Player("Doyle Brunson"); 
            player1.Draw(mydeck.Deal()); 
        }
    }
}
