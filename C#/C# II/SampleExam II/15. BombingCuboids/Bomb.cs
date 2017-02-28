using System;

public class Bomb
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Depth { get; set; }
    public int Power { get; set; }

    public Bomb(int width, int height, int depth, int power)
    {
        this.Width = width;
        this.Height = height;
        this.Depth = depth;
        this.Power = power;
    }
}