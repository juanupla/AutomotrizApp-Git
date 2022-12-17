using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private TiposDocumento tiposDocumento;
        private int numeroDocumento;
        private int telefono;
        private string email;
        private TiposClientes tipoCliente;
        private Barrio barrio;

        public Cliente()
        {
            idCliente = 0;
            nombre = String.Empty;
            apellido = String.Empty;
            tiposDocumento = null;
            numeroDocumento = 0;
            telefono = 0;
            email = String.Empty;
            tipoCliente = null;
            barrio = null;

        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public TiposDocumento TiposDocumento
        {
            get { return tiposDocumento; }
            set { tiposDocumento = value; }
        }

        public int NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public TiposClientes TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public override string ToString()
        {
            return Nombre + ", " + Apellido + " | Documento: " + NumeroDocumento; //+ " | Provincia: " + Barrio.Localidad.Provincia;
        }
    }
}
