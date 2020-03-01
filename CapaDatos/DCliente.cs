using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCliente
    {
        private int _Id_Cliente;
        private string _Nombre;
        private string _Apellido;
        private string _Alias;
        private string _Cedula;
        private string _Sexo;
        private string _Direccion;
        private int _Telefono;
        private int _Monto;
        private string _Textobuscar;
        DataTable DtResultado = new DataTable();
        
        SqlCommand SqlCmd = new SqlCommand();

        SqlConnection SqlCon = new SqlConnection();

        public int Id_Cliente
        {
            get { return _Id_Cliente; }
            set { _Id_Cliente = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Alias
        {
            get { return _Alias; }
            set { _Alias = value; }
        }

        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public int Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }

        public DCliente()
        {

        }

        public DCliente(int Id_Empleado, string Nombre, string Apellido, string Alias, string Cedula, string Sexo, string Direccion, int Telefono, int Monto) 
        {
           this._Id_Cliente = Id_Cliente;
           this._Nombre = Nombre;
           this._Apellido = Apellido;
           this._Alias = Alias;
           this._Cedula = Cedula;
           this._Sexo = Sexo;
           this._Direccion = Direccion;
           this._Telefono = Telefono;
           this._Monto = Monto;
       }

       public string Insertar(DCliente Cliente) 
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "SPInsertar_Cliente";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCliente = new SqlParameter();
               parIdCliente.ParameterName = "@Id_Cliente";
               parIdCliente.SqlDbType = SqlDbType.Int;
               parIdCliente.Direction = ParameterDirection.Output;
               SqlCmd.Parameters.Add(parIdCliente);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@Nombres";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Cliente.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parApellido = new SqlParameter();
               parApellido.ParameterName = "@Apellidos";
               parApellido.SqlDbType = SqlDbType.VarChar;
               parApellido.Size = 50;
               parApellido.Value = Cliente.Apellido;
               SqlCmd.Parameters.Add(parApellido);

               SqlParameter parAlias = new SqlParameter();
               parAlias.ParameterName = "@Alias";
               parAlias.SqlDbType = SqlDbType.VarChar;
               parAlias.Size = 50;
               parAlias.Value = Cliente.Alias;
               SqlCmd.Parameters.Add(parAlias);

               SqlParameter parCedula = new SqlParameter();
               parCedula.ParameterName = "@Cedula";
               parCedula.SqlDbType = SqlDbType.VarChar;
               parCedula.Size = 16;
               parCedula.Value = Cliente.Cedula;
               SqlCmd.Parameters.Add(parCedula);

               SqlParameter parDireccion = new SqlParameter();
               parDireccion.ParameterName = "@Direccion";
               parDireccion.SqlDbType = SqlDbType.VarChar;
               parDireccion.Size = 255;
               parDireccion.Value = Cliente.Direccion;
               SqlCmd.Parameters.Add(parDireccion);

               SqlParameter parSexo = new SqlParameter();
               parSexo.ParameterName = "@Sexo";
               parSexo.SqlDbType = SqlDbType.VarChar;
               parSexo.Size = 2;
               parSexo.Value = Cliente.Sexo;
               SqlCmd.Parameters.Add(parSexo);

               SqlParameter parTelefono = new SqlParameter();
               parTelefono.ParameterName = "@Telefono";
               parTelefono.SqlDbType = SqlDbType.Int;
               parTelefono.Value = Cliente.Telefono;
               SqlCmd.Parameters.Add(parTelefono);

               SqlParameter parMonto = new SqlParameter();
               parMonto.ParameterName = "@Monto";
               parMonto.SqlDbType = SqlDbType.Int;
               parMonto.Value = Cliente.Monto;
               SqlCmd.Parameters.Add(parMonto);

               Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se guardo";
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
           DataTable DtResultado = new DataTable("Cliente");
           SqlConnection SqlCon = new SqlConnection();

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCommand SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spMostrarCliente";
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

       public DataTable TextoBuscar(DCliente Cliente)
       {
           DataTable DtResultado = new DataTable("Cliente");

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spBuscarCliente";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parTextBuscar = new SqlParameter();
               parTextBuscar.ParameterName = "@textoBuscar";
               parTextBuscar.SqlDbType = SqlDbType.VarChar;
               parTextBuscar.Size = 50;
               parTextBuscar.Value = Cliente.Textobuscar;
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

       public string Editar(DCliente DCliente)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spModificarCliente";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdEmpleado = new SqlParameter();
               parIdEmpleado.ParameterName = "@Id_Cliente";
               parIdEmpleado.SqlDbType = SqlDbType.Int;
               parIdEmpleado.Value = DCliente.Id_Cliente;
               SqlCmd.Parameters.Add(parIdEmpleado);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@Nombres";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = DCliente.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parApellido = new SqlParameter();
               parApellido.ParameterName = "@Apellidos";
               parApellido.SqlDbType = SqlDbType.VarChar;
               parApellido.Size = 50;
               parApellido.Value = DCliente.Apellido;
               SqlCmd.Parameters.Add(parApellido);

               SqlParameter parAlias = new SqlParameter();
               parAlias.ParameterName = "@Alias";
               parAlias.SqlDbType = SqlDbType.VarChar;
               parAlias.Size = 50;
               parAlias.Value = DCliente.Alias;
               SqlCmd.Parameters.Add(parAlias);

               SqlParameter parCedula = new SqlParameter();
               parCedula.ParameterName = "@Cedula";
               parCedula.SqlDbType = SqlDbType.VarChar;
               parCedula.Size = 50;
               parCedula.Value = DCliente.Cedula;
               SqlCmd.Parameters.Add(parCedula);

               SqlParameter parDireccion = new SqlParameter();
               parDireccion.ParameterName = "@Direccion";
               parDireccion.SqlDbType = SqlDbType.VarChar;
               parDireccion.Size = 50;
               parDireccion.Value = DCliente.Direccion;
               SqlCmd.Parameters.Add(parDireccion);

               SqlParameter parSexo = new SqlParameter();
               parSexo.ParameterName = "@Sexo";
               parSexo.SqlDbType = SqlDbType.VarChar;
               parSexo.Size = 2;
               parSexo.Value = DCliente.Sexo;
               SqlCmd.Parameters.Add(parSexo);

               SqlParameter parTelefono = new SqlParameter();
               parTelefono.ParameterName = "@Telefono";
               parTelefono.SqlDbType = SqlDbType.Int;
               parTelefono.Value = DCliente.Telefono;
               SqlCmd.Parameters.Add(parTelefono);

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

       public string Eliminar(DCliente Cliente)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spEliminarCliente";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdCliente = new SqlParameter();
               parIdCliente.ParameterName = "@Id_Cliente";
               parIdCliente.SqlDbType = SqlDbType.Int;
               parIdCliente.Value = Cliente.Id_Cliente;
               SqlCmd.Parameters.Add(parIdCliente);

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

       public int Contar(int valor)
       {
           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCommand SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spContarClientes";
               SqlCmd.CommandType = CommandType.StoredProcedure;
               valor = (int)SqlCmd.ExecuteScalar();
           }
           catch (Exception ex)
           {
                
           }
           return valor;
       }
    }
}
