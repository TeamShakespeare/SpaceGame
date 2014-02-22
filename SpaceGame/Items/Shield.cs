namespace SpaceGame.Items
{
    using System;

    public class Shield : Item
    {
        public Shield(Random rand)
            : base(rand)
        {
            this.itemType = ItemType.Shield;
            SetRandomProps();
        }

        private void SetRandomProps()
        {
            this.bonusValue = (Bonus)(randGenerator.Next(0, 5) * 10);
            this.Name = Enum.GetName(typeof(Bonus), bonusValue)+" Shield";
        }
    }
}
