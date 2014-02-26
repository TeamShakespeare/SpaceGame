using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SpaceGame.Items;

namespace SpaceGame
{
    public class Engine
    {
        private List<IWorldObject> worldObject;
        private IRenderer render;
        private PlayerShip player;
        private Random randomGenerator;
        private int counterOfInteration;

        public Engine(ConsoleRenderer render, PlayerShip player , List<IWorldObject> objects , Random randomGenerator)
        {
            this.render = render;
            worldObject = objects;
            this.player = player;
            this.randomGenerator = randomGenerator;
        }

        public void Run()
        {

            //this.player.Inventory.AddItem(GenerateItem.GenerateRandomItem(randomGenerator));

            while (true)
            {
                counterOfInteration++;
                int counter = 1;

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo playerKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
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
                        case ConsoleKey.R:
                            if (this.player.Inventory.Fire(ItemType.Missile))
                            {
                                this.AddObject(new Missile(this.player.ProjectilePosition()));
                            }
                            break;
                        case ConsoleKey.Escape:
                            EscapeToShop();
                            break;
                        default: break;

                    }
                }

                GenerateRandomEnemy();

                foreach (var item in this.worldObject)
                {
                    item.Update();
                }

                foreach (var item in this.worldObject)
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
            worldObject.Add(obj);

        }
        public void CheckCollision()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Save&switsh to window mode
        /// </summary>
        private void EscapeToShop()
        {
            player.SaveShip();
            WindowSwitch.Utilities.SwitchToWindow();
        }

    }
}
