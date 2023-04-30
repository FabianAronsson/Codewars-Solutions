namespace CodeWars;
//https://www.codewars.com/kata/545cedaa9943f7fe7b000048
public static class DetectPanagram
{
    public static bool Solution(string str)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        for (int i = 0; i < alpha.Length; i++)
        {
            if (Array.IndexOf(str.ToUpper().ToCharArray(), alpha[i]) == -1)
            {
                return false;
            }
        }
        return true;
    }
}