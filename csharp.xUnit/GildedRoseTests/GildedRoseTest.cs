using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("foo", Items[0].Name);
    }

    [Fact]
    public void SulfurasDoesntChangeQuality()
    {

        IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(80, Items[0].Quality);

    }
    [Fact]
    public void SulfurasDoesntChangeSellIn()
    {

        IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].SellIn);

    }

    [Fact]
    public void NormalItemDecreasesQualityBy1BeforeSellIn()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(18, Items[0].Quality);
    }

    [Fact]
    public void NormalItemDecreasesQualityBy2AfterSellIn()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 19 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(17, Items[0].Quality);
    }
    [Fact]
    public void NormalItemDecreasesSellIn()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(8, Items[0].SellIn);
    }

    [Fact]
    public void AgedBrieIncreasesQualityByOneBeforeSellIn()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 9, Quality = 19 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(20, Items[0].Quality);
    }

    [Fact]
    public void AgedBrieIncreasesQualityByTwoAfterSellIn()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 19 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(21, Items[0].Quality);
    }

    [Fact]
    public void BackstagePassIncreaseQualityBy1WhenSellInOver10()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 14, Quality = 21 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(22, Items[0].Quality);
    }

    [Fact]
    public void BackstagePassIncreaseQualityBy2WhenSellInLessThan10()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 25 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(27, Items[0].Quality);
    }

    [Fact]
    public void BackstagePassIncreaseQualityBy3WhenSellInLessThan5()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 35 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(38, Items[0].Quality);
    }

    [Fact]
    public void BackstagePassQualitySetsToZeroAfterShow()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
}