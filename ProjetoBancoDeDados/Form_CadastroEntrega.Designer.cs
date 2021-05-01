
namespace ProjetoBancoDeDados
{
    partial class Form_CadastroEntrega
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_numCNH = new System.Windows.Forms.Label();
            this.msktxt_placa = new System.Windows.Forms.MaskedTextBox();
            this.msktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msktxt_cnh = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(62, 26);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(66, 48);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(450, 25);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(62, 110);
            this.lbl_placa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(46, 18);
            this.lbl_placa.TabIndex = 2;
            this.lbl_placa.Text = "Placa";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(62, 192);
            this.lbl_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(37, 18);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(65, 382);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(125, 44);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(391, 382);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(125, 44);
            this.btn_confirmar.TabIndex = 6;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_numCNH
            // 
            this.lbl_numCNH.AutoSize = true;
            this.lbl_numCNH.Location = new System.Drawing.Point(62, 280);
            this.lbl_numCNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numCNH.Name = "lbl_numCNH";
            this.lbl_numCNH.Size = new System.Drawing.Size(129, 18);
            this.lbl_numCNH.TabIndex = 20;
            this.lbl_numCNH.Text = "Número da CNH";
            // 
            // msktxt_placa
            // 
            this.msktxt_placa.Location = new System.Drawing.Point(65, 131);
            this.msktxt_placa.Mask = "aaa0000";
            this.msktxt_placa.Name = "msktxt_placa";
            this.msktxt_placa.Size = new System.Drawing.Size(451, 25);
            this.msktxt_placa.TabIndex = 2;
            // 
            // msktxt_cpf
            // 
            this.msktxt_cpf.Location = new System.Drawing.Point(65, 213);
            this.msktxt_cpf.Mask = "000000000-00";
            this.msktxt_cpf.Name = "msktxt_cpf";
            this.msktxt_cpf.Size = new System.Drawing.Size(451, 25);
            this.msktxt_cpf.TabIndex = 3;
            // 
            // msktxt_cnh
            // 
            this.msktxt_cnh.Location = new System.Drawing.Point(66, 301);
            this.msktxt_cnh.Mask = "00000000000";
            this.msktxt_cnh.Name = "msktxt_cnh";
            this.msktxt_cnh.Size = new System.Drawing.Size(450, 25);
            this.msktxt_cnh.TabIndex = 4;
            // 
            // Form_CadastroEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.msktxt_cnh);
            this.Controls.Add(this.msktxt_cpf);
            this.Controls.Add(this.msktxt_placa);
            this.Controls.Add(this.lbl_numCNH);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Verdana", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CadastroEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Entregador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_numCNH;
        private System.Windows.Forms.MaskedTextBox msktxt_placa;
        private System.Windows.Forms.MaskedTextBox msktxt_cpf;
        private System.Windows.Forms.MaskedTextBox msktxt_cnh;
    }
}