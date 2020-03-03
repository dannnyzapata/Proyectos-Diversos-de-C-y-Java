namespace WindowsFormsApplication1
{
    partial class Chat
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
            this.rtxChat = new System.Windows.Forms.RichTextBox();
            this.rtxUsuario = new System.Windows.Forms.RichTextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxChat
            // 
            this.rtxChat.Enabled = false;
            this.rtxChat.Location = new System.Drawing.Point(13, 13);
            this.rtxChat.Name = "rtxChat";
            this.rtxChat.Size = new System.Drawing.Size(525, 397);
            this.rtxChat.TabIndex = 0;
            this.rtxChat.Text = "";
            // 
            // rtxUsuario
            // 
            this.rtxUsuario.Location = new System.Drawing.Point(13, 417);
            this.rtxUsuario.Name = "rtxUsuario";
            this.rtxUsuario.Size = new System.Drawing.Size(454, 60);
            this.rtxUsuario.TabIndex = 1;
            this.rtxUsuario.Text = "";
            this.rtxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtxUsuario_KeyPress);
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(474, 417);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(73, 60);
            this.btEnviar.TabIndex = 2;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 489);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.rtxUsuario);
            this.Controls.Add(this.rtxChat);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxChat;
        private System.Windows.Forms.RichTextBox rtxUsuario;
        private System.Windows.Forms.Button btEnviar;
    }
}

