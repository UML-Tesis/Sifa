using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
    
{
    class Validaciones

    {
        public static void sololetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo letras");
               

            }
        }

        // para que los texbox solo acepte numeros
        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("Solo se admiten numeros");
            }
        }

        // para que los texbox no acepten controles
        public static void SoloNumerosyLetras(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("Solo se admiten numeros y letras");
            }
        }
    }
}
