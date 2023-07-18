namespace WF1
{
    partial class Frm_Mascara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mascara));
            this.Msk_Input = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_ModeloMascara = new System.Windows.Forms.Label();
            this.Lbl_VerConteudo = new System.Windows.Forms.Label();
            this.Btn_Hora = new System.Windows.Forms.Button();
            this.Btn_Cep = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_VerConteudo = new System.Windows.Forms.Button();
            this.Btn_Telefone = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Moeda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_Input
            // 
            this.Msk_Input.Location = new System.Drawing.Point(29, 24);
            this.Msk_Input.Mask = "(99) 9 9999 9999";
            this.Msk_Input.Name = "Msk_Input";
            this.Msk_Input.Size = new System.Drawing.Size(258, 20);
            this.Msk_Input.TabIndex = 0;
            // 
            // Lbl_ModeloMascara
            // 
            this.Lbl_ModeloMascara.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ModeloMascara.Location = new System.Drawing.Point(33, 59);
            this.Lbl_ModeloMascara.Name = "Lbl_ModeloMascara";
            this.Lbl_ModeloMascara.Size = new System.Drawing.Size(254, 29);
            this.Lbl_ModeloMascara.TabIndex = 1;
            this.Lbl_ModeloMascara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_VerConteudo
            // 
            this.Lbl_VerConteudo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_VerConteudo.Location = new System.Drawing.Point(156, 188);
            this.Lbl_VerConteudo.Name = "Lbl_VerConteudo";
            this.Lbl_VerConteudo.Size = new System.Drawing.Size(131, 40);
            this.Lbl_VerConteudo.TabIndex = 2;
            this.Lbl_VerConteudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Hora
            // 
            this.Btn_Hora.Location = new System.Drawing.Point(26, 91);
            this.Btn_Hora.Name = "Btn_Hora";
            this.Btn_Hora.Size = new System.Drawing.Size(83, 40);
            this.Btn_Hora.TabIndex = 3;
            this.Btn_Hora.Text = "Hora";
            this.Btn_Hora.UseVisualStyleBackColor = true;
            this.Btn_Hora.Click += new System.EventHandler(this.Btn_Hora_Click);
            // 
            // Btn_Cep
            // 
            this.Btn_Cep.Location = new System.Drawing.Point(115, 91);
            this.Btn_Cep.Name = "Btn_Cep";
            this.Btn_Cep.Size = new System.Drawing.Size(83, 40);
            this.Btn_Cep.TabIndex = 4;
            this.Btn_Cep.Text = "CEP";
            this.Btn_Cep.UseVisualStyleBackColor = true;
            this.Btn_Cep.Click += new System.EventHandler(this.Btn_Cep_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Location = new System.Drawing.Point(115, 137);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(83, 40);
            this.Btn_Senha.TabIndex = 5;
            this.Btn_Senha.Text = "Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_VerConteudo
            // 
            this.Btn_VerConteudo.Location = new System.Drawing.Point(26, 188);
            this.Btn_VerConteudo.Name = "Btn_VerConteudo";
            this.Btn_VerConteudo.Size = new System.Drawing.Size(112, 40);
            this.Btn_VerConteudo.TabIndex = 6;
            this.Btn_VerConteudo.Text = "Ver Conteúdo";
            this.Btn_VerConteudo.UseVisualStyleBackColor = true;
            this.Btn_VerConteudo.Click += new System.EventHandler(this.Btn_VerConteudo_Click);
            // 
            // Btn_Telefone
            // 
            this.Btn_Telefone.Location = new System.Drawing.Point(204, 137);
            this.Btn_Telefone.Name = "Btn_Telefone";
            this.Btn_Telefone.Size = new System.Drawing.Size(83, 40);
            this.Btn_Telefone.TabIndex = 7;
            this.Btn_Telefone.Text = "Telefone";
            this.Btn_Telefone.UseVisualStyleBackColor = true;
            this.Btn_Telefone.Click += new System.EventHandler(this.Btn_Telefone_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Location = new System.Drawing.Point(26, 137);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(83, 40);
            this.Btn_Data.TabIndex = 8;
            this.Btn_Data.Text = "Data";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Moeda
            // 
            this.Btn_Moeda.Location = new System.Drawing.Point(204, 91);
            this.Btn_Moeda.Name = "Btn_Moeda";
            this.Btn_Moeda.Size = new System.Drawing.Size(83, 40);
            this.Btn_Moeda.TabIndex = 9;
            this.Btn_Moeda.Text = "Moeda";
            this.Btn_Moeda.UseVisualStyleBackColor = true;
            this.Btn_Moeda.Click += new System.EventHandler(this.Btn_Moeda_Click);
            // 
            // Frm_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 255);
            this.Controls.Add(this.Btn_Moeda);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Telefone);
            this.Controls.Add(this.Btn_VerConteudo);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_Cep);
            this.Controls.Add(this.Btn_Hora);
            this.Controls.Add(this.Lbl_VerConteudo);
            this.Controls.Add(this.Lbl_ModeloMascara);
            this.Controls.Add(this.Msk_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Mascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Mascara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_Input;
        private System.Windows.Forms.Label Lbl_ModeloMascara;
        private System.Windows.Forms.Label Lbl_VerConteudo;
        private System.Windows.Forms.Button Btn_Hora;
        private System.Windows.Forms.Button Btn_Cep;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_VerConteudo;
        private System.Windows.Forms.Button Btn_Telefone;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Moeda;
    }
}