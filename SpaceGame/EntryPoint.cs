namespace SpaceGame
{
    using SpaceGame.Items;
    using System;
    using System.Collections.Generic;

    class EntryPoint
    {
        public static readonly Random rand = new Random();
        static void Main()
        {
            var render = new ConsoleRenderer(50 , 30);
            var player = new PlayerShip();
            var objects = new List<IWorldObject>();
            var engine = new Engine(render , player , objects);
            engine.AddObject(player);
            engine.Run();
        }
    }
}
