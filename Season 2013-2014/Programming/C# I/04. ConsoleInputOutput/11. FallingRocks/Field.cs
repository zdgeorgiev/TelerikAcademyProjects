using System;

public class Field
{
    private int width;

    public Field(int width)
    {
        this.Width = width;
    }

    public int Width
    {
        get { return this.width; }
        set
        {
            if (value < 10 || value >= 31)
            {
                throw new ArgumentException(string.Format(
                    "Invalid game field width ({0}).Should be in range [10...30]", value));
            }
            this.width = value;
        }
    }
}