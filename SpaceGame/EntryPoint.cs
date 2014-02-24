namespace SpaceGame
{
    using SpaceGame.Items;
    using System;

    class EntryPoint
    {
        public static readonly Random rand = new Random();
        static void Main()
        {
            var render = new ConsoleRenderer(50 , 30);
            var player = new PlayerShip();
            var engine = new Engine(render , player);
            engine.AddObject(player);
            engine.Run();
        }
    }
}
