using SpaceGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWindow
{
    class ShoppingShip : PlayerShip
    {
        internal static PlayerShip theOne = PlayerShip.LoadShip();
        
        //void PlusHealth()
        //{
        //    theOne.HealthPoint++;
        //}
    }
}
