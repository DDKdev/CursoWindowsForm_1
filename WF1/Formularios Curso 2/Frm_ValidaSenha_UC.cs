using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF1Biblioteca;

namespace WF1
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Uteis.ChecaForcaSenha checaSenha = new Cls_Uteis.ChecaForcaSenha();
            string senha = Txt_Senha.Text;
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha checado = checaSenha.GetForcaDaSenha(senha);

            if ((checado.ToString() == "Inaceitavel") || (checado.ToString() == "Fraca"))
            {
                Lbl_Status.Text = checado.ToString();
                Lbl_Status.ForeColor = Color.Red;
            }

            if (checado.ToString() == "Aceitavel")
            {
                Lbl_Status.Text = checado.ToString();
                Lbl_Status.ForeColor = Color.Blue;
            }

            if ((checado.ToString() == "Forte") || (checado.ToString() == "Segura"))
            {
                Lbl_Status.Text = checado.ToString();
                Lbl_Status.ForeColor = Color.Green;
            }
        }

        bool VisaoSenha = false;
        private void Btn_Limpar_Click_1(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Status.Text = "";
        }

        private void Btn_VerSenha_Click_1(object sender, EventArgs e)
        {
            if (VisaoSenha == false)
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_VerSenha.Text = "Ocultar Senha";
                VisaoSenha = true;
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                Btn_VerSenha.Text = "Ver Senha";
                VisaoSenha = false;
            }
        }
    }
}
