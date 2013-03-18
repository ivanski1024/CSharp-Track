using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplosionWave : Ball
    {
        private byte lifetime;
        private char[,] exploadingWaveBody = { { '+' } };
        public ExplosionWave(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            this.lifetime = 0;
            this.body = exploadingWaveBody;
        }
         
        public ExplosionWave(MatrixCoords topLeft, MatrixCoords speed, byte lifetime)
            : base(topLeft, speed)
        {
            this.lifetime = lifetime;
        }

        public override void Update()
        {

            IsDestroyed = true;
            base.Update();
        }
    }
}
