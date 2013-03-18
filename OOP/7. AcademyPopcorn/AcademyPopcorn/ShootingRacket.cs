using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {
        private bool  actionPressed = false;
        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width) { }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Bullet> bullets = new List<Bullet>();
                       
            if (actionPressed)
            {
                bullets.Add(new Bullet(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col+this.Width / 2)));
                this.actionPressed = false;
            }
            return bullets;
        }


        public override void Update()
        {
            base.Update();
            //this.ProduceObjects();
        }

        public void Shoot()
        {
            this.actionPressed = true;
        }


    }
}
