using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class TiposClientes
    {
        private int idTipoCliente;
        private string nombre;

        public TiposClientes()
        {
            idTipoCliente = 0;
            nombre = String.Empty;
        }

        public int IdTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
