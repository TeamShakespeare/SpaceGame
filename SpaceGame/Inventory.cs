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

        public void IsInInventory(ItemType type)
        {
            //TODO:Implement
            switch (type)
            {
                case ItemType.Missile:
                    break;
                case ItemType.Bomb:
                    break;
                case ItemType.Engine:
                    break;
                case ItemType.Shield:
                    break;
                default:
                    break;
            }
        }
    }
}
