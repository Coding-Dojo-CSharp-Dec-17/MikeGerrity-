using System; 
using System.Collections.Generic; 

namespace deckofcards
{
    public class Player
    {
        public string name; 
        public List<Card> hand; 
        public Player(string playerName)
        {
            name = playerName; 
            hand = new List<Card>(); 
        }
        public void Draw(Card card)
        {
            Console.WriteLine($"{name} draws a {card.")
        }
    }
}