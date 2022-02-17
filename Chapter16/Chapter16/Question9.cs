using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter16
{
    public class Question9
    {
        public static void Answer()
        {
            var N = 2;
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(N);
            for (int i = 0; i < 50; i++)
            {
                var M = myQueue.Dequeue();
                Console.Write(M + " ");
                myQueue.Enqueue(M + 1);
                myQueue.Enqueue(2 * M + 1);
                myQueue.Enqueue(  M + 2);
            }
            
        }
    }
}