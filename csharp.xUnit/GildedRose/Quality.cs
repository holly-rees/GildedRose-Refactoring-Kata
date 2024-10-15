using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class Quality
    {
        private int _quality;

        public Quality(int quality)
        {
            _quality = quality;
        }

        public void IncreaseBy(int amount)
        {
            Math.Min(_quality += amount, 50);
        }

        public void DecreaseBy(int amount)
        {
            Math.Max(_quality -= amount, 0);
        }

    }
}