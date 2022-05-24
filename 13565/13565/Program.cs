class Program
{

    private static bool[,] array;
    private static int m;
    private static int n;
    private static bool result;

    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        m = int.Parse(input[0]);
        n = int.Parse(input[1]);

        array = new bool[m, n];
        for (int i = 0; i < m; i++)
        {
            var lineInput = Console.ReadLine();

            for (int j = 0; j < n; j++)
            {
                array[i, j] = lineInput[j] == '0';
            }
        }

        var taskList = new List<Task>();
        result = false;

        for(int k = 0; k < n; k++)
        {
            if(array[0,k])
            {
                Search(0, k);   
            }
        }

        Console.WriteLine(result ? "YES" : "NO");
    }

    static void Search(int i, int j)
    {
        if (result) return;

        if(i == m - 1)
        {
            result = true;
            return;
        }

        if (i > 1 && array[i - 1, j])
        {
            array[i - 1, j] = false;
            Search(i - 1, j);
        }

        if(array[i + 1, j])
        {
            array[i + 1, j] = false;
            Search(i + 1, j);
        }

        if(j != 0 && array[i, j - 1])
        {
            array[i, j - 1] = false;
            Search(i, j - 1);
        }

        if(j < n - 1  && array[i, j + 1])
        {
            array[i, j + 1] = false;
            Search(i, j + 1);
        }
    }
}