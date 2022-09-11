namespace BibliotecaHbsis.View.Livro
{
	partial class frmAdicionaLivro
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
			this.taDescricao = new System.Windows.Forms.RichTextBox();
			this.dtpInclusao = new System.Windows.Forms.DateTimePicker();
			this.txNome = new System.Windows.Forms.TextBox();
			this.lbDataInsercao = new System.Windows.Forms.Label();
			this.lbDataAtual = new System.Windows.Forms.Label();
			this.lbUsuarioLogado = new System.Windows.Forms.Label();
			this.lbDescricao = new System.Windows.Forms.Label();
			this.lbNome = new System.Windows.Forms.Label();
			this.lbIsbn = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.lbGenero = new System.Windows.Forms.Label();
			this.cbGenero = new System.Windows.Forms.ComboBox();
			this.cbEditora = new System.Windows.Forms.ComboBox();
			this.lbEditora = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// taDescricao
			// 
			this.taDescricao.Location = new System.Drawing.Point(67, 91);
			this.taDescricao.Name = "taDescricao";
			this.taDescricao.Size = new System.Drawing.Size(217, 85);
			this.taDescricao.TabIndex = 15;
			this.taDescricao.Text = "";
			// 
			// dtpInclusao
			// 
			this.dtpInclusao.Location = new System.Drawing.Point(329, 12);
			this.dtpInclusao.Name = "dtpInclusao";
			this.dtpInclusao.Size = new System.Drawing.Size(217, 20);
			this.dtpInclusao.TabIndex = 14;
			// 
			// txNome
			// 
			this.txNome.Location = new System.Drawing.Point(67, 12);
			this.txNome.Name = "txNome";
			this.txNome.Size = new System.Drawing.Size(217, 20);
			this.txNome.TabIndex = 13;
			// 
			// lbDataInsercao
			// 
			this.lbDataInsercao.AutoSize = true;
			this.lbDataInsercao.Location = new System.Drawing.Point(300, 15);
			this.lbDataInsercao.Name = "lbDataInsercao";
			this.lbDataInsercao.Size = new System.Drawing.Size(33, 13);
			this.lbDataInsercao.TabIndex = 12;
			this.lbDataInsercao.Text = "Data:";
			// 
			// lbDataAtual
			// 
			this.lbDataAtual.AutoSize = true;
			this.lbDataAtual.Location = new System.Drawing.Point(455, 239);
			this.lbDataAtual.Name = "lbDataAtual";
			this.lbDataAtual.Size = new System.Drawing.Size(36, 13);
			this.lbDataAtual.TabIndex = 11;
			this.lbDataAtual.Text = "Data: ";
			// 
			// lbUsuarioLogado
			// 
			this.lbUsuarioLogado.AutoSize = true;
			this.lbUsuarioLogado.Location = new System.Drawing.Point(21, 239);
			this.lbUsuarioLogado.Name = "lbUsuarioLogado";
			this.lbUsuarioLogado.Size = new System.Drawing.Size(49, 13);
			this.lbUsuarioLogado.TabIndex = 10;
			this.lbUsuarioLogado.Text = "Usuário: ";
			// 
			// lbDescricao
			// 
			this.lbDescricao.AutoSize = true;
			this.lbDescricao.Location = new System.Drawing.Point(12, 97);
			this.lbDescricao.Name = "lbDescricao";
			this.lbDescricao.Size = new System.Drawing.Size(58, 13);
			this.lbDescricao.TabIndex = 9;
			this.lbDescricao.Text = "Descrição:";
			// 
			// lbNome
			// 
			this.lbNome.AutoSize = true;
			this.lbNome.Location = new System.Drawing.Point(32, 15);
			this.lbNome.Name = "lbNome";
			this.lbNome.Size = new System.Drawing.Size(38, 13);
			this.lbNome.TabIndex = 8;
			this.lbNome.Text = "Nome:";
			// 
			// lbIsbn
			// 
			this.lbIsbn.AutoSize = true;
			this.lbIsbn.Location = new System.Drawing.Point(35, 68);
			this.lbIsbn.Name = "lbIsbn";
			this.lbIsbn.Size = new System.Drawing.Size(35, 13);
			this.lbIsbn.TabIndex = 16;
			this.lbIsbn.Text = "ISBN:";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(67, 65);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(217, 20);
			this.maskedTextBox1.TabIndex = 17;
			// 
			// lbGenero
			// 
			this.lbGenero.AutoSize = true;
			this.lbGenero.Location = new System.Drawing.Point(25, 41);
			this.lbGenero.Name = "lbGenero";
			this.lbGenero.Size = new System.Drawing.Size(45, 13);
			this.lbGenero.TabIndex = 18;
			this.lbGenero.Text = "Gênero:";
			// 
			// cbGenero
			// 
			this.cbGenero.FormattingEnabled = true;
			this.cbGenero.Location = new System.Drawing.Point(67, 38);
			this.cbGenero.Name = "cbGenero";
			this.cbGenero.Size = new System.Drawing.Size(217, 21);
			this.cbGenero.TabIndex = 19;
			// 
			// cbEditora
			// 
			this.cbEditora.FormattingEnabled = true;
			this.cbEditora.Location = new System.Drawing.Point(329, 38);
			this.cbEditora.Name = "cbEditora";
			this.cbEditora.Size = new System.Drawing.Size(217, 21);
			this.cbEditora.TabIndex = 21;
			// 
			// lbEditora
			// 
			this.lbEditora.AutoSize = true;
			this.lbEditora.Location = new System.Drawing.Point(290, 41);
			this.lbEditora.Name = "lbEditora";
			this.lbEditora.Size = new System.Drawing.Size(43, 13);
			this.lbEditora.TabIndex = 20;
			this.lbEditora.Text = "Editora:";
			// 
			// frmAdicionaLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 271);
			this.Controls.Add(this.cbEditora);
			this.Controls.Add(this.lbEditora);
			this.Controls.Add(this.cbGenero);
			this.Controls.Add(this.lbGenero);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.lbIsbn);
			this.Controls.Add(this.taDescricao);
			this.Controls.Add(this.dtpInclusao);
			this.Controls.Add(this.txNome);
			this.Controls.Add(this.lbDataInsercao);
			this.Controls.Add(this.lbDataAtual);
			this.Controls.Add(this.lbUsuarioLogado);
			this.Controls.Add(this.lbDescricao);
			this.Controls.Add(this.lbNome);
			this.Name = "frmAdicionaLivro";
			this.Text = "frmAdicionaLivro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox taDescricao;
		private System.Windows.Forms.DateTimePicker dtpInclusao;
		private System.Windows.Forms.TextBox txNome;
		private System.Windows.Forms.Label lbDataInsercao;
		private System.Windows.Forms.Label lbDataAtual;
		private System.Windows.Forms.Label lbUsuarioLogado;
		private System.Windows.Forms.Label lbDescricao;
		private System.Windows.Forms.Label lbNome;
		private System.Windows.Forms.Label lbIsbn;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label lbGenero;
		private System.Windows.Forms.ComboBox cbGenero;
		private System.Windows.Forms.ComboBox cbEditora;
		private System.Windows.Forms.Label lbEditora;
	}
}