namespace SimpleApp
{
    class StatisticsHelper
    {
        public static bool IsAdult(int age)
        {
            return age >= 18;
        }

        public static int CalculateMin(int[] values)
{
    return 0;
}

        public static int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
        return 0;

    int max = values[0];

    foreach (var v in values)
    {
        if (v > max)
            max = v;
    }

    return max;
}
    

    public static double CalculateAverage(int[] values)
{
    if (values == null || values.Length == 0)
        return 0;

    double sum = 0;
    foreach (var v in values)
        sum += v;

    return sum / values.Length;
        }
    }
}