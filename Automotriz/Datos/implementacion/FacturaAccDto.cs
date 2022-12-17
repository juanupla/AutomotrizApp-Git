using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorPartAutomotriz.Datos.intefaz;
using CorPartAutomotriz.Dominio;
using System.Data;

namespace CorPartAutomotriz.Datos.implementacion
{
    public class FacturaAccDto : IFacturaAccDto
    {
        public int proximaFactu()
        {
            int proximaFactu;
            proximaFactu = accesoDatos.ObtenerInstancia().facturaNro("SP_ultimaFactura");
            proximaFactu += 1;
            return proximaFactu;
        }

        public List<FormasPago> obtenerFormasPagos()
        {
            List<FormasPago> formapago = new List<FormasPago>();
            DataTable tabla = new DataTable();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_FormaPago");
            foreach (DataRow fila in tabla.Rows)
            {
                FormasPago fp = new FormasPago();
                fp.Nombre = fila["forma_pago"].ToString();
                fp.IdFormaPago = Convert.ToInt32(fila["id_forma_pago"].ToString());
                formapago.Add(fp);
            }
            return formapago;
        }

        public List<FormasEnvio> obtenerFormasEnvios()
        {
            DataTable tabla = new DataTable();
            List<FormasEnvio> formasEnvios = new List<FormasEnvio>();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_FormaEnvio");
            foreach (DataRow fila in tabla.Rows)
            {
                FormasEnvio fm = new FormasEnvio();
                fm.IdFormaEnvio = Convert.ToInt32(fila["id_forma_envio"].ToString());
                fm.Nombre = fila["forma_envio"].ToString();
                formasEnvios.Add(fm);
            }
            return formasEnvios;
        }

        public List<TiposProductos> obtenerTiposProductos()
        {
            DataTable tabla = new DataTable();
            List<TiposProductos> tiposProductos = new List<TiposProductos>();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_tipoProducto");
            foreach (DataRow fila in tabla.Rows)
            {
                TiposProductos tp = new TiposProductos();
                tp.IdTipoProducto = Convert.ToInt32(fila["id_tipo_producto"].ToString());
                tp.TipoProducto = fila["descripcion"].ToString();
                tiposProductos.Add(tp);
            }
            return tiposProductos;
        }


        public List<Producto> obtenerProductosAutopartes()
        {
            List<Producto> productos = new List<Producto>();
            DataTable tabla = new DataTable();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_prodcutosAutopartes");
            foreach (DataRow fila in tabla.Rows)
            {
                Marcas m = new Marcas();
                m.IdMarca = Convert.ToInt32(fila["id_marca"].ToString());
                TiposProductos tp = new TiposProductos();
                tp.IdTipoProducto = Convert.ToInt32(fila["id_tipo_producto"].ToString());
                Producto p = new Producto();
                p.IdProducto = Convert.ToInt32(fila["id_producto"].ToString());
                p.Nombre = fila["nombre"].ToString();
                p.Descripcion = fila["descripcion"].ToString();
                p.Stock = Convert.ToInt32(fila["stock"].ToString());
                p.StockMinimo = Convert.ToInt32(fila["stock_minimo"].ToString());
                p.Precio = Convert.ToDecimal(fila["precio"].ToString());

                p.TipoProducto = tp;
                p.Marca = m;
                productos.Add(p);
            }
            return productos;
        }

        public List<Producto> obtenerProductosVehiculos()
        {
            List<Producto> productos = new List<Producto>();
            DataTable tabla = new DataTable();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_prodcutosVehiculos");
            foreach (DataRow fila in tabla.Rows)
            {
                Marcas m = new Marcas();
                m.IdMarca = Convert.ToInt32(fila["id_marca"].ToString());

                TiposProductos tp = new TiposProductos();
                tp.IdTipoProducto = Convert.ToInt32(fila["id_tipo_producto"].ToString());

                Producto p = new Producto();
                p.IdProducto = Convert.ToInt32(fila["id_producto"].ToString());
                p.Nombre = fila["nombre"].ToString();
                p.Descripcion = fila["descripcion"].ToString();
                p.Stock = Convert.ToInt32(fila["stock"].ToString());
                p.StockMinimo = Convert.ToInt32(fila["stock_minimo"].ToString());
                p.Precio = Convert.ToDecimal(fila["precio"].ToString());

                p.TipoProducto = tp;
                p.Marca = m;
                productos.Add(p);
            }
            return productos;
        }

        public List<TiposClientes> obtenerTiposClientes()
        {
            DataTable tabla = new DataTable();
            List<TiposClientes> tiposClientes = new List<TiposClientes>();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_tipoCliente");
            foreach (DataRow fila in tabla.Rows)
            {
                TiposClientes tp = new TiposClientes();
                tp.IdTipoCliente = Convert.ToInt32(fila["id_tipo_cliente"].ToString());
                tp.Nombre = fila["descripcion"].ToString();
                tiposClientes.Add(tp);
            }
            return tiposClientes;
        }

        public List<Provincia> obtenerProvincia() //ultimo o nuevo, para lo de agos.
        {
            DataTable table = new DataTable();
            List<Provincia> provincia = new List<Provincia>();
            table = accesoDatos.ObtenerInstancia().Consulta("SP_comboProvincias");
            foreach (DataRow fila in table.Rows)
            {
                Provincia p = new Provincia();
                p.IdProvincia = Convert.ToInt32(fila["id_provincia"].ToString());
                p.Nombre = fila["descripcion"].ToString();
                provincia.Add(p);
            }
            return provincia;

        }

        public List<Localidad> obtenerLocalidad(int id_Provincia) //ultimo o nuevo, para lo de agos.
        {
            DataTable table = new DataTable();
            List<Localidad> localidad = new List<Localidad>();
            table = accesoDatos.ObtenerInstancia().ConsultarLocalidades("SP_comboLocalidades", id_Provincia);
            foreach (DataRow fila in table.Rows)
            {
                Localidad l = new Localidad();
                l.IdLocalidad = Convert.ToInt32(fila["id_localidad"].ToString());
                l.Nombre = fila["descripcion"].ToString();
                l.Provincia.IdProvincia = id_Provincia;
                localidad.Add(l);
            }
            return localidad;
        }

        public List<Localidad> obtenerLocalidadSinId() //ultimo o nuevo, para lo de agos.
        {
            DataTable table = new DataTable();
            List<Localidad> localidad = new List<Localidad>();
            table = accesoDatos.ObtenerInstancia().Consulta("Sp_localidad_sinID");
            foreach (DataRow fila in table.Rows)
            {
                Provincia p = new Provincia();
                p.IdProvincia = Convert.ToInt32(fila["id_provincia"].ToString());
                Localidad l = new Localidad();
                l.IdLocalidad = Convert.ToInt32(fila["id_localidad"].ToString());
                l.Nombre = fila["descripcion"].ToString();
                l.Provincia = p;

                localidad.Add(l);
            }
            return localidad;
        }


        public List<Barrio> obtenerBarrioSinId() //ultimo o nuevo, para lo de agos.
        {
            DataTable table = new DataTable();
            List<Barrio> barrio = new List<Barrio>();
            table = accesoDatos.ObtenerInstancia().Consulta("Sp_barrio_sinID");
            foreach (DataRow fila in table.Rows)
            {
                Localidad l = new Localidad();
                l.IdLocalidad = Convert.ToInt32(fila["id_localidad"].ToString());
                Barrio b = new Barrio();
                b.IdBarrio = Convert.ToInt32(fila["id_barrio"].ToString());
                b.Nombre = fila["descripcion"].ToString();
                b.Localidad = l;
                barrio.Add(b);
            }

            return barrio;
        }


        public List<Barrio> obtenerBarrios(int id_localidad) //ultimo o nuevo, para lo de agos.
        {
            DataTable table = new DataTable();
            List<Barrio> barrio = new List<Barrio>();
            table = accesoDatos.ObtenerInstancia().ConsultarBarrios("SP_comboBarrios", id_localidad);
            foreach (DataRow fila in table.Rows)
            {
                Barrio b = new Barrio();
                b.IdBarrio = Convert.ToInt32(fila["id_barrio"].ToString());
                b.Nombre = fila["descripcion"].ToString();
                b.Localidad.IdLocalidad = id_localidad;
                barrio.Add(b);
            }
            return barrio;
        }

        public List<TiposDocumento> obtenerTipoDocumentos() //ultimo o nuevo, para lo de agos.
        {
            DataTable tabla = new DataTable();
            List<TiposDocumento> tiposDoc = new List<TiposDocumento>();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_tipoDocumentos");
            foreach (DataRow fila in tabla.Rows)
            {
                TiposDocumento tp = new TiposDocumento();
                tp.IdTipoDoc = Convert.ToInt32(fila["id_tipo_doc"].ToString());
                tp.Nombre = fila["descripcion"].ToString();
                tiposDoc.Add(tp);
            }
            return tiposDoc;
        }

        public bool insertarFacturaDetalles(Factura factura) //inserta factura y detalles
        {
            bool aux;
            aux = accesoDatos.ObtenerInstancia().InsertarFacturaConDetalles("SP_Maestro", "SP_DetalleFactura", factura);
            return aux;
        }

        public bool insertarFacturaOrdenes(Factura factura) //inserta factura y ordenes
        {
            bool aux;
            aux = accesoDatos.ObtenerInstancia().InsertarFacturaConOrdenes("SP_Maestro", "SP_DetalleOrdenFactura", factura);
            return aux;
        }

        public bool insertarFacturaDetallesOrdenes(Factura factura) //insertar factura, ordenes y detalles
        {
            bool aux;
            aux = accesoDatos.ObtenerInstancia().InsertarFacturaConDetallesYOrdenes("SP_Maestro", "SP_DetalleOrdenFactura", "SP_DetalleFactura", factura);
            return aux;
        }

        public bool InsertarCliente(Cliente cliente)
        {
            bool aux;
            aux = accesoDatos.ObtenerInstancia().InsertarCliente(cliente, "SP_insertarCliente");
            return aux;
        }

        //public DataTable obtenerProductosAutopartesSinEstado() //Formulario configuracion y estado de producto
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = accesoDatos.ObtenerInstancia().Consulta("productosAutopartesSinEstado");
        //    return tabla;
        //}

        //public DataTable obtenerProductosVehiculosSinEstado() //Formulario configuracion y estado de producto
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = accesoDatos.ObtenerInstancia().Consulta("productosVehiculosSinEstado");
        //    return tabla;
        //}

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DataTable tabla = new DataTable();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_Usuarios");
            foreach (DataRow fila in tabla.Rows)
            {
                Usuario u = new Usuario();

                //u.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                u.NombreUsuario = fila["nombreUsuario"].ToString();
                u.Contraseña = Convert.ToInt32(fila["contraseña"].ToString());
                usuarios.Add(u);
            }

            return usuarios;
            //return tabla;
        }

        public List<Cliente> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable tabla = new DataTable();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_ListaClientes");
            foreach (DataRow fila in tabla.Rows)
            {


                Barrio b = new Barrio();
                b.IdBarrio = Convert.ToInt32(fila["id_barrio"].ToString());
                TiposDocumento td = new TiposDocumento();
                td.IdTipoDoc = Convert.ToInt32(fila["id_tipo_doc"].ToString());
                TiposClientes tipo = new TiposClientes();
                Cliente c = new Cliente();
                c.IdCliente = Convert.ToInt32(fila["id_cliente"].ToString());
                c.Nombre = fila["nombre"].ToString();
                c.Apellido = fila["apellido"].ToString();
                c.TiposDocumento = td;
                c.NumeroDocumento = Convert.ToInt32(fila["num_doc"].ToString());
                c.Telefono = Convert.ToInt32(fila["telefono"].ToString());
                c.Email = fila["email"].ToString();
                tipo.IdTipoCliente = Convert.ToInt32(fila["id_tipo_cliente"].ToString());
                c.TipoCliente = tipo;
                c.Barrio = b;
                clientes.Add(c);
            }
            return clientes;
        }

        public bool actualizarCliente(Cliente c)
        {
            bool aux;
            aux = accesoDatos.ObtenerInstancia().actualizarCliente(c, "SP_ActualizarCliente");
            return aux;
        }

        public List<Cliente> ListarClientesSinFacturas()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable tabla = new DataTable();
            tabla = accesoDatos.ObtenerInstancia().Consulta("SP_ListaClientesSinFactura");
            foreach (DataRow fila in tabla.Rows)
            {


                Barrio b = new Barrio();
                b.IdBarrio = Convert.ToInt32(fila["id_barrio"].ToString());
                TiposDocumento td = new TiposDocumento();
                td.IdTipoDoc = Convert.ToInt32(fila["id_tipo_doc"].ToString());
                TiposClientes tipo = new TiposClientes();
                Cliente c = new Cliente();
                c.IdCliente = Convert.ToInt32(fila["id_cliente"].ToString());
                c.Nombre = fila["nombre"].ToString();
                c.Apellido = fila["apellido"].ToString();
                c.TiposDocumento = td;
                c.NumeroDocumento = Convert.ToInt32(fila["num_doc"].ToString());
                c.Telefono = Convert.ToInt32(fila["telefono"].ToString());
                c.Email = fila["email"].ToString();
                tipo.IdTipoCliente = Convert.ToInt32(fila["id_tipo_cliente"].ToString());
                c.TipoCliente = tipo;
                c.Barrio = b;
                clientes.Add(c);
            }
            return clientes;
        }

        public bool eliminarCliente(int id)
        {
            bool aux;
            aux = accesoDatos.ObtenerInstancia().eliminarCliente(id, "SP_EliminarCliente");
            return aux;
        }
    }
}
