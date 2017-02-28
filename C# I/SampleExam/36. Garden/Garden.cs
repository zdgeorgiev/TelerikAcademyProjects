using System;

class Garden
{
    static void Main(string[] args)
    {
        int tomato = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumber = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potato = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrot = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbage = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beans = int.Parse(Console.ReadLine());

        const int TotalArea = 250;

        double totalCost = tomato * 0.5 + cucumber * 0.4 + potato * 0.25
            + carrot * 0.6 + cabbage * 0.3 + beans * 0.4;

        Console.WriteLine("Total costs: {0:F2}", totalCost);

        if (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea > 250)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea < 250)
        {
            int areaLeftForBeans = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
            Console.WriteLine("Beans area: {0}", areaLeftForBeans);
        }
        else
        {
            Console.WriteLine("No area for beans");
        }
    }
}