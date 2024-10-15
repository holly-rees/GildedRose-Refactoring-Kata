using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BackstagePass : IGildedItem
    {
        private GildedUtilityItem gildedItem;

        public BackstagePass(Item item)
        {
            gildedItem = new GildedUtilityItem(item);
        }


        public void UpdateQuality()
        {
            switch (gildedItem.SellIn)
            {
                case < 0:
                    gildedItem.SetQualityToZero();
                    break;
                case < 5:
                    gildedItem.IncreaseQualityBy(3);
                    break;
                case < 10:
                    gildedItem.IncreaseQualityBy(2);
                    break;
                default:
                    gildedItem.IncreaseQualityBy(1);
                    break;
            }

        }

        public void UpdateSellIn()
        {
            gildedItem.DecreaseSellInBy(1);
        }
    }
}