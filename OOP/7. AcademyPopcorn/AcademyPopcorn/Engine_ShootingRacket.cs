using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Engine_ShootingRacket : Engine
    {
        public Engine_ShootingRacket(IRenderer renderer, IUserInterface userInterface, int threadSleep)
            : base(renderer, userInterface, threadSleep) { }
            
        public void ShootPlayerRacket()
        {
            if (this.playerRacket is ShootingRacket)
            {
                (this.playerRacket as ShootingRacket).Shoot();
            }
        }
    }
}
