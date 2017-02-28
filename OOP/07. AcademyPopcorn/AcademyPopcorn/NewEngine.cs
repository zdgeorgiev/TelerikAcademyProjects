using System;
using System.Linq;

namespace AcademyPopcorn
{
    class NewEngine : Engine
    {
        public NewEngine(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
        }

        public void ShootPlayerRacket()
        {
        }
    }
}