namespace BibliotecaHbsis.View.Locacoa
{
	partial class frmAdicionaLocacao
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
			this.lbLivro = new System.Windows.Forms.Label();
			this.lbUsuario = new System.Windows.Forms.Label();
			this.lbOperacao = new System.Windows.Forms.Label();
			this.lbDataDevolucao = new System.Windows.Forms.Label();
			this.cbLivros = new System.Windows.Forms.ComboBox();
			this.cbUsuarios = new System.Windows.Forms.ComboBox();
			this.cbTipo = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbUsuarioAtual = new System.Windows.Forms.Label();
			this.lbDataAtual = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbLivro
			// 
			this.lbLivro.AutoSize = true;
			this.lbLivro.Location = new System.Drawing.Point(279, 15);
			this.lbLivro.Name = "lbLivro";
			this.lbLivro.Size = new System.Drawing.Size(33, 13);
			this.lbLivro.TabIndex = 0;
			this.lbLivro.Text = "Livro:";
			// 
			// lbUsuario
			// 
			this.lbUsuario.AutoSize = true;
			this.lbUsuario.Location = new System.Drawing.Point(26, 15);
			this.lbUsuario.Name = "lbUsuario";
			this.lbUsuario.Size = new System.Drawing.Size(46, 13);
			this.lbUsuario.TabIndex = 1;
			this.lbUsuario.Text = "Usuário:";
			// 
			// lbOperacao
			// 
			this.lbOperacao.AutoSize = true;
			this.lbOperacao.Location = new System.Drawing.Point(12, 48);
			this.lbOperacao.Name = "lbOperacao";
			this.lbOperacao.Size = new System.Drawing.Size(60, 13);
			this.lbOperacao.TabIndex = 2;
			this.lbOperacao.Text = "Operação: ";
			// 
			// lbDataDevolucao
			// 
			this.lbDataDevolucao.AutoSize = true;
			this.lbDataDevolucao.Location = new System.Drawing.Point(224, 48);
			this.lbDataDevolucao.Name = "lbDataDevolucao";
			this.lbDataDevolucao.Size = new System.Drawing.Size(88, 13);
			this.lbDataDevolucao.TabIndex = 3;
			this.lbDataDevolucao.Text = "Data Devolução:";
			// 
			// cbLivros
			// 
			this.cbLivros.FormattingEnabled = true;
			this.cbLivros.Location = new System.Drawing.Point(308, 12);
			this.cbLivros.Name = "cbLivros";
			this.cbLivros.Size = new System.Drawing.Size(215, 21);
			this.cbLivros.TabIndex = 4;
			// 
			// cbUsuarios
			// 
			this.cbUsuarios.FormattingEnabled = true;
			this.cbUsuarios.Location = new System.Drawing.Point(68, 12);
			this.cbUsuarios.Name = "cbUsuarios";
			this.cbUsuarios.Size = new System.Drawing.Size(203, 21);
			this.cbUsuarios.TabIndex = 5;
			// 
			// cbTipo
			// 
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Location = new System.Drawing.Point(68, 45);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.Size = new System.Drawing.Size(150, 21);
			this.cbTipo.TabIndex = 6;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(308, 45);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// lbUsuarioAtual
			// 
			this.lbUsuarioAtual.AutoSize = true;
			this.lbUsuarioAtual.Location = new System.Drawing.Point(12, 159);
			this.lbUsuarioAtual.Name = "lbUsuarioAtual";
			this.lbUsuarioAtual.Size = new System.Drawing.Size(46, 13);
			this.lbUsuarioAtual.TabIndex = 8;
			this.lbUsuarioAtual.Text = "Usuário:";
			// 
			// lbDataAtual
			// 
			this.lbDataAtual.AutoSize = true;
			this.lbDataAtual.Location = new System.Drawing.Point(277, 159);
			this.lbDataAtual.Name = "lbDataAtual";
			this.lbDataAtual.Size = new System.Drawing.Size(33, 13);
			this.lbDataAtual.TabIndex = 9;
			this.lbDataAtual.Text = "Data:";
			// 
			// frmAdicionaLocacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 185);
			this.Controls.Add(this.lbDataAtual);
			this.Controls.Add(this.lbUsuarioAtual);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cbTipo);
			this.Controls.Add(this.cbUsuarios);
			this.Controls.Add(this.cbLivros);
			this.Controls.Add(this.lbDataDevolucao);
			this.Controls.Add(this.lbOperacao);
			this.Controls.Add(this.lbUsuario);
			this.Controls.Add(this.lbLivro);
			this.Name = "frmAdicionaLocacao";
			this.Text = "frmAdicionaLocacao";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbLivro;
		private System.Windows.Forms.Label lbUsuario;
		private System.Windows.Forms.Label lbOperacao;
		private System.Windows.Forms.Label lbDataDevolucao;
		private System.Windows.Forms.ComboBox cbLivros;
		private System.Windows.Forms.ComboBox cbUsuarios;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lbUsuarioAtual;
		private System.Windows.Forms.Label lbDataAtual;
	}
}