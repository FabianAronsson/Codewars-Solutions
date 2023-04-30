namespace CodeWars;

//https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
public static class RangeExtraction
{
    public static string Solution(int[] args)
    {
        var temp = "";
        for (int i = 0; i < args.Length; i++)
        {
            if (args.Length == 1)
            {
                return args[0].ToString();
            }
            temp += args[i].ToString();
            int index = i + 1;
            int inc = 1;
            if (index == args.Length)
            {
                break;
            }
            while (true)
            {
                if (args[index] - inc != args[i])
                {
                    if (inc >= 3)
                    {
                        temp += "-" + args[index - 1] + ",";
                    }
                    else
                    {
                        temp += ",";
                        if (inc == 2)
                        {
                            index--;
                        }

                    }
                    break;
                }


                index++;
                inc++;
                if (index == args.Length)
                {
                    if (inc >= 3)
                    {
                        temp += "-" + args[index - 1];
                    }
                    else
                    {
                        temp += "," + args[index - 1];
                    }

                    break;
                }
            }

            i = index - 1;
        }
        return temp;
    }
}