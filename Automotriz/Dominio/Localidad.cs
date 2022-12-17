using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Localidad
    {
        private int idLocalidad;
        private string nombre;
        private Provincia provincia;

        public Localidad()
        {
            idLocalidad = 0;
            nombre = "";
            provincia = null;
        }

        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
