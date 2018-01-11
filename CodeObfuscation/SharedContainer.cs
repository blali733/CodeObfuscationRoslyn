using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CodeObfuscation
{
    class SharedContainer
    {
        private static readonly SharedContainer instance = new SharedContainer();
        private Random random = new Random();
        private List<string> files = new List<string>();
        public List<string> filePaths = new List<string>();
        public string path;
        public string outputPath;
        public bool generalizeNames;
        public int mode;
        public List<SyntaxTree> sourceTrees;
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
            int fuse = 0;
            string randomString;
            do
            {
                randomString = "u" + Guid.NewGuid().ToString().Replace('-', 'u');
                foreach (string value in nameMap.Values)
                {
                    if (value.Equals(randomString))
                    {
                        fuse++;
                    }
                }
            } while (fuse != 0);
            return randomString;
        }

        public string RandomFileName()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXqwertyuiopasdfghjklzxcvbnm";
            string randomFileName;
            do
            {
                randomFileName = new string(Enumerable.Repeat(chars, 15)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (files.Contains(randomFileName));
            files.Add(randomFileName);
            return randomFileName;
        }
    }
}
