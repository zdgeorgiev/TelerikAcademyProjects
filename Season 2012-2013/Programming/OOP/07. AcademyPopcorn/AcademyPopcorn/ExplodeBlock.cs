using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodeBlock : Block
    {
        public const char Symbol = '@';
        public new const string CollisionGroupString = "explodeBlock";

        public ExplodeBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(-1, 0)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(1, 0)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(0, 1)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(0, -1)));
            }
            return produceObjects;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }
    }
}

//Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed.
//You must NOT edit any existing .cs file. Hint: what does an explosion "produce"?
