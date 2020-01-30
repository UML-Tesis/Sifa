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
        private string _Primer_Nombre;
        private string Segundo_Nombre;
        private string Primer_Apellido;
        private string Segundo_Apellido;
        private int Telefono;
        private string Tipo_Documento;
        private string Sector_Comercial;
        private string Empresa;
        private string Direccion;
        private string Correo;
        private string RUC;
        private string Textobuscar;
        SqlCommand SqlCmd = new SqlCommand();
        SqlConnection SqlCon = new SqlConnection();

        public int Id_Proveedor
        {
            get { return _Id_Proveedor; }
            set { _Id_Proveedor = value; }
        }

        public string Primer_Nombre
        {
            get { return _Primer_Nombre; }
            set { _Primer_Nombre = value; }
        }
        public string Segundo_Nombre1
        {
            get { return Segundo_Nombre; }
            set { Segundo_Nombre = value; }
        }
        public string Primer_Apellido1
        {
            get { return Primer_Apellido; }
            set { Primer_Apellido = value; }
        }
        public string Segundo_Apellido1
        {
            get { return Segundo_Apellido; }
            set { Segundo_Apellido = value; }
        }
        public int Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string Tipo_Documento1
        {
            get { return Tipo_Documento; }
            set { Tipo_Documento = value; }
        }
        public string Sector_Comercial1
        {
            get { return Sector_Comercial; }
            set { Sector_Comercial = value; }
        }
        public string Empresa1
        {
            get { return Empresa; }
            set { Empresa = value; }
        }
        public string Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string Correo1
        {
            get { return Correo; }
            set { Correo = value; }
        }
        public string RUC1
        {
            get { return RUC; }
            set { RUC = value; }
        }
        public string Textobuscar1
        {
            get { return Textobuscar; }
            set { Textobuscar = value; }
        }

        public DProveedor (){
         }
        public DProveedor(int idproveedor, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido,   int telefono, 
            string tipo_documento, string sector_comercial,string empresa, string direccion, string correo, string ruc) {
            this._Id_Proveedor = idproveedor;
            this._Primer_Nombre = primer_nombre;
            this.Segundo_Nombre = segundo_nombre;
            this.Primer_Apellido = primer_apellido;
            this.Segundo_Apellido = segundo_apellido;
            this.Telefono = telefono;
            this.Tipo_Documento = tipo_documento;
            this.Sector_Comercial = sector_comercial;
            this.Empresa = empresa;
            this.Direccion = direccion;
            this.Correo = correo;
            this.RUC = ruc;
           
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

                SqlParameter parPrimer_Nombre = new SqlParameter();
                parPrimer_Nombre.ParameterName = "@Primer_Nombre";
                parPrimer_Nombre.SqlDbType = SqlDbType.VarChar;
                parPrimer_Nombre.Size = 50;
                parPrimer_Nombre.Value = Proveedor._Primer_Nombre;
                SqlCmd.Parameters.Add(parPrimer_Nombre);

                SqlParameter parSegundo_Nombre = new SqlParameter();
                parSegundo_Nombre.ParameterName = "@Segundo_Nombre";
                parSegundo_Nombre.SqlDbType = SqlDbType.VarChar;
                parSegundo_Nombre.Size = 50;
                parSegundo_Nombre.Value = Proveedor.Segundo_Nombre;
                SqlCmd.Parameters.Add(parSegundo_Nombre);

                SqlParameter parPrimer_Apellido = new SqlParameter();
                parPrimer_Apellido.ParameterName = "@Primer_Apellido";
                parPrimer_Apellido.SqlDbType = SqlDbType.VarChar;
                parPrimer_Apellido.Size = 50;
                parPrimer_Apellido.Value = Proveedor.Primer_Apellido;
                SqlCmd.Parameters.Add(parPrimer_Apellido);

                SqlParameter parSegundo_Apellido = new SqlParameter();
                parSegundo_Apellido.ParameterName = "@Segundo_Apellido";
                parSegundo_Apellido.SqlDbType = SqlDbType.VarChar;
                parSegundo_Apellido.Size = 50;
                parSegundo_Apellido.Value = Proveedor.Segundo_Apellido;
                SqlCmd.Parameters.Add(parSegundo_Apellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@Telefono";
                parTelefono.SqlDbType = SqlDbType.Int;
                parTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(parTelefono);

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

                SqlParameter parEmpresa = new SqlParameter();
                parEmpresa.ParameterName = "@Empresa";
                parEmpresa.SqlDbType = SqlDbType.VarChar;
                parEmpresa.Size = 50;
                parEmpresa.Value = Proveedor.Empresa;
                SqlCmd.Parameters.Add(parEmpresa);

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

                SqlParameter parRUC = new SqlParameter();
                parRUC.ParameterName = "@RUC";
                parRUC.SqlDbType = SqlDbType.VarChar;
                parRUC.Size = 14;
                parRUC.Value = Proveedor.RUC;
                SqlCmd.Parameters.Add(parRUC);

              

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
                parId_Proveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parId_Proveedor);

                SqlParameter parPrimer_Nombre = new SqlParameter();
                parPrimer_Nombre.ParameterName = "@Primer_Nombre";
                parPrimer_Nombre.SqlDbType = SqlDbType.VarChar;
                parPrimer_Nombre.Size = 50;
                parPrimer_Nombre.Value = Proveedor._Primer_Nombre;
                SqlCmd.Parameters.Add(parPrimer_Nombre);

                SqlParameter parSegundo_Nombre = new SqlParameter();
                parSegundo_Nombre.ParameterName = "@Segundo_Nombre";
                parSegundo_Nombre.SqlDbType = SqlDbType.VarChar;
                parSegundo_Nombre.Size = 50;
                parSegundo_Nombre.Value = Proveedor.Segundo_Nombre;
                SqlCmd.Parameters.Add(parSegundo_Nombre);

                SqlParameter parPrimer_Apellido = new SqlParameter();
                parPrimer_Apellido.ParameterName = "@Primer_Apellido";
                parPrimer_Apellido.SqlDbType = SqlDbType.VarChar;
                parPrimer_Apellido.Size = 50;
                parPrimer_Apellido.Value = Proveedor.Primer_Apellido;
                SqlCmd.Parameters.Add(parPrimer_Apellido);

                SqlParameter parSegundo_Apellido = new SqlParameter();
                parSegundo_Apellido.ParameterName = "@Segundo_Apellido";
                parSegundo_Apellido.SqlDbType = SqlDbType.VarChar;
                parSegundo_Apellido.Size = 50;
                parSegundo_Apellido.Value = Proveedor.Segundo_Apellido;
                SqlCmd.Parameters.Add(parSegundo_Apellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@Telefono";
                parTelefono.SqlDbType = SqlDbType.Int;
                parTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(parTelefono);

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

                SqlParameter parEmpresa = new SqlParameter();
                parEmpresa.ParameterName = "@Empresa";
                parEmpresa.SqlDbType = SqlDbType.VarChar;
                parEmpresa.Size = 50;
                parEmpresa.Value = Proveedor.Empresa;
                SqlCmd.Parameters.Add(parEmpresa);

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

                SqlParameter parRUC = new SqlParameter();
                parRUC.ParameterName = "@RUC";
                parRUC.SqlDbType = SqlDbType.VarChar;
                parRUC.Size = 14;
                parRUC.Value = Proveedor.RUC;
                SqlCmd.Parameters.Add(parRUC);

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
    }
}
