namespace Dsw2026Ej8;
public class Problema4
{  
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        int suma = 0;
        int cantidad = 0;

        if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
        {
            suma += nota1.Value;
            cantidad++;
        }

        if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
        {
            suma += nota2.Value;
            cantidad++;
        }

        if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
        {
            suma += nota3.Value;
            cantidad++;
        }

        if (cantidad == 0)
            return 0;

        return (double)suma / cantidad;
    }
}