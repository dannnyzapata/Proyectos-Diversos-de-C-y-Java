namespace ArbolLetras
{
    partial class FrmArbol
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Inicio");
            this.TvArbol = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLetra = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TvArbol
            // 
            this.TvArbol.Location = new System.Drawing.Point(2, 40);
            this.TvArbol.Name = "TvArbol";
            treeNode1.Name = "NdInicio";
            treeNode1.Text = "Inicio";
            this.TvArbol.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TvArbol.Size = new System.Drawing.Size(436, 375);
            this.TvArbol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insertar:";
            // 
            // TxtLetra
            // 
            this.TxtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLetra.Location = new System.Drawing.Point(63, 11);
            this.TxtLetra.MaxLength = 1;
            this.TxtLetra.Name = "TxtLetra";
            this.TxtLetra.Size = new System.Drawing.Size(21, 20);
            this.TxtLetra.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(90, 9);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(54, 23);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(150, 9);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(54, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 415);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtLetra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TvArbol);
            this.Name = "FrmArbol";
            this.Text = "Arbol de Letras";
            this.Load += new System.EventHandler(this.FrmArbol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TvArbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLetra;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}

