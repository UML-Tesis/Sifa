using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCliente
    {
        public static string Insertar(string Nombre, string Apellido, string Alias, string cedula, string direccion, string sexo, int telefono)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = Nombre;
            Obj.Apellido = Apellido;
            Obj.Alias = Alias;
            Obj.Cedula = cedula;
            Obj.Direccion = direccion;
            Obj.Sexo = sexo;
            Obj.Telefono = telefono;
            return Obj.Insertar(Obj);
        }

        public static int Contar(int getvalue)
        {
            try
            {
                SqlConnection SqlCon = new SqlConnection();
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spContarClientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                getvalue = (int)SqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            return getvalue;
        }

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        public static DataTable Buscar(string TextoBuscar)
        {
            DCliente Obj = new DCliente();
            Obj.Textobuscar = TextoBuscar;
            return Obj.TextoBuscar(Obj);
        }

        public static string Editar(int idCliente, string Nombre, string Apellido, string Alias, string cedula, string direccion, string sexo, int telefono)
        {
            DCliente Obj = new DCliente();
            Obj.Id_Cliente = idCliente;
            Obj.Nombre = Nombre;
            Obj.Apellido = Apellido;
            Obj.Alias = Alias;
            Obj.Cedula = cedula;
            Obj.Direccion = direccion;
            Obj.Sexo = sexo;
            Obj.Telefono = telefono;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int Id_Cliente)
        {
            DCliente Obj = new DCliente();
            Obj.Id_Cliente = Id_Cliente;
            return Obj.Eliminar(Obj);
        }
    }
}
