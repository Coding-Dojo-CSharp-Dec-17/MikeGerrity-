using System; 
using System.Collections.Generic; 

namespace deckofcards
{
    public class Deck
    {
        private static Random rand = new Random(); 
        public List<Card> cards;
        public void Shuffle()
        {
            
            for(int i= 0; i < cards.Count/2; i++)
            {
                Card temp = cards[i]; 
                int randomIdx = rand.Next(i, cards.Count); 
                cards[i] = cards[randomIdx]; 
                cards[randomIdx] = temp; 
            }
        }

        public Deck(); 
        {
            InitializeDeck();
        } 
        public void Deck Reset()
        {
            InitializeDeck();
        }
        public Card Deal()
        {
            Card cardPulled = cards[0];
            cards.RemoveAt(0); 
            return cardPulled;  

        }
        private void InitializeDeck()
        {
            cards = new List<Card>(); 
            for(int suitnum = 0; suitnum < 4; suitnum++)
            {
                for(int cardnum = 0; cardnum < 13; cardnum++)
                {
                    cards.Add(new Card(suitnum, cardnum)); 
                }
            }
        }
    }
}