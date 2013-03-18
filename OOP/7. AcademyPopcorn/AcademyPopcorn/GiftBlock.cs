using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class GiftBlock : Block
    {
        private bool isHit = false;
        static private char[,] giftBlockBody = { { '+' } };

        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body = GiftBlock.giftBlockBody;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            base.RespondToCollision(collisionData);

            isHit = true;
            DropGift();
        }

        private void DropGift()
        {
            ProduceObjects();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (isHit)
            {
                List<Gift> gifts = new List<Gift>();
                gifts.Add(new Gift(new MatrixCoords(this.topLeft.Row + 1, this.TopLeft.Col)));
                return gifts;
            }
            else
            {
                return base.ProduceObjects();
            }

        }

    }
}
