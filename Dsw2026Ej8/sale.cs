namespace Dsw2026Ej8;
public class Sale
{
    public decimal Amount;

    public virtual decimal CalculateTotal()
    {
        return Amount;
    }
}