﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NDetalleCompra
    {
        public static DataTable MostrarBajoStock()
        {
            return new DDetalleCompra().BajoStock();
        }
    }
}
