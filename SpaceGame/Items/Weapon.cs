namespace SpaceGame.Items
{
    using System;

    public class Weapon : Item
    {
        private static readonly Random rand = new Random();

        protected Weapon(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public static override Item GenerateItem()
        {
            throw new NotImplementedException();
        }
    }
}
