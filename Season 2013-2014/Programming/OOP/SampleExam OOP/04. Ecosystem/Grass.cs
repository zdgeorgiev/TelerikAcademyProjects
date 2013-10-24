using AcademyEcosystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosystem
{
    public class Grass : Plant
    {
        public Grass(Point position)
            : base(position, 2)
        {
        }

        public override void Update(int time)
        {
            for (int i = 0; i < time; i++)
            {
                if (this.IsAlive)
                {
                    this.Size++;
                }
                else
                {
                    break;
                }
            }

            base.Update(time);
        }
    }
}