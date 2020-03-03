namespace WindowsFormsApplication1
{
    partial class Login
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
            this.rdHombre = new System.Windows.Forms.RadioButton();
            this.rdMujer = new System.Windows.Forms.RadioButton();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.btEnviar = new System.Windows.Forms.Button();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdHombre
            // 
            this.rdHombre.AutoSize = true;
            this.rdHombre.Location = new System.Drawing.Point(12, 71);
            this.rdHombre.Name = "rdHombre";
            this.rdHombre.Size = new System.Drawing.Size(62, 17);
            this.rdHombre.TabIndex = 0;
            this.rdHombre.TabStop = true;
            this.rdHombre.Text = "Hombre";
            this.rdHombre.UseVisualStyleBackColor = true;
            // 
            // rdMujer
            // 
            this.rdMujer.AutoSize = true;
            this.rdMujer.Location = new System.Drawing.Point(90, 71);
            this.rdMujer.Name = "rdMujer";
            this.rdMujer.Size = new System.Drawing.Size(51, 17);
            this.rdMujer.TabIndex = 1;
            this.rdMujer.TabStop = true;
            this.rdMujer.Text = "Mujer";
            this.rdMujer.UseVisualStyleBackColor = true;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(156, 71);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(45, 17);
            this.rdOtro.TabIndex = 2;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(66, 96);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(12, 28);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(194, 20);
            this.txNombre.TabIndex = 4;
            this.txNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxNombre_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 131);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.rdOtro);
            this.Controls.Add(this.rdMujer);
            this.Controls.Add(this.rdHombre);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdHombre;
        private System.Windows.Forms.RadioButton rdMujer;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox txNombre;
    }
}