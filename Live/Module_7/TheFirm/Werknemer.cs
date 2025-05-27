namespace TheFirm;

internal class Werknemer : Person, IContract
{
    public void Ploetert()
    {
        Werk();
    }

    public virtual void Werk()
    {

    }
}
