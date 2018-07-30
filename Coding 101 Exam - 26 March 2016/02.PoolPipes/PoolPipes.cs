using System;

    class PoolPipes
    {
        public static void Main()
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double firstPipe = p1 * h;
            double secondPipe = p2 * h;
            double total = firstPipe + secondPipe;

            if (total <= v)
            {
                double fullPercent = Math.Truncate(total / v * 100);
                double firstPipePercent = Math.Truncate(firstPipe / total * 100);
                double secondPipePercent = Math.Truncate(secondPipe / total * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", fullPercent, firstPipePercent, secondPipePercent);

            }
            else
            {
                double overflows = total - v;

                Console.WriteLine($"For {h} hours the pool overflows with {overflows:F1} liters.");
            }
        }
    }
