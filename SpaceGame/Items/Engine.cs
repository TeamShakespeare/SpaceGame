namespace SpaceGame.Items
{
    using System;

    public class Engine : Item
    {
        private static readonly Random rand = new Random();

        protected Engine(string name, int weight)
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
