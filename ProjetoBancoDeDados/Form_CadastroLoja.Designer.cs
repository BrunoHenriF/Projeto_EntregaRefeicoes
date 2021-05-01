
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
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.lbl_nomeoficial = new System.Windows.Forms.Label();
            this.txt_nomeoficial = new System.Windows.Forms.TextBox();
            this.lbl_nomefantasia = new System.Windows.Forms.Label();
            this.txt_nomefantasia = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_culinaria = new System.Windows.Forms.TextBox();
            this.cbbox_estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpj.Location = new System.Drawing.Point(10, 174);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(36, 13);
            this.lbl_cnpj.TabIndex = 12;
            this.lbl_cnpj.Text = "CNPJ";
            // 
            // lbl_nomeoficial
            // 
            this.lbl_nomeoficial.AutoSize = true;
            this.lbl_nomeoficial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeoficial.Location = new System.Drawing.Point(10, 25);
            this.lbl_nomeoficial.Name = "lbl_nomeoficial";
            this.lbl_nomeoficial.Size = new System.Drawing.Size(77, 13);
            this.lbl_nomeoficial.TabIndex = 14;
            this.lbl_nomeoficial.Text = "Nome oficial";
            // 
            // txt_nomeoficial
            // 
            this.txt_nomeoficial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeoficial.Location = new System.Drawing.Point(15, 47);
            this.txt_nomeoficial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nomeoficial.Name = "txt_nomeoficial";
            this.txt_nomeoficial.Size = new System.Drawing.Size(598, 21);
            this.txt_nomeoficial.TabIndex = 13;
            // 
            // lbl_nomefantasia
            // 
            this.lbl_nomefantasia.AutoSize = true;
            this.lbl_nomefantasia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomefantasia.Location = new System.Drawing.Point(8, 91);
            this.lbl_nomefantasia.Name = "lbl_nomefantasia";
            this.lbl_nomefantasia.Size = new System.Drawing.Size(89, 13);
            this.lbl_nomefantasia.TabIndex = 16;
            this.lbl_nomefantasia.Text = "Nome fantasia";
            // 
            // txt_nomefantasia
            // 
            this.txt_nomefantasia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomefantasia.Location = new System.Drawing.Point(15, 114);
            this.txt_nomefantasia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nomefantasia.Name = "txt_nomefantasia";
            this.txt_nomefantasia.Size = new System.Drawing.Size(598, 21);
            this.txt_nomefantasia.TabIndex = 15;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(10, 348);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(55, 13);
            this.lbl_telefone.TabIndex = 18;
            this.lbl_telefone.Text = "Telefone";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(18, 506);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(142, 44);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(472, 506);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(142, 44);
            this.btn_confirmar.TabIndex = 19;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnpj.Location = new System.Drawing.Point(15, 197);
            this.txt_cnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cnpj.Mask = "00,000,000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(598, 21);
            this.txt_cnpj.TabIndex = 21;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(18, 370);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(598, 21);
            this.txt_telefone.TabIndex = 22;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(501, 286);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(112, 25);
            this.txt_numero.TabIndex = 23;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(339, 286);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(115, 25);
            this.txt_rua.TabIndex = 24;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(180, 286);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(112, 25);
            this.txt_cidade.TabIndex = 25;
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.Location = new System.Drawing.Point(334, 263);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(36, 18);
            this.lbl_Rua.TabIndex = 26;
            this.lbl_Rua.Text = "Rua";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(496, 263);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(68, 18);
            this.lbl_numero.TabIndex = 27;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(177, 263);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(58, 18);
            this.lbl_cidade.TabIndex = 29;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(8, 263);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(59, 18);
            this.lbl_estado.TabIndex = 30;
            this.lbl_estado.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Culinária";
            // 
            // txt_culinaria
            // 
            this.txt_culinaria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_culinaria.Location = new System.Drawing.Point(15, 450);
            this.txt_culinaria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_culinaria.Name = "txt_culinaria";
            this.txt_culinaria.Size = new System.Drawing.Size(598, 21);
            this.txt_culinaria.TabIndex = 31;
            // 
            // cbbox_estado
            // 
            this.cbbox_estado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbox_estado.FormattingEnabled = true;
            this.cbbox_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbox_estado.Location = new System.Drawing.Point(14, 286);
            this.cbbox_estado.Margin = new System.Windows.Forms.Padding(4);
            this.cbbox_estado.Name = "cbbox_estado";
            this.cbbox_estado.Size = new System.Drawing.Size(112, 24);
            this.cbbox_estado.TabIndex = 61;
            // 
            // Form_CadastroLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 623);
            this.Controls.Add(this.cbbox_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_culinaria);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_Rua);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nomefantasia);
            this.Controls.Add(this.txt_nomefantasia);
            this.Controls.Add(this.lbl_nomeoficial);
            this.Controls.Add(this.txt_nomeoficial);
            this.Controls.Add(this.lbl_cnpj);
            this.Font = new System.Drawing.Font("Verdana", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_CadastroLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.Label lbl_nomeoficial;
        private System.Windows.Forms.TextBox txt_nomeoficial;
        private System.Windows.Forms.Label lbl_nomefantasia;
        private System.Windows.Forms.TextBox txt_nomefantasia;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_Rua;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_culinaria;
        private System.Windows.Forms.ComboBox cbbox_estado;
    }
}