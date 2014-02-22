namespace SpaceGame.Items
{
    using System;

    public class Weapon : Item
    {
        public Weapon(Random rand)
            : base(rand)
        {
            SetRandomProps();
        }

        private void SetRandomProps()
        {
            this.itemType = (ItemType)(randGenerator.Next(0, 1));
            this.bonusValue = (Bonus)(randGenerator.Next(0, 5) * 10);
            this.Name = Enum.GetName(typeof(Bonus), bonusValue) + Enum.GetName(typeof(ItemType), itemType);
        }
    }
}
