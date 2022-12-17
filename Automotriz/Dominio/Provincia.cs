using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Provincia
    {
        private int idProvincia;
        private string nombre;


        public Provincia()
        {
            idProvincia = 0;
            nombre = "";
        }

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
