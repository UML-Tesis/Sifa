using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCompra
    {
        public static string Insertar(int Id_Empleado, int Id_Proveedor, DateTime Fecha, int CodFactura, decimal Iva, int correlativo, string Estado, DataTable dtDetalles)
        {
            DCompra Obj = new DCompra();
            Obj.Id_Empleado = Id_Empleado;
            Obj.Id_Proveedor = Id_Proveedor;
            Obj.Fecha_Hora = Fecha;
            Obj.Cod_Factura = CodFactura;
            Obj.Iva = Iva;
            Obj.Correlativo = correlativo;
            Obj.Estado = Estado;
            List<DDetalleCompra> detalles = new List<DDetalleCompra>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalleCompra detalle = new DDetalleCompra();
                detalle.Id_Producto = Convert.ToInt32(row["Id_Producto"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["Precio_Compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["Precio_Venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["Stock_Inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["Stock_Inicial"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public static DataTable Mostrar()
        {
            return new DCompra().Mostrar();
        }

        public static string Contar()
        {
            return new DCompra().Contar();
        }

        public static string ContarNuevos()
        {
            return new DCompra().ContarNuevos();
        }

        public static DataTable BuscarFechas(string TextoBuscar, string TextoBuscar2)
        {
            DCompra Obj = new DCompra();
            return Obj.BuscarFechas(TextoBuscar, TextoBuscar2);
        }

        public static DataTable MostrarDetalle(string TextoBuscar)
        {
            DCompra Obj = new DCompra();
            return Obj.MostrarDetalle(TextoBuscar);
        }

        public static string Anular(int Id_Compra)
        {
            DCompra Obj = new DCompra();
            Obj.Id_Compra = Id_Compra;
            return Obj.Anular(Obj);
        }
    }
}
