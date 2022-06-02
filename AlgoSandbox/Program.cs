internal class Program
{
    private static List<int> iList = new List<int>();
    private static int visitedPos = 0;
    private static int totalValue = 0;

    static void Main(string[] args)
    {
        var i = Console.ReadLine();
        var m = Console.ReadLine().Split(' ');

        foreach (var x in m)
        {
            iList.Add(int.Parse(x));
        }

        totalValue = iList.Sum();

        Calc(0);

        Console.WriteLine(totalValue);
    }

    private static void Calc(int pos)
    {
        if (pos == iList.Count - 1)
        {
            if (iList[pos] > 0)
                totalValue += iList[pos];
            return;
        }


        if (iList[pos] > 0 && (iList[pos + 1] >= 0 || (pos > 0 && iList[pos - 1] >= 0)))
        {
            totalValue += iList[pos];
        }

        if (pos > 0
            && iList[pos] > 0
            && iList[pos + 1] < 0 && iList[pos - 1] < 0
            && iList[pos] + iList[pos + 1] > 0)
        {
            totalValue += iList[pos];
            totalValue += iList[pos + 1];
        }


        Calc(pos + 1);
    }
}