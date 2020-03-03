namespace Vuelos
{
    partial class FrmVuelos
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
            this.tvVuelos = new System.Windows.Forms.TreeView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIda = new System.Windows.Forms.ComboBox();
            this.cmbVuelta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkRedondo = new System.Windows.Forms.CheckBox();
            this.nudMano = new System.Windows.Forms.NumericUpDown();
            this.nudDocumentada = new System.Windows.Forms.NumericUpDown();
            this.nudAsiento = new System.Windows.Forms.NumericUpDown();
            this.nudLlegada = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDocumentada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAsiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLlegada)).BeginInit();
            this.SuspendLayout();
            // 
            // tvVuelos
            // 
            this.tvVuelos.Location = new System.Drawing.Point(256, 12);
            this.tvVuelos.Name = "tvVuelos";
            this.tvVuelos.Size = new System.Drawing.Size(231, 296);
            this.tvVuelos.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // cmbIda
            // 
            this.cmbIda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIda.FormattingEnabled = true;
            this.cmbIda.Items.AddRange(new object[] {
            "CUU-CUN",
            "CUU-MTY",
            "CUU-GDL"});
            this.cmbIda.Location = new System.Drawing.Point(73, 53);
            this.cmbIda.Name = "cmbIda";
            this.cmbIda.Size = new System.Drawing.Size(168, 21);
            this.cmbIda.TabIndex = 3;
            this.cmbIda.SelectedIndexChanged += new System.EventHandler(this.cmbIda_SelectedIndexChanged);
            // 
            // cmbVuelta
            // 
            this.cmbVuelta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVuelta.FormattingEnabled = true;
            this.cmbVuelta.Items.AddRange(new object[] {
            "CUN-CUU",
            "MTY-CUU",
            "GDL-CUU"});
            this.cmbVuelta.Location = new System.Drawing.Point(73, 89);
            this.cmbVuelta.Name = "cmbVuelta";
            this.cmbVuelta.Size = new System.Drawing.Size(168, 21);
            this.cmbVuelta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vuelta:";
            // 
            // ChkRedondo
            // 
            this.ChkRedondo.AutoSize = true;
            this.ChkRedondo.Checked = true;
            this.ChkRedondo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRedondo.Location = new System.Drawing.Point(92, 131);
            this.ChkRedondo.Name = "ChkRedondo";
            this.ChkRedondo.Size = new System.Drawing.Size(100, 17);
            this.ChkRedondo.TabIndex = 7;
            this.ChkRedondo.Text = "Vuelo Redondo";
            this.ChkRedondo.UseVisualStyleBackColor = true;
            this.ChkRedondo.CheckedChanged += new System.EventHandler(this.ChkRedondo_CheckedChanged);
            // 
            // nudMano
            // 
            this.nudMano.Location = new System.Drawing.Point(160, 163);
            this.nudMano.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMano.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMano.Name = "nudMano";
            this.nudMano.Size = new System.Drawing.Size(49, 20);
            this.nudMano.TabIndex = 8;
            this.nudMano.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMano.ValueChanged += new System.EventHandler(this.nudMano_ValueChanged);
            // 
            // nudDocumentada
            // 
            this.nudDocumentada.Location = new System.Drawing.Point(160, 189);
            this.nudDocumentada.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDocumentada.Name = "nudDocumentada";
            this.nudDocumentada.Size = new System.Drawing.Size(49, 20);
            this.nudDocumentada.TabIndex = 9;
            this.nudDocumentada.ValueChanged += new System.EventHandler(this.nudDocumentada_ValueChanged);
            // 
            // nudAsiento
            // 
            this.nudAsiento.Location = new System.Drawing.Point(160, 215);
            this.nudAsiento.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAsiento.Name = "nudAsiento";
            this.nudAsiento.Size = new System.Drawing.Size(49, 20);
            this.nudAsiento.TabIndex = 10;
            // 
            // nudLlegada
            // 
            this.nudLlegada.Location = new System.Drawing.Point(160, 241);
            this.nudLlegada.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLlegada.Name = "nudLlegada";
            this.nudLlegada.Size = new System.Drawing.Size(49, 20);
            this.nudLlegada.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maleta de Mano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maleta Documentada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selección de Asiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Seguro de Llegada:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(54, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 24);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // FrmVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 320);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudLlegada);
            this.Controls.Add(this.nudAsiento);
            this.Controls.Add(this.nudDocumentada);
            this.Controls.Add(this.nudMano);
            this.Controls.Add(this.ChkRedondo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVuelta);
            this.Controls.Add(this.cmbIda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.tvVuelos);
            this.Name = "FrmVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.FrmVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDocumentada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAsiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLlegada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvVuelos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIda;
        private System.Windows.Forms.ComboBox cmbVuelta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkRedondo;
        private System.Windows.Forms.NumericUpDown nudMano;
        private System.Windows.Forms.NumericUpDown nudDocumentada;
        private System.Windows.Forms.NumericUpDown nudAsiento;
        private System.Windows.Forms.NumericUpDown nudLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
    }
}

