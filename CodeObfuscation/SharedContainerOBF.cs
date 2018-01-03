using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeObfuscation
{
    class MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN    {
        private static readonly MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN CHRFUANSPVOQRWKPTJQKFBGRQPHHNHGKILVFNACPBEH= new MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN();
        private Random GWFOXPVPDDQCBBXMEQGEHOEHFAEBTGAIARATKBIPQQDG= new Random();
        public Dictionary<string, string> PITENLVXSAAPSWIWLTUUCHCIAEBDIOLOLVQUFALHJBOAR= new Dictionary<string, string>();
        private MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN() { }
        public static MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN Instance
        {
            get
            {
                return CHRFUANSPVOQRWKPTJQKFBGRQPHHNHGKILVFNACPBEH;
            }
        }

        public string WXWAIIAEAJGOAEJCSTGKTANHFWPOXXDMWIVCMKMUCI(int length)
        {
            const string JAMQKEVUHDHGLEJJSPDMJDUFMRLHMLBRCPPDNKVKOSESIO= "ABCDEFGHIJKLMNOPQRSTUVWX";
            string RTCWOKKLHFDHERROHUCODUMFUHRRWOXCUVXPEOUOHOHKAGG= new string(Enumerable.Repeat(JAMQKEVUHDHGLEJJSPDMJDUFMRLHMLBRCPPDNKVKOSESIO, length + 4)
              .Select(s => s[GWFOXPVPDDQCBBXMEQGEHOEHFAEBTGAIARATKBIPQQDG.Next(s.Length)]).ToArray());
            foreach(string value in PITENLVXSAAPSWIWLTUUCHCIAEBDIOLOLVQUFALHJBOAR.Values)
            {
                if (value.Equals(RTCWOKKLHFDHERROHUCODUMFUHRRWOXCUVXPEOUOHOHKAGG))
                {
                    return WXWAIIAEAJGOAEJCSTGKTANHFWPOXXDMWIVCMKMUCI(length);
                }
            }
            return RTCWOKKLHFDHERROHUCODUMFUHRRWOXCUVXPEOUOHOHKAGG;
        }
    }
}
