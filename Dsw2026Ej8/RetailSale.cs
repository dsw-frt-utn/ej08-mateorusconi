namespace Dsw2026Ej8;
public class RetailSale : Sale
{
    public override decimal CalculateTotal()
    {
        return Amount; 
    }
}