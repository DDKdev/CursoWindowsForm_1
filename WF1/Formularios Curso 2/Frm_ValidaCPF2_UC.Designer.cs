namespace WF1
{
    partial class Frm_ValidaCPF2_UC
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
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Msk_InputCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Validar.Location = new System.Drawing.Point(217, 55);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Validar.TabIndex = 5;
            this.Btn_Validar.Text = "Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Limpar.Location = new System.Drawing.Point(217, 26);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Msk_InputCPF
            // 
            this.Msk_InputCPF.Location = new System.Drawing.Point(29, 30);
            this.Msk_InputCPF.Mask = "000,000,000-00";
            this.Msk_InputCPF.Name = "Msk_InputCPF";
            this.Msk_InputCPF.Size = new System.Drawing.Size(160, 20);
            this.Msk_InputCPF.TabIndex = 3;
            // 
            // Frm_ValidaCPF2_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Msk_InputCPF);
            this.Name = "Frm_ValidaCPF2_UC";
            this.Size = new System.Drawing.Size(325, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Validar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.MaskedTextBox Msk_InputCPF;
    }
}
