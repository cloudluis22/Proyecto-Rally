namespace CarrosRally
{
    partial class FormVerMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnActualizarDatos = new System.Windows.Forms.Button();
            this.BtnEliminarMarca = new System.Windows.Forms.Button();
            this.BtnEditarMarca = new System.Windows.Forms.Button();
            this.LblMarcaActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnActualizarDatos
            // 
            this.BtnActualizarDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnActualizarDatos.Location = new System.Drawing.Point(596, 289);
            this.BtnActualizarDatos.Name = "BtnActualizarDatos";
            this.BtnActualizarDatos.Size = new System.Drawing.Size(203, 38);
            this.BtnActualizarDatos.TabIndex = 16;
            this.BtnActualizarDatos.Text = "Actualizar Datos";
            this.BtnActualizarDatos.UseVisualStyleBackColor = true;
            this.BtnActualizarDatos.Click += new System.EventHandler(this.BtnActualizarDatos_Click);
            // 
            // BtnEliminarMarca
            // 
            this.BtnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarMarca.Location = new System.Drawing.Point(596, 228);
            this.BtnEliminarMarca.Name = "BtnEliminarMarca";
            this.BtnEliminarMarca.Size = new System.Drawing.Size(203, 38);
            this.BtnEliminarMarca.TabIndex = 15;
            this.BtnEliminarMarca.Text = "Eliminar Marca";
            this.BtnEliminarMarca.UseVisualStyleBackColor = true;
            this.BtnEliminarMarca.Click += new System.EventHandler(this.BtnEliminarMarca_Click);
            // 
            // BtnEditarMarca
            // 
            this.BtnEditarMarca.Enabled = false;
            this.BtnEditarMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarMarca.Location = new System.Drawing.Point(596, 169);
            this.BtnEditarMarca.Name = "BtnEditarMarca";
            this.BtnEditarMarca.Size = new System.Drawing.Size(203, 38);
            this.BtnEditarMarca.TabIndex = 14;
            this.BtnEditarMarca.Text = "Editar Marca";
            this.BtnEditarMarca.UseVisualStyleBackColor = true;
            this.BtnEditarMarca.Click += new System.EventHandler(this.BtnEditarMarca_Click);
            // 
            // LblMarcaActual
            // 
            this.LblMarcaActual.AutoSize = true;
            this.LblMarcaActual.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMarcaActual.Location = new System.Drawing.Point(596, 107);
            this.LblMarcaActual.Name = "LblMarcaActual";
            this.LblMarcaActual.Size = new System.Drawing.Size(87, 23);
            this.LblMarcaActual.TabIndex = 13;
            this.LblMarcaActual.Text = "*marca*";
            this.LblMarcaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(596, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca Seleccionada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Visualizador de Marcas";
            // 
            // DataGridMarcas
            // 
            this.DataGridMarcas.AllowUserToAddRows = false;
            this.DataGridMarcas.AllowUserToDeleteRows = false;
            this.DataGridMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridMarcas.Location = new System.Drawing.Point(22, 106);
            this.DataGridMarcas.Name = "DataGridMarcas";
            this.DataGridMarcas.ReadOnly = true;
            this.DataGridMarcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridMarcas.RowTemplate.Height = 25;
            this.DataGridMarcas.Size = new System.Drawing.Size(553, 292);
            this.DataGridMarcas.TabIndex = 10;
            this.DataGridMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMarcas_CellClick);
            // 
            // FormVerMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(836, 430);
            this.Controls.Add(this.BtnActualizarDatos);
            this.Controls.Add(this.BtnEliminarMarca);
            this.Controls.Add(this.BtnEditarMarca);
            this.Controls.Add(this.LblMarcaActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridMarcas);
            this.Name = "FormVerMarcas";
            this.Text = "Visualizador de Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnActualizarDatos;
        private Button BtnEliminarMarca;
        private Button BtnEditarMarca;
        private Label LblMarcaActual;
        private Label label3;
        private Label label1;
        private DataGridView DataGridMarcas;
    }
}