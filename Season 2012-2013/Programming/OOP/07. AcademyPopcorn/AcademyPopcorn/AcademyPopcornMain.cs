using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(new UnpassableBlock(new MatrixCoords(startRow - 3, i)));

                engine.AddObject(currBlock);
            }

            for (int i = 0; i < WorldRows; i++)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(i, 0)));
                engine.AddObject(new UnpassableBlock(new MatrixCoords(i, WorldCols - 1)));
                if (i == 7)
                {
                    engine.AddObject(new ExplodeBlock(new MatrixCoords(startRow, i + 1)));
                }
                //engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, 0)));
                //engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
            }

            //Replacing the original ball with MeteoriteBall

            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //
            //engine.AddObject(theBall);

            engine.AddObject(new Meteoriteball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1)));

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //engine.AddObject(new TrailObject(new MatrixCoords(15, 15), new char[,] { { '$' } }, 5));

            engine.AddObject(new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1)));
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
