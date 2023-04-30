namespace CodeWars;
//https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
public static class CalculateAverage
{
    public static double Solution(double[] array)
    {
        return (array.Length == 0 ? 0 : array.Sum() / array.Length);
    }
}