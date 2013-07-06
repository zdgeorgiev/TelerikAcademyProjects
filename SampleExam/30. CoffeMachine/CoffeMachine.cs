using System;
using System.Globalization;
using System.Threading;

class CoffeMachine
{
    // 93 / 100 
    // two time limits

    static void Main(string[] args)
    {
        //decimal fives = decimal.Parse(Console.ReadLine()) * 0.05M;
        //decimal tens = decimal.Parse(Console.ReadLine()) * 0.10M;
        //decimal twelf = decimal.Parse(Console.ReadLine()) * 0.20M;
        //decimal fifty = decimal.Parse(Console.ReadLine()) * 0.50M;
        //decimal one = decimal.Parse(Console.ReadLine()) * 1M;

        //// 0.05, 0.10, 0.20, 0.50, and 1.00

        //decimal userMoney = decimal.Parse(Console.ReadLine());
        //decimal piene = decimal.Parse(Console.ReadLine());

        //decimal totalMachinesum = fives + tens + twelf + fifty + one;
        ////Console.WriteLine(totalMachinesum);

        //if (userMoney >= piene)
        //{
        //    if (userMoney - piene > 0)
        //    {
        //        if (totalMachinesum >= userMoney - piene)
        //        {
        //            decimal resto = userMoney - piene;

        //            totalMachinesum -= resto;

        //            Console.WriteLine("Yes " + totalMachinesum);
        //        }
        //        else
        //        {
        //            decimal resto = userMoney - piene;

        //            Console.WriteLine("No " + Math.Abs(totalMachinesum - resto));
        //            //Console.WriteLine("No" + );
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("More " + (piene - userMoney));
        //}

        // Ensure the decimal separator is ".", not "," or any other
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        // Read the input
        int trayOne = int.Parse(Console.ReadLine());
        int trayTwo = int.Parse(Console.ReadLine());
        int trayThree = int.Parse(Console.ReadLine());
        int trayFour = int.Parse(Console.ReadLine());
        int trayFive = int.Parse(Console.ReadLine());
        decimal givenAmount = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

        // Check the 3 possible cases
        if (givenAmount < drinkPrice)
        {
            decimal difference = drinkPrice - givenAmount;
            Console.WriteLine("More {0:F2}", difference);
        }
        else
        {
            decimal moneyInTrays =
                0.05m * trayOne +
                0.10m * trayTwo +
                0.20m * trayThree +
                0.50m * trayFour +
                1.00m * trayFive;
            decimal changeToGive = givenAmount - drinkPrice;
            decimal difference = Math.Abs(moneyInTrays - changeToGive);

            if (changeToGive <= moneyInTrays)
            {
                Console.WriteLine("Yes {0:F2}", difference);
            }
            else
            {
                Console.WriteLine("No {0:F2}", difference);
            }
        }
    }
}