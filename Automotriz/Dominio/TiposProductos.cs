using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class TiposProductos
    {
        private int idTipoProducto;
        private string tipoProducto;

        public TiposProductos()
        {
            idTipoProducto = 0;
            tipoProducto = String.Empty;
        }

        public int IdTipoProducto
        {
            get { return idTipoProducto; }
            set { idTipoProducto = value; }
        }

        public string TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }

        public override string ToString()
        {
            return TipoProducto;
        }
    }
}
