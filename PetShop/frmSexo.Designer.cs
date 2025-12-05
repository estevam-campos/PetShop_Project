namespace PetShop
{
    partial class frmSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSexo));
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpDados.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(7, 66);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(360, 215);
            this.grpLista.TabIndex = 37;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Sexos Cadastrados";
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.AllowUserToResizeColumns = false;
            this.grdDados.AllowUserToResizeRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(6, 19);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersVisible = false;
            this.grdDados.RowHeadersWidth = 62;
            this.grdDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(342, 190);
            this.grdDados.TabIndex = 0;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(6, 26);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 19;
            this.lblSexo.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(43, 23);
            this.txtSexo.MaxLength = 100;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(305, 20);
            this.txtSexo.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 25);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(71, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar por";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.lblSexo);
            this.grpDados.Controls.Add(this.txtSexo);
            this.grpDados.Location = new System.Drawing.Point(7, 287);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(360, 56);
            this.grpDados.TabIndex = 38;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.lblPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(7, 7);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(360, 53);
            this.grpPesquisa.TabIndex = 36;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados para Pesquisa";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PetShop.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(7, 350);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 41);
            this.btnGravar.TabIndex = 39;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::PetShop.Properties.Resources.eraser;
            this.btnLimpar.Location = new System.Drawing.Point(129, 350);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 40;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PetShop.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(251, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 400);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Cadastro de Sexo";
            this.Load += new System.EventHandler(this.frmSexo_Load);
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpPesquisa;
    }
}