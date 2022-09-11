namespace ExemploBD_02
{
    partial class ListaHerois
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
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rbnNome = new System.Windows.Forms.RadioButton();
            this.rbnRaça = new System.Windows.Forms.RadioButton();
            this.rbnContaBancaria = new System.Windows.Forms.RadioButton();
            this.gbxColunas = new System.Windows.Forms.GroupBox();
            this.rbnCrescente = new System.Windows.Forms.RadioButton();
            this.rbnDecrescente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEstatitica = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxColunas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(12, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(95, 24);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(16, 36);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(180, 22);
            this.txtPesquisa.TabIndex = 1;
            // 
            // rbnNome
            // 
            this.rbnNome.AutoSize = true;
            this.rbnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNome.Location = new System.Drawing.Point(0, 18);
            this.rbnNome.Name = "rbnNome";
            this.rbnNome.Size = new System.Drawing.Size(67, 20);
            this.rbnNome.TabIndex = 2;
            this.rbnNome.TabStop = true;
            this.rbnNome.Text = "Nome";
            this.rbnNome.UseVisualStyleBackColor = true;
            // 
            // rbnRaça
            // 
            this.rbnRaça.AutoSize = true;
            this.rbnRaça.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnRaça.Location = new System.Drawing.Point(73, 18);
            this.rbnRaça.Name = "rbnRaça";
            this.rbnRaça.Size = new System.Drawing.Size(63, 20);
            this.rbnRaça.TabIndex = 3;
            this.rbnRaça.TabStop = true;
            this.rbnRaça.Text = "Raça";
            this.rbnRaça.UseVisualStyleBackColor = true;
            // 
            // rbnContaBancaria
            // 
            this.rbnContaBancaria.AutoSize = true;
            this.rbnContaBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnContaBancaria.Location = new System.Drawing.Point(153, 18);
            this.rbnContaBancaria.Name = "rbnContaBancaria";
            this.rbnContaBancaria.Size = new System.Drawing.Size(132, 20);
            this.rbnContaBancaria.TabIndex = 4;
            this.rbnContaBancaria.TabStop = true;
            this.rbnContaBancaria.Text = "Conta Bancária";
            this.rbnContaBancaria.UseVisualStyleBackColor = true;
            // 
            // gbxColunas
            // 
            this.gbxColunas.Controls.Add(this.rbnRaça);
            this.gbxColunas.Controls.Add(this.rbnContaBancaria);
            this.gbxColunas.Controls.Add(this.rbnNome);
            this.gbxColunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxColunas.Location = new System.Drawing.Point(290, 9);
            this.gbxColunas.Name = "gbxColunas";
            this.gbxColunas.Size = new System.Drawing.Size(307, 57);
            this.gbxColunas.TabIndex = 5;
            this.gbxColunas.TabStop = false;
            this.gbxColunas.Text = "Coluna";
            // 
            // rbnCrescente
            // 
            this.rbnCrescente.AutoSize = true;
            this.rbnCrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCrescente.Location = new System.Drawing.Point(0, 21);
            this.rbnCrescente.Name = "rbnCrescente";
            this.rbnCrescente.Size = new System.Drawing.Size(96, 20);
            this.rbnCrescente.TabIndex = 6;
            this.rbnCrescente.TabStop = true;
            this.rbnCrescente.Text = "Crescente";
            this.rbnCrescente.UseVisualStyleBackColor = true;
            // 
            // rbnDecrescente
            // 
            this.rbnDecrescente.AutoSize = true;
            this.rbnDecrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDecrescente.Location = new System.Drawing.Point(112, 21);
            this.rbnDecrescente.Name = "rbnDecrescente";
            this.rbnDecrescente.Size = new System.Drawing.Size(114, 20);
            this.rbnDecrescente.TabIndex = 7;
            this.rbnDecrescente.TabStop = true;
            this.rbnDecrescente.Text = "Decrescente";
            this.rbnDecrescente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnCrescente);
            this.groupBox1.Controls.Add(this.rbnDecrescente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(699, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(699, 82);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(226, 51);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(699, 168);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(226, 51);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(705, 255);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(226, 51);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(699, 340);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(226, 51);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnEstatitica
            // 
            this.btnEstatitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstatitica.Location = new System.Drawing.Point(699, 426);
            this.btnEstatitica.Name = "btnEstatitica";
            this.btnEstatitica.Size = new System.Drawing.Size(226, 51);
            this.btnEstatitica.TabIndex = 13;
            this.btnEstatitica.Text = "Estatisticas";
            this.btnEstatitica.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaNome,
            this.ColunaRaca,
            this.ColunaCB});
            this.dataGridView1.Location = new System.Drawing.Point(16, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 408);
            this.dataGridView1.TabIndex = 14;
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.Width = 200;
            // 
            // ColunaRaca
            // 
            this.ColunaRaca.HeaderText = "Raça";
            this.ColunaRaca.Name = "ColunaRaca";
            this.ColunaRaca.Width = 200;
            // 
            // ColunaCB
            // 
            this.ColunaCB.HeaderText = "Conta Bancária";
            this.ColunaCB.Name = "ColunaCB";
            this.ColunaCB.Width = 220;
            // 
            // ListaHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEstatitica);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxColunas);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Name = "ListaHerois";
            this.Text = "ListaHerois";
            this.gbxColunas.ResumeLayout(false);
            this.gbxColunas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbnNome;
        private System.Windows.Forms.RadioButton rbnRaça;
        private System.Windows.Forms.RadioButton rbnContaBancaria;
        private System.Windows.Forms.GroupBox gbxColunas;
        private System.Windows.Forms.RadioButton rbnCrescente;
        private System.Windows.Forms.RadioButton rbnDecrescente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEstatitica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCB;
    }
}