using System;
using System.Collections.Generic;

namespace AmountOfDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array");
            int elements = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[100];
            int duplicates = 0;

            Console.WriteLine("Enter a number in the array");
            for (int i = 0; i < elements; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Element {0} : {1}", i, arr1[i]);
            }
            var dict = new Dictionary<int, int>();
            foreach (var value in arr1)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }
            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                    duplicates++;
            }
            Console.WriteLine("Total no of duplicates {0}", duplicates - 1);

            //for (int i=0; i<= elements; i++)
            //{
            //    for (int j =1; j<= elements; j++)
            //    {
            //        if(arr1[i] == arr1[j])
            //        {
            //            duplicates++;
            //        }                    
            //    }                
            //}
            //Console.WriteLine("Total no. of duplicates is {0}", duplicates);

            Console.Read();
        }
    }
}
