using System;
using System.Collections.Generic; 

namespace basic13
{
    public class Program
    {
        //Print nums 1-255
        public static void printNums(int num)
        {
            for (int i = 0; i <=255; i++)
            {
                num = i; 
                Console.WriteLine(num);
            }
        }    
        //Print odd numbers 1-255
        public static void printOdds(int odd)
        {
            for(int i=0; i <=255; i++)
            {
                if(i % 2 != 0)
                {
                    odd = i;
                    Console.WriteLine($"{odd}");
                }
            }
        }
        // print number and running total from 1-255
        public static void sumOfNums(int sum)
        {
            for(int i=0; i <=255; i++)
            {
                sum += i; 
                Console.WriteLine($"New Number is {i} Sum is {sum}");
            }
        }
        //iterate trough an array

        public static void funWithArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The value of array location {i} is {arr[i]} ");
            }
        }
        public static void findMax(int[] max)
        {
            int maxNum = max[0]; 
            for(int i = 0; i < max.Length; i++)
            {
                if(maxNum < max[i])
                {
                    maxNum = max[i];
                }
            }
            Console.WriteLine($"The max number in the array is {maxNum}");
        }
        public static void findAvg(int[] avg)
        {
            int total = avg[0]; 
            int denominator = avg.Length; 
            for(int i = 0; i < avg.Length; i++)
            {
                total += avg[i];  
            }
            double finalAvg = (float)total/(float)denominator; 
            Console.WriteLine($"The average of the array is {finalAvg}");
        }
        public static void oddArray()
        {
            List<int> oddList = new List<int>(); 

            for(int i=0; i <=255; i++)
            {
                if(i % 2 != 0)
                {
                    oddList.Add(i); 
                }
            }
            int[] newArray = new int[oddList.Count]; 
            for (int i = 0; i < oddList.Count; i++)
            {
                newArray[i] = oddList[i]; 
                Console.WriteLine(newArray[i]);                                 
            }         
        }
        public static void greaterThanY(int[] arr, int y)
        {
            int ycount = 0; 
            foreach(int item in arr)
            {
                if (item > y)
                {
                    ycount ++;
                }
            }
            Console.WriteLine($"There are {ycount} values greater than {y} in this array"); 
        }
        public static void squareValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i]; 
            }
            Console.WriteLine(String.Join(", ", arr));
        }
        public static void byeByeNegatives(int [] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] <0)
                {
                    arr[i] = 0; 
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }
        public static void minMaxAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            double total = 0; 
            double denom = arr.Length; 
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i]; 
                } 
                if (max < arr[i])
                {
                    max = arr[i]; 
                }
                total +=arr[i]; 
            }
            double avg = total/denom; 
            Console.WriteLine($"The minimum value is {min}: The maximum value is {max}:  The average value is {avg}");
        }
        public static void shifty(int[] arr)
        {
            for (int i = 0; i<(arr.Length-1); i++)
            {
                arr[i] = arr[i+1]; 
            }
            arr[arr.Length-1] = 0;
            Console.WriteLine(String.Join(", ", arr));
        }
        public static object numToString(object[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if((int)arr[i] < 0)
                {
                    arr[i] = "Dojo"; 
                }
            }
            return arr; 
        }
        public static void Main(string[] args)
        {
            printNums(0);
            printOdds(0); 
            sumOfNums(0);
            int[] myArr = new int[6] {1,3,5,7,9,13};  
            funWithArray(myArr);  
            findMax(myArr); 
            findAvg(myArr); 
            oddArray(); 
            greaterThanY(myArr, 4);
            squareValues(myArr); 
            byeByeNegatives(myArr); 
            shifty(myArr); 
            minMaxAvg(myArr); 
            object[] boxedArray = new object[] {1,5,-9,15,-20}; 
            numToString(boxedArray);
        }
            
    }
}
