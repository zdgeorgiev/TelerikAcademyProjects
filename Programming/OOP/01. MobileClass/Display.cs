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
        set { this.displaySize = value; }
    }

    public decimal? NumberOfColors
    {
        get { return this.numbersOfColors; }
        set { this.numbersOfColors = value; }
    }
}
