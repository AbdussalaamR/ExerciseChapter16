using System;
using System.Collections.Generic;

namespace Chapter16
{
    public class Question4
    {
        public static void TestAnswer()
        {
            int[] array = { 1, 2, 2, 1, 1, 2, 2, 2, 2,3,3, 3, 3, 3 };
            Question4.Answer(array);
        }
        public static void Answer(int[]arr)
        {
            //int[] arr = { 1, 2, 2, 1,1,1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };
            int counter = 1;
            int occuredMost = 0;
            int bestCounter = 0;

            for (int n = 1; n < arr.Length; n++)
            {
                if (arr[n] == arr[n - 1])
                {
                    counter++;
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        occuredMost = arr[n];

                    }
                }
            
                else
                {
                    counter = 1;
                }
            }
            List<int> myList = new List<int>();
            for(int i =0; i<bestCounter; i++)
            {
                myList.Add(occuredMost);
            }
        
            foreach (var num in myList)
            {
                Console.Write(num+", ");
            }
        }
    }
}