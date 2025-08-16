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
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tbp_Estoque = new TabPage();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            tbp_Movimentos = new TabPage();
            tbp_Transferencias = new TabPage();
            tbp_Historico = new TabPage();
            tbp_Cadastros = new TabPage();
            tbp_Relatorios = new TabPage();
            tabControl2 = new TabControl();
            tbp_EntreProdutos = new TabPage();
            tbp_EntreDep = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            tabControl1.SuspendLayout();
            tbp_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbp_Movimentos.SuspendLayout();
            tbp_Transferencias.SuspendLayout();
            tabControl2.SuspendLayout();
            tbp_EntreProdutos.SuspendLayout();
            tbp_EntreDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbp_Estoque);
            tabControl1.Controls.Add(tbp_Movimentos);
            tabControl1.Controls.Add(tbp_Transferencias);
            tabControl1.Controls.Add(tbp_Historico);
            tabControl1.Controls.Add(tbp_Cadastros);
            tabControl1.Controls.Add(tbp_Relatorios);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 454);
            tabControl1.TabIndex = 0;
            // 
            // tbp_Estoque
            // 
            tbp_Estoque.Controls.Add(button2);
            tbp_Estoque.Controls.Add(label8);
            tbp_Estoque.Controls.Add(label7);
            tbp_Estoque.Controls.Add(label6);
            tbp_Estoque.Controls.Add(label5);
            tbp_Estoque.Controls.Add(textBox8);
            tbp_Estoque.Controls.Add(textBox7);
            tbp_Estoque.Controls.Add(textBox6);
            tbp_Estoque.Controls.Add(textBox5);
            tbp_Estoque.Controls.Add(dataGridView1);
            tbp_Estoque.Location = new Point(4, 24);
            tbp_Estoque.Name = "tbp_Estoque";
            tbp_Estoque.Padding = new Padding(3);
            tbp_Estoque.Size = new Size(791, 426);
            tbp_Estoque.TabIndex = 0;
            tbp_Estoque.Text = "Posição Estoque";
            tbp_Estoque.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(708, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Mostrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(300, 12);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 8;
            label8.Text = "Depósito:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 12);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 7;
            label7.Text = "Posição:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 33);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 6;
            label6.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 9);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Código:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(357, 6);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(64, 23);
            textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(216, 6);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(64, 23);
            textBox7.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(73, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(348, 23);
            textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(73, 6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(82, 23);
            textBox5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 281);
            dataGridView1.TabIndex = 0;
            // 
            // tbp_Movimentos
            // 
            tbp_Movimentos.Controls.Add(dataGridView4);
            tbp_Movimentos.Location = new Point(4, 24);
            tbp_Movimentos.Name = "tbp_Movimentos";
            tbp_Movimentos.Padding = new Padding(3);
            tbp_Movimentos.Size = new Size(791, 426);
            tbp_Movimentos.TabIndex = 1;
            tbp_Movimentos.Text = "Movimentação";
            tbp_Movimentos.UseVisualStyleBackColor = true;
            // 
            // tbp_Transferencias
            // 
            tbp_Transferencias.Controls.Add(tabControl2);
            tbp_Transferencias.Location = new Point(4, 24);
            tbp_Transferencias.Name = "tbp_Transferencias";
            tbp_Transferencias.Padding = new Padding(3);
            tbp_Transferencias.Size = new Size(791, 426);
            tbp_Transferencias.TabIndex = 2;
            tbp_Transferencias.Text = "Transferências";
            tbp_Transferencias.UseVisualStyleBackColor = true;
            // 
            // tbp_Historico
            // 
            tbp_Historico.Location = new Point(4, 24);
            tbp_Historico.Name = "tbp_Historico";
            tbp_Historico.Padding = new Padding(3);
            tbp_Historico.Size = new Size(791, 426);
            tbp_Historico.TabIndex = 3;
            tbp_Historico.Text = "Históricos";
            tbp_Historico.UseVisualStyleBackColor = true;
            // 
            // tbp_Cadastros
            // 
            tbp_Cadastros.Location = new Point(4, 24);
            tbp_Cadastros.Name = "tbp_Cadastros";
            tbp_Cadastros.Padding = new Padding(3);
            tbp_Cadastros.Size = new Size(791, 426);
            tbp_Cadastros.TabIndex = 4;
            tbp_Cadastros.Text = "Cadastros";
            tbp_Cadastros.UseVisualStyleBackColor = true;
            // 
            // tbp_Relatorios
            // 
            tbp_Relatorios.Location = new Point(4, 24);
            tbp_Relatorios.Name = "tbp_Relatorios";
            tbp_Relatorios.Padding = new Padding(3);
            tbp_Relatorios.Size = new Size(791, 426);
            tbp_Relatorios.TabIndex = 5;
            tbp_Relatorios.Text = "Relatórios";
            tbp_Relatorios.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tbp_EntreProdutos);
            tabControl2.Controls.Add(tbp_EntreDep);
            tabControl2.Location = new Point(-1, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(792, 427);
            tabControl2.TabIndex = 1;
            // 
            // tbp_EntreProdutos
            // 
            tbp_EntreProdutos.Controls.Add(dataGridView2);
            tbp_EntreProdutos.Location = new Point(4, 24);
            tbp_EntreProdutos.Name = "tbp_EntreProdutos";
            tbp_EntreProdutos.Padding = new Padding(3);
            tbp_EntreProdutos.Size = new Size(784, 399);
            tbp_EntreProdutos.TabIndex = 0;
            tbp_EntreProdutos.Text = "Entre Produtos";
            tbp_EntreProdutos.UseVisualStyleBackColor = true;
            // 
            // tbp_EntreDep
            // 
            tbp_EntreDep.Controls.Add(dataGridView3);
            tbp_EntreDep.Location = new Point(4, 24);
            tbp_EntreDep.Name = "tbp_EntreDep";
            tbp_EntreDep.Padding = new Padding(3);
            tbp_EntreDep.Size = new Size(784, 399);
            tbp_EntreDep.TabIndex = 1;
            tbp_EntreDep.Text = "Entre Depósitos";
            tbp_EntreDep.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(4, 59);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(776, 281);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(4, 59);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(776, 281);
            dataGridView3.TabIndex = 1;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(7, 73);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(776, 281);
            dataGridView4.TabIndex = 1;
            // 
            // frm_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frm_Menu";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbp_Estoque.ResumeLayout(false);
            tbp_Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbp_Movimentos.ResumeLayout(false);
            tbp_Transferencias.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tbp_EntreProdutos.ResumeLayout(false);
            tbp_EntreDep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbp_Estoque;
        private TabPage tbp_Movimentos;
        private TabPage tbp_Transferencias;
        private TabPage tbp_Historico;
        private TabPage tbp_Cadastros;
        private TabPage tbp_Relatorios;
        private DataGridView dataGridView1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TabControl tabControl2;
        private TabPage tbp_EntreProdutos;
        private TabPage tbp_EntreDep;
        private DataGridView dataGridView4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}
