using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        private uint lifetime = 1;
        public TrailObject(MatrixCoords topLeft, char[,] body, uint lifetime ) : base(topLeft, body)
        {
            this.lifetime = lifetime;
        }

        public override void Update()
        {
            if (this.lifetime == 0)
            {
                this.IsDestroyed = true;
            }
            else
            {
                this.lifetime--;
            }
        }
    }
}
