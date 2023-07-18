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
    public partial class Frm_Login : Form
    {
        public string login;
        public string senha;
        public Frm_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Login";
            Lbl_Senha.Text = "Senha";
            Btn_Cancel.Text = "Cancel";
            Btn_Ok.Text = "OK";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            login = Txt_login.Text;
            senha = Txt_Senha.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
