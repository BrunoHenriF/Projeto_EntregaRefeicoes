
namespace ProjetoBancoDeDados
{
    partial class Form_CadastroUsuario
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_repetesenha = new System.Windows.Forms.TextBox();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.masktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(68, 33);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(598, 26);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(68, 90);
            this.txt_sobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(598, 26);
            this.txt_sobrenome.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(68, 424);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(598, 26);
            this.txt_senha.TabIndex = 2;
            // 
            // txt_repetesenha
            // 
            this.txt_repetesenha.Location = new System.Drawing.Point(68, 486);
            this.txt_repetesenha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_repetesenha.Name = "txt_repetesenha";
            this.txt_repetesenha.PasswordChar = '*';
            this.txt_repetesenha.Size = new System.Drawing.Size(598, 26);
            this.txt_repetesenha.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(78, 68);
            this.lbl_sobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(95, 18);
            this.lbl_sobrenome.TabIndex = 5;
            this.lbl_sobrenome.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 464);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repita sua senha";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(78, 11);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(78, 329);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 18);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "E-mail";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(68, 354);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(598, 26);
            this.txt_email.TabIndex = 9;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(78, 191);
            this.lbl_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(37, 18);
            this.lbl_cpf.TabIndex = 12;
            this.lbl_cpf.Text = "CPF";
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(483, 555);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(141, 44);
            this.btn_proximo.TabIndex = 13;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(114, 555);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 44);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Verdana", 11F);
            this.txt_telefone.Location = new System.Drawing.Point(68, 287);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(598, 25);
            this.txt_telefone.TabIndex = 34;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Verdana", 11F);
            this.lbl_telefone.Location = new System.Drawing.Point(78, 265);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(69, 18);
            this.lbl_telefone.TabIndex = 33;
            this.lbl_telefone.Text = "Telefone";
            // 
            // masktxt_cpf
            // 
            this.masktxt_cpf.Location = new System.Drawing.Point(68, 214);
            this.masktxt_cpf.Margin = new System.Windows.Forms.Padding(4);
            this.masktxt_cpf.Mask = "000000000-00";
            this.masktxt_cpf.Name = "masktxt_cpf";
            this.masktxt_cpf.Size = new System.Drawing.Size(598, 26);
            this.masktxt_cpf.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "RG";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(68, 153);
            this.txt_rg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(598, 26);
            this.txt_rg.TabIndex = 36;
            // 
            // Form_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.masktxt_cpf);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.txt_repetesenha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_repetesenha;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.MaskedTextBox masktxt_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rg;
    }
}