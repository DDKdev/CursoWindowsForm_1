namespace WF1
{
    partial class Frm_DemonstracaoKey_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Minuscula = new System.Windows.Forms.Label();
            this.Lbl_Maiuscula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_maius = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Txt_Tela = new System.Windows.Forms.TextBox();
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Minuscula
            // 
            this.Lbl_Minuscula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Minuscula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Minuscula.Location = new System.Drawing.Point(398, 150);
            this.Lbl_Minuscula.Name = "Lbl_Minuscula";
            this.Lbl_Minuscula.Size = new System.Drawing.Size(30, 30);
            this.Lbl_Minuscula.TabIndex = 13;
            this.Lbl_Minuscula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Maiuscula
            // 
            this.Lbl_Maiuscula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Maiuscula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Maiuscula.Location = new System.Drawing.Point(398, 87);
            this.Lbl_Maiuscula.Name = "Lbl_Maiuscula";
            this.Lbl_Maiuscula.Size = new System.Drawing.Size(30, 30);
            this.Lbl_Maiuscula.TabIndex = 12;
            this.Lbl_Maiuscula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "minúscula";
            // 
            // Lbl_maius
            // 
            this.Lbl_maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_maius.AutoSize = true;
            this.Lbl_maius.Location = new System.Drawing.Point(338, 96);
            this.Lbl_maius.Name = "Lbl_maius";
            this.Lbl_maius.Size = new System.Drawing.Size(54, 13);
            this.Lbl_maius.TabIndex = 10;
            this.Lbl_maius.Text = "maiúscula";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Limpar.Location = new System.Drawing.Point(341, 51);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(99, 20);
            this.Btn_Limpar.TabIndex = 9;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Txt_Tela
            // 
            this.Txt_Tela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Tela.Location = new System.Drawing.Point(34, 96);
            this.Txt_Tela.Multiline = true;
            this.Txt_Tela.Name = "Txt_Tela";
            this.Txt_Tela.Size = new System.Drawing.Size(287, 213);
            this.Txt_Tela.TabIndex = 8;
            // 
            // Txt_Input
            // 
            this.Txt_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Input.Location = new System.Drawing.Point(34, 51);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(287, 20);
            this.Txt_Input.TabIndex = 7;
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // Frm_DemonstracaoKey_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Minuscula);
            this.Controls.Add(this.Lbl_Maiuscula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_maius);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_Tela);
            this.Controls.Add(this.Txt_Input);
            this.Name = "Frm_DemonstracaoKey_UC";
            this.Size = new System.Drawing.Size(475, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Minuscula;
        private System.Windows.Forms.Label Lbl_Maiuscula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_maius;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.TextBox Txt_Tela;
        private System.Windows.Forms.TextBox Txt_Input;
    }
}
