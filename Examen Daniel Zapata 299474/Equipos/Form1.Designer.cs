namespace Equipos
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
            this.txtG1 = new System.Windows.Forms.TextBox();
            this.txtG2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAgregarB = new System.Windows.Forms.Button();
            this.btAgregarR = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtG1
            // 
            this.txtG1.Location = new System.Drawing.Point(80, 89);
            this.txtG1.Name = "txtG1";
            this.txtG1.Size = new System.Drawing.Size(100, 20);
            this.txtG1.TabIndex = 0;
            this.txtG1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG1_KeyPress);
            // 
            // txtG2
            // 
            this.txtG2.Location = new System.Drawing.Point(240, 89);
            this.txtG2.Name = "txtG2";
            this.txtG2.Size = new System.Drawing.Size(100, 20);
            this.txtG2.TabIndex = 1;
            this.txtG2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(105, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(266, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupo 2";
            // 
            // btAgregarB
            // 
            this.btAgregarB.Location = new System.Drawing.Point(94, 129);
            this.btAgregarB.Name = "btAgregarB";
            this.btAgregarB.Size = new System.Drawing.Size(75, 23);
            this.btAgregarB.TabIndex = 4;
            this.btAgregarB.Text = "Agregar";
            this.btAgregarB.UseVisualStyleBackColor = true;
            this.btAgregarB.Click += new System.EventHandler(this.btAgregarB_Click);
            // 
            // btAgregarR
            // 
            this.btAgregarR.Location = new System.Drawing.Point(250, 128);
            this.btAgregarR.Name = "btAgregarR";
            this.btAgregarR.Size = new System.Drawing.Size(75, 23);
            this.btAgregarR.TabIndex = 5;
            this.btAgregarR.Text = "Agregar";
            this.btAgregarR.UseVisualStyleBackColor = true;
            this.btAgregarR.Click += new System.EventHandler(this.btAgregarR_Click);
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(172, 200);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 6;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 345);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.btAgregarR);
            this.Controls.Add(this.btAgregarB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtG2);
            this.Controls.Add(this.txtG1);
            this.Name = "Form1";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtG1;
        private System.Windows.Forms.TextBox txtG2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAgregarB;
        private System.Windows.Forms.Button btAgregarR;
        private System.Windows.Forms.Button btCrear;
    }
}

