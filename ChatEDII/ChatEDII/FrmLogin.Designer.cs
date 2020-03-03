namespace ChatEDII
{
    partial class FrmLogin
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbnHombre = new System.Windows.Forms.RadioButton();
            this.rbnMujer = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // rbnHombre
            // 
            this.rbnHombre.AutoSize = true;
            this.rbnHombre.Location = new System.Drawing.Point(56, 42);
            this.rbnHombre.Name = "rbnHombre";
            this.rbnHombre.Size = new System.Drawing.Size(62, 17);
            this.rbnHombre.TabIndex = 2;
            this.rbnHombre.TabStop = true;
            this.rbnHombre.Text = "Hombre";
            this.rbnHombre.UseVisualStyleBackColor = true;
            // 
            // rbnMujer
            // 
            this.rbnMujer.AutoSize = true;
            this.rbnMujer.Location = new System.Drawing.Point(125, 42);
            this.rbnMujer.Name = "rbnMujer";
            this.rbnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbnMujer.TabIndex = 3;
            this.rbnMujer.TabStop = true;
            this.rbnMujer.Text = "Mujer";
            this.rbnMujer.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(84, 72);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 106);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.rbnMujer);
            this.Controls.Add(this.rbnHombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbnHombre;
        private System.Windows.Forms.RadioButton rbnMujer;
        private System.Windows.Forms.Button btnIngresar;
    }
}

