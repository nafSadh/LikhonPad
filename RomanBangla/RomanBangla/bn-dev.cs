using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ns7.bhaswor.LikhonPad
{
    class bn_dev
    {
        #region বর্ণ ভীত্তিক ফাংশনসমূহ
        public static char bn2dev(char bn)
        {
            if (util.isBangla(bn)) return (char)(bn - 0x80);
            else return bn;
        }
        public static string dev2bn(char dev)
        {
            if (util.isDevanagari(dev))
            {
                switch (dev)
                {
                    case (char)0X0900: return dev.ToString();
                    case (char)0X0904: return "অৗ";
                    case (char)0X090D: return "এঁ";//চন্দ্র এ // ऍ 
                    case (char)0X090E: return "এৗ";//
                    case (char)0X0911: return "ওঁ";
                    case (char)0X0912: return "ওৗ";
                    case (char)0X0929: return "ন়";
                    case (char)0X0931: return "ৰ়";
                    case (char)0X0933: return "ল়";
                    case (char)0X0934: return "ল়্";
                    case (char)0X0935: return "ৰ";
                    case (char)0X093A: return dev.ToString();//ऺ
                    case (char)0X093B: return dev.ToString();//ऻ
                    case (char)0X0945: return "েঁ";
                    case (char)0X0946: return "ে়";
                    case (char)0X0949: return "োঁ";
                    case (char)0X094A: return "ৈা";//ক+ৈা=কৈা//
                    case (char)0X094E: return "ে়";
                    case (char)0X094F: return "ৈৗ";//vowel sign AW//ক+ৈৗ=কৈৗ//ॏ looks like ौ = ৌ
                    case (char)0X0950: return "ওঁ";//OM//ওৗঁ
                    case (char)0X0951://fall trhough
                    case (char)0X0952://fall trhough
                    case (char)0X0953://fall trhough
                    case (char)0X0954://fall trhough
                    case (char)0X0955: return dev.ToString();
                    case (char)0X0956: return "ুৗ";//ক+ুৗ=কুৗ, //
                    case (char)0X0957: return "ূৗ";//ক+ূৗ=কূৗ, //ূৗ
                    case (char)0X0958: return "ক়";//क़   //Dev QA   
                    case (char)0X0959: return "খ়";//ख़   //Dev KHHA 
                    case (char)0X095A: return "গ়";//ग़   //Dev GHHA 
                    case (char)0X095B: return "জ়";//ज़   //Dev ZA   
                    //case (char)0X095C: return "ড়";//ड़   //Dev DDDHA  
                    //case (char)0X095D: return "ঢ়";//ढ़   //Dev RHA   
                    case (char)0X095E: return "ফ়";//फ़   //Dev FA   
                    //case (char)0X095F: return "য়";//य़   //Dev YYA  
                    case (char)0X0970: return dev.ToString();//dev abbr. sign
                    case (char)0X0971: return dev.ToString();//dev high spacing dot
                    case (char)0X0972: return "অঁ";//ॲ
                    case (char)0X0973: return "অऺ";//ॳ
                    case (char)0X0974: return "অऻ";//ॴ
                    case (char)0X0975: return "এৗ";//ॵ AW
                    case (char)0X0976: return "উৗ";//ॶ UE
                    case (char)0X0977: return "ঊৗ";//ॷ UUE
                    case (char)0X0979: return "ঝ়";// ZHA
                    case (char)0X097A: return "য়্";// JJYA
                    case (char)0X097B: return "গ়্";// Sindh GGA
                    case (char)0X097C: return "জ়্";// Sindh JJA
                    case (char)0X097D: return dev.ToString();// glottal stop
                    case (char)0X097E: return "দ়";// Sindh DDDA
                    case (char)0X097F: return "ৱ";// Sindh BBA

                    default: return ((char)(dev + 0x80)).ToString();
                }
            }
            else return dev.ToString();
        }
        #endregion

        #region পূর্ণবাক্য রূপান্তর  मैच

        public static string bn2dev(string bn)
        {
            char[] input = bn.ToCharArray();
            StringBuilder outPut = new StringBuilder();
            foreach (char c in input)
            {
                outPut.Append(bn2dev(c));
            }
            return outPut.ToString();
        }

        public static string dev2bn(string devnagari)
        {
            char[] input = devnagari.ToCharArray();
            StringBuilder outPut = new StringBuilder();
            foreach (char c in input)
            {
                outPut.Append(dev2bn(c));
            }
            return outPut.ToString();
        }
        #endregion
    }
}
