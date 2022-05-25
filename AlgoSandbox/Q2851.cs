using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSandbox
{
    public static class Q2851
    {
        public static void Run()
        {
            var list = new int[10];

            for (int i = 0; i < 10; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }

            int result = 0;

            foreach (var i in list)
            {
                result += i;

                if (result >= 100)
                {
                    if (result - 100 > 100 - (result - i))
                    {
                        result -= i;
                    }
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
