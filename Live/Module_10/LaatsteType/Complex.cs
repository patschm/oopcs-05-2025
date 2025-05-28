namespace LaatsteType;

internal class Complex
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public override string ToString()
    {
        return $"({Real} + {Imaginary}i)";
    }

}
