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
        public String path;
        public String outputPath;
        public bool generalizeNames;
        public int mode;
        public Dictionary<string, string> nameMap = new Dictionary<string, string>();
        public Dictionary<string, Priority.En_Priority> nameType = new Dictionary<string, Priority.En_Priority>();
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
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXqwertyuiopasdfghjklzxcvbnm";
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

        public string RandomFileName()  //TODO: actually check if result is unique
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXqwertyuiopasdfghjklzxcvbnm";
            string randomString = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            //foreach (string value in nameMap.Values)
            //{
            //    if (value.Equals(randomString))
            //    {
            //        return RandomFileName();
            //    }
            //}
            return randomString;
        }
    }
}
