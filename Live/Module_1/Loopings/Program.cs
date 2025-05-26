namespace Loopings;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        for (x = 0; x < 10; x = x + 2 )
        {
            Console.WriteLine(x);
            if (x == 6)
            {
                //break;
                continue:
            }
        }

        while (x < 20)
        {
            Console.WriteLine(x++);
        }

        do
        {
            Console.WriteLine(x++);
        }
        while (x < 50);
    }
}
