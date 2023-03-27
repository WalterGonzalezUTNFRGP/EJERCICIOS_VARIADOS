using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if( txtApellido.Text.Trim() == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            if(txtNombre.Text.Trim() == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            if(txtEdad.Text.Trim() == "") 
            {
                txtEdad.BackColor = Color.Red;
            }
            /*else
            {
                if (Regex.IsMatch(txtEdad.Text,"[ ºª!|#·$~%&¬/()=?¿^¨´{}çA-Za-z]"))
                {
                    MessageBox.Show("¡DEBE INGRESAR SÓLO NÚMEROS EN EL CAMPO EDAD!", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
            if(txtDireccion.Text.Trim() == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
        }

        private void txtEdad_KeyUp(object sender, KeyEventArgs e)
        {
            if(!(e.KeyValue >= 48 && e.KeyValue <= 57) && e.KeyValue != 8 && e.KeyValue != 13 && !(e.KeyValue >= 37 && e.KeyValue <=40) && e.KeyValue != 46)
            {
                MessageBox.Show("¡DEBE INGRESAR SÓLO NÚMEROS EN EL CAMPO EDAD!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
