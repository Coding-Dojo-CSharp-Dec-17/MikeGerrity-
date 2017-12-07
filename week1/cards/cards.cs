using System; 
using System.Collections.Generic; 

namespace deckofcards
{
    public class Card
    {
        public string stringVal;
        public string suit; 
        public int val; 
        string [] cardNames = {
            "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", 
            "Nine", "Ten", "Jack", "Queen", "King"
            }; 
        string [] suitNames = {
            "Clubs", "Spades", "Hearts", "Diamonds"
            };    
        public Card(int suitnum, int cardnum)
        {
            stringVal = cardNames[cardnum]; 
            suit = suitNames[suitnum]; 
            val = cardnum + 1; 
        }
    }
}