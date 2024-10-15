using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class GildedUtilityItem
    {
        private Item _item;
        public GildedUtilityItem(Item item)
        {
            _item = item;
        }
        public void IncreaseQualityBy(int amount)
        {
            _item.Quality = Math.Min(50, _item.Quality + amount);
        }
        public void DecreaseQualityBy(int amount)
        {
            _item.Quality = Math.Max(0, _item.Quality - amount);
        }
        public void SetQualityToZero()
        {
            _item.Quality = 0;
        }
        public void DecreaseSellInBy(int amount)
        {
            _item.SellIn -= amount;
        }
        public int SellIn => _item.SellIn;

    }
}