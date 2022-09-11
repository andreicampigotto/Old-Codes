namespace BibliotecaHbsis.View.Autores
{
	partial class frmAdicionaAutores
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
			this.lbNome = new System.Windows.Forms.Label();
			this.lbDescricao = new System.Windows.Forms.Label();
			this.lbUsuarioLogado = new System.Windows.Forms.Label();
			this.lbDataAtual = new System.Windows.Forms.Label();
			this.lbDataInsercao = new System.Windows.Forms.Label();
			this.txNome = new System.Windows.Forms.TextBox();
			this.dtpInclusao = new System.Windows.Forms.DateTimePicker();
			this.taDescricao = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbNome
			// 
			this.lbNome.AutoSize = true;
			this.lbNome.Location = new System.Drawing.Point(32, 9);
			this.lbNome.Name = "lbNome";
			this.lbNome.Size = new System.Drawing.Size(38, 13);
			this.lbNome.TabIndex = 0;
			this.lbNome.Text = "Nome:";
			// 
			// lbDescricao
			// 
			this.lbDescricao.AutoSize = true;
			this.lbDescricao.Location = new System.Drawing.Point(12, 62);
			this.lbDescricao.Name = "lbDescricao";
			this.lbDescricao.Size = new System.Drawing.Size(58, 13);
			this.lbDescricao.TabIndex = 1;
			this.lbDescricao.Text = "Descrição:";
			// 
			// lbUsuarioLogado
			// 
			this.lbUsuarioLogado.AutoSize = true;
			this.lbUsuarioLogado.Location = new System.Drawing.Point(12, 216);
			this.lbUsuarioLogado.Name = "lbUsuarioLogado";
			this.lbUsuarioLogado.Size = new System.Drawing.Size(49, 13);
			this.lbUsuarioLogado.TabIndex = 2;
			this.lbUsuarioLogado.Text = "Usuário: ";
			// 
			// lbDataAtual
			// 
			this.lbDataAtual.AutoSize = true;
			this.lbDataAtual.Location = new System.Drawing.Point(180, 216);
			this.lbDataAtual.Name = "lbDataAtual";
			this.lbDataAtual.Size = new System.Drawing.Size(36, 13);
			this.lbDataAtual.TabIndex = 3;
			this.lbDataAtual.Text = "Data: ";
			// 
			// lbDataInsercao
			// 
			this.lbDataInsercao.AutoSize = true;
			this.lbDataInsercao.Location = new System.Drawing.Point(37, 39);
			this.lbDataInsercao.Name = "lbDataInsercao";
			this.lbDataInsercao.Size = new System.Drawing.Size(33, 13);
			this.lbDataInsercao.TabIndex = 4;
			this.lbDataInsercao.Text = "Data:";
			// 
			// txNome
			// 
			this.txNome.Location = new System.Drawing.Point(67, 6);
			this.txNome.Name = "txNome";
			this.txNome.Size = new System.Drawing.Size(217, 20);
			this.txNome.TabIndex = 5;
			// 
			// dtpInclusao
			// 
			this.dtpInclusao.Location = new System.Drawing.Point(67, 33);
			this.dtpInclusao.Name = "dtpInclusao";
			this.dtpInclusao.Size = new System.Drawing.Size(217, 20);
			this.dtpInclusao.TabIndex = 6;
			// 
			// taDescricao
			// 
			this.taDescricao.Location = new System.Drawing.Point(67, 59);
			this.taDescricao.Name = "taDescricao";
			this.taDescricao.Size = new System.Drawing.Size(217, 85);
			this.taDescricao.TabIndex = 7;
			this.taDescricao.Text = "";
			// 
			// frmAdicionaAutores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 238);
			this.Controls.Add(this.taDescricao);
			this.Controls.Add(this.dtpInclusao);
			this.Controls.Add(this.txNome);
			this.Controls.Add(this.lbDataInsercao);
			this.Controls.Add(this.lbDataAtual);
			this.Controls.Add(this.lbUsuarioLogado);
			this.Controls.Add(this.lbDescricao);
			this.Controls.Add(this.lbNome);
			this.Name = "frmAdicionaAutores";
			this.Text = "frmAutores";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbNome;
		private System.Windows.Forms.Label lbDescricao;
		private System.Windows.Forms.Label lbUsuarioLogado;
		private System.Windows.Forms.Label lbDataAtual;
		private System.Windows.Forms.Label lbDataInsercao;
		private System.Windows.Forms.TextBox txNome;
		private System.Windows.Forms.DateTimePicker dtpInclusao;
		private System.Windows.Forms.RichTextBox taDescricao;
	}
}