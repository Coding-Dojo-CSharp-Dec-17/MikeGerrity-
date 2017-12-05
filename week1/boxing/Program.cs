using System;
using System.Collections.Generic; 

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> anyList = new List<object> ();
            // add these items (7,28,-1, true, "chair")
            anyList.Add(7);
            anyList.Add(28);
            anyList.Add(-1);
            anyList.Add(true);
            anyList.Add("chair");

            int total = 0;
            foreach (var item in anyList)
            {
                Console.WriteLine($"{item} is actually item type {item.GetType()}");
                if (item is int)
                {
                    total += (int)item; 
                } 
            }
            Console.WriteLine($"Total of ints = {total}"); 
        }
    }
}
