using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGoL
{
    class CellTable
    {
        private List<int> keys = new List<int>();
        private List<int> values = new List<int>();


        static readonly int populationArea = Convert.ToInt32(ConfigurationManager.AppSettings["populationArea"]);

        public int this[int key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (index == -1) return -1;
                else return values[index];
            }
            set
            {
                if (keys.Contains(key))
                {
                    int index = keys.IndexOf(key);
                    values[index] = value;
                }
                else
                {
                    keys.Add(key);
                    values.Add(value);
                }
            }
        }

        public int Get(int key)
        {
            int index = keys.IndexOf(key);
            return values[index];
        }

        public void Add(int key, int value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public void Clear()
        {
            keys = new List<int>();
            values = new List<int>();
        }
    }
}
