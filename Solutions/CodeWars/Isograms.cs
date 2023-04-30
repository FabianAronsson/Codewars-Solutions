namespace CodeWars;

//https://www.codewars.com/kata/54ba84be607a92aa900000f1
public static class Isograms
{
    public static bool Solution(string str)
    {
        string s = string.Empty;
        foreach (var item in str.ToLower().ToCharArray())
        {
            if (s.IndexOf(item) != -1)
            {
                return false;
            }
            else
            {
                s += item;
            }
        }
        return true;
    }
}