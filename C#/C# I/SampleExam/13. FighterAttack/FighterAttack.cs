using System;

class FighterAttack
{
    static void Main(string[] args)
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int damage = 0;

        if ((fx + d >= px1 && fx + d <= px2) &&
            (fy >= py2 && fy <= py1))
        {
            damage += 100;
        }
        if (fx + d + 1 >= px1 && fx + d + 1 <= px2)
        {
            damage += 75;
        }
        if ((fy + 1 >= py2 && fy + 1 <= py1) && (fx + d >= px1 && fx + d <= px2))
        {
            damage += 50;
        }
        if ((fy - 1 >= py2 && fy - 1 <= py1) && (fx + d >= px1 && fx + d <= px2))
        {
            damage += 50;
        }

        Console.WriteLine(damage + "%");
    }
}