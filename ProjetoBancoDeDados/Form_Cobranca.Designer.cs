
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cobranca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_entrega = new System.Windows.Forms.RadioButton();
            this.radio_online = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.txt_nometitular = new System.Windows.Forms.TextBox();
            this.txt_validade = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grp_troco = new System.Windows.Forms.GroupBox();
            this.chkbox_troconao = new System.Windows.Forms.CheckBox();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtn_dinheiro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grp_troco.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_entrega);
            this.groupBox1.Controls.Add(this.radio_online);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a forma de pagamento";
            // 
            // radio_entrega
            // 
            this.radio_entrega.AutoSize = true;
            this.radio_entrega.Location = new System.Drawing.Point(420, 28);
            this.radio_entrega.Name = "radio_entrega";
            this.radio_entrega.Size = new System.Drawing.Size(14, 13);
            this.radio_entrega.TabIndex = 14;
            this.radio_entrega.TabStop = true;
            this.radio_entrega.UseVisualStyleBackColor = true;
            this.radio_entrega.CheckedChanged += new System.EventHandler(this.radio_entrega_CheckedChanged);
            // 
            // radio_online
            // 
            this.radio_online.AutoSize = true;
            this.radio_online.Location = new System.Drawing.Point(0, 28);
            this.radio_online.Name = "radio_online";
            this.radio_online.Size = new System.Drawing.Size(14, 13);
            this.radio_online.TabIndex = 13;
            this.radio_online.TabStop = true;
            this.radio_online.UseVisualStyleBackColor = true;
            this.radio_online.CheckedChanged += new System.EventHandler(this.radio_online_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.txt_numero);
            this.groupBox4.Controls.Add(this.txt_cvv);
            this.groupBox4.Controls.Add(this.txt_nometitular);
            this.groupBox4.Controls.Add(this.txt_validade);
            this.groupBox4.Location = new System.Drawing.Point(6, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 243);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagamento online";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "CVV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de validade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número do cartão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome do titular";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 36);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(202, 22);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Usar cartão cadastrado";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(6, 149);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(392, 26);
            this.txt_numero.TabIndex = 6;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(231, 202);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(167, 26);
            this.txt_cvv.TabIndex = 7;
            // 
            // txt_nometitular
            // 
            this.txt_nometitular.Location = new System.Drawing.Point(6, 96);
            this.txt_nometitular.Name = "txt_nometitular";
            this.txt_nometitular.Size = new System.Drawing.Size(392, 26);
            this.txt_nometitular.TabIndex = 4;
            // 
            // txt_validade
            // 
            this.txt_validade.Location = new System.Drawing.Point(6, 202);
            this.txt_validade.Name = "txt_validade";
            this.txt_validade.Size = new System.Drawing.Size(167, 26);
            this.txt_validade.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.grp_troco);
            this.groupBox3.Controls.Add(this.rdbtn_dinheiro);
            this.groupBox3.Location = new System.Drawing.Point(427, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 243);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagamento na entrega";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 22);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vale refeição";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 22);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cartão de crédito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // grp_troco
            // 
            this.grp_troco.Controls.Add(this.chkbox_troconao);
            this.grp_troco.Controls.Add(this.txt_troco);
            this.grp_troco.Controls.Add(this.label3);
            this.grp_troco.Location = new System.Drawing.Point(18, 124);
            this.grp_troco.Name = "grp_troco";
            this.grp_troco.Size = new System.Drawing.Size(217, 104);
            this.grp_troco.TabIndex = 3;
            this.grp_troco.TabStop = false;
            this.grp_troco.Visible = false;
            // 
            // chkbox_troconao
            // 
            this.chkbox_troconao.AutoSize = true;
            this.chkbox_troconao.Location = new System.Drawing.Point(12, 60);
            this.chkbox_troconao.Name = "chkbox_troconao";
            this.chkbox_troconao.Size = new System.Drawing.Size(182, 22);
            this.chkbox_troconao.TabIndex = 4;
            this.chkbox_troconao.Text = "Não precisa de troco";
            this.chkbox_troconao.UseVisualStyleBackColor = true;
            this.chkbox_troconao.CheckedChanged += new System.EventHandler(this.chkbox_troconao_CheckedChanged);
            // 
            // txt_troco
            // 
            this.txt_troco.Location = new System.Drawing.Point(103, 22);
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(100, 26);
            this.txt_troco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Troco para";
            // 
            // rdbtn_dinheiro
            // 
            this.rdbtn_dinheiro.AutoSize = true;
            this.rdbtn_dinheiro.Location = new System.Drawing.Point(18, 96);
            this.rdbtn_dinheiro.Name = "rdbtn_dinheiro";
            this.rdbtn_dinheiro.Size = new System.Drawing.Size(86, 22);
            this.rdbtn_dinheiro.TabIndex = 1;
            this.rdbtn_dinheiro.TabStop = true;
            this.rdbtn_dinheiro.Text = "Dinheiro";
            this.rdbtn_dinheiro.UseVisualStyleBackColor = true;
            this.rdbtn_dinheiro.CheckedChanged += new System.EventHandler(this.rdbtn_dinheiro_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_estado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_cep);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_complemento);
            this.groupBox2.Controls.Add(this.lbl_estado);
            this.groupBox2.Controls.Add(this.lbl_cidade);
            this.groupBox2.Controls.Add(this.lbl_numero);
            this.groupBox2.Controls.Add(this.lbl_Rua);
            this.groupBox2.Controls.Add(this.txt_cidade);
            this.groupBox2.Controls.Add(this.txt_rua);
            this.groupBox2.Controls.Add(this.txt_num);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço de entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "CEP";
            // 
            // txt_cep
            // 
            this.txt_cep.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(19, 222);
            this.txt_cep.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(179, 23);
            this.txt_cep.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Complemento";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complemento.Location = new System.Drawing.Point(244, 222);
            this.txt_complemento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(166, 23);
            this.txt_complemento.TabIndex = 68;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(22, 81);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(53, 16);
            this.lbl_estado.TabIndex = 67;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(246, 81);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(52, 16);
            this.lbl_cidade.TabIndex = 66;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(246, 143);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(57, 16);
            this.lbl_numero.TabIndex = 65;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rua.Location = new System.Drawing.Point(22, 143);
            this.lbl_Rua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(32, 16);
            this.lbl_Rua.TabIndex = 64;
            this.lbl_Rua.Text = "Rua";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(245, 101);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(165, 23);
            this.txt_cidade.TabIndex = 63;
            // 
            // txt_rua
            // 
            this.txt_rua.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(19, 162);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(179, 23);
            this.txt_rua.TabIndex = 62;
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(245, 163);
            this.txt_num.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(165, 23);
            this.txt_num.TabIndex = 61;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(223, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Usar endereço cadastrado";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11F);
            this.button1.Location = new System.Drawing.Point(571, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Finalizar compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 26;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Valor final:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_valor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(558, 313);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_valor.Size = new System.Drawing.Size(67, 27);
            this.lbl_valor.TabIndex = 28;
            this.lbl_valor.Text = "valor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(19, 101);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(179, 23);
            this.txt_estado.TabIndex = 72;
            // 
            // Form_Cobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Cobranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento e entrega";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grp_troco.ResumeLayout(false);
            this.grp_troco.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtn_dinheiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grp_troco;
        private System.Windows.Forms.CheckBox chkbox_troconao;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_Rua;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.TextBox txt_nometitular;
        private System.Windows.Forms.TextBox txt_validade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radio_entrega;
        private System.Windows.Forms.RadioButton radio_online;
        private System.Windows.Forms.TextBox txt_estado;
    }
}