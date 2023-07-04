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

namespace WF1
{
    public partial class Frm_ValidaSenha : Form
    {
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }


            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
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
            ChecaForcaSenha checaSenha = new ChecaForcaSenha();
            string senha = Txt_Senha.Text;
            ChecaForcaSenha.ForcaDaSenha checado = checaSenha.GetForcaDaSenha(senha);

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
