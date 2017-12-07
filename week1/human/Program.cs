using System;

namespace human
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human player1 = new Human("Luke Skywalker",20,1,16,500);
            Human player2 = new Human("Darth Vadar",20,75,88,600);
            player1.Attack(player2);
            Console.WriteLine($"{player1.name} attacks {player2.name}.  {player2.name}'s health is now {player2.health}");
        }
    }
}
