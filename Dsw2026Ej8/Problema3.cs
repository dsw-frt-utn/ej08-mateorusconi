namespace Dsw2026Ej8;
public class Problema3
{  
    public string CompararCopias(int originalValue, Product product)
    {
        int copia = originalValue;
        copia++;
        Product productcopia= product;
        productcopia.CambiarDescripcion("descripcion nueva modificada");

        return $"{originalValue} - {copia} - {product.GetDescription()}";
    }

}