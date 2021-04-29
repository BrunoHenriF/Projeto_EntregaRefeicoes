
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
            this.txt_barradebusca = new System.Windows.Forms.TextBox();
            this.lbl_barradebusca = new System.Windows.Forms.Label();
            this.radbtn_prato = new System.Windows.Forms.RadioButton();
            this.radbtn_nome = new System.Windows.Forms.RadioButton();
            this.radbtn_culinaria = new System.Windows.Forms.RadioButton();
            this.radbtn_preco = new System.Windows.Forms.RadioButton();
            this.gpbox_filtros = new System.Windows.Forms.GroupBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.gpbox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(762, 7);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(141, 46);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cadastre_se
            // 
            this.btn_cadastre_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastre_se.Location = new System.Drawing.Point(629, 7);
            this.btn_cadastre_se.Name = "btn_cadastre_se";
            this.btn_cadastre_se.Size = new System.Drawing.Size(126, 46);
            this.btn_cadastre_se.TabIndex = 1;
            this.btn_cadastre_se.Text = "Cadastre-se";
            this.btn_cadastre_se.UseVisualStyleBackColor = true;
            this.btn_cadastre_se.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cadastroloja
            // 
            this.btn_cadastroloja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastroloja.Location = new System.Drawing.Point(762, 504);
            this.btn_cadastroloja.Name = "btn_cadastroloja";
            this.btn_cadastroloja.Size = new System.Drawing.Size(141, 46);
            this.btn_cadastroloja.TabIndex = 2;
            this.btn_cadastroloja.Text = "Cadastre seu restaurante!";
            this.btn_cadastroloja.UseVisualStyleBackColor = true;
            this.btn_cadastroloja.Click += new System.EventHandler(this.btn_cadastroloja_Click);
            // 
            // btn_cadastromotoboy
            // 
            this.btn_cadastromotoboy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_cadastromotoboy.Location = new System.Drawing.Point(614, 504);
            this.btn_cadastromotoboy.Name = "btn_cadastromotoboy";
            this.btn_cadastromotoboy.Size = new System.Drawing.Size(141, 46);
            this.btn_cadastromotoboy.TabIndex = 3;
            this.btn_cadastromotoboy.Text = "Trabalhe como nosso entregador!";
            this.btn_cadastromotoboy.UseVisualStyleBackColor = true;
            this.btn_cadastromotoboy.Click += new System.EventHandler(this.btn_cadastromotoboy_Click);
            // 
            // txt_barradebusca
            // 
            this.txt_barradebusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_barradebusca.Location = new System.Drawing.Point(111, 182);
            this.txt_barradebusca.Name = "txt_barradebusca";
            this.txt_barradebusca.Size = new System.Drawing.Size(426, 26);
            this.txt_barradebusca.TabIndex = 4;
            // 
            // lbl_barradebusca
            // 
            this.lbl_barradebusca.AutoSize = true;
            this.lbl_barradebusca.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_barradebusca.Location = new System.Drawing.Point(117, 154);
            this.lbl_barradebusca.Name = "lbl_barradebusca";
            this.lbl_barradebusca.Size = new System.Drawing.Size(298, 25);
            this.lbl_barradebusca.TabIndex = 5;
            this.lbl_barradebusca.Text = "Busque um restaurante:";
            // 
            // radbtn_prato
            // 
            this.radbtn_prato.AutoSize = true;
            this.radbtn_prato.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_prato.Location = new System.Drawing.Point(31, 37);
            this.radbtn_prato.Name = "radbtn_prato";
            this.radbtn_prato.Size = new System.Drawing.Size(101, 22);
            this.radbtn_prato.TabIndex = 6;
            this.radbtn_prato.TabStop = true;
            this.radbtn_prato.Text = "Por prato";
            this.radbtn_prato.UseVisualStyleBackColor = true;
            this.radbtn_prato.CheckedChanged += new System.EventHandler(this.radbtn_prato_CheckedChanged);
            // 
            // radbtn_nome
            // 
            this.radbtn_nome.AutoSize = true;
            this.radbtn_nome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_nome.Location = new System.Drawing.Point(29, 9);
            this.radbtn_nome.Name = "radbtn_nome";
            this.radbtn_nome.Size = new System.Drawing.Size(103, 22);
            this.radbtn_nome.TabIndex = 7;
            this.radbtn_nome.TabStop = true;
            this.radbtn_nome.Text = "Por nome";
            this.radbtn_nome.UseVisualStyleBackColor = true;
            // 
            // radbtn_culinaria
            // 
            this.radbtn_culinaria.AutoSize = true;
            this.radbtn_culinaria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_culinaria.Location = new System.Drawing.Point(31, 65);
            this.radbtn_culinaria.Name = "radbtn_culinaria";
            this.radbtn_culinaria.Size = new System.Drawing.Size(127, 22);
            this.radbtn_culinaria.TabIndex = 8;
            this.radbtn_culinaria.TabStop = true;
            this.radbtn_culinaria.Text = "Por culinária";
            this.radbtn_culinaria.UseVisualStyleBackColor = true;
            // 
            // radbtn_preco
            // 
            this.radbtn_preco.AutoSize = true;
            this.radbtn_preco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_preco.Location = new System.Drawing.Point(31, 93);
            this.radbtn_preco.Name = "radbtn_preco";
            this.radbtn_preco.Size = new System.Drawing.Size(102, 22);
            this.radbtn_preco.TabIndex = 9;
            this.radbtn_preco.TabStop = true;
            this.radbtn_preco.Text = "Por preço";
            this.radbtn_preco.UseVisualStyleBackColor = true;
            // 
            // gpbox_filtros
            // 
            this.gpbox_filtros.BackColor = System.Drawing.SystemColors.Control;
            this.gpbox_filtros.Controls.Add(this.radbtn_prato);
            this.gpbox_filtros.Controls.Add(this.radbtn_preco);
            this.gpbox_filtros.Controls.Add(this.radbtn_nome);
            this.gpbox_filtros.Controls.Add(this.radbtn_culinaria);
            this.gpbox_filtros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpbox_filtros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpbox_filtros.Location = new System.Drawing.Point(111, 216);
            this.gpbox_filtros.Name = "gpbox_filtros";
            this.gpbox_filtros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpbox_filtros.Size = new System.Drawing.Size(300, 126);
            this.gpbox_filtros.TabIndex = 10;
            this.gpbox_filtros.TabStop = false;
            // 
            // btn_busca
            // 
            this.btn_busca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_busca.Location = new System.Drawing.Point(446, 222);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(92, 36);
            this.btn_busca.TabIndex = 11;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = true;
            // 
            // Form_TataDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 562);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.gpbox_filtros);
            this.Controls.Add(this.lbl_barradebusca);
            this.Controls.Add(this.txt_barradebusca);
            this.Controls.Add(this.btn_cadastromotoboy);
            this.Controls.Add(this.btn_cadastroloja);
            this.Controls.Add(this.btn_cadastre_se);
            this.Controls.Add(this.btn_login);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_TataDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txt_barradebusca;
        private System.Windows.Forms.Label lbl_barradebusca;
        private System.Windows.Forms.RadioButton radbtn_prato;
        private System.Windows.Forms.RadioButton radbtn_nome;
        private System.Windows.Forms.RadioButton radbtn_culinaria;
        private System.Windows.Forms.RadioButton radbtn_preco;
        private System.Windows.Forms.GroupBox gpbox_filtros;
        private System.Windows.Forms.Button btn_busca;
    }
}

