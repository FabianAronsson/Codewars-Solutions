namespace CodeWars;
//https://www.codewars.com/kata/5412509bd436bd33920011bc
public static class Maskify
{
    public static string Solution(string cc)
    {
        string s = "";
        for (int i = 0; i < cc.Length; i++)
        {
            if (i >= cc.Length - 4)
            {
                s += cc[i];
            }
            else
            {
                s += '#';
            }
        }
        return s;
    }
}