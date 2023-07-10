namespace WF1
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_DemonstracaoKey = new System.Windows.Forms.Button();
            this.Btn_MudaTitulo = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarTítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forçaDaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_DemonstracaoKey
            // 
            this.Btn_DemonstracaoKey.Image = global::WF1.Properties.Resources.Frm_DemonstracaoKey;
            this.Btn_DemonstracaoKey.Location = new System.Drawing.Point(47, 64);
            this.Btn_DemonstracaoKey.Name = "Btn_DemonstracaoKey";
            this.Btn_DemonstracaoKey.Size = new System.Drawing.Size(133, 70);
            this.Btn_DemonstracaoKey.TabIndex = 0;
            this.Btn_DemonstracaoKey.Text = "DemonstrcaoKey";
            this.Btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            this.Btn_DemonstracaoKey.Click += new System.EventHandler(this.Btn_DemonstracaoKey_Click);
            // 
            // Btn_MudaTitulo
            // 
            this.Btn_MudaTitulo.Image = global::WF1.Properties.Resources.Frm_HelloWorld;
            this.Btn_MudaTitulo.Location = new System.Drawing.Point(206, 64);
            this.Btn_MudaTitulo.Name = "Btn_MudaTitulo";
            this.Btn_MudaTitulo.Size = new System.Drawing.Size(133, 70);
            this.Btn_MudaTitulo.TabIndex = 1;
            this.Btn_MudaTitulo.Text = "Muda Título";
            this.Btn_MudaTitulo.UseVisualStyleBackColor = true;
            this.Btn_MudaTitulo.Click += new System.EventHandler(this.Btn_MudaTitulo_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Image = global::WF1.Properties.Resources.Frm_Mascara;
            this.Btn_Mascara.Location = new System.Drawing.Point(374, 64);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(133, 70);
            this.Btn_Mascara.TabIndex = 2;
            this.Btn_Mascara.Text = "Máscara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Image = global::WF1.Properties.Resources.Frm_ValidaSenha;
            this.Btn_Senha.Location = new System.Drawing.Point(374, 160);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(133, 70);
            this.Btn_Senha.TabIndex = 5;
            this.Btn_Senha.Text = "Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_ValidaCPF2
            // 
            this.Btn_ValidaCPF2.Image = global::WF1.Properties.Resources.Frm_ValidaCPF2;
            this.Btn_ValidaCPF2.Location = new System.Drawing.Point(206, 160);
            this.Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            this.Btn_ValidaCPF2.Size = new System.Drawing.Size(133, 70);
            this.Btn_ValidaCPF2.TabIndex = 4;
            this.Btn_ValidaCPF2.Text = "Valida CPF 2";
            this.Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF2.Click += new System.EventHandler(this.Btn_ValidaCPF2_Click);
            // 
            // Btn_ValidaCPF
            // 
            this.Btn_ValidaCPF.Image = global::WF1.Properties.Resources.Frm_ValidaCPF;
            this.Btn_ValidaCPF.Location = new System.Drawing.Point(47, 160);
            this.Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            this.Btn_ValidaCPF.Size = new System.Drawing.Size(133, 70);
            this.Btn_ValidaCPF.TabIndex = 3;
            this.Btn_ValidaCPF.Text = "Valida CPF";
            this.Btn_ValidaCPF.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF.Click += new System.EventHandler(this.Btn_ValidaCPF_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFormulárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoFormulárioToolStripMenuItem
            // 
            this.novoFormulárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.mudarTítuloToolStripMenuItem,
            this.máscarasToolStripMenuItem,
            this.validarCPFToolStripMenuItem,
            this.validarCPF2ToolStripMenuItem,
            this.forçaDaSenhaToolStripMenuItem});
            this.novoFormulárioToolStripMenuItem.Name = "novoFormulárioToolStripMenuItem";
            this.novoFormulárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoFormulárioToolStripMenuItem.Text = "Novo Formulário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_DemonstracaoKey;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // mudarTítuloToolStripMenuItem
            // 
            this.mudarTítuloToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_HelloWorld;
            this.mudarTítuloToolStripMenuItem.Name = "mudarTítuloToolStripMenuItem";
            this.mudarTítuloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.mudarTítuloToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mudarTítuloToolStripMenuItem.Text = "Mudar Título";
            this.mudarTítuloToolStripMenuItem.Click += new System.EventHandler(this.mudarTítuloToolStripMenuItem_Click);
            // 
            // máscarasToolStripMenuItem
            // 
            this.máscarasToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_Mascara;
            this.máscarasToolStripMenuItem.Name = "máscarasToolStripMenuItem";
            this.máscarasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.máscarasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.máscarasToolStripMenuItem.Text = "Máscaras";
            this.máscarasToolStripMenuItem.Click += new System.EventHandler(this.máscarasToolStripMenuItem_Click);
            // 
            // validarCPFToolStripMenuItem
            // 
            this.validarCPFToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_ValidaCPF;
            this.validarCPFToolStripMenuItem.Name = "validarCPFToolStripMenuItem";
            this.validarCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.validarCPFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.validarCPFToolStripMenuItem.Text = "Validar CPF";
            this.validarCPFToolStripMenuItem.Click += new System.EventHandler(this.validarCPFToolStripMenuItem_Click);
            // 
            // validarCPF2ToolStripMenuItem
            // 
            this.validarCPF2ToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_ValidaCPF2;
            this.validarCPF2ToolStripMenuItem.Name = "validarCPF2ToolStripMenuItem";
            this.validarCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.validarCPF2ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.validarCPF2ToolStripMenuItem.Text = "Validar CPF 2";
            this.validarCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validarCPF2ToolStripMenuItem_Click);
            // 
            // forçaDaSenhaToolStripMenuItem
            // 
            this.forçaDaSenhaToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_ValidaSenha;
            this.forçaDaSenhaToolStripMenuItem.Name = "forçaDaSenhaToolStripMenuItem";
            this.forçaDaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.forçaDaSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.forçaDaSenhaToolStripMenuItem.Text = "Força da Senha";
            this.forçaDaSenhaToolStripMenuItem.Click += new System.EventHandler(this.forçaDaSenhaToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 310);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_ValidaCPF2);
            this.Controls.Add(this.Btn_ValidaCPF);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_MudaTitulo);
            this.Controls.Add(this.Btn_DemonstracaoKey);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_DemonstracaoKey;
        private System.Windows.Forms.Button Btn_MudaTitulo;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_ValidaCPF2;
        private System.Windows.Forms.Button Btn_ValidaCPF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFormulárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarTítuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forçaDaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}