using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
    public static class RNG
    {
        private static readonly Random _random = new Random();

        public static int Next(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static bool CoinFlip()
        {
            return _random.Next(0, 2) == 1;
        }

        public static T Choice<T>(T[] items)
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Arrayen får inte vara tom.");

            int index = _random.Next(0, items.Length);
            return items[index];
        }
    }
}
