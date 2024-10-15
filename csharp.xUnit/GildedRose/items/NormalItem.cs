using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class NormalItem : IGildedItem
    {
        private GildedUtilityItem gildedItem;

        public NormalItem(Item item)
        {
            gildedItem = new GildedUtilityItem(item);
        }

        public void UpdateQuality()
        {
            if (gildedItem.SellIn < 0)
            {
                gildedItem.DecreaseQualityBy(2);
            }
            else
            {
                gildedItem.DecreaseQualityBy(1);
            }
        }

        public void UpdateSellIn()
        {
            gildedItem.DecreaseSellInBy(1);
        }
    }
}