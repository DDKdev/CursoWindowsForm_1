using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Frm_UC : Form
    {
        public Frm_UC()
        {
            InitializeComponent();

            novoFormulárioToolStripMenuItem.Enabled = false;
            apagarAbaSelecionadaToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        int ControleK = 0;
        int ControleH = 0;
        int ControleM = 0;
        int ControleC1 = 0;
        int ControleC2 = 0;
        int ControleS = 0;
        int ControleC3 = 0;
        int ControleA = 0;



        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleK += 1;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Demonstração Key " + ControleK;
            TB.Text = "Demonstração Key " + ControleK;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mudarTítuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleH += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Hello World " + ControleH;
            TB.Text = "Hello World " + ControleH;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void máscarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleM += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Máscara " + ControleM;
            TB.Text = "Máscara " + ControleM;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validarCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleC1 += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Valida CPF " + ControleC1;
            TB.Text = "Valida CPF " + ControleC1;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validarCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleC2 += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Valida CPF 2 " + ControleC2;
            TB.Text = "Valida CPF 2 " + ControleC2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void forçaDaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleS += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Valida Senha " + ControleS;
            TB.Text = "Valida Senha " + ControleS;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaSelecionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void validaCPF3BoxDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleC3 += 1;
            Frm_ValidaCPF3_UC U = new Frm_ValidaCPF3_UC();
            TabPage TB = new TabPage();
            TB.Dock = DockStyle.Fill;
            TB.Name = "Valida Senha " + ControleC3;
            TB.Text = "Valida Senha " + ControleC3;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\dnl_3\\OneDrive\\Documentos\\ProjetosGitHub\\PrimeiroWF\\WF1\\imagens";
            Db.Title = "Escolha a imagem";
            Db.Filter = "PNG|*.PNG";

            if(Db.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = Db.FileName;

                ControleA += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(caminhoArquivo);
                TabPage TB = new TabPage();
                TB.Dock = DockStyle.Fill;
                TB.Name = "Imagem " + ControleA;
                TB.Text = "Imagem " + ControleA;
                TB.ImageIndex = 2;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();

            string login = f.login;
            string senha = f.senha;

            if(f.DialogResult == DialogResult.OK)
            {
                if (WF1Biblioteca.Cls_Uteis.ValidaSenhaLogin(senha) == true)
                {
                    novoFormulárioToolStripMenuItem.Enabled = true;
                    apagarAbaSelecionadaToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;

                    MessageBox.Show("Bem Vindo " + login + "!!!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha incorreta", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Q = new Frm_Questao("question", "Deseja mesmo desconectar-se?");
            Q.ShowDialog();

            if(Q.DialogResult == DialogResult.Yes)
            {
                for(int i = Tbc_Aplicacoes.TabPages.Count -1; i >= 0; i--)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoFormulárioToolStripMenuItem.Enabled = false;
                apagarAbaSelecionadaToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
