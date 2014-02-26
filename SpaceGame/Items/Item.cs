namespace SpaceGame.Items
{
    using System;

    [Serializable]
    public abstract class Item
    {
        public string Name { get; protected set; }
        protected Random randGenerator;
        protected ItemType itemType;
        protected Bonus bonusValue;

        public Item(Random rand)
        {
            this.randGenerator = rand;
        }

        public ItemType ItemType
        {
            get 
            {
                return this.itemType;
            }
        }
    }
}
