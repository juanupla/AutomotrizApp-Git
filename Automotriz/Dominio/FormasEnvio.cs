using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class FormasEnvio
    {
        private int idFromaEnvio;
        private string nombre;

        public FormasEnvio()
        {
            idFromaEnvio = 0;
            nombre = String.Empty;
        }

        public int IdFormaEnvio
        {
            get { return idFromaEnvio; }
            set { idFromaEnvio = value; }
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
