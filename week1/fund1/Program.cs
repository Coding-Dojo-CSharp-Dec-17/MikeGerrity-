using System;

namespace fund1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=255; i++)
            {
            Console.WriteLine(i);
            }
            for (int i = 1; i<=100; i++)
            {
                if (i % 3 ==0 || i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
            }
            for (int i = 1; i<=100; i++)
            {
                if (i % 3 ==0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                else if (i % 3 ==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                else if (i % 5 ==0)
                    {
                        Console.WriteLine("Buzz");
                    }    
            }
            for (int i = 1; i<=100; i++)
            {
                float result3 = (float)i/3;
                float result5 = (float)i/5;
                if (result3 ==  (int)i/3  && result5 == (int)i/5)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                else if (result3 == (int)i/3)
                    {
                        Console.WriteLine("Fizz");
                    }
                else if (result5 ==(int)i/5)
                    {
                        Console.WriteLine("Buzz");
                    }    
            }
            Random r = new Random();
            for (int i=0; i<=11; i++)
            {
                int x = r.Next(1,100);
                if (x % 3 ==0 && x % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                else if (x % 3 ==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                else if (x % 5 ==0)
                    {
                        Console.WriteLine("Buzz");
                    }    
            }
        }
    }
}
