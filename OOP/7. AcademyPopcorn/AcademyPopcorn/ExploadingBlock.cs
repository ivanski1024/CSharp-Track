using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExploadingBlock : Block
    {
        static private char[,] exploadingBlockBody = { { '+' } };

        public ExploadingBlock(MatrixCoords topLeft) : base(topLeft) 
        {
            this.body = ExploadingBlock.exploadingBlockBody;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            GenerateWave();
        }

        private void GenerateWave()
        {
            ProduceObjects();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<ExplosionWave> explosionPieces = new List<ExplosionWave>();

            if (this.IsDestroyed)
            {
                for (int row = -1; row < 2; row++)
                {
                    for (int col = -1; col < 2; col++)
                    {
                        if (!(row == 0 && col == 0))
                        {
                            //ProduceObjects(new ExplosionWave(new MatrixCoords(this.topLeft.Row, this.topLeft.Col), new MatrixCoords(row, col)));
                            explosionPieces.Add(new ExplosionWave(new MatrixCoords(this.topLeft.Row, this.topLeft.Col), new MatrixCoords(row, col)));
                        }
                    }
                }
            }
            return explosionPieces;
        }


    }
}
