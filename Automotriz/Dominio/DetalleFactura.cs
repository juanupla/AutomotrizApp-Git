using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class DetalleFactura
    {
        private Producto producto;
        private int cantidad;
        private decimal precioUnitario;

        public DetalleFactura()
        {
            producto = null;
            cantidad = 0;
            precioUnitario = 0;
        }

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public override string ToString()
        {
            return "Producto: " + producto.Nombre + " | Cantidad" + Cantidad + " | Precio: " + PrecioUnitario;
        }
    }
}
