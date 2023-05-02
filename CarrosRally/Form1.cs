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
            CorredoresNegocios contextoCorredores = new CorredoresNegocios();
            List<Corredor> listaCorredores = contextoCorredores.GetCorredores();

            DataTable dataCorredores = new DataTable();

            dataCorredores.Columns.Add("ID. Corredor");
            dataCorredores.Columns.Add("Nombre");
            dataCorredores.Columns.Add("Edad");
            dataCorredores.Columns.Add("Marca");

            foreach (Corredor corredor in listaCorredores)
            {
                dataCorredores.Rows.Add(corredor.id, corredor.nombreCorredor, corredor.edad.ToString(), corredor.marca);
            }

            dataGridView1.DataSource = dataCorredores;
        }


    }
}