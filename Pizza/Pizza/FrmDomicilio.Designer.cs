namespace Pizza
{
    partial class FrmDomicilio
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
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarPizza = new System.Windows.Forms.Button();
            this.txtPizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtReferencias = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btBuscarDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(448, 7);
            this.LblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(21, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(82, 27);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(273, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(358, 27);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 19);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // BtnBuscarPizza
            // 
            this.BtnBuscarPizza.Location = new System.Drawing.Point(358, 59);
            this.BtnBuscarPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscarPizza.Name = "BtnBuscarPizza";
            this.BtnBuscarPizza.Size = new System.Drawing.Size(26, 19);
            this.BtnBuscarPizza.TabIndex = 6;
            this.BtnBuscarPizza.Text = "...";
            this.BtnBuscarPizza.UseVisualStyleBackColor = true;
            this.BtnBuscarPizza.Click += new System.EventHandler(this.BtnBuscarPizza_Click);
            // 
            // txtPizza
            // 
            this.txtPizza.Location = new System.Drawing.Point(82, 59);
            this.txtPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPizza.Name = "txtPizza";
            this.txtPizza.ReadOnly = true;
            this.txtPizza.Size = new System.Drawing.Size(273, 20);
            this.txtPizza.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pizza:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(82, 234);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Mask = "(###)###-##-##";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(78, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtReferencias
            // 
            this.txtReferencias.Location = new System.Drawing.Point(82, 205);
            this.txtReferencias.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferencias.Name = "txtReferencias";
            this.txtReferencias.ReadOnly = true;
            this.txtReferencias.Size = new System.Drawing.Size(235, 20);
            this.txtReferencias.TabIndex = 25;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(82, 175);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.Size = new System.Drawing.Size(68, 20);
            this.txtCP.TabIndex = 24;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(82, 146);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(2);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ReadOnly = true;
            this.txtColonia.Size = new System.Drawing.Size(157, 20);
            this.txtColonia.TabIndex = 23;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(82, 117);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(68, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(82, 88);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.ReadOnly = true;
            this.txtCalle.Size = new System.Drawing.Size(157, 20);
            this.txtCalle.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Referencias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "C.P.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Colonia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Calle:";
            // 
            // btBuscarDireccion
            // 
            this.btBuscarDireccion.Location = new System.Drawing.Point(244, 86);
            this.btBuscarDireccion.Name = "btBuscarDireccion";
            this.btBuscarDireccion.Size = new System.Drawing.Size(34, 23);
            this.btBuscarDireccion.TabIndex = 27;
            this.btBuscarDireccion.Text = "...";
            this.btBuscarDireccion.UseVisualStyleBackColor = true;
            this.btBuscarDireccion.Click += new System.EventHandler(this.btBuscarDireccion_Click);
            // 
            // FrmDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 362);
            this.Controls.Add(this.btBuscarDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtReferencias);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscarPizza);
            this.Controls.Add(this.txtPizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDomicilio";
            this.Text = "Entregas a Domicilio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button BtnBuscarPizza;
        private System.Windows.Forms.TextBox txtPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtReferencias;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btBuscarDireccion;
    }
}