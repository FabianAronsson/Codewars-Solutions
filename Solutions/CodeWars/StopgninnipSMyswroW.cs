namespace CodeWars;

//https://www.codewars.com/kata/5264d2b162488dc400000001
public class StopgninnipSMyswroW
{
    public static string Solution(string sentence)
    {
        var temp = sentence.Split(' ');
        var sum = "";
        foreach (var t in temp)
        {
            var temp2 = "";
            for (int j = t.Length - 1; j >= 0; j--)
            {
                if (t.Length < 5)
                {
                    temp2 += t;
                    break;
                }
                temp2 += t[j];
            }
            sum += sum.Length > 0 ? " " + temp2 : temp2;
        }
        return sum;
    }
}