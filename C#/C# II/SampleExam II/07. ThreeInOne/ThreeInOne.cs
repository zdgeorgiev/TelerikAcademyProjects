using System;
using System.Linq;

class ThreeInOne
{
    static void Main(string[] args)
    {
        Task1();

        Task2();
        
        //TODO : Task3();
    }

    private static void Task2()
    {
        string[] cookies = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int numberOfFriends = int.Parse(Console.ReadLine());

        int[] allCookies = new int[cookies.Length];

        for (int i = 0; i < cookies.Length; i++)
        {
            allCookies[i] = int.Parse(cookies[i]);
        }

        Array.Sort(allCookies);
        Array.Reverse(allCookies);

        int totalCookies = allCookies[0];

        int myCookiesIndex = 0;
        int nextCookieIndex = myCookiesIndex + numberOfFriends + 1;

        while (nextCookieIndex < allCookies.Length)
        {
            totalCookies += allCookies[nextCookieIndex];
            nextCookieIndex += numberOfFriends + 1;
        }

        Console.WriteLine(totalCookies);
    }

    private static void Task1()
    {
        string[] points = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] allPoints = new int[points.Length];

        for (int i = 0; i < points.Length; i++)
        {
            if (int.Parse(points[i]) > 21)
            {
                continue;
            }

            allPoints[i] = int.Parse(points[i]);
        }

        Array.Sort(allPoints);

        //biggest element is the same with other one
        if (allPoints[allPoints.Length - 1] == allPoints[allPoints.Length - 2])
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(Array.IndexOf(points, allPoints[allPoints.Length - 1].ToString()));
        }
    }
}