namespace ExemploBD_02
{
    partial class Cadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbEscuridao = new System.Windows.Forms.GroupBox();
            this.rdbEscuridaoNao = new System.Windows.Forms.RadioButton();
            this.rdbEscuridaoSim = new System.Windows.Forms.RadioButton();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.lblNomePessoa = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.CheckBox();
            this.txtQuantidadedeFilmes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContaBancaria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHeroi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbEscuridao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(421, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 31);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(13, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 22);
            this.txtNome.TabIndex = 2;
            // 
            // gbEscuridao
            // 
            this.gbEscuridao.Controls.Add(this.rdbEscuridaoNao);
            this.gbEscuridao.Controls.Add(this.rdbEscuridaoSim);
            this.gbEscuridao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEscuridao.Location = new System.Drawing.Point(8, 63);
            this.gbEscuridao.Name = "gbEscuridao";
            this.gbEscuridao.Size = new System.Drawing.Size(163, 52);
            this.gbEscuridao.TabIndex = 3;
            this.gbEscuridao.TabStop = false;
            this.gbEscuridao.Text = "Escuridão";
            // 
            // rdbEscuridaoNao
            // 
            this.rdbEscuridaoNao.AutoSize = true;
            this.rdbEscuridaoNao.Location = new System.Drawing.Point(101, 22);
            this.rdbEscuridaoNao.Name = "rdbEscuridaoNao";
            this.rdbEscuridaoNao.Size = new System.Drawing.Size(55, 20);
            this.rdbEscuridaoNao.TabIndex = 1;
            this.rdbEscuridaoNao.TabStop = true;
            this.rdbEscuridaoNao.Text = "Não";
            this.rdbEscuridaoNao.UseVisualStyleBackColor = true;
            // 
            // rdbEscuridaoSim
            // 
            this.rdbEscuridaoSim.AutoSize = true;
            this.rdbEscuridaoSim.Location = new System.Drawing.Point(20, 22);
            this.rdbEscuridaoSim.Name = "rdbEscuridaoSim";
            this.rdbEscuridaoSim.Size = new System.Drawing.Size(52, 20);
            this.rdbEscuridaoSim.TabIndex = 0;
            this.rdbEscuridaoSim.TabStop = true;
            this.rdbEscuridaoSim.Text = "Sim";
            this.rdbEscuridaoSim.UseVisualStyleBackColor = true;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePessoa.Location = new System.Drawing.Point(13, 150);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(158, 22);
            this.txtNomePessoa.TabIndex = 5;
            // 
            // lblNomePessoa
            // 
            this.lblNomePessoa.AutoSize = true;
            this.lblNomePessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePessoa.Location = new System.Drawing.Point(9, 131);
            this.lblNomePessoa.Name = "lblNomePessoa";
            this.lblNomePessoa.Size = new System.Drawing.Size(124, 20);
            this.lblNomePessoa.TabIndex = 4;
            this.lblNomePessoa.Text = "Nome Pessoa:";
            // 
            // cbRaca
            // 
            this.cbRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(180, 36);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(158, 24);
            this.cbRaca.TabIndex = 6;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(176, 13);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(56, 20);
            this.lblRaca.TabIndex = 7;
            this.lblRaca.Text = "Raca:";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(253, 81);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(82, 24);
            this.cb.TabIndex = 8;
            this.cb.Text = "Mulher";
            this.cb.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadedeFilmes
            // 
            this.txtQuantidadedeFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadedeFilmes.Location = new System.Drawing.Point(13, 216);
            this.txtQuantidadedeFilmes.Name = "txtQuantidadedeFilmes";
            this.txtQuantidadedeFilmes.Size = new System.Drawing.Size(159, 22);
            this.txtQuantidadedeFilmes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantidade Filmes:";
            // 
            // txtContaBancaria
            // 
            this.txtContaBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaBancaria.Location = new System.Drawing.Point(177, 150);
            this.txtContaBancaria.Name = "txtContaBancaria";
            this.txtContaBancaria.Size = new System.Drawing.Size(158, 22);
            this.txtContaBancaria.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Conta Bancária";
            // 
            // dtHeroi
            // 
            this.dtHeroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHeroi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHeroi.Location = new System.Drawing.Point(182, 219);
            this.dtHeroi.Name = "dtHeroi";
            this.dtHeroi.Size = new System.Drawing.Size(159, 22);
            this.dtHeroi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Nascimento:";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.Location = new System.Drawing.Point(359, 59);
            this.rtbDescricao.Multiline = true;
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(171, 154);
            this.rtbDescricao.TabIndex = 15;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(355, 36);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 20);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descricao:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 312);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtHeroi);
            this.Controls.Add(this.txtContaBancaria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidadedeFilmes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.lblNomePessoa);
            this.Controls.Add(this.gbEscuridao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbEscuridao.ResumeLayout(false);
            this.gbEscuridao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbEscuridao;
        private System.Windows.Forms.RadioButton rdbEscuridaoNao;
        private System.Windows.Forms.RadioButton rdbEscuridaoSim;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.Label lblNomePessoa;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.TextBox txtQuantidadedeFilmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContaBancaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHeroi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rtbDescricao;
        private System.Windows.Forms.Label lblDescricao;
    }
}

