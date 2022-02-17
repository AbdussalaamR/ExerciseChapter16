using System;
using System.Collections.Generic;

namespace Chapter16
{
    public class Question7
    {
        public static void Answer()
        {
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            int[] arr = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            foreach (var num in arr)
            {
                if (myDictionary.ContainsKey(num))
                {
                    myDictionary[num] = myDictionary[num] + 1;
                }
                else
                {
                    myDictionary.Add(num,1);
                }
            
            }
            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}