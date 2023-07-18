namespace WF1
{
    partial class Frm_ValidaCPF_UC
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
            this.Lbl_ResultadoValidacao = new System.Windows.Forms.Label();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Msk_InputCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lbl_ResultadoValidacao
            // 
            this.Lbl_ResultadoValidacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_ResultadoValidacao.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultadoValidacao.Location = new System.Drawing.Point(23, 123);
            this.Lbl_ResultadoValidacao.Name = "Lbl_ResultadoValidacao";
            this.Lbl_ResultadoValidacao.Size = new System.Drawing.Size(160, 23);
            this.Lbl_ResultadoValidacao.TabIndex = 7;
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Validar.Location = new System.Drawing.Point(211, 53);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Validar.TabIndex = 6;
            this.Btn_Validar.Text = "Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Limpar.Location = new System.Drawing.Point(211, 24);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 5;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Msk_InputCPF
            // 
            this.Msk_InputCPF.Location = new System.Drawing.Point(23, 28);
            this.Msk_InputCPF.Mask = "000,000,000-00";
            this.Msk_InputCPF.Name = "Msk_InputCPF";
            this.Msk_InputCPF.Size = new System.Drawing.Size(160, 20);
            this.Msk_InputCPF.TabIndex = 4;
            // 
            // Frm_ValidaCPF_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_ResultadoValidacao);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Msk_InputCPF);
            this.Name = "Frm_ValidaCPF_UC";
            this.Size = new System.Drawing.Size(325, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ResultadoValidacao;
        private System.Windows.Forms.Button Btn_Validar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.MaskedTextBox Msk_InputCPF;
    }
}
