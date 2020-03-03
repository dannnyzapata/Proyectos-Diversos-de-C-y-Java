namespace WindowsFormsApplication2
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
            this.rtxCaja = new System.Windows.Forms.RichTextBox();
            this.txtAbrir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.btCortar = new System.Windows.Forms.Button();
            this.btPegar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxCaja
            // 
            this.rtxCaja.Location = new System.Drawing.Point(13, 48);
            this.rtxCaja.Name = "rtxCaja";
            this.rtxCaja.Size = new System.Drawing.Size(786, 276);
            this.rtxCaja.TabIndex = 0;
            this.rtxCaja.Text = "";
            // 
            // txtAbrir
            // 
            this.txtAbrir.Location = new System.Drawing.Point(70, 13);
            this.txtAbrir.Name = "txtAbrir";
            this.txtAbrir.Size = new System.Drawing.Size(596, 20);
            this.txtAbrir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(672, 16);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(27, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "...";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(35, 330);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(101, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(142, 330);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(106, 23);
            this.btAbrir.TabIndex = 5;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(307, 329);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(75, 23);
            this.btCopiar.TabIndex = 6;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // btCortar
            // 
            this.btCortar.Location = new System.Drawing.Point(388, 330);
            this.btCortar.Name = "btCortar";
            this.btCortar.Size = new System.Drawing.Size(75, 23);
            this.btCortar.TabIndex = 7;
            this.btCortar.Text = "Cortar";
            this.btCortar.UseVisualStyleBackColor = true;
            this.btCortar.Click += new System.EventHandler(this.btCortar_Click);
            // 
            // btPegar
            // 
            this.btPegar.Location = new System.Drawing.Point(470, 329);
            this.btPegar.Name = "btPegar";
            this.btPegar.Size = new System.Drawing.Size(75, 23);
            this.btPegar.TabIndex = 8;
            this.btPegar.Text = "Pegar";
            this.btPegar.UseVisualStyleBackColor = true;
            this.btPegar.Click += new System.EventHandler(this.btPegar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 378);
            this.Controls.Add(this.btPegar);
            this.Controls.Add(this.btCortar);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAbrir);
            this.Controls.Add(this.rtxCaja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxCaja;
        private System.Windows.Forms.TextBox txtAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Button btCortar;
        private System.Windows.Forms.Button btPegar;
    }
}

