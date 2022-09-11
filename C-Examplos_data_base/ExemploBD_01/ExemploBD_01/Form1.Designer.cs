namespace ExemploBD_01
{
    partial class Form1
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
            this.lblNOme = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.rtxResultado = new System.Windows.Forms.RichTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblCores = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.cbCorAlterar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConsulta.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNOme
            // 
            this.lblNOme.AutoSize = true;
            this.lblNOme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOme.Location = new System.Drawing.Point(12, 30);
            this.lblNOme.Name = "lblNOme";
            this.lblNOme.Size = new System.Drawing.Size(37, 14);
            this.lblNOme.TabIndex = 0;
            this.lblNOme.Text = "Nome:";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(55, 27);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(117, 20);
            this.txtCor.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(97, 53);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.rtxResultado);
            this.grpConsulta.Controls.Add(this.btnAtualizar);
            this.grpConsulta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(204, 12);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(154, 346);
            this.grpConsulta.TabIndex = 4;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Resultado";
            // 
            // rtxResultado
            // 
            this.rtxResultado.Location = new System.Drawing.Point(6, 19);
            this.rtxResultado.Name = "rtxResultado";
            this.rtxResultado.Size = new System.Drawing.Size(142, 284);
            this.rtxResultado.TabIndex = 4;
            this.rtxResultado.Text = "";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(73, 310);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(55, 25);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(117, 21);
            this.cbCor.TabIndex = 5;
            this.cbCor.DropDown += new System.EventHandler(this.cbCor_DropDown);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(97, 52);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCores.Location = new System.Drawing.Point(13, 28);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(39, 14);
            this.lblCores.TabIndex = 7;
            this.lblCores.Text = "Cores:";
            this.lblCores.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.btnCadastrar);
            this.gbCadastro.Controls.Add(this.lblNOme);
            this.gbCadastro.Controls.Add(this.txtCor);
            this.gbCadastro.Location = new System.Drawing.Point(12, 12);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(186, 88);
            this.gbCadastro.TabIndex = 8;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastrar Cores";
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.btnApagar);
            this.gbDelete.Controls.Add(this.cbCor);
            this.gbDelete.Controls.Add(this.lblCores);
            this.gbDelete.Location = new System.Drawing.Point(12, 123);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(186, 86);
            this.gbDelete.TabIndex = 9;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Deletar Cores";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.label2);
            this.gbEditar.Controls.Add(this.btnAlterar);
            this.gbEditar.Controls.Add(this.txtNovoNome);
            this.gbEditar.Controls.Add(this.cbCorAlterar);
            this.gbEditar.Controls.Add(this.label1);
            this.gbEditar.Location = new System.Drawing.Point(12, 231);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(186, 127);
            this.gbEditar.TabIndex = 10;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar Cores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(97, 90);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNome.Location = new System.Drawing.Point(55, 64);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(117, 20);
            this.txtNovoNome.TabIndex = 4;
            // 
            // cbCorAlterar
            // 
            this.cbCorAlterar.FormattingEnabled = true;
            this.cbCorAlterar.Location = new System.Drawing.Point(55, 25);
            this.cbCorAlterar.Name = "cbCorAlterar";
            this.cbCorAlterar.Size = new System.Drawing.Size(117, 21);
            this.cbCorAlterar.TabIndex = 5;
            this.cbCorAlterar.DropDown += new System.EventHandler(this.cbCorAlterar_DropDown);
            this.cbCorAlterar.SelectedIndexChanged += new System.EventHandler(this.cbCorAlterar_SelectedIndexChanged);
            this.cbCorAlterar.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbCorAlterar_DragDrop);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 367);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.grpConsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpConsulta.ResumeLayout(false);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNOme;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.RichTextBox rtxResultado;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.ComboBox cbCorAlterar;
        private System.Windows.Forms.Label label1;
    }
}

