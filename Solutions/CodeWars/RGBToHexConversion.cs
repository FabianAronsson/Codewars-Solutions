namespace CodeWars;
//https://www.codewars.com/kata/513e08acc600c94f01000001
//TODO: Refactor
public static class RGBToHexConversion
{
    public static string Solution(int r, int g, int b)
    {
        var red = FormatResult(ConvertToHex(CreateValidNumbers(r)));
        var green = FormatResult(ConvertToHex(CreateValidNumbers(g)));
        var blue = FormatResult(ConvertToHex(CreateValidNumbers(b)));

        return red + green + blue;
    }

    public static string ConvertToHex(int n)
    {
        if (n / 16 == 0)
        {
            return "" + n % 16;
        }

        return n % 16 + " " + ConvertToHex(n / 16);
    }

    public static int CreateValidNumbers(int n)
    {
        return n switch
        {
            > 255 => 255,
            < 0 => 0,
            _ => n,
        };
    }

    public static string FormatResult(string str)
    {
        string[] arr = str.Split(' ');
        str = string.Empty;
        for (var i = arr.Length - 1; i >= 0; i--)
        {
            if (arr.Length == 1)
            {
                if (int.Parse(arr[i]) >= 10)
                {
                    return "0" + GetHexValue(int.Parse(arr[i]));
                }

                return "0" + arr[i];
            }

            if (int.Parse(arr[i]) >= 10)
            {
                str += GetHexValue(int.Parse(arr[i]));
            }
            else
            {
                str += arr[i];
            }

        }

        return str;
    }

    public static string GetHexValue(int a)
    {
        foreach (HexNumbers hex in Enum.GetValues(typeof(HexNumbers)))
        {
            if (a == (int)hex)
            {
                return Enum.GetName(hex);
            }
        }

        return "";
    }

    public enum HexNumbers
    {
        A = 10,
        B = 11,
        C = 12,
        D = 13,
        E = 14,
        F = 15,
    }
}