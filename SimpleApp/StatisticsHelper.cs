namespace SimpleApp
{
    class StatisticsHelper
    {
        public static bool IsAdult(int age)
        {
            return age >= 18;
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