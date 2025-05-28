namespace HetCern;

class Program
{
    static void Main(string[] args)
    {
        SimonvdMeer simon = new SimonvdMeer();
        WillemKlein willem = new WillemKlein();

        willem.Calculate(simon.Add, 4, 5);
        willem.Calculate(simon.Subtract, 8, 10);


        MathDel md = simon.Add;
        md += simon.Add;
        md += simon.Subtract;
        md -= simon.Add;
        md += simon.Subtract;

        foreach (MathDel del in md.GetInvocationList())
        {
            System.Console.WriteLine(del.Method.Name);
        }
        
        int result = md(1, 2);

        System.Console.WriteLine(result);
    }
}
