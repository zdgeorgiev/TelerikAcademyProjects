using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShoothingRacket : Racket
    {
        public ShoothingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            produceObjects.Add(new Bullet(this.topLeft));
            return produceObjects;
        }
    }
}