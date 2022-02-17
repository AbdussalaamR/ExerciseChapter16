using System;
using System.Collections.Generic;

namespace Chapter16
{
    public class Question3
    {
        public static void Answer()
        {
            List<int> addNum = new List<int>();
        
            while (true)
            {
                Console.Write("Enter the numbers:");
                string num = Console.ReadLine();
                if (num !="")
                {
                    try
                    {
                        int newList = Convert.ToInt32(num);
                        addNum.Add(newList);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Enter any integer or press enter to sort");
                    }
                
                }
                else
                {
                    addNum.Sort();
                    foreach (var item in addNum)
                    {
                        Console.Write(item+",");
                    }
                    break;
                }
            
            }
        
        }
    }
}