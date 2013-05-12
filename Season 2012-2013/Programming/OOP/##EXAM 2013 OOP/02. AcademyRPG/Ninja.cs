using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        public int AttackPoints { get { return attk; } }
        private int attk = 0;
        public int DefensePoints { get { return int.MaxValue; } }

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            //this.IsDestroyed = false;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            bool isHighest = true;

            foreach (var tar in availableTargets)
            {
                if (this.HitPoints < tar.HitPoints)
                {
                    isHighest = false;
                    break;
                }
            }

            if (isHighest)
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
            else
            {
                return -1;
            }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attk += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.attk += resource.Quantity * 2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
