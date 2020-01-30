using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalleCompra
    {
        private int _Id_DetalleCompra;
        private int _Id_Compra;
        private int _Id_Producto;
        private decimal _Precio_Compra;
        private decimal _Precio_Venta;
        private int _Stock_Inicial;
        private int _Stock_Actual;
        SqlCommand SqlCmd = new SqlCommand();
        SqlConnection SqlCon = new SqlConnection();

        public int Id_DetalleCompra
        {
            get { return _Id_DetalleCompra; }
            set { _Id_DetalleCompra = value; }
        }

        public int Id_Compra
        {
            get { return _Id_Compra; }
            set { _Id_Compra = value; }
        }

        public int Id_Producto
        {
            get { return _Id_Producto; }
            set { _Id_Producto = value; }
        }

        public decimal Precio_Compra
        {
            get { return _Precio_Compra; }
            set { _Precio_Compra = value; }
        }

        public decimal Precio_Venta
        {
            get { return _Precio_Venta; }
            set { _Precio_Venta = value; }
        }

        public int Stock_Inicial
        {
            get { return _Stock_Inicial; }
            set { _Stock_Inicial = value; }
        }

        public int Stock_Actual
        {
            get { return _Stock_Actual; }
            set { _Stock_Actual = value; }
        }

        //Constructores
        public DDetalleCompra()
        {

        }

        public DDetalleCompra(int idDetalle_Compra, int Id_Compra, int Id_Producto, decimal Precio_Compra, decimal Precio_Venta, int Stock_Inicial, int Stock_Actual)
        {
            this.Id_DetalleCompra = idDetalle_Compra;
            this.Id_Compra = Id_Compra;
            this.Id_Producto = Id_Producto;
            this.Precio_Compra = Precio_Compra;
            this.Precio_Venta = Precio_Venta;
            this.Stock_Inicial = Stock_Inicial;
            this.Stock_Actual = Stock_Actual;
        }

        public string Insertar(DDetalleCompra Detalle_Compra, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spInsertarDetalle_Compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdDetalleCompra = new SqlParameter();
                parIdDetalleCompra.ParameterName = "@Id_DetalleCompra";
                parIdDetalleCompra.SqlDbType = SqlDbType.Int;
                parIdDetalleCompra.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parIdDetalleCompra);

                SqlParameter parId_Compra = new SqlParameter();
                parId_Compra.ParameterName = "@Id_Compra";
                parId_Compra.SqlDbType = SqlDbType.Int;
                parId_Compra.Value = Detalle_Compra.Id_Compra;
                SqlCmd.Parameters.Add(parId_Compra);

                SqlParameter parId_Producto= new SqlParameter();
                parId_Producto.ParameterName = "@Id_Producto";
                parId_Producto.SqlDbType = SqlDbType.Int;
                parId_Producto.Value = Detalle_Compra.Id_Producto;
                SqlCmd.Parameters.Add(parId_Producto);

                SqlParameter parPrecio_Compra = new SqlParameter();
                parPrecio_Compra.ParameterName = "@Precio_Compra";
                parPrecio_Compra.SqlDbType = SqlDbType.Money;
                parPrecio_Compra.Value = Detalle_Compra.Precio_Compra;
                SqlCmd.Parameters.Add(parPrecio_Compra);

                SqlParameter parPrecio_Venta = new SqlParameter();
                parPrecio_Venta.ParameterName = "@Precio_Venta";
                parPrecio_Venta.SqlDbType = SqlDbType.Money;
                parPrecio_Venta.Value = Detalle_Compra.Precio_Venta;
                SqlCmd.Parameters.Add(parPrecio_Venta);

                SqlParameter parStock_Inicial = new SqlParameter();
                parStock_Inicial.ParameterName = "@Stock_Inicial";
                parStock_Inicial.SqlDbType = SqlDbType.Int;
                parStock_Inicial.Value = Detalle_Compra.Stock_Inicial;
                SqlCmd.Parameters.Add(parStock_Inicial);

                SqlParameter parStock_Actual = new SqlParameter();
                parStock_Actual.ParameterName = "@Stock_Actual";
                parStock_Actual.SqlDbType = SqlDbType.Int;
                parStock_Actual.Value = Detalle_Compra.Stock_Actual;
                SqlCmd.Parameters.Add(parStock_Actual);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Error al Guardar";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            return Rpta;
        }
    }
}
