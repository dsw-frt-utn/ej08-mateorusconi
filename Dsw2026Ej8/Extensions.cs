namespace Dsw2026Ej8;

public static class Extensions
{ 
    public static string ToProductCode(this string? code)
    {
        if (code == null)
        {
            return "SIN-CODIGO";
        }
            
        string sinEspacios = code.Trim();
        string enMayusculas = sinEspacios.ToUpper();
        string conGuiones = enMayusculas.Replace(" ", "-");
        return conGuiones;
        
    }
}