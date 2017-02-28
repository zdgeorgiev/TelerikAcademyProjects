using System;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        public Rock(Point position)
            : base(position)
        {
        }

        public int Quantity
        {
            get { return this.HitPoints / 2; }
        }

        public ResourceType Type
        {
            get { return ResourceType.Stone; }
        }
    }
}
