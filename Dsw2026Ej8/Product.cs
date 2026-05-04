namespace Dsw2026Ej8;
public class Product
{
    private string _description;
    
    public Product(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void CambiarDescripcion(string nuevaDescripcion)
    {
        _description = nuevaDescripcion;
    }

}