namespace CodeWars;

//https://www.codewars.com/kata/54b724efac3d5402db00065e
class DecodetheMorsecode
{
    private static readonly Dictionary<string, string> MorseCode = new ();
    public static string Solution(string morseCode)
    {
        string[] arr = morseCode.Split(" ");
        string res = "";

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != arr.Length - 1 && arr[i].Equals("") && arr[i + 1].Equals(""))
            {
                res += " ";
                i++;
            }
            else
            {
                //Won't compile, since codewars have a preloaded dictionary
                //Uncomment when testing
                //res += MorseCode.Get(arr[i]); 
            }
        }

        return res.Trim();
    }
}