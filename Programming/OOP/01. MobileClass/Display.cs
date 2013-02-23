using System;

class Display
{
    private int? displaySize;
    private decimal? numbersOfColors;

    public Display()
        : this(null, null)
    {
    }

    public Display(int? displaySize)
        : this(displaySize, null)
    {
    }

    public Display(int? displaySize, decimal? numbersOfColors)
    {
        this.displaySize = displaySize;
        this.numbersOfColors = numbersOfColors;
    }

    public int? DisplaySize
    {
        get { return this.displaySize; }
        set
        {
            if ((value > 0 && value <= 100) || value == null)
            {
                this.displaySize = value;
            }
            else
            {
                throw new ArgumentException("DisplaySize should be from 1 to 100 inches.");
            }
        }
    }

    public decimal? NumberOfColors
    {
        get { return this.numbersOfColors; }
        set
        {
            if ((value > 0 && value <= 100000000) || value == null)
            {
                this.numbersOfColors = value;
            }
            else
            {
                throw new ArgumentException("DisplaySize should be from 1 to 100,000,000 inches.");
            }
        }
    }
}
