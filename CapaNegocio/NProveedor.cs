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
   public  class NProveedor
    {
       public static string Insertar(string empresa, string contacto_nombre, string contacto_apellido, int telefono, int telefono2, string tipo_documento,
         string sector_comercial, string direccion, string correo, string doc)
       {
           DProveedor Obj = new DProveedor();
           Obj.Empresa = empresa;
           Obj.ContactoNombre = contacto_nombre;
           Obj.ContactoApellido = contacto_apellido;
           Obj.Telefono = telefono;
           Obj.Telefono2 = telefono2;
           Obj.Tipo_Documento = tipo_documento;
           Obj.Sector_Comercial = sector_comercial;
           Obj.Direccion = direccion;
           Obj.Correo = correo;
           Obj.Documento = doc;

           return Obj.Insertar(Obj);

       }

       public static DataTable Mostrar()
       {
           return new DProveedor().Mostrar();
       }

       public static DataTable Buscar(string TextoBuscar)
       {
           DProveedor Obj = new DProveedor();
           Obj.Textobuscar = TextoBuscar;
           return Obj.TextoBuscar(Obj);
       }

       public static string Editar( int id_proveedor, string empresa, string contacto_nombre, string contacto_apellido, int telefono, int telefono2, string tipo_documento,
         string sector_comercial, string direccion, string correo, string ruc)
       {
           DProveedor Obj = new DProveedor();
           Obj.Id_Proveedor = id_proveedor;
           Obj.Empresa = empresa;
           Obj.ContactoNombre = contacto_nombre;
           Obj.ContactoApellido = contacto_apellido;
           Obj.Telefono = telefono;
           Obj.Telefono2 = telefono2;
           Obj.Tipo_Documento = tipo_documento;
           Obj.Sector_Comercial = sector_comercial;
           Obj.Direccion = direccion;
           Obj.Correo = correo;
           Obj.Documento = ruc; 
           return Obj.Editar(Obj);
       }

       public static string Eliminar(int Id_Proveedor)
       {
           DProveedor Obj = new DProveedor();
           Obj.Id_Proveedor = Id_Proveedor;
           return Obj.Eliminar(Obj);
       }
    }
}
