namespace CodeWars;

//https://www.codewars.com/kata/52223df9e8f98c7aa7000062
public static class ROT13
{
    public static string Solution(string input)
    {
        List<char> alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray().ToList();
        string res = "";
        for (int i = 0; i < input.Length; i++)
        {
            var index = 0;
            if (char.IsLetter(input[i]))
            {
                index = alphabet.IndexOf(char.ToLower(input[i])) + 13 > 26 ?
                    alphabet.IndexOf(char.ToLower(input[i])) + 13 - 26 :
                    alphabet.IndexOf(char.ToLower(input[i])) + 13;
                if (index == 26)
                {
                    index = 0;
                }
                res += char.IsUpper(input[i]) ? alphabet[index].ToString().ToUpper() : alphabet[index];
            }
            else
            {
                res += input[i];
            }
        }

        return res;
    }
}