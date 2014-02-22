using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public interface IWorldObject : IRenderable
    {
        bool Alive
        {
            get;
            set;
        }

        Position Position
        {
            get;
            set;
        }

        void Move();
    }
}
