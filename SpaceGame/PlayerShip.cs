using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    [Serializable]
    public class PlayerShip : Ship
    {
        private Inventory inventory;


         //<summary>
         //A prameterless constructor using default values
         //</summary>
        public PlayerShip()
            :base(10,2,new MatrixCoords(44,20))
        {
            this.Speed = 10;
            this.inventory = new Inventory();
        }

        //The path to the saved ship file (if any)
        private static string filePath = @"..\..\..\CurrentState.boat";

        /// <summary>
        /// A static method to be used in the Engine, either generates a new PleyerShip
        /// or reads it from a file.
        /// </summary>
        /// <returns></returns>
        public static PlayerShip LoadShip()
        {
            if (!System.IO.File.Exists(filePath))
            {
                return new PlayerShip();                
            }
            else
            {
                return (PlayerShip)WindowSwitch.Utilities.Deserialize(filePath);
            }
        }

        /// <summary>
        /// To be used in the Engine, saves the PlayerShip to a file before switching to ShoppingWindow
        /// </summary>
        public void SaveShip()
        {
            WindowSwitch.Utilities.Serialize(this,filePath);
        }

        public MatrixCoords ProjectilePosition()
        {
            return new MatrixCoords(this.position.Row-1, this.position.Col + 2);
        }
        public void Move(int number)
        {
            this.position.Col += number;
        }

        public override char[,] GetImage()
        {
            return new char[,]
            {
            {'0' , '0' , '7' , '0' , '0'},
            {'7' , '0' , '7' , '0' , '7'},
            {'0' , '7' , '7' , '7' , '0'},
            {'7' , '7' , '0' , '7' , '7'},
            {'7' , '0' , '0' , '0' , '7'},
            };
        }
    }
}
