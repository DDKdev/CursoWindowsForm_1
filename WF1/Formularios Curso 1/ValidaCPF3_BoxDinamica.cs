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
    public partial class ValidaCPF3_BoxDinamica : Form
    {
        public ValidaCPF3_BoxDinamica()
        {
            InitializeComponent();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Msk_InputCPF.Text = "";
        }

        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            string cpfDigitado = Msk_InputCPF.Text;
            string cpfTratado = cpfDigitado.Replace(".", "").Replace("-", "");
            cpfTratado = cpfTratado.Trim();

            if ((cpfTratado == "") || (cpfTratado.Length != 11))
            {
                MessageBox.Show("O CPF deve conter 11 dígitos", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_Questao Db = new Frm_Questao("question", "deseja MESMO validar o CPF?");
                Db.ShowDialog();
                if (Db.DialogResult == DialogResult.Yes)
                {
                    bool resultado = Cls_Uteis.Valida(cpfDigitado);

                    if (resultado == false)
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
    }
}
