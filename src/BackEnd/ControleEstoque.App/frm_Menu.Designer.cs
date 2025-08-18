namespace ControleEstoque.App
{
    partial class frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            tabControl1 = new TabControl();
            tbp_Estoque = new TabPage();
            grb_Posicao_Estoque = new GroupBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            tbp_Movimentos = new TabPage();
            tabControl3 = new TabControl();
            tbp_Saidas = new TabPage();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            lbl_Codigo_Saida = new Label();
            textBox1 = new TextBox();
            btn_Mov__Saida_Processar = new Button();
            tbp_Entradas = new TabPage();
            groupBox2 = new GroupBox();
            dataGridView3 = new DataGridView();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox9 = new TextBox();
            label4 = new Label();
            label9 = new Label();
            textBox10 = new TextBox();
            button1 = new Button();
            tbp_Transferencia = new TabPage();
            tbp_Consultas = new TabPage();
            tbp_Cadastros = new TabPage();
            tabControl4 = new TabControl();
            tbp_Produtos = new TabPage();
            tbp_Estoques = new TabPage();
            tbp_Usuario = new TabPage();
            tbp_Relatorios = new TabPage();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            dataGridView6 = new DataGridView();
            tabControl1.SuspendLayout();
            tbp_Estoque.SuspendLayout();
            grb_Posicao_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbp_Movimentos.SuspendLayout();
            tabControl3.SuspendLayout();
            tbp_Saidas.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tbp_Entradas.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tbp_Transferencia.SuspendLayout();
            tbp_Consultas.SuspendLayout();
            tbp_Cadastros.SuspendLayout();
            tabControl4.SuspendLayout();
            tabControl2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleRole = AccessibleRole.MenuBar;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tbp_Estoque);
            tabControl1.Controls.Add(tbp_Movimentos);
            tabControl1.Controls.Add(tbp_Transferencia);
            tabControl1.Controls.Add(tbp_Consultas);
            tabControl1.Controls.Add(tbp_Cadastros);
            tabControl1.Controls.Add(tbp_Relatorios);
            tabControl1.Location = new Point(1 , 0);
            tabControl1.Margin = new Padding(3 , 4 , 3 , 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(913 , 605);
            tabControl1.TabIndex = 0;
            // 
            // tbp_Estoque
            // 
            tbp_Estoque.Controls.Add(grb_Posicao_Estoque);
            tbp_Estoque.Controls.Add(button2);
            tbp_Estoque.Controls.Add(label8);
            tbp_Estoque.Controls.Add(label7);
            tbp_Estoque.Controls.Add(label6);
            tbp_Estoque.Controls.Add(label5);
            tbp_Estoque.Controls.Add(textBox8);
            tbp_Estoque.Controls.Add(textBox7);
            tbp_Estoque.Controls.Add(textBox6);
            tbp_Estoque.Controls.Add(textBox5);
            tbp_Estoque.Location = new Point(4 , 29);
            tbp_Estoque.Margin = new Padding(3 , 4 , 3 , 4);
            tbp_Estoque.Name = "tbp_Estoque";
            tbp_Estoque.Padding = new Padding(3 , 4 , 3 , 4);
            tbp_Estoque.Size = new Size(905 , 572);
            tbp_Estoque.TabIndex = 0;
            tbp_Estoque.Text = "Posição Estoque";
            tbp_Estoque.UseVisualStyleBackColor = true;
            // 
            // grb_Posicao_Estoque
            // 
            grb_Posicao_Estoque.Controls.Add(dataGridView1);
            grb_Posicao_Estoque.Location = new Point(0 , 74);
            grb_Posicao_Estoque.Name = "grb_Posicao_Estoque";
            grb_Posicao_Estoque.Size = new Size(905 , 495);
            grb_Posicao_Estoque.TabIndex = 10;
            grb_Posicao_Estoque.TabStop = false;
            grb_Posicao_Estoque.Text = "Posição de Estoque";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9 , 27);
            dataGridView1.Margin = new Padding(3 , 4 , 3 , 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887 , 461);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(809 , 8);
            button2.Margin = new Padding(3 , 4 , 3 , 4);
            button2.Name = "button2";
            button2.Size = new Size(86 , 31);
            button2.TabIndex = 9;
            button2.Text = "Mostrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(338 , 13);
            label8.Name = "label8";
            label8.Size = new Size(73 , 20);
            label8.TabIndex = 8;
            label8.Text = "Depósito:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(182 , 15);
            label7.Name = "label7";
            label7.Size = new Size(62 , 20);
            label7.TabIndex = 7;
            label7.Text = "Posição:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(8 , 44);
            label6.Name = "label6";
            label6.Size = new Size(77 , 20);
            label6.TabIndex = 6;
            label6.Text = "Descrição:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(8 , 12);
            label5.Name = "label5";
            label5.Size = new Size(61 , 20);
            label5.TabIndex = 5;
            label5.Text = "Código:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(408 , 8);
            textBox8.Margin = new Padding(3 , 4 , 3 , 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(73 , 27);
            textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(247 , 8);
            textBox7.Margin = new Padding(3 , 4 , 3 , 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(73 , 27);
            textBox7.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(83 , 40);
            textBox6.Margin = new Padding(3 , 4 , 3 , 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(397 , 27);
            textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(83 , 8);
            textBox5.Margin = new Padding(3 , 4 , 3 , 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93 , 27);
            textBox5.TabIndex = 1;
            // 
            // tbp_Movimentos
            // 
            tbp_Movimentos.Controls.Add(tabControl3);
            tbp_Movimentos.Location = new Point(4 , 29);
            tbp_Movimentos.Margin = new Padding(3 , 4 , 3 , 4);
            tbp_Movimentos.Name = "tbp_Movimentos";
            tbp_Movimentos.Padding = new Padding(3 , 4 , 3 , 4);
            tbp_Movimentos.Size = new Size(905 , 572);
            tbp_Movimentos.TabIndex = 1;
            tbp_Movimentos.Text = "Movimentação";
            tbp_Movimentos.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tbp_Saidas);
            tabControl3.Controls.Add(tbp_Entradas);
            tabControl3.Location = new Point(3 , 3);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(906 , 573);
            tabControl3.TabIndex = 0;
            // 
            // tbp_Saidas
            // 
            tbp_Saidas.Controls.Add(groupBox1);
            tbp_Saidas.Controls.Add(textBox3);
            tbp_Saidas.Controls.Add(label2);
            tbp_Saidas.Controls.Add(textBox2);
            tbp_Saidas.Controls.Add(label1);
            tbp_Saidas.Controls.Add(lbl_Codigo_Saida);
            tbp_Saidas.Controls.Add(textBox1);
            tbp_Saidas.Controls.Add(btn_Mov__Saida_Processar);
            tbp_Saidas.Location = new Point(4 , 29);
            tbp_Saidas.Name = "tbp_Saidas";
            tbp_Saidas.Padding = new Padding(3);
            tbp_Saidas.Size = new Size(898 , 540);
            tbp_Saidas.TabIndex = 0;
            tbp_Saidas.Text = "Saída";
            tbp_Saidas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(6 , 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884 , 461);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Produto";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6 , 19);
            dataGridView2.Margin = new Padding(3 , 4 , 3 , 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(872 , 435);
            dataGridView2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(357 , 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148 , 27);
            textBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286 , 9);
            label2.Name = "label2";
            label2.Size = new Size(65 , 20);
            label2.TabIndex = 9;
            label2.Text = "Estoque:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74 , 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148 , 27);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6 , 43);
            label1.Name = "label1";
            label1.Size = new Size(62 , 20);
            label1.TabIndex = 7;
            label1.Text = "Posição:";
            // 
            // lbl_Codigo_Saida
            // 
            lbl_Codigo_Saida.AutoSize = true;
            lbl_Codigo_Saida.Location = new Point(6 , 10);
            lbl_Codigo_Saida.Name = "lbl_Codigo_Saida";
            lbl_Codigo_Saida.Size = new Size(61 , 20);
            lbl_Codigo_Saida.TabIndex = 6;
            lbl_Codigo_Saida.Text = "Código:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74 , 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148 , 27);
            textBox1.TabIndex = 5;
            // 
            // btn_Mov__Saida_Processar
            // 
            btn_Mov__Saida_Processar.Location = new Point(796 , 6);
            btn_Mov__Saida_Processar.Name = "btn_Mov__Saida_Processar";
            btn_Mov__Saida_Processar.Size = new Size(94 , 29);
            btn_Mov__Saida_Processar.TabIndex = 4;
            btn_Mov__Saida_Processar.Text = "Processar";
            btn_Mov__Saida_Processar.UseVisualStyleBackColor = true;
            // 
            // tbp_Entradas
            // 
            tbp_Entradas.Controls.Add(groupBox2);
            tbp_Entradas.Controls.Add(textBox4);
            tbp_Entradas.Controls.Add(label3);
            tbp_Entradas.Controls.Add(textBox9);
            tbp_Entradas.Controls.Add(label4);
            tbp_Entradas.Controls.Add(label9);
            tbp_Entradas.Controls.Add(textBox10);
            tbp_Entradas.Controls.Add(button1);
            tbp_Entradas.Location = new Point(4 , 29);
            tbp_Entradas.Name = "tbp_Entradas";
            tbp_Entradas.Padding = new Padding(3);
            tbp_Entradas.Size = new Size(898 , 540);
            tbp_Entradas.TabIndex = 1;
            tbp_Entradas.Text = "Entradas";
            tbp_Entradas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView3);
            groupBox2.Location = new Point(6 , 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(884 , 461);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Produto";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6 , 19);
            dataGridView3.Margin = new Padding(3 , 4 , 3 , 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(872 , 435);
            dataGridView3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(357 , 7);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148 , 27);
            textBox4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286 , 9);
            label3.Name = "label3";
            label3.Size = new Size(65 , 20);
            label3.TabIndex = 16;
            label3.Text = "Estoque:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(74 , 39);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(148 , 27);
            textBox9.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6 , 43);
            label4.Name = "label4";
            label4.Size = new Size(62 , 20);
            label4.TabIndex = 14;
            label4.Text = "Posição:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6 , 10);
            label9.Name = "label9";
            label9.Size = new Size(61 , 20);
            label9.TabIndex = 13;
            label9.Text = "Código:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(74 , 6);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(148 , 27);
            textBox10.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(796 , 6);
            button1.Name = "button1";
            button1.Size = new Size(94 , 29);
            button1.TabIndex = 11;
            button1.Text = "Processar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbp_Transferencia
            // 
            tbp_Transferencia.Controls.Add(tabControl2);
            tbp_Transferencia.Location = new Point(4 , 29);
            tbp_Transferencia.Name = "tbp_Transferencia";
            tbp_Transferencia.Size = new Size(905 , 572);
            tbp_Transferencia.TabIndex = 6;
            tbp_Transferencia.Text = "Transferência";
            tbp_Transferencia.UseVisualStyleBackColor = true;
            // 
            // tbp_Consultas
            // 
            tbp_Consultas.Controls.Add(groupBox3);
            tbp_Consultas.Location = new Point(4 , 29);
            tbp_Consultas.Margin = new Padding(3 , 4 , 3 , 4);
            tbp_Consultas.Name = "tbp_Consultas";
            tbp_Consultas.Padding = new Padding(3 , 4 , 3 , 4);
            tbp_Consultas.Size = new Size(905 , 572);
            tbp_Consultas.TabIndex = 3;
            tbp_Consultas.Text = "Consultas";
            tbp_Consultas.UseVisualStyleBackColor = true;
            // 
            // tbp_Cadastros
            // 
            tbp_Cadastros.Controls.Add(tabControl4);
            tbp_Cadastros.Location = new Point(4 , 29);
            tbp_Cadastros.Margin = new Padding(3 , 4 , 3 , 4);
            tbp_Cadastros.Name = "tbp_Cadastros";
            tbp_Cadastros.Padding = new Padding(3 , 4 , 3 , 4);
            tbp_Cadastros.Size = new Size(905 , 572);
            tbp_Cadastros.TabIndex = 4;
            tbp_Cadastros.Text = "Cadastros";
            tbp_Cadastros.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(tbp_Produtos);
            tabControl4.Controls.Add(tbp_Estoques);
            tabControl4.Controls.Add(tbp_Usuario);
            tabControl4.Location = new Point(3 , 3);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(902 , 569);
            tabControl4.TabIndex = 0;
            // 
            // tbp_Produtos
            // 
            tbp_Produtos.Location = new Point(4 , 29);
            tbp_Produtos.Name = "tbp_Produtos";
            tbp_Produtos.Padding = new Padding(3);
            tbp_Produtos.Size = new Size(894 , 536);
            tbp_Produtos.TabIndex = 0;
            tbp_Produtos.Text = "Produtos";
            tbp_Produtos.UseVisualStyleBackColor = true;
            // 
            // tbp_Estoques
            // 
            tbp_Estoques.Location = new Point(4 , 29);
            tbp_Estoques.Name = "tbp_Estoques";
            tbp_Estoques.Padding = new Padding(3);
            tbp_Estoques.Size = new Size(894 , 536);
            tbp_Estoques.TabIndex = 1;
            tbp_Estoques.Text = "Estoques";
            tbp_Estoques.UseVisualStyleBackColor = true;
            // 
            // tbp_Usuario
            // 
            tbp_Usuario.Location = new Point(4 , 29);
            tbp_Usuario.Name = "tbp_Usuario";
            tbp_Usuario.Size = new Size(894 , 536);
            tbp_Usuario.TabIndex = 2;
            tbp_Usuario.Text = " Usuários";
            tbp_Usuario.UseVisualStyleBackColor = true;
            // 
            // tbp_Relatorios
            // 
            tbp_Relatorios.Location = new Point(4 , 29);
            tbp_Relatorios.Margin = new Padding(3 , 4 , 3 , 4);
            tbp_Relatorios.Name = "tbp_Relatorios";
            tbp_Relatorios.Padding = new Padding(3 , 4 , 3 , 4);
            tbp_Relatorios.Size = new Size(905 , 572);
            tbp_Relatorios.TabIndex = 5;
            tbp_Relatorios.Text = "Relatórios";
            tbp_Relatorios.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(3 , 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(906 , 566);
            tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4 , 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(898 , 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4 , 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(898 , 533);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView6);
            groupBox3.Location = new Point(3 , 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(896 , 438);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(5 , 27);
            dataGridView6.Margin = new Padding(3 , 4 , 3 , 4);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(887 , 400);
            dataGridView6.TabIndex = 5;
            // 
            // frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(914 , 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3 , 4 , 3 , 4);
            Name = "frm_Menu";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbp_Estoque.ResumeLayout(false);
            tbp_Estoque.PerformLayout();
            grb_Posicao_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbp_Movimentos.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tbp_Saidas.ResumeLayout(false);
            tbp_Saidas.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tbp_Entradas.ResumeLayout(false);
            tbp_Entradas.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tbp_Transferencia.ResumeLayout(false);
            tbp_Consultas.ResumeLayout(false);
            tbp_Cadastros.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbp_Estoque;
        private TabPage tbp_Movimentos;
        private TabPage tbp_Consultas;
        private TabPage tbp_Cadastros;
        private TabPage tbp_Relatorios;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TabControl tabControl3;
        private TabPage tbp_Saidas;
        private TabPage tbp_Entradas;
        private TabControl tabControl4;
        private TabPage tbp_Produtos;
        private TabPage tbp_Estoques;
        private TabPage tbp_Usuario;
        private TabPage tbp_Transferencia;
        private Button btn_Mov__Saida_Processar;
        private Label lbl_Codigo_Saida;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox9;
        private Label label4;
        private Label label9;
        private TextBox textBox10;
        private Button button1;
        private GroupBox grb_Posicao_Estoque;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private DataGridView dataGridView3;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private DataGridView dataGridView6;
    }
}
