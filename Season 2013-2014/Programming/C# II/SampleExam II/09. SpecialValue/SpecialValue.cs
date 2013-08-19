using System;

class SpecialValue
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] array = ProccessInput(n);

        int bestSpecialValue = int.MinValue;

        for (int row = 0; row < 1; row++)
        {
            for (int col = 0; col < array[row].GetLength(0); col++)
            {
                //bool [][] visited = CreateBoolMatrix(n, array);

                int currentSpecialValue = CalculateThePath(array, row, col);//,visited);

                if (currentSpecialValue > bestSpecialValue)
                {
                    bestSpecialValue = currentSpecialValue;
                }
            }
        }

        Console.WriteLine(bestSpecialValue);
    }

    private static int CalculateThePath(int[][] array, int row, int col)//,bool[][] visited)
    {
        int currentNumber = array[row][col];
        int total = 0;
        int path = 1;

        while (true)
        {
            //if (visited[row][col])
            //{
            //    return 0;
            //}

            //visited[row][col] = true;

            if (currentNumber >= 0)
            {
                row++;

                if (row == array.GetLength(0))
                {
                    row = 0;
                }

                col = currentNumber;
                path++;

                currentNumber = array[row][col];
            }
            else
            {
                total += (currentNumber * -1) + path;

                return total;
            }
        }
    }

    private static int[][] ProccessInput(int n)
    {
        int[][] array = new int[n][];

        for (int i = 0; i < n; i++)
        {
            string[] currentLine =
                Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            array[i] = new int[currentLine.Length];

            for (int j = 0; j < currentLine.Length; j++)
            {
                array[i][j] = int.Parse(currentLine[j]);
            }
        }

        return array;
    }

    private static bool[][] CreateBoolMatrix(int n, int[][] array)
    {
        bool[][] visited = new bool[n][];
    
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array[i].GetLength(0); j++)
            {
                visited[i] = new bool[array[i].Length];
            }
        }
    
        return visited;
    }
}