namespace CodeWars;

//https://www.codewars.com/kata/52742f58faf5485cae000b9a
//Should be refactored with the Datetime library
public static class Humanreadabledurationformat
{
    public static string Solution(int seconds)
    {
        int year = 31536000;
        int day = 86400;
        int hour = 3600;
        int minute = 60;
        int counter = 0;
        int[] arr = new int[5];
        if (seconds == 0)
            return "now";

        if (seconds >= year)
        {
            counter = CalculateTime(seconds, year);
            arr[0] = counter;
            seconds = UpdateSeconds(seconds, year, counter);
            counter = 0;

        }
        if (seconds >= day)
        {
            counter = CalculateTime(seconds, day);
            arr[1] = counter;
            seconds = UpdateSeconds(seconds, day, counter);
            counter = 0;
        }
        if (seconds >= hour)
        {
            counter = CalculateTime(seconds, hour);
            arr[2] = counter;
            seconds = UpdateSeconds(seconds, hour, counter);
            counter = 0;
        }
        if (seconds >= minute)
        {
            counter = CalculateTime(seconds, minute);
            arr[3] = counter;
            seconds = UpdateSeconds(seconds, minute, counter);
            counter = 0;
        }
        if (seconds != 0)
        {
            arr[4] = seconds;
        }

        return FormatString(FormatResult(arr).TrimEnd().Split(','));
    }

    public enum Types
    {
        year,
        day,
        hour,
        minute,
        second
    }

    public static string FormatString(string[] str)
    {
        string res = string.Empty;
        if (str.Length == 2)
            return str[0];
        for (int i = 0; i < str.Length; i++)
        {
            if (i == str.Length - 3 && str.Length > 1)
            {
                res += str[^3] + " and " + str[^2];
                break;
            }
            else
            {
                res += str[i] + ", ";
            }
        }
        return res;
    }

    public static string FormatResult(int[] arr)
    {
        string res = string.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                res += arr[i] switch
                {
                    > 1 => arr[i] + " " + (Types)i + "s,",
                    _ => arr[i] + " " + (Types)i + ",",
                };
            }
        }
        return res;
    }

    public static int UpdateSeconds(int seconds, int setTime, int counter)
    {
        return seconds - setTime * counter;
    }


    public static int CalculateTime(int seconds, int setTime)
    {
        int counter = 0;
        while (true)
        {
            counter++;
            if (seconds - setTime >= setTime)
            {
                seconds -= setTime;
            }
            else
            {
                return counter;
            }

        }
    }
}