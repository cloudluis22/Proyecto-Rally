using CapaNegocios;
using Modelos;
using System.Data;

namespace CarrosRally
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCorredor_Click(object sender, EventArgs e)
        {
            FormAgregarCorredor formAgregarCorredor = new FormAgregarCorredor();
            formAgregarCorredor.ShowDialog();
        }
    }
}