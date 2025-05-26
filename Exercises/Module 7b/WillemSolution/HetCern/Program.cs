namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        var wk = new WillemKlein();
        var svm = new SimonVanDeMeer();

        //wk.Bereken(svm.Add, 4, 5);
        //wk.Bereken(svm.Subtract, 6, 7);

        MathDel m1 = svm.Add;
        m1 += svm.Add;
        m1 += svm.Subtract;
        m1 += svm.Add;
        m1 += svm.Add;

        foreach(var del in m1.GetInvocationList())
        {
            Console.WriteLine(del.Method.Name);
        }

        Console.WriteLine(m1(1,2));

       // m1.Invoke(1,2)
    }
}