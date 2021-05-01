
namespace ProjetoBancoDeDados
{
    partial class Form_Login
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
            this.lbl_email_login = new System.Windows.Forms.Label();
            this.txt_email_login = new System.Windows.Forms.TextBox();
            this.lbl_senha_login = new System.Windows.Forms.Label();
            this.txt_senha_login = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email_login
            // 
            this.lbl_email_login.AutoSize = true;
            this.lbl_email_login.Location = new System.Drawing.Point(28, 25);
            this.lbl_email_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email_login.Name = "lbl_email_login";
            this.lbl_email_login.Size = new System.Drawing.Size(54, 18);
            this.lbl_email_login.TabIndex = 10;
            this.lbl_email_login.Text = "E-mail";
            // 
            // txt_email_login
            // 
            this.txt_email_login.Location = new System.Drawing.Point(18, 47);
            this.txt_email_login.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email_login.Name = "txt_email_login";
            this.txt_email_login.Size = new System.Drawing.Size(298, 26);
            this.txt_email_login.TabIndex = 9;
            // 
            // lbl_senha_login
            // 
            this.lbl_senha_login.AutoSize = true;
            this.lbl_senha_login.Location = new System.Drawing.Point(28, 102);
            this.lbl_senha_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha_login.Name = "lbl_senha_login";
            this.lbl_senha_login.Size = new System.Drawing.Size(54, 18);
            this.lbl_senha_login.TabIndex = 12;
            this.lbl_senha_login.Text = "Senha";
            // 
            // txt_senha_login
            // 
            this.txt_senha_login.Location = new System.Drawing.Point(18, 125);
            this.txt_senha_login.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha_login.Name = "txt_senha_login";
            this.txt_senha_login.PasswordChar = '*';
            this.txt_senha_login.Size = new System.Drawing.Size(298, 26);
            this.txt_senha_login.TabIndex = 11;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(18, 208);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(124, 44);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(194, 208);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(124, 44);
            this.btn_confirmar.TabIndex = 15;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 264);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_senha_login);
            this.Controls.Add(this.txt_senha_login);
            this.Controls.Add(this.lbl_email_login);
            this.Controls.Add(this.txt_email_login);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email_login;
        private System.Windows.Forms.TextBox txt_email_login;
        private System.Windows.Forms.Label lbl_senha_login;
        private System.Windows.Forms.TextBox txt_senha_login;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
    }
}