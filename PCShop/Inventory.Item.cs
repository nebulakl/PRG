// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace PCShopRevisited
{
    public partial class Inventory
    {
        public class Item
        {
            public string Name { get; set; } = "";
            public double Price { get; set; } = 0;

            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return string.Format("{0}, ${1:0.00}", Name, Price);
            }
        }
    }
}