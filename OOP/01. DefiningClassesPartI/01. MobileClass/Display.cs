using System;
using System.Text;

public class Display
{
    private ulong size;
    private ulong numberOfColors;

    public Display(ulong size, ulong numberOfColors)
    {
        this.Size = size;
        this.NumberOfColors = numberOfColors;
    }

    public ulong Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size of the display cannot be less than 0.");
            }

            this.size = value;
        }
    }

    public ulong NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number of colors cannot be less than 0.");
            }

            this.numberOfColors = value;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

            output.Append(
                string.Format("(Size - {0}, Colors - {1})", this.Size, this.NumberOfColors));

        return output.ToString();
    }
}