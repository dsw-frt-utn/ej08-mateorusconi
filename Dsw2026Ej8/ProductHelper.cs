using System.ComponentModel;
using Microsoft.VisualBasic;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private long _code;
        private string _description = "";
        private decimal _price;

        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            _code = code;
            _description = description;
            _price = price;
            return $"[{_code}] {_description} - {FormatearPrecio(price)}";
        }
    }
}
