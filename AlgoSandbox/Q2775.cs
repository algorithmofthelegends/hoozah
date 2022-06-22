using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSandbox
{
    public class Q2775
    {
        public static void Run()
        {
            var t = int.Parse(Console.ReadLine());
            var q = new (int, int)[t];

            for (int i = 0; i < t; i++)
            {
                var k = int.Parse(Console.ReadLine());
                var n = int.Parse(Console.ReadLine());

                q[i] = (k, n);
            }

            var maxY = q.Max(x => x.Item1);
            var maxX = q.Max(x => x.Item2);

            var values = new Dictionary<(int, int), int>();

            for (int i = 1; i <= maxX; i++)
            {
                values.Add((0, i), i);
            }

            for (int y = 1; y <= maxY; y++)
            {
                for (int x = 1; x <= maxX; x++)
                {
                    if (x == 1)
                    {
                        values.Add((y, 1), 1);
                    }
                    else
                    {
                        var side = values[((y, x - 1))];
                        var bot = values[((y - 1, x))];
                        values.Add((y, x), side + bot);
                    }
                }
            }

            foreach (var question in q)
            {
                Console.WriteLine(values[(question.Item1, question.Item2)]);
            }
        }
    }
}
