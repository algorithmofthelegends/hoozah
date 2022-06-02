using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSandbox
{
    public class Q25175
    {
        public static void Run()
        {

            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            var k = int.Parse(input[2]);

            k = k % n;
            var i = 3;

            while (i != k)
            {
                if (k > i)
                {
                    i++;
                    m++;
                }
                else if (k < i)
                {
                    i--;
                    m--;
                }
                if (m == 0)
                {
                    m = n;
                }
                if (m == n + 1)
                {
                    m = 1;
                }
            }

            Console.WriteLine(m);


            //var input = Console.ReadLine().Split(' ');
            //var n = int.Parse(input[0]);
            //var m = int.Parse(input[1]);
            //var k = int.Parse(input[2]);

            //var diff = 3 - m;
            //var result = Math.Abs((k - diff)) % n;

            //Console.WriteLine(result != 0 ? result : n);
        }
    }
}
