using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public new const char Symbol = 'Q';
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            this.body[0, 0] = UnstoppableBall.Symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == UnpassableBlock.CollisionGroupString ||
                   otherCollisionGroupString == IndestructibleBlock.CollisionGroupString ||
                   otherCollisionGroupString == Block.CollisionGroupString ||
                   otherCollisionGroupString == Racket.CollisionGroupString;
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            for (int i = 0; i < collisionData.hitObjectsCollisionGroupStrings.Count; i++)
            {
                if (collisionData.hitObjectsCollisionGroupStrings[i] == IndestructibleBlock.CollisionGroupString ||
                    collisionData.hitObjectsCollisionGroupStrings[i] == UnpassableBlock.CollisionGroupString ||
                    collisionData.hitObjectsCollisionGroupStrings[i] == Racket.CollisionGroupString)
                {
                    if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
                    {
                        this.Speed.Row *= -1;
                    }
                    if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
                    {
                        this.Speed.Col *= -1;
                    }
                }
            }
        }
    }
}