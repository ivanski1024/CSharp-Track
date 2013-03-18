using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppable";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            char[,] someBody = { { '*' } };
            this.body = someBody;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "unpassable";
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }


        public override void RespondToCollision(CollisionData collisionData)
        {

            foreach (string hittenObject in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (hittenObject == Racket.CollisionGroupString || hittenObject == UnpassableBlock.CollisionGroupString)
                {
                    base.RespondToCollision(collisionData);
                }

            }

        }
    }
}
