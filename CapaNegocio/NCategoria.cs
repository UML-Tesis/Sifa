using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCategoria
    {
      public static string Insertar(string nombre, string descripcion)
      {
          DCategoria Obj = new DCategoria();
          Obj.Nombre = nombre;
          Obj.Descripcion = descripcion;
          return Obj.Insertar(Obj);
      }

      public static DataTable Mostrar()
      {
          return new DCategoria().Mostrar();
      }

      public static DataTable Buscar(string TextoBuscar)
      {
          DCategoria Obj = new DCategoria();
          Obj.Textobuscar = TextoBuscar;
          return Obj.TextoBuscar(Obj);
      }

      public static string Editar(int Id_Categoria, string nombre, string descripcion)
      {
          DCategoria Obj = new DCategoria();
          Obj.Id_Categoria = Id_Categoria;
          Obj.Nombre = nombre;
          Obj.Descripcion = descripcion;
          return Obj.Editar(Obj);
      }

      public static string Eliminar(int Id_Categoria)
      {
          DCategoria Obj = new DCategoria();
          Obj.Id_Categoria = Id_Categoria;
          return Obj.Eliminar(Obj);
      }
    }
}
