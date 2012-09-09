using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class Gerogian
    {
        public static string en2ka(string  roman)
        {
            string[] table = { 
                                 /** 3 */
                                 "ts'", "წ",
                                 "ch'", "ჭ",
                                 /** 2 */
                                 "th", "თ",
                                 "p'", "პ",
                                 "t'", "ტ", //t'ar
                                 "ph", "ფ",
                                 "k'", "კ",
                                 "kh", "ქ",
                                 "gh", "ღ",
                                 "q'", "ყ",//q'ar
                                 "sh", "შ",
                                 "ch", "ჩ",
                                 "ts", "ც",
                                 "dz", "ძ",
                                 "xh", "ხ",
                                 "zh", "ჟ",
                                 /** 1 */
                                 "a", "ა",
                                 "b", "ბ",
                                 "g", "გ",
                                 "d", "დ",
                                 "e", "ე",
                                 "v", "ვ",
                                 "z", "ზ",
                                 "i", "ი",
                                 "k", "კ",
                                 "l", "ლ",
                                 "m", "მ",
                                 "n", "ნ",
                                 "o", "ო",
                                 "p", "პ",
                                 "r", "რ",
                                 "s", "ს",
                                 "t", "ტ", //t'ar
                                 "u", "უ",
                                 "q", "ყ", //q'ar
                                 "j", "ჯ",
                                 "h", "ჰ",
                                 "x", "ხ",//xan
                                 /** ~ */
                                 "ow", "ჵ",
                                 "c", "წ",
                                 "f", "ჶ",
                                 "w", "ჳ",
                                 "y", "ჷ",
                                 "`", "ჸ",
                             };
            roman = roman.ToLower();
            for (int i = 0; i < table.Length; i += 2)
            {
                roman = roman.Replace(table[i], table[i+1]);
            }
                return roman;
        }

    }
}
