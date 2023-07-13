namespace WF1
{
    partial class Frm_UC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarTítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forçaDaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.Img_List = new System.Windows.Forms.ImageList(this.components);
            this.apagarAbaSelecionadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.apagarAbaSelecionadaToolStripMenuItem,
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.ImageList = this.Img_List;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(574, 286);
            this.Tbc_Aplicacoes.TabIndex = 7;
            // 
            // Img_List
            // 
            this.Img_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_List.ImageStream")));
            this.Img_List.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_List.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.Img_List.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.Img_List.Images.SetKeyName(2, "Frm_Mascara.png");
            this.Img_List.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.Img_List.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.Img_List.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            // 
            // apagarAbaSelecionadaToolStripMenuItem
            // 
            this.apagarAbaSelecionadaToolStripMenuItem.Name = "apagarAbaSelecionadaToolStripMenuItem";
            this.apagarAbaSelecionadaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.apagarAbaSelecionadaToolStripMenuItem.Text = "Apagar Aba Selecionada";
            this.apagarAbaSelecionadaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaSelecionadaToolStripMenuItem_Click);
            // 
            // Frm_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 310);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_UC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ImageList Img_List;
        private System.Windows.Forms.ToolStripMenuItem apagarAbaSelecionadaToolStripMenuItem;
    }
}