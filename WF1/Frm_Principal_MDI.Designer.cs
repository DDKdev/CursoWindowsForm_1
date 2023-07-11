namespace WF1
{
    partial class Frm_Principal_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaTítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.keyToolStripMenuItem,
            this.trocaTítuloToolStripMenuItem,
            this.máscarasToolStripMenuItem,
            this.validarCPFToolStripMenuItem,
            this.validarCPF2ToolStripMenuItem,
            this.validarSenhaToolStripMenuItem});
            this.novoFormulárioToolStripMenuItem.Name = "novoFormulárioToolStripMenuItem";
            this.novoFormulárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoFormulárioToolStripMenuItem.Text = "Novo formulário";
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_DemonstracaoKey;
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keyToolStripMenuItem.Text = "Key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // trocaTítuloToolStripMenuItem
            // 
            this.trocaTítuloToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_HelloWorld;
            this.trocaTítuloToolStripMenuItem.Name = "trocaTítuloToolStripMenuItem";
            this.trocaTítuloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.trocaTítuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocaTítuloToolStripMenuItem.Text = "Troca Título";
            this.trocaTítuloToolStripMenuItem.Click += new System.EventHandler(this.trocaTítuloToolStripMenuItem_Click);
            // 
            // máscarasToolStripMenuItem
            // 
            this.máscarasToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_Mascara;
            this.máscarasToolStripMenuItem.Name = "máscarasToolStripMenuItem";
            this.máscarasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.máscarasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.máscarasToolStripMenuItem.Text = "Máscaras";
            this.máscarasToolStripMenuItem.Click += new System.EventHandler(this.máscarasToolStripMenuItem_Click);
            // 
            // validarCPFToolStripMenuItem
            // 
            this.validarCPFToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_ValidaCPF;
            this.validarCPFToolStripMenuItem.Name = "validarCPFToolStripMenuItem";
            this.validarCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.validarCPFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarCPFToolStripMenuItem.Text = "Validar CPF";
            this.validarCPFToolStripMenuItem.Click += new System.EventHandler(this.validarCPFToolStripMenuItem_Click);
            // 
            // validarCPF2ToolStripMenuItem
            // 
            this.validarCPF2ToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_ValidaCPF2;
            this.validarCPF2ToolStripMenuItem.Name = "validarCPF2ToolStripMenuItem";
            this.validarCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.validarCPF2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarCPF2ToolStripMenuItem.Text = "Validar CPF 2";
            this.validarCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validarCPF2ToolStripMenuItem_Click);
            // 
            // validarSenhaToolStripMenuItem
            // 
            this.validarSenhaToolStripMenuItem.Image = global::WF1.Properties.Resources.Frm_ValidaSenha;
            this.validarSenhaToolStripMenuItem.Name = "validarSenhaToolStripMenuItem";
            this.validarSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.validarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarSenhaToolStripMenuItem.Text = "Validar Senha";
            this.validarSenhaToolStripMenuItem.Click += new System.EventHandler(this.validarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // Frm_Principal_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 367);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal_MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFormulárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocaTítuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}