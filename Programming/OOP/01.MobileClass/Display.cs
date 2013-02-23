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
            if (value <= 0 || value == null)
            {
                throw new ArgumentException("Display size cannot be 0 or smaller.");
            }
            else if (value > 100)
            {
                throw new ArgumentException("Display size cannot be higher than 100 inches.");
            }
            this.displaySize = value;
        }
    }

    public decimal? NumberOfColors
    {
        get { return this.numbersOfColors; }
        set
        {
            if (value <= 0 || value == null)
            {
                throw new ArgumentException("NumberOfColors cannot be 0 or smaller.");
            }
            else if (value > 100000000)
            {
                throw new ArgumentException("NumberOfColors cannot higher than 100,000,000.");
            }
            this.numbersOfColors = value;
        }
    }
}
