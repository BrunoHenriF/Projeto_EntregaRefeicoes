
namespace ProjetoBancoDeDados
{
    partial class Form_CadastroPrato
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
            this.lbl_nomedoprato = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_codprato = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nomedoprato
            // 
            this.lbl_nomedoprato.AutoSize = true;
            this.lbl_nomedoprato.Location = new System.Drawing.Point(51, 58);
            this.lbl_nomedoprato.Name = "lbl_nomedoprato";
            this.lbl_nomedoprato.Size = new System.Drawing.Size(77, 13);
            this.lbl_nomedoprato.TabIndex = 0;
            this.lbl_nomedoprato.Text = "Nome do prato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_codprato
            // 
            this.lbl_codprato.AutoSize = true;
            this.lbl_codprato.Location = new System.Drawing.Point(51, 132);
            this.lbl_codprato.Name = "lbl_codprato";
            this.lbl_codprato.Size = new System.Drawing.Size(82, 13);
            this.lbl_codprato.TabIndex = 2;
            this.lbl_codprato.Text = "Código do prato";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(51, 199);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_preco.TabIndex = 4;
            this.lbl_preco.Text = "Preço";
            // 
            // Form_CadastroPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_codprato);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_nomedoprato);
            this.Name = "Form_CadastroPrato";
            this.Text = "Cadastre um prato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomedoprato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_codprato;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_preco;
    }
}