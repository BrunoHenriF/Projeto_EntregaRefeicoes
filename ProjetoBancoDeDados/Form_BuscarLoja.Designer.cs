
namespace ProjetoBancoDeDados
{
    partial class Form_BuscarLoja
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_buscanome = new System.Windows.Forms.Label();
            this.txt_buscanome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(220, 406);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(466, 406);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(94, 32);
            this.btn_confirmar.TabIndex = 21;
            this.btn_confirmar.Text = "Buscar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // lbl_buscanome
            // 
            this.lbl_buscanome.AutoSize = true;
            this.lbl_buscanome.Location = new System.Drawing.Point(194, 30);
            this.lbl_buscanome.Name = "lbl_buscanome";
            this.lbl_buscanome.Size = new System.Drawing.Size(73, 13);
            this.lbl_buscanome.TabIndex = 24;
            this.lbl_buscanome.Text = "Nome da Loja";
            // 
            // txt_buscanome
            // 
            this.txt_buscanome.Location = new System.Drawing.Point(187, 46);
            this.txt_buscanome.Name = "txt_buscanome";
            this.txt_buscanome.Size = new System.Drawing.Size(400, 20);
            this.txt_buscanome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Repita sua senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Repita sua senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Repita sua senha";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 265);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 20);
            this.textBox3.TabIndex = 29;
            // 
            // Form_BuscarLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_buscanome);
            this.Controls.Add(this.txt_buscanome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Name = "Form_BuscarLoja";
            this.Text = "Buscar loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_buscanome;
        private System.Windows.Forms.TextBox txt_buscanome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}