namespace SpaceGame.Items
{
    using System;

    public class Engine : Item
    {
        public Engine(Random rand)
            : base(rand)
        {
            this.itemType = ItemType.Engine;
            SetRandomProps();
        }

        private void SetRandomProps()
        {
            this.bonusValue = (Bonus)(randGenerator.Next(0, 5) * 10);
            this.Name = Enum.GetName(typeof(Bonus), bonusValue)+" Engine";
        }
    }
}
