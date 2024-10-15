using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public interface IGildedItem
    {
        public void UpdateQuality();
        public void UpdateSellIn();
    }
}