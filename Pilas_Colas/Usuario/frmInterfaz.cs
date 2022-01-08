using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pilas_Colas.Negocio;

namespace Pilas_Colas.Usuario
{
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
        }
        Pilas miPila;
        Colas objCola;
        int dato;
        private void frmInterfaz_Load(object sender, EventArgs e)
        {
            miPila = new Pilas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miPila.Apilar(txtDato.Text);
            MessageBox.Show("El dato ingreado fue: " + txtDato.Text + "\nEn la posición: " + miPila.PosicionPila, "Mensaje");
            txtDato.Clear();
            txtDato.Focus();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string dato = (string)miPila.Desapilar();
            if (dato == null)
            {
            }
            else
            {
                MessageBox.Show("El dato removido fue: " + dato + "\nDe la posición: " + (miPila.PosicionPila + 1), "Mensaje");
            }
        }

        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAgregar.PerformClick();
            }
        }
    }
}
