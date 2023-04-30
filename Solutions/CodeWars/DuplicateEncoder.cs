namespace CodeWars;
//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
public static class DuplicateEncoder
{
    public static string Solution(string word)
    {
        bool isFinished = false;
        bool foundDuplicate = false;
        char[] arr = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (arr.All(x => !x.Equals('\0')))
                {
                    isFinished = true;
                    break;
                }
                if (i != j)
                {
                    if (word.ToLower()[i].Equals(word.ToLower()[j]))
                    {
                        arr[i] = ')';
                        arr[j] = ')';
                        foundDuplicate = true;
                    }
                }
            }
            if (isFinished)
            {
                break;
            }
            if (!foundDuplicate)
            {
                arr[i] = '(';
                foundDuplicate = false;
            }
            else
            {
                foundDuplicate = false;
            }
        }
        return word = new string(arr);
    }
}