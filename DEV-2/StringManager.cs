using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    public class StringManager
    {
        private int MaxNumberOfUnequalConsecutiveCharacters { get; set; }
        private int MaxNumberOfIdenticalConsecutiveDigits { get; set; }
        private int MaxNumberOfIdenticalConsecutiveLatinCharacters { get; set; }

        public void Testing(string inputString)
        {
            MaxNumberOfUnequalConsecutiveCharacters = GetMaxNumberOfUnequalConsecutiveCharacters(inputString);
            MaxNumberOfIdenticalConsecutiveDigits = GetMaxNumberOfIdenticalConsecutiveDigits(inputString);
            MaxNumberOfIdenticalConsecutiveLatinCharacters = GetMaxNumberOfIdenticalConsecutiveLatinCharacters(inputString);
            
        }
        public int GetMaxNumberOfUnequalConsecutiveCharacters(string str)
        {
            int temp = 1;
            int maxCount = 0;

            if (CheckingForEmptyString(str))
            {
                return 0;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    temp++;
                }
                else
                {
                    temp = 1;
                }
                if (temp > maxCount)
                {
                    maxCount = temp;
                }
            }
            return maxCount;
        }

        public int GetMaxNumberOfIdenticalConsecutiveDigits(string str)
        {
            int temp = 1;
            int maxCount = 0;

            if (CheckingForEmptyString(str))
            {
                return 0;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (!(str[i] > 47 && str[i] < 58))
                {
                    continue;
                }

                if (str[i] == str[i - 1] && (str[i] > 47 && str[i] < 58))
                {
                    temp++;
                }
                else
                {
                    if (temp > maxCount)
                    {
                        maxCount = temp;
                    }
                    temp = 1;
                }
            }
            return maxCount;
        }
 
        public int GetMaxNumberOfIdenticalConsecutiveLatinCharacters(string str)
        {
            int temp = 1;
            int maxCount = 0;

            if (CheckingForEmptyString(str))
            {
                return 0;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (!(str[i] > 64 && str[i] < 91 || (str[i] > 96 && str[i] < 123)))
                {
                    continue;
                }

                if (str[i] == str[i - 1] && (str[i] > 64 && str[i] < 91 || (str[i] > 96 && str[i] < 123)))
                {
                    temp++;
                }
                else
                {
                    if (temp > maxCount)
                    {
                        maxCount = temp;
                    }
                    temp = 1;
                }
            }
            return maxCount;   
        }

        public void DisplayResults()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine(stringBuilder.Append("MaxNumberOfUnequalConsecutiveCharacters: " + MaxNumberOfUnequalConsecutiveCharacters +
                "\n" + "MaxNumberOfIdenticalConsecutiveDigits: " + MaxNumberOfIdenticalConsecutiveDigits +
                "\n" + "MaxNumberOfIdenticalConsecutiveLatinCharacters: " + MaxNumberOfIdenticalConsecutiveLatinCharacters));
        }
        private bool CheckingForEmptyString(string str) => String.IsNullOrEmpty(str);
    }

}
    

