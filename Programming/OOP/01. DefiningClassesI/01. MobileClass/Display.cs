using System;

class Display
{
    private int? displaySize;
    private decimal? numberOfColors;

    public Display()
        : this(null, null)
    {
    }

    public Display(int? displaySize)
        : this(displaySize, null)
    {
    }

    public Display(int? displaySize, decimal? numberOfColors)
    {
        this.DisplaySize = displaySize;
        this.NumberOfColors = numberOfColors;
    }

    public int? DisplaySize
    {
        get { return this.displaySize; }
        set
        {
            if (value == null || value > 0)
            {
                this.displaySize = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public decimal? NumberOfColors
    {
        get { return this.numberOfColors; }
        set
        {
            if (value == null || value > 0)
            {
                this.numberOfColors = value;
            }
            else
            {
                throw new ArgumentException("DisplaySize should be atleast 1 collor.");
            }
        }
    }
}
