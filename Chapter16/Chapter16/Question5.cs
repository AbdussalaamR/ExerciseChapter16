using System;
using System.Collections.Generic;

namespace Chapter16
{
    public class Question5
    {
        public static void Answer()
        {
            int[] arr = { 19, -10, 12, -6, -3, 34, -2, 5 };
            Queue<int> myQueue = new Queue<int>();
            foreach (var item in arr)
            {
                if (item >= 0)
                {
                    myQueue.Enqueue(item);
                }
            }

            foreach (var num in myQueue)
            {
                Console.Write(num+",");
            }
        }
    }
}