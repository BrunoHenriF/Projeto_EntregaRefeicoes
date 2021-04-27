
namespace ProjetoBancoDeDados
{
    partial class Form_TataDelivery
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cadastre_se = new System.Windows.Forms.Button();
            this.btn_cadastroloja = new System.Windows.Forms.Button();
            this.btn_cadastromotoboy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gpbox_filtros = new System.Windows.Forms.GroupBox();
            this.gpbox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(676, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(98, 34);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cadastre_se
            // 
            this.btn_cadastre_se.Location = new System.Drawing.Point(572, 12);
            this.btn_cadastre_se.Name = "btn_cadastre_se";
            this.btn_cadastre_se.Size = new System.Drawing.Size(98, 34);
            this.btn_cadastre_se.TabIndex = 1;
            this.btn_cadastre_se.Text = "Cadastre-se";
            this.btn_cadastre_se.UseVisualStyleBackColor = true;
            this.btn_cadastre_se.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cadastroloja
            // 
            this.btn_cadastroloja.Location = new System.Drawing.Point(653, 504);
            this.btn_cadastroloja.Name = "btn_cadastroloja";
            this.btn_cadastroloja.Size = new System.Drawing.Size(121, 46);
            this.btn_cadastroloja.TabIndex = 2;
            this.btn_cadastroloja.Text = "Cadastre seu restaurante!";
            this.btn_cadastroloja.UseVisualStyleBackColor = true;
            this.btn_cadastroloja.Click += new System.EventHandler(this.btn_cadastroloja_Click);
            // 
            // btn_cadastromotoboy
            // 
            this.btn_cadastromotoboy.Location = new System.Drawing.Point(526, 504);
            this.btn_cadastromotoboy.Name = "btn_cadastromotoboy";
            this.btn_cadastromotoboy.Size = new System.Drawing.Size(121, 46);
            this.btn_cadastromotoboy.TabIndex = 3;
            this.btn_cadastromotoboy.Text = "Trabalhe como nosso entregador!";
            this.btn_cadastromotoboy.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "busque um restaurante";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gpbox_filtros
            // 
            this.gpbox_filtros.Controls.Add(this.radioButton1);
            this.gpbox_filtros.Controls.Add(this.radioButton4);
            this.gpbox_filtros.Controls.Add(this.radioButton2);
            this.gpbox_filtros.Controls.Add(this.radioButton3);
            this.gpbox_filtros.Location = new System.Drawing.Point(176, 232);
            this.gpbox_filtros.Name = "gpbox_filtros";
            this.gpbox_filtros.Size = new System.Drawing.Size(200, 173);
            this.gpbox_filtros.TabIndex = 10;
            this.gpbox_filtros.TabStop = false;
            // 
            // Form_TataDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 562);
            this.Controls.Add(this.gpbox_filtros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cadastromotoboy);
            this.Controls.Add(this.btn_cadastroloja);
            this.Controls.Add(this.btn_cadastre_se);
            this.Controls.Add(this.btn_login);
            this.Name = "Form_TataDelivery";
            this.Text = "Tata Delivery";
            this.gpbox_filtros.ResumeLayout(false);
            this.gpbox_filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cadastre_se;
        private System.Windows.Forms.Button btn_cadastroloja;
        private System.Windows.Forms.Button btn_cadastromotoboy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gpbox_filtros;
    }
}

