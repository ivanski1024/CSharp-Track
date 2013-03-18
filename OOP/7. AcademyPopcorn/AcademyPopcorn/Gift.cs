using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Gift : MovingObject
    {
        private static char[,] giftBody = { { '$' } };

        public Gift(MatrixCoords topLeft) : base(topLeft, Gift.giftBody, new MatrixCoords(1, 0)) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {

            //TODO: Edit the setting of the new racket's position and width.

            List<GameObject> newObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                newObjects.Add(new ShootingRacket(new MatrixCoords(this.topLeft.Row+1, this.topLeft.Col-3), 7));
            }

            return newObjects;
        }

    }
}
