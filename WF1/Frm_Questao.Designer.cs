namespace WF1
{
    partial class Frm_Questao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pic_pergunta = new System.Windows.Forms.PictureBox();
            this.Lbl_Pergunta = new System.Windows.Forms.Label();
            this.Btn_Nao = new System.Windows.Forms.Button();
            this.Btn_Sim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pergunta)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_pergunta
            // 
            this.Pic_pergunta.Image = global::WF1.Properties.Resources.question;
            this.Pic_pergunta.Location = new System.Drawing.Point(27, 77);
            this.Pic_pergunta.Name = "Pic_pergunta";
            this.Pic_pergunta.Size = new System.Drawing.Size(123, 108);
            this.Pic_pergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_pergunta.TabIndex = 7;
            this.Pic_pergunta.TabStop = false;
            // 
            // Lbl_Pergunta
            // 
            this.Lbl_Pergunta.AutoSize = true;
            this.Lbl_Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pergunta.Location = new System.Drawing.Point(40, 20);
            this.Lbl_Pergunta.Name = "Lbl_Pergunta";
            this.Lbl_Pergunta.Size = new System.Drawing.Size(210, 18);
            this.Lbl_Pergunta.TabIndex = 6;
            this.Lbl_Pergunta.Text = "Deseja mesmo validar o CPF?";
            // 
            // Btn_Nao
            // 
            this.Btn_Nao.Location = new System.Drawing.Point(175, 128);
            this.Btn_Nao.Name = "Btn_Nao";
            this.Btn_Nao.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nao.TabIndex = 5;
            this.Btn_Nao.Text = "Não";
            this.Btn_Nao.UseVisualStyleBackColor = true;
            this.Btn_Nao.Click += new System.EventHandler(this.Btn_Nao_Click);
            // 
            // Btn_Sim
            // 
            this.Btn_Sim.Location = new System.Drawing.Point(175, 86);
            this.Btn_Sim.Name = "Btn_Sim";
            this.Btn_Sim.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sim.TabIndex = 4;
            this.Btn_Sim.Text = "Sim";
            this.Btn_Sim.UseVisualStyleBackColor = true;
            this.Btn_Sim.Click += new System.EventHandler(this.Btn_Sim_Click);
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 198);
            this.Controls.Add(this.Pic_pergunta);
            this.Controls.Add(this.Lbl_Pergunta);
            this.Controls.Add(this.Btn_Nao);
            this.Controls.Add(this.Btn_Sim);
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Questao";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pergunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_pergunta;
        private System.Windows.Forms.Label Lbl_Pergunta;
        private System.Windows.Forms.Button Btn_Nao;
        private System.Windows.Forms.Button Btn_Sim;
    }
}