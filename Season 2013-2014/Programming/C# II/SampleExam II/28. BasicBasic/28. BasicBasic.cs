using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

class BasicBasic
{
    static Dictionary<int, string> dic = new Dictionary<int, string>();
    static Dictionary<string, long> variables = new Dictionary<string, long>()
    {
        { "X", 0 },
        { "V", 0 },
        { "W", 0 },
        { "Z", 0 },
        { "Y", 0 }
    };
    static StringBuilder output = new StringBuilder();
    static int lineNumber;
    static int i;

    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        lineNumber = int.Parse(line.Split()[0]);

        while (!line.StartsWith("RUN"))
        {
            dic.Add(int.Parse(line.Split()[0]), line.Substring(line.IndexOf(' ')).Trim());
            line = Console.ReadLine();
        }

        while (true)
        {
            for (i = 0; i < dic.Count; i++)
            {
                var currentCommand = dic[dic.ElementAt(i).Key];

                ExecuteCommand(currentCommand);
            }

            break;
        }

        output.Length--;
        Console.WriteLine(output.ToString());
    }

    private static void ExecuteCommand(string commandContent)
    {
        if (commandContent.Trim().StartsWith("IF"))
        {
            int indexOfIF = commandContent.IndexOf("IF") + 2;
            int indexOfTHEN = commandContent.IndexOf("THEN");

            string condition = commandContent.Substring(indexOfIF, indexOfTHEN - indexOfIF).Trim();

            if (CheckForValidCondition(condition))
            {
                string thenCommand = commandContent.Substring(indexOfTHEN + 4);

                ExecuteCommand(thenCommand.Trim());
            }
        }
        else if (commandContent.Trim().StartsWith("PRINT"))
        {
            string currentVariable = commandContent.Split(new string[] { "PRINT" },
                StringSplitOptions.RemoveEmptyEntries)[0].Trim();

            output.AppendLine(variables[currentVariable].ToString());
        }
        else if (commandContent.Trim().StartsWith("CLS"))
        {
            output.Clear();
        }
        else if (commandContent.Trim().StartsWith("GOTO"))
        {
            int nextLineNumber = int.Parse(commandContent.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)[1]);

            lineNumber = nextLineNumber;

            i = dic.ToList().IndexOf(dic.First(x => x.Key == lineNumber)) - 1;
        }
        else if (commandContent.Trim().StartsWith("STOP"))
        {
            output.Length--;
            Console.WriteLine(output.ToString());
            using (StreamWriter writer = new StreamWriter("../../output.txt"))
            {
                writer.WriteLine(output.ToString());
            }
            Environment.Exit(0);
        }
        else
        {
            string currentVariable = commandContent[0].ToString();
            string[] rawNumbers = commandContent.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            string rightPart = rawNumbers[1].Trim();

            if (rightPart.Substring(1).Contains("-"))
            {
                variables[currentVariable] = CalculateTheNewValue(rightPart, "-");
            }
            else if (rightPart.Substring(1).Contains("+"))
            {
                variables[currentVariable] = CalculateTheNewValue(rightPart, "+");
            }
            else
            {
                if (char.IsLetter(rightPart[0]))
                {
                    variables[currentVariable] = variables[rightPart];
                }
                else
                {
                    variables[currentVariable] = long.Parse(rightPart);
                }
            }
        }
    }

    private static long CalculateTheNewValue(string rightPart, string currentOperator)
    {
        long calculatedNumber = 0;

        string leftNumber = rightPart.Substring(0, rightPart.LastIndexOf(currentOperator)).Trim();
        string rightNumber = rightPart.Substring(rightPart.LastIndexOf(currentOperator) + 1).Trim();

        if (char.IsLetter(leftNumber[0]))
        {
            leftNumber = variables[leftNumber].ToString();
        }

        if (char.IsLetter(rightNumber[0]))
        {
            rightNumber = variables[rightNumber].ToString();
        }

        if (currentOperator == "-")
        {
            calculatedNumber = long.Parse(leftNumber) - long.Parse(rightNumber);
        }
        else
        {
            calculatedNumber = long.Parse(leftNumber) + long.Parse(rightNumber);
        }

        return calculatedNumber;
    }

    private static bool CheckForValidCondition(string condition)
    {
        // X = Y  + 1
        bool areEqual = false;

        if (condition.Contains(">"))
        {
            areEqual = CheckForEqualConditions(condition, ">");
        }
        else if (condition.Contains("<"))
        {
            areEqual = CheckForEqualConditions(condition, "<");
        }
        else if (condition.Contains("="))
        {
            areEqual = CheckForEqualConditions(condition, "=");
        }

        return areEqual;
    }

    private static bool CheckForEqualConditions(string condition, string currentOperator)
    {
        string[] rawParts = condition.Split(new char[] { char.Parse(currentOperator) },
            StringSplitOptions.RemoveEmptyEntries);

        bool areEqual = false;

        string leftPart = rawParts[0].Trim();
        string rightPart = rawParts[1].Trim();

        long leftNumber = variables[leftPart];
        long rightNumber = 0;

        if (rightPart.Substring(1).Contains("-"))
        {
            rightNumber = CalculateTheNewValue(rightPart, "-");
        }
        else if (rightPart.Substring(1).Contains("+"))
        {
            rightNumber = CalculateTheNewValue(rightPart, "+");
        }
        else if (char.IsLetter(rightPart[0]))
        {
            rightNumber = variables[rightPart];
        }
        else
        {
            rightNumber = long.Parse(rightPart);
        }

        switch (currentOperator)
        {
            case "=": if (leftNumber == rightNumber) areEqual = true; break;
            case ">": if (leftNumber > rightNumber) areEqual = true; break;
            case "<": if (leftNumber < rightNumber) areEqual = true; break;

            default:
                throw new ArgumentException("Invalid operator");
        }

        return areEqual;
    }
}