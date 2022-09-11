namespace BibliotecaHbsis.View.Autores
{
	partial class frmMotraAutores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotraAutores));
			this.dgvAutores = new System.Windows.Forms.DataGridView();
			this.btAdiciona = new System.Windows.Forms.Button();
			this.btLixeira = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAutores
			// 
			this.dgvAutores.AllowUserToAddRows = false;
			this.dgvAutores.AllowUserToDeleteRows = false;
			this.dgvAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAutores.Location = new System.Drawing.Point(-1, 0);
			this.dgvAutores.Name = "dgvAutores";
			this.dgvAutores.ReadOnly = true;
			this.dgvAutores.Size = new System.Drawing.Size(384, 270);
			this.dgvAutores.TabIndex = 0;
			// 
			// btAdiciona
			// 
			this.btAdiciona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAdiciona.Image = ((System.Drawing.Image)(resources.GetObject("btAdiciona.Image")));
			this.btAdiciona.Location = new System.Drawing.Point(389, 12);
			this.btAdiciona.Name = "btAdiciona";
			this.btAdiciona.Size = new System.Drawing.Size(35, 35);
			this.btAdiciona.TabIndex = 1;
			this.btAdiciona.UseVisualStyleBackColor = true;
			// 
			// btLixeira
			// 
			this.btLixeira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btLixeira.Image = ((System.Drawing.Image)(resources.GetObject("btLixeira.Image")));
			this.btLixeira.Location = new System.Drawing.Point(389, 224);
			this.btLixeira.Name = "btLixeira";
			this.btLixeira.Size = new System.Drawing.Size(35, 33);
			this.btLixeira.TabIndex = 2;
			this.btLixeira.UseVisualStyleBackColor = true;
			// 
			// btDelete
			// 
			this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
			this.btDelete.Location = new System.Drawing.Point(389, 53);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(35, 33);
			this.btDelete.TabIndex = 3;
			this.btDelete.UseVisualStyleBackColor = true;
			// 
			// frmMotraAutores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 269);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btLixeira);
			this.Controls.Add(this.btAdiciona);
			this.Controls.Add(this.dgvAutores);
			this.Name = "frmMotraAutores";
			this.Text = "MotraAutores";
			((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAutores;
		private System.Windows.Forms.Button btAdiciona;
		private System.Windows.Forms.Button btLixeira;
		private System.Windows.Forms.Button btDelete;
	}
}