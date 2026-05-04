namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pruebas
            
            // Problema 1
            var helper = new ProductHelper();
            var resultado = helper.ObtenerEtiquetaProducto(123, "Yerba Mate", 1500.50m);
            Console.WriteLine(resultado);
            // ---------------------------------------------------

            // Problema  2
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(500, "Teclado Mecánico", 2, 1500.50m)); 
            // Caso cantidad igual a cero
            Console.WriteLine(p2.CrearResumenVenta(501, "Mouse", 0, 800m));

            // ---------------------------------------------------

        }
    }
}
