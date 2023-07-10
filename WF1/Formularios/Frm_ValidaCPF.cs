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
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Msk_InputCPF.Text = "";
            Lbl_ResultadoValidacao.Text = "";
        }
        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            string cpfDigitado = Msk_InputCPF.Text;
            bool valida = Cls_Uteis.Valida(cpfDigitado);

            if(valida == false)
            {
                Lbl_ResultadoValidacao.Text = "CPF INVÁLIDO";
                Lbl_ResultadoValidacao.ForeColor = Color.Red;
            }
            else
            {
                Lbl_ResultadoValidacao.Text = "CPF VÁLIDO";
                Lbl_ResultadoValidacao.ForeColor = Color.Green;
            }
        }
    }
}
