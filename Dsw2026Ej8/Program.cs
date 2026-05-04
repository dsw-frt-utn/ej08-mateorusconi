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

            var p3 = new Problema3();
            Console.WriteLine(p3.CompararCopias(5, new Product("Original")));


            // ---------------------------------------------------

            var p4 = new Problema4();
            // Caso 1: Mezcla de nulos y válidos
            Console.WriteLine(p4.CalcularPromedio(8, null, 10)); // (8+10)/2 = 9

            // Caso 2: Todos nulos
            Console.WriteLine(p4.CalcularPromedio(null, null, null)); // 0

            // Caso 3: Valores fuera de rango (ignorados)
            Console.WriteLine(p4.CalcularPromedio(5, 20, -2)); // 5/1 = 5

            // Caso 4: Promedio con decimales
            Console.WriteLine(p4.CalcularPromedio(7, 8, null)); // 7.5

            var p5 = new Problema5();

            RetailSale r = new RetailSale();
            r.Amount = 1000m;

            Wholesale w = new Wholesale();
            w.Amount = 1000m;

            // polimorfismo: Sale como tipo base
            Sale venta1 = r;
            Sale venta2 = w;

            Console.WriteLine(p5.ObtenerImporteFinal(venta1)); // → 1000
            Console.WriteLine(p5.ObtenerImporteFinal(venta2));// → 900


        }
    }
}
