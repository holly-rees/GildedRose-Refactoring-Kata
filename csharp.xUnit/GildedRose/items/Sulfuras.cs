using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class Sulfuras : IGildedItem
    {
        private Item _item;

        public Sulfuras(Item item)
        {
            _item = item;
        }
        public void UpdateQuality()
        {

        }

        public void UpdateSellIn()
        {

        }
    }
}