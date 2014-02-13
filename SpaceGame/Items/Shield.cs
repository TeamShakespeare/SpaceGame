namespace SpaceGame.Items
{
    using System;

    public class Shield : Item
    {
        private static readonly Random rand = new Random();

        protected Shield(string name, int weight)
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
