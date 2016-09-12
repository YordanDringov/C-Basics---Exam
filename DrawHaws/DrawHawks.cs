using System;

class DrawHawks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 5 * n;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', 3 * n),
                new string('-', i),
                new string('-', width - 2 - 3 * n - i));
        }
        for (int i = 0; i < n / 2; i++)
        {

            Console.WriteLine("{0}*{1}*{2}",
                new string('*', 3 * n),
                new string('-', n - 1),
                new string('-', n - 1));
        }

        for (int i = 0; i < n / 2; i++)
        {
            if (i == n / 2 - 1)
            {
                Console.WriteLine("{0}*{1}*{2}",
                new string('-', 3 * n - i),
                new string('*', width - 2 - (3 * n - i) - (n - 1 - i)),
                new string('-', n - 1 - i)); break;
            }
            Console.WriteLine("{0}*{1}*{2}",
            new string('-', 3 * n - i),
            new string('-', width - 2 - (3 * n - i) - (n - 1 - i)),
            new string('-', n - 1 - i));

        }


    }
}
