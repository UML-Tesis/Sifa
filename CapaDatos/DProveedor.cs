using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProveedor
    {
        private int _Id_Proveedor;
        private string _Empresa;
        private string _ContactoNombre;
        private string _ContactoApellido;
        private int _Telefono;
        private int _Telefono2;
        private string _Tipo_Documento;
        private string _Sector_Comercial;
        private string _Direccion;
        private string _Correo;
        private string _Documento;
        private string _Textobuscar;
        SqlCommand SqlCmd = new SqlCommand();
        SqlConnection SqlCon = new SqlConnection();

        public int Id_Proveedor
        {
            get { return _Id_Proveedor; }
            set { _Id_Proveedor = value; }
        }

        public string Empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }
        public string ContactoNombre
        {
            get { return _ContactoNombre; }
            set { _ContactoNombre = value; }
        }
        public string ContactoApellido
        {
            get { return _ContactoApellido; }
            set { _ContactoApellido = value; }
        }

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public int Telefono2
        {
            get { return _Telefono2; }
            set { _Telefono2 = value; }
        }
        public string Tipo_Documento
        {
            get { return _Tipo_Documento; }
            set { _Tipo_Documento = value; }
        }
        public string Sector_Comercial
        {
            get { return _Sector_Comercial; }
            set { _Sector_Comercial = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }
        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }

        public DProveedor (){
         }
        public DProveedor(int idproveedor, string empresa, string contacto_nombre, string contacto_apellido, int telefono,   int telefono2, 
            string tipo_documento, string sector_comercial, string direccion, string correo, string doc) {
            this._Id_Proveedor = idproveedor;
            this._Empresa = empresa;
            this._ContactoNombre = contacto_nombre;
            this._ContactoApellido = contacto_apellido;
            this._Telefono = telefono;
            this._Telefono2 = telefono2;
            this._Tipo_Documento = tipo_documento;
            this._Sector_Comercial = sector_comercial;
            this._Direccion = direccion;
            this._Correo = correo;
            this._Documento = doc;
           
       }

        public string Insertar(DProveedor Proveedor)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spInsertarProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_Proveedor = new SqlParameter();
                parId_Proveedor.ParameterName = "@Id_Proveedor";
                parId_Proveedor.SqlDbType = SqlDbType.Int;
                parId_Proveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parId_Proveedor);

                SqlParameter parEmpresa = new SqlParameter();
                parEmpresa.ParameterName = "@Empresa";
                parEmpresa.SqlDbType = SqlDbType.VarChar;
                parEmpresa.Size = 50;
                parEmpresa.Value = Proveedor.Empresa;
                SqlCmd.Parameters.Add(parEmpresa);

                SqlParameter parContactoNombre = new SqlParameter();
                parContactoNombre.ParameterName = "@ContactoNombre";
                parContactoNombre.SqlDbType = SqlDbType.VarChar;
                parContactoNombre.Size = 50;
                parContactoNombre.Value = Proveedor.ContactoNombre;
                SqlCmd.Parameters.Add(parContactoNombre);

                SqlParameter parContactoApellido = new SqlParameter();
                parContactoApellido.ParameterName = "@ContactoApellido";
                parContactoApellido.SqlDbType = SqlDbType.VarChar;
                parContactoApellido.Size = 50;
                parContactoApellido.Value = Proveedor.ContactoApellido;
                SqlCmd.Parameters.Add(parContactoApellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@Telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 50;
                parTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(parTelefono);

                SqlParameter parTelefono2 = new SqlParameter();
                parTelefono2.ParameterName = "@Telefono2";
                parTelefono2.SqlDbType = SqlDbType.Int;
                parTelefono2.Value = Proveedor.Telefono2;
                SqlCmd.Parameters.Add(parTelefono2);

                SqlParameter parTipo_Documento = new SqlParameter();
                parTipo_Documento.ParameterName = "@Tipo_Documento";
                parTipo_Documento.SqlDbType = SqlDbType.VarChar;
                parTipo_Documento.Size = 50;
                parTipo_Documento.Value = Proveedor.Tipo_Documento;
                SqlCmd.Parameters.Add(parTipo_Documento);

                SqlParameter parSector_Comercial = new SqlParameter();
                parSector_Comercial.ParameterName = "@Sector_Comercial";
                parSector_Comercial.SqlDbType = SqlDbType.VarChar;
                parSector_Comercial.Size = 50;
                parSector_Comercial.Value = Proveedor.Sector_Comercial;
                SqlCmd.Parameters.Add(parSector_Comercial);

                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@Direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 50;
                parDireccion.Value = Proveedor.Direccion;
                SqlCmd.Parameters.Add(parDireccion);

                SqlParameter parCorreo = new SqlParameter();
                parCorreo.ParameterName = "@Correo";
                parCorreo.SqlDbType = SqlDbType.VarChar;
                parCorreo.Size = 50;
                parCorreo.Value = Proveedor.Correo;
                SqlCmd.Parameters.Add(parCorreo);

                SqlParameter parDoc = new SqlParameter();
                parDoc.ParameterName = "@Documento";
                parDoc.SqlDbType = SqlDbType.VarChar;
                parDoc.Size = 14;
                parDoc.Value = Proveedor.Documento;
                SqlCmd.Parameters.Add(parDoc);

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
            DataTable DtResultado = new DataTable("Proveedor");

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarProveedor";
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

        public DataTable TextoBuscar(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("Proveedor");

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = Proveedor.Textobuscar;
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

        public string Editar(DProveedor Proveedor)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spModificarProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_Proveedor = new SqlParameter();
                parId_Proveedor.ParameterName = "@Id_Proveedor";
                parId_Proveedor.SqlDbType = SqlDbType.Int;
                parId_Proveedor.Value = Proveedor.Id_Proveedor;
                SqlCmd.Parameters.Add(parId_Proveedor);

                SqlParameter parEmpresa = new SqlParameter();
                parEmpresa.ParameterName = "@Empresa";
                parEmpresa.SqlDbType = SqlDbType.VarChar;
                parEmpresa.Size = 50;
                parEmpresa.Value = Proveedor.Empresa;
                SqlCmd.Parameters.Add(parEmpresa);

                SqlParameter parContactoNombre = new SqlParameter();
                parContactoNombre.ParameterName = "@ContactoNombre";
                parContactoNombre.SqlDbType = SqlDbType.VarChar;
                parContactoNombre.Size = 50;
                parContactoNombre.Value = Proveedor.ContactoNombre;
                SqlCmd.Parameters.Add(parContactoNombre);

                SqlParameter parContactoApellido = new SqlParameter();
                parContactoApellido.ParameterName = "@ContactoApellido";
                parContactoApellido.SqlDbType = SqlDbType.VarChar;
                parContactoApellido.Size = 50;
                parContactoApellido.Value = Proveedor.ContactoApellido;
                SqlCmd.Parameters.Add(parContactoApellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@Telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 50;
                parTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(parTelefono);

                SqlParameter parTelefono2 = new SqlParameter();
                parTelefono2.ParameterName = "@Telefono2";
                parTelefono2.SqlDbType = SqlDbType.Int;
                parTelefono2.Value = Proveedor.Telefono2;
                SqlCmd.Parameters.Add(parTelefono2);

                SqlParameter parTipo_Documento = new SqlParameter();
                parTipo_Documento.ParameterName = "@Tipo_Documento";
                parTipo_Documento.SqlDbType = SqlDbType.VarChar;
                parTipo_Documento.Size = 50;
                parTipo_Documento.Value = Proveedor.Tipo_Documento;
                SqlCmd.Parameters.Add(parTipo_Documento);

                SqlParameter parSector_Comercial = new SqlParameter();
                parSector_Comercial.ParameterName = "@Sector_Comercial";
                parSector_Comercial.SqlDbType = SqlDbType.VarChar;
                parSector_Comercial.Size = 50;
                parSector_Comercial.Value = Proveedor.Sector_Comercial;
                SqlCmd.Parameters.Add(parSector_Comercial);

                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@Direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 50;
                parDireccion.Value = Proveedor.Direccion;
                SqlCmd.Parameters.Add(parDireccion);

                SqlParameter parCorreo = new SqlParameter();
                parCorreo.ParameterName = "@Correo";
                parCorreo.SqlDbType = SqlDbType.VarChar;
                parCorreo.Size = 50;
                parCorreo.Value = Proveedor.Correo;
                SqlCmd.Parameters.Add(parCorreo);

                SqlParameter parDoc = new SqlParameter();
                parDoc.ParameterName = "@Documento";
                parDoc.SqlDbType = SqlDbType.VarChar;
                parDoc.Size = 14;
                parDoc.Value = Proveedor.Documento;
                SqlCmd.Parameters.Add(parDoc);

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

        public string Eliminar(DProveedor Proveedor)
        {
            string Rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spEliminarProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_Proveedor";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Value = Proveedor.Id_Proveedor;
                SqlCmd.Parameters.Add(parIdProducto);

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

        public string Contar()
        {
            int valor = 0;
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spContarProveedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add("@Count", SqlDbType.Int).Direction = ParameterDirection.Output;
                SqlCon.Open();
                SqlCmd.ExecuteNonQuery();
                valor = Convert.ToInt32(SqlCmd.Parameters["@Count"].Value);
            }
            catch (Exception ex)
            {

            }
            return valor.ToString();
        }
    }
}
