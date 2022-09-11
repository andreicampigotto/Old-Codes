namespace BibliotecaHbsis.View.Genero
{
	partial class frmMostraGenero
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostraGenero));
			this.dgvMostraGenero = new System.Windows.Forms.DataGridView();
			this.btDelete = new System.Windows.Forms.Button();
			this.btLixeira = new System.Windows.Forms.Button();
			this.btAdiciona = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMostraGenero)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMostraGenero
			// 
			this.dgvMostraGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMostraGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMostraGenero.Location = new System.Drawing.Point(0, 0);
			this.dgvMostraGenero.Name = "dgvMostraGenero";
			this.dgvMostraGenero.Size = new System.Drawing.Size(402, 253);
			this.dgvMostraGenero.TabIndex = 0;
			// 
			// btDelete
			// 
			this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
			this.btDelete.Location = new System.Drawing.Point(415, 53);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(36, 33);
			this.btDelete.TabIndex = 6;
			this.btDelete.UseVisualStyleBackColor = true;
			// 
			// btLixeira
			// 
			this.btLixeira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btLixeira.Image = ((System.Drawing.Image)(resources.GetObject("btLixeira.Image")));
			this.btLixeira.Location = new System.Drawing.Point(415, 219);
			this.btLixeira.Name = "btLixeira";
			this.btLixeira.Size = new System.Drawing.Size(36, 33);
			this.btLixeira.TabIndex = 5;
			this.btLixeira.UseVisualStyleBackColor = true;
			// 
			// btAdiciona
			// 
			this.btAdiciona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAdiciona.Image = ((System.Drawing.Image)(resources.GetObject("btAdiciona.Image")));
			this.btAdiciona.Location = new System.Drawing.Point(415, 12);
			this.btAdiciona.Name = "btAdiciona";
			this.btAdiciona.Size = new System.Drawing.Size(36, 35);
			this.btAdiciona.TabIndex = 4;
			this.btAdiciona.UseVisualStyleBackColor = true;
			// 
			// frmMostraGenero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 253);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btLixeira);
			this.Controls.Add(this.btAdiciona);
			this.Controls.Add(this.dgvMostraGenero);
			this.Name = "frmMostraGenero";
			this.Text = "frmMostraGenero";
			((System.ComponentModel.ISupportInitialize)(this.dgvMostraGenero)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMostraGenero;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Button btLixeira;
		private System.Windows.Forms.Button btAdiciona;
	}
}