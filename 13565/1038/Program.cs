using System.Numerics;

class Program
{
    private static Dictionary<int,int> dicValue;
    private static int input;
    private static int counter;

    static void Main(string[] args)
    {
        input = int.Parse(Console.ReadLine());

        if (input <= 10)
        {
            Console.WriteLine(input);
            return;
        }

        counter = 10;
        dicValue = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 2 }
        };

        var result = Loop(dicValue);
        Console.WriteLine(result.Any() ? DicToString(result) : -1);
    }

    private static Dictionary<int, int> Loop(Dictionary<int,int> dic)
    {
        if(dic.ContainsKey(11))
        {
            return new Dictionary<int, int>();
        }
        var maxKey = dic.Keys.Max();
        var bDescending = true;

        for(int i = maxKey; i > 1; i--)
        {
            if(dic[i] <= dic[i - 1])
            {
                AddOneToDic(dic, i);
                AddZeroes(dic, i - 1);
                bDescending = false;
                break;
            }
        }

        if(bDescending)
        {
            Console.WriteLine(DicToString(dic));
            counter++;
            if (counter == input)
                return dic;

            AddOneToDic(dic, 1);          
        }
        return Loop(dic);
    }

    private static void AddOneToDic(Dictionary<int,int> dic,int pos)
    {
        if(dic[pos] == 9)
        {
            dic[pos] = 0;
            if(dic.ContainsKey(pos + 1))
            {
                AddOneToDic(dic, pos + 1);
            }
            else
            {
                dic.Add(pos + 1, 1);    
            }
        }
        else
        {
            dic[pos] = dic[pos] + 1;
        }
    }

    private static void AddZeroes(Dictionary<int, int> dic, int pos)
    {
        for(int i = pos; i >= 1; i--)
        {
            dic[i] = 0;
        }
    }

    private static string DicToString(Dictionary<int, int> dic)
    {
        var result = string.Empty;

        for (int i = dic.Keys.Max(); i >= 1; i--)
        {
            result += dic[i];
        }

        return result;
    }
}