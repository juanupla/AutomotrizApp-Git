using CorPartAutomotriz.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CorPartAutomotriz.Datos.intefaz
{
    public interface IFacturaAccDto
    {
        List<Cliente> ListarClientes();

        int proximaFactu();

        List<FormasPago> obtenerFormasPagos();

        List<FormasEnvio> obtenerFormasEnvios();

        List<TiposProductos> obtenerTiposProductos();

        List<TiposClientes> obtenerTiposClientes(); //--------------------------------------------

        List<Producto> obtenerProductosAutopartes();

        List<Producto> obtenerProductosVehiculos();

        List<Provincia> obtenerProvincia(); //ultimo o nuevo, para lo de agos.

        List<Localidad> obtenerLocalidad(int id_Provincia); //ultimo o nuevo, para lo de agos.

        List<Barrio> obtenerBarrios(int id_localidad); //ultimo o nuevo, para lo de agos.

        List<TiposDocumento> obtenerTipoDocumentos(); //ultimo o nuevo, para lo de agos.

        bool insertarFacturaDetalles(Factura factura); //inserta factura y detalles

        bool insertarFacturaOrdenes(Factura factura); //inserta factura y ordenes

        bool insertarFacturaDetallesOrdenes(Factura factura); //insertar factura, ordenes y detalles

        //DataTable obtenerProductosAutopartesSinEstado(); //Formulario configuracion y estado de producto -- desechado

        //DataTable obtenerProductosVehiculosSinEstado(); //Formulario configuracion y estado de producto -- desechado

        List<Usuario> obtenerUsuarios();

        List<Localidad> obtenerLocalidadSinId();

        List<Barrio> obtenerBarrioSinId();

        bool InsertarCliente(Cliente cliente);

        bool actualizarCliente(Cliente c);

        List<Cliente> ListarClientesSinFacturas();
        bool eliminarCliente(int id);
    }
}
