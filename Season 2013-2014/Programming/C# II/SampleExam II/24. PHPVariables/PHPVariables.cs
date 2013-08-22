using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class PHPVariables
{
    static void Main(string[] args)
    {
        List<string> php = ProcessInputAndRemoveWithspaces();
        var uniqueVariables = FindAllVariables(php);

        Console.WriteLine(uniqueVariables.ToList().Count);

        foreach (var variable in uniqueVariables)
        {
            var fixedVariable = variable.TrimStart('$');
            Console.WriteLine(fixedVariable);
        }
    }

    private static List<string> ProcessInputAndRemoveWithspaces()
    {
        List<string> php = new List<string>();

        while (true)
        {
            string[] currentLine =
                Console.ReadLine().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < currentLine.Length; i++)
            {
                php.Add(currentLine[i]);

                if (currentLine[i] == "?>")
                {
                    return php;
                }
            }
        }
    }

    private static IOrderedEnumerable<string> FindAllVariables(List<string> php)
    {
        List<string> fixedPhp = new List<string>();

        for (int j = 0; j < php.Count; j++)
        {
            string currentLine = php[j];

            if (currentLine.Trim().StartsWith("/") ||
                currentLine.Trim().StartsWith("#"))
            {
                continue;
            }

            StringBuilder currentLineFixed = new StringBuilder();

            for (int k = 0; k < currentLine.Length; k++)
            {
                if (currentLine[k] == '\\' || currentLine[k] == '/')
                {
                    break;
                }
                else
                {
                    currentLineFixed.Append(currentLine[k]);
                }
            }

            fixedPhp.Add(currentLineFixed.ToString());
        }

        List<string> variables = new List<string>();

        for (int i = 0; i < fixedPhp.Count; i++)
        {
            string currentLine = fixedPhp[i];

            string regex = @"\B[$]\W*\w+";

            MatchCollection matches = Regex.Matches(currentLine, regex);

            foreach (Match match in matches)
            {
                variables.Add(match.Value);
            }
        }

        var uniqueVariables = variables.Distinct().OrderBy(item => item.ToString(), StringComparer.Ordinal);

        return uniqueVariables;
    }
}