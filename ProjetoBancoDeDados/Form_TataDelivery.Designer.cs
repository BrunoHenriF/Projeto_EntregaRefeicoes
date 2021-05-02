
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TataDelivery));
            this.txt_barradebusca = new System.Windows.Forms.TextBox();
            this.lbl_barradebusca = new System.Windows.Forms.Label();
            this.radbtn_prato = new System.Windows.Forms.RadioButton();
            this.radbtn_nome = new System.Windows.Forms.RadioButton();
            this.radbtn_culinaria = new System.Windows.Forms.RadioButton();
            this.radbtn_preco = new System.Windows.Forms.RadioButton();
            this.gpbox_filtros = new System.Windows.Forms.GroupBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_ir_para_restaurante = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.listbox_resultados = new System.Windows.Forms.ListBox();
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastreseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastreSeuRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalheComoNossoEntregadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_teste = new System.Windows.Forms.Label();
            this.gpbox_filtros.SuspendLayout();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_barradebusca
            // 
            this.txt_barradebusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_barradebusca.Location = new System.Drawing.Point(15, 118);
            this.txt_barradebusca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barradebusca.Name = "txt_barradebusca";
            this.txt_barradebusca.Size = new System.Drawing.Size(547, 26);
            this.txt_barradebusca.TabIndex = 4;
            this.txt_barradebusca.TextChanged += new System.EventHandler(this.txt_barradebusca_TextChanged);
            // 
            // lbl_barradebusca
            // 
            this.lbl_barradebusca.AutoSize = true;
            this.lbl_barradebusca.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_barradebusca.Location = new System.Drawing.Point(18, 79);
            this.lbl_barradebusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_barradebusca.Name = "lbl_barradebusca";
            this.lbl_barradebusca.Size = new System.Drawing.Size(298, 25);
            this.lbl_barradebusca.TabIndex = 5;
            this.lbl_barradebusca.Text = "Busque um restaurante:";
            // 
            // radbtn_prato
            // 
            this.radbtn_prato.AutoSize = true;
            this.radbtn_prato.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_prato.Location = new System.Drawing.Point(32, 59);
            this.radbtn_prato.Margin = new System.Windows.Forms.Padding(4);
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
            this.radbtn_nome.Location = new System.Drawing.Point(32, 23);
            this.radbtn_nome.Margin = new System.Windows.Forms.Padding(4);
            this.radbtn_nome.Name = "radbtn_nome";
            this.radbtn_nome.Size = new System.Drawing.Size(103, 22);
            this.radbtn_nome.TabIndex = 7;
            this.radbtn_nome.TabStop = true;
            this.radbtn_nome.Text = "Por nome";
            this.radbtn_nome.UseVisualStyleBackColor = true;
            this.radbtn_nome.CheckedChanged += new System.EventHandler(this.radbtn_nome_CheckedChanged);
            // 
            // radbtn_culinaria
            // 
            this.radbtn_culinaria.AutoSize = true;
            this.radbtn_culinaria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_culinaria.Location = new System.Drawing.Point(32, 98);
            this.radbtn_culinaria.Margin = new System.Windows.Forms.Padding(4);
            this.radbtn_culinaria.Name = "radbtn_culinaria";
            this.radbtn_culinaria.Size = new System.Drawing.Size(127, 22);
            this.radbtn_culinaria.TabIndex = 8;
            this.radbtn_culinaria.TabStop = true;
            this.radbtn_culinaria.Text = "Por culinária";
            this.radbtn_culinaria.UseVisualStyleBackColor = true;
            this.radbtn_culinaria.CheckedChanged += new System.EventHandler(this.radbtn_culinaria_CheckedChanged);
            // 
            // radbtn_preco
            // 
            this.radbtn_preco.AutoSize = true;
            this.radbtn_preco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_preco.Location = new System.Drawing.Point(32, 137);
            this.radbtn_preco.Margin = new System.Windows.Forms.Padding(4);
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
            this.gpbox_filtros.Location = new System.Drawing.Point(15, 165);
            this.gpbox_filtros.Margin = new System.Windows.Forms.Padding(4);
            this.gpbox_filtros.Name = "gpbox_filtros";
            this.gpbox_filtros.Padding = new System.Windows.Forms.Padding(4);
            this.gpbox_filtros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpbox_filtros.Size = new System.Drawing.Size(386, 174);
            this.gpbox_filtros.TabIndex = 10;
            this.gpbox_filtros.TabStop = false;
            // 
            // btn_busca
            // 
            this.btn_busca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_busca.Font = new System.Drawing.Font("Verdana", 11F);
            this.btn_busca.Location = new System.Drawing.Point(446, 173);
            this.btn_busca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(118, 50);
            this.btn_busca.TabIndex = 11;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_ir_para_restaurante
            // 
            this.btn_ir_para_restaurante.Font = new System.Drawing.Font("Verdana", 11F);
            this.btn_ir_para_restaurante.Location = new System.Drawing.Point(746, 493);
            this.btn_ir_para_restaurante.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ir_para_restaurante.Name = "btn_ir_para_restaurante";
            this.btn_ir_para_restaurante.Size = new System.Drawing.Size(267, 44);
            this.btn_ir_para_restaurante.TabIndex = 14;
            this.btn_ir_para_restaurante.Text = "Ir para restaurante";
            this.btn_ir_para_restaurante.UseVisualStyleBackColor = true;
            this.btn_ir_para_restaurante.Click += new System.EventHandler(this.btn_ir_para_restaurante_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_resultado.Location = new System.Drawing.Point(657, 79);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(337, 25);
            this.lbl_resultado.TabIndex = 13;
            this.lbl_resultado.Text = "Restaurantes encontrados:";
            // 
            // listbox_resultados
            // 
            this.listbox_resultados.Font = new System.Drawing.Font("Verdana", 14F);
            this.listbox_resultados.FormattingEnabled = true;
            this.listbox_resultados.ItemHeight = 23;
            this.listbox_resultados.Location = new System.Drawing.Point(663, 118);
            this.listbox_resultados.Margin = new System.Windows.Forms.Padding(4);
            this.listbox_resultados.Name = "listbox_resultados";
            this.listbox_resultados.Size = new System.Drawing.Size(426, 349);
            this.listbox_resultados.TabIndex = 12;
            this.listbox_resultados.SelectedIndexChanged += new System.EventHandler(this.listbox_resultados_SelectedIndexChanged);
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cadastreseToolStripMenuItem,
            this.cadastreSeuRestauranteToolStripMenuItem,
            this.trabalheComoNossoEntregadorToolStripMenuItem,
            this.cadastroDePratosToolStripMenuItem});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menu_principal.Size = new System.Drawing.Size(1108, 25);
            this.menu_principal.TabIndex = 15;
            this.menu_principal.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cadastreseToolStripMenuItem
            // 
            this.cadastreseToolStripMenuItem.Name = "cadastreseToolStripMenuItem";
            this.cadastreseToolStripMenuItem.Size = new System.Drawing.Size(81, 19);
            this.cadastreseToolStripMenuItem.Text = "Cadastre-se";
            this.cadastreseToolStripMenuItem.Click += new System.EventHandler(this.cadastreseToolStripMenuItem_Click);
            // 
            // cadastreSeuRestauranteToolStripMenuItem
            // 
            this.cadastreSeuRestauranteToolStripMenuItem.Name = "cadastreSeuRestauranteToolStripMenuItem";
            this.cadastreSeuRestauranteToolStripMenuItem.Size = new System.Drawing.Size(148, 19);
            this.cadastreSeuRestauranteToolStripMenuItem.Text = "Cadastre seu restaurante";
            this.cadastreSeuRestauranteToolStripMenuItem.Click += new System.EventHandler(this.cadastreSeuRestauranteToolStripMenuItem_Click);
            // 
            // trabalheComoNossoEntregadorToolStripMenuItem
            // 
            this.trabalheComoNossoEntregadorToolStripMenuItem.Name = "trabalheComoNossoEntregadorToolStripMenuItem";
            this.trabalheComoNossoEntregadorToolStripMenuItem.Size = new System.Drawing.Size(195, 19);
            this.trabalheComoNossoEntregadorToolStripMenuItem.Text = "Trabalhe como nosso entregador!";
            this.trabalheComoNossoEntregadorToolStripMenuItem.Click += new System.EventHandler(this.trabalheComoNossoEntregadorToolStripMenuItem_Click);
            // 
            // cadastroDePratosToolStripMenuItem
            // 
            this.cadastroDePratosToolStripMenuItem.Name = "cadastroDePratosToolStripMenuItem";
            this.cadastroDePratosToolStripMenuItem.Size = new System.Drawing.Size(118, 19);
            this.cadastroDePratosToolStripMenuItem.Text = "Cadastro de pratos";
            this.cadastroDePratosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePratosToolStripMenuItem_Click);
            // 
            // lbl_teste
            // 
            this.lbl_teste.AutoSize = true;
            this.lbl_teste.Location = new System.Drawing.Point(26, 43);
            this.lbl_teste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_teste.Name = "lbl_teste";
            this.lbl_teste.Size = new System.Drawing.Size(51, 18);
            this.lbl_teste.TabIndex = 16;
            this.lbl_teste.Text = "label1";
            // 
            // Form_TataDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 617);
            this.Controls.Add(this.lbl_teste);
            this.Controls.Add(this.btn_ir_para_restaurante);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.listbox_resultados);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.gpbox_filtros);
            this.Controls.Add(this.lbl_barradebusca);
            this.Controls.Add(this.txt_barradebusca);
            this.Controls.Add(this.menu_principal);
            this.Font = new System.Drawing.Font("Verdana", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TataDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tata Delivery";
            this.Load += new System.EventHandler(this.Form_TataDelivery_Load);
            this.gpbox_filtros.ResumeLayout(false);
            this.gpbox_filtros.PerformLayout();
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_barradebusca;
        private System.Windows.Forms.Label lbl_barradebusca;
        private System.Windows.Forms.RadioButton radbtn_prato;
        private System.Windows.Forms.RadioButton radbtn_nome;
        private System.Windows.Forms.RadioButton radbtn_culinaria;
        private System.Windows.Forms.RadioButton radbtn_preco;
        private System.Windows.Forms.GroupBox gpbox_filtros;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_ir_para_restaurante;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.ListBox listbox_resultados;
        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.Label lbl_teste;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastreseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabalheComoNossoEntregadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastreSeuRestauranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePratosToolStripMenuItem;
    }
}

