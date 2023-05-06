using CapaDatos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosRally
{
    public partial class EditarCorredor : Form
    {
        string idCorredor = String.Empty;
        public EditarCorredor(string id)
        {
            idCorredor = id;
            InitializeComponent();
        }

        private void EditarCorredor_Load(object sender, EventArgs e)
        {
            CorredoresDatos corredoresDatos = new CorredoresDatos();
            Corredor corredor = corredoresDatos.GetCorredor(idCorredor);

            TxtBoxNombre.Text = corredor.nombreCorredor.ToString();
            TxtBoxMarca.Text = corredor.marca.ToString();
            TxtBoxNacionalidad.Text = corredor.nacionalidad.ToString();
            NumericEdad.Value = int.Parse(corredor.edad.ToString());
            NumericPuntos.Value = int.Parse(corredor.puntos.ToString());

        }
    }
}
