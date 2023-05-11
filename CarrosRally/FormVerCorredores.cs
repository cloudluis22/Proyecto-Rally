using CapaNegocios;
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
    public partial class FormVerCorredores : Form
    {
        Corredor corredorSeleccionado;
        public FormVerCorredores()
        {
            InitializeComponent();
        }

        private void MostrarCorredores()
        {
            CorredoresNegocios contextoCorredores = new CorredoresNegocios();
            List<Corredor> listaCorredores = contextoCorredores.GetCorredores();

            DataTable dataCorredores = new DataTable();

            dataCorredores.Columns.Add("ID. Corredor");
            dataCorredores.Columns.Add("Nombre");
            dataCorredores.Columns.Add("Nacionalidad");
            dataCorredores.Columns.Add("Edad");
            dataCorredores.Columns.Add("Marca");
            dataCorredores.Columns.Add("Puntos");


            foreach (Corredor corredor in listaCorredores)
            {
                dataCorredores.Rows.Add(corredor.id, corredor.nombreCorredor, corredor.nacionalidad, corredor.edad.ToString(), corredor.marca, corredor.puntos);
            }

            DataGridCorredores.DataSource = dataCorredores;
            DataGridCorredores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnEliminarCorredor_Click(object sender, EventArgs e)
        {
            CorredoresNegocios contextoCorredores = new CorredoresNegocios();

            if(MessageBox.Show("¿Seguro que desea eliminar a " + corredorSeleccionado.nombreCorredor + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               string res = contextoCorredores.EliminarCorredor(corredorSeleccionado.id);
                MessageBox.Show(res, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            MostrarCorredores();
        }

        private void FormVerCorredores_Load(object sender, EventArgs e)
        {
            LblCorredorActual.Text = String.Empty;
            MostrarCorredores();
        }

        private void DataGridCorredores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView rowSeleccionada = new DataGridView();
            rowSeleccionada = DataGridCorredores;
            corredorSeleccionado = new Corredor(
                rowSeleccionada.CurrentRow.Cells[0].Value.ToString(),
                rowSeleccionada.CurrentRow.Cells[1].Value.ToString(),
                rowSeleccionada.CurrentRow.Cells[2].Value.ToString(),
                int.Parse(rowSeleccionada.CurrentRow.Cells[3].Value.ToString()),
                rowSeleccionada.CurrentRow.Cells[4].Value.ToString(),
                int.Parse(rowSeleccionada.CurrentRow.Cells[5].Value.ToString())
                );
            LblCorredorActual.Text = corredorSeleccionado.nombreCorredor;
            BtnEditarCorredor.Enabled = true;
            BtnEliminarCorredor.Enabled = true;
        }

        private void BtnEditarCorredor_Click(object sender, EventArgs e)
        {
            EditarCorredor editarCorredor = new EditarCorredor(corredorSeleccionado.id);
            editarCorredor.ShowDialog();
        }

        private void BtnActualizarDatos_Click(object sender, EventArgs e)
        {
            MostrarCorredores();
        }
    }
}
