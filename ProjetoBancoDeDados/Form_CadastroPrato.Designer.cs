
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroPrato));
            this.lbl_nomedoprato = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_codprato = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.txt_disponibilidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_nomedoprato
            // 
            this.lbl_nomedoprato.AutoSize = true;
            this.lbl_nomedoprato.Location = new System.Drawing.Point(80, 27);
            this.lbl_nomedoprato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomedoprato.Name = "lbl_nomedoprato";
            this.lbl_nomedoprato.Size = new System.Drawing.Size(122, 18);
            this.lbl_nomedoprato.TabIndex = 0;
            this.lbl_nomedoprato.Text = "Nome do prato";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(72, 49);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(313, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(72, 196);
            this.txt_preco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(313, 26);
            this.txt_preco.TabIndex = 5;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(80, 174);
            this.lbl_preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(50, 18);
            this.lbl_preco.TabIndex = 4;
            this.lbl_preco.Text = "Preço";
            // 
            // lbl_codprato
            // 
            this.lbl_codprato.AutoSize = true;
            this.lbl_codprato.Location = new System.Drawing.Point(80, 102);
            this.lbl_codprato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codprato.Name = "lbl_codprato";
            this.lbl_codprato.Size = new System.Drawing.Size(161, 18);
            this.lbl_codprato.TabIndex = 2;
            this.lbl_codprato.Text = "CNPJ do restaurante";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(72, 268);
            this.txt_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(313, 26);
            this.txt_descricao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição do prato";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(72, 337);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(313, 26);
            this.txt_codigo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código do prato";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(13, 464);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 52);
            this.btn_cancelar.TabIndex = 50;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.Location = new System.Drawing.Point(312, 464);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(141, 52);
            this.btn_proximo.TabIndex = 49;
            this.btn_proximo.Text = "Confirmar";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // txt_disponibilidade
            // 
            this.txt_disponibilidade.Location = new System.Drawing.Point(72, 409);
            this.txt_disponibilidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_disponibilidade.Name = "txt_disponibilidade";
            this.txt_disponibilidade.Size = new System.Drawing.Size(313, 26);
            this.txt_disponibilidade.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Disponibilidade";
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.Location = new System.Drawing.Point(72, 123);
            this.txt_CNPJ.Mask = "00,000,000/0000-00";
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(313, 26);
            this.txt_CNPJ.TabIndex = 53;
            // 
            // Form_CadastroPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 538);
            this.Controls.Add(this.txt_CNPJ);
            this.Controls.Add(this.txt_disponibilidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_codprato);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nomedoprato);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CadastroPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre um prato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomedoprato;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_codprato;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.TextBox txt_disponibilidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_CNPJ;
    }
}