public void PrintStatistics(double[] data, int count)
{
    double max = double.MinValue;

    for (int i = 0; i < count; i++)
    {
        if (data[i] > max)
        {
            max = data[i];
        }
    }

    PrintMax(max);

    double mid = double.MaxValue;

    for (int i = 0; i < count; i++)
    {
        if (data[i] < max)
        {
            max = data[i];
        }
    }

    PrintMin(max);

    double totalSum = double.MinValue;

    for (int i = 0; i < count; i++)
    {
        totalSum += data[i];
    }

    double average = totalSum / count;

    PrintAvg(average);
}