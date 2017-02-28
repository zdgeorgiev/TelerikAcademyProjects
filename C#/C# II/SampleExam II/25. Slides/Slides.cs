using System;

class Ball
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Depth { get; set; }

    public Ball(int width, int height, int depth)
    {
        this.Width = width;
        this.Height = height;
        this.Depth = depth;
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", this.Width, this.Height, this.Depth);
    }
}

class Slides
{
    private static int width, height, depth;
    private static string[, ,] cube;
    private static Ball ball;

    static void Main(string[] args)
    {
        ProcessInput();

        bool isStucked = false;
        bool isFinished = false;

        while (true)
        {
            string nextCoordinate = cube[ball.Width, ball.Height, ball.Depth];

            if (ball.Height == height - 1 && nextCoordinate.StartsWith("S"))
            {
                isFinished = true;
                break;
            }

            if (nextCoordinate.StartsWith("S"))
            {
                //(S R)
                string direction = nextCoordinate.Split()[1];

                switch (direction)
                {
                    //Direction: L R F B FL FR BL BR
                    case "L":
                        ball.Width--;
                        break;
                    case "R":
                        ball.Width++;
                        break;
                    case "F":
                        ball.Depth--;
                        break;
                    case "B":
                        ball.Depth++;
                        break;
                    case "FL":
                        ball.Depth--;
                        ball.Width--;
                        break;
                    case "FR":
                        ball.Depth--;
                        ball.Width++;
                        break;
                    case "BL":
                        ball.Depth++;
                        ball.Width--;
                        break;
                    case "BR":
                        ball.Depth++;
                        ball.Width++;
                        break;
                    default:
                        throw new ArgumentException("Invalid direction {0}", direction);
                }
            }
            else if (nextCoordinate.StartsWith("T"))
            {
                //(T 1 1)
                string[] newCoords = nextCoordinate.Split();

                ball.Width = int.Parse(newCoords[1]);
                ball.Depth = int.Parse(newCoords[2]);

                continue;
            }
            else if (nextCoordinate.StartsWith("B"))
            {
                isStucked = true;
                break;
            }

            if (ball.Width < 0 || ball.Width >= width || ball.Depth < 0 || ball.Depth >= depth)
            {
                isStucked = true;

                GetTheLastBlockCoords(nextCoordinate);

                break;
            }

            ball.Height++;

            if (ball.Height == height)
            {
                isFinished = true;
                break;
            }
        }

        if (isFinished)
        {
            Console.WriteLine("Yes");
        }
        else if (isStucked)
        {
            Console.WriteLine("No");
        }

        Console.WriteLine(ball);
    }

    private static void GetTheLastBlockCoords(string nextCoordinate)
    {
        switch (nextCoordinate.Split()[1])
        {
            case "L":
                ball.Width++;
                break;
            case "R":
                ball.Width--;
                break;
            case "F":
                ball.Depth++;
                break;
            case "B":
                ball.Depth--;
                break;
            case "FL":
                ball.Depth++;
                ball.Width++;
                break;
            case "FR":
                ball.Depth++;
                ball.Width--;
                break;
            case "BL":
                ball.Depth--;
                ball.Width++;
                break;
            case "BR":
                ball.Depth--;
                ball.Width--;
                break;
            default:
                break;
        }
    }

    private static void ProcessInput()
    {
        string[] dimentionNumbers = Console.ReadLine().Split();

        width = int.Parse(dimentionNumbers[0]);
        height = int.Parse(dimentionNumbers[1]);
        depth = int.Parse(dimentionNumbers[2]);

        cube = new string[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            //(S L)(E)(S L) | (S L)(S R)(S L) | (B)(S F)(S L)
            string currentLine = Console.ReadLine();

            for (int d = 0; d < depth; d++)
            {
                //(S L)(E)(S L)
                string[] rawNumbers =
                    currentLine.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    //(S L)
                    string[] numberWidth =
                        rawNumbers[d].Split(new string[] { ")", "(" }, StringSplitOptions.RemoveEmptyEntries);

                    cube[w, h, d] = numberWidth[w];
                }
            }
        }

        string[] ballCoordiantes = Console.ReadLine().Split();

        int ballWidth = int.Parse(ballCoordiantes[0]);
        int ballDepth = int.Parse(ballCoordiantes[1]);

        ball = new Ball(ballWidth, 0, ballDepth);
    }
}