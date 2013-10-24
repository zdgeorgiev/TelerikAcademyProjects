using System;
using System.Collections.Generic;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private bool hasGather = false;
        private int attackPoints = 150;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!hasGather)
                {
                    this.attackPoints += 100;
                    hasGather = true; 
                }

                return true;
            }

            return false;
        }
    }
}
