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
        private string _PrimerNombre;
        private string _SegundoNombre;
        private string _PrimerApellido;
        private string _SegundoApellido;
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

        public string PrimerNombre
        {
            get { return _PrimerNombre; }
            set { _PrimerNombre = value; }
        }

        public string SegundoNombre
        {
            get { return _SegundoNombre; }
            set { _SegundoNombre = value; }
        }

        public string PrimerApellido
        {
            get { return _PrimerApellido; }
            set { _PrimerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return _SegundoApellido; }
            set { _SegundoApellido = value; }
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

        public DCliente(int Id_Empleado, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string Cedula, string Sexo, string Direccion, int Telefono, int Monto) 
        {
           this._Id_Cliente = Id_Cliente;
           this._PrimerNombre = PrimerNombre;
           this._SegundoNombre = SegundoNombre;
           this._PrimerApellido = PrimerApellido;
           this._SegundoApellido = SegundoApellido;
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

               SqlParameter parPrimerNombre = new SqlParameter();
               parPrimerNombre.ParameterName = "@PrimerNombre";
               parPrimerNombre.SqlDbType = SqlDbType.VarChar;
               parPrimerNombre.Size = 50;
               parPrimerNombre.Value = Cliente.PrimerNombre;
               SqlCmd.Parameters.Add(parPrimerNombre);

               SqlParameter parSegundoNombre = new SqlParameter();
               parSegundoNombre.ParameterName = "@SegundoNombre";
               parSegundoNombre.SqlDbType = SqlDbType.VarChar;
               parSegundoNombre.Size = 50;
               parSegundoNombre.Value = Cliente.SegundoNombre;
               SqlCmd.Parameters.Add(parSegundoNombre);

               SqlParameter parPrimerApellido = new SqlParameter();
               parPrimerApellido.ParameterName = "@PrimerApellido";
               parPrimerApellido.SqlDbType = SqlDbType.VarChar;
               parPrimerApellido.Size = 50;
               parPrimerApellido.Value = Cliente.PrimerApellido;
               SqlCmd.Parameters.Add(parPrimerApellido);

               SqlParameter parSegundoApellido = new SqlParameter();
               parSegundoApellido.ParameterName = "@SegundoApellido";
               parSegundoApellido.SqlDbType = SqlDbType.VarChar;
               parSegundoApellido.Size = 50;
               parSegundoApellido.Value = Cliente.SegundoApellido;
               SqlCmd.Parameters.Add(parSegundoApellido);

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

               SqlParameter parPrimerNombre = new SqlParameter();
               parPrimerNombre.ParameterName = "@PrimerNombre";
               parPrimerNombre.SqlDbType = SqlDbType.VarChar;
               parPrimerNombre.Size = 50;
               parPrimerNombre.Value = DCliente.PrimerNombre;
               SqlCmd.Parameters.Add(parPrimerNombre);

               SqlParameter parSegundoNombre = new SqlParameter();
               parSegundoNombre.ParameterName = "@SegundoNombre";
               parSegundoNombre.SqlDbType = SqlDbType.VarChar;
               parSegundoNombre.Size = 255;
               parSegundoNombre.Value = DCliente.SegundoNombre;
               SqlCmd.Parameters.Add(parSegundoNombre);

               SqlParameter parPrimerApellido = new SqlParameter();
               parPrimerApellido.ParameterName = "@PrimerApellido";
               parPrimerApellido.SqlDbType = SqlDbType.VarChar;
               parPrimerApellido.Size = 50;
               parPrimerApellido.Value = DCliente.PrimerApellido;
               SqlCmd.Parameters.Add(parPrimerApellido);

               SqlParameter parSegundoApellido = new SqlParameter();
               parSegundoApellido.ParameterName = "@SegundoApellido";
               parSegundoApellido.SqlDbType = SqlDbType.VarChar;
               parSegundoApellido.Size = 50;
               parSegundoApellido.Value = DCliente.SegundoApellido;
               SqlCmd.Parameters.Add(parSegundoApellido);

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
               parSexo.Size = 50;
               parSexo.Value = DCliente.Sexo;
               SqlCmd.Parameters.Add(parSexo);

               SqlParameter parTelefono = new SqlParameter();
               parTelefono.ParameterName = "@Telefono";
               parTelefono.SqlDbType = SqlDbType.Int;
               parTelefono.Value = DCliente.Telefono;
               SqlCmd.Parameters.Add(parTelefono);

               Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Editado " : "No se edito";
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
