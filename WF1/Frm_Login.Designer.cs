namespace WF1
{
    partial class Frm_Login
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
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            this.Txt_login = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Login
            // 
            this.Pic_Login.Image = global::WF1.Properties.Resources.key;
            this.Pic_Login.Location = new System.Drawing.Point(13, 13);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(138, 111);
            this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Login.TabIndex = 0;
            this.Pic_Login.TabStop = false;
            // 
            // Txt_login
            // 
            this.Txt_login.Location = new System.Drawing.Point(171, 41);
            this.Txt_login.Name = "Txt_login";
            this.Txt_login.Size = new System.Drawing.Size(125, 20);
            this.Txt_login.TabIndex = 1;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(171, 89);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(125, 20);
            this.Txt_Senha.TabIndex = 2;
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(168, 25);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Login.TabIndex = 3;
            this.Lbl_Login.Text = "label1";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(168, 73);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Senha.TabIndex = 4;
            this.Lbl_Senha.Text = "label2";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(13, 140);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 27);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "button1";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(199, 140);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(97, 27);
            this.Btn_Ok.TabIndex = 6;
            this.Btn_Ok.Text = "button2";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 191);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_login);
            this.Controls.Add(this.Pic_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Login;
        private System.Windows.Forms.TextBox Txt_login;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Ok;
    }
}