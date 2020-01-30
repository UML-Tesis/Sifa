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
        public static string Insertar(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string cedula, string direccion, string sexo, int telefono)
        {
            DCliente Obj = new DCliente();
            Obj.PrimerNombre = primerNombre;
            Obj.SegundoNombre = segundoNombre;
            Obj.PrimerApellido = primerApellido;
            Obj.SegundoApellido = segundoApellido;
            Obj.Cedula = cedula;
            Obj.Direccion = direccion;
            Obj.Sexo = sexo;
            Obj.Telefono = telefono;
            return Obj.Insertar(Obj);
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

        public static string Editar(int idEmpleado, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string cedula, string direccion, string sexo, int telefono)
        {
            DCliente Obj = new DCliente();
            Obj.PrimerNombre = primerNombre;
            Obj.SegundoNombre = segundoNombre;
            Obj.PrimerApellido = primerApellido;
            Obj.SegundoApellido = segundoApellido;
            Obj.Cedula = cedula;
            Obj.Direccion = direccion;
            Obj.Sexo = sexo;
            Obj.Telefono = telefono;
            return Obj.Editar(Obj);
        }
    }
}
