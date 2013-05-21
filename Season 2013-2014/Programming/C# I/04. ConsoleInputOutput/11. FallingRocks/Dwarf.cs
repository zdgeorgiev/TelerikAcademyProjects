using System;

public class Dwarf
{
    public int Y { get; set; }
    public string Symbol { get; set; }
    public Field Field { get; set; }

    public Dwarf(string symbol, Field field)
    {
        this.Symbol = symbol;
        this.Field = field;
    }

    public void Move(ConsoleKeyInfo keyPressed)
    {
        if (keyPressed.Key == ConsoleKey.LeftArrow &&
            this.Y > 0)
        {
            this.Y--;
        }
        else if (keyPressed.Key == ConsoleKey.RightArrow &&
            this.Y < this.Field.Width)
        {
            this.Y++;
        }
    }

    public void PrintTheDwarf()
    {
        Console.SetCursorPosition(this.Y, Console.WindowHeight - 1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(this.Symbol);
        Console.ResetColor();
    }
}