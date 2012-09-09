using System;
using System.Collections.Generic;
using System.Text;

using ns7.bhaswor;

namespace ns7.bhaswor.LikhonPad
{
    class BanglaBornoResultSet
    {
        #region fields
        private int _numberOfLetters;
        private BanglaBorno.Chihno _borno;
        private string _oqkhor = "";
        #endregion

        #region constructors
        public BanglaBornoResultSet()
        {
            Num = 0;
            Borno = BanglaBorno.Chihno._NULL;
        }
        public BanglaBornoResultSet(int l, string oqkhor)
        {
            Num = l;
            Oqkhor = oqkhor;
        }
        public BanglaBornoResultSet(int l, BanglaBorno.Chihno chihno)
        {
            Num = l;
            Borno = chihno;
        }
        public BanglaBornoResultSet(int l, BanglaBorno.Swor swor)
        {
            Num = l;
            Borno = BanglaBorno.toChihno(swor);
        }
        public BanglaBornoResultSet(int l, BanglaBorno.Byanzon byanjon)
        {
            Num = l;
            Borno = BanglaBorno.toChihno(byanjon);
        }
        public BanglaBornoResultSet(int l, BanglaBorno.Kar kar)
        {
            Num = l;
            Borno = BanglaBorno.toChihno(kar);
        }
        public BanglaBornoResultSet(int l, BanglaBorno.Onko onko)
        {
            Num = l;
            Borno = BanglaBorno.toChihno(onko);
        }
        public BanglaBornoResultSet(BanglaBornoResultSet resultBoronSet)
        {
            Num = resultBoronSet.Num;
            Borno = resultBoronSet.Borno;
        }
        #endregion

        #region properties
        public int Num
        {
            get { return _numberOfLetters; }
            set { _numberOfLetters = value; }
        }
        public BanglaBorno.Chihno Borno
        {
            get { return _borno; }
            set { _borno = value; }
        }
        public string Oqkhor
        {
            get { return _oqkhor; }
            set { _oqkhor = value; }
        }
        #endregion

        override public string ToString()
        {
            if (Oqkhor == "")
                return ((char)Borno).ToString();
            else
                return Oqkhor;
        }

        #region SetVal
        public BanglaBornoResultSet SetVal(int numberOfLetter, string oqkhor)
        {
            Num = numberOfLetter;
            Oqkhor = oqkhor;
            return this;
        }
        public BanglaBornoResultSet SetVal(int numberOfLetter, BanglaBorno.Chihno borno1, BanglaBorno.Chihno bonro2)
        {
            Num = numberOfLetter;
            _oqkhor = char.ConvertFromUtf32((int)borno1) + char.ConvertFromUtf32((int)bonro2);
            return this;
        }
        public BanglaBornoResultSet SetVal(int numberOfLetter, BanglaBorno.Chihno borno)
        {
            Num = numberOfLetter;
            Borno = borno;
            return this;
        }
        public BanglaBornoResultSet SetVal(int numberOfLetter, BanglaBorno.Swor borno)
        {
            Num = numberOfLetter;
            Borno = BanglaBorno.toChihno(borno);
            return this;
        }
        public BanglaBornoResultSet SetVal(int numberOfLetter, BanglaBorno.Byanzon borno)
        {
            Num = numberOfLetter;
            Borno = BanglaBorno.toChihno(borno);
            return this;
        }
        public BanglaBornoResultSet SetVal(int numberOfLetter, BanglaBorno.Kar borno)
        {
            Num = numberOfLetter;
            Borno = BanglaBorno.toChihno(borno);
            return this;
        }
        public BanglaBornoResultSet SetVal(int numberOfLetter, BanglaBorno.Onko borno)
        {
            Num = numberOfLetter;
            Borno = BanglaBorno.toChihno(borno);
            return this;
        }

        public BanglaBornoResultSet SetVal(int numberOfLetter, char borno)
        {
            Num = numberOfLetter;
            Borno = BanglaBorno.toChihno(borno);
            return this;
        }
        #endregion
    }

    partial class JuktiKendro
    {

        private static BanglaBornoResultSet isSwor(char romok, char romok_1)
        {
            BanglaBornoResultSet sworoborno = new BanglaBornoResultSet();
            if (char.IsUpper(romok_1))
                romok_1 = char.ToLower(romok_1);

            switch (romok)
            {
                default: return sworoborno.SetVal(1, romok);
                case 'o': return sworoborno.SetVal(1, BanglaBorno.Swor.o);//অ
                case 'A': return sworoborno.SetVal(1, BanglaBorno.Swor.a);//আ া
                case 'a':
                    switch (romok_1)
                    {
                        default: return sworoborno.SetVal(1, BanglaBorno.Swor.a);//আ া
                        case 'e': return sworoborno.SetVal(2, BanglaBorno.Swor.ae);//
                    }
                case 'i': return sworoborno.SetVal(1, BanglaBorno.Swor.i);//ই ি
                case 'I': return sworoborno.SetVal(1, BanglaBorno.Swor.ii);//ঈ ী
                case 'u': return sworoborno.SetVal(1, BanglaBorno.Swor.u);//উ ু
                case 'U': return sworoborno.SetVal(1, BanglaBorno.Swor.uu);//ঊ ূ
                case 'x': return sworoborno.SetVal(1, BanglaBorno.Swor.RI);//ঋ ৃ
                case 'e': return sworoborno.SetVal(1, BanglaBorno.Swor.e);
                case 'w':
                    switch (romok_1)
                    {
                        case 'i': return sworoborno.SetVal(2, BanglaBorno.Swor.OI);// ঐ 
                        case 'w': return sworoborno.SetVal(2, BanglaBorno.Swor.ow);//ঔ ৌ
                        default: return sworoborno.SetVal(1, BanglaBorno.Swor.oa);////ও ো
                    }
                case 'O': return sworoborno.SetVal(1, BanglaBorno.Swor.oa);////ও ো
            }
        }

        private static BanglaBornoResultSet isOnuByanjon(char romok, char romok_1)
        {
            BanglaBornoResultSet borno = new BanglaBornoResultSet();
            switch (romok)
            {
                default: return borno;
                case '`':
                    switch (romok_1)
                    {
                        case '`': return borno.SetVal(2, "্‌");
                        case '~': return borno.SetVal(2, BanglaBorno.Byanzon._chondrobindu);
                        case 'n': return borno.SetVal(2, BanglaBorno.Byanzon._anuswor);
                        case 't': return borno.SetVal(2, BanglaBorno.Byanzon.t_);
                        case 'h': return borno.SetVal(2, BanglaBorno.Byanzon._bisorgo);
                        case '*': return borno.SetVal(2, BanglaBorno.Chihno.hosonto);
                        //case '-': return borno.SetVal(2, "‌");//No Space Non Joiner
                        case '-': return borno.SetVal(2, BanglaBorno.Chihno._shunnodoirghoBicchinno);//No Space Non Joiner
                        //case '+': return borno.SetVal(2, "‍");//No Space Joiner  
                        case '+': return borno.SetVal(2, BanglaBorno.Chihno._odourgoJukti);//No Space Joiner  
                        //case '_': return borno.SetVal(2, " ");//nbsp No break Space
                        case '_': return borno.SetVal(2, BanglaBorno.Chihno._nbsp);//nbsp No break Space
                        case 'a':
                        case 'i':
                        case 'I':
                        case 'u':
                        case 'U':
                        case 'x':
                        case 'e':
                        case 'w':
                        case 'O': return borno.SetVal(1, BanglaBorno.Chihno._forceKar);
                        default: return borno.SetVal(1, "্‌");
                    }
                case '^': return borno.SetVal(1, BanglaBorno.Byanzon._chondrobindu);
            }
        }

        private static BanglaBornoResultSet isBorgiio(char romok, char romok_1)
        {
            BanglaBornoResultSet byanjonborno
                = new BanglaBornoResultSet();
            BanglaBorno.Byanzon x = BanglaBorno.Byanzon._NULL;

            switch (romok)
            {
                default: return byanjonborno;
                case 'K':
                case 'k':
                    x = BanglaBorno.Byanzon.k; break;
                case 'G':
                case 'g':
                    x = BanglaBorno.Byanzon.g; break;
                case 'C':
                case 'c':
                    x = BanglaBorno.Byanzon.c; break;
                case 'Z':
                case 'z':
                    x = BanglaBorno.Byanzon.z; break;
                case 'T':
                    x = BanglaBorno.Byanzon.T; break;
                case 'D':
                    x = BanglaBorno.Byanzon.D; break;
                case 't':
                    x = BanglaBorno.Byanzon.t; break;
                case 'd':
                    x = BanglaBorno.Byanzon.d; break;
                case 'P':
                case 'p':
                    x = BanglaBorno.Byanzon.p; break;
                case 'B':
                case 'b':
                    x = BanglaBorno.Byanzon.b; break;
            }
            if (romok_1 == 'h')
                return byanjonborno.SetVal(2, BanglaBorno.toMohapran(x));
            else
                return byanjonborno.SetVal(1, x);
        }

        private static BanglaBornoResultSet isByanjon(char romok, char romok_1)
        {
            BanglaBornoResultSet byanjonborno
                = new BanglaBornoResultSet(isBorgiio(romok, romok_1));
            if (byanjonborno.Num > 0)
                return byanjonborno;

            switch (romok)
            {
                default: return byanjonborno;
                case 'v': return byanjonborno.SetVal(1, BanglaBorno.Byanzon.bh);
                case 'f': return byanjonborno.SetVal(1, BanglaBorno.Byanzon.ph);
                case 'N':
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.N);
                case 'n':
                    switch (romok_1)
                    {
                        default:
                            return byanjonborno.SetVal(1, BanglaBorno.Byanzon.n);
                        case '~':
                            return byanjonborno.SetVal(2, BanglaBorno.Byanzon.uno);
                        case 'k':
                        case 'g':
                            return byanjonborno.SetVal(1, BanglaBorno.Byanzon.uno);
                        case 'c':
                        case 'z':
                            return byanjonborno.SetVal(1, BanglaBorno.Byanzon.nio);
                    }
                case 'm':
                    switch (romok_1)
                    {
                        default:
                            return byanjonborno.SetVal(1, BanglaBorno.Byanzon.m);
                        case '~':
                            return byanjonborno.SetVal(2, BanglaBorno.Byanzon.nio);
                    }
                case 'j':
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.j);
                case 'l':
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.l);
                case 'W':
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.b);
                case 's':
                    switch (romok_1)
                    {
                        default:
                            return byanjonborno.SetVal(1, BanglaBorno.Byanzon.s);
                        case 'h':
                            return byanjonborno.SetVal(2, BanglaBorno.Byanzon.sh);
                        case 's':
                            return byanjonborno.SetVal(2, BanglaBorno.Byanzon.ss);
                    }
                case 'H':
                case 'h':
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.h);
                case 'r':
                    switch (romok_1)
                    {
                        default:
                            return byanjonborno.SetVal(1, BanglaBorno.Byanzon.r);
                        case 'y':
                            return byanjonborno.SetVal(2, "র‌্য");
                        case 'h':
                            return byanjonborno.SetVal(2, BanglaBorno.Byanzon.Rh);
                    }
                case 'R':
                    switch (romok_1)
                    {
                        case 'h':
                        case 'H':
                            return byanjonborno.SetVal(2, BanglaBorno.Byanzon.Rh);
                        default: return byanjonborno.SetVal(1, BanglaBorno.Byanzon.R);
                    }
                case 'y':
                    return byanjonborno.SetVal(1, BanglaBorno.Byanzon.y);
                case 'q':
                    switch (romok_1)
                    {
                        case 'h':
                            return byanjonborno.SetVal(2, "ক্ষ");
                        default: return byanjonborno.SetVal(1, "ক্ব");
                    }
            }
        }
        private static BanglaBornoResultSet isOnko(char onko)
        {
            switch (onko)
            {
                case '0': return new BanglaBornoResultSet(1, BanglaBorno.Onko.shunno);
                case '1': return new BanglaBornoResultSet(1, BanglaBorno.Onko.ek);
                case '2': return new BanglaBornoResultSet(1, BanglaBorno.Onko.dui);
                case '3': return new BanglaBornoResultSet(1, BanglaBorno.Onko.tin);
                case '4': return new BanglaBornoResultSet(1, BanglaBorno.Onko.car);
                case '5': return new BanglaBornoResultSet(1, BanglaBorno.Onko.panc);
                case '6': return new BanglaBornoResultSet(1, BanglaBorno.Onko.choy);
                case '7': return new BanglaBornoResultSet(1, BanglaBorno.Onko.sat);
                case '8': return new BanglaBornoResultSet(1, BanglaBorno.Onko.at);
                case '9': return new BanglaBornoResultSet(1, BanglaBorno.Onko.noy);
                default: return new BanglaBornoResultSet(0, BanglaBorno.Chihno._NULL);
            }
        }
        public static BanglaBornoResultSet isSymbol(char roman)
        {
            switch (roman)
            {
                case ' ': return new BanglaBornoResultSet(1, " ");
                case '|': return new BanglaBornoResultSet(1, Char.ToString((char)0x964));
                default: return new BanglaBornoResultSet(0, String.Empty);
            }
        }
        public static string RomokThekeBangla(string romok)
        {
            StringBuilder bangla = new StringBuilder("", 3 * romok.Length);
            bool isKarNeeded = false;
            bool sworeokaarghotona = false;
            int index = 0;
            char[] c = (romok + " ").ToCharArray();
            BanglaBornoResultSet borno = new BanglaBornoResultSet();

            while (index < romok.Length)
            {
                borno = isSymbol(c[index]);
                if (borno.Num > 0)
                {
                    bangla.Append(borno.Oqkhor);
                    isKarNeeded = false;
                    index += borno.Num;
                }
                else
                {
                    borno = isOnko(c[index]);
                    if (borno.Num == 1) { ; }
                    else
                    {
                        borno = isByanjon(c[index], c[index + 1]);
                        if (borno.Num > 0)
                        {
                            if (isKarNeeded)
                            {
                                bangla.Append((char)BanglaBorno.Chihno.hosonto);
                                if (borno.Borno == BanglaBorno.toChihno(BanglaBorno.Byanzon.y))
                                    borno.Borno = BanglaBorno.toChihno(BanglaBorno.Byanzon.j);
                            }
                            isKarNeeded = true;
                        }
                        else
                        {
                            BanglaBornoResultSet borno1 = isOnuByanjon(c[index], c[index + 1]);
                            if (borno1.Borno == BanglaBorno.Chihno._forceKar) isKarNeeded = true;
                            else
                            {
                                borno = borno1;
                                if (borno.Num > 0) isKarNeeded = false;
                            }
                        }
                        if (borno.Num == 0)
                        {
                            borno = isSwor(c[index], c[index + 1]);
                            if (isKarNeeded)
                            {
                                if (borno.Borno == BanglaBorno.toChihno(BanglaBorno.Swor.o))
                                    sworeokaarghotona = true;
                                else borno.Borno = BanglaBorno.SworToKar(borno.Borno);
                            }
                            // handle jofolay a-kar
                            if (borno.Borno == BanglaBorno.toChihno(BanglaBorno.Swor.ae))
                            {
                                if (!isKarNeeded)
                                    bangla.Append((char)BanglaBorno.Swor.o);
                                bangla.Append((char)BanglaBorno.Kar.hosonto);
                                bangla.Append((char)BanglaBorno.Byanzon.j);
                                borno.Borno = BanglaBorno.Chihno.a_kar;
                            }
                            isKarNeeded = false;
                        }
                    }
                    if (!sworeokaarghotona)
                        bangla.Append(borno.ToString());
                    sworeokaarghotona = false;
                    index += borno.Num;
                }
            }
            return bangla.ToString();
        }
        /* public static string parseWrite1(string inputText)
         {
             string[] seperators = { "./" };
             string[] inputs = inputText.Split(seperators, StringSplitOptions.None);
             StringBuilder outPut = new StringBuilder();
             int i = 0;
             while (i < inputs.Length)
             {

             }
         }*/
        public static string symbolParse(string inputText)
        {
            //punctuations
            inputText = inputText.Replace("&-!", "¡");
            inputText = inputText.Replace("!!", "‼");//‼
            inputText = inputText.Replace("!?", "‽");//‽ interrobang
            inputText = inputText.Replace("...", "…");//‽
            inputText = inputText.Replace("->", "→");//→
            //monetary
            inputText = inputText.Replace("&$t", "৳");
            //emoticons
            inputText = inputText.Replace("&)", "⌣");
            inputText = inputText.Replace("&:)", "☺");
            inputText = inputText.Replace("&:(", "☹");
            //image
            inputText = inputText.Replace("&TEL", "℡");
            inputText = inputText.Replace("&phone", "✆");
            inputText = inputText.Replace("&telephone", "☎");
            inputText = inputText.Replace("&sun", "☉");//☉
            inputText = inputText.Replace("&sunray", "☼");//☼
            //lettrelike symbols
            inputText = inputText.Replace("&C", "©");
            inputText = inputText.Replace("&R", "®");
            inputText = inputText.Replace("&TM", "™");
            //marks
            inputText = inputText.Replace("&degree", "°");
            //should be at last:
            inputText = inputText.Replace("&amp", "&");
            return inputText;
        }
        public static string parseWrite(string inputText)
        {
            inputText = symbolParse(inputText);
            string[] seperators = { "./" };
            string[] inputs = inputText.Split(seperators, StringSplitOptions.None);
            StringBuilder outPut = new StringBuilder();
            int i = 0;
            while (i < inputs.Length)
            {
                if (inputs[i] == "BN" || inputs[i] == "bn")
                {
                    if (i + 1 < inputs.Length)
                        outPut.Append(ns7.bhaswor.LikhonPad.JuktiKendro.RomokThekeBangla(inputs[++i]));
                }/*
                else if (inputs[i] == "bj" || inputs[i] == "bj")
                {
                    if (i + 1 < inputs.Length)
                        outPut.Append(ns7.bhaswor.LikhonPad.Bijoy.Romok2Bijoy(inputs[++i]));
                }
                else if (inputs[i] == "AR" || inputs[i] == "ar")
                {
                    if (i + 1 < inputs.Length)
                        outPut.Append(ns7.bhaswor.LikhonPad.RomamArabic.RomanToArabic(inputs[++i]));
                }
                else if (inputs[i] == "EL" || inputs[i] == "el")
                {
                    if (i + 1 < inputs.Length)
                        outPut.Append(ns7.bhaswor.LikhonPad.RomanGreek.RomanToGreek(inputs[++i]));
                }*/
                else if (inputs[i] == "EN" || inputs[i] == "en")
                {
                    if (i + 1 < inputs.Length)
                        outPut.Append(inputs[++i]);
                }
                else
                {
                    outPut.Append(ns7.bhaswor.LikhonPad.JuktiKendro.RomokThekeBangla(inputs[i]));
                }
                i++;
            }
            return outPut.ToString();
        }
    }
}
/*
 * o a,A ae i I u U 
 * x e Wi O,W Ww 
 * k kh g gh n~ 
 * c ch z zh m~ 
 * T Th D Dh N 
 * t th d dh n 
 * p ph,f b bh,v m 
 * j r l W
 * sh ss s h 
 * R rh,Rh y `t `n `h `~
*/