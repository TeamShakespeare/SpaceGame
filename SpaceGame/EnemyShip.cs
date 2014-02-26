using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class EnemyShip : Ship
    {
        private Random randomGenerator;
        public EnemyShip(int healthPoint, int attackDamage , MatrixCoords position , Random rand):
            base(healthPoint , attackDamage , position)
        {
            this.randomGenerator = rand;
        }

        public override char[,] GetImage()
        {
            return new char[,]
            {
            {'5' , '0' , '5' },
            {'5' , '5' , '5'},
            {'0' , '5' , '0' },
            };
        }

        public override void Update()
        {
            this.position += new MatrixCoords(1, 0);
            if(randomGenerator.Next(5)==0)
            {
                this.position += new MatrixCoords(0, 1);
            }
            else if(randomGenerator.Next(5)==1)
            {
                this.position -= new MatrixCoords(0, 1);
            }
        }

    }
}
