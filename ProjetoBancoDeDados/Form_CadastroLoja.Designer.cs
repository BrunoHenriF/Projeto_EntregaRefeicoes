
namespace ProjetoBancoDeDados
{
    partial class Form_CadastroLoja
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
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.lbl_nomeoficial = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_nomefantasia = new System.Windows.Forms.Label();
            this.txt_nomefantasia = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(76, 216);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(60, 13);
            this.lbl_endereco.TabIndex = 10;
            this.lbl_endereco.Text = "Endereço";
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpj.Location = new System.Drawing.Point(76, 156);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(36, 13);
            this.lbl_cnpj.TabIndex = 12;
            this.lbl_cnpj.Text = "CNPJ";
            // 
            // lbl_nomeoficial
            // 
            this.lbl_nomeoficial.AutoSize = true;
            this.lbl_nomeoficial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeoficial.Location = new System.Drawing.Point(76, 36);
            this.lbl_nomeoficial.Name = "lbl_nomeoficial";
            this.lbl_nomeoficial.Size = new System.Drawing.Size(77, 13);
            this.lbl_nomeoficial.TabIndex = 14;
            this.lbl_nomeoficial.Text = "Nome oficial";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(76, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(466, 21);
            this.textBox2.TabIndex = 13;
            // 
            // lbl_nomefantasia
            // 
            this.lbl_nomefantasia.AutoSize = true;
            this.lbl_nomefantasia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomefantasia.Location = new System.Drawing.Point(76, 96);
            this.lbl_nomefantasia.Name = "lbl_nomefantasia";
            this.lbl_nomefantasia.Size = new System.Drawing.Size(89, 13);
            this.lbl_nomefantasia.TabIndex = 16;
            this.lbl_nomefantasia.Text = "Nome fantasia";
            // 
            // txt_nomefantasia
            // 
            this.txt_nomefantasia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomefantasia.Location = new System.Drawing.Point(76, 122);
            this.txt_nomefantasia.Name = "txt_nomefantasia";
            this.txt_nomefantasia.Size = new System.Drawing.Size(466, 21);
            this.txt_nomefantasia.TabIndex = 15;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(76, 276);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(55, 13);
            this.lbl_telefone.TabIndex = 18;
            this.lbl_telefone.Text = "Telefone";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(79, 379);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(432, 379);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(110, 32);
            this.btn_confirmar.TabIndex = 19;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnpj.Location = new System.Drawing.Point(76, 182);
            this.txt_cnpj.Mask = "00,000,000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(466, 21);
            this.txt_cnpj.TabIndex = 21;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(76, 302);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(466, 21);
            this.txt_telefone.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(76, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 21);
            this.textBox1.TabIndex = 23;
            // 
            // Form_CadastroLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nomefantasia);
            this.Controls.Add(this.txt_nomefantasia);
            this.Controls.Add(this.lbl_nomeoficial);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_cnpj);
            this.Controls.Add(this.lbl_endereco);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_CadastroLoja";
            this.Text = "Cadastro de loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.Label lbl_nomeoficial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_nomefantasia;
        private System.Windows.Forms.TextBox txt_nomefantasia;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.TextBox textBox1;
    }
}