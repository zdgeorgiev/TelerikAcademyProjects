using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        public int Quantity { get { return this.HitPoints / 2; } }

        public Rock(int hitPoint, Point position)
            : base(position)
        {
            this.HitPoints = hitPoint;
        }

        public ResourceType Type
        {
            get { { return ResourceType.Stone; } }
        }
    }
}