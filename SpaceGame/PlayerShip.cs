using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class PlayerShip : Ship
    {
        private Inventory inventory;

         //<summary>
         //A prameterless constructor using default values OR the CurrentState.txt file
         //</summary>
        public PlayerShip()
            :base(10,2,new MatrixCoords(44,20))
        {
            if (!System.IO.File.Exists(@"..\..\..\CurrentState.txt"))
            {                
                this.Speed = 10;
                this.inventory = new Inventory();
            }
            else
            {
                var fields = this.GetType().GetFields();
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"..\..\..\CurrentState.txt"))
                {
                    //foreach (var field in fields)
                    //{
                    //    this.GetType().GetField(field.Name) = new 
                    //}
                }
            }
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
