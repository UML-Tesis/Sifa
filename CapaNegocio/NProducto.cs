using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProducto
    {
        public static string Insertar(string nombre, double precio, string marca, DateTime vence, int IdCategoria, int IdPresentacion, int medida)
        {
            DProducto Obj = new DProducto();
            Obj.Nombre = nombre;
            Obj.Precio = precio;
            Obj.Marca = marca;
            Obj.Vence = vence;
            Obj.Id_Categoria = IdCategoria;
            Obj.Id_Presentacion = IdPresentacion;
            Obj.Medida = medida;
            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DProducto().Mostrar();
        }

        public static DataTable Buscar(string TextoBuscar)
        {
            DProducto Obj = new DProducto();
            Obj.Textobuscar = TextoBuscar;
            return Obj.TextoBuscar(Obj);
        }

        public static string Editar(int Id_producto, string nombre, double precio, string marca, DateTime vence, int IdCategoria, int IdPresentacion, int medida)
        {
            DProducto Obj = new DProducto();
            Obj.Id_Producto = Id_producto;
            Obj.Nombre = nombre;
            Obj.Precio = precio;
            Obj.Marca = marca;
            Obj.Vence = vence;
            Obj.Id_Categoria = IdCategoria;
            Obj.Id_Presentacion = IdPresentacion;
            Obj.Medida = medida;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int Id_Producto)
        {
            DProducto Obj = new DProducto();
            Obj.Id_Producto = Id_Producto;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Stock_Producto()
        {
            return new DProducto().Stock_Producto();
        }
    }
}
