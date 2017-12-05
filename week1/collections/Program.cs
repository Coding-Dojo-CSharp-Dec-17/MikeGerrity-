using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 3 basic arrays
            int[] arrayofIntegers = new int[10] {0,1,2,3,4,5,6,7,8,9};
            string[] arrayofNames = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];

            for(int i = 0; i < 10; i += 2)
            {
                boolArray[i] = true;
            }

            //Multipliaction table
            int[,] mult = new int[10,10]; 
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    mult[x,y] = (x + 1) * (y+1);
                }
            }
            for (int x = 0; x < 10; x++)
            {
                string output = "["; 
                for (int y = 0; y < 10; y++)
                {
                    output += mult[x,y] + ","; 
                    if (mult[x,y] < 10);
                    {
                        output += " "; 
                    }
                }
                output += "]";
                Console.WriteLine(output); 
            }
            //List of Ice Cream Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Rocky Road");
            flavors.Add("Cookie Dough");
            flavors.Add("Neopolotan");
            flavors.Add("Rainbow Sherbet");

            //Output the length of the List
            Console.WriteLine(flavors.Count);

            //Print the 3rd value then remove it
            Console.WriteLine("The third flavor in the list is: " + flavors[2]);
            flavors.RemoveAt(2);

            //Output the updated length of the List of flavors
            Console.WriteLine(flavors.Count);
            

            //User Dictionary Construction
            Dictionary<string, string> userInfo = new Dictionary<string,string>();
            Random rand = new Random();
            foreach(string name in arrayofNames)
            {
                userInfo[name] = flavors[rand.Next(flavors.Count)];
            }

            //Looping through info Dictionary
            Console.WriteLine("Users and their favor ice cream flavors:");
            foreach(KeyValuePair<string, string> info in userInfo)
            {
                Console.WriteLine(info.Key + " - " + info.Value);
            }
        }
    }
}
