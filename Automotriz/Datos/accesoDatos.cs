using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CorPartAutomotriz.Dominio;

namespace CorPartAutomotriz.Datos
{
    class accesoDatos
    {
        private static accesoDatos instancia;
        private string cadena;
        private SqlConnection cnn;

        public accesoDatos()
        {
            cadena = @"Data Source=localhost;Initial Catalog=tp_laboratorio_automotriz;Integrated Security=True";
            cnn = new SqlConnection(cadena);
        }

        public static accesoDatos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new accesoDatos();
            }
            return instancia;
        }

        public DataTable Consulta(string sql)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;

        }


        public DataTable ConsultaParametro(string sql, object parametro)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@año", parametro);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;

        }

        public int facturaNro(string sql)
        {
            try
            {
                int nro;
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                cnn.Close();
                nro = Convert.ToInt32(param.Value);
                return nro;
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
        //ultimo o nuevo, para lo de agos.
        public DataTable ConsultarLocalidades(string sql, int id_provincia)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_provincia", id_provincia);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        //ultimo o nuevo, para lo de agos.
        public DataTable ConsultarBarrios(string sql, int id_provincia)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_localidad", id_provincia);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public bool InsertarFacturaConDetalles(string sqlFactura, string sqlDetalleFactura, Factura factura)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sqlFactura, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(factura.Cliente.IdCliente));
                cmd.Parameters.AddWithValue("@id_formaPago", factura.FormasPago.IdFormaPago);
                cmd.Parameters.AddWithValue("@id_formaEnvio", factura.FormasEnvio.IdFormaEnvio);
                cmd.Parameters.AddWithValue("@interes", factura.Interes);
                cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);

                SqlParameter param = new SqlParameter("@id_factura", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                int id_factura = Convert.ToInt32(param.Value);

                SqlCommand cmd2; //= new SqlCommand(sqlDetalleFactura, cnn, t);
                //cmd2.CommandType = CommandType.StoredProcedure;
                foreach (DetalleFactura detalle in factura.Detalles)
                {
                    cmd2 = new SqlCommand(sqlDetalleFactura, cnn, t);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@id_factura", id_factura);
                    cmd2.Parameters.AddWithValue("@id_producto", detalle.Producto.IdProducto);
                    cmd2.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd2.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);
                    cmd2.ExecuteNonQuery();
                    //Aca habria que hacer un cmd3 que envie la cantidad, usando otro sp, para actualizar el stock que se va consimiento. LAP UTA MADRE
                }

                t.Commit();
                aux = true;
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();

                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return aux;
        }

        public bool InsertarFacturaConOrdenes(string sqlFactura, string sqlDetalleOrden, Factura factura)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sqlFactura, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", factura.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@id_formaPago", factura.FormasPago.IdFormaPago);
                cmd.Parameters.AddWithValue("@id_formaEnvio", factura.FormasEnvio.IdFormaEnvio);
                cmd.Parameters.AddWithValue("@interes", factura.Interes);
                cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);

                SqlParameter param = new SqlParameter("@id_factura", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                int id_factura = Convert.ToInt32(param.Value);

                SqlCommand cmd2; //= new SqlCommand(sqlDetalleOrden, cnn, t);

                foreach (DetalleOrdenPedido orden in factura.Ordenes)
                {
                    cmd2 = new SqlCommand(sqlDetalleOrden, cnn, t);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@id_producto", orden.Producto.IdProducto);
                    cmd2.Parameters.AddWithValue("@id_factura", id_factura);
                    cmd2.Parameters.AddWithValue("@cantidad", orden.Cantidad);
                    cmd2.Parameters.AddWithValue("@precio", orden.PrecioUnitario);
                    cmd2.Parameters.AddWithValue("@fechaDeEntrega", orden.FechaEntrega);
                    cmd2.ExecuteNonQuery();
                }

                t.Commit();
                aux = true;
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                }

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return aux;
        }

        public bool InsertarFacturaConDetallesYOrdenes(string sqlFactura, string sqlDetalleOrden, string sqlDetalleFactura, Factura factura)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sqlFactura, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", factura.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@id_formaPago", factura.FormasPago.IdFormaPago);
                cmd.Parameters.AddWithValue("@id_formaEnvio", factura.FormasEnvio.IdFormaEnvio);
                cmd.Parameters.AddWithValue("@interes", factura.Interes);
                cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);

                SqlParameter param = new SqlParameter("@id_factura", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                int id_factura = Convert.ToInt32(param.Value);

                SqlCommand cmd2;// = new SqlCommand(sqlDetalleOrden, cnn, t);
                //cmd2.CommandType = CommandType.StoredProcedure;
                foreach (DetalleOrdenPedido orden in factura.Ordenes)
                {
                    cmd2 = new SqlCommand(sqlDetalleOrden, cnn, t);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@id_producto", orden.Producto.IdProducto);
                    cmd2.Parameters.AddWithValue("@id_factura", id_factura);
                    cmd2.Parameters.AddWithValue("@cantidad", orden.Cantidad);
                    cmd2.Parameters.AddWithValue("@precio", orden.PrecioUnitario);
                    cmd2.Parameters.AddWithValue("@fechaDeEntrega", orden.FechaEntrega);
                    cmd2.ExecuteNonQuery();
                    //Aca habria que hacer un cmd3 que envie la cantidad, usando otro sp, para actualizar el stock que se va consimiento.
                }

                SqlCommand cmd3;// = new SqlCommand(sqlDetalleFactura, cnn, t);
                //cmd3.CommandType = CommandType.StoredProcedure;
                foreach (DetalleFactura detalle in factura.Detalles)
                {
                    cmd3 = new SqlCommand(sqlDetalleFactura, cnn, t);
                    cmd3.CommandType = CommandType.StoredProcedure;

                    cmd3.Parameters.AddWithValue("@id_factura", id_factura);
                    cmd3.Parameters.AddWithValue("@id_producto", detalle.Producto.IdProducto);
                    cmd3.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd3.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);
                    cmd3.ExecuteNonQuery();
                    //Aca habria que hacer un cmd3 que envie la cantidad, usando otro sp, para actualizar el stock que se va consimiento.
                }
                t.Commit();
                aux = true;
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return aux;
        }



        public bool InsertarCliente(Cliente c, string sqlInsertarCliente)
        {
            bool aux = false;

            try
            {
                cnn.Open();
                
                SqlCommand cmd = new SqlCommand(sqlInsertarCliente, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Convert.ToString(c.Nombre));
                cmd.Parameters.AddWithValue("@apellido", Convert.ToString(c.Apellido));
                cmd.Parameters.AddWithValue("@idTipoDoc", Convert.ToInt32(c.TiposDocumento.IdTipoDoc));
                cmd.Parameters.AddWithValue("@numDoc", Convert.ToInt32(c.NumeroDocumento));
                cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(c.Telefono));
                cmd.Parameters.AddWithValue("@email", Convert.ToString(c.Email));
                cmd.Parameters.AddWithValue("@idTipoCliente", Convert.ToInt32(c.TipoCliente.IdTipoCliente));
                cmd.Parameters.AddWithValue("@idBarrio", Convert.ToInt32(c.Barrio.IdBarrio));

                cmd.ExecuteNonQuery();
                cnn.Close();
                aux = true;

            }
            catch
            {
                aux = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return aux;
        }

        public bool actualizarCliente(Cliente c, string sql)
        {
            bool aux = false;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(c.IdCliente));
                cmd.Parameters.AddWithValue("@nombre", Convert.ToString(c.Nombre));
                cmd.Parameters.AddWithValue("@apellido", Convert.ToString(c.Apellido));
                cmd.Parameters.AddWithValue("@idTipoDoc", Convert.ToInt32(c.TiposDocumento.IdTipoDoc));
                cmd.Parameters.AddWithValue("@numeroDoc", Convert.ToInt32(c.NumeroDocumento));
                cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(c.Telefono));
                cmd.Parameters.AddWithValue("@email", Convert.ToString(c.Email));
                cmd.Parameters.AddWithValue("@idTipoCliente", Convert.ToInt32(c.TipoCliente.IdTipoCliente));
                cmd.Parameters.AddWithValue("@idBarrio", Convert.ToInt32(c.Barrio.IdBarrio));

                cmd.ExecuteNonQuery();
                cnn.Close();
                aux = true;
            }
            catch
            {
                aux = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return aux;
        }


        public bool eliminarCliente(int id, string sql)
        {
            bool aux = false;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente",Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cnn.Close();
                aux = true;
            }
            catch
            {
                aux= false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return aux;
        }
    }
}
