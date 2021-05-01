
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_codprato = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nomedoprato
            // 
            this.lbl_nomedoprato.AutoSize = true;
            this.lbl_nomedoprato.Location = new System.Drawing.Point(76, 80);
            this.lbl_nomedoprato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomedoprato.Name = "lbl_nomedoprato";
            this.lbl_nomedoprato.Size = new System.Drawing.Size(122, 18);
            this.lbl_nomedoprato.TabIndex = 0;
            this.lbl_nomedoprato.Text = "Nome do prato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 249);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 26);
            this.textBox3.TabIndex = 5;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(76, 227);
            this.lbl_preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(50, 18);
            this.lbl_preco.TabIndex = 4;
            this.lbl_preco.Text = "Preço";
            // 
            // lbl_codprato
            // 
            this.lbl_codprato.AutoSize = true;
            this.lbl_codprato.Location = new System.Drawing.Point(76, 155);
            this.lbl_codprato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codprato.Name = "lbl_codprato";
            this.lbl_codprato.Size = new System.Drawing.Size(161, 18);
            this.lbl_codprato.TabIndex = 2;
            this.lbl_codprato.Text = "CNPJ do restaurante";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 321);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(313, 26);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição do prato";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 394);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(313, 26);
            this.textBox5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código do prato";
            // 
            // Form_CadastroPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 623);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_codprato);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_nomedoprato);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_CadastroPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre um prato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomedoprato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_codprato;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
    }
}