using System;
using System.Collections.Generic;

namespace Store
{
    public class Player
    {
        public List<Item> inventory = new List<Item>() { };


        public void InventoryItems()
        {
            Dictionary<string, int> itemsCount = new Dictionary<string, int>();

            foreach (Item item in inventory)
            {
                if (itemsCount.ContainsKey(item.GetName()))
                {
                    itemsCount[item.GetName()] += 1; //itemsCount[item.GetName()] = itemsCount[item.GetName()] + 1;
                }
                else
                {
                    itemsCount.Add(item.GetName(), 1);
                }
            }

            foreach (KeyValuePair<string, int> entry in itemsCount) //Den raden är Inte min kod men förstår den ändå :)
            {
                System.Console.WriteLine(entry.Key + " X" + entry.Value);
            }

        }
    }
}
