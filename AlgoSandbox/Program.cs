namespace AlgoSandbox
{
    public class Program
    {
        static void Main()
        {
            var cases = int.Parse(Console.ReadLine());

            foreach(var i in Enumerable.Range(0, cases))
            {
                Dictionary<char, int> counter = new();

                var line = Console.ReadLine().ToLower();

                foreach (char c in line)
                {
                    if (char.IsLetter(c))
                    {
                        if (counter.ContainsKey(c))
                        {
                            counter[c]++;
                        }
                        else
                        {
                            counter.Add(c, 1);
                        }
                    }
                }

                if (counter.Count == 26)
                {
                    var pangram = counter.Min(x => x.Value);

                    if (pangram == 1)
                    {
                        Console.WriteLine($"Case {i + 1}: Pangram!");
                    }
                    else if(pangram == 2)
                    {
                        Console.WriteLine($"Case {i + 1}: Double pangram!!");
                    }
                    else if (pangram == 3)
                    {
                        Console.WriteLine($"Case {i + 1}: Triple pangram!!!");
                    }
                }
                else
                {
                    Console.WriteLine($"Case {i + 1}: Not a pangram");
                }
            }
        }
    }
}