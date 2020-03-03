namespace WindowsFormsApplication1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vuelos");
            this.Aviones = new System.Windows.Forms.TreeView();
            this.Pasajero = new System.Windows.Forms.Button();
            this.documentar = new System.Windows.Forms.Button();
            this.Regreso = new System.Windows.Forms.Button();
            this.subir = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Aviones
            // 
            this.Aviones.Location = new System.Drawing.Point(27, 29);
            this.Aviones.Name = "Aviones";
            treeNode1.Name = "Vuelos";
            treeNode1.Text = "Vuelos";
            this.Aviones.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.Aviones.Size = new System.Drawing.Size(184, 342);
            this.Aviones.TabIndex = 0;
            this.Aviones.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Aviones_AfterSelect);
            // 
            // Pasajero
            // 
            this.Pasajero.Location = new System.Drawing.Point(244, 99);
            this.Pasajero.Name = "Pasajero";
            this.Pasajero.Size = new System.Drawing.Size(122, 31);
            this.Pasajero.TabIndex = 1;
            this.Pasajero.Text = "Agregar Pasajero";
            this.Pasajero.UseVisualStyleBackColor = true;
            this.Pasajero.Click += new System.EventHandler(this.Pasajero_Click);
            // 
            // documentar
            // 
            this.documentar.Location = new System.Drawing.Point(392, 99);
            this.documentar.Name = "documentar";
            this.documentar.Size = new System.Drawing.Size(116, 30);
            this.documentar.TabIndex = 2;
            this.documentar.Text = "Documentar";
            this.documentar.UseVisualStyleBackColor = true;
            this.documentar.Click += new System.EventHandler(this.documentar_Click);
            // 
            // Regreso
            // 
            this.Regreso.Location = new System.Drawing.Point(244, 179);
            this.Regreso.Name = "Regreso";
            this.Regreso.Size = new System.Drawing.Size(122, 30);
            this.Regreso.TabIndex = 3;
            this.Regreso.Text = "Vuelo de Regreso";
            this.Regreso.UseVisualStyleBackColor = true;
            this.Regreso.Click += new System.EventHandler(this.Regreso_Click);
            // 
            // subir
            // 
            this.subir.Location = new System.Drawing.Point(392, 179);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(116, 30);
            this.subir.TabIndex = 4;
            this.subir.Text = "Subir de Clase";
            this.subir.UseVisualStyleBackColor = true;
            this.subir.Click += new System.EventHandler(this.subir_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(244, 73);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 20);
            this.nombre.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 402);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.subir);
            this.Controls.Add(this.Regreso);
            this.Controls.Add(this.documentar);
            this.Controls.Add(this.Pasajero);
            this.Controls.Add(this.Aviones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Aviones;
        private System.Windows.Forms.Button Pasajero;
        private System.Windows.Forms.Button documentar;
        private System.Windows.Forms.Button Regreso;
        private System.Windows.Forms.Button subir;
        private System.Windows.Forms.TextBox nombre;
    }
}

