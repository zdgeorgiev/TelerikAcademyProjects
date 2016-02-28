using System;

public class Size
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public static Size GetRotatedSize(Size oldSize, double rotatedAngle)
    {
        double cosOfTheFigure = Math.Abs(Math.Cos(rotatedAngle));
        double sinOfTheFigure = Math.Abs(Math.Sin(rotatedAngle));

        double widthOfTheRotatedFigure = cosOfTheFigure * oldSize.Width + sinOfTheFigure * oldSize.Height;
        double heightOfTheRotatedFigure = sinOfTheFigure * oldSize.Width + cosOfTheFigure * oldSize.Height;

        Size rotatedSize = new Size(widthOfTheRotatedFigure, heightOfTheRotatedFigure);

        return rotatedSize;
    }
}