using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCompra
    {
        private int _Id_Compra;
        private int _Id_Empleado;
        private int _Id_Proveedor;
        private DateTime _Fecha_Hora;
        private int _Cod_Factura;
        private int _Correlativo;
        private decimal _Iva;
        private string _Estado;
        
        SqlCommand SqlCmd = new SqlCommand();
        SqlConnection SqlCon = new SqlConnection();

        public int Id_Compra
        {
            get { return _Id_Compra; }
            set { _Id_Compra = value; }
        }

        public int Id_Empleado
        {
            get { return _Id_Empleado; }
            set { _Id_Empleado = value; }
        }

        public int Id_Proveedor
        {
            get { return _Id_Proveedor; }
            set { _Id_Proveedor = value; }
        }

        public DateTime Fecha_Hora
        {
            get { return _Fecha_Hora; }
            set { _Fecha_Hora = value; }
        }

              public int Cod_Factura
        {
            get { return _Cod_Factura; }
            set { _Cod_Factura = value; }
        }

        public int Correlativo
        {
            get { return _Correlativo; }
            set { _Correlativo = value; }
        }

        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public DCompra()
        {

        }

        public DCompra(int IdCompra, int IdEmpleado, int IdProveedor, DateTime Fecha, int CodFactura, int correlativo, decimal Iva, string Estado)
        {
            this.Id_Compra = IdCompra;
            this.Id_Empleado = IdEmpleado;
            this.Id_Proveedor = IdProveedor;
            this.Fecha_Hora = Fecha;
            this.Cod_Factura = CodFactura;
            this.Correlativo = correlativo;
            this.Iva = Iva;
            this.Estado = Estado;
        }

        public string Insertar(DCompra Compra, List<DDetalleCompra> Detalle)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spInsertarCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_Compra = new SqlParameter();
                parId_Compra.ParameterName = "@Id_Compra";
                parId_Compra.SqlDbType = SqlDbType.Int;
                parId_Compra.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parId_Compra);

                SqlParameter parId_Empleado = new SqlParameter();
                parId_Empleado.ParameterName = "@Id_Empleado";
                parId_Empleado.SqlDbType = SqlDbType.Int;
                parId_Empleado.Value = Compra.Id_Empleado;
                SqlCmd.Parameters.Add(parId_Empleado);

                SqlParameter parId_Proveedor = new SqlParameter();
                parId_Proveedor.ParameterName = "@Id_Proveedor";
                parId_Proveedor.SqlDbType = SqlDbType.Int;
                parId_Proveedor.Value = Compra.Id_Proveedor;
                SqlCmd.Parameters.Add(parId_Proveedor);

                SqlParameter parFecha = new SqlParameter();
                parFecha.ParameterName = "@Fecha";
                parFecha.SqlDbType = SqlDbType.Date;
                parFecha.Value = Compra.Fecha_Hora;
                SqlCmd.Parameters.Add(parFecha);

                SqlParameter parFactura = new SqlParameter();
                parFactura.ParameterName = "@CodFactura";
                parFactura.SqlDbType = SqlDbType.Int;
                parFactura.Value = Compra.Cod_Factura;
                SqlCmd.Parameters.Add(parFactura);

                SqlParameter pariva = new SqlParameter();
                pariva.ParameterName = "@Iva";
                pariva.SqlDbType = SqlDbType.Decimal;
                pariva.Precision = 4;
                pariva.Scale = 2;
                pariva.Value = Compra.Iva;
                SqlCmd.Parameters.Add(pariva);

                SqlParameter parCorrelativo = new SqlParameter();
                parCorrelativo.ParameterName = "@Correlativo";
                parCorrelativo.SqlDbType = SqlDbType.Int;
                parCorrelativo.Value = Compra.Correlativo;
                SqlCmd.Parameters.Add(parCorrelativo);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@Estado";
                parEstado.SqlDbType = SqlDbType.VarChar;
                parEstado.Size = 7;
                parEstado.Value = Compra.Estado;
                SqlCmd.Parameters.Add(parEstado);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se guardo";

                if(Rpta.Equals("Ok")) 
                {
                    //Obtenemos el codigo del ingreso generado
                    this.Id_Compra = Convert.ToInt32(SqlCmd.Parameters["@Id_Compra"].Value);
                    foreach (DDetalleCompra det in Detalle) 
                    {
                        det.Id_Compra = this.Id_Compra;
                        //Llamar al metodo Insertar de la clase DDetalleCompra
                        Rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if(!Rpta.Equals("Ok")) 
                        {
                            break;
                        }
                    }
                }
                if(Rpta.Equals("Ok"))    
                {
                    SqlTra.Commit();
                }
                else 
                {
                    SqlTra.Rollback();
                }
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Anular(DCompra Compra)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spAnularCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_Compra = new SqlParameter();
                parId_Compra.ParameterName = "@Id_Compra";
                parId_Compra.SqlDbType = SqlDbType.Int;
                parId_Compra.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parId_Compra);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Anulo el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Compra");

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;

            }

            return DtResultado;
        }

        public DataTable BuscarFechas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Compra");

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarCompraPorFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(parTextBuscar);

                SqlParameter parTextBuscar2 = new SqlParameter();
                parTextBuscar2.ParameterName = "@textoBuscar2";
                parTextBuscar2.SqlDbType = SqlDbType.VarChar;
                parTextBuscar2.Size = 50;
                parTextBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(parTextBuscar2);

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarDetalle(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Detalle_Compra");

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarDetalle_Compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(parTextBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
