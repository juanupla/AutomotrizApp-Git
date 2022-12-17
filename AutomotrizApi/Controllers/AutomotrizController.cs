using CorPartAutomotriz.Datos.intefaz;
using CorPartAutomotriz.Datos.implementacion;
using Microsoft.AspNetCore.Mvc;
using CorPartAutomotriz.Dominio;

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomotrizController : ControllerBase
    {
        private IFacturaAccDto app;
       
        public AutomotrizController()
        {
            app = new FacturaAccDto();
        }
        [HttpGet("proxima")]
        public IActionResult Details()
        {
            return Ok(app.proximaFactu());
        }

        [HttpGet("listaCliente")]
        public IActionResult get()
        {
            return Ok(app.ListarClientes());
        }

        [HttpGet("listaClienteSinFactura")]
        public IActionResult getlistaClienteSinFactura()
        {
            return Ok(app.ListarClientesSinFacturas());
        }

        [HttpGet("formasPagos")]
        public IActionResult gett()
        {
            List<FormasPago> lst = null;
            try
            {
                lst = app.obtenerFormasPagos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("loginUsuarios")]
        public IActionResult getUsuarios()
        {
            return Ok(app.obtenerUsuarios());
        }

        [HttpGet("TiposProductos")]
        public IActionResult getTipoProductos()
        {
            List<TiposProductos> lst = null;
            try
            {
                lst = app.obtenerTiposProductos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("TiposClientes")]
        public IActionResult getTipoClientes()
        {
            List<TiposClientes> lst = null;
            try
            {
                lst = app.obtenerTiposClientes();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("FormasEnvio")]
        public IActionResult getFormasEnvio()
        {
            List<FormasEnvio> lst = null;
            try
            {
                lst = app.obtenerFormasEnvios();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("ObtenerAutoparte")]
        public IActionResult getAutoPartes()
        {
            List<Producto> lst = null;
            try
            {
                lst = app.obtenerProductosAutopartes();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("ObtenerVehiculo")]
        public IActionResult getVehiculos()
        {
            List<Producto> lst = null;
            try
            {
                lst = app.obtenerProductosVehiculos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("ObtenerProvincias")]
        public IActionResult getProvincias()
        {
            List<Provincia> lst = null;
            try
            {
                lst = app.obtenerProvincia();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("ObtenerLocalidad")]
        public IActionResult getLocalidad()
        {
            List<Localidad> lst = null;
            try
            {
                lst = app.obtenerLocalidadSinId();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("ObtenerBarrio")]
        public IActionResult getBarrio()
        {
            List<Barrio> lst = null;
            try
            {
                lst = app.obtenerBarrioSinId();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("ObtenerTiposDoc")]
        public IActionResult getTiposDoc()
        {
            List<TiposDocumento> lst = null;
            try
            {
                lst = app.obtenerTipoDocumentos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }



        [HttpPost("GuardarOrdenes")]
        public IActionResult PostGuardarOrdenes(Factura f)
        {
            try
            {
                if (f == null)
                {
                    return BadRequest("Datos de presupuesto incorrectos!");
                }

                return Ok(app.insertarFacturaOrdenes(f));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("GuardarDetalles")]
        public IActionResult PostGuardarDetalles(Factura f)
        {
            try
            {
                if (f == null)
                {
                    return BadRequest("Datos de presupuesto incorrectos!");
                }

                return Ok(app.insertarFacturaDetalles(f));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("GuardarDetallesOrdenes")]
        public IActionResult PostGuardarDetallesOrdenes(Factura f)
        {
            try
            {
                if (f == null)
                {
                    return BadRequest("Datos de presupuesto incorrectos!");
                }

                return Ok(app.insertarFacturaDetallesOrdenes(f));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("NuevoCliente")]
        public IActionResult PostGuardarNuevoCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Datos del cliente incorrectos!");
                }

                return Ok(app.InsertarCliente(cliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("ActualizarCliente")]
        public IActionResult PutCliente(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    return Ok(app.actualizarCliente(cliente));
                }
                else
                {
                    return StatusCode(500, "Error interno! Intente luego");
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("EliminarCliente/{id}")]
        public IActionResult DeleteCliente(int id)
        {
            if (id != 0)
            {
                bool result = app.eliminarCliente(id);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar un cliente válido");
            }
        }
    }
}
