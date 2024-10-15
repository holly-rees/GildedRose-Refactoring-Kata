using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class AgedBrie : IGildedItem
    {
        //private Item _item;
        private GildedUtilityItem gildedItem;

        public AgedBrie(Item item)
        {
            gildedItem = new GildedUtilityItem(item);
        }
        public void UpdateQuality()
        {
            if (gildedItem.SellIn >= 0)
            {
                gildedItem.IncreaseQualityBy(1);
            }
            else
            {
                gildedItem.IncreaseQualityBy(2);
            }

        }

        public void UpdateSellIn()
        {
            gildedItem.DecreaseSellInBy(1);
        }
    }
}