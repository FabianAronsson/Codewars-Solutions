namespace CodeWars;

//https://www.codewars.com/kata/55c45be3b2079eccff00010f
public static class YourOrderPlease
{
    public static string Solution(string words)
    {
        string[] a = words.Split();
        string[] n = new string[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                if (char.IsDigit(a[i][j]))
                {
                    n[(int)(char.GetNumericValue(a[i][j]) - 1)] = a[i];

                    break;
                }
            }
        }

        string nad = "";
        foreach (var item in n)
        {
            nad += item + " ";
        }
        return nad.Substring(0, nad.Length - 1);
    }
}