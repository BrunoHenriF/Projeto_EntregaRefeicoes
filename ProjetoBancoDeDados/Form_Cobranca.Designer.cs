
namespace ProjetoBancoDeDados
{
    partial class Form_Cobranca
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtn_cartao = new System.Windows.Forms.RadioButton();
            this.rdbtn_dinheiro = new System.Windows.Forms.RadioButton();
            this.rdbtn_vr = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrinho de compras:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_vr);
            this.groupBox1.Controls.Add(this.rdbtn_dinheiro);
            this.groupBox1.Controls.Add(this.rdbtn_cartao);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a forma de pagamento";
            // 
            // rdbtn_cartao
            // 
            this.rdbtn_cartao.AutoSize = true;
            this.rdbtn_cartao.Location = new System.Drawing.Point(6, 55);
            this.rdbtn_cartao.Name = "rdbtn_cartao";
            this.rdbtn_cartao.Size = new System.Drawing.Size(156, 22);
            this.rdbtn_cartao.TabIndex = 0;
            this.rdbtn_cartao.TabStop = true;
            this.rdbtn_cartao.Text = "Cartão de crédito";
            this.rdbtn_cartao.UseVisualStyleBackColor = true;
            // 
            // rdbtn_dinheiro
            // 
            this.rdbtn_dinheiro.AutoSize = true;
            this.rdbtn_dinheiro.Location = new System.Drawing.Point(6, 111);
            this.rdbtn_dinheiro.Name = "rdbtn_dinheiro";
            this.rdbtn_dinheiro.Size = new System.Drawing.Size(86, 22);
            this.rdbtn_dinheiro.TabIndex = 1;
            this.rdbtn_dinheiro.TabStop = true;
            this.rdbtn_dinheiro.Text = "Dinheiro";
            this.rdbtn_dinheiro.UseVisualStyleBackColor = true;
            // 
            // rdbtn_vr
            // 
            this.rdbtn_vr.AutoSize = true;
            this.rdbtn_vr.Location = new System.Drawing.Point(6, 83);
            this.rdbtn_vr.Name = "rdbtn_vr";
            this.rdbtn_vr.Size = new System.Drawing.Size(124, 22);
            this.rdbtn_vr.TabIndex = 2;
            this.rdbtn_vr.TabStop = true;
            this.rdbtn_vr.Text = "Vale Refeição";
            this.rdbtn_vr.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 244);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11F);
            this.button1.Location = new System.Drawing.Point(257, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Finalizar compra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 392);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(363, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 352);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 352);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total a pagar:";
            // 
            // Form_Cobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Cobranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtn_vr;
        private System.Windows.Forms.RadioButton rdbtn_dinheiro;
        private System.Windows.Forms.RadioButton rdbtn_cartao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}