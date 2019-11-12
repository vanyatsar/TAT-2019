using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public static class StringExtension
    {
        const string vowels = "уеыаоэяиюУЕЫАОЭЯИЮ";
        const string consonants = "йцкнгшщзхфвпрлджчсмтбЙЦКНГШЩЗХФВПРЛДЖЧСМТБ";

        public static int ConsonantsCount(this string word)
        {
            int consonantsCounter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (consonants.Contains(word[i]))
                {
                    consonantsCounter++;
                }
            }
            return consonantsCounter;
        }
        public static int VowelsCount(this string word)
        {
            int vowelsCounter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    vowelsCounter++;
                }
            }
            return vowelsCounter;
        }

        public static StringBuilder ReverseString(this string word)
        {
            StringBuilder wordForReverse = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                wordForReverse.Append(word[word.Length - 1 - i]);
            }
            return wordForReverse;
        }
        
    }
}
