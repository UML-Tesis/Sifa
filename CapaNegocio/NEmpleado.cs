using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NEmpleado
    {
        public static string Insertar(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string Cedula, string Direccion, string Sexo, int Telefono, int Salario, string Correo, string Usuario, string Contrasena, string Acceso)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.PrimerNombre = PrimerNombre;
            Obj.SegundoNombre = SegundoNombre;
            Obj.PrimerApellido = PrimerApellido;
            Obj.SegundoApellido = SegundoApellido;
            Obj.Cedula = Cedula;
            Obj.Direccion = Direccion;
            Obj.Sexo = Sexo;
            Obj.Telefono = Telefono;
            Obj.Salario = Salario;
            Obj.Correo = Correo;
            Obj.Usuario = Usuario;
            Obj.Contrasena = Contrasena;
            Obj.TipoAcceso = Acceso;
            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar() 
        {
            return new DEmpleado().Mostrar();
        }

        public static DataTable Buscar(string TextoBuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Textobuscar = TextoBuscar;
            return Obj.TextoBuscar(Obj);
        }

        public static DataTable Login(string Usuario, string Password)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Usuario = Usuario;
            Obj.Contrasena = Password;
            return Obj.Login(Obj);
        }

        public static string Editar(int IdEmpleado, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string Cedula, string Direccion, string Sexo, int Telefono, int Salario, string Correo, string Usuario, string Contrasena, string Acceso)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Id_Empleado = IdEmpleado;
            Obj.PrimerNombre = PrimerNombre;
            Obj.SegundoNombre = SegundoNombre;
            Obj.PrimerApellido = PrimerApellido;
            Obj.SegundoApellido = SegundoApellido;
            Obj.Cedula = Cedula;
            Obj.Direccion = Direccion;
            Obj.Sexo = Sexo;
            Obj.Telefono = Telefono;
            Obj.Salario = Salario;
            Obj.Correo = Correo;
            Obj.Usuario = Usuario;
            Obj.Contrasena = Contrasena;
            Obj.TipoAcceso = Acceso;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int Id_Empleado)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Id_Empleado = Id_Empleado;
            return Obj.Eliminar(Obj);
        }
    }
}
