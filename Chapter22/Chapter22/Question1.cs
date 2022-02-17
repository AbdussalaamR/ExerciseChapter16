using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter22
{
    public static class Question1
    {
        public static string Answer(this string word, int index, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                sb.Append(word[i]);
            }

            return sb.ToString();
        }
    }
}