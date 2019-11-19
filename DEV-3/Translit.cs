using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_3
{
    class Translit
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"а","a"},
                {"б","b"},
                {"в","v"},
                {"г","g"},
                {"д","d"},
                {"е","e"},
                {"ё","yo"},
                {"ж","zh"},
                {"з","z"},
                {"и","i"},
                {"й","y"},
                {"к","k"},
                {"л","l"},
                {"м","m"},
                {"н","n"},
                {"о","o"},
                {"п","p"},
                {"р","r"},
                {"с","s"},
                {"т","t"},
                {"у","u"},
                {"ф","f"},
                {"х","h"},
                {"ц","ts"},
                {"ч","ch"},
                {"ш","sh"},
                {"щ","sch"},
                {"ъ","'"},
                {"ы","yi"},
                {"ь",""},
                {"э","e"},
                {"ю","yu"},
                {"я","ya"},
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
                {"Ц","TS"},
                {"Ч","CH"},
                {"Ш","SH"},
                {"Щ","SCH"},
                {"Ъ","'"},
                {"Ы","YI"},
                {"Ь",""},
                {"Э","E"},
                {"Ю","YU"},
                {"Я","YA"},
                {"a","a"},
                {"b","b"},
                {"v","v"},
                {"g","g"},
                {"d","д"},
                {"e","е"},
                {"yo","ё"},
                {"zh","ж"},
                {"z","з"},
                {"i","и"},
                {"y","й"},
                {"k","к"},
                {"l","л"},
                {"m","м"},
                {"n","н"},
                {"o","о"},
                {"p","п"},
                {"r","р"},
                {"s","с"},
                {"t","т"},
                {"u","у"},
                {"f","ф"},
                {"h","х"},
                {"ts","ц"},
                {"ch","ч"},
                {"sh","ш"},
                {"sch","щ"},
                {"'","ъ"},
                {"yi","ы"},
                {"","ь"},
                {"e","э"},
                {"ю","yu"},
                {"ya","я"},
                {"A","А"},
                {"B","Б"},
                {"V","В"},
                {"G","Г"},
                {"D","Д"},
                {"E","Е"},
                {"YO","Ё"},
                {"ZH","Ж"},
                {"Z","З"},
                {"I","И"},
                {"Y","Й"},
                {"K","К"},
                {"L","Л"},
                {"M","М"},
                {"N","Н"},
                {"O","О"},
                {"P","П"},
                {"R","Р"},
                {"S","С"},
                {"T","Т"},
                {"U","У"},
                {"F","Ф"},
                {"H","Х"},
                {"TS","Ц"},
                {"CH","Ч"},
                {"SH","Ш"},
                {"SCH","Щ"},
                {"'","Ъ"},
                {"YI","Ы"},
                {"","Ь"},
                {"E","Э"},
                {"YU","Ю"},
                {"YA","Я"}
            };

        public StringBuilder GetTranslitString(string inputString)
        {
            StringBuilder result = new StringBuilder();
            
            foreach (char keyValue in inputString)
            {
                string value = String.Empty;
                
                if (dictionary.TryGetValue(keyValue.ToString(), out value))
                {
                    result.Append(value);
                }
                else result.Append(keyValue);
            }
            return result;
        }
    }
}
