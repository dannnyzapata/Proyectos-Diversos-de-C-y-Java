namespace MATRicularas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgMatriculas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btBuscarM = new System.Windows.Forms.Button();
            this.btBorrarS = new System.Windows.Forms.Button();
            this.btBorrarM = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.cMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMatriculaBus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMatriculas
            // 
            this.dtgMatriculas.AllowUserToAddRows = false;
            this.dtgMatriculas.AllowUserToDeleteRows = false;
            this.dtgMatriculas.AllowUserToOrderColumns = true;
            this.dtgMatriculas.AllowUserToResizeRows = false;
            this.dtgMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMatricula,
            this.cNombre,
            this.cApellidoP,
            this.cApellidoM,
            this.cTelefono});
            this.dtgMatriculas.Location = new System.Drawing.Point(12, 12);
            this.dtgMatriculas.Name = "dtgMatriculas";
            this.dtgMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMatriculas.Size = new System.Drawing.Size(630, 252);
            this.dtgMatriculas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula: ";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(12, 316);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatricula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 316);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(270, 316);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Paterno: ";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(395, 316);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoM.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Materno: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(520, 316);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de Telefono:";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(16, 367);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // btBuscarM
            // 
            this.btBuscarM.Location = new System.Drawing.Point(205, 367);
            this.btBuscarM.Name = "btBuscarM";
            this.btBuscarM.Size = new System.Drawing.Size(112, 23);
            this.btBuscarM.TabIndex = 12;
            this.btBuscarM.Text = "Buscar por Matricula";
            this.btBuscarM.UseVisualStyleBackColor = true;
            this.btBuscarM.Click += new System.EventHandler(this.BtBuscarM_Click);
            // 
            // btBorrarS
            // 
            this.btBorrarS.Location = new System.Drawing.Point(109, 366);
            this.btBorrarS.Name = "btBorrarS";
            this.btBorrarS.Size = new System.Drawing.Size(75, 23);
            this.btBorrarS.TabIndex = 13;
            this.btBorrarS.Text = "Borrar";
            this.btBorrarS.UseVisualStyleBackColor = true;
            this.btBorrarS.Click += new System.EventHandler(this.BtBorrarS_Click);
            // 
            // btBorrarM
            // 
            this.btBorrarM.Location = new System.Drawing.Point(340, 366);
            this.btBorrarM.Name = "btBorrarM";
            this.btBorrarM.Size = new System.Drawing.Size(124, 23);
            this.btBorrarM.TabIndex = 14;
            this.btBorrarM.Text = "Borrar por Matricula";
            this.btBorrarM.UseVisualStyleBackColor = true;
            this.btBorrarM.Click += new System.EventHandler(this.BtBorrarM_Click);
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(482, 366);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(75, 23);
            this.btExportar.TabIndex = 15;
            this.btExportar.Text = "Exportar";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.BtExportar_Click);
            // 
            // cMatricula
            // 
            this.cMatricula.HeaderText = "Matricula";
            this.cMatricula.Name = "cMatricula";
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            // 
            // cApellidoP
            // 
            this.cApellidoP.HeaderText = "Apellido Paterno";
            this.cApellidoP.Name = "cApellidoP";
            // 
            // cApellidoM
            // 
            this.cApellidoM.HeaderText = "Apellido Materno";
            this.cApellidoM.Name = "cApellidoM";
            // 
            // cTelefono
            // 
            this.cTelefono.HeaderText = "Telefono";
            this.cTelefono.Name = "cTelefono";
            // 
            // txtMatriculaBus
            // 
            this.txtMatriculaBus.Location = new System.Drawing.Point(270, 396);
            this.txtMatriculaBus.Name = "txtMatriculaBus";
            this.txtMatriculaBus.Size = new System.Drawing.Size(100, 20);
            this.txtMatriculaBus.TabIndex = 16;
            this.txtMatriculaBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatriculaBus_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Matricula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatriculaBus);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btBorrarM);
            this.Controls.Add(this.btBorrarS);
            this.Controls.Add(this.btBuscarM);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMatriculas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMatriculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btBuscarM;
        private System.Windows.Forms.Button btBorrarS;
        private System.Windows.Forms.Button btBorrarM;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefono;
        private System.Windows.Forms.TextBox txtMatriculaBus;
        private System.Windows.Forms.Label label6;
    }
}

