using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Collections;

[StructLayout(LayoutKind.Explicit)]
struct Data
{
    [FieldOffset(0)]
    int F1;
    [FieldOffset(4)]    
    int F2;
}

internal class Program
{
    static void Main(string[] args)
    {
        BitVector32 bv = new BitVector32();
        bv[4] 

        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array[0] = 1;

        for( int i = 0 i < array.Length;i++)
        {
            int tmp = array[i];
            Console.WriteLine(tmp);
        }

        foreach(int tmp in array)
        {
            Console.WriteLine(tmp);
        }

        int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] array3;
        array3 = [1, 2, 3, 4];

        int[,] matrix = new int[2, 3] { {1, 2, 3 }, { 4,5,6} };

        matrix[0, 1] = 23;

        int[][] jagged = new int[3][];
        jagged[0] = [2, 3, 4, 5];
        jagged[1] = [1, 2, 3, 4, 5, 6, 7];

        foreach(int[] xx in  jagged)
        {

        }

        Console.WriteLine(jagged[0][2]);


        List<int> list = new List<int>();
        list.Add(1);

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("een", 1);
        Console.WriteLine(dictionary["een"]);

        Stopwatch sw = new Stopwatch();
        string x = "";
        StringBuilder sx = new StringBuilder();
        sw.Start(); 
        for (int i = 0;i < 100_000; i++)
        {
            //x += i.ToString();
            sx.Append(i.ToString());
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed);

        Console.ReadLine(); 
    }
}
