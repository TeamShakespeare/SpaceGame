﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public abstract class Projectile : IWorldObject
    {
        public int DMGMultipier
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Fire()
        {
            throw new System.NotImplementedException();
        }
    }
}
