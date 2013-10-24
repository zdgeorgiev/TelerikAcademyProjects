﻿using AcademyEcosystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BiteSize = 2;

        public Boar(string name, Point location)
            : base(name, location, 4)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                return plant.GetEatenQuantity(BiteSize);
            }

            return 0;
        }
    }
}
