using System.Globalization;

namespace Chapter22
{
    public static class Question7
        {
            public static string Question6(this string word)
            {
                var  capitalise = new CultureInfo("en-US", false).TextInfo.ToTitleCase(word);
                return capitalise;
            }
    }
}