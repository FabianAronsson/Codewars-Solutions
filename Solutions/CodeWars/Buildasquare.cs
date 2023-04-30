namespace CodeWars;

//https://www.codewars.com/kata/59a96d71dbe3b06c0200009c
public static class Buildasquare
{
    public static string Solution(int n)
    {
        string res = "";
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                res += '+';
            }
            if (i != n - 1)
                res += '\n';
        }
        return res;
    }
}