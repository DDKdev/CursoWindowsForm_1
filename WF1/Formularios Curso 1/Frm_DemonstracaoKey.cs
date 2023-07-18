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
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Tela.AppendText(e.KeyCode.ToString() + "\r\n");
            Lbl_Maiuscula.Text = e.KeyCode.ToString().ToUpper();
            Lbl_Minuscula.Text = e.KeyCode.ToString().ToLower();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Tela.Text = "";
            Txt_Input.Text = "";
            Lbl_Maiuscula.Text = "";
            Lbl_Minuscula.Text = "";
        }
    }
}
