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

        public Engine(ConsoleRenderer render, PlayerShip player , List<IWorldObject> objects)
        {
            this.render = render;
            worldObejct = objects;
            this.player = player;
        }

        public void Run()
        {
            
            while (true)
            {
                int counter = 1;
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo playerKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true); //The sokoban moves without lagging
                        counter++;
                    }
                    switch (playerKey.Key)
                    {

                        case ConsoleKey.LeftArrow:
                            this.player.Move(-counter);
                            break;
                        case ConsoleKey.RightArrow:
                            this.player.Move(counter);
                            break;
                        case ConsoleKey.Spacebar:
                            this.AddObject(new Bullet(this.player.ProjectilePosition()));
                        break;
                        default: break;

                    }
                }

                foreach (var item in this.worldObejct)
                {
                    item.Update();
                }

                foreach (var item in this.worldObejct)
                {
                    render.EnqueueForRendering(item);

                }
                render.RenderAll();
                render.ClearQueue();
                Thread.Sleep(100);
                
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
