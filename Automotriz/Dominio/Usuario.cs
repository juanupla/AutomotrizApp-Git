using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Usuario
    {
        private int id;
        private string nombreUsuario;
        private int contraseña;

        public Usuario()
        {
            id = 0;
            nombreUsuario = String.Empty;
            contraseña = 0;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public int Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
    }
}
