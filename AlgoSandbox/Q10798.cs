using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSandbox
{
    internal class Q10798
    {
        static int skipCounter = 0;

        public static void Run()
        {

            var lone = Console.ReadLine().ToCharArray();
            var ltwo = Console.ReadLine().ToCharArray();
            var lthree = Console.ReadLine().ToCharArray();
            var lfour = Console.ReadLine().ToCharArray();
            var lfive = Console.ReadLine().ToCharArray();

            for (int i = 0; i < 15; i++)
            {
                skipCounter = 0;

                printLine(lone, i);
                printLine(ltwo, i);
                printLine(lthree, i);
                printLine(lfour, i);
                printLine(lfive, i);

                if (skipCounter == 5) break;
            }
        }

        static void printLine(char[] cArray, int i)
        {
            if (i < cArray.Length) Console.Write(cArray[i]);
            else skipCounter++;
        }
    }
}
