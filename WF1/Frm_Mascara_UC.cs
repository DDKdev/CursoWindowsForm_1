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
    public partial class Frm_Mascara_UC : UserControl
    {
        public Frm_Mascara_UC()
        {
            InitializeComponent();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_Input.UseSystemPasswordChar = false;
            Lbl_VerConteudo.Text = "";
            Msk_Input.Text = "";
            Msk_Input.Focus();
            Msk_Input.Mask = "00:00";
            Lbl_ModeloMascara.Text = Msk_Input.Mask;
        }

        private void Btn_Cep_Click(object sender, EventArgs e)
        {
            Msk_Input.UseSystemPasswordChar = false;
            Lbl_VerConteudo.Text = "";
            Msk_Input.Text = "";
            Msk_Input.Focus();
            Msk_Input.Mask = "00000-000";
            Lbl_ModeloMascara.Text = Msk_Input.Mask;
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_Input.UseSystemPasswordChar = false;
            Lbl_VerConteudo.Text = "";
            Msk_Input.Text = "";
            Msk_Input.Focus();
            Msk_Input.Mask = "000,000,000.00";
            Lbl_ModeloMascara.Text = Msk_Input.Mask;
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_Input.UseSystemPasswordChar = false;
            Lbl_VerConteudo.Text = "";
            Msk_Input.Text = "";
            Msk_Input.Focus();
            Msk_Input.Mask = "00/00/0000";
            Lbl_ModeloMascara.Text = Msk_Input.Mask;
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_Input.UseSystemPasswordChar = true;
            Lbl_VerConteudo.Text = "";
            Msk_Input.Text = "";
            Msk_Input.Focus();
            Msk_Input.Mask = "000000";
            Lbl_ModeloMascara.Text = Msk_Input.Mask;
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_Input.UseSystemPasswordChar = false;
            Lbl_VerConteudo.Text = "";
            Msk_Input.Text = "";
            Msk_Input.Focus();
            Msk_Input.Mask = "(00) 0 0000 0000";
            Lbl_ModeloMascara.Text = Msk_Input.Mask;
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_VerConteudo.Text = Msk_Input.Text;
        }
    }
}
