namespace SpaceGame
{
    using SpaceGame.Items;
    using System;

    class EntryPoint
    {
        public static readonly Random rand = new Random();
        static void Main()
        {
            var render = new ConsoleRenderer(30 , 30);
            var engine = new Engine(render);
            engine.AddObject(new PlayerShip());
            engine.Run();
        }
    }
}
