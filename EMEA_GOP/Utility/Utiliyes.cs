using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMEA_GOP.Utility
{
    internal class Utiliyes
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
            public string RandomString(int size)
            {
                StringBuilder builder = new StringBuilder();
                char ch;
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }

                 return builder.ToString();
            }
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }



    }
}
