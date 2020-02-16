using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPresentacion
    {
        private int _Id_Presentacion;
        private string _Nombre;
        private string _Descripcion;
        private string _Textobuscar;
        SqlConnection SqlCon = new SqlConnection();
        SqlCommand SqlCmd = new SqlCommand();

       public int Id_Presentacion
       {
           get { return _Id_Presentacion; }
           set { _Id_Presentacion = value; }
       }
       public string Nombre
       {
           get { return _Nombre; }
           set { _Nombre = value; }
       }
       public string Descripcion
       {
           get { return _Descripcion; }
           set { _Descripcion = value; }
       }

       public string Textobuscar
       {
           get { return _Textobuscar; }
           set { _Textobuscar = value; }
       }

       public DPresentacion() { 

       }

       public DPresentacion(int idpresentacion, string nombre, string descricion) 
       {
        this._Id_Presentacion = idpresentacion;
           this._Nombre = nombre;
           this._Descripcion = descricion;
       }
        
       public string Insertar(DPresentacion Presentacion) 
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "SPInsertar_Presentacion";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCategoria = new SqlParameter();
               parIdCategoria.ParameterName = "@Id_Presentacion";
               parIdCategoria.SqlDbType = SqlDbType.Int;
               parIdCategoria.Direction = ParameterDirection.Output;
               SqlCmd.Parameters.Add(parIdCategoria);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@nombre";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Presentacion.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parDesc = new SqlParameter();
               parDesc.ParameterName = "@descripcion";
               parDesc.SqlDbType = SqlDbType.VarChar;
               parDesc.Size = 255;
               parDesc.Value = Presentacion.Descripcion;
               SqlCmd.Parameters.Add(parDesc);

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
        //mostrar
       public DataTable Mostrar()
       {
           DataTable DtResultado = new DataTable("Presentacion");
           SqlConnection SqlCon = new SqlConnection();

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCommand SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spMostrarPresentacion";
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

       public DataTable TextoBuscar(DPresentacion Presentacion)
       {
           DataTable DtResultado = new DataTable("Presentacion");

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spBuscarPresentacion";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parTextBuscar = new SqlParameter();
               parTextBuscar.ParameterName = "@textoBuscar";
               parTextBuscar.SqlDbType = SqlDbType.VarChar;
               parTextBuscar.Size = 50;
               parTextBuscar.Value = Presentacion.Textobuscar;
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

       public string Editar(DPresentacion Presentacion)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spModificarPresentacion";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCategoria = new SqlParameter();
               parIdCategoria.ParameterName = "@Id_Presentacion";
               parIdCategoria.SqlDbType = SqlDbType.Int;
               parIdCategoria.Value = Presentacion.Id_Presentacion;
               SqlCmd.Parameters.Add(parIdCategoria);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@nombre";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Presentacion.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parDesc = new SqlParameter();
               parDesc.ParameterName = "@descripcion";
               parDesc.SqlDbType = SqlDbType.VarChar;
               parDesc.Size = 255;
               parDesc.Value = Presentacion.Descripcion;
               SqlCmd.Parameters.Add(parDesc);

               Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok " : "No se edito";
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
        //metodo eliminar presentacion

        public string Eliminar(DPresentacion Presentacion) 
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "speliminar_Presentacion";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCategoria = new SqlParameter();
               parIdCategoria.ParameterName = "@idpresentacion";
               parIdCategoria.SqlDbType = SqlDbType.Int;
               parIdCategoria.Value = Presentacion.Id_Presentacion;
               SqlCmd.Parameters.Add(parIdCategoria);


               Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se elimino";
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
     
       }
    }

   