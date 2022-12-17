using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class TiposDocumento
    {
        private int idTipoDoc;
        private string nombre;

        public TiposDocumento()
        {
            idTipoDoc = 0;
            nombre = "";

        }

        public int IdTipoDoc
        {
            get { return idTipoDoc; }
            set { idTipoDoc = value; }
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
