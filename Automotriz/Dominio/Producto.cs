using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Producto
    {




        private int idProducto;
        private string nombre;
        private string descripcion;
        private int stock;
        private int stockMinimo;
        private decimal precio;
        private TiposProductos tipoProducto;
        private Marcas marca;
        private int estado;

        public Producto()
        {
            idProducto = 0;
            nombre = String.Empty;
            descripcion = String.Empty;
            stock = 0;
            stockMinimo = 0;
            precio = 0;
            tipoProducto = null;
            marca = null;
            estado = 0;
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int StockMinimo
        {
            get { return stockMinimo; }
            set { stockMinimo = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public TiposProductos TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }

        public Marcas Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " | Descripción: " + Descripcion + " | Precio: " + Precio;
        }
    }
}

