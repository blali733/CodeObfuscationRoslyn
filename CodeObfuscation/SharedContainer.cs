using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeObfuscation
{
    class SharedContainer
    {
        private static readonly SharedContainer instance = new SharedContainer();
        private Random random = new Random();
        public Dictionary<string, string> nameMap = new Dictionary<string, string>();
        private SharedContainer() { }
        public static SharedContainer Instance
        {
            get
            {
                return instance;
            }
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWX!@#$";
            string randomString = new string(Enumerable.Repeat(chars, length + 4)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            foreach(string value in nameMap.Values)
            {
                if (value.Equals(randomString))
                {
                    return RandomString(length);
                }
            }
            return randomString;
        }
    }
}
