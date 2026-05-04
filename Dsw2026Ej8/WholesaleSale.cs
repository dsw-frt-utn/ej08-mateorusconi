namespace Dsw2026Ej8;
public class Wholesale : Sale
{
    public override decimal CalculateTotal()
    {
        return Amount * 0.9m; 
    }
}