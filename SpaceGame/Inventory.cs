using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceGame.Items;

namespace SpaceGame
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            this.items = new List<Item>();
        }

        public List<Item> Items
        {
            get
            {
                return this.items;
            }
        }
    
        public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public bool Fire(ItemType type)
        {
            foreach (var item in this.Items)
            {
                if (item.ItemType == type)
                {
                    this.items.Remove(item);
                    return true;
                }
            }

            return false;
        }
    }
}
