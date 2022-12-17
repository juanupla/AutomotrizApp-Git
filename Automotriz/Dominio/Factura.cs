using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorPartAutomotriz.Dominio
{
    public class Factura 
    { 


        private int idFactura;
        private Cliente cliente;    
        private FormasPago formasPago;
        private FormasEnvio formasEnvio;
        private Decimal interes;
        private Decimal descuento;
        private DateTime fecha;
        private List<DetalleFactura> detalles;
        private List<DetalleOrdenPedido> ordenes;


    public Factura()
    {
        idFactura = 0;
        cliente = null;
        formasPago = null;
        formasEnvio = null;
        interes = 0;
        descuento = 0;
        fecha = DateTime.Now;
        detalles = new List<DetalleFactura>();
        ordenes = new List<DetalleOrdenPedido>();
    }

    public int IdFactura
    {
        get { return idFactura; }
        set { idFactura = value; }
    }

    public Cliente Cliente
    {
        get { return cliente; }
        set { cliente = value; }
    }

    public FormasPago FormasPago
    {
        get { return formasPago; }
        set { formasPago = value; }
    }

    public FormasEnvio FormasEnvio
    {
        get { return formasEnvio; }
        set { formasEnvio = value; }
    }

    public decimal Interes
    {
        get { return interes; }
        set { interes = value; }
    }

    public Decimal Descuento
    {
        get { return descuento; }
        set { descuento = value; }
    }
    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    public List<DetalleFactura> Detalles
    {
        get { return detalles; }
        set { detalles = value; }
    }

    public List<DetalleOrdenPedido> Ordenes
    {
        get { return ordenes; }
        set { ordenes = value; }
    }

    public void ModificarListaDetalles(int currentRow, int cantidadASumar)
    {
        Detalles[currentRow].Cantidad += cantidadASumar;
    }

    public void ModificarListaDetallesOrdenes(int currentRow, int cantidadASumar)
    {
        Ordenes[currentRow].Cantidad += cantidadASumar;
    }

    public void AgregarListaDetalle(DetalleFactura detalle)
    {
        Detalles.Add(detalle);
    }

    public void AgregarListaDetalleOrden(DetalleOrdenPedido detalle)
    {
        Ordenes.Add(detalle);
    }

    public void EliminarDetalle(int posicion)
    {
        Detalles.RemoveAt(posicion);
    }

    public void EliminarDetalleOrden(int posicion)
    {
        Ordenes.RemoveAt(posicion);
    }

    public void LimpiarDetalle()
    {
        Detalles.Clear();
    }

    public void LimpiarDetalleOrden()
    {
        Ordenes.Clear();
    }
    public override string ToString()
    {
        return "Nro Factura: " + IdFactura + " | Cliente: " + cliente.Apellido + ", " + cliente.Nombre + " |Fecha: " + Fecha.ToString();
    }

}
}
