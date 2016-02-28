using System;

public class SystemOfFunctions
{
    private const int MaxCount = 6;

    public static void Main()
    {
        Converter converter = new Converter();

        converter.ConvertBoolToString(true);
    }
}