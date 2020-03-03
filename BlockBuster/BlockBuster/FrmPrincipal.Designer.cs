namespace BlockBuster
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbnPelicula = new System.Windows.Forms.RadioButton();
            this.rbnVideoJuego = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDirDes = new System.Windows.Forms.Label();
            this.txtDirDes = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // rbnPelicula
            // 
            this.rbnPelicula.AutoSize = true;
            this.rbnPelicula.Checked = true;
            this.rbnPelicula.Location = new System.Drawing.Point(50, 18);
            this.rbnPelicula.Name = "rbnPelicula";
            this.rbnPelicula.Size = new System.Drawing.Size(62, 17);
            this.rbnPelicula.TabIndex = 1;
            this.rbnPelicula.TabStop = true;
            this.rbnPelicula.Text = "Pelicula";
            this.rbnPelicula.UseVisualStyleBackColor = true;
            this.rbnPelicula.CheckedChanged += new System.EventHandler(this.rbnPelicula_CheckedChanged);
            // 
            // rbnVideoJuego
            // 
            this.rbnVideoJuego.AutoSize = true;
            this.rbnVideoJuego.Location = new System.Drawing.Point(139, 18);
            this.rbnVideoJuego.Name = "rbnVideoJuego";
            this.rbnVideoJuego.Size = new System.Drawing.Size(84, 17);
            this.rbnVideoJuego.TabIndex = 2;
            this.rbnVideoJuego.Text = "Video Juego";
            this.rbnVideoJuego.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(97, 82);
            this.nudAnio.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(61, 20);
            this.nudAnio.TabIndex = 4;
            this.nudAnio.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // LblDirDes
            // 
            this.LblDirDes.Location = new System.Drawing.Point(12, 121);
            this.LblDirDes.Name = "LblDirDes";
            this.LblDirDes.Size = new System.Drawing.Size(80, 17);
            this.LblDirDes.TabIndex = 6;
            this.LblDirDes.Text = "Director";
            this.LblDirDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirDes
            // 
            this.txtDirDes.Location = new System.Drawing.Point(97, 118);
            this.txtDirDes.Name = "txtDirDes";
            this.txtDirDes.Size = new System.Drawing.Size(126, 20);
            this.txtDirDes.TabIndex = 7;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Terror",
            "Suspenso",
            "Accion",
            "Comedia",
            "Drama"});
            this.cmbGenero.Location = new System.Drawing.Point(97, 156);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(126, 21);
            this.cmbGenero.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genero";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(50, 197);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(148, 197);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(246, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(662, 437);
            this.dgvDatos.TabIndex = 12;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(97, 238);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(85, 23);
            this.btCargar.TabIndex = 13;
            this.btCargar.Text = "Cargar Tabla";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 461);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtDirDes);
            this.Controls.Add(this.LblDirDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.rbnVideoJuego);
            this.Controls.Add(this.rbnPelicula);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnPelicula;
        private System.Windows.Forms.RadioButton rbnVideoJuego;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDirDes;
        private System.Windows.Forms.TextBox txtDirDes;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btCargar;
    }
}

