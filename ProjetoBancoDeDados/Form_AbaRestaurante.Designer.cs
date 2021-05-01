
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
            this.lbl_nomerest = new System.Windows.Forms.Label();
            this.listbox_pratos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_preco = new System.Windows.Forms.ListBox();
            this.listBox_item = new System.Windows.Forms.ListBox();
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
            this.listbox_pratos.Size = new System.Drawing.Size(336, 349);
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
            this.btn_adicionar.Location = new System.Drawing.Point(12, 427);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(337, 32);
            this.btn_adicionar.TabIndex = 15;
            this.btn_adicionar.Text = "Adicionar ao carrinho";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total a pagar:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(638, 428);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F);
            this.label3.Location = new System.Drawing.Point(577, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Carrinho";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11F);
            this.button1.Location = new System.Drawing.Point(532, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ir para pagamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_preco
            // 
            this.listBox_preco.FormattingEnabled = true;
            this.listBox_preco.ItemHeight = 18;
            this.listBox_preco.Location = new System.Drawing.Point(638, 68);
            this.listBox_preco.Name = "listBox_preco";
            this.listBox_preco.Size = new System.Drawing.Size(100, 346);
            this.listBox_preco.TabIndex = 24;
            // 
            // listBox_item
            // 
            this.listBox_item.FormattingEnabled = true;
            this.listBox_item.ItemHeight = 18;
            this.listBox_item.Location = new System.Drawing.Point(532, 68);
            this.listBox_item.Name = "listBox_item";
            this.listBox_item.Size = new System.Drawing.Size(100, 346);
            this.listBox_item.TabIndex = 25;
            // 
            // Form_AbaRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 629);
            this.Controls.Add(this.listBox_item);
            this.Controls.Add(this.listBox_preco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_pratos);
            this.Controls.Add(this.lbl_nomerest);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AbaRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomerest;
        private System.Windows.Forms.ListBox listbox_pratos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_preco;
        private System.Windows.Forms.ListBox listBox_item;
    }
}