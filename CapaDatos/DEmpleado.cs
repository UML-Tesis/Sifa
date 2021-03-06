﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEmpleado
    {
        private int _Id_Empleado;
        private string _Nombre;
        private string _Apellido;
        private string _Alias;
        private string _Cedula;
        private int _Telefono;
        private string _Sexo;
        private int _Salario;
        private string _Correo;
        private string _Usuario;
        private string _Contrasena;
        private string _Direccion;
        private string _TipoAcceso;
        public string _Textobuscar;
        SqlConnection SqlCon = new SqlConnection();
        SqlCommand SqlCmd = new SqlCommand();

        public int Id_Empleado
        {
            get { return _Id_Empleado; }
            set { _Id_Empleado = value; }
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

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public int Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string Contrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string TipoAcceso
        {
            get { return _TipoAcceso; }
            set { _TipoAcceso = value; }
        }

        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }

        public DEmpleado()
        {

        }

        public DEmpleado(int Id_Empleado, string Nombre, string Apellido, string Alias, string Cedula, int Telefono, string Sexo, int Salario, string Correo, string Usuario, string Contrasena, string Direccion, string acceso) 
        {
           this._Id_Empleado = Id_Empleado;
           this._Nombre = Nombre;
           this._Apellido = Apellido;
           this._Alias = Alias;
           this._Cedula = Cedula;
           this._Telefono = Telefono;
           this._Sexo = Sexo;
           this._Salario = Salario;
           this._Correo = Correo;
           this._Usuario = Usuario;
           this._Contrasena = Contrasena;
           this._Direccion = Direccion;
           this.TipoAcceso = acceso;
       }

       public string Insertar(DEmpleado Empleado) 
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "SPInsertar_Empleado";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdEmpleado = new SqlParameter();
               parIdEmpleado.ParameterName = "@Id_Empleado";
               parIdEmpleado.SqlDbType = SqlDbType.Int;
               parIdEmpleado.Direction = ParameterDirection.Output;
               SqlCmd.Parameters.Add(parIdEmpleado);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@Nombre";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Empleado.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parApellido = new SqlParameter();
               parApellido.ParameterName = "@Apellido";
               parApellido.SqlDbType = SqlDbType.VarChar;
               parApellido.Size = 50;
               parApellido.Value = Empleado.Apellido;
               SqlCmd.Parameters.Add(parApellido);

               SqlParameter parSegundoApellido = new SqlParameter();
               parSegundoApellido.ParameterName = "@Alias";
               parSegundoApellido.SqlDbType = SqlDbType.VarChar;
               parSegundoApellido.Size = 50;
               parSegundoApellido.Value = Empleado.Alias;
               SqlCmd.Parameters.Add(parSegundoApellido);

               SqlParameter parCedula = new SqlParameter();
               parCedula.ParameterName = "@Cedula";
               parCedula.SqlDbType = SqlDbType.VarChar;
               parCedula.Size = 16;
               parCedula.Value = Empleado.Cedula;
               SqlCmd.Parameters.Add(parCedula);

               SqlParameter parDireccion = new SqlParameter();
               parDireccion.ParameterName = "@Direccion";
               parDireccion.SqlDbType = SqlDbType.VarChar;
               parDireccion.Size = 255;
               parDireccion.Value = Empleado.Direccion;
               SqlCmd.Parameters.Add(parDireccion);

               SqlParameter parSexo = new SqlParameter();
               parSexo.ParameterName = "@Sexo";
               parSexo.SqlDbType = SqlDbType.VarChar;
               parSexo.Size = 2;
               parSexo.Value = Empleado.Sexo;
               SqlCmd.Parameters.Add(parSexo);

               SqlParameter parTelefono = new SqlParameter();
               parTelefono.ParameterName = "@Telefono";
               parTelefono.SqlDbType = SqlDbType.Int;
               parTelefono.Value = Empleado.Telefono;
               SqlCmd.Parameters.Add(parTelefono);

               SqlParameter parSalario = new SqlParameter();
               parSalario.ParameterName = "@Salario";
               parSalario.SqlDbType = SqlDbType.Int;
               parSalario.Value = Empleado.Salario;
               SqlCmd.Parameters.Add(parSalario);

               SqlParameter parCorreo = new SqlParameter();
               parCorreo.ParameterName = "@Correo";
               parCorreo.SqlDbType = SqlDbType.VarChar;
               parCorreo.Size = 50;
               parCorreo.Value = Empleado.Correo;
               SqlCmd.Parameters.Add(parCorreo);

               SqlParameter parUsuario = new SqlParameter();
               parUsuario.ParameterName = "@Usuario";
               parUsuario.SqlDbType = SqlDbType.VarChar;
               parUsuario.Size = 30;
               parUsuario.Value = Empleado.Usuario;
               SqlCmd.Parameters.Add(parUsuario);

               SqlParameter parContrasena = new SqlParameter();
               parContrasena.ParameterName = "@Contrasena";
               parContrasena.SqlDbType = SqlDbType.VarChar;
               parContrasena.Size = 30;
               parContrasena.Value = Empleado.Contrasena;
               SqlCmd.Parameters.Add(parContrasena);

               SqlParameter parAcceso = new SqlParameter();
               parAcceso.ParameterName = "@Tipo_Acceso";
               parAcceso.SqlDbType = SqlDbType.VarChar;
               parAcceso.Size = 50;
               parAcceso.Value = Empleado.TipoAcceso;
               SqlCmd.Parameters.Add(parAcceso);

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
           DataTable DtResultado = new DataTable("Empleado");

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spMostrarEmpleado";
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

       public DataTable TextoBuscar(DEmpleado Empleado)
       {
           DataTable DtResultado = new DataTable("Empleado");

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spBuscarEmpleado";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parTextBuscar = new SqlParameter();
               parTextBuscar.ParameterName = "@textoBuscar";
               parTextBuscar.SqlDbType = SqlDbType.VarChar;
               parTextBuscar.Size = 50;
               parTextBuscar.Value = Empleado.Textobuscar;
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

       public DataTable Login(DEmpleado Empleado)
       {
           DataTable DtResultado = new DataTable("Empleado");

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCmd = new SqlCommand();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spLogin";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parUsuario = new SqlParameter();
               parUsuario.ParameterName = "@Usuario";
               parUsuario.SqlDbType = SqlDbType.VarChar;
               parUsuario.Size = 20;
               parUsuario.Value = Empleado.Usuario;
               SqlCmd.Parameters.Add(parUsuario);

               SqlParameter parContraseña = new SqlParameter();
               parContraseña.ParameterName = "@Password";
               parContraseña.SqlDbType = SqlDbType.VarChar;
               parContraseña.Size = 20;
               parContraseña.Value = Empleado.Contrasena;
               SqlCmd.Parameters.Add(parContraseña);

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

       public string Editar(DEmpleado Empleado)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spModificarEmpleado";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter ParIdEmpleado = new SqlParameter();
               ParIdEmpleado.ParameterName = "@Id_Empleado";
               ParIdEmpleado.SqlDbType = SqlDbType.Int;
               ParIdEmpleado.Value = Empleado.Id_Empleado;
               SqlCmd.Parameters.Add(ParIdEmpleado);

               SqlParameter parNombre = new SqlParameter();
               parNombre.ParameterName = "@Nombre";
               parNombre.SqlDbType = SqlDbType.VarChar;
               parNombre.Size = 50;
               parNombre.Value = Empleado.Nombre;
               SqlCmd.Parameters.Add(parNombre);

               SqlParameter parApellido = new SqlParameter();
               parApellido.ParameterName = "@Apellido";
               parApellido.SqlDbType = SqlDbType.VarChar;
               parApellido.Size = 50;
               parApellido.Value = Empleado.Apellido;
               SqlCmd.Parameters.Add(parApellido);

               SqlParameter parAlias= new SqlParameter();
               parAlias.ParameterName = "@Alias";
               parAlias.SqlDbType = SqlDbType.VarChar;
               parAlias.Size = 50;
               parAlias.Value = Empleado.Alias;
               SqlCmd.Parameters.Add(parAlias);

               SqlParameter parCedula = new SqlParameter();
               parCedula.ParameterName = "@Cedula";
               parCedula.SqlDbType = SqlDbType.VarChar;
               parCedula.Size = 50;
               parCedula.Value = Empleado.Cedula;
               SqlCmd.Parameters.Add(parCedula);

               SqlParameter parDireccion = new SqlParameter();
               parDireccion.ParameterName = "@Direccion";
               parDireccion.SqlDbType = SqlDbType.VarChar;
               parDireccion.Size = 50;
               parDireccion.Value = Empleado.Direccion;
               SqlCmd.Parameters.Add(parDireccion);

               SqlParameter parSexo = new SqlParameter();
               parSexo.ParameterName = "@Sexo";
               parSexo.SqlDbType = SqlDbType.VarChar;
               parSexo.Size = 2;
               parSexo.Value = Empleado.Sexo;
               SqlCmd.Parameters.Add(parSexo);

               SqlParameter parTelefono = new SqlParameter();
               parTelefono.ParameterName = "@Telefono";
               parTelefono.SqlDbType = SqlDbType.Int;
               parTelefono.Value = Empleado.Telefono;
               SqlCmd.Parameters.Add(parTelefono);

               SqlParameter parSalario = new SqlParameter();
               parSalario.ParameterName = "@Salario";
               parSalario.SqlDbType = SqlDbType.Int;
               parSalario.Value = Empleado.Salario;
               SqlCmd.Parameters.Add(parSalario);

               SqlParameter parCorreo = new SqlParameter();
               parCorreo.ParameterName = "@Correo";
               parCorreo.SqlDbType = SqlDbType.VarChar;
               parCorreo.Size = 50;
               parCorreo.Value = Empleado.Correo;
               SqlCmd.Parameters.Add(parCorreo);

               SqlParameter parUsuario = new SqlParameter();
               parUsuario.ParameterName = "@Usuario";
               parUsuario.SqlDbType = SqlDbType.VarChar;
               parUsuario.Size = 30;
               parUsuario.Value = Empleado.Usuario;
               SqlCmd.Parameters.Add(parUsuario);

               SqlParameter parContrasena = new SqlParameter();
               parContrasena.ParameterName = "@Contrasena";
               parContrasena.SqlDbType = SqlDbType.VarChar;
               parContrasena.Size = 30;
               parContrasena.Value = Empleado.Contrasena;
               SqlCmd.Parameters.Add(parContrasena);

               SqlParameter parAcceso = new SqlParameter();
               parAcceso.ParameterName = "@TipoAcceso";
               parAcceso.SqlDbType = SqlDbType.VarChar;
               parAcceso.Size = 30;
               parAcceso.Value = Empleado.TipoAcceso;
               SqlCmd.Parameters.Add(parAcceso);

               Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se edito";
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

       public string Eliminar(DEmpleado Empleado)
       {
           string Rpta = "";

           try
           {
               SqlCon.ConnectionString = Conexion.Cn;
               SqlCon.Open();
               SqlCmd.Connection = SqlCon;
               SqlCmd.CommandText = "spEliminarEmpleado";
               SqlCmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parIdEmpleado = new SqlParameter();
               parIdEmpleado.ParameterName = "@Id_Empleado";
               parIdEmpleado.SqlDbType = SqlDbType.Int;
               parIdEmpleado.Value = Empleado.Id_Empleado;
               SqlCmd.Parameters.Add(parIdEmpleado);

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
