using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_3
{
    public class Translit
    {         
        private readonly Dictionary<string, string> _dictionaryRussianToLatin = new Dictionary<string, string>()
        {
            {"А","A"},
            {"Б","B"},
            {"В","V"},
            {"Г","G"},
            {"Д","D"},
            {"Е","E"},
            {"Ё","YO"},
            {"Ж","ZH"},
            {"З","Z"},
            {"И","I"},
            {"Й","Y"},
            {"К","K"},
            {"Л","L"},
            {"М","M"},
            {"Н","N"},
            {"О","O"},
            {"П","P"},
            {"Р","R"},
            {"С","S"},
            {"Т","T"},
            {"У","U"},
            {"Ф","F"},
            {"Х","H"},
            {"Ц","C"},
            {"Ч","CH"},
            {"Ш","SH"},
            {"Щ","SCH"},
            {"Ъ","'"},
            {"Ы","YI"},
            {"Ь",""},
            {"Э","E"},
            {"Ю","YU"},
            {"Я","YA"}
        };
        
        private readonly Dictionary<string, string> _dictionaryLatinToRussian = new Dictionary<string, string>()
        {
            {"A", "А"},
            {"B", "Б"},
            {"V", "В"},
            {"G", "Г"},
            {"D", "Д"},
            {"Z", "З"},
            {"I", "И"},
            {"K", "К"},
            {"L", "Л"},
            {"M", "М"},
            {"N", "Н"},
            {"O", "О"},
            {"P", "П"},
            {"R", "Р"},
            {"S", "С"},
            {"T", "Т"},
            {"U", "У"},
            {"F", "Ф"},
            {"Y", "Ы"},
            {"E", "Э"}
         };

        private readonly Dictionary<string, string> _specialSymbols = new Dictionary<string, string>()
        { 
            {"SSH", "Щ"},
            {"YE", "Е"},
            {"YO", "Ё"},
            {"YI", "Й"},
            {"ZH", "Ж"},
            {"KH", "Х"},
            {"TS", "Ц"},
            {"CH", "Ч"},
            {"SH", "Ш"},
            {"YU", "Ю"},
            {"YA", "Я"}
        };

        public string GetTranslitString(string inputString)
        {
            inputString = inputString.ToUpper();

            if (!Validation(inputString) || inputString.Any(x => x <= 'Я' && x >= 'А' && x >= 'A' && x <= 'Z'))
            {
                throw new ArgumentException("Illegal characters in the entered string");
            }
                return inputString[0] >= 'A' && inputString[0] <= 'Z' ? TranslitLatinToRussian(inputString) : 
                                                                        TranslitRussianToLatin(inputString);
        }

        public string TranslitRussianToLatin(string str)
        {
            string result = string.Copy(str);

            return ReplaceSymbols(result, _dictionaryRussianToLatin);
            }

        public string TranslitLatinToRussian(string str)
        {
            string result = string.Copy(str);

            result = ReplaceSymbols(result, _specialSymbols);
            result = ReplaceSymbols(result, _dictionaryLatinToRussian);

            return result;
        }

        private string ReplaceSymbols(string str, Dictionary<string, string> mapping)
        {
            foreach (var item in mapping)
            {
                str = str.Replace(item.Key, item.Value);
            }

            return str;
        }


        private bool Validation(string str) => (str.Any(x => x >= 'A' && x <= 'Z') ||
                                                str.Any(x => x <= 'Я' && x >= 'А') ||
                                                str.Any(x => x == 32)) ?
                                                true : false;
    }
}
