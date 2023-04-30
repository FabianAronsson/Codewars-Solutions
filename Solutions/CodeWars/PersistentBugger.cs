namespace CodeWars;

//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
public class PersistentBugger
{
    public static int Solution(long n)
    {
        long res = n;
        int counter = 0;
        while (true)
        {
            if (res < 10)
            {
                break;
            }

            string temp = res.ToString();

            res = 1;

            foreach (var item in temp)
            {
                res *= (int)char.GetNumericValue(item);
            }

            counter++;
        }
        return counter;
    }
}