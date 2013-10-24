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
            if (this.IsAlive)
            {
                this.Size++;
            }

            base.Update(time);
        }
    }
}