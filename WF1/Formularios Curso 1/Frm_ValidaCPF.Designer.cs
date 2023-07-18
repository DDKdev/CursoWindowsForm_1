namespace WF1
{
    partial class Frm_ValidaCPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaCPF));
            this.Msk_InputCPF = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.Lbl_ResultadoValidacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Msk_InputCPF
            // 
            this.Msk_InputCPF.Location = new System.Drawing.Point(33, 28);
            this.Msk_InputCPF.Mask = "000,000,000-00";
            this.Msk_InputCPF.Name = "Msk_InputCPF";
            this.Msk_InputCPF.Size = new System.Drawing.Size(160, 20);
            this.Msk_InputCPF.TabIndex = 0;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Limpar.Location = new System.Drawing.Point(221, 24);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 1;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Validar.Location = new System.Drawing.Point(221, 53);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Validar.TabIndex = 2;
            this.Btn_Validar.Text = "Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Lbl_ResultadoValidacao
            // 
            this.Lbl_ResultadoValidacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_ResultadoValidacao.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultadoValidacao.Location = new System.Drawing.Point(33, 123);
            this.Lbl_ResultadoValidacao.Name = "Lbl_ResultadoValidacao";
            this.Lbl_ResultadoValidacao.Size = new System.Drawing.Size(160, 23);
            this.Lbl_ResultadoValidacao.TabIndex = 3;
            // 
            // Frm_ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 178);
            this.Controls.Add(this.Lbl_ResultadoValidacao);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Msk_InputCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ValidaCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ValidaCPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_InputCPF;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Validar;
        private System.Windows.Forms.Label Lbl_ResultadoValidacao;
    }
}