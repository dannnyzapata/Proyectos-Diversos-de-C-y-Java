namespace Ferreteria
{
    partial class Entrada
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
            this.rdEmpleados = new System.Windows.Forms.RadioButton();
            this.rdHerramientas = new System.Windows.Forms.RadioButton();
            this.rdPartes = new System.Windows.Forms.RadioButton();
            this.btEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdEmpleados
            // 
            this.rdEmpleados.AutoSize = true;
            this.rdEmpleados.Location = new System.Drawing.Point(25, 24);
            this.rdEmpleados.Name = "rdEmpleados";
            this.rdEmpleados.Size = new System.Drawing.Size(77, 17);
            this.rdEmpleados.TabIndex = 0;
            this.rdEmpleados.TabStop = true;
            this.rdEmpleados.Text = "Empleados";
            this.rdEmpleados.UseVisualStyleBackColor = true;
            // 
            // rdHerramientas
            // 
            this.rdHerramientas.AutoSize = true;
            this.rdHerramientas.Location = new System.Drawing.Point(108, 24);
            this.rdHerramientas.Name = "rdHerramientas";
            this.rdHerramientas.Size = new System.Drawing.Size(87, 17);
            this.rdHerramientas.TabIndex = 1;
            this.rdHerramientas.TabStop = true;
            this.rdHerramientas.Text = "Herramientas";
            this.rdHerramientas.UseVisualStyleBackColor = true;
            // 
            // rdPartes
            // 
            this.rdPartes.AutoSize = true;
            this.rdPartes.Location = new System.Drawing.Point(201, 24);
            this.rdPartes.Name = "rdPartes";
            this.rdPartes.Size = new System.Drawing.Size(55, 17);
            this.rdPartes.TabIndex = 2;
            this.rdPartes.TabStop = true;
            this.rdPartes.Text = "Partes";
            this.rdPartes.UseVisualStyleBackColor = true;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(108, 75);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // VistaAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.rdPartes);
            this.Controls.Add(this.rdHerramientas);
            this.Controls.Add(this.rdEmpleados);
            this.Name = "VistaAutos";
            this.Text = "VistaAutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdEmpleados;
        private System.Windows.Forms.RadioButton rdHerramientas;
        private System.Windows.Forms.RadioButton rdPartes;
        private System.Windows.Forms.Button btEnviar;
    }
}