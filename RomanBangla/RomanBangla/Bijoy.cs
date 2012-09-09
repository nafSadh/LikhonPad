/** 
 * nafSadh>>LikhonPad>>Bengali2Bijoy
 * 
 * Author:  Khan M Nafee M Sadh
 *          a.k.a.  nafSadh-khan
 *          web:    http://nafSadh.com/Khan
 *          email:  khan AT nafSadh DOT com
 *          
 * License: CC BY-NC-SA v2.0
 * 
 * Project: LikhonPad
 * 
 * Owner:   nafSadh
 * 
 * Description:
 * 
 * Bengali (Unicode) to Bijoy (ASCII space) conversion code
 * this is a part of LikhonPad project
 * 
 * 
 * COPYRIGHT NOTICE:
 * 
 * Copyright (C) 2007-2012, Khan M Nafee M Sadh, some rights reserved
 * 
 * this source file is exposed under CC BY-NC-SA v2.0 license 
 * (license text at http://creativecommons.org/licenses/by-nc-sa/2.0/ )
 * (src url: http://ns.nafsadh.com/open/src/likhonpad/Bijoy.cs )
 * hence:
 *  You are free:
 *      » to Share — to copy, distribute and transmit the work
 *      » to Remix — to adapt the work
 *  Under the following conditions:
 *      » Attribution — You must attribute the work in the manner specified 
 *          by the author or licensor (but not in any way that suggests 
 *          that they endorse you or your use of the work).
 *      » Noncommercial — You may not use this work for commercial purposes.
 *      » Share Alike — If you alter, transform, or build upon this work, 
 *          you may distribute the resulting work only under the same or 
 *          similar license to this one. 
 *  
 * END OF NOTICE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class Bijoy
    {
        /// <summary>
        /// eats 1 unicode char
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char banglaSimple2Bijoy(char str)
        {
            switch (str)
            {
                case 'অ': return 'A';
                case 'ই': return 'B';
                case 'ঈ': return 'C';
                case 'উ': return 'D';
                case 'ঊ': return 'E';
                case 'ঋ': return 'F';
                case 'এ': return 'G';
                case 'ঐ': return 'H';
                case 'ও': return 'I';
                case 'ঔ': return 'J';
                case 'ক': return 'K';
                case 'খ': return 'L';
                case 'গ': return 'M';
                case 'ঘ': return 'N';
                case 'ঙ': return 'O';
                case 'চ': return 'P';
                case 'ছ': return 'Q';
                case 'জ': return 'R';
                case 'ঝ': return 'S';
                case 'ঞ': return 'T';
                case 'ট': return 'U';
                case 'ঠ': return 'V';
                case 'ড': return 'W';
                case 'ঢ': return 'X';
                case 'ণ': return 'Y';
                case 'ত': return 'Z';
                case 'থ': return '_';
                case 'দ': return '`';/**/
                case 'ধ': return 'a';
                case 'ন': return 'b';
                case 'প': return 'c';
                case 'ফ': return 'd';
                case 'ব': return 'e';
                case 'ভ': return 'f';
                case 'ম': return 'g';
                case 'য': return 'h';
                case 'র': return 'i';
                case 'ল': return 'j';
                case 'শ': return 'k';
                case 'ষ': return 'l';
                case 'স': return 'm';
                case 'হ': return 'n';
                case 'ড়': return 'o';
                case 'ঢ়': return 'p';
                case 'য়': return 'q';
                case 'ৎ': return 'r';
                case 'ং': return 's';
                case 'ঃ': return 't';
                case 'ঁ': return 'u';
                case 'া': return 'v';
                //case 'ি': return 'w';
                case 'ী': return 'x';
                case 'ু': return 'y';//আগোনো হ্রস্ব-উ কার:z
                case 'ূ': return '~';
                case 'ৃ': return (char)0x2026;
                case '্': return '&';
                //case 'ে': return (char)0x2020;//মাত্রা সহ ে-কার:0x2021
                //case 'ৈ': return 'ˆ';
                //case '': return '';
                //case '': return '';
                //case '': return '';
                //asamase
                case (char)0x09F0: return '­';
            }
            return '0';
        }
        ///
        public static string bangla5charEater2Bijoy(string str)
        {
            switch (str)
            {
                case "ক্ষ্ম": return "²";
                case "ষ্ক্র": return "®Œ";
                case "স্ক্র": return "¯Œ";
                case "ম্ক্র": return "¤Œ";
                default: return "";
            }
        }
        /// <summary>
        /// eats 4 chars
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string banglaSpecialJuktaqhor2Bijoy(String str)
        {
            switch (str)
            {
                case "র‌্য": return "i¨";
                case "্ভ্র": return "£";
                default: return "";
            }
        }

        /// <summary>
        /// eats 3 unicode char
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string banglaSpecificJuktaqhor2Bijoy(string str)
        {

            switch (str)
            {
                case "্ভ্র": return "£";
                case "স্ব": return "m¦";
                case "ক্র": return "μ";//µ or μ
                case "চ্র": return "Pª";
                case "ট্র": return "Uª";
                case "ড্র": return "Wª";
                case "ঢ্র": return "Xª";
                case "ত্র": return "Î";
                case "থ্র": return "_Ö";
                case "দ্র": return "`ª";
                case "ধ্র": return "aª";
                case "ন্র": return "bª";
                case "প্র": return "cÖ";
                case "ব্র": return "eÖ";
                case "ভ্র": return "å";
                case "ম্র": return "gª";
                case "য্র": return "hª";
                case "ল্র": return "jª";
                case "শ্র": return "kÖ";
                case "ষ্র": return "lÖ";
                case "স্র": return "mª";
                case "ক্ল": return "K¬";
                case "ছ্ল": return "Q¬";
                case "জ্ল": return "R¬";
                case "ঝ্ল": return "S¬";
                case "ফ্ল": return "d¬";
                case "ভ্ল": return "f¬";
                case "হ্ল": return "n¬";
                case "ক্ক": return "°";
                case "ক্ট": return "±";
                case "ক্ত": return "³";
                case "ক্ম": return "´";
                case "ক্স": return "·";
                case "গ্গ": return "¹";
                case "গ্দ": return Char.ToString((char)0x00BA);
                case "গ্ধ": return "»";
                case "ঙ্ক": return "¼";
                case "ঙ্গ": return "½";
                case "জ্জ": return "¾";
                case "জ্ঝ": return "À";
                case "জ্ঞ": return "Á";
                case "ঞ্চ": return "Â";
                case "ঞ্ছ": return "Ã";
                case "ঞ্জ": return "Ä";
                case "ঞ্ঝ": return "Å";
                case "ট্ট": return "Æ";
                case "ড্ড": return "Ç";
                case "ণ্ট": return "È";
                case "ণ্ঠ": return "É";
                case "ণ্ড": return "Ê";
                case "ত্ত": return "Ë";
                case "ত্থ": return "Ì";
                case "দ্দ": return "Ï";
                case "দ্ধ": return "×";
                case "দ্ব": return "Ø";
                case "দ্ম": return "Ù";
                case "ন্ঠ": return "Ú";
                case "ন্ড": return "Û";
                case "ন্ধ": return "Ü";
                case "ন্স": return "Ý";
                case "প্ট": return "Þ";
                case "প্ত": return "ß";
                case "প্প": return "à";
                case "প্স": return "á";
                case "ব্জ": return "â";
                case "ব্দ": return "ã";
                case "ব্ধ": return "ä";
                case "ব্ব": return "eŸ";
                case "ম্ফ": return "ç";
                case "ত্ন": return "Zœ";
                case "ল্ক": return "é";
                case "ল্গ": return "ê";
                case "ল্ট": return "ë";
                case "ল্ড": return "ì";
                case "ল্প": return "í";
                case "ল্ফ": return "î";
                case "শ্চ": return "ð";
                case "শ্ছ": return "ñ";
                case "শ্ব": return "k¦";
                case "ষ্ণ": return "ò";
                case "ষ্ট": return "ó";
                case "ষ্ঠ": return "ô";
                case "ষ্ফ": return "õ";
                case "স্খ": return "ö";
                case "স্ট": return "÷";
                case "স্ফ": return "ù";
                case "হ্ন": return "ý";
                case "হ্ণ": return "nœ";
                case "হ্ম": return "þ";
                case "ক্ষ": return "¶";// for Sutnny MJ ÿ
                case "হ্ব": return "nŸ";
                case "ষ্ক": return "®‹";
                case "ন্থ": return "š’";/*
                case "": return "";/*
                case "": return "";
                case "": return "";
                case "": return "";
                case "": return "";*/
            }
            return "";
        }

        /// <summary>
        ///  eats 2 unicode char
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char banglaJuktaqhor2Bijoy(String str)
        {
            switch (str)
            {
                //generic
                case "্ব": return '¡';
                case "্ভ": return '¢';
                case "্ন": return 'œ';
                case "্য": return '¨';
                case "ম্": return '¤';
                //case "্ম": return '¥';//ম
                case "্ম": return '¥';
                case "র্": return '©';
                case "্র": return '«';
                case "্ল": return 'ø';//¬
                case "ষ্": return '®';
                case "্স": return '¯';
                case "গু": return '¸';//--
                case "শু": return 'ï';//--
                case "হৃ": return 'ü';//--
                //case "্ত": return 'Í'; S-Mj only
                //case "ত্": return 'æ';
                /*
                case "":return'';
                case "":return'';*/
                default: return '0';
            }
            //return '0';
        }
        public static string Romok2Bijoy(String str)
        {

            StringBuilder bjy = new StringBuilder();
            int i = 0, j = 0; int fallback = 1;
            bool option_sm=false;
            bool option_kar = false;
            while (i < str.Length)
            {
                int charval = (int)str[i];
                if (!(0x0980 <= charval && charval <= 0x0A00)) bjy.Append(str[i]);
                char a, b, c;
                string s;
                //handle 5 char eaters
                if ((str.Length - i) > 4)
                {
                    s = bangla5charEater2Bijoy(str.Substring(i, 5));
                    if (s != "")
                    {
                        fallback = s.Length; j += fallback; bjy.Append(s); i += 5; continue;
                    }
                }
                //handle 4 char eaters
                if ((str.Length - i) > 3)
                {
                    s = banglaSpecialJuktaqhor2Bijoy(str.Substring(i, 4));
                    if (s != "")
                    {
                        fallback = s.Length; j += fallback; bjy.Append(s); i += 4; continue;
                    }
                }
                //handle 3 char eaters
                if ((str.Length - i) > 2)
                {
                    s = banglaSpecificJuktaqhor2Bijoy(str.Substring(i, 3));
                    if (s != "")
                    {
                        fallback = s.Length; j += fallback; bjy.Append(s); i += 3; continue;
                    }
                }
                //handle 2 char eaters
                if ((str.Length - i) > 1)
                {
                    a = banglaJuktaqhor2Bijoy(str.Substring(i, 2));
                    if (a != '0')
                    {
                        fallback++; ; j++; bjy.Append(a); i += 2; continue;
                    }
                }
                a = banglaSimple2Bijoy(str[i]);
                if (a != '0') { bjy.Append(a); fallback = 1; }
                else if (str[i] == 'আ') { bjy.Append("Av"); j++; }
                // আগে পরে স্বর-কার সমূহ 
                else if (str[i] == 'ি') { bjy = bjy.Insert((j - fallback), 'w'); }
                else if (str[i] == 'ে') { bjy = bjy.Insert((j - fallback), (char)0x2021); }
                else if (str[i] == 'ৈ') { bjy = bjy.Insert((j - fallback), 'ˆ'); }
                else if (str[i] == 'ো') { bjy = bjy.Insert((j - fallback), (char)0x2021); bjy.Append('v'); j++; }
                else if (str[i] == 'ৌ') { bjy = bjy.Insert((j - fallback), (char)0x2021); bjy.Append('Š'); j++; }

                i++; j++;
            }
            string weRq = bjy.ToString();
            //optionHandle
            if (option_sm) weRq.Replace("m¥", "¯§");
            if (option_kar)
            {
                weRq.Replace("i~", "iƒ");
            }
            return weRq;
        }
    }
}
