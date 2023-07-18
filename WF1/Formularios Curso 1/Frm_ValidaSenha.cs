using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF1Biblioteca;

namespace WF1
{
    public partial class Frm_ValidaSenha : Form
    {
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }
        
        public void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            //curso
            //ChecaForcaSenha valida = new ChecaForcaSenha();
            //ChecaForcaSenha.ForcaDaSenha forca;
            //forca = valida.GetForcaDaSenha(Txt_Senha.Text);
            //Lbl_Status.Text = forca.ToString();

            //instanciamos a classe ChecaforcaSenha;
            //armazenamos cada tecla digitada na string senha
            // o método da classe retorna um estado do tipo ForcaDaSenha por isso o ChecaForcaSenha.ForcaDaSenha checado
            // por fim atribuimos ao LBL o status gerado, convertendo-o para string.
            Cls_Uteis.ChecaForcaSenha checaSenha = new Cls_Uteis.ChecaForcaSenha();
            string senha = Txt_Senha.Text;
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha checado = checaSenha.GetForcaDaSenha(senha);

            if((checado.ToString() == "Inaceitavel") || (checado.ToString() == "Fraca"))
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
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Status.Text = "";
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if(VisaoSenha == false)
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
