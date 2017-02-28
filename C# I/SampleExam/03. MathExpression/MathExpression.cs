using System;

class MathExpression
{
    static void Main(string[] args)
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal firstPart = n * n + (1 / (m * p)) + 1337;
        decimal secondPart = n - (128.523123123M * p);
        decimal thirdPart = (decimal)Math.Sin(((int)m) % 180);

        decimal result = Math.Round((firstPart / secondPart) + thirdPart, 6);
        Console.WriteLine(result);
    }
}