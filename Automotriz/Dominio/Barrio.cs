using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Barrio
    {
        private int idBarrio;
        private string nombre;
        private Localidad localidad;

        public Barrio()
        {
            idBarrio = 0;
            nombre = "";
            localidad = null;
        }

        public int IdBarrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
