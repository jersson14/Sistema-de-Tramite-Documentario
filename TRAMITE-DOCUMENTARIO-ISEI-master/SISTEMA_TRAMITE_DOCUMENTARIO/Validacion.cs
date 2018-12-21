using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    class Validacion
    {
        public static void sololetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                //mensaje de error al intentar validar numero solo se permiten letras
                v.Handled = true;
                MessageBox.Show("Solo se permite Letras ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        //instanciando el metodo para que solo valide numeros
        public static void solonumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                //mensaje de error al intentar validar letras solo se permiten numeros
                v.Handled = true;
                MessageBox.Show("Solo se permite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
