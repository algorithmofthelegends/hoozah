using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSandbox
{
    internal static class Q15649
    {
        static void Run()
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            var l = new List<int>();

            for (int i = 1; i <= n; i++) l.Add(i);

            foreach (var r in GetCombinations(l, m))
            {
                Console.WriteLine(string.Join(" ", r));
            }
        }

        static IEnumerable<IEnumerable<int>> GetCombinations(IEnumerable<int> list, int length)
        {
            if (length == 1)
                return list.Select(t => new int[] { t });
            return GetCombinations(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new int[] { t2 }));
        }
    }
}
