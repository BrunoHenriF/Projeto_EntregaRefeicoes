
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(45, 46);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(400, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(45, 109);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(400, 20);
            this.txt_sobrenome.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(45, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(400, 20);
            this.textBox4.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(52, 93);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbl_sobrenome.TabIndex = 5;
            this.lbl_sobrenome.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repita sua senha";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(52, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(52, 206);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "E-mail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(45, 224);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(400, 20);
            this.textBox5.TabIndex = 9;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(52, 149);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 12;
            this.lbl_cpf.Text = "CPF";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(45, 169);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(400, 20);
            this.txt_cpf.TabIndex = 11;
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(322, 401);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(94, 32);
            this.btn_proximo.TabIndex = 13;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(76, 401);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Form_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 445);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form_CadastroUsuario";
            this.Text = "Cadastro de usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_cancelar;
    }
}