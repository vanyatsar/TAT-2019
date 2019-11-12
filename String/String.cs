using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class String
    {
        string word;

        public String(string word) 
        {
            this.word = word;
        }

        public void CheckRussianSymdols()
        {
            for (int i = 0; i < this.word.Length; i++)
            {
                if (!(this.word[i] >= 'А' && this.word[i] <= 'я'))
                {
                    throw new NotRussianSymbol("Input only russian symbols!");
                }
            }
        }
    }
}
