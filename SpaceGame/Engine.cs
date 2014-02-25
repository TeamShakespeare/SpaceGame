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
        private Random randomGenerator;
        private int counterOfInteration;

        public Engine(ConsoleRenderer render, PlayerShip player , List<IWorldObject> objects , Random randomGenerator)
        {
            this.render = render;
            worldObejct = objects;
            this.player = player;
            this.randomGenerator = randomGenerator;
        }

        public void Run()
        {
            
            while (true)
            {
                counterOfInteration++;
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

                GenerateRandomEnemy();

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

        private void GenerateRandomEnemy()
        {
            if (counterOfInteration > 4)
            {
                if (randomGenerator.Next(5) == 3)
                {
                    counterOfInteration = 0;
                    this.AddObject(new EnemyShip(20, 10, new MatrixCoords(0, randomGenerator.Next(28)), this.randomGenerator));
                }
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

    }
}
