using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            Item item = Items[i];
            IGildedItem gildedItem = GildedItemFactory(item);
            gildedItem.UpdateSellIn();
            gildedItem.UpdateQuality();
        }
    }

    private static IGildedItem GildedItemFactory(Item item)
    {
        return item.Name switch
        {
            "Sulfuras, Hand of Ragnaros" => new Sulfuras(item),
            "Aged Brie" => new AgedBrie(item),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePass(item),
            _ => new NormalItem(item)
        };
    }
}