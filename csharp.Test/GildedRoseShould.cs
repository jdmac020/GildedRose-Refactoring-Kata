using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

namespace csharp.Test
{
    public class GildedRoseShould
    {
        [Fact]
        public void StarterTest()
        {
            var testItem = new Item { Name = "Banana", SellIn = 5, Quality = 5 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Name.ShouldBe("fixme");
        }
    }
}
