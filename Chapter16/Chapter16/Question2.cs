using System;
using System.Collections.Generic;

namespace Chapter16
{
    public class Question2
    {
        public static void Answer()
        {
            Stack<int> myStack = new Stack<int>();
            Console.Write("Enter the number of integer you want to enter:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= lenght; i++)
            {
                Console.Write($"Enter number {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                myStack.Push(num);
            }

            foreach (var item in myStack)
            {
                Console.Write(item+",");
            }
        }
    }
}