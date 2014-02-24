using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SpaceGame
{
    public class Engine
    {
        private List<IWorldObject> worldObejct;
        private IRenderer render;
        private PlayerShip player;

        public Engine(ConsoleRenderer render, PlayerShip player)
        {
            this.render = render;
            worldObejct = new List<IWorldObject>();
            this.player = player;
        }

        public void Run()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo playerKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true); //The sokoban moves without lagging
                    }
                    switch (playerKey.Key)
                    {

                        case ConsoleKey.LeftArrow:
                            this.player.Move(-1);
                            break;
                        case ConsoleKey.RightArrow:
                            this.player.Move(1);
                            break;
                        //case ConsoleKey.Spacebar:
                        //    PressedSpacebar();
                        //break;
                        default: break;

                    }
                }
                foreach (var item in this.worldObejct)
                {
                    render.EnqueueForRendering(item);
                }
                render.RenderAll();
                render.ClearQueue();
                Thread.Sleep(300);
            }
        }
        

        public void AddObject(IWorldObject obj)
        {
            worldObejct.Add(obj);

        }
        public void CheckCollision()
        {
            throw new System.NotImplementedException();
        }

        public void MoveBots()
        {
            throw new System.NotImplementedException();
        }
    }
}
