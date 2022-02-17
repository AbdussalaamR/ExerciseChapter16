using System;
using System.Collections;

namespace Chapter16
{
    public class Question6
    {
        public static void Answer()
        {
            Hashtable myHashtable = new Hashtable();
            int[] arr = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (myHashtable.ContainsKey(arr[i]))
                {
                    myHashtable[arr[i]] = (int)myHashtable[arr[i]] + 1;
                }
                else
                {
                    myHashtable.Add(arr[i],1);
                }
            }

            foreach (DictionaryEntry item in myHashtable)
            {
                if ((int)item.Value % 2 == 0)
                {
                    for (int i = 0; i < (int)item.Value; i++)
                    {
                        Console.Write(item.Key+",");
                    }
                }
            }
        }
    }
}