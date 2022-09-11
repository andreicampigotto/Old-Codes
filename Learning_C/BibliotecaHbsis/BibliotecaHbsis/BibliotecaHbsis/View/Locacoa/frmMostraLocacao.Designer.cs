namespace BibliotecaHbsis.View.Locacoa
{
	partial class frmMostraLocacao
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
			this.dgvLocacoes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocacoes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLocacoes
			// 
			this.dgvLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocacoes.Location = new System.Drawing.Point(-1, -1);
			this.dgvLocacoes.Name = "dgvLocacoes";
			this.dgvLocacoes.Size = new System.Drawing.Size(429, 278);
			this.dgvLocacoes.TabIndex = 0;
			// 
			// frmMostraLocacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 275);
			this.Controls.Add(this.dgvLocacoes);
			this.Name = "frmMostraLocacao";
			this.Text = "frmMostraLocacao";
			((System.ComponentModel.ISupportInitialize)(this.dgvLocacoes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvLocacoes;
	}
}