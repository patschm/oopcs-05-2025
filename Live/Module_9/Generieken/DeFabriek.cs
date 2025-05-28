
namespace Generieken;

internal class DeFabriek<T> where T : new()
{
    public  T Bouw()
    {
        return new T();
    }
}
