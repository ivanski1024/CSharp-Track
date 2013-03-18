using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        //public List<TrailObject> Trail = new List<TrailObject>(); 
        
        public MeteoriteBall( MatrixCoords topLeft, MatrixCoords speed) : base (topLeft, speed)
        {
            //this.engine = engine;
            
        }

        private static char[,] trailBody = { { '.' } };

        public override void Update()
        {
            base.Update();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> trail = new List<TrailObject>();
            trail.Add(new TrailObject(this.TopLeft, trailBody, 3));
            return trail;
        }
    }
}
