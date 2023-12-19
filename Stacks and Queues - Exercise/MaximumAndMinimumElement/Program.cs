namespace MaximumAndMinimumElement;

internal class Program
{
    static void Main()
    {
        Stack<int> seq = new Stack<int>();
        int queries = int.Parse(Console.ReadLine());
        for (int i = 0; i < queries; i++)
        {
            int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            switch (cmd[0])
            {
                case 1:
                    seq.Push(cmd[1]);
                    break;
                case 2:
                    if (seq.Count > 0)
                        seq.Pop();
                    break;
                case 3:
                    if (seq.Count > 0)
                        Console.WriteLine(seq.Max());
                    break;
                case 4:
                    if (seq.Count > 0)
                        Console.WriteLine(seq.Min());
                    break;
            }
        }
        Console.WriteLine(String.Join(", ", seq.ToArray()));
    }
}