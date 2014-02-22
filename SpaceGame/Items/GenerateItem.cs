namespace SpaceGame.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class GenerateItem
    {
        public static Item GenerateRandomItem(Random rand)
        {
            int randNum = rand.Next(1,4);

            switch (randNum)
            {
                case 1:
                    return new Engine(rand);
                case 2:
                    return new Shield(rand);
                case 3:
                    return new Weapon(rand);
                default:
                    return null;
            }
        }
    }
}
