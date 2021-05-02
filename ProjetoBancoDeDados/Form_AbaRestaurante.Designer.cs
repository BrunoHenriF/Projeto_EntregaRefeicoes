
namespace ProjetoBancoDeDados
{
    partial class Form_AbaRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AbaRestaurante));
            this.lbl_nomerest = new System.Windows.Forms.Label();
            this.listbox_pratos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_preco = new System.Windows.Forms.ListBox();
            this.listBox_item = new System.Windows.Forms.ListBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nomerest
            // 
            this.lbl_nomerest.AutoSize = true;
            this.lbl_nomerest.Location = new System.Drawing.Point(15, 9);
            this.lbl_nomerest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomerest.Name = "lbl_nomerest";
            this.lbl_nomerest.Size = new System.Drawing.Size(168, 18);
            this.lbl_nomerest.TabIndex = 0;
            this.lbl_nomerest.Text = "Nome do restaurante";
            // 
            // listbox_pratos
            // 
            this.listbox_pratos.Font = new System.Drawing.Font("Verdana", 14F);
            this.listbox_pratos.FormattingEnabled = true;
            this.listbox_pratos.ItemHeight = 23;
            this.listbox_pratos.Location = new System.Drawing.Point(13, 68);
            this.listbox_pratos.Margin = new System.Windows.Forms.Padding(4);
            this.listbox_pratos.Name = "listbox_pratos";
            this.listbox_pratos.Size = new System.Drawing.Size(336, 234);
            this.listbox_pratos.TabIndex = 13;
            this.listbox_pratos.SelectedIndexChanged += new System.EventHandler(this.listbox_pratos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F);
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pratos";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Verdana", 11F);
            this.btn_adicionar.Location = new System.Drawing.Point(13, 470);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(336, 32);
            this.btn_adicionar.TabIndex = 15;
            this.btn_adicionar.Text = "Adicionar ao carrinho";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total a pagar:";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_total.Location = new System.Drawing.Point(533, 430);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(65, 26);
            this.txt_total.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F);
            this.label3.Location = new System.Drawing.Point(448, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Carrinho";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11F);
            this.button1.Location = new System.Drawing.Point(498, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_preco
            // 
            this.listBox_preco.FormattingEnabled = true;
            this.listBox_preco.ItemHeight = 18;
            this.listBox_preco.Location = new System.Drawing.Point(533, 70);
            this.listBox_preco.Name = "listBox_preco";
            this.listBox_preco.Size = new System.Drawing.Size(65, 346);
            this.listBox_preco.TabIndex = 24;
            // 
            // listBox_item
            // 
            this.listBox_item.FormattingEnabled = true;
            this.listBox_item.ItemHeight = 18;
            this.listBox_item.Location = new System.Drawing.Point(392, 70);
            this.listBox_item.Name = "listBox_item";
            this.listBox_item.Size = new System.Drawing.Size(135, 346);
            this.listBox_item.TabIndex = 25;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_descricao.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_descricao.Location = new System.Drawing.Point(13, 337);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ReadOnly = true;
            this.txt_descricao.Size = new System.Drawing.Size(336, 117);
            this.txt_descricao.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F);
            this.label4.Location = new System.Drawing.Point(13, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Descrição";
            // 
            // Form_AbaRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(609, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.listBox_item);
            this.Controls.Add(this.listBox_preco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_pratos);
            this.Controls.Add(this.lbl_nomerest);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AbaRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Form_AbaRestaurante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomerest;
        private System.Windows.Forms.ListBox listbox_pratos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_preco;
        private System.Windows.Forms.ListBox listBox_item;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label4;
    }
}