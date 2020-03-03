namespace Cementerio
{
    partial class FrmLotes
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
            this.TxtNomenclatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTitular = new System.Windows.Forms.TextBox();
            this.TxtBeneficiario1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBeneficiario2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBeneficiario3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChkPagado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLugar1 = new System.Windows.Forms.TextBox();
            this.TxtLugar2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLugar4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLugar3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(788, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(25, 17);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomenclatura";
            // 
            // TxtNomenclatura
            // 
            this.TxtNomenclatura.Location = new System.Drawing.Point(123, 44);
            this.TxtNomenclatura.MaxLength = 10;
            this.TxtNomenclatura.Name = "TxtNomenclatura";
            this.TxtNomenclatura.Size = new System.Drawing.Size(103, 22);
            this.TxtNomenclatura.TabIndex = 2;
            this.TxtNomenclatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomenclatura_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacidad";
            // 
            // NudCapacidad
            // 
            this.NudCapacidad.Enabled = false;
            this.NudCapacidad.Location = new System.Drawing.Point(123, 80);
            this.NudCapacidad.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCapacidad.Name = "NudCapacidad";
            this.NudCapacidad.Size = new System.Drawing.Size(36, 22);
            this.NudCapacidad.TabIndex = 4;
            this.NudCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titular";
            // 
            // TxtTitular
            // 
            this.TxtTitular.Location = new System.Drawing.Point(123, 116);
            this.TxtTitular.Name = "TxtTitular";
            this.TxtTitular.ReadOnly = true;
            this.TxtTitular.Size = new System.Drawing.Size(357, 22);
            this.TxtTitular.TabIndex = 6;
            // 
            // TxtBeneficiario1
            // 
            this.TxtBeneficiario1.Location = new System.Drawing.Point(123, 155);
            this.TxtBeneficiario1.Name = "TxtBeneficiario1";
            this.TxtBeneficiario1.ReadOnly = true;
            this.TxtBeneficiario1.Size = new System.Drawing.Size(357, 22);
            this.TxtBeneficiario1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beneficiario 1";
            // 
            // TxtBeneficiario2
            // 
            this.TxtBeneficiario2.Location = new System.Drawing.Point(123, 193);
            this.TxtBeneficiario2.Name = "TxtBeneficiario2";
            this.TxtBeneficiario2.ReadOnly = true;
            this.TxtBeneficiario2.Size = new System.Drawing.Size(357, 22);
            this.TxtBeneficiario2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beneficiario 2";
            // 
            // TxtBeneficiario3
            // 
            this.TxtBeneficiario3.Location = new System.Drawing.Point(123, 231);
            this.TxtBeneficiario3.Name = "TxtBeneficiario3";
            this.TxtBeneficiario3.ReadOnly = true;
            this.TxtBeneficiario3.Size = new System.Drawing.Size(357, 22);
            this.TxtBeneficiario3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Beneficiario 3";
            // 
            // ChkPagado
            // 
            this.ChkPagado.AutoSize = true;
            this.ChkPagado.Enabled = false;
            this.ChkPagado.Location = new System.Drawing.Point(232, 274);
            this.ChkPagado.Name = "ChkPagado";
            this.ChkPagado.Size = new System.Drawing.Size(79, 21);
            this.ChkPagado.TabIndex = 13;
            this.ChkPagado.Text = "Pagado";
            this.ChkPagado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lugar 1";
            // 
            // TxtLugar1
            // 
            this.TxtLugar1.Location = new System.Drawing.Point(33, 391);
            this.TxtLugar1.Name = "TxtLugar1";
            this.TxtLugar1.ReadOnly = true;
            this.TxtLugar1.Size = new System.Drawing.Size(357, 22);
            this.TxtLugar1.TabIndex = 15;
            // 
            // TxtLugar2
            // 
            this.TxtLugar2.Location = new System.Drawing.Point(456, 391);
            this.TxtLugar2.Name = "TxtLugar2";
            this.TxtLugar2.ReadOnly = true;
            this.TxtLugar2.Size = new System.Drawing.Size(357, 22);
            this.TxtLugar2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lugar 2";
            // 
            // TxtLugar4
            // 
            this.TxtLugar4.Location = new System.Drawing.Point(456, 462);
            this.TxtLugar4.Name = "TxtLugar4";
            this.TxtLugar4.ReadOnly = true;
            this.TxtLugar4.Size = new System.Drawing.Size(357, 22);
            this.TxtLugar4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Lugar 4";
            // 
            // TxtLugar3
            // 
            this.TxtLugar3.Location = new System.Drawing.Point(33, 462);
            this.TxtLugar3.Name = "TxtLugar3";
            this.TxtLugar3.ReadOnly = true;
            this.TxtLugar3.Size = new System.Drawing.Size(357, 22);
            this.TxtLugar3.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lugar 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-35, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1240, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "_________________________________________________________________________________" +
    "_________________________________________________________________________";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Location = new System.Drawing.Point(643, 155);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 58);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 506);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtLugar4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtLugar3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtLugar2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtLugar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChkPagado);
            this.Controls.Add(this.TxtBeneficiario3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBeneficiario2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBeneficiario1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTitular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomenclatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblID);
            this.Name = "FrmLotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cementerio";
            ((System.ComponentModel.ISupportInitialize)(this.NudCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomenclatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudCapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTitular;
        private System.Windows.Forms.TextBox TxtBeneficiario1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBeneficiario2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBeneficiario3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkPagado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLugar1;
        private System.Windows.Forms.TextBox TxtLugar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLugar4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLugar3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnGuardar;
    }
}

