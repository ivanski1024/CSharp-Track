using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Bullet : MovingObject
    {

        

        private static char[,] bulletBody = { { '^' } };
        private static string type = "bullet";

        public override string GetCollisionGroupString()
        {
            return Bullet.type;
        }


        public Bullet(MatrixCoords topLeft) : base(topLeft, Bullet.bulletBody, new MatrixCoords(-1, 0)) { }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
    }
}
