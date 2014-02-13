namespace SpaceGame.Items
{
    public abstract class Item
    {
        public string Name { get; protected set; }
        public int Weight { get; protected set; } //If the inventory is limited

        public abstract static Item GenerateItem();
    }
}
