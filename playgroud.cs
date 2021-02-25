using System;
using System.Collections.Generic;

namespace standardCsharp
{
    class Program
    {
       
        /** : Problem :
         *   
         *   
         *  : Constraints : 
         *  
         *  
         *  : Assumptions :
         *  
         *   
         *  : Inputs :
         *   
         *    
         *  : Outputs :
         *  
         *    
         *  : Tests : easy :
         *     
         *          
         *  Data Structures :
         * 
         *                  
         *  Algorithm Design :
         *          
         *  Time : O()
         *  Space : O()
        */
        static string ReverseWords(string s)
        {
            string[] split = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(split);
            return String.Join(" ", split);

           
            
        }

        public static int[] QuickSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSort(arr, start, pivot);
                QuickSort(arr, pivot + 1, end);
            }
            return arr;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }

        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int swapIndex = start;
            for(int i = start + 1; i < end; i++)
            {
                if(arr[i]<pivot)
                { 
                    swapIndex++;
                    Swap(arr, i, swapIndex);
           
                }

            }
            Swap(arr, start, swapIndex);
            return swapIndex;
        }

        static void Main(string[] args)
        {
            var arrr = new[] { 4, 1, 2, -1, 24, 100, -2 };
            var sorted = QuickSort(arrr, 0, arrr.Length);
            foreach(var item in sorted)
            {
                Console.Write(item + " ");
            }

            RedCar rc = new RedCar();
            rc.printB();

            BlueCar bc = new BlueCar();
            bc.printB();

            string test = " the  sky    is   blue ";
            char[] arr = test.ToCharArray();
            if (!char.IsLetter(arr[0]))
            {

            }


            test = ReverseWords(test);
            Console.WriteLine(test);
            string ans = new string(arr);
            Console.WriteLine(ans);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("a", 1);
            dict.Add("b", 2);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            int x;
            dict.TryGetValue("a", out x);
            Console.WriteLine(x);
        }

    }

    public abstract class BaseCar
    {
        public virtual void printB()
        {
            Console.WriteLine("i'm the BaseCar");
        }
    }
    public class BlueCar : BaseCar
    {
        public override void printB()
        {
            Console.WriteLine("i'm BlueCar");
        }
    }
    public class RedCar : BaseCar
    {
        
    }

    

}
