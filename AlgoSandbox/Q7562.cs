namespace AlgoSandbox
{
    public static class Q7562
    {
        public static Dictionary<(int, int), int> visited = new();
        public static readonly int[] dx = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        public static readonly int[] dy = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        public static int l;

        public static void Run()
        {
            var n = int.Parse(Console.ReadLine());
            var answers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                l = int.Parse(Console.ReadLine());

                var start = Console.ReadLine();
                var end = Console.ReadLine();

                var a = int.Parse(start.Split(' ')[0]);
                var b = int.Parse(start.Split(' ')[1]);

                var c = int.Parse(end.Split(' ')[0]);
                var d = int.Parse(end.Split(' ')[1]);

                visited = new();
                visited.Add((a, b), 1);
                answers.Add(bfs(a, b, c, d));
            }

            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }

        static int bfs(int a, int b, int c, int d)
        {
            var queue = new Queue<(int, int)>();
            queue.Enqueue((a, b));

            while (queue.Count > 0)
            {
                var x = queue.Dequeue();
                var curX = x.Item1;
                var curY = x.Item2;

                if (curX == c && curY == d)
                {
                    return visited[(curX, curY)] - 1;
                }

                foreach (var i in Enumerable.Range(0, 8))
                {
                    var nx = curX + dx[i];
                    var ny = curY + dy[i];
                    if (nx < 0 || nx >= l || ny < 0 || ny >= l)
                    {
                        continue;
                    }
                    if (!visited.ContainsKey((nx, ny)))
                    {
                        visited.Add((nx, ny), visited[(curX, curY)] + 1);
                        queue.Enqueue((nx, ny));
                    }
                }
            }
            return 0;
        }
    }
}
