namespace WF1
{
    partial class Frm_HelloWorld
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_TrocarTexto = new System.Windows.Forms.Button();
            this.Txt_Conteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(61, 22);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Título";
            // 
            // Btn_TrocarTexto
            // 
            this.Btn_TrocarTexto.Location = new System.Drawing.Point(16, 70);
            this.Btn_TrocarTexto.Name = "Btn_TrocarTexto";
            this.Btn_TrocarTexto.Size = new System.Drawing.Size(134, 23);
            this.Btn_TrocarTexto.TabIndex = 1;
            this.Btn_TrocarTexto.Text = "Trocar Titulo";
            this.Btn_TrocarTexto.UseVisualStyleBackColor = true;
            this.Btn_TrocarTexto.Click += new System.EventHandler(this.Btn_TrocarTexto_Click);
            // 
            // Txt_Conteudo
            // 
            this.Txt_Conteudo.Location = new System.Drawing.Point(16, 38);
            this.Txt_Conteudo.Name = "Txt_Conteudo";
            this.Txt_Conteudo.Size = new System.Drawing.Size(169, 20);
            this.Txt_Conteudo.TabIndex = 2;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 258);
            this.Controls.Add(this.Txt_Conteudo);
            this.Controls.Add(this.Btn_TrocarTexto);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca Título";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_TrocarTexto;
        private System.Windows.Forms.TextBox Txt_Conteudo;
    }
}

