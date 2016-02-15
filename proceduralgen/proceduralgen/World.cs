using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proceduralgen
{
    class World
    {
        Dictionary<string, bool> qualities;
        World()
        {
            qualities = new Dictionary<string, bool>();
        }

        public bool getQuality(string key)
        {
            if (qualities.ContainsKey(key))
            {
                return qualities[key];
            }
            return false;
        }

        public void setQuality(string key, bool val)
        {
            if (qualities.ContainsKey(key))
            {
                qualities[key] = val;
            }
            else
            {
                qualities.Add(key, val);
            }
        }

        public void generateRandomQualities(int n)
        {
            Random r = new Random();
            string key = "quality";
            for(int i=0;i< n; i++)
            {
                int k = r.Next() % 2;
                bool val;
                if (k % 2 == 0)
                {
                    val = false;
                }
                else
                {
                    val = true;
                }
                qualities.Add(key + i, val);
            }
        }
    }
}
