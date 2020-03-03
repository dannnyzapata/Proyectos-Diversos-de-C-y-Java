namespace Ciudades
{
    partial class Form1
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
            this.dtgMuestra = new System.Windows.Forms.DataGridView();
            this.cPaises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCiudades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSeleccionar = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.txtContenidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMuestra
            // 
            this.dtgMuestra.AllowUserToAddRows = false;
            this.dtgMuestra.AllowUserToDeleteRows = false;
            this.dtgMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPaises,
            this.cEstados,
            this.cCiudades});
            this.dtgMuestra.Location = new System.Drawing.Point(4, 13);
            this.dtgMuestra.Name = "dtgMuestra";
            this.dtgMuestra.Size = new System.Drawing.Size(694, 195);
            this.dtgMuestra.TabIndex = 0;
            // 
            // cPaises
            // 
            this.cPaises.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPaises.HeaderText = "Paises";
            this.cPaises.Name = "cPaises";
            // 
            // cEstados
            // 
            this.cEstados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cEstados.HeaderText = "Estados";
            this.cEstados.Name = "cEstados";
            // 
            // cCiudades
            // 
            this.cCiudades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cCiudades.HeaderText = "Ciudades";
            this.cCiudades.Name = "cCiudades";
            // 
            // cbSeleccionar
            // 
            this.cbSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSeleccionar.FormattingEnabled = true;
            this.cbSeleccionar.Items.AddRange(new object[] {
            "Pais",
            "Estado",
            "Ciudad"});
            this.cbSeleccionar.Location = new System.Drawing.Point(27, 253);
            this.cbSeleccionar.Name = "cbSeleccionar";
            this.cbSeleccionar.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccionar.TabIndex = 1;
            // 
            // cbPais
            // 
            this.cbPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(210, 253);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 21);
            this.cbPais.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(396, 253);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 3;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(565, 236);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(565, 279);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 5;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            // 
            // txtContenidos
            // 
            this.txtContenidos.Location = new System.Drawing.Point(310, 292);
            this.txtContenidos.Name = "txtContenidos";
            this.txtContenidos.Size = new System.Drawing.Size(100, 20);
            this.txtContenidos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 340);
            this.Controls.Add(this.txtContenidos);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.cbSeleccionar);
            this.Controls.Add(this.dtgMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCiudades;
        private System.Windows.Forms.ComboBox cbSeleccionar;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.TextBox txtContenidos;
    }
}

