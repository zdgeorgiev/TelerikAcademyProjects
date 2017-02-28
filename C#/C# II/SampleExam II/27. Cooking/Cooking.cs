using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Cooking
{
    private static Dictionary<string, string> notFixed = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    private static Dictionary<string, string> used = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    private static Dictionary<string, string> fixedReceipe = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    private static Dictionary<string, string> usedFixed = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    private static Dictionary<string, string> calculatedList = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    static void Main(string[] args)
    {
        ProcessInput();
        
        ConvertAllOfTheProducts(notFixed, fixedReceipe);
        ConvertAllOfTheProducts(used, usedFixed);

        CalculateTheDifferents(fixedReceipe, usedFixed);

        PrintTheLeftProductsInRightUnits(calculatedList);
    }

    private static void PrintTheLeftProductsInRightUnits(Dictionary<string, string> calculatedList)
    {
        foreach (var item in calculatedList)
        {
            string name = item.Key;
            string units = item.Value.Substring(0, item.Value.LastIndexOf(' ') + 1).Trim();
            decimal amount = ConvertToUnit(units, decimal.Parse(item.Value.Substring(item.Value.LastIndexOf(' ') + 1)));

            Console.WriteLine("{0:F2}:{1}:{2}", amount, units, name);
        }
    }

    private static void CalculateTheDifferents(Dictionary<string, string> fixedReceipe, Dictionary<string, string> usedFixed)
    {
        foreach (var currentElement in fixedReceipe)
        {
            string[] allValues = currentElement.Value.Split();

            if (usedFixed.ContainsKey(currentElement.Key) &&
                decimal.Parse(usedFixed[currentElement.Key].Split().LastOrDefault()) <
                decimal.Parse(allValues[allValues.Length - 1]))
            {
                decimal value = decimal.Parse(allValues[allValues.Length - 1])
                    - decimal.Parse(usedFixed[currentElement.Key].Split().LastOrDefault());

                calculatedList.Add(currentElement.Key,
                    currentElement.Value.Substring(0, currentElement.Value.LastIndexOf(' ') + 1) + " " + value.ToString());
            }
            else if (usedFixed.ContainsKey(currentElement.Key) &&
                    decimal.Parse(usedFixed[currentElement.Key].Split().LastOrDefault()) >=
                    decimal.Parse(allValues[allValues.Length - 1]))
            {
                continue;
            }
            else
            {
                calculatedList.Add(currentElement.Key, currentElement.Value);
            }
        }
    }

    private static void ConvertAllOfTheProducts(Dictionary<string, string> notFixed, Dictionary<string, string> fixedReceipe)
    {
        foreach (var val in notFixed)
        {
            string content = val.Value;
            string pattern = @"(\d*[.]?\w+)[:](\w+)";

            MatchCollection matches = Regex.Matches(content, pattern);

            string mainUnit = string.Empty;
            decimal amount = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                string currentUnit = matches[i].Groups[0].ToString();

                if (i == 0)
                {
                    mainUnit = currentUnit.Split(':')[1];
                    fixedReceipe.Add(val.Key, mainUnit); 
                }

                amount += ConvertToMililiters(currentUnit.Split(':')[1], decimal.Parse(currentUnit.Split(':')[0]));
            }

            fixedReceipe[val.Key] += " " + amount.ToString();
        }
    }

    private static void ProcessInput()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string currentProduct = Console.ReadLine();

            string quantity = currentProduct.Substring(0, currentProduct.LastIndexOf(':'));
            string product = currentProduct.Substring(currentProduct.LastIndexOf(':') + 1);

            if (notFixed.ContainsKey(product))
            {
                notFixed[product] += " " + quantity;
                continue;
            }

            notFixed.Add(product, quantity);
        }

        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string currentProduct = Console.ReadLine();

            string quantity = currentProduct.Substring(0, currentProduct.LastIndexOf(':'));
            string product = currentProduct.Substring(currentProduct.LastIndexOf(':') + 1);

            if (used.ContainsKey(product))
            {
                used[product] += " " + quantity;
                continue;
            }

            used.Add(product, quantity);
        }
    }

    private static decimal ConvertToMililiters(string unit, decimal amount)
    {
        switch (unit)
        {
            case "mls": return amount;
            case "ls": return amount * 1000;
            case "tbsps": return amount * 15;
            case "fl": return amount * 30;
            case "tsps": return amount * 5;
            case "gals": return amount * 3840;
            case "pts": return amount * 480;
            case "qts": return amount * 960;
            case "cups": return amount * 240;

            case "milliliters": return amount;
            case "liters": return amount * 1000;
            case "tablespoons": return amount * 15;
            case "fluid": return amount * 30;
            case "teaspoons": return amount * 5;
            case "gallons": return amount * 3840;
            case "pints": return amount * 480;
            case "quarts": return amount * 960;

            default:
                throw new ArgumentException("Invalid unit");
        }
    }

    private static decimal ConvertToUnit(string unit, decimal amount)
    {
        switch (unit)
        {
            case "mls": return amount;
            case "ls": return amount / 1000;
            case "tbsps": return amount / 15;
            case "fl": return amount / 30;
            case "tsps": return amount / 5;
            case "gals": return amount / 3840;
            case "pts": return amount / 480;
            case "qts": return amount / 960;
            case "cups": return amount / 240;

            case "milliliters": return amount;
            case "liters": return amount / 1000;
            case "tablespoons": return amount / 15;
            case "fluid": return amount / 30;
            case "teaspoons": return amount / 5;
            case "gallons": return amount / 3840;
            case "pints": return amount / 480;
            case "quarts": return amount / 960;

            default:
                throw new ArgumentException("Invalid unit");
        }
    }
}