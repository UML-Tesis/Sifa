using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DCategoria
    {
        private int _Id_Categoria;
        private string _Nombre;
        private string _Descripcion;
        private string _Textobuscar;
        DataTable DtResultado = new DataTable();
        SqlCommand SqlCmd = new SqlCommand();

        SqlConnection SqlCon = new SqlConnection();

       public int Id_Categoria
       {
           get { return _Id_Categoria; }
           set { _Id_Categoria = value; }
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

       public DCategoria() { 

       }

       public DCategoria(int idcategoria, string nombre, string descricion) {
           this._Id_Categoria = idcategoria;
           this._Nombre = nombre;
           this._Descripcion = descricion;
       }

       public string Insertar(DCategoria Categoria)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spInsertarCategoria";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCategoria = new SqlParameter();
               parIdCategoria.ParameterName = "@Id_Categoria";
               parIdCategoria.SqlDbType = SqlDbType.Int;
               parIdCategoria.Direction = ParameterDirection.Output;
               SqlCmd.Parameters.Add(parIdCategoria);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@nombre";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Categoria.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parDesc = new SqlParameter();
               parDesc.ParameterName = "@descripcion";
               parDesc.SqlDbType = SqlDbType.VarChar;
               parDesc.Size = 255;
               parDesc.Value = Categoria.Descripcion;
               SqlCmd.Parameters.Add(parDesc);

               Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se guardo";
           }
           catch (Exception ex)
           {
               Rpta = ex.Message;
           }
           

           finally{
           if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
           }
           return Rpta;
       }

       public DataTable Mostrar() {        
           DtResultado = new DataTable("Categoria");

           try {

               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spMostrarCategoria";
               SqlCmd.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
               SqlDat.Fill(DtResultado);
           }

           catch (Exception ex) {
               DtResultado = null;

           } 
           
           return DtResultado;
       }

       public DataTable TextoBuscar(DCategoria Categoria)
       {
           DataTable DtResultado = new DataTable("Categoria");
           
           
           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spBuscarCategoria";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parTextBuscar = new SqlParameter();
               parTextBuscar.ParameterName = "@textoBuscar";
               parTextBuscar.SqlDbType = SqlDbType.VarChar;
               parTextBuscar.Size = 50;
               parTextBuscar.Value = Categoria.Textobuscar;
               SqlCmd.Parameters.Add(parTextBuscar);

               SqlCmd.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
               SqlDat.Fill(DtResultado);
           }
           catch(Exception ex)
           {
               DtResultado = null;
           }
           return DtResultado;
       }

       public string Editar(DCategoria Categoria)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spModificarCategoria";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCategoria = new SqlParameter();
               parIdCategoria.ParameterName = "@Id_Categoria";
               parIdCategoria.SqlDbType = SqlDbType.Int;
               parIdCategoria.Value = Categoria.Id_Categoria;
               SqlCmd.Parameters.Add(parIdCategoria);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@nombre";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Categoria.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parDesc = new SqlParameter();
               parDesc.ParameterName = "@descripcion";
               parDesc.SqlDbType = SqlDbType.VarChar;
               parDesc.Size = 255;
               parDesc.Value = Categoria.Descripcion;
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

       // metodo eliminar 

       public string Eliminar(DCategoria Categoria) 
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spEliminarCategoria";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCategoria = new SqlParameter();
               parIdCategoria.ParameterName = "@Id_Categoria";
               parIdCategoria.SqlDbType = SqlDbType.Int;
               parIdCategoria.Value = Categoria.Id_Categoria;
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

