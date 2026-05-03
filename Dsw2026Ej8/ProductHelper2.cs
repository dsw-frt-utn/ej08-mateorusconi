using System.ComponentModel;
using Microsoft.VisualBasic;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private String FormatearPrecio(decimal price)
        {
            return price.ToString("C2");
        }
    } 
}