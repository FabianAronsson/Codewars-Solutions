using System.Text.RegularExpressions;

namespace CodeWars;

//https://www.codewars.com/kata/55f8a9c06c018a0d6e000132
public static class RegexValidatePINcode
{
    public static bool Solution(string pin)
    {
        if (Regex.IsMatch(pin, @"[\D+]") != true && (pin.Length == 6 || pin.Length == 4))
        {
            return true;
        }
        return false;
    }
}