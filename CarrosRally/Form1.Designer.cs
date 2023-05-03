namespace CarrosRally
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregarCorredor = new System.Windows.Forms.Button();
            this.BtnAgregarMarca = new System.Windows.Forms.Button();
            this.BtnVerCorredores = new System.Windows.Forms.Button();
            this.BtnVerMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarrosRally.Properties.Resources.dirt;
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Corredores";
            // 
            // BtnAgregarCorredor
            // 
            this.BtnAgregarCorredor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarCorredor.Location = new System.Drawing.Point(114, 233);
            this.BtnAgregarCorredor.Name = "BtnAgregarCorredor";
            this.BtnAgregarCorredor.Size = new System.Drawing.Size(203, 38);
            this.BtnAgregarCorredor.TabIndex = 2;
            this.BtnAgregarCorredor.Text = "Agregar Corredor";
            this.BtnAgregarCorredor.UseVisualStyleBackColor = true;
            this.BtnAgregarCorredor.Click += new System.EventHandler(this.BtnAgregarCorredor_Click);
            // 
            // BtnAgregarMarca
            // 
            this.BtnAgregarMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarMarca.Location = new System.Drawing.Point(114, 277);
            this.BtnAgregarMarca.Name = "BtnAgregarMarca";
            this.BtnAgregarMarca.Size = new System.Drawing.Size(203, 38);
            this.BtnAgregarMarca.TabIndex = 3;
            this.BtnAgregarMarca.Text = "Agregar Marca";
            this.BtnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // BtnVerCorredores
            // 
            this.BtnVerCorredores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVerCorredores.Location = new System.Drawing.Point(114, 352);
            this.BtnVerCorredores.Name = "BtnVerCorredores";
            this.BtnVerCorredores.Size = new System.Drawing.Size(203, 38);
            this.BtnVerCorredores.TabIndex = 4;
            this.BtnVerCorredores.Text = "Ver Corredores";
            this.BtnVerCorredores.UseVisualStyleBackColor = true;
            // 
            // BtnVerMarcas
            // 
            this.BtnVerMarcas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVerMarcas.Location = new System.Drawing.Point(114, 396);
            this.BtnVerMarcas.Name = "BtnVerMarcas";
            this.BtnVerMarcas.Size = new System.Drawing.Size(203, 38);
            this.BtnVerMarcas.TabIndex = 5;
            this.BtnVerMarcas.Text = "Ver Marcas";
            this.BtnVerMarcas.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(423, 499);
            this.Controls.Add(this.BtnVerMarcas);
            this.Controls.Add(this.BtnVerCorredores);
            this.Controls.Add(this.BtnAgregarMarca);
            this.Controls.Add(this.BtnAgregarCorredor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnAgregarCorredor;
        private Button BtnAgregarMarca;
        private Button BtnVerCorredores;
        private Button BtnVerMarcas;
    }
}