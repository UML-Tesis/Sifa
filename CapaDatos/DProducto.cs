using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {
        private int _Id_Producto;
        private string _Nombre;
        private string _Codigo;
        private double _Precio;
        private string _Marca;
        private DateTime _Vence;
        private int _Id_Categoria;
        private int _Id_Presentacion;
        private int _Medida;
        private string _Textobuscar;
        SqlConnection SqlCon = new SqlConnection();
        SqlCommand SqlCmd = new SqlCommand();

        public int Id_Producto
        {
            get { return _Id_Producto; }
            set { _Id_Producto = value; }
        }
    
        public string Nombre
        {
          get { return _Nombre; }
          set { _Nombre = value; }
        }

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public double Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public string Marca
        {
          get { return _Marca; }
          set { _Marca = value; }
        }
    
        public DateTime Vence
        {
          get { return _Vence; }
          set { _Vence = value; }
        }

        public int Id_Categoria
        {
          get { return _Id_Categoria; }
          set { _Id_Categoria = value; }
        }

        public int Id_Presentacion
        {
            get { return _Id_Presentacion; }
            set { _Id_Presentacion = value; }
        }

        public int Medida
        {
            get { return _Medida; }
            set { _Medida = value; }
        }

        public string Textobuscar
        {
          get { return _Textobuscar; }
          set { _Textobuscar = value; }
        }

        public DProducto(){
    
        }

        public DProducto(int IdProducto, string Nombre, string codigo, string marca, double Precio, DateTime Vence, int IdCategoria, int IdPresentacion, int Medida)
        {
            this._Id_Producto = IdProducto;
            this._Nombre = Nombre;
            this._Codigo = codigo;
            this._Marca = marca;
            this._Precio = Precio;
            this._Vence = Vence;
            this._Id_Categoria = IdCategoria;
            this._Id_Presentacion = IdPresentacion;
            this._Medida = Medida;
        }

        public string Insertar(DProducto Producto)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPInsertar_Producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_Producto";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parIdProducto);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@Nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Producto.Nombre;
                SqlCmd.Parameters.Add(parNombre);

                SqlParameter parPrecio = new SqlParameter();
                parPrecio.ParameterName = "@Precio";
                parPrecio.SqlDbType = SqlDbType.Int;
                parPrecio.Value = Producto.Precio;
                SqlCmd.Parameters.Add(parPrecio);

                SqlParameter parMarca = new SqlParameter();
                parMarca.ParameterName = "@Marca";
                parMarca.SqlDbType = SqlDbType.VarChar;
                parMarca.Size = 50;
                parMarca.Value = Producto.Marca;
                SqlCmd.Parameters.Add(parMarca);

                SqlParameter parVence = new SqlParameter();
                parVence.ParameterName = "@Fecha_Vencimiento";
                parVence.SqlDbType = SqlDbType.Date;
                parVence.Value = Producto.Vence;
                SqlCmd.Parameters.Add(parVence);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@Id_Categoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Producto.Id_Categoria;
                SqlCmd.Parameters.Add(parIdCategoria);

                SqlParameter parIdPresentacion = new SqlParameter();
                parIdPresentacion.ParameterName = "@Id_Presentacion";
                parIdPresentacion.SqlDbType = SqlDbType.Int;
                parIdPresentacion.Value = Producto.Id_Presentacion;
                SqlCmd.Parameters.Add(parIdPresentacion);

                SqlParameter parMedida = new SqlParameter();
                parMedida.ParameterName = "@Medida";
                parMedida.SqlDbType = SqlDbType.Int;
                parMedida.Value = Producto.Medida;
                SqlCmd.Parameters.Add(parMedida);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se guardo";
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
            DataTable DtResultado;
            DtResultado = new DataTable("Producto");

            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarProductos";
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

        public DataTable TextoBuscar(DProducto Producto)
        {
            DataTable DtResultado = new DataTable("Producto");


            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarProducto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = Producto.Textobuscar;
                SqlCmd.Parameters.Add(parTextBuscar);

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

        public string Editar(DProducto Producto)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spModificarProducto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_Producto";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Value = Producto.Id_Producto;
                SqlCmd.Parameters.Add(parIdProducto);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@Nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Producto.Nombre;
                SqlCmd.Parameters.Add(parNombre);

                SqlParameter parPrecio = new SqlParameter();
                parPrecio.ParameterName = "@Precio";
                parPrecio.SqlDbType = SqlDbType.Int;
                parPrecio.Value = Producto.Precio;
                SqlCmd.Parameters.Add(parPrecio);

                SqlParameter parMarca = new SqlParameter();
                parMarca.ParameterName = "@Marca";
                parMarca.SqlDbType = SqlDbType.VarChar;
                parMarca.Size = 50;
                parMarca.Value = Producto.Marca;
                SqlCmd.Parameters.Add(parMarca);

                SqlParameter parVence = new SqlParameter();
                parVence.ParameterName = "@Fecha_Vencimiento";
                parVence.SqlDbType = SqlDbType.Date;
                parVence.Value = Producto.Vence;
                SqlCmd.Parameters.Add(parVence);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@Id_Categoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Producto.Id_Categoria;
                SqlCmd.Parameters.Add(parIdCategoria);

                SqlParameter parIdPresentacion = new SqlParameter();
                parIdPresentacion.ParameterName = "@Id_Presentacion";
                parIdPresentacion.SqlDbType = SqlDbType.Int;
                parIdPresentacion.Value = Producto.Id_Presentacion;
                SqlCmd.Parameters.Add(parIdPresentacion);

                SqlParameter parMedida = new SqlParameter();
                parMedida.ParameterName = "@Medida";
                parMedida.SqlDbType = SqlDbType.Int;
                parMedida.Value = Producto.Medida;
                SqlCmd.Parameters.Add(parMedida);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK " : "No se edito";
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

        public DataTable Stock_Producto()
        {
            DataTable DtResultado;
            DtResultado = new DataTable("Producto");

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spStock_Productos";
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
    }
}
