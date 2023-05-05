using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosRally
{
    public partial class FormAgregarCorredor : Form
    {
        public FormAgregarCorredor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CorredoresNegocios corredoresNegocios = new CorredoresNegocios();
            string accion = corredoresNegocios.AgregarCorredor(TxtBoxNombre.Text, TxtBoxNacionalidad.Text, (int)NumericEdad.Value, TxtBoxMarca.Text, (int)NumericPuntos.Value);
            MessageBox.Show(accion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
