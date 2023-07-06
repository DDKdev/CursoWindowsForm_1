namespace WF1
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.Txt_Tela = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Lbl_maius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Maiuscula = new System.Windows.Forms.Label();
            this.Lbl_Minuscula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(29, 38);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(287, 20);
            this.Txt_Input.TabIndex = 0;
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // Txt_Tela
            // 
            this.Txt_Tela.Location = new System.Drawing.Point(29, 83);
            this.Txt_Tela.Multiline = true;
            this.Txt_Tela.Name = "Txt_Tela";
            this.Txt_Tela.Size = new System.Drawing.Size(287, 213);
            this.Txt_Tela.TabIndex = 1;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(360, 38);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 2;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Lbl_maius
            // 
            this.Lbl_maius.AutoSize = true;
            this.Lbl_maius.Location = new System.Drawing.Point(333, 83);
            this.Lbl_maius.Name = "Lbl_maius";
            this.Lbl_maius.Size = new System.Drawing.Size(54, 13);
            this.Lbl_maius.TabIndex = 3;
            this.Lbl_maius.Text = "maiúscula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "minúscula";
            // 
            // Lbl_Maiuscula
            // 
            this.Lbl_Maiuscula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Maiuscula.Location = new System.Drawing.Point(393, 74);
            this.Lbl_Maiuscula.Name = "Lbl_Maiuscula";
            this.Lbl_Maiuscula.Size = new System.Drawing.Size(30, 30);
            this.Lbl_Maiuscula.TabIndex = 5;
            this.Lbl_Maiuscula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Minuscula
            // 
            this.Lbl_Minuscula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Minuscula.Location = new System.Drawing.Point(393, 137);
            this.Lbl_Minuscula.Name = "Lbl_Minuscula";
            this.Lbl_Minuscula.Size = new System.Drawing.Size(30, 30);
            this.Lbl_Minuscula.TabIndex = 6;
            this.Lbl_Minuscula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 326);
            this.Controls.Add(this.Lbl_Minuscula);
            this.Controls.Add(this.Lbl_Maiuscula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_maius);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_Tela);
            this.Controls.Add(this.Txt_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DemonstracaoKey";
            this.Text = "Frm_DemonstracaoKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.TextBox Txt_Tela;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label Lbl_maius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Maiuscula;
        private System.Windows.Forms.Label Lbl_Minuscula;
    }
}