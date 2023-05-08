namespace CodeWars;

//https://www.codewars.com/kata/551f37452ff852b7bd000139
public static class BinaryAddition
{
    public static string Solution(int a, int b)
    {
        var sum = a + b;
        var result = string.Empty;
        while (sum > 0)
        {
            result = sum % 2 + result;
            sum /= 2;
        }
        return result;
    }
}