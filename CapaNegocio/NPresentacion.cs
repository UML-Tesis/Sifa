using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
 
    public class NPresentacion
    {
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }

        public static DataTable Buscar(string TextoBuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Textobuscar = TextoBuscar;
            return Obj.TextoBuscar(Obj);
        }

        public static string Editar(int Id_Presentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Id_Presentacion = Id_Presentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int Id_Presentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Id_Presentacion = Id_Presentacion;
            return Obj.Eliminar(Obj);
        }
    }
}
