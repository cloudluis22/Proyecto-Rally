namespace CarrosRally
{
    partial class FormVerCorredores
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
            this.DataGridCorredores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCorredorActual = new System.Windows.Forms.Label();
            this.BtnEditarCorredor = new System.Windows.Forms.Button();
            this.BtnEliminarCorredor = new System.Windows.Forms.Button();
            this.BtnActualizarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorredores)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCorredores
            // 
            this.DataGridCorredores.AllowUserToAddRows = false;
            this.DataGridCorredores.AllowUserToDeleteRows = false;
            this.DataGridCorredores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCorredores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridCorredores.Location = new System.Drawing.Point(12, 82);
            this.DataGridCorredores.Name = "DataGridCorredores";
            this.DataGridCorredores.ReadOnly = true;
            this.DataGridCorredores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridCorredores.RowTemplate.Height = 25;
            this.DataGridCorredores.Size = new System.Drawing.Size(511, 292);
            this.DataGridCorredores.TabIndex = 0;
            this.DataGridCorredores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCorredores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizador de Corredores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(586, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Corredor Seleccionado";
            // 
            // LblCorredorActual
            // 
            this.LblCorredorActual.AutoSize = true;
            this.LblCorredorActual.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCorredorActual.Location = new System.Drawing.Point(586, 83);
            this.LblCorredorActual.Name = "LblCorredorActual";
            this.LblCorredorActual.Size = new System.Drawing.Size(108, 23);
            this.LblCorredorActual.TabIndex = 6;
            this.LblCorredorActual.Text = "*corredor*";
            this.LblCorredorActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEditarCorredor
            // 
            this.BtnEditarCorredor.Enabled = false;
            this.BtnEditarCorredor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarCorredor.Location = new System.Drawing.Point(586, 145);
            this.BtnEditarCorredor.Name = "BtnEditarCorredor";
            this.BtnEditarCorredor.Size = new System.Drawing.Size(203, 38);
            this.BtnEditarCorredor.TabIndex = 7;
            this.BtnEditarCorredor.Text = "Editar Corredor";
            this.BtnEditarCorredor.UseVisualStyleBackColor = true;
            this.BtnEditarCorredor.Click += new System.EventHandler(this.BtnEditarCorredor_Click);
            // 
            // BtnEliminarCorredor
            // 
            this.BtnEliminarCorredor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarCorredor.Location = new System.Drawing.Point(586, 204);
            this.BtnEliminarCorredor.Name = "BtnEliminarCorredor";
            this.BtnEliminarCorredor.Size = new System.Drawing.Size(203, 38);
            this.BtnEliminarCorredor.TabIndex = 8;
            this.BtnEliminarCorredor.Text = "Eliminar Corredor";
            this.BtnEliminarCorredor.UseVisualStyleBackColor = true;
            this.BtnEliminarCorredor.Click += new System.EventHandler(this.BtnEliminarCorredor_Click);
            // 
            // BtnActualizarDatos
            // 
            this.BtnActualizarDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnActualizarDatos.Location = new System.Drawing.Point(586, 265);
            this.BtnActualizarDatos.Name = "BtnActualizarDatos";
            this.BtnActualizarDatos.Size = new System.Drawing.Size(203, 38);
            this.BtnActualizarDatos.TabIndex = 9;
            this.BtnActualizarDatos.Text = "Actualizar Datos";
            this.BtnActualizarDatos.UseVisualStyleBackColor = true;
            // 
            // FormVerCorredores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(836, 430);
            this.Controls.Add(this.BtnActualizarDatos);
            this.Controls.Add(this.BtnEliminarCorredor);
            this.Controls.Add(this.BtnEditarCorredor);
            this.Controls.Add(this.LblCorredorActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridCorredores);
            this.Name = "FormVerCorredores";
            this.Text = "Visualizador de Corredores";
            this.Load += new System.EventHandler(this.FormVerCorredores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorredores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridCorredores;
        private Label label1;
        private Label label3;
        private Label LblCorredorActual;
        private Button BtnEditarCorredor;
        private Button BtnEliminarCorredor;
        private Button BtnActualizarDatos;
    }
}