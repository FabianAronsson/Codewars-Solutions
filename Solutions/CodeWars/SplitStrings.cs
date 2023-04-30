namespace CodeWars;

//https://www.codewars.com/kata/515de9ae9dcfc28eb6000001
public static class SplitStrings
{
    public static string[] Solution(string str)
    {
        string s = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (i % 2 == 0 && i != 0)
            {
                s += " " + str[i];
            }
            else
            {
                s += str[i];
            }

        }
        if (s.Split(' ')[^1].Length % 2 != 0)
        {

            s += '_';
        }
        return s.Split(' ');
    }
}