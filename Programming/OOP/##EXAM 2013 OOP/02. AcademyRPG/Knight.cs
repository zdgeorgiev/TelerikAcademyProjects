using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Knight : Character, IFighter
    {
        public int AttackPoints { get { return 100; } }
        public int DefensePoints { get { return 100; } }

        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 100;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int target = 0; target < availableTargets.Count; target++)
            {
                if (availableTargets[target].Owner != this.Owner && availableTargets[target].Owner != 0)
                {
                    return target;
                }
            }
            return -1;
        }
    }
}
