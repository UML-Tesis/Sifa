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
       public static string Insertar(string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int telefono, string tipo_documento,
         string sector_comercial, string empresa, string direccion, string correo, string ruc)
       {
           DProveedor Obj = new DProveedor();
           Obj.Primer_Nombre = primer_nombre;
           Obj.Segundo_Nombre1 = segundo_nombre;
           Obj.Primer_Apellido1 = segundo_apellido;
           Obj.Segundo_Apellido1 = segundo_apellido;
           Obj.Telefono1 = telefono;
           Obj.Tipo_Documento1 = tipo_documento;
           Obj.Sector_Comercial1 = sector_comercial;
           Obj.Empresa1 = empresa;
           Obj.Direccion1 = direccion;
           Obj.Correo1 = correo;
           Obj.RUC1 = ruc;

           return Obj.Insertar(Obj);

       }

       public static DataTable Mostrar()
       {
           return new DProveedor().Mostrar();
       }

       public static DataTable Buscar(string TextoBuscar)
       {
           DProveedor Obj = new DProveedor();
           Obj.Textobuscar1 = TextoBuscar;
           return Obj.TextoBuscar(Obj);
       }

       public static string Editar( int id_proveedor, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int telefono, string tipo_documento,
         string sector_comercial, string empresa, string direccion, string correo, string ruc)
       {
           DProveedor Obj = new DProveedor();
           Obj.Primer_Nombre = primer_nombre;
           Obj.Segundo_Nombre1 = segundo_nombre;
           Obj.Primer_Apellido1 = segundo_apellido;
           Obj.Segundo_Apellido1 = segundo_apellido;
           Obj.Telefono1 = telefono;
           Obj.Tipo_Documento1 = tipo_documento;
           Obj.Sector_Comercial1 = sector_comercial;
           Obj.Empresa1 = empresa;
           Obj.Direccion1 = direccion;
           Obj.Correo1 = correo;
           Obj.RUC1 = ruc; 
           return Obj.Editar(Obj);
       }
       
    }
}
