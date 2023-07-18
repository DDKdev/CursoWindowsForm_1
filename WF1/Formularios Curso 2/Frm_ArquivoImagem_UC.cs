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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string caminhoArquivo)
        {
            InitializeComponent();
            Lbl_caminhoImagem.Text = caminhoArquivo;
            Pic_Imagem.Image = Image.FromFile(caminhoArquivo);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog Cdb = new ColorDialog();
            if(Cdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_caminhoImagem.ForeColor = Cdb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog Fdb = new FontDialog();
            if (Fdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_caminhoImagem.Font = Fdb.Font;
            }
        }
    }
}
