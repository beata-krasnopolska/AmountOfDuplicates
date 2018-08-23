using System;
using System.Collections.Generic;
using System.Linq;

namespace AmountOfDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>() { 2, 2, 4, 4 };
            
            var dictList = new Dictionary<int, int>();
            foreach(var key in numberList)
            {
                if (dictList.ContainsKey(key))
                    dictList[key]++;
                else
                    dictList.Add(key, 1);
            }
            var numberOfDuplicates = dictList.Values.Where(value => value > 1).Count();
            Console.WriteLine("Total no. of duplicates is {0}", numberOfDuplicates);
            
            Console.Read();
        }
    }
}
