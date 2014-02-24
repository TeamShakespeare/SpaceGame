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

        public Engine(ConsoleRenderer render)
        {
            this.render = render;
            worldObejct = new List<IWorldObject>();
        }

        public void Run()
        {
            while(true)
            {
                foreach (var item in worldObejct)
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
