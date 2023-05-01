using System.Numerics;

namespace CodeWars;

//https://www.codewars.com/kata/525f4206b73515bffb000b21
public static class AddingBigNumbers
{
    public static string Solution(string a, string b)
    {
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}