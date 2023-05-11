using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using Modelos;

namespace CarrosRally
{
    public partial class FormVerMarcas : Form
    {
        Marca marcaSeleccionada;

        public FormVerMarcas()
        {
            InitializeComponent();
            MostrarMarcas();
        }

        private void MostrarMarcas()
        {
            MarcasNegocios contextoMarcas = new MarcasNegocios();
            List<Marca> listaMarcas = contextoMarcas.GetMarcas();

            DataTable dataMarcas = new DataTable();

            dataMarcas.Columns.Add("ID. Marca");
            dataMarcas.Columns.Add("Nombre");
            dataMarcas.Columns.Add("País de Fundación");
            dataMarcas.Columns.Add("Año de Fundación");

            foreach (Marca marca in listaMarcas)
            {
                dataMarcas.Rows.Add(marca.id, marca.nombreMarca, marca.paisFundacion, marca.anioFundacion.ToString());
            }

            DataGridMarcas.DataSource = dataMarcas;
            DataGridMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcasNegocios contextoMarcas = new MarcasNegocios();

            if (MessageBox.Show("¿Seguro que desea eliminar la marca " + marcaSeleccionada.nombreMarca + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string res = contextoMarcas.EliminarMarca(marcaSeleccionada.id);
                MessageBox.Show(res, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            MostrarMarcas();
        }

        private void BtnEditarMarca_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizarDatos_Click(object sender, EventArgs e)
        {
            MostrarMarcas(); 
        }

        private void DataGridMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView rowSeleccionada = new DataGridView();
            rowSeleccionada = DataGridMarcas;
            marcaSeleccionada = new Marca(
                rowSeleccionada.CurrentRow.Cells[0].Value.ToString(),
                rowSeleccionada.CurrentRow.Cells[1].Value.ToString(),
                rowSeleccionada.CurrentRow.Cells[2].Value.ToString(),
                int.Parse(rowSeleccionada.CurrentRow.Cells[3].Value.ToString()));
            LblMarcaActual.Text = marcaSeleccionada.nombreMarca;
            BtnEditarMarca.Enabled = true;
            BtnEliminarMarca.Enabled = true;
        }
    }
}
