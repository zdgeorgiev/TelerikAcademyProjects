using System;
using System.Text;

class BasicLanguage
{
    static void Main(string[] args)
    {
        StringBuilder result = new StringBuilder();
        long forLoopCycles = 1;

        while (true)
        {
            string currentCommand = Console.ReadLine();

            string[] allSubCommands = currentCommand.Split(new char[] { '(', ')', ';', '\n', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < allSubCommands.Length; i++)
            {
                switch (allSubCommands[i].Trim())
                {
                    case "FOR":

                        if (forLoopCycles == 1)
                        {
                            forLoopCycles += GetForLoopCycles(allSubCommands[i + 1].Trim()) - 1;
                        }
                        else
                        {
                            forLoopCycles *= GetForLoopCycles(allSubCommands[i + 1].Trim());
                        }

                        break;
                    case "PRINT":

                        try
                        {
                            for (int times = 0; times < forLoopCycles; times++)
                            {
                                result.Append(allSubCommands[i + 1]);
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            //When argument after the print is empty
                            result.AppendLine(" ");
                        }

                        forLoopCycles = 1;
                        break;

                    case "EXIT":
                        Console.WriteLine(result.ToString());
                        return;

                    default:
                        continue;
                }
            }
        }
    }

    private static long GetForLoopCycles(string command)
    {
        long cycles = 0;

        if (command.Contains(","))
        {
            string[] numbers = command.Split(',');

            cycles = long.Parse(numbers[1].Trim()) - long.Parse(numbers[0].Trim()) + 1;
        }
        else
        {
            cycles = long.Parse(command.Trim());
        }

        return cycles;
    }
}