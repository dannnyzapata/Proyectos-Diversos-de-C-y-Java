namespace Teams
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbxGrupo1 = new System.Windows.Forms.ListBox();
            this.lbxGrupo2 = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtEquipoG1 = new System.Windows.Forms.TextBox();
            this.btnAgregarG1 = new System.Windows.Forms.Button();
            this.btnAgregarG2 = new System.Windows.Forms.Button();
            this.txtEquipoG2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo 2";
            // 
            // lbxGrupo1
            // 
            this.lbxGrupo1.FormattingEnabled = true;
            this.lbxGrupo1.Location = new System.Drawing.Point(35, 47);
            this.lbxGrupo1.Name = "lbxGrupo1";
            this.lbxGrupo1.Size = new System.Drawing.Size(203, 251);
            this.lbxGrupo1.TabIndex = 2;
            // 
            // lbxGrupo2
            // 
            this.lbxGrupo2.FormattingEnabled = true;
            this.lbxGrupo2.Location = new System.Drawing.Point(285, 47);
            this.lbxGrupo2.Name = "lbxGrupo2";
            this.lbxGrupo2.Size = new System.Drawing.Size(203, 251);
            this.lbxGrupo2.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(209, 343);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Horarios";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtEquipoG1
            // 
            this.txtEquipoG1.Location = new System.Drawing.Point(35, 303);
            this.txtEquipoG1.Name = "txtEquipoG1";
            this.txtEquipoG1.Size = new System.Drawing.Size(164, 20);
            this.txtEquipoG1.TabIndex = 5;
            // 
            // btnAgregarG1
            // 
            this.btnAgregarG1.Location = new System.Drawing.Point(205, 302);
            this.btnAgregarG1.Name = "btnAgregarG1";
            this.btnAgregarG1.Size = new System.Drawing.Size(33, 23);
            this.btnAgregarG1.TabIndex = 6;
            this.btnAgregarG1.Text = "+";
            this.btnAgregarG1.UseVisualStyleBackColor = true;
            this.btnAgregarG1.Click += new System.EventHandler(this.btnAgregarG1_Click);
            // 
            // btnAgregarG2
            // 
            this.btnAgregarG2.Location = new System.Drawing.Point(455, 302);
            this.btnAgregarG2.Name = "btnAgregarG2";
            this.btnAgregarG2.Size = new System.Drawing.Size(33, 23);
            this.btnAgregarG2.TabIndex = 8;
            this.btnAgregarG2.Text = "+";
            this.btnAgregarG2.UseVisualStyleBackColor = true;
            this.btnAgregarG2.Click += new System.EventHandler(this.btnAgregarG2_Click);
            // 
            // txtEquipoG2
            // 
            this.txtEquipoG2.Location = new System.Drawing.Point(285, 303);
            this.txtEquipoG2.Name = "txtEquipoG2";
            this.txtEquipoG2.Size = new System.Drawing.Size(164, 20);
            this.txtEquipoG2.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 374);
            this.Controls.Add(this.btnAgregarG2);
            this.Controls.Add(this.txtEquipoG2);
            this.Controls.Add(this.btnAgregarG1);
            this.Controls.Add(this.txtEquipoG1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lbxGrupo2);
            this.Controls.Add(this.lbxGrupo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxGrupo1;
        private System.Windows.Forms.ListBox lbxGrupo2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtEquipoG1;
        private System.Windows.Forms.Button btnAgregarG1;
        private System.Windows.Forms.Button btnAgregarG2;
        private System.Windows.Forms.TextBox txtEquipoG2;
    }
}

