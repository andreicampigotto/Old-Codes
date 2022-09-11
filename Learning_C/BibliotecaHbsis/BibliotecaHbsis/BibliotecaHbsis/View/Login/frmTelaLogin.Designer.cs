namespace BibliotecaHbsis.View.Login
{
	partial class frmTelaLogin
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
			this.lbUsuario = new System.Windows.Forms.Label();
			this.lbSenha = new System.Windows.Forms.Label();
			this.lbHoraAtual = new System.Windows.Forms.Label();
			this.txUsuario = new System.Windows.Forms.TextBox();
			this.txSenha = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbUsuario
			// 
			this.lbUsuario.AutoSize = true;
			this.lbUsuario.Location = new System.Drawing.Point(12, 23);
			this.lbUsuario.Name = "lbUsuario";
			this.lbUsuario.Size = new System.Drawing.Size(46, 13);
			this.lbUsuario.TabIndex = 0;
			this.lbUsuario.Text = "Usuário:";
			// 
			// lbSenha
			// 
			this.lbSenha.AutoSize = true;
			this.lbSenha.Location = new System.Drawing.Point(17, 49);
			this.lbSenha.Name = "lbSenha";
			this.lbSenha.Size = new System.Drawing.Size(41, 13);
			this.lbSenha.TabIndex = 1;
			this.lbSenha.Text = "Senha:";
			// 
			// lbHoraAtual
			// 
			this.lbHoraAtual.AutoSize = true;
			this.lbHoraAtual.Location = new System.Drawing.Point(25, 110);
			this.lbHoraAtual.Name = "lbHoraAtual";
			this.lbHoraAtual.Size = new System.Drawing.Size(33, 13);
			this.lbHoraAtual.TabIndex = 2;
			this.lbHoraAtual.Text = "Data:";
			// 
			// txUsuario
			// 
			this.txUsuario.Location = new System.Drawing.Point(55, 20);
			this.txUsuario.Name = "txUsuario";
			this.txUsuario.Size = new System.Drawing.Size(173, 20);
			this.txUsuario.TabIndex = 3;
			// 
			// txSenha
			// 
			this.txSenha.Location = new System.Drawing.Point(55, 46);
			this.txSenha.Name = "txSenha";
			this.txSenha.Size = new System.Drawing.Size(173, 20);
			this.txSenha.TabIndex = 4;
			// 
			// frmTelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 132);
			this.Controls.Add(this.txSenha);
			this.Controls.Add(this.txUsuario);
			this.Controls.Add(this.lbHoraAtual);
			this.Controls.Add(this.lbSenha);
			this.Controls.Add(this.lbUsuario);
			this.Name = "frmTelaLogin";
			this.Text = "frmTelaLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbUsuario;
		private System.Windows.Forms.Label lbSenha;
		private System.Windows.Forms.Label lbHoraAtual;
		private System.Windows.Forms.TextBox txUsuario;
		private System.Windows.Forms.TextBox txSenha;
	}
}